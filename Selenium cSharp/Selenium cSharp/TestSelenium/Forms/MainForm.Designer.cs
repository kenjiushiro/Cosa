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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chromedriverSelector));
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtChromedriverPath = new System.Windows.Forms.TextBox();
            this.contextMenuValidar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.validateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lblAlertas = new System.Windows.Forms.Label();
            this.lblThreading = new System.Windows.Forms.Label();
            this.lblExcelReading = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.radioUser = new System.Windows.Forms.RadioButton();
            this.radioNew = new System.Windows.Forms.RadioButton();
            this.btnKillTaskChromedriver = new System.Windows.Forms.Button();
            this.btnKillTaskChrome = new System.Windows.Forms.Button();
            this.txtBotName = new System.Windows.Forms.TextBox();
            this.lblBotname = new System.Windows.Forms.Label();
            this.btnCheckUpdates = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.btnShowAlert = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnDownloadDriver = new System.Windows.Forms.Button();
            this.contextMenuValidar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(462, 39);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(185, 22);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select chromedriver";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtChromedriverPath
            // 
            this.txtChromedriverPath.ContextMenuStrip = this.contextMenuValidar;
            this.txtChromedriverPath.Location = new System.Drawing.Point(16, 40);
            this.txtChromedriverPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChromedriverPath.Name = "txtChromedriverPath";
            this.txtChromedriverPath.ReadOnly = true;
            this.txtChromedriverPath.Size = new System.Drawing.Size(430, 26);
            this.txtChromedriverPath.TabIndex = 1;
            this.txtChromedriverPath.TextChanged += new System.EventHandler(this.TxtValor_TextChanged);
            // 
            // contextMenuValidar
            // 
            this.contextMenuValidar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuValidar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validateToolStripMenuItem});
            this.contextMenuValidar.Name = "contextMenuValidar";
            this.contextMenuValidar.Size = new System.Drawing.Size(133, 28);
            this.contextMenuValidar.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuValidar_Opening);
            // 
            // validateToolStripMenuItem
            // 
            this.validateToolStripMenuItem.Name = "validateToolStripMenuItem";
            this.validateToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.validateToolStripMenuItem.Text = "Validate";
            this.validateToolStripMenuItem.Click += new System.EventHandler(this.ValidateToolStripMenuItem_Click);
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Location = new System.Drawing.Point(11, 10);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(241, 20);
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
            this.btnGuardar.Location = new System.Drawing.Point(15, 338);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(185, 22);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Save";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(15, 368);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(185, 22);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txtInputFile
            // 
            this.txtInputFile.ContextMenuStrip = this.contextMenuValidar;
            this.txtInputFile.Location = new System.Drawing.Point(16, 70);
            this.txtInputFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.ReadOnly = true;
            this.txtInputFile.Size = new System.Drawing.Size(430, 26);
            this.txtInputFile.TabIndex = 6;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(462, 70);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(185, 22);
            this.btnSelectFile.TabIndex = 7;
            this.btnSelectFile.Text = "Select file";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // btnFileParameters
            // 
            this.btnFileParameters.Location = new System.Drawing.Point(655, 70);
            this.btnFileParameters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFileParameters.Name = "btnFileParameters";
            this.btnFileParameters.Size = new System.Drawing.Size(185, 22);
            this.btnFileParameters.TabIndex = 8;
            this.btnFileParameters.Text = "File Parameters";
            this.btnFileParameters.UseVisualStyleBackColor = true;
            this.btnFileParameters.Click += new System.EventHandler(this.BtnFileParameters_Click);
            // 
            // btnDriverVersion
            // 
            this.btnDriverVersion.Location = new System.Drawing.Point(655, 40);
            this.btnDriverVersion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDriverVersion.Name = "btnDriverVersion";
            this.btnDriverVersion.Size = new System.Drawing.Size(185, 22);
            this.btnDriverVersion.TabIndex = 9;
            this.btnDriverVersion.Text = "Version";
            this.btnDriverVersion.UseVisualStyleBackColor = true;
            this.btnDriverVersion.Click += new System.EventHandler(this.BtnDriverVersion_Click);
            // 
            // btnRunBot
            // 
            this.btnRunBot.Location = new System.Drawing.Point(457, 368);
            this.btnRunBot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRunBot.Name = "btnRunBot";
            this.btnRunBot.Size = new System.Drawing.Size(185, 22);
            this.btnRunBot.TabIndex = 11;
            this.btnRunBot.Text = "Run bot";
            this.btnRunBot.UseVisualStyleBackColor = true;
            this.btnRunBot.Click += new System.EventHandler(this.BtnRunBot_Click);
            // 
            // btnThreadState
            // 
            this.btnThreadState.Location = new System.Drawing.Point(655, 196);
            this.btnThreadState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThreadState.Name = "btnThreadState";
            this.btnThreadState.Size = new System.Drawing.Size(185, 22);
            this.btnThreadState.TabIndex = 12;
            this.btnThreadState.Text = "Thread state";
            this.btnThreadState.UseVisualStyleBackColor = true;
            this.btnThreadState.Click += new System.EventHandler(this.BtnThreadState_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(655, 136);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(185, 22);
            this.btnPause.TabIndex = 13;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(655, 166);
            this.btnResume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(185, 22);
            this.btnResume.TabIndex = 14;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.BtnResume_Click);
            // 
            // btnBmf
            // 
            this.btnBmf.Location = new System.Drawing.Point(655, 368);
            this.btnBmf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBmf.Name = "btnBmf";
            this.btnBmf.Size = new System.Drawing.Size(185, 22);
            this.btnBmf.TabIndex = 15;
            this.btnBmf.Text = "BMF";
            this.btnBmf.UseVisualStyleBackColor = true;
            this.btnBmf.Click += new System.EventHandler(this.BtnBmf_Click);
            // 
            // btnAlertAccept
            // 
            this.btnAlertAccept.Location = new System.Drawing.Point(16, 142);
            this.btnAlertAccept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlertAccept.Name = "btnAlertAccept";
            this.btnAlertAccept.Size = new System.Drawing.Size(185, 22);
            this.btnAlertAccept.TabIndex = 16;
            this.btnAlertAccept.Text = "Accept alert";
            this.btnAlertAccept.UseVisualStyleBackColor = true;
            this.btnAlertAccept.Click += new System.EventHandler(this.BtnAlertAccept_Click);
            // 
            // btnAlertDismiss
            // 
            this.btnAlertDismiss.Location = new System.Drawing.Point(16, 172);
            this.btnAlertDismiss.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlertDismiss.Name = "btnAlertDismiss";
            this.btnAlertDismiss.Size = new System.Drawing.Size(185, 22);
            this.btnAlertDismiss.TabIndex = 17;
            this.btnAlertDismiss.Text = "Dismiss alert";
            this.btnAlertDismiss.UseVisualStyleBackColor = true;
            this.btnAlertDismiss.Click += new System.EventHandler(this.BtnAlertDismiss_Click);
            // 
            // btnAlertRead
            // 
            this.btnAlertRead.Location = new System.Drawing.Point(16, 202);
            this.btnAlertRead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlertRead.Name = "btnAlertRead";
            this.btnAlertRead.Size = new System.Drawing.Size(185, 22);
            this.btnAlertRead.TabIndex = 18;
            this.btnAlertRead.Text = "Leer";
            this.btnAlertRead.UseVisualStyleBackColor = true;
            this.btnAlertRead.Click += new System.EventHandler(this.BtnAlertRead_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(446, 226);
            this.btnPeek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(185, 22);
            this.btnPeek.TabIndex = 19;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.BtnPeek_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(441, 136);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(158, 20);
            this.lblProgress.TabIndex = 20;
            this.lblProgress.Text = "Current work item";
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(457, 310);
            this.btnReadFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(185, 22);
            this.btnReadFile.TabIndex = 21;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.BtnReadFile_Click);
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(655, 310);
            this.btnShowData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(185, 22);
            this.btnShowData.TabIndex = 22;
            this.btnShowData.Text = "Show data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.BtnShowData_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(655, 226);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(185, 22);
            this.btnEnd.TabIndex = 23;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // lblAlertas
            // 
            this.lblAlertas.AutoSize = true;
            this.lblAlertas.Location = new System.Drawing.Point(16, 118);
            this.lblAlertas.Name = "lblAlertas";
            this.lblAlertas.Size = new System.Drawing.Size(66, 20);
            this.lblAlertas.TabIndex = 24;
            this.lblAlertas.Text = "Alertas";
            // 
            // lblThreading
            // 
            this.lblThreading.AutoSize = true;
            this.lblThreading.Location = new System.Drawing.Point(650, 118);
            this.lblThreading.Name = "lblThreading";
            this.lblThreading.Size = new System.Drawing.Size(94, 20);
            this.lblThreading.TabIndex = 25;
            this.lblThreading.Text = "Threading";
            // 
            // lblExcelReading
            // 
            this.lblExcelReading.AutoSize = true;
            this.lblExcelReading.Location = new System.Drawing.Point(457, 292);
            this.lblExcelReading.Name = "lblExcelReading";
            this.lblExcelReading.Size = new System.Drawing.Size(119, 20);
            this.lblExcelReading.TabIndex = 26;
            this.lblExcelReading.Text = "Excel reading";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(446, 258);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(394, 26);
            this.progressBar1.TabIndex = 27;
            this.progressBar1.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.Location = new System.Drawing.Point(335, 341);
            this.radioUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioUser.Name = "radioUser";
            this.radioUser.Size = new System.Drawing.Size(134, 24);
            this.radioUser.TabIndex = 29;
            this.radioUser.TabStop = true;
            this.radioUser.Text = "User session";
            this.radioUser.UseVisualStyleBackColor = true;
            // 
            // radioNew
            // 
            this.radioNew.AutoSize = true;
            this.radioNew.Location = new System.Drawing.Point(335, 368);
            this.radioNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioNew.Name = "radioNew";
            this.radioNew.Size = new System.Drawing.Size(132, 24);
            this.radioNew.TabIndex = 30;
            this.radioNew.TabStop = true;
            this.radioNew.Text = "New session";
            this.radioNew.UseVisualStyleBackColor = true;
            // 
            // btnKillTaskChromedriver
            // 
            this.btnKillTaskChromedriver.Location = new System.Drawing.Point(16, 275);
            this.btnKillTaskChromedriver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKillTaskChromedriver.Name = "btnKillTaskChromedriver";
            this.btnKillTaskChromedriver.Size = new System.Drawing.Size(185, 22);
            this.btnKillTaskChromedriver.TabIndex = 31;
            this.btnKillTaskChromedriver.Text = "Kill Chromedriver";
            this.btnKillTaskChromedriver.UseVisualStyleBackColor = true;
            this.btnKillTaskChromedriver.Click += new System.EventHandler(this.BtnKillTaskChromedriver_Click);
            // 
            // btnKillTaskChrome
            // 
            this.btnKillTaskChrome.Location = new System.Drawing.Point(16, 305);
            this.btnKillTaskChrome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKillTaskChrome.Name = "btnKillTaskChrome";
            this.btnKillTaskChrome.Size = new System.Drawing.Size(185, 22);
            this.btnKillTaskChrome.TabIndex = 32;
            this.btnKillTaskChrome.Text = "Kill chrome";
            this.btnKillTaskChrome.UseVisualStyleBackColor = true;
            this.btnKillTaskChrome.Click += new System.EventHandler(this.BtnKillTaskChrome_Click);
            // 
            // txtBotName
            // 
            this.txtBotName.Location = new System.Drawing.Point(221, 155);
            this.txtBotName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBotName.Name = "txtBotName";
            this.txtBotName.Size = new System.Drawing.Size(132, 26);
            this.txtBotName.TabIndex = 33;
            // 
            // lblBotname
            // 
            this.lblBotname.AutoSize = true;
            this.lblBotname.Location = new System.Drawing.Point(218, 136);
            this.lblBotname.Name = "lblBotname";
            this.lblBotname.Size = new System.Drawing.Size(85, 20);
            this.lblBotname.TabIndex = 34;
            this.lblBotname.Text = "Bot name";
            // 
            // btnCheckUpdates
            // 
            this.btnCheckUpdates.Location = new System.Drawing.Point(221, 186);
            this.btnCheckUpdates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckUpdates.Name = "btnCheckUpdates";
            this.btnCheckUpdates.Size = new System.Drawing.Size(195, 34);
            this.btnCheckUpdates.TabIndex = 35;
            this.btnCheckUpdates.Text = "Check for updates";
            this.btnCheckUpdates.UseVisualStyleBackColor = true;
            this.btnCheckUpdates.Click += new System.EventHandler(this.BtnCheckUpdates_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(16, 412);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(58, 20);
            this.lblState.TabIndex = 36;
            this.lblState.Text = "Ready";
            // 
            // btnShowAlert
            // 
            this.btnShowAlert.Location = new System.Drawing.Point(19, 232);
            this.btnShowAlert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAlert.Name = "btnShowAlert";
            this.btnShowAlert.Size = new System.Drawing.Size(185, 22);
            this.btnShowAlert.TabIndex = 37;
            this.btnShowAlert.Text = "Alerta";
            this.btnShowAlert.UseVisualStyleBackColor = true;
            this.btnShowAlert.Click += new System.EventHandler(this.BtnShowAlert_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(222, 263);
            this.btnAttach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(195, 34);
            this.btnAttach.TabIndex = 38;
            this.btnAttach.Text = "Attach  Browser";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.BtnAttach_Click);
            // 
            // btnDownloadDriver
            // 
            this.btnDownloadDriver.Location = new System.Drawing.Point(221, 305);
            this.btnDownloadDriver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDownloadDriver.Name = "btnDownloadDriver";
            this.btnDownloadDriver.Size = new System.Drawing.Size(195, 34);
            this.btnDownloadDriver.TabIndex = 39;
            this.btnDownloadDriver.Text = "Download driver";
            this.btnDownloadDriver.UseVisualStyleBackColor = true;
            this.btnDownloadDriver.Click += new System.EventHandler(this.BtnDownloadDriver_Click);
            // 
            // chromedriverSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 458);
            this.Controls.Add(this.btnDownloadDriver);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.btnShowAlert);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnCheckUpdates);
            this.Controls.Add(this.lblBotname);
            this.Controls.Add(this.txtBotName);
            this.Controls.Add(this.btnKillTaskChrome);
            this.Controls.Add(this.btnKillTaskChromedriver);
            this.Controls.Add(this.radioNew);
            this.Controls.Add(this.radioUser);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblExcelReading);
            this.Controls.Add(this.lblThreading);
            this.Controls.Add(this.lblAlertas);
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
            this.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "chromedriverSelector";
            this.Text = "Vicky GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuValidar.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblAlertas;
        private System.Windows.Forms.Label lblThreading;
        private System.Windows.Forms.Label lblExcelReading;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuValidar;
        private System.Windows.Forms.ToolStripMenuItem validateToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioUser;
        private System.Windows.Forms.RadioButton radioNew;
        private System.Windows.Forms.Button btnKillTaskChromedriver;
        private System.Windows.Forms.Button btnKillTaskChrome;
        private System.Windows.Forms.TextBox txtBotName;
        private System.Windows.Forms.Label lblBotname;
        private System.Windows.Forms.Button btnCheckUpdates;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnShowAlert;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnDownloadDriver;
    }
}

