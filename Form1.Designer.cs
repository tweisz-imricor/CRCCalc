namespace CRCCalc
{
    partial class CrcMainForm
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
            this.CrcSourceTextBox = new System.Windows.Forms.TextBox();
            this.Crc16GoButton = new System.Windows.Forms.Button();
            this.Crc16ResultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ccittButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ccittResultTextBox = new System.Windows.Forms.TextBox();
            this.can15ResultTextBox = new System.Windows.Forms.TextBox();
            this.can15Button = new System.Windows.Forms.Button();
            this.initValTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lrc8ResultTextBox = new System.Windows.Forms.TextBox();
            this.lrc8Button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.modbusResultTextBox = new System.Windows.Forms.TextBox();
            this.modbusButton = new System.Windows.Forms.Button();
            this.calcAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CrcSourceTextBox
            // 
            this.CrcSourceTextBox.AllowDrop = true;
            this.CrcSourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CrcSourceTextBox.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrcSourceTextBox.Location = new System.Drawing.Point(9, 88);
            this.CrcSourceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CrcSourceTextBox.Multiline = true;
            this.CrcSourceTextBox.Name = "CrcSourceTextBox";
            this.CrcSourceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CrcSourceTextBox.Size = new System.Drawing.Size(626, 716);
            this.CrcSourceTextBox.TabIndex = 0;
            this.CrcSourceTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.CrcSourceTextBox_DragDrop);
            this.CrcSourceTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.CrcSourceTextBox_DragEnter);
            // 
            // Crc16GoButton
            // 
            this.Crc16GoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crc16GoButton.Location = new System.Drawing.Point(9, 26);
            this.Crc16GoButton.Margin = new System.Windows.Forms.Padding(2);
            this.Crc16GoButton.Name = "Crc16GoButton";
            this.Crc16GoButton.Size = new System.Drawing.Size(81, 28);
            this.Crc16GoButton.TabIndex = 1;
            this.Crc16GoButton.Text = "Crc16";
            this.Crc16GoButton.UseVisualStyleBackColor = true;
            this.Crc16GoButton.Click += new System.EventHandler(this.Crc16GoButton_Click);
            // 
            // Crc16ResultTextBox
            // 
            this.Crc16ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crc16ResultTextBox.Location = new System.Drawing.Point(33, 59);
            this.Crc16ResultTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Crc16ResultTextBox.Name = "Crc16ResultTextBox";
            this.Crc16ResultTextBox.Size = new System.Drawing.Size(58, 23);
            this.Crc16ResultTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "0x";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.CheckOnClick = true;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcAllToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // ccittButton
            // 
            this.ccittButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccittButton.Location = new System.Drawing.Point(94, 26);
            this.ccittButton.Margin = new System.Windows.Forms.Padding(2);
            this.ccittButton.Name = "ccittButton";
            this.ccittButton.Size = new System.Drawing.Size(81, 28);
            this.ccittButton.TabIndex = 5;
            this.ccittButton.Text = "CCITT";
            this.ccittButton.UseVisualStyleBackColor = true;
            this.ccittButton.Click += new System.EventHandler(this.ccittButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "0x";
            // 
            // ccittResultTextBox
            // 
            this.ccittResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccittResultTextBox.Location = new System.Drawing.Point(118, 59);
            this.ccittResultTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ccittResultTextBox.Name = "ccittResultTextBox";
            this.ccittResultTextBox.Size = new System.Drawing.Size(58, 23);
            this.ccittResultTextBox.TabIndex = 6;
            // 
            // can15ResultTextBox
            // 
            this.can15ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.can15ResultTextBox.Location = new System.Drawing.Point(204, 59);
            this.can15ResultTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.can15ResultTextBox.Name = "can15ResultTextBox";
            this.can15ResultTextBox.Size = new System.Drawing.Size(58, 23);
            this.can15ResultTextBox.TabIndex = 9;
            // 
            // can15Button
            // 
            this.can15Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.can15Button.Location = new System.Drawing.Point(180, 26);
            this.can15Button.Margin = new System.Windows.Forms.Padding(2);
            this.can15Button.Name = "can15Button";
            this.can15Button.Size = new System.Drawing.Size(81, 28);
            this.can15Button.TabIndex = 8;
            this.can15Button.Text = "CAN-15";
            this.can15Button.UseVisualStyleBackColor = true;
            this.can15Button.Click += new System.EventHandler(this.can15Button_Click);
            // 
            // initValTextBox
            // 
            this.initValTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.initValTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initValTextBox.Location = new System.Drawing.Point(575, 59);
            this.initValTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.initValTextBox.Name = "initValTextBox";
            this.initValTextBox.Size = new System.Drawing.Size(58, 23);
            this.initValTextBox.TabIndex = 11;
            this.initValTextBox.Text = "0";
            this.initValTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "0x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "0x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(572, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Init Val";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(265, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "0x";
            // 
            // lrc8ResultTextBox
            // 
            this.lrc8ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lrc8ResultTextBox.Location = new System.Drawing.Point(289, 59);
            this.lrc8ResultTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lrc8ResultTextBox.Name = "lrc8ResultTextBox";
            this.lrc8ResultTextBox.Size = new System.Drawing.Size(58, 23);
            this.lrc8ResultTextBox.TabIndex = 15;
            // 
            // lrc8Button
            // 
            this.lrc8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lrc8Button.Location = new System.Drawing.Point(265, 26);
            this.lrc8Button.Margin = new System.Windows.Forms.Padding(2);
            this.lrc8Button.Name = "lrc8Button";
            this.lrc8Button.Size = new System.Drawing.Size(81, 28);
            this.lrc8Button.TabIndex = 14;
            this.lrc8Button.Text = "LRC-8";
            this.lrc8Button.UseVisualStyleBackColor = true;
            this.lrc8Button.Click += new System.EventHandler(this.lrc8Button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(350, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "0x";
            // 
            // modbusResultTextBox
            // 
            this.modbusResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modbusResultTextBox.Location = new System.Drawing.Point(374, 59);
            this.modbusResultTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.modbusResultTextBox.Name = "modbusResultTextBox";
            this.modbusResultTextBox.Size = new System.Drawing.Size(58, 23);
            this.modbusResultTextBox.TabIndex = 18;
            // 
            // modbusButton
            // 
            this.modbusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modbusButton.Location = new System.Drawing.Point(350, 26);
            this.modbusButton.Margin = new System.Windows.Forms.Padding(2);
            this.modbusButton.Name = "modbusButton";
            this.modbusButton.Size = new System.Drawing.Size(81, 28);
            this.modbusButton.TabIndex = 17;
            this.modbusButton.Text = "ModBus";
            this.modbusButton.UseVisualStyleBackColor = true;
            this.modbusButton.Click += new System.EventHandler(this.modbusButton_Click);
            // 
            // calcAllToolStripMenuItem
            // 
            this.calcAllToolStripMenuItem.Name = "calcAllToolStripMenuItem";
            this.calcAllToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.calcAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calcAllToolStripMenuItem.Text = "Calc All";
            this.calcAllToolStripMenuItem.Click += new System.EventHandler(this.calcAllToolStripMenuItem_Click);
            // 
            // CrcMainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 812);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.modbusResultTextBox);
            this.Controls.Add(this.modbusButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lrc8ResultTextBox);
            this.Controls.Add(this.lrc8Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.initValTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.can15ResultTextBox);
            this.Controls.Add(this.can15Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ccittResultTextBox);
            this.Controls.Add(this.ccittButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Crc16ResultTextBox);
            this.Controls.Add(this.Crc16GoButton);
            this.Controls.Add(this.CrcSourceTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CrcMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRC Calc";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.CrcMainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.CrcMainForm_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CrcSourceTextBox;
        private System.Windows.Forms.Button Crc16GoButton;
        private System.Windows.Forms.TextBox Crc16ResultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button ccittButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ccittResultTextBox;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.TextBox can15ResultTextBox;
        private System.Windows.Forms.Button can15Button;
        private System.Windows.Forms.TextBox initValTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lrc8ResultTextBox;
        private System.Windows.Forms.Button lrc8Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox modbusResultTextBox;
        private System.Windows.Forms.Button modbusButton;
        private System.Windows.Forms.ToolStripMenuItem calcAllToolStripMenuItem;
    }
}

