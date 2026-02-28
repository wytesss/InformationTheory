namespace lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoadFromFileCheckBox = new CheckBox();
            SaveToFileCheckBox = new CheckBox();
            EncryptButton = new Button();
            DecryptButton = new Button();
            PlainTextBox = new TextBox();
            CipherTextBox = new TextBox();
            KeyTextBox = new TextBox();
            KeyLabel = new Label();
            PlainTextLabel = new Label();
            CipherTextLabel = new Label();
            DecimalChoice = new RadioButton();
            VigenerChoice = new RadioButton();
            ProcessGroupBox = new GroupBox();
            SettingsGroupBox = new GroupBox();
            MethodGroupBox = new GroupBox();
            ProcessGroupBox.SuspendLayout();
            SettingsGroupBox.SuspendLayout();
            MethodGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // LoadFromFileCheckBox
            // 
            LoadFromFileCheckBox.AutoSize = true;
            LoadFromFileCheckBox.Cursor = Cursors.Hand;
            LoadFromFileCheckBox.Location = new Point(9, 26);
            LoadFromFileCheckBox.Name = "LoadFromFileCheckBox";
            LoadFromFileCheckBox.Size = new Size(173, 24);
            LoadFromFileCheckBox.TabIndex = 0;
            LoadFromFileCheckBox.Text = "Загрузить из файла?";
            LoadFromFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveToFileCheckBox
            // 
            SaveToFileCheckBox.AutoSize = true;
            SaveToFileCheckBox.Cursor = Cursors.Hand;
            SaveToFileCheckBox.Location = new Point(9, 56);
            SaveToFileCheckBox.Name = "SaveToFileCheckBox";
            SaveToFileCheckBox.Size = new Size(163, 24);
            SaveToFileCheckBox.TabIndex = 1;
            SaveToFileCheckBox.Text = "Сохранить в файл?";
            SaveToFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // EncryptButton
            // 
            EncryptButton.Cursor = Cursors.Hand;
            EncryptButton.Location = new Point(268, 37);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(163, 29);
            EncryptButton.TabIndex = 2;
            EncryptButton.Text = "Зашифровать";
            EncryptButton.UseVisualStyleBackColor = true;
            // 
            // DecryptButton
            // 
            DecryptButton.Cursor = Cursors.Hand;
            DecryptButton.Location = new Point(9, 37);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new Size(162, 29);
            DecryptButton.TabIndex = 3;
            DecryptButton.Text = "Расшифровать";
            DecryptButton.UseVisualStyleBackColor = true;
            // 
            // PlainTextBox
            // 
            PlainTextBox.Cursor = Cursors.IBeam;
            PlainTextBox.Location = new Point(37, 52);
            PlainTextBox.Multiline = true;
            PlainTextBox.Name = "PlainTextBox";
            PlainTextBox.Size = new Size(758, 271);
            PlainTextBox.TabIndex = 4;
            // 
            // CipherTextBox
            // 
            CipherTextBox.Cursor = Cursors.IBeam;
            CipherTextBox.Location = new Point(37, 361);
            CipherTextBox.Multiline = true;
            CipherTextBox.Name = "CipherTextBox";
            CipherTextBox.Size = new Size(758, 269);
            CipherTextBox.TabIndex = 5;
            // 
            // KeyTextBox
            // 
            KeyTextBox.Cursor = Cursors.IBeam;
            KeyTextBox.Location = new Point(816, 52);
            KeyTextBox.Multiline = true;
            KeyTextBox.Name = "KeyTextBox";
            KeyTextBox.Size = new Size(437, 271);
            KeyTextBox.TabIndex = 6;
            // 
            // KeyLabel
            // 
            KeyLabel.AutoSize = true;
            KeyLabel.Location = new Point(997, 29);
            KeyLabel.Name = "KeyLabel";
            KeyLabel.Size = new Size(46, 20);
            KeyLabel.TabIndex = 7;
            KeyLabel.Text = "Ключ";
            // 
            // PlainTextLabel
            // 
            PlainTextLabel.AutoSize = true;
            PlainTextLabel.Location = new Point(340, 29);
            PlainTextLabel.Name = "PlainTextLabel";
            PlainTextLabel.Size = new Size(118, 20);
            PlainTextLabel.TabIndex = 8;
            PlainTextLabel.Text = "Исходный текст";
            // 
            // CipherTextLabel
            // 
            CipherTextLabel.AutoSize = true;
            CipherTextLabel.FlatStyle = FlatStyle.System;
            CipherTextLabel.Location = new Point(328, 338);
            CipherTextLabel.Name = "CipherTextLabel";
            CipherTextLabel.Size = new Size(146, 20);
            CipherTextLabel.TabIndex = 9;
            CipherTextLabel.Text = "Получите результат";
            // 
            // DecimalChoice
            // 
            DecimalChoice.AutoSize = true;
            DecimalChoice.Cursor = Cursors.Hand;
            DecimalChoice.Location = new Point(9, 35);
            DecimalChoice.Name = "DecimalChoice";
            DecimalChoice.Size = new Size(160, 24);
            DecimalChoice.TabIndex = 10;
            DecimalChoice.TabStop = true;
            DecimalChoice.Text = "Метод Децимаций";
            DecimalChoice.UseVisualStyleBackColor = true;
            // 
            // VigenerChoice
            // 
            VigenerChoice.AutoSize = true;
            VigenerChoice.Cursor = Cursors.Hand;
            VigenerChoice.Location = new Point(268, 35);
            VigenerChoice.Name = "VigenerChoice";
            VigenerChoice.Size = new Size(149, 24);
            VigenerChoice.TabIndex = 11;
            VigenerChoice.TabStop = true;
            VigenerChoice.Text = "Метод Виженера";
            VigenerChoice.UseVisualStyleBackColor = true;
            // 
            // ProcessGroupBox
            // 
            ProcessGroupBox.Controls.Add(DecryptButton);
            ProcessGroupBox.Controls.Add(EncryptButton);
            ProcessGroupBox.Location = new Point(816, 545);
            ProcessGroupBox.Name = "ProcessGroupBox";
            ProcessGroupBox.Size = new Size(437, 85);
            ProcessGroupBox.TabIndex = 14;
            ProcessGroupBox.TabStop = false;
            ProcessGroupBox.Text = "Действие";
            // 
            // SettingsGroupBox
            // 
            SettingsGroupBox.Controls.Add(LoadFromFileCheckBox);
            SettingsGroupBox.Controls.Add(SaveToFileCheckBox);
            SettingsGroupBox.Location = new Point(816, 441);
            SettingsGroupBox.Name = "SettingsGroupBox";
            SettingsGroupBox.Size = new Size(437, 98);
            SettingsGroupBox.TabIndex = 15;
            SettingsGroupBox.TabStop = false;
            SettingsGroupBox.Text = "Настройки";
            // 
            // MethodGroupBox
            // 
            MethodGroupBox.Controls.Add(DecimalChoice);
            MethodGroupBox.Controls.Add(VigenerChoice);
            MethodGroupBox.Location = new Point(816, 361);
            MethodGroupBox.Name = "MethodGroupBox";
            MethodGroupBox.Size = new Size(437, 74);
            MethodGroupBox.TabIndex = 16;
            MethodGroupBox.TabStop = false;
            MethodGroupBox.Text = "Метод";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 657);
            Controls.Add(MethodGroupBox);
            Controls.Add(SettingsGroupBox);
            Controls.Add(ProcessGroupBox);
            Controls.Add(CipherTextLabel);
            Controls.Add(PlainTextLabel);
            Controls.Add(KeyLabel);
            Controls.Add(KeyTextBox);
            Controls.Add(CipherTextBox);
            Controls.Add(PlainTextBox);
            Name = "Form1";
            Text = "Form1";
            ProcessGroupBox.ResumeLayout(false);
            SettingsGroupBox.ResumeLayout(false);
            SettingsGroupBox.PerformLayout();
            MethodGroupBox.ResumeLayout(false);
            MethodGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox LoadFromFileCheckBox;
        private CheckBox SaveToFileCheckBox;
        private Button EncryptButton;
        private Button DecryptButton;
        private TextBox PlainTextBox;
        private TextBox CipherTextBox;
        private TextBox KeyTextBox;
        private Label KeyLabel;
        private Label PlainTextLabel;
        private Label CipherTextLabel;
        private RadioButton DecimalChoice;
        private RadioButton VigenerChoice;
        private GroupBox ProcessGroupBox;
        private GroupBox SettingsGroupBox;
        private GroupBox MethodGroupBox;
    }
}
