
namespace ScreenCapturer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.instrumentPanel = new System.Windows.Forms.Panel();
            this.separatorPanel2 = new System.Windows.Forms.Panel();
            this.widthPanel = new System.Windows.Forms.Panel();
            this.widthUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightPanel = new System.Windows.Forms.Panel();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightLabel = new System.Windows.Forms.Label();
            this.separatorPanel1 = new System.Windows.Forms.Panel();
            this.applyBtn = new System.Windows.Forms.Button();
            this.captureBtn = new System.Windows.Forms.Button();
            this.displaySwitch = new System.Windows.Forms.ComboBox();
            this.displayLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.workArea = new System.Windows.Forms.PictureBox();
            this.delayPanel = new System.Windows.Forms.Panel();
            this.delayUpDown = new System.Windows.Forms.NumericUpDown();
            this.delayLabel = new System.Windows.Forms.Label();
            this.instrumentLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.settingsPanel.SuspendLayout();
            this.instrumentPanel.SuspendLayout();
            this.widthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            this.heightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workArea)).BeginInit();
            this.delayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.instrumentPanel);
            this.settingsPanel.Controls.Add(this.instrumentLabel);
            this.settingsPanel.Controls.Add(this.panel3);
            this.settingsPanel.Controls.Add(this.captureBtn);
            this.settingsPanel.Controls.Add(this.displaySwitch);
            this.settingsPanel.Controls.Add(this.saveBtn);
            this.settingsPanel.Controls.Add(this.delayPanel);
            this.settingsPanel.Controls.Add(this.displayLabel);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsPanel.Location = new System.Drawing.Point(600, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(200, 450);
            this.settingsPanel.TabIndex = 1;
            // 
            // instrumentPanel
            // 
            this.instrumentPanel.Controls.Add(this.separatorPanel2);
            this.instrumentPanel.Controls.Add(this.widthPanel);
            this.instrumentPanel.Controls.Add(this.heightPanel);
            this.instrumentPanel.Controls.Add(this.separatorPanel1);
            this.instrumentPanel.Controls.Add(this.applyBtn);
            this.instrumentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instrumentPanel.Location = new System.Drawing.Point(0, 115);
            this.instrumentPanel.Name = "instrumentPanel";
            this.instrumentPanel.Size = new System.Drawing.Size(200, 292);
            this.instrumentPanel.TabIndex = 14;
            // 
            // separatorPanel2
            // 
            this.separatorPanel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.separatorPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatorPanel2.Location = new System.Drawing.Point(0, 45);
            this.separatorPanel2.Name = "separatorPanel2";
            this.separatorPanel2.Size = new System.Drawing.Size(200, 5);
            this.separatorPanel2.TabIndex = 16;
            // 
            // widthPanel
            // 
            this.widthPanel.Controls.Add(this.widthUpDown);
            this.widthPanel.Controls.Add(this.widthLabel);
            this.widthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.widthPanel.Location = new System.Drawing.Point(0, 25);
            this.widthPanel.Name = "widthPanel";
            this.widthPanel.Size = new System.Drawing.Size(200, 20);
            this.widthPanel.TabIndex = 15;
            // 
            // widthUpDown
            // 
            this.widthUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.widthUpDown.Location = new System.Drawing.Point(55, 0);
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size(145, 20);
            this.widthUpDown.TabIndex = 2;
            // 
            // widthLabel
            // 
            this.widthLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.widthLabel.Location = new System.Drawing.Point(0, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(55, 20);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Ширина:";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heightPanel
            // 
            this.heightPanel.Controls.Add(this.heightUpDown);
            this.heightPanel.Controls.Add(this.heightLabel);
            this.heightPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.heightPanel.Location = new System.Drawing.Point(0, 5);
            this.heightPanel.Name = "heightPanel";
            this.heightPanel.Size = new System.Drawing.Size(200, 20);
            this.heightPanel.TabIndex = 14;
            // 
            // heightUpDown
            // 
            this.heightUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heightUpDown.Location = new System.Drawing.Point(55, 0);
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size(145, 20);
            this.heightUpDown.TabIndex = 1;
            // 
            // heightLabel
            // 
            this.heightLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.heightLabel.Location = new System.Drawing.Point(0, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(55, 20);
            this.heightLabel.TabIndex = 0;
            this.heightLabel.Text = "Высота:";
            this.heightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // separatorPanel1
            // 
            this.separatorPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.separatorPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatorPanel1.Location = new System.Drawing.Point(0, 0);
            this.separatorPanel1.Name = "separatorPanel1";
            this.separatorPanel1.Size = new System.Drawing.Size(200, 5);
            this.separatorPanel1.TabIndex = 13;
            // 
            // applyBtn
            // 
            this.applyBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.applyBtn.Location = new System.Drawing.Point(0, 249);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(200, 43);
            this.applyBtn.TabIndex = 12;
            this.applyBtn.Text = "Применить";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // captureBtn
            // 
            this.captureBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.captureBtn.Location = new System.Drawing.Point(0, 54);
            this.captureBtn.Name = "captureBtn";
            this.captureBtn.Size = new System.Drawing.Size(200, 43);
            this.captureBtn.TabIndex = 0;
            this.captureBtn.Text = "Сделать снимок";
            this.captureBtn.UseVisualStyleBackColor = true;
            this.captureBtn.Click += new System.EventHandler(this.captureBtn_Click);
            // 
            // displaySwitch
            // 
            this.displaySwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.displaySwitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displaySwitch.FormattingEnabled = true;
            this.displaySwitch.Location = new System.Drawing.Point(0, 33);
            this.displaySwitch.Name = "displaySwitch";
            this.displaySwitch.Size = new System.Drawing.Size(200, 21);
            this.displaySwitch.TabIndex = 9;
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.displayLabel.Location = new System.Drawing.Point(0, 0);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(55, 13);
            this.displayLabel.TabIndex = 10;
            this.displayLabel.Text = "Дислпей:";
            // 
            // saveBtn
            // 
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveBtn.Location = new System.Drawing.Point(0, 407);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(200, 43);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.workArea);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 450);
            this.panel2.TabIndex = 2;
            // 
            // workArea
            // 
            this.workArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workArea.Location = new System.Drawing.Point(0, 0);
            this.workArea.Name = "workArea";
            this.workArea.Size = new System.Drawing.Size(600, 450);
            this.workArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.workArea.TabIndex = 0;
            this.workArea.TabStop = false;
            // 
            // delayPanel
            // 
            this.delayPanel.Controls.Add(this.delayUpDown);
            this.delayPanel.Controls.Add(this.delayLabel);
            this.delayPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.delayPanel.Location = new System.Drawing.Point(0, 13);
            this.delayPanel.Name = "delayPanel";
            this.delayPanel.Size = new System.Drawing.Size(200, 20);
            this.delayPanel.TabIndex = 16;
            // 
            // delayUpDown
            // 
            this.delayUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delayUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.delayUpDown.Location = new System.Drawing.Point(90, 0);
            this.delayUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.delayUpDown.Name = "delayUpDown";
            this.delayUpDown.Size = new System.Drawing.Size(110, 20);
            this.delayUpDown.TabIndex = 2;
            this.delayUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // delayLabel
            // 
            this.delayLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.delayLabel.Location = new System.Drawing.Point(0, 0);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(90, 20);
            this.delayLabel.TabIndex = 1;
            this.delayLabel.Text = "Задержка(мс):";
            this.delayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instrumentLabel
            // 
            this.instrumentLabel.AutoSize = true;
            this.instrumentLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.instrumentLabel.Location = new System.Drawing.Point(0, 102);
            this.instrumentLabel.Name = "instrumentLabel";
            this.instrumentLabel.Size = new System.Drawing.Size(79, 13);
            this.instrumentLabel.TabIndex = 17;
            this.instrumentLabel.Text = "Инструменты:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 5);
            this.panel3.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.settingsPanel);
            this.Name = "MainForm";
            this.Text = "Screen Capturer";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.instrumentPanel.ResumeLayout(false);
            this.widthPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
            this.heightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workArea)).EndInit();
            this.delayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.delayUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox workArea;
        private System.Windows.Forms.Button captureBtn;
        private System.Windows.Forms.ComboBox displaySwitch;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Panel instrumentPanel;
        private System.Windows.Forms.Panel widthPanel;
        private System.Windows.Forms.Panel heightPanel;
        private System.Windows.Forms.Panel separatorPanel1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.NumericUpDown heightUpDown;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.NumericUpDown widthUpDown;
        private System.Windows.Forms.Panel separatorPanel2;
        private System.Windows.Forms.Label instrumentLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel delayPanel;
        private System.Windows.Forms.NumericUpDown delayUpDown;
        private System.Windows.Forms.Label delayLabel;
    }
}

