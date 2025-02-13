namespace stp_gui
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rulesDataGridView = new DataGridView();
            Rule = new DataGridViewTextBoxColumn();
            Run = new DataGridViewButtonColumn();
            menuStrip1 = new MenuStrip();
            設定ToolStripMenuItem = new ToolStripMenuItem();
            設定ToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
            statusStrip1 = new StatusStrip();
            ((System.ComponentModel.ISupportInitialize)rulesDataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // rulesDataGridView
            // 
            rulesDataGridView.AllowUserToAddRows = false;
            rulesDataGridView.AllowUserToDeleteRows = false;
            rulesDataGridView.AllowUserToResizeColumns = false;
            rulesDataGridView.AllowUserToResizeRows = false;
            rulesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rulesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rulesDataGridView.Columns.AddRange(new DataGridViewColumn[] { Rule, Run });
            rulesDataGridView.Dock = DockStyle.Fill;
            rulesDataGridView.Location = new Point(0, 0);
            rulesDataGridView.Name = "rulesDataGridView";
            rulesDataGridView.ReadOnly = true;
            rulesDataGridView.RowHeadersVisible = false;
            rulesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rulesDataGridView.Size = new Size(392, 427);
            rulesDataGridView.TabIndex = 0;
            rulesDataGridView.CellContentClick += rulesDataGridView_CellContentClick;
            // 
            // Rule
            // 
            Rule.DataPropertyName = "Rule";
            Rule.FillWeight = 39.8832474F;
            Rule.HeaderText = "ルール";
            Rule.MinimumWidth = 40;
            Rule.Name = "Rule";
            Rule.ReadOnly = true;
            // 
            // Run
            // 
            Run.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Run.FillWeight = 20F;
            Run.HeaderText = "実行";
            Run.MinimumWidth = 60;
            Run.Name = "Run";
            Run.ReadOnly = true;
            Run.Resizable = DataGridViewTriState.False;
            Run.Text = "実行";
            Run.UseColumnTextForButtonValue = true;
            Run.Width = 60;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { 設定ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(392, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // 設定ToolStripMenuItem
            // 
            設定ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 設定ToolStripMenuItem1 });
            設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            設定ToolStripMenuItem.Size = new Size(43, 20);
            設定ToolStripMenuItem.Text = "設定";
            // 
            // 設定ToolStripMenuItem1
            // 
            設定ToolStripMenuItem1.Name = "設定ToolStripMenuItem1";
            設定ToolStripMenuItem1.Size = new Size(98, 22);
            設定ToolStripMenuItem1.Text = "設定";
            設定ToolStripMenuItem1.Click += 設定ToolStripMenuItem1_Click;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(rulesDataGridView);
            toolStripContainer1.ContentPanel.Size = new Size(392, 427);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(392, 473);
            toolStripContainer1.TabIndex = 3;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(menuStrip1);
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(392, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 473);
            Controls.Add(toolStripContainer1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "stp-gui";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)rulesDataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView rulesDataGridView;
        private DataGridViewTextBoxColumn Rule;
        private DataGridViewButtonColumn Run;
        private MenuStrip menuStrip1;
        private ToolStripContainer toolStripContainer1;
        private ToolStripMenuItem 設定ToolStripMenuItem;
        private ToolStripMenuItem 設定ToolStripMenuItem1;
        private StatusStrip statusStrip1;
    }
}
