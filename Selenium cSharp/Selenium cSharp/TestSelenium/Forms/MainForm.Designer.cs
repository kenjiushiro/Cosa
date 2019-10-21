namespace Forms
{
    partial class chromedriverSelector
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtChromedriverPath = new System.Windows.Forms.TextBox();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnFileParameters = new System.Windows.Forms.Button();
            this.btnDriverVersion = new System.Windows.Forms.Button();
            this.btnRunBot = new System.Windows.Forms.Button();
            this.btnThreadState = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnBmf = new System.Windows.Forms.Button();
            this.btnAlertAccept = new System.Windows.Forms.Button();
            this.btnAlertDismiss = new System.Windows.Forms.Button();
            this.btnAlertRead = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(346, 34);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(139, 20);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select folder";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtChromedriverPath
            // 
            this.txtChromedriverPath.Location = new System.Drawing.Point(12, 35);
            this.txtChromedriverPath.Name = "txtChromedriverPath";
            this.txtChromedriverPath.ReadOnly = true;
            this.txtChromedriverPath.Size = new System.Drawing.Size(324, 20);
            this.txtChromedriverPath.TabIndex = 1;
            this.txtChromedriverPath.TextChanged += new System.EventHandler(this.TxtValor_TextChanged);
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Location = new System.Drawing.Point(9, 9);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(141, 13);
            this.lblInstrucciones.TabIndex = 2;
            this.lblInstrucciones.Text = "Select chromedriver location";
            this.lblInstrucciones.Click += new System.EventHandler(this.LblInstrucciones_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(21, 319);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(139, 20);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Save";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(183, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 20);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txtInputFile
            // 
            this.txtInputFile.Location = new System.Drawing.Point(12, 61);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.ReadOnly = true;
            this.txtInputFile.Size = new System.Drawing.Size(324, 20);
            this.txtInputFile.TabIndex = 6;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(346, 61);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(139, 20);
            this.btnSelectFile.TabIndex = 7;
            this.btnSelectFile.Text = "Select file";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // btnFileParameters
            // 
            this.btnFileParameters.Location = new System.Drawing.Point(491, 61);
            this.btnFileParameters.Name = "btnFileParameters";
            this.btnFileParameters.Size = new System.Drawing.Size(139, 20);
            this.btnFileParameters.TabIndex = 8;
            this.btnFileParameters.Text = "File Parameters";
            this.btnFileParameters.UseVisualStyleBackColor = true;
            this.btnFileParameters.Click += new System.EventHandler(this.BtnFileParameters_Click);
            // 
            // btnDriverVersion
            // 
            this.btnDriverVersion.Location = new System.Drawing.Point(491, 35);
            this.btnDriverVersion.Name = "btnDriverVersion";
            this.btnDriverVersion.Size = new System.Drawing.Size(139, 20);
            this.btnDriverVersion.TabIndex = 9;
            this.btnDriverVersion.Text = "Version";
            this.btnDriverVersion.UseVisualStyleBackColor = true;
            this.btnDriverVersion.Click += new System.EventHandler(this.BtnDriverVersion_Click);
            // 
            // btnRunBot
            // 
            this.btnRunBot.Location = new System.Drawing.Point(343, 319);
            this.btnRunBot.Name = "btnRunBot";
            this.btnRunBot.Size = new System.Drawing.Size(139, 20);
            this.btnRunBot.TabIndex = 11;
            this.btnRunBot.Text = "Run bot";
            this.btnRunBot.UseVisualStyleBackColor = true;
            this.btnRunBot.Click += new System.EventHandler(this.BtnRunBot_Click);
            // 
            // btnThreadState
            // 
            this.btnThreadState.Location = new System.Drawing.Point(491, 176);
            this.btnThreadState.Name = "btnThreadState";
            this.btnThreadState.Size = new System.Drawing.Size(139, 20);
            this.btnThreadState.TabIndex = 12;
            this.btnThreadState.Text = "Thread state";
            this.btnThreadState.UseVisualStyleBackColor = true;
            this.btnThreadState.Click += new System.EventHandler(this.BtnThreadState_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(491, 118);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(139, 20);
            this.btnPause.TabIndex = 13;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(491, 150);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(139, 20);
            this.btnResume.TabIndex = 14;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.BtnResume_Click);
            // 
            // btnBmf
            // 
            this.btnBmf.Location = new System.Drawing.Point(491, 319);
            this.btnBmf.Name = "btnBmf";
            this.btnBmf.Size = new System.Drawing.Size(139, 20);
            this.btnBmf.TabIndex = 15;
            this.btnBmf.Text = "BMF";
            this.btnBmf.UseVisualStyleBackColor = true;
            this.btnBmf.Click += new System.EventHandler(this.BtnBmf_Click);
            // 
            // btnAlertAccept
            // 
            this.btnAlertAccept.Location = new System.Drawing.Point(21, 115);
            this.btnAlertAccept.Name = "btnAlertAccept";
            this.btnAlertAccept.Size = new System.Drawing.Size(139, 20);
            this.btnAlertAccept.TabIndex = 16;
            this.btnAlertAccept.Text = "Accept alert";
            this.btnAlertAccept.UseVisualStyleBackColor = true;
            this.btnAlertAccept.Click += new System.EventHandler(this.BtnAlertAccept_Click);
            // 
            // btnAlertDismiss
            // 
            this.btnAlertDismiss.Location = new System.Drawing.Point(21, 141);
            this.btnAlertDismiss.Name = "btnAlertDismiss";
            this.btnAlertDismiss.Size = new System.Drawing.Size(139, 20);
            this.btnAlertDismiss.TabIndex = 17;
            this.btnAlertDismiss.Text = "Dismiss alert";
            this.btnAlertDismiss.UseVisualStyleBackColor = true;
            this.btnAlertDismiss.Click += new System.EventHandler(this.BtnAlertDismiss_Click);
            // 
            // btnAlertRead
            // 
            this.btnAlertRead.Location = new System.Drawing.Point(21, 167);
            this.btnAlertRead.Name = "btnAlertRead";
            this.btnAlertRead.Size = new System.Drawing.Size(139, 20);
            this.btnAlertRead.TabIndex = 18;
            this.btnAlertRead.Text = "Leer";
            this.btnAlertRead.UseVisualStyleBackColor = true;
            this.btnAlertRead.Click += new System.EventHandler(this.BtnAlertRead_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(343, 118);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(139, 20);
            this.btnPeek.TabIndex = 19;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.BtnPeek_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(183, 235);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(35, 13);
            this.lblProgress.TabIndex = 20;
            this.lblProgress.Text = "label1";
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(343, 293);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(139, 20);
            this.btnReadFile.TabIndex = 21;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.BtnReadFile_Click);
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(491, 293);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(139, 20);
            this.btnShowData.TabIndex = 22;
            this.btnShowData.Text = "Show data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.BtnShowData_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(491, 202);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(139, 20);
            this.btnEnd.TabIndex = 23;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // chromedriverSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 351);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnAlertRead);
            this.Controls.Add(this.btnAlertDismiss);
            this.Controls.Add(this.btnAlertAccept);
            this.Controls.Add(this.btnBmf);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnThreadState);
            this.Controls.Add(this.btnRunBot);
            this.Controls.Add(this.btnDriverVersion);
            this.Controls.Add(this.btnFileParameters);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtInputFile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.txtChromedriverPath);
            this.Controls.Add(this.btnSelect);
            this.Name = "chromedriverSelector";
            this.Text = "Select chromedriver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtChromedriverPath;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnFileParameters;
        private System.Windows.Forms.Button btnDriverVersion;
        private System.Windows.Forms.Button btnRunBot;
        private System.Windows.Forms.Button btnThreadState;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnBmf;
        private System.Windows.Forms.Button btnAlertAccept;
        private System.Windows.Forms.Button btnAlertDismiss;
        private System.Windows.Forms.Button btnAlertRead;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Button btnEnd;
    }
}

