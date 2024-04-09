namespace DiceRoller
{
    public partial class Main : Form
    {
        List<int> dices = new List<int>();
        public Main()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addDiceBTN_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.Size = new System.Drawing.Size(300, 100);
            panel.AutoSize = true;
            panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.White;

            Label label = new Label();
            label.Text = $"Dice {flowLayoutPanel1.Controls.Count + 1}";
            label.Font = new Font(FontFamily.GenericSansSerif, 10);

            ComboBox comboBox = new ComboBox();
            comboBox.Items.Add("2 Sided");
            comboBox.Items.Add("3 Sided");
            comboBox.Items.Add("4 Sided");
            comboBox.Items.Add("5 Sided");
            comboBox.Items.Add("6 Sided");
            comboBox.Items.Add("7 Sided");
            comboBox.Items.Add("8 Sided");
            comboBox.Items.Add("9 Sided");
            comboBox.Items.Add("10 Sided");
            comboBox.Items.Add("11 Sided");
            comboBox.Items.Add("12 Sided");
            comboBox.Items.Add("13 Sided");
            comboBox.Items.Add("14 Sided");
            comboBox.Items.Add("15 Sided");
            comboBox.Items.Add("16 Sided");
            comboBox.Items.Add("17 Sided");
            comboBox.Items.Add("18 Sided");
            comboBox.Items.Add("19 Sided");
            comboBox.Items.Add("20 Sided");
            comboBox.SelectedItem = "6 Sided";
            comboBox.Location = new Point(0, 37);

            panel.Controls.Add(label);
            panel.Controls.Add(comboBox);

            flowLayoutPanel1.Controls.Add(panel);
        }

        private void rollBTN_Click(object sender, EventArgs e)
        {
            foreach (Control panelControl in flowLayoutPanel1.Controls)
            {
                if (panelControl is Panel panel)
                {
                    foreach (Control innerControl in panel.Controls)
                    {
                        if (innerControl is ComboBox comboBox)
                        {
                            string selectedValue = comboBox.SelectedItem.ToString();
                            Random rnd = new Random();
                            dices.Add(
                                rnd.Next(0,
                                    Convert.ToInt32(comboBox.SelectedItem
                                                .ToString()
                                                .Substring(0, 1)
                                                )
                                            )
                                    );
                        }
                    }
                }
            }

            ResultForm result = new ResultForm();
            result.LoadResults(dices.ToArray());
            //MessageBox.Show($"All Dices Rolled {string.Join(", ", dices)}");
            dices = new List<int>();
        }

        private bool adjustingSize = false;

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (!adjustingSize && (this.Width != 1059 || this.Height != 670))
            {
                adjustingSize = true;
                this.Size = new Size(1059, 670);
                adjustingSize = false;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (this.Size != new Size(1059, 670))
            {
                this.Size = new Size(1059, 670);
            }
        }
    }
}
