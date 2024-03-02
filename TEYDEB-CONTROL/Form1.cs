using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TEYDEBCONTROL 
{
    public partial class Form1 : Form
    {
        private Thread threadModbusManager = null; // Thread for managing tcp ip connection with tcp ip server.

        private Data data = new Data();

        private ProductionMonitorData productionMonitorData = new ProductionMonitorData();

        private DateTime lastDateTime = DateTime.Now;

        bool dataAvailable = false;

        int saniyeTimerCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
               njCompolet1.WriteVariable("connectionStart", true);
               if(Convert.ToBoolean (njCompolet1.ReadVariable("connectionStart")))
                {
                    textBoxStatus.BackColor = Color.Green;
                    textBoxStatus.Text = "PLC ile Bağlantı Başarılı";
                }
               else
                {
                    textBoxStatus.BackColor = Color.Red;
                    textBoxStatus.Text = "PLC Bağlantı Hatası";
                    Stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            njCompolet1.WriteVariable("connectionStart", false);
            Stop();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            try
            {
                Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Stop()
        {
            if (threadModbusManager != null)
            {
                threadModbusManager.Abort();
            }

            StopProduction();

            timer1.Stop();

            productionMonitorData = new ProductionMonitorData();
        }

        public void StopProduction()
        {
            njCompolet1.WriteVariable("productionStop", true);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                if(!Convert.ToBoolean(njCompolet1.ReadVariable("connectionStart")))
                {
                    njCompolet1.WriteVariable("connectionStart", true);
                    textBoxStatus.BackColor = Color.Green;
                    textBoxStatus.Text = "PLC ile Bağlantı Başarılı";
                }
                SetProduction(textBoxSelectedProductCode.Text, int.Parse(textBoxSelectedProductAmount.Text));
                StartProduction();
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SetProduction(string productCode, int amount)
        {     
            njCompolet1.WriteVariable("productCodeLenght", productCode.Length);
            njCompolet1.WriteVariable("productCode", productCode);   
            njCompolet1.WriteVariable("productAmount", amount);
        }

        public void StartProduction()
        {
            njCompolet1.WriteVariable("productionStart", true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniyeTimerCounter++;
            if (saniyeTimerCounter == 1)
            {
                saniyeTimerCounter = 0;
                threadModbusManager = new Thread(threadModbusManagerFunction);
                threadModbusManager.Start();
            }
        }

        private void threadModbusManagerFunction()
        {
            if (threadModbusManager != null)
            {
                if (Convert.ToBoolean(njCompolet1.ReadVariable("connectionStart")))
                {
                    try
                    {
                        this.Invoke(new Action(delegate ()
                        {

                            ReadData();
                            ReadProductionMonitorData();

                            textBoxDataAvailable.Text = Convert.ToString(dataAvailable);
                             
                            textBoxOKAmount.Text = ProductionMonitorData.OKAmount.ToString();
                            textBoxNOKAmount.Text = ProductionMonitorData.NOKAmount.ToString();
                        }));

                    }
                    catch
                    {
                        MessageBox.Show("Thread Fonksiyonu İçinde ReadData Hatası");
                        Stop();
                    }

                    try
                    {
                        if (dataAvailable)
                        {
                            Data d = GetData();
                            this.Invoke(new Action(delegate ()
                            {
                                textBoxDateTime.Text = d.DateTime.ToString();
                                textBoxProductCode.Text = d.ProductCode;
                                textBoxProductID.Text = d.ProductID;
                                textBoxTemperature.Text = d.Temperature.ToString("0.0000");
                                textBoxHumudity.Text = d.Humudity.ToString("0.0000");
                                textBoxForce.Text = d.Force.ToString("0.0000");
                               // textBoxResult.Text = d.Result.ToString();
                            }));
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Thread Fonksiyonu İçinde GetData Hatası");
                        Stop();
                    }
                }
                else
                {
                    // njCompolet1.WriteVariable("connectionStart", true);
                    this.Invoke(new Action(delegate ()
                    {
                       // Stop();
                        textBoxStatus.Text = "PLC Bağlantı Hatası";
                        textBoxStatus.BackColor = Color.Red;
                      //  MessageBox.Show("Thread Fonksiyonu İçinde PLC Bağlantı Hatası");
                    }));

                }
            }
        }

        private void ReadData()
        {
            bool available = ReadDataAvailable();

            Data d = new Data();
            if (available)
            {
                try
                {
                    d.ProductCode = Convert.ToString(njCompolet1.ReadVariable("productCode"));

                    int temp1 = Convert.ToInt32(njCompolet1.ReadVariable("productIdYear"));
                    string yearStr = temp1.ToString("D4");

                    int temp2 = Convert.ToInt32(njCompolet1.ReadVariable("productIdMonth"));
                    string monthStr = temp2.ToString("D2");

                    int temp3 = Convert.ToInt32(njCompolet1.ReadVariable("productIdDay"));
                    string dayStr = temp3.ToString("D2");

                    int temp4 = Convert.ToInt32(njCompolet1.ReadVariable("productIdCounter"));
                    string counterStr = temp4.ToString("D5");

                    d.ProductID = yearStr + monthStr + dayStr + counterStr;

                    double temp5 = Convert.ToDouble(njCompolet1.ReadVariable("productIdTemp"));
                    d.Temperature = temp5;

                    double temp6 = Convert.ToDouble(njCompolet1.ReadVariable("productIdHum"));
                    d.Humudity = temp6;

                    double temp7 = Convert.ToDouble(njCompolet1.ReadVariable("productIdForce"));
                    d.Force = temp7;

                    d.DateTime = DateTime.Now;

                    data = d;
                }
                catch
                {
                    MessageBox.Show("ReadData Hatası");
                    Stop();
                }

                dataAvailable = true;

                ResetDataAvailable();
            }

            bool temp8 = Convert.ToBoolean(njCompolet1.ReadVariable("productResult"));
            d.Result = temp8; 
            textBoxResult.Text = d.Result.ToString();
            if(temp8 == true)
            {
               njCompolet1.WriteVariable("productOk",0);
            }
        }

        private bool ReadDataAvailable()
        {
            try
            {
                return Convert.ToBoolean(njCompolet1.ReadVariable("productAvailable"));
            }
            catch
            {
                MessageBox.Show("ReadDataAvailable Hatası");
                Stop();
            }
            return true;
        }

        private void ReadProductionMonitorData()
        {
            try
            {
                int data1 = Convert.ToInt32(njCompolet1.ReadVariable("productOk"));
                int data2 = Convert.ToInt32(njCompolet1.ReadVariable("productNok"));

                productionMonitorData.OKAmount = data1;
                productionMonitorData.NOKAmount = data2;
            }
            catch
            {
                MessageBox.Show("ReadProductionMonitorData Hatası");
                Stop();
            }
        }

        private void ResetDataAvailable()
        {
            try
            {
                njCompolet1.WriteVariable("productAvailable", false);
            }
            catch
            {
                MessageBox.Show("ResetDataAvailable Hatası");
                Stop();
            }
        }

        public Data GetData()
        {
            Data d = new Data();

            if (dataAvailable)
            {
                d = data;
                dataAvailable = false;
            }
            return d;
        }

        /****************************************************************************************************/
        public ProductionMonitorData ProductionMonitorData
        {
            get
            {
                return productionMonitorData;
            }
        }
    }


    public class ProductionMonitorData
    {
        private bool error;

        public bool Error
        {
            get { return error; }
            set { error = value; }
        }

        private bool started;

        public bool Started
        {
            get { return started; }
            set { started = value; }
        }

        private bool stopped;

        public bool Stopped
        {
            get { return stopped; }
            set { stopped = value; }
        }

        private bool canceled;

        public bool Canceled
        {
            get { return canceled; }
            set { canceled = value; }
        }

        private bool finished;

        public bool Finished
        {
            get { return finished; }
            set { finished = value; }
        }

        private int oKAmount;

        public int OKAmount
        {
            get { return oKAmount; }
            set { oKAmount = value; }
        }

        private int nOKAmount;

        public int NOKAmount
        {
            get { return nOKAmount; }
            set { nOKAmount = value; }
        }
    }

    public class Data
    {
        private DateTime dateTime;

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        private string productCode;

        public string ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }

        private string productID;

        public string ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        private double temperature;

        public double Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        private double humudity;

        public double Humudity
        {
            get { return humudity; }
            set { humudity = value; }
        }

        private double force;

        public double Force
        {
            get { return force; }
            set { force = value; }
        }

        private bool result;

        public bool Result
        {
            get { return result; }
            set { result = value; }
        }
    }
}

