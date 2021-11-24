namespace Защита_КИ
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.LR_1_Button = new yt_DesignUI.yt_Button();
            this.yt_Button1 = new yt_DesignUI.yt_Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Главное меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LR_1_Button
            // 
            this.LR_1_Button.BackColor = System.Drawing.Color.Tomato;
            this.LR_1_Button.BackColorAdditional = System.Drawing.Color.Gray;
            this.LR_1_Button.BackColorGradientEnabled = false;
            this.LR_1_Button.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.LR_1_Button.BorderColor = System.Drawing.Color.Tomato;
            this.LR_1_Button.BorderColorEnabled = false;
            this.LR_1_Button.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.LR_1_Button.BorderColorOnHoverEnabled = false;
            this.LR_1_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LR_1_Button.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.LR_1_Button.ForeColor = System.Drawing.Color.White;
            this.LR_1_Button.Location = new System.Drawing.Point(12, 12);
            this.LR_1_Button.Name = "LR_1_Button";
            this.LR_1_Button.RippleColor = System.Drawing.Color.Black;
            this.LR_1_Button.Rounding = 40;
            this.LR_1_Button.RoundingEnable = true;
            this.LR_1_Button.Size = new System.Drawing.Size(130, 130);
            this.LR_1_Button.TabIndex = 4;
            this.LR_1_Button.Text = "Лабораторная работа №1";
            this.LR_1_Button.TextHover = null;
            this.LR_1_Button.UseDownPressEffectOnClick = false;
            this.LR_1_Button.UseRippleEffect = true;
            this.LR_1_Button.UseZoomEffectOnHover = false;
            this.LR_1_Button.Click += new System.EventHandler(this.LR_1_Button_Click);
            // 
            // yt_Button1
            // 
            this.yt_Button1.BackColor = System.Drawing.Color.Tomato;
            this.yt_Button1.BackColorAdditional = System.Drawing.Color.Gray;
            this.yt_Button1.BackColorGradientEnabled = false;
            this.yt_Button1.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.yt_Button1.BorderColor = System.Drawing.Color.Tomato;
            this.yt_Button1.BorderColorEnabled = false;
            this.yt_Button1.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.yt_Button1.BorderColorOnHoverEnabled = false;
            this.yt_Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yt_Button1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.yt_Button1.ForeColor = System.Drawing.Color.White;
            this.yt_Button1.Location = new System.Drawing.Point(298, 12);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.RippleColor = System.Drawing.Color.Black;
            this.yt_Button1.Rounding = 40;
            this.yt_Button1.RoundingEnable = true;
            this.yt_Button1.Size = new System.Drawing.Size(130, 130);
            this.yt_Button1.TabIndex = 5;
            this.yt_Button1.Text = "Лабораторная работа №3";
            this.yt_Button1.TextHover = null;
            this.yt_Button1.UseDownPressEffectOnClick = false;
            this.yt_Button1.UseRippleEffect = true;
            this.yt_Button1.UseZoomEffectOnHover = false;
            this.yt_Button1.Click += new System.EventHandler(this.yt_Button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.yt_Button1);
            this.Controls.Add(this.LR_1_Button);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(369, 274);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private yt_DesignUI.yt_Button LR_1_Button;
        private yt_DesignUI.yt_Button yt_Button1;
    }
}