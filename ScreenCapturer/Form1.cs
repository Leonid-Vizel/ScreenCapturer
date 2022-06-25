using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace ScreenCapturer
{
    public partial class Form1 : Form
    {
        private Screen[] screens;
        public Form1()
        {
            screens = Screen.AllScreens;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            workArea.Image?.Dispose();
            workArea.Image = ScreenCapturer.Capture(screens[displaySwitch.SelectedIndex]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Screen screen in screens)
            {
                displaySwitch.Items.Add(screen.DeviceName);
            }
            displaySwitch.SelectedIndex = 0;
        }
    }
}
