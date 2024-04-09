namespace DiceRoller
{
    partial class Main
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            addDiceBTN = new Button();
            rollBTN = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Noto Sans", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1035, 66);
            label1.TabIndex = 0;
            label1.Text = "DiceRoller";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Noto Sans", 11.999999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 66);
            label2.Name = "label2";
            label2.Size = new Size(1035, 42);
            label2.TabIndex = 1;
            label2.Text = "Made in .NET (C#)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI Semibold", 11.1428576F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 108);
            label3.Name = "label3";
            label3.Size = new Size(1035, 111);
            label3.TabIndex = 2;
            label3.Text = "Config";
            label3.TextAlign = ContentAlignment.BottomCenter;
            label3.Click += label3_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ControlDark;
            flowLayoutPanel1.Location = new Point(21, 250);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(836, 344);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // addDiceBTN
            // 
            addDiceBTN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addDiceBTN.Font = new Font("Segoe UI Semibold", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addDiceBTN.Location = new Point(863, 250);
            addDiceBTN.Name = "addDiceBTN";
            addDiceBTN.Size = new Size(131, 40);
            addDiceBTN.TabIndex = 5;
            addDiceBTN.Text = "+ Dice";
            addDiceBTN.UseVisualStyleBackColor = true;
            addDiceBTN.Click += addDiceBTN_Click;
            // 
            // rollBTN
            // 
            rollBTN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rollBTN.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rollBTN.Location = new Point(863, 296);
            rollBTN.Name = "rollBTN";
            rollBTN.Size = new Size(131, 40);
            rollBTN.TabIndex = 6;
            rollBTN.Text = "Roll";
            rollBTN.UseVisualStyleBackColor = true;
            rollBTN.Click += rollBTN_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(885, 356);
            label4.Name = "label4";
            label4.Size = new Size(137, 56);
            label4.TabIndex = 7;
            label4.Text = "👆 Click here\r\nto roll them!";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 606);
            Controls.Add(label4);
            Controls.Add(rollBTN);
            Controls.Add(addDiceBTN);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Main";
            Text = "Form1";
            SizeChanged += Form1_SizeChanged;
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button addDiceBTN;
        private Button rollBTN;
        private Label label4;
    }
}
