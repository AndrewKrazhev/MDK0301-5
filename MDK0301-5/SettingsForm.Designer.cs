namespace MDK0301_5
{
    partial class SettingsForm
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
            this.FormNameBox = new System.Windows.Forms.TextBox();
            this.labelFormName = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormNameBox
            // 
            this.FormNameBox.Location = new System.Drawing.Point(162, 21);
            this.FormNameBox.Name = "FormNameBox";
            this.FormNameBox.Size = new System.Drawing.Size(470, 20);
            this.FormNameBox.TabIndex = 0;
            // 
            // labelFormName
            // 
            this.labelFormName.AutoSize = true;
            this.labelFormName.Location = new System.Drawing.Point(25, 24);
            this.labelFormName.Name = "labelFormName";
            this.labelFormName.Size = new System.Drawing.Size(122, 13);
            this.labelFormName.TabIndex = 1;
            this.labelFormName.Text = "Название приложения";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(487, 353);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.buttonSave_HelpRequested);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(568, 353);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(75, 23);
            this.buttonAbort.TabIndex = 3;
            this.buttonAbort.Text = "Отмена";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 388);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelFormName);
            this.Controls.Add(this.FormNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.SettingsForm_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FormNameBox;
        private System.Windows.Forms.Label labelFormName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAbort;
    }
}