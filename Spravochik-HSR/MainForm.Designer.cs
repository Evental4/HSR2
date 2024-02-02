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
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.UzerPanel = new System.Windows.Forms.Panel();
            this.FiltPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Auth_button = new System.Windows.Forms.Button();
            this.Hellolabel = new System.Windows.Forms.Label();
            this.UzerPanel.SuspendLayout();
            this.FiltPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HelpButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HelpButton.Location = new System.Drawing.Point(189, 4);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(4);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(88, 31);
            this.HelpButton.TabIndex = 3;
            this.HelpButton.Text = "Справка";
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // ViewPanel
            // 
            this.ViewPanel.AutoScroll = true;
            this.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPanel.Location = new System.Drawing.Point(0, 0);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(1184, 861);
            this.ViewPanel.TabIndex = 13;
            this.ViewPanel.Resize += new System.EventHandler(this.ViewPanel_Resize);
            // 
            // UzerPanel
            // 
            this.UzerPanel.AutoScroll = true;
            this.UzerPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.UzerPanel.Controls.Add(this.Hellolabel);
            this.UzerPanel.Controls.Add(this.Auth_button);
            this.UzerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UzerPanel.Location = new System.Drawing.Point(3, 3);
            this.UzerPanel.Name = "UzerPanel";
            this.UzerPanel.Size = new System.Drawing.Size(885, 53);
            this.UzerPanel.TabIndex = 14;
            // 
            // FiltPanel
            // 
            this.FiltPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FiltPanel.Controls.Add(this.HelpButton);
            this.FiltPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiltPanel.Location = new System.Drawing.Point(894, 3);
            this.FiltPanel.Name = "FiltPanel";
            this.FiltPanel.Size = new System.Drawing.Size(287, 53);
            this.FiltPanel.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.25338F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.74662F));
            this.tableLayoutPanel1.Controls.Add(this.UzerPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FiltPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 59);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // Auth_button
            // 
            this.Auth_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Auth_button.Location = new System.Drawing.Point(3, 3);
            this.Auth_button.Name = "Auth_button";
            this.Auth_button.Size = new System.Drawing.Size(139, 47);
            this.Auth_button.TabIndex = 0;
            this.Auth_button.Text = "Войти\r\n";
            this.Auth_button.UseVisualStyleBackColor = false;
            this.Auth_button.Click += new System.EventHandler(this.Auth_button_Click);
            // 
            // Hellolabel
            // 
            this.Hellolabel.AutoSize = true;
            this.Hellolabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Hellolabel.Location = new System.Drawing.Point(148, 4);
            this.Hellolabel.Name = "Hellolabel";
            this.Hellolabel.Size = new System.Drawing.Size(51, 19);
            this.Hellolabel.TabIndex = 1;
            this.Hellolabel.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ViewPanel);
            this.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.button1_Click);
            this.UzerPanel.ResumeLayout(false);
            this.UzerPanel.PerformLayout();
            this.FiltPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.Panel UzerPanel;
        private System.Windows.Forms.Panel FiltPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Auth_button;
        private System.Windows.Forms.Label Hellolabel;
    }
}

