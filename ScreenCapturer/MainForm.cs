using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ScreenCapturer
{
    public partial class MainForm : Form
    {
        private Screen[] screens;
        private Edits edits;
        public MainForm()
        {
            screens = Screen.AllScreens;
            InitializeComponent();
            edits = new Edits(workArea);
            heightUpDown.Maximum = widthUpDown.Maximum = int.MaxValue;
        }

        private void captureBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            if (delayUpDown.Value > 0)
            {
                Thread.Sleep((int)delayUpDown.Value);
            }
            workArea.Image?.Dispose();
            Bitmap capturedBitmap = ScreenCapturer.Capture(screens[displaySwitch.SelectedIndex]);
            workArea.Image = capturedBitmap;
            UpdateSize(capturedBitmap.Size);
            edits.Size = capturedBitmap.Size;
            Visible = true;
        }

        private void UpdateSize(Size size)
        {
            heightUpDown.Value = size.Height;
            widthUpDown.Value = size.Width;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            foreach (Screen screen in screens)
            {
                displaySwitch.Items.Add(screen.DeviceName);
            }
            displaySwitch.SelectedIndex = 0;
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            edits.Size = new Size((int)widthUpDown.Value, (int)heightUpDown.Value);
            edits.ApplyOverlay();
        }
    }
}
