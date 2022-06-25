
namespace ScreenCapturer
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CaptureBtn = new System.Windows.Forms.Button();
            this.displaySwitch = new System.Windows.Forms.ComboBox();
            this.displayLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.workArea = new System.Windows.Forms.PictureBox();
            this.instrumentLabel = new System.Windows.Forms.Label();
            this.instrumentPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workArea)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.instrumentPanel);
            this.panel1.Controls.Add(this.instrumentLabel);
            this.panel1.Controls.Add(this.CaptureBtn);
            this.panel1.Controls.Add(this.displaySwitch);
            this.panel1.Controls.Add(this.displayLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 1;
            // 
            // CaptureBtn
            // 
            this.CaptureBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaptureBtn.Location = new System.Drawing.Point(0, 34);
            this.CaptureBtn.Name = "CaptureBtn";
            this.CaptureBtn.Size = new System.Drawing.Size(200, 43);
            this.CaptureBtn.TabIndex = 0;
            this.CaptureBtn.Text = "Сделать снимок";
            this.CaptureBtn.UseVisualStyleBackColor = true;
            this.CaptureBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // displaySwitch
            // 
            this.displaySwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.displaySwitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displaySwitch.FormattingEnabled = true;
            this.displaySwitch.Location = new System.Drawing.Point(0, 13);
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
            // instrumentLabel
            // 
            this.instrumentLabel.AutoSize = true;
            this.instrumentLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.instrumentLabel.Location = new System.Drawing.Point(0, 77);
            this.instrumentLabel.Name = "instrumentLabel";
            this.instrumentLabel.Size = new System.Drawing.Size(79, 13);
            this.instrumentLabel.TabIndex = 11;
            this.instrumentLabel.Text = "Инструменты:";
            // 
            // instrumentPanel
            // 
            this.instrumentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instrumentPanel.Location = new System.Drawing.Point(0, 90);
            this.instrumentPanel.Name = "instrumentPanel";
            this.instrumentPanel.Size = new System.Drawing.Size(200, 360);
            this.instrumentPanel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Screen Capturer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox workArea;
        private System.Windows.Forms.Button CaptureBtn;
        private System.Windows.Forms.ComboBox displaySwitch;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Label instrumentLabel;
        private System.Windows.Forms.Panel instrumentPanel;
    }
}

