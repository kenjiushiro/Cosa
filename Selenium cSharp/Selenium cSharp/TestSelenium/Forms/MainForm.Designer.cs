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
            this.button1 = new System.Windows.Forms.Button();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnFileParameters = new System.Windows.Forms.Button();
            this.btnDriverVersion = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Run bot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
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
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(488, 319);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(139, 20);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // chromedriverSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 351);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnDriverVersion);
            this.Controls.Add(this.btnFileParameters);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtInputFile);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnFileParameters;
        private System.Windows.Forms.Button btnDriverVersion;
        private System.Windows.Forms.Button btnTest;
    }
}

