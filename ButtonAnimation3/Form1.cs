using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonAnimation3
{
    public partial class Form1 : Form
    {
        private Color MomentColor = Color.FromArgb(100, 100, 100);

        public Form1()
        {
            InitializeComponent();

            NoFocusCuesButton TestButton = new NoFocusCuesButton();
            TestButton.TabIndex = 0;
            TestButton.TabStop = true;
            TestButton.Location = new Point(30, 30);
            TestButton.Size = new Size(100, 50);
            TestButton.FlatStyle = FlatStyle.Flat;
            TestButton.BackColor = Color.FromArgb(100, 100, 100);
            TestButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 100, 100);
            TestButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 160, 160);
            TestButton.FlatAppearance.BorderSize = 0;
            TestButton.Font = new Font("Calibri", 14);
            TestButton.ForeColor = Color.White;
            TestButton.Text = "Test";
            TestButton.TextAlign = ContentAlignment.MiddleCenter;
            TestButton.Paint += TestButton_Paint;
            TestButton.MouseEnter += TestButton_MouseEnter;
            TestButton.MouseLeave += TestButton_MouseLeave;

            this.Controls.Add(TestButton);
        }

        private void TestButton_Paint(object sender, PaintEventArgs e)
        {
            //NoFocusCuesButton TestButton = sender as NoFocusCuesButton;
        }

        private void TestButton_MouseEnter(object sender, EventArgs e)
        {
            NoFocusCuesButton TestButton = sender as NoFocusCuesButton;
            int ColorR, ColorG, ColorB;
            for (int i = 0; i < 10; i++)
            {
                ColorR = TestButton.FlatAppearance.MouseOverBackColor.R;
                ColorG = TestButton.FlatAppearance.MouseOverBackColor.G;
                ColorB = TestButton.FlatAppearance.MouseOverBackColor.B;
                MomentColor = Color.FromArgb(ColorR + 3, ColorG + 3, ColorB + 3);
                TestButton.BackColor = MomentColor;
                TestButton.FlatAppearance.MouseOverBackColor = MomentColor;
                TestButton.Refresh();
                Thread.Sleep(3);
            }
        }

        private void TestButton_MouseLeave(object sender, EventArgs e)
        {
            NoFocusCuesButton TestButton = sender as NoFocusCuesButton;
            int ColorR, ColorG, ColorB;
            for (int i = 0; i < 10; i++)
            {
                ColorR = TestButton.FlatAppearance.MouseOverBackColor.R;
                ColorG = TestButton.FlatAppearance.MouseOverBackColor.G;
                ColorB = TestButton.FlatAppearance.MouseOverBackColor.B;
                MomentColor = Color.FromArgb(ColorR - 3, ColorG - 3, ColorB - 3);
                TestButton.BackColor = MomentColor;
                TestButton.FlatAppearance.MouseOverBackColor = MomentColor;
                TestButton.Refresh();
                Thread.Sleep(3);
            }
        }
    }
}
