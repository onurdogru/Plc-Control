namespace TEYDEBCONTROL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.njCompolet1 = new OMRON.Compolet.CIP.NJCompolet(this.components);
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxNOKAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxOKAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSelectedProductAmount = new System.Windows.Forms.TextBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSelectedProductCode = new System.Windows.Forms.TextBox();
            this.DataAvailable = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDataAvailable = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxForce = new System.Windows.Forms.TextBox();
            this.textBoxHumudity = new System.Windows.Forms.TextBox();
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.textBoxProductCode = new System.Windows.Forms.TextBox();
            this.textBoxDateTime = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // njCompolet1
            // 
            this.njCompolet1.Active = true;
            this.njCompolet1.ConnectionType = OMRON.Compolet.CIP.ConnectionType.UCMM;
            this.njCompolet1.DontFragment = false;
            this.njCompolet1.HeartBeatTimer = 0;
            this.njCompolet1.LocalPort = 2;
            this.njCompolet1.PeerAddress = "192.168.250.1";
            this.njCompolet1.ReceiveTimeLimit = ((long)(750));
            this.njCompolet1.RoutePath = "";
            this.njCompolet1.UseRoutePath = false;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(94, 92);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(120, 20);
            this.textBoxStatus.TabIndex = 88;
            this.textBoxStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 13);
            this.label19.TabIndex = 87;
            this.label19.Text = "Status";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(94, 62);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(120, 20);
            this.textBoxPort.TabIndex = 75;
            this.textBoxPort.Text = "502";
            this.textBoxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 74;
            this.label14.Text = "Port";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(94, 32);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(120, 20);
            this.textBoxIP.TabIndex = 73;
            this.textBoxIP.Text = "192.168.250.1";
            this.textBoxIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 13);
            this.label13.TabIndex = 72;
            this.label13.Text = "IP";
            // 
            // textBoxNOKAmount
            // 
            this.textBoxNOKAmount.Location = new System.Drawing.Point(328, 167);
            this.textBoxNOKAmount.Name = "textBoxNOKAmount";
            this.textBoxNOKAmount.Size = new System.Drawing.Size(120, 20);
            this.textBoxNOKAmount.TabIndex = 71;
            this.textBoxNOKAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(248, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 70;
            this.label12.Text = "Hatalı Ürün S.";
            // 
            // textBoxOKAmount
            // 
            this.textBoxOKAmount.Location = new System.Drawing.Point(328, 130);
            this.textBoxOKAmount.Name = "textBoxOKAmount";
            this.textBoxOKAmount.Size = new System.Drawing.Size(120, 20);
            this.textBoxOKAmount.TabIndex = 69;
            this.textBoxOKAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(248, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Başarılı Ürün S.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "Amount";
            // 
            // textBoxSelectedProductAmount
            // 
            this.textBoxSelectedProductAmount.Location = new System.Drawing.Point(94, 162);
            this.textBoxSelectedProductAmount.Name = "textBoxSelectedProductAmount";
            this.textBoxSelectedProductAmount.Size = new System.Drawing.Size(120, 20);
            this.textBoxSelectedProductAmount.TabIndex = 66;
            this.textBoxSelectedProductAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(224, 161);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(70, 23);
            this.buttonStop.TabIndex = 65;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(224, 131);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(70, 23);
            this.buttonStart.TabIndex = 64;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "ProductCode";
            // 
            // textBoxSelectedProductCode
            // 
            this.textBoxSelectedProductCode.Location = new System.Drawing.Point(94, 132);
            this.textBoxSelectedProductCode.Name = "textBoxSelectedProductCode";
            this.textBoxSelectedProductCode.Size = new System.Drawing.Size(120, 20);
            this.textBoxSelectedProductCode.TabIndex = 62;
            this.textBoxSelectedProductCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataAvailable
            // 
            this.DataAvailable.AutoSize = true;
            this.DataAvailable.ForeColor = System.Drawing.Color.Green;
            this.DataAvailable.Location = new System.Drawing.Point(248, 95);
            this.DataAvailable.Name = "DataAvailable";
            this.DataAvailable.Size = new System.Drawing.Size(76, 13);
            this.DataAvailable.TabIndex = 61;
            this.DataAvailable.Text = "Data Available";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(248, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(29, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Force";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(29, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Humudity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(29, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(29, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "ProductID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(248, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "ProductCode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "DateTime";
            // 
            // textBoxDataAvailable
            // 
            this.textBoxDataAvailable.Location = new System.Drawing.Point(328, 93);
            this.textBoxDataAvailable.Name = "textBoxDataAvailable";
            this.textBoxDataAvailable.Size = new System.Drawing.Size(120, 20);
            this.textBoxDataAvailable.TabIndex = 53;
            this.textBoxDataAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(328, 56);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(120, 20);
            this.textBoxResult.TabIndex = 52;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxForce
            // 
            this.textBoxForce.Location = new System.Drawing.Point(109, 167);
            this.textBoxForce.Name = "textBoxForce";
            this.textBoxForce.Size = new System.Drawing.Size(120, 20);
            this.textBoxForce.TabIndex = 51;
            this.textBoxForce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHumudity
            // 
            this.textBoxHumudity.Location = new System.Drawing.Point(109, 130);
            this.textBoxHumudity.Name = "textBoxHumudity";
            this.textBoxHumudity.Size = new System.Drawing.Size(120, 20);
            this.textBoxHumudity.TabIndex = 50;
            this.textBoxHumudity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTemperature
            // 
            this.textBoxTemperature.Location = new System.Drawing.Point(109, 93);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.Size = new System.Drawing.Size(120, 20);
            this.textBoxTemperature.TabIndex = 49;
            this.textBoxTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Location = new System.Drawing.Point(109, 56);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(120, 20);
            this.textBoxProductID.TabIndex = 48;
            this.textBoxProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxProductCode
            // 
            this.textBoxProductCode.Location = new System.Drawing.Point(328, 19);
            this.textBoxProductCode.Name = "textBoxProductCode";
            this.textBoxProductCode.Size = new System.Drawing.Size(120, 20);
            this.textBoxProductCode.TabIndex = 47;
            this.textBoxProductCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDateTime
            // 
            this.textBoxDateTime.Location = new System.Drawing.Point(109, 19);
            this.textBoxDateTime.Name = "textBoxDateTime";
            this.textBoxDateTime.Size = new System.Drawing.Size(120, 20);
            this.textBoxDateTime.TabIndex = 46;
            this.textBoxDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxIP);
            this.groupBox1.Controls.Add(this.textBoxStatus);
            this.groupBox1.Controls.Add(this.textBoxSelectedProductCode);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxPort);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.buttonStop);
            this.groupBox1.Controls.Add(this.textBoxSelectedProductAmount);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 198);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontrol";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxDateTime);
            this.groupBox2.Controls.Add(this.textBoxProductCode);
            this.groupBox2.Controls.Add(this.DataAvailable);
            this.groupBox2.Controls.Add(this.textBoxProductID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxTemperature);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxHumudity);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxForce);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxResult);
            this.groupBox2.Controls.Add(this.textBoxNOKAmount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBoxDataAvailable);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxOKAmount);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(363, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 198);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Takip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(838, 228);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TEYDEB-1511";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private OMRON.Compolet.CIP.NJCompolet njCompolet1;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxNOKAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxOKAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSelectedProductAmount;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSelectedProductCode;
        private System.Windows.Forms.Label DataAvailable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDataAvailable;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxForce;
        private System.Windows.Forms.TextBox textBoxHumudity;
        private System.Windows.Forms.TextBox textBoxTemperature;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.TextBox textBoxProductCode;
        private System.Windows.Forms.TextBox textBoxDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

