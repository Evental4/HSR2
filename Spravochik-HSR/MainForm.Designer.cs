namespace Spravochik_HSR
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
            this.HelpButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.UzerPanel = new System.Windows.Forms.Panel();
            this.FiltPanel = new System.Windows.Forms.Panel();
            this.FiltPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HelpButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HelpButton.Location = new System.Drawing.Point(193, 1);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(4);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(88, 31);
            this.HelpButton.TabIndex = 3;
            this.HelpButton.Text = "Справка";
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DamegDiler",
            "SapDiler",
            "Saport",
            "Deferint",
            "Hiler",
            "Defender"});
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 27);
            this.comboBox1.TabIndex = 5;
            // 
            // ViewPanel
            // 
            this.ViewPanel.Location = new System.Drawing.Point(10, 71);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1125, 614);
            this.ViewPanel.TabIndex = 13;
            // 
            // UzerPanel
            // 
            this.UzerPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.UzerPanel.Location = new System.Drawing.Point(10, 13);
            this.UzerPanel.Name = "UzerPanel";
            this.UzerPanel.Size = new System.Drawing.Size(841, 52);
            this.UzerPanel.TabIndex = 14;
            // 
            // FiltPanel
            // 
            this.FiltPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FiltPanel.Controls.Add(this.HelpButton);
            this.FiltPanel.Controls.Add(this.comboBox1);
            this.FiltPanel.Location = new System.Drawing.Point(854, 12);
            this.FiltPanel.Name = "FiltPanel";
            this.FiltPanel.Size = new System.Drawing.Size(281, 52);
            this.FiltPanel.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1150, 768);
            this.Controls.Add(this.FiltPanel);
            this.Controls.Add(this.UzerPanel);
            this.Controls.Add(this.ViewPanel);
            this.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Click += new System.EventHandler(this.button1_Click);
            this.FiltPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Panel UzerPanel;
        private System.Windows.Forms.Panel FiltPanel;
    }
}

