using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        public void LoadResults(int[] results)
        {
            this.Show();
            foreach (int result in results)
            {
                Panel panel = new Panel();
                panel.Size = new System.Drawing.Size(150, 50);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.BackColor = Color.White;

                Label label = new Label();
                label.Text = $"Dice {flowLayoutPanel1.Controls.Count + 1}: {result}";
                label.Font = new Font(FontFamily.GenericSansSerif, 10);
                label.AutoSize = true;
                label.Dock = DockStyle.Fill;


                panel.Controls.Add(label);

                flowLayoutPanel1.Controls.Add(panel);
                this.Refresh();
                Task.Delay(25).Wait();
            }
        }
    }
}
