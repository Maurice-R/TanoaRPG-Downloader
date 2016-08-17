namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelTRPGMP = new System.Windows.Forms.Label();
            this.labelT1 = new System.Windows.Forms.Label();
            this.labelT2 = new System.Windows.Forms.Label();
            this.labelT3 = new System.Windows.Forms.Label();
            this.labelNVersion = new System.Windows.Forms.Label();
            this.labelAKVersion = new System.Windows.Forms.Label();
            this.labelDLServer = new System.Windows.Forms.Label();
            this.labelSV = new System.Windows.Forms.Label();
            this.labelDF = new System.Windows.Forms.Label();
            this.labelDLT = new System.Windows.Forms.Label();
            this.labelCL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(148, 196);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(75, 23);
            this.button_1.TabIndex = 0;
            this.button_1.Text = "Download";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 252);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(343, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(159, 236);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(0, 13);
            this.labelSpeed.TabIndex = 5;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(67, 159);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(0, 13);
            this.labelVersion.TabIndex = 6;
            // 
            // labelTRPGMP
            // 
            this.labelTRPGMP.AutoSize = true;
            this.labelTRPGMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTRPGMP.Location = new System.Drawing.Point(12, 9);
            this.labelTRPGMP.Name = "labelTRPGMP";
            this.labelTRPGMP.Size = new System.Drawing.Size(336, 25);
            this.labelTRPGMP.TabIndex = 7;
            this.labelTRPGMP.Text = "TanoaRPG Missionsdatei Preload";
            // 
            // labelT1
            // 
            this.labelT1.AutoSize = true;
            this.labelT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT1.Location = new System.Drawing.Point(38, 34);
            this.labelT1.Name = "labelT1";
            this.labelT1.Size = new System.Drawing.Size(310, 13);
            this.labelT1.TabIndex = 8;
            this.labelT1.Text = "Hier kannst du das neueste Update bereits vorab herunterladen.";
            // 
            // labelT2
            // 
            this.labelT2.AutoSize = true;
            this.labelT2.Location = new System.Drawing.Point(14, 56);
            this.labelT2.Name = "labelT2";
            this.labelT2.Size = new System.Drawing.Size(346, 13);
            this.labelT2.TabIndex = 9;
            this.labelT2.Text = "Vorteil: Schneller spielen durch maximale Downloadgeschwindigkeit und";
            // 
            // labelT3
            // 
            this.labelT3.AutoSize = true;
            this.labelT3.Location = new System.Drawing.Point(126, 78);
            this.labelT3.Name = "labelT3";
            this.labelT3.Size = new System.Drawing.Size(122, 13);
            this.labelT3.TabIndex = 10;
            this.labelT3.Text = " Entlastung des Servers.";
            // 
            // labelNVersion
            // 
            this.labelNVersion.AutoSize = true;
            this.labelNVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelNVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNVersion.ForeColor = System.Drawing.Color.Black;
            this.labelNVersion.Location = new System.Drawing.Point(116, 98);
            this.labelNVersion.Name = "labelNVersion";
            this.labelNVersion.Size = new System.Drawing.Size(0, 13);
            this.labelNVersion.TabIndex = 11;
            // 
            // labelAKVersion
            // 
            this.labelAKVersion.AutoSize = true;
            this.labelAKVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelAKVersion.Location = new System.Drawing.Point(207, 146);
            this.labelAKVersion.Name = "labelAKVersion";
            this.labelAKVersion.Size = new System.Drawing.Size(0, 13);
            this.labelAKVersion.TabIndex = 12;
            // 
            // labelDLServer
            // 
            this.labelDLServer.AutoSize = true;
            this.labelDLServer.Location = new System.Drawing.Point(93, 278);
            this.labelDLServer.Name = "labelDLServer";
            this.labelDLServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDLServer.Size = new System.Drawing.Size(0, 13);
            this.labelDLServer.TabIndex = 13;
            // 
            // labelSV
            // 
            this.labelSV.AutoSize = true;
            this.labelSV.BackColor = System.Drawing.Color.Transparent;
            this.labelSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSV.ForeColor = System.Drawing.Color.Black;
            this.labelSV.Location = new System.Drawing.Point(93, 175);
            this.labelSV.Name = "labelSV";
            this.labelSV.Size = new System.Drawing.Size(0, 13);
            this.labelSV.TabIndex = 14;
            // 
            // labelDF
            // 
            this.labelDF.AutoSize = true;
            this.labelDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDF.Location = new System.Drawing.Point(93, 234);
            this.labelDF.Name = "labelDF";
            this.labelDF.Size = new System.Drawing.Size(0, 17);
            this.labelDF.TabIndex = 15;
            // 
            // labelDLT
            // 
            this.labelDLT.AutoSize = true;
            this.labelDLT.Location = new System.Drawing.Point(235, 236);
            this.labelDLT.Name = "labelDLT";
            this.labelDLT.Size = new System.Drawing.Size(0, 13);
            this.labelDLT.TabIndex = 16;
            // 
            // labelCL
            // 
            this.labelCL.AutoSize = true;
            this.labelCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCL.Location = new System.Drawing.Point(155, 115);
            this.labelCL.Name = "labelCL";
            this.labelCL.Size = new System.Drawing.Size(0, 13);
            this.labelCL.TabIndex = 17;
            this.labelCL.Click += new System.EventHandler(this.labelCL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(376, 298);
            this.Controls.Add(this.labelCL);
            this.Controls.Add(this.labelDLT);
            this.Controls.Add(this.labelDF);
            this.Controls.Add(this.labelSV);
            this.Controls.Add(this.labelDLServer);
            this.Controls.Add(this.labelAKVersion);
            this.Controls.Add(this.labelNVersion);
            this.Controls.Add(this.labelT3);
            this.Controls.Add(this.labelT2);
            this.Controls.Add(this.labelT1);
            this.Controls.Add(this.labelTRPGMP);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TanoaRPG Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelTRPGMP;
        private System.Windows.Forms.Label labelT1;
        private System.Windows.Forms.Label labelT2;
        private System.Windows.Forms.Label labelT3;
        private System.Windows.Forms.Label labelNVersion;
        private System.Windows.Forms.Label labelAKVersion;
        private System.Windows.Forms.Label labelDLServer;
        private System.Windows.Forms.Label labelSV;
        private System.Windows.Forms.Label labelDF;
        private System.Windows.Forms.Label labelDLT;
        private System.Windows.Forms.Label labelCL;
    }
}

