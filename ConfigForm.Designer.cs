namespace stp_gui
{
    partial class ConfigForm
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
            stpDirTextBox = new TextBox();
            label1 = new Label();
            selectStpDirButton = new Button();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // stpDirTextBox
            // 
            stpDirTextBox.Location = new Point(105, 12);
            stpDirTextBox.Name = "stpDirTextBox";
            stpDirTextBox.Size = new Size(337, 23);
            stpDirTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "STPディレクトリ";
            // 
            // selectStpDirButton
            // 
            selectStpDirButton.Location = new Point(448, 13);
            selectStpDirButton.Name = "selectStpDirButton";
            selectStpDirButton.Size = new Size(56, 23);
            selectStpDirButton.TabIndex = 2;
            selectStpDirButton.Text = "参照";
            selectStpDirButton.UseVisualStyleBackColor = true;
            selectStpDirButton.Click += selectStpDirButton_Click;
            // 
            // okButton
            // 
            okButton.Location = new Point(348, 70);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 3;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(429, 70);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "キャンセル";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // ConfigForm
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(514, 105);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(selectStpDirButton);
            Controls.Add(label1);
            Controls.Add(stpDirTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfigForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "設定";
            Load += ConfigForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox stpDirTextBox;
        private Label label1;
        private Button selectStpDirButton;
        private Button okButton;
        private Button cancelButton;
    }
}