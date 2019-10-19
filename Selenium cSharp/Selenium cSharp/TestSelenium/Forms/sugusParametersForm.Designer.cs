namespace Forms
{
    partial class sugusParametersForm
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
            this.txtSheetname = new System.Windows.Forms.TextBox();
            this.numericHeaderRow = new System.Windows.Forms.NumericUpDown();
            this.lblSheetname = new System.Windows.Forms.Label();
            this.lblHeaderRow = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeaderRow)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSheetname
            // 
            this.txtSheetname.Location = new System.Drawing.Point(13, 13);
            this.txtSheetname.Name = "txtSheetname";
            this.txtSheetname.Size = new System.Drawing.Size(120, 20);
            this.txtSheetname.TabIndex = 0;
            // 
            // numericHeaderRow
            // 
            this.numericHeaderRow.Location = new System.Drawing.Point(13, 40);
            this.numericHeaderRow.Name = "numericHeaderRow";
            this.numericHeaderRow.Size = new System.Drawing.Size(120, 20);
            this.numericHeaderRow.TabIndex = 1;
            // 
            // lblSheetname
            // 
            this.lblSheetname.AutoSize = true;
            this.lblSheetname.Location = new System.Drawing.Point(139, 16);
            this.lblSheetname.Name = "lblSheetname";
            this.lblSheetname.Size = new System.Drawing.Size(64, 13);
            this.lblSheetname.TabIndex = 2;
            this.lblSheetname.Text = "Sheet name";
            // 
            // lblHeaderRow
            // 
            this.lblHeaderRow.AutoSize = true;
            this.lblHeaderRow.Location = new System.Drawing.Point(139, 42);
            this.lblHeaderRow.Name = "lblHeaderRow";
            this.lblHeaderRow.Size = new System.Drawing.Size(67, 13);
            this.lblHeaderRow.TabIndex = 3;
            this.lblHeaderRow.Text = "Header Row";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 72);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(137, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // sugusParametersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 107);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblHeaderRow);
            this.Controls.Add(this.lblSheetname);
            this.Controls.Add(this.numericHeaderRow);
            this.Controls.Add(this.txtSheetname);
            this.Name = "sugusParametersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUGUS Parameters";
            this.Load += new System.EventHandler(this.SugusParametersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericHeaderRow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSheetname;
        private System.Windows.Forms.NumericUpDown numericHeaderRow;
        private System.Windows.Forms.Label lblSheetname;
        private System.Windows.Forms.Label lblHeaderRow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}