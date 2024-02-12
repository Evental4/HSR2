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
            this.RegButton = new System.Windows.Forms.Button();
            this.Hellolabel = new System.Windows.Forms.Label();
            this.Auth_button = new System.Windows.Forms.Button();
            this.FiltPanel = new System.Windows.Forms.Panel();
            this.FindButton = new System.Windows.Forms.Button();
            this.tipTextBox = new System.Windows.Forms.TextBox();
            this.pyteTextBox = new System.Windows.Forms.TextBox();
            this.roleTextBox = new System.Windows.Forms.TextBox();
            this.tipcomboBox = new System.Windows.Forms.ComboBox();
            this.pytecomboBox = new System.Windows.Forms.ComboBox();
            this.rolecomboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UzerPanel.SuspendLayout();
            this.FiltPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HelpButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HelpButton.Location = new System.Drawing.Point(619, 2);
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
            this.UzerPanel.Controls.Add(this.HelpButton);
            this.UzerPanel.Controls.Add(this.RegButton);
            this.UzerPanel.Controls.Add(this.Hellolabel);
            this.UzerPanel.Controls.Add(this.Auth_button);
            this.UzerPanel.Location = new System.Drawing.Point(3, 3);
            this.UzerPanel.Name = "UzerPanel";
            this.UzerPanel.Size = new System.Drawing.Size(712, 53);
            this.UzerPanel.TabIndex = 14;
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.RegButton.Location = new System.Drawing.Point(81, 3);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(96, 46);
            this.RegButton.TabIndex = 2;
            this.RegButton.Text = "Регистрация\r\n";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // Hellolabel
            // 
            this.Hellolabel.AutoSize = true;
            this.Hellolabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Hellolabel.Location = new System.Drawing.Point(183, 4);
            this.Hellolabel.Name = "Hellolabel";
            this.Hellolabel.Size = new System.Drawing.Size(51, 19);
            this.Hellolabel.TabIndex = 1;
            this.Hellolabel.Text = "label1";
            // 
            // Auth_button
            // 
            this.Auth_button.BackColor = System.Drawing.SystemColors.Desktop;
            this.Auth_button.Location = new System.Drawing.Point(3, 3);
            this.Auth_button.Name = "Auth_button";
            this.Auth_button.Size = new System.Drawing.Size(72, 47);
            this.Auth_button.TabIndex = 0;
            this.Auth_button.Text = "Войти\r\n";
            this.Auth_button.UseVisualStyleBackColor = false;
            this.Auth_button.Click += new System.EventHandler(this.Auth_button_Click);
            // 
            // FiltPanel
            // 
            this.FiltPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FiltPanel.Controls.Add(this.FindButton);
            this.FiltPanel.Controls.Add(this.tipTextBox);
            this.FiltPanel.Controls.Add(this.pyteTextBox);
            this.FiltPanel.Controls.Add(this.roleTextBox);
            this.FiltPanel.Controls.Add(this.tipcomboBox);
            this.FiltPanel.Controls.Add(this.pytecomboBox);
            this.FiltPanel.Controls.Add(this.rolecomboBox);
            this.FiltPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiltPanel.Location = new System.Drawing.Point(721, 3);
            this.FiltPanel.Name = "FiltPanel";
            this.FiltPanel.Size = new System.Drawing.Size(460, 55);
            this.FiltPanel.TabIndex = 15;
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FindButton.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FindButton.Location = new System.Drawing.Point(389, 9);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(62, 34);
            this.FindButton.TabIndex = 6;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // tipTextBox
            // 
            this.tipTextBox.Location = new System.Drawing.Point(192, 0);
            this.tipTextBox.Multiline = true;
            this.tipTextBox.Name = "tipTextBox";
            this.tipTextBox.Size = new System.Drawing.Size(82, 22);
            this.tipTextBox.TabIndex = 5;
            this.tipTextBox.Text = "Тип_урона";
            // 
            // pyteTextBox
            // 
            this.pyteTextBox.Location = new System.Drawing.Point(99, 0);
            this.pyteTextBox.Multiline = true;
            this.pyteTextBox.Name = "pyteTextBox";
            this.pyteTextBox.Size = new System.Drawing.Size(87, 22);
            this.pyteTextBox.TabIndex = 4;
            this.pyteTextBox.Text = "Путь";
            // 
            // roleTextBox
            // 
            this.roleTextBox.Location = new System.Drawing.Point(4, 2);
            this.roleTextBox.Multiline = true;
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.Size = new System.Drawing.Size(89, 20);
            this.roleTextBox.TabIndex = 3;
            this.roleTextBox.Text = "Роль";
            // 
            // tipcomboBox
            // 
            this.tipcomboBox.FormattingEnabled = true;
            this.tipcomboBox.Items.AddRange(new object[] {
            "",
            "Физический",
            "Ветреной",
            "Леденой",
            "Огненый",
            "Электрический",
            "Квантовый",
            "Мнимый"});
            this.tipcomboBox.Location = new System.Drawing.Point(192, 25);
            this.tipcomboBox.Name = "tipcomboBox";
            this.tipcomboBox.Size = new System.Drawing.Size(82, 27);
            this.tipcomboBox.TabIndex = 2;
            // 
            // pytecomboBox
            // 
            this.pytecomboBox.FormattingEnabled = true;
            this.pytecomboBox.Items.AddRange(new object[] {
            "",
            "Разрушение",
            "Охота",
            "Изобилие",
            "Эрудикция",
            "Небытие",
            "Сохранение",
            "Гармония"});
            this.pytecomboBox.Location = new System.Drawing.Point(99, 26);
            this.pytecomboBox.Name = "pytecomboBox";
            this.pytecomboBox.Size = new System.Drawing.Size(87, 27);
            this.pytecomboBox.TabIndex = 1;
            // 
            // rolecomboBox
            // 
            this.rolecomboBox.FormattingEnabled = true;
            this.rolecomboBox.Items.AddRange(new object[] {
            "",
            "DD",
            "SapDD",
            "Sap",
            "Hiler",
            "Debaffer",
            "Defens",
            "DD or SapDD"});
            this.rolecomboBox.Location = new System.Drawing.Point(4, 25);
            this.rolecomboBox.Name = "rolecomboBox";
            this.rolecomboBox.Size = new System.Drawing.Size(90, 27);
            this.rolecomboBox.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.64189F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.35811F));
            this.tableLayoutPanel1.Controls.Add(this.UzerPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FiltPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 61);
            this.tableLayoutPanel1.TabIndex = 16;
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
            this.FiltPanel.PerformLayout();
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
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.ComboBox rolecomboBox;
        private System.Windows.Forms.TextBox pyteTextBox;
        private System.Windows.Forms.TextBox roleTextBox;
        private System.Windows.Forms.ComboBox tipcomboBox;
        private System.Windows.Forms.ComboBox pytecomboBox;
        private System.Windows.Forms.TextBox tipTextBox;
        private System.Windows.Forms.Button FindButton;
    }
}

