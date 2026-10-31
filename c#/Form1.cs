using System;
using System.Drawing;
using System.Windows.Forms;

namespace Divya
{
    public class Form1 : Form
    {
        private Label lbResult;

        public Form1()
        {
            this.Text = "Eventapp";
            this.Size = new Size(300, 400);
            this.KeyPreview = true;

            lbResult = new Label();
            lbResult.Text = "Eventclick";
            lbResult.Size = new Size(250, 40);
            lbResult.Location = new Point(30, 40);

            this.Controls.Add(lbResult);

            this.MouseClick += Form1_MouseClick;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_MouseClick(object? sender, MouseEventArgs e)
        {
            lbResult.Text = "Mouse Clicked!";
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            lbResult.Text = "Key Pressed: " + e.KeyCode;
        }
    }
}