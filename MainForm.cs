using System.Diagnostics;
using stp_gui.Properties;

namespace stp_gui
{
    public partial class MainForm : Form
    {
        private string? stpScriptPath;
        private string? ruleDir;

        public MainForm()
        {
            stpScriptPath = null;
            ruleDir = null;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadRules();
        }

        private void ê›íËToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (ConfigForm configForm = new ConfigForm())
            {
                if (configForm.ShowDialog() == DialogResult.OK)
                {
                    LoadRules();
                }
            }
        }

        private void LoadRules()
        {

            string stpDir = Settings.Default.stpdir;
            if (string.IsNullOrWhiteSpace(stpDir))
            {
                rulesDataGridView.DataSource = new List<StpRule>();
                return;
            }

            stpScriptPath = Path.Join(stpDir, "stp.ps1");
            ruleDir = Path.Join(stpDir, "rules");
            string[] ruleFiles = Directory.GetFiles(ruleDir, "*.ps1", SearchOption.AllDirectories);

            List<StpRule> rules = ruleFiles.Select(f => new StpRule() { Rule = Path.GetRelativePath(ruleDir, f) }).ToList();
            rulesDataGridView.DataSource = rules;
        }

        private void rulesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var col = rulesDataGridView.Columns[e.ColumnIndex];

            if (col.Name == "Run")
            {
                StpRule rowItem = (StpRule)rulesDataGridView.Rows[e.RowIndex].DataBoundItem;
                RunPs(rowItem.Rule);
            }
        }

        private void RunPs(string rule)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"powershell.exe";
            startInfo.Arguments = @"& '" + stpScriptPath + "' -rule " + rule;
            startInfo.WorkingDirectory = Settings.Default.stpdir;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();

            string err = process.StandardError.ReadToEnd();
            Debug.WriteLine(err);

            string std = process.StandardOutput.ReadToEnd();
            Debug.WriteLine(std);
        }

    }
}
