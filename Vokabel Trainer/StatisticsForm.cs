using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vokabel_Trainer
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            lblUsedCorrect.Text += " " + Vokabel_Trainer.Properties.Settings.Default.usedCorrect_total;
            lblUsedIncorrect.Text += " " + Vokabel_Trainer.Properties.Settings.Default.usedIncorrect_total;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
