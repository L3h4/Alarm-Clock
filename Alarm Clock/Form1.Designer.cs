
namespace Alarm_Clock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.buttonTurnOn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lTimerDisp = new System.Windows.Forms.Label();
            this.nUDHours = new System.Windows.Forms.NumericUpDown();
            this.nUDMinutes = new System.Windows.Forms.NumericUpDown();
            this.nUDSeconds = new System.Windows.Forms.NumericUpDown();
            this.bStartTimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arimo for Powerline", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(117, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "00:00:00";
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Arimo for Powerline", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(122, 56);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 29);
            this.numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Arimo for Powerline", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(176, 56);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(39, 29);
            this.numericUpDown2.TabIndex = 3;
            // 
            // buttonTurnOn
            // 
            this.buttonTurnOn.BackgroundImage = global::Alarm_Clock.Properties.Resources.check;
            this.buttonTurnOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTurnOn.Location = new System.Drawing.Point(232, 56);
            this.buttonTurnOn.Name = "buttonTurnOn";
            this.buttonTurnOn.Size = new System.Drawing.Size(32, 29);
            this.buttonTurnOn.TabIndex = 4;
            this.buttonTurnOn.UseVisualStyleBackColor = true;
            this.buttonTurnOn.Click += new System.EventHandler(this.buttonTurnOn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Alarm_Clock.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(6, 223);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(273, 49);
            this.MediaPlayer.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(290, 146);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonTurnOn);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.numericUpDown2);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(282, 116);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alarm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bStartTimer);
            this.tabPage2.Controls.Add(this.nUDSeconds);
            this.tabPage2.Controls.Add(this.nUDMinutes);
            this.tabPage2.Controls.Add(this.nUDHours);
            this.tabPage2.Controls.Add(this.lTimerDisp);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(282, 116);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Timer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lTimerDisp
            // 
            this.lTimerDisp.AutoSize = true;
            this.lTimerDisp.Font = new System.Drawing.Font("Arimo for Powerline", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTimerDisp.Location = new System.Drawing.Point(66, 3);
            this.lTimerDisp.Name = "lTimerDisp";
            this.lTimerDisp.Size = new System.Drawing.Size(158, 41);
            this.lTimerDisp.TabIndex = 0;
            this.lTimerDisp.Text = "00:00:00";
            this.lTimerDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lTimerDisp.Visible = false;
            // 
            // nUDHours
            // 
            this.nUDHours.Font = new System.Drawing.Font("Arimo for Powerline", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUDHours.Location = new System.Drawing.Point(73, 6);
            this.nUDHours.Name = "nUDHours";
            this.nUDHours.Size = new System.Drawing.Size(39, 29);
            this.nUDHours.TabIndex = 3;
            // 
            // nUDMinutes
            // 
            this.nUDMinutes.Font = new System.Drawing.Font("Arimo for Powerline", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUDMinutes.Location = new System.Drawing.Point(123, 6);
            this.nUDMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nUDMinutes.Name = "nUDMinutes";
            this.nUDMinutes.Size = new System.Drawing.Size(39, 29);
            this.nUDMinutes.TabIndex = 4;
            // 
            // nUDSeconds
            // 
            this.nUDSeconds.Font = new System.Drawing.Font("Arimo for Powerline", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUDSeconds.Location = new System.Drawing.Point(173, 6);
            this.nUDSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nUDSeconds.Name = "nUDSeconds";
            this.nUDSeconds.Size = new System.Drawing.Size(39, 29);
            this.nUDSeconds.TabIndex = 5;
            // 
            // bStartTimer
            // 
            this.bStartTimer.Location = new System.Drawing.Point(73, 71);
            this.bStartTimer.Name = "bStartTimer";
            this.bStartTimer.Size = new System.Drawing.Size(139, 39);
            this.bStartTimer.TabIndex = 6;
            this.bStartTimer.Text = "Start";
            this.bStartTimer.UseVisualStyleBackColor = true;
            this.bStartTimer.Click += new System.EventHandler(this.bStartTimer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(539, 343);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MediaPlayer);
            this.Font = new System.Drawing.Font("Arimo for Powerline", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSeconds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button buttonTurnOn;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bStartTimer;
        private System.Windows.Forms.NumericUpDown nUDSeconds;
        private System.Windows.Forms.NumericUpDown nUDMinutes;
        private System.Windows.Forms.NumericUpDown nUDHours;
        private System.Windows.Forms.Label lTimerDisp;
    }
}

