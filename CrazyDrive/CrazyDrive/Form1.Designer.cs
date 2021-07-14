
namespace CrazyDrive
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
            this.MenuGB = new System.Windows.Forms.GroupBox();
            this.ResumeBtn = new System.Windows.Forms.Button();
            this.SuspendBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.button4 = new CrazyDrive.ButtonComparable();
            this.button3 = new CrazyDrive.ButtonComparable();
            this.button2 = new CrazyDrive.ButtonComparable();
            this.button1 = new CrazyDrive.ButtonComparable();
            this.Finish_PB = new System.Windows.Forms.PictureBox();
            this.MenuGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Finish_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuGB
            // 
            this.MenuGB.Controls.Add(this.ResumeBtn);
            this.MenuGB.Controls.Add(this.SuspendBtn);
            this.MenuGB.Controls.Add(this.StopBtn);
            this.MenuGB.Controls.Add(this.StartBtn);
            this.MenuGB.Location = new System.Drawing.Point(107, 500);
            this.MenuGB.Name = "MenuGB";
            this.MenuGB.Size = new System.Drawing.Size(894, 100);
            this.MenuGB.TabIndex = 10;
            this.MenuGB.TabStop = false;
            // 
            // ResumeBtn
            // 
            this.ResumeBtn.Enabled = false;
            this.ResumeBtn.Location = new System.Drawing.Point(643, 40);
            this.ResumeBtn.Name = "ResumeBtn";
            this.ResumeBtn.Size = new System.Drawing.Size(106, 30);
            this.ResumeBtn.TabIndex = 4;
            this.ResumeBtn.Text = "Resume";
            this.ResumeBtn.UseVisualStyleBackColor = true;
            this.ResumeBtn.Click += new System.EventHandler(this.ResumeBtn_Click);
            // 
            // SuspendBtn
            // 
            this.SuspendBtn.Enabled = false;
            this.SuspendBtn.Location = new System.Drawing.Point(474, 40);
            this.SuspendBtn.Name = "SuspendBtn";
            this.SuspendBtn.Size = new System.Drawing.Size(106, 30);
            this.SuspendBtn.TabIndex = 3;
            this.SuspendBtn.Text = "Suspend";
            this.SuspendBtn.UseVisualStyleBackColor = true;
            this.SuspendBtn.Click += new System.EventHandler(this.SuspendBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Enabled = false;
            this.StopBtn.Location = new System.Drawing.Point(298, 40);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(106, 30);
            this.StopBtn.TabIndex = 2;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(121, 40);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(106, 30);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(107, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 30);
            this.button4.TabIndex = 9;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(107, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Finish_PB
            // 
            this.Finish_PB.Image = global::CrazyDrive.Properties.Resources.ItIsFinish;
            this.Finish_PB.Location = new System.Drawing.Point(762, 27);
            this.Finish_PB.Name = "Finish_PB";
            this.Finish_PB.Size = new System.Drawing.Size(24, 345);
            this.Finish_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Finish_PB.TabIndex = 11;
            this.Finish_PB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 607);
            this.Controls.Add(this.Finish_PB);
            this.Controls.Add(this.MenuGB);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "CrazyDrive";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MenuGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Finish_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MenuGB;
        private System.Windows.Forms.Button ResumeBtn;
        private System.Windows.Forms.Button SuspendBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button StartBtn;
        private ButtonComparable button4;
        private ButtonComparable button3;
        private ButtonComparable button2;
        private ButtonComparable button1;
        private System.Windows.Forms.PictureBox Finish_PB;
    }
}

