namespace Spravochik_HSR
{
    partial class RegForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NemeTB = new System.Windows.Forms.TextBox();
            this.LogTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FamTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PassPodTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя\r\n";
            // 
            // NemeTB
            // 
            this.NemeTB.Location = new System.Drawing.Point(12, 42);
            this.NemeTB.Multiline = true;
            this.NemeTB.Name = "NemeTB";
            this.NemeTB.Size = new System.Drawing.Size(317, 36);
            this.NemeTB.TabIndex = 2;
            
            // 
            // LogTB
            // 
            this.LogTB.Location = new System.Drawing.Point(12, 179);
            this.LogTB.Multiline = true;
            this.LogTB.Name = "LogTB";
            this.LogTB.Size = new System.Drawing.Size(317, 36);
            this.LogTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин";
            // 
            // FamTB
            // 
            this.FamTB.Location = new System.Drawing.Point(14, 113);
            this.FamTB.Multiline = true;
            this.FamTB.Name = "FamTB";
            this.FamTB.Size = new System.Drawing.Size(317, 36);
            this.FamTB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Фамилия\r\n";
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(12, 245);
            this.PassTB.Multiline = true;
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(317, 36);
            this.PassTB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пороль";
            
            // 
            // PassPodTB
            // 
            this.PassPodTB.Location = new System.Drawing.Point(12, 311);
            this.PassPodTB.Multiline = true;
            this.PassPodTB.Name = "PassPodTB";
            this.PassPodTB.Size = new System.Drawing.Size(317, 36);
            this.PassPodTB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Потверждение пороля";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 408);
            this.Controls.Add(this.PassPodTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FamTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LogTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NemeTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "RegForm";
            this.Text = "RegForm";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NemeTB;
        private System.Windows.Forms.TextBox LogTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FamTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PassPodTB;
        private System.Windows.Forms.Label label5;
    }
}