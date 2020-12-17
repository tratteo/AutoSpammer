
namespace AutoSpammer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.typeBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.parametersGroup = new System.Windows.Forms.GroupBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.infoText = new System.Windows.Forms.TextBox();
            this.startdelayLabel = new System.Windows.Forms.Label();
            this.startDelayValue = new System.Windows.Forms.NumericUpDown();
            this.delayLabel = new System.Windows.Forms.Label();
            this.delayValue = new System.Windows.Forms.NumericUpDown();
            this.spamTextBox = new System.Windows.Forms.TextBox();
            this.console = new System.Windows.Forms.TextBox();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.clearConsoleBtn = new System.Windows.Forms.Button();
            this.infoTooltip = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.parametersGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startDelayValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayValue)).BeginInit();
            this.SuspendLayout();
            // 
            // typeBtn
            // 
            this.typeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.typeBtn.Location = new System.Drawing.Point(260, 297);
            this.typeBtn.Name = "typeBtn";
            this.typeBtn.Size = new System.Drawing.Size(120, 50);
            this.typeBtn.TabIndex = 1;
            this.typeBtn.Text = "Spam";
            this.typeBtn.UseVisualStyleBackColor = true;
            this.typeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.typeBtn_MouseClick);
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stopBtn.Location = new System.Drawing.Point(414, 297);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(120, 50);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stopBtn_MouseClick);
            // 
            // parametersGroup
            // 
            this.parametersGroup.Controls.Add(this.infoTooltip);
            this.parametersGroup.Controls.Add(this.infoLabel);
            this.parametersGroup.Controls.Add(this.infoText);
            this.parametersGroup.Controls.Add(this.startdelayLabel);
            this.parametersGroup.Controls.Add(this.startDelayValue);
            this.parametersGroup.Controls.Add(this.delayLabel);
            this.parametersGroup.Controls.Add(this.delayValue);
            this.parametersGroup.Controls.Add(this.stopBtn);
            this.parametersGroup.Controls.Add(this.typeBtn);
            this.parametersGroup.Font = new System.Drawing.Font("Inconsolata", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parametersGroup.Location = new System.Drawing.Point(12, 12);
            this.parametersGroup.Name = "parametersGroup";
            this.parametersGroup.Size = new System.Drawing.Size(557, 405);
            this.parametersGroup.TabIndex = 3;
            this.parametersGroup.TabStop = false;
            this.parametersGroup.Text = "Controls";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(11, 42);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(82, 26);
            this.infoLabel.TabIndex = 8;
            this.infoLabel.Text = "Message";
            // 
            // infoText
            // 
            this.infoText.Location = new System.Drawing.Point(11, 68);
            this.infoText.Multiline = true;
            this.infoText.Name = "infoText";
            this.infoText.ReadOnly = true;
            this.infoText.Size = new System.Drawing.Size(523, 178);
            this.infoText.TabIndex = 7;
            // 
            // startdelayLabel
            // 
            this.startdelayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startdelayLabel.AutoSize = true;
            this.startdelayLabel.Location = new System.Drawing.Point(11, 249);
            this.startdelayLabel.Name = "startdelayLabel";
            this.startdelayLabel.Size = new System.Drawing.Size(122, 26);
            this.startdelayLabel.TabIndex = 6;
            this.startdelayLabel.Text = "Start delay";
            // 
            // startDelayValue
            // 
            this.startDelayValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startDelayValue.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.startDelayValue.Location = new System.Drawing.Point(16, 278);
            this.startDelayValue.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.startDelayValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.startDelayValue.Name = "startDelayValue";
            this.startDelayValue.Size = new System.Drawing.Size(120, 28);
            this.startDelayValue.TabIndex = 5;
            this.startDelayValue.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // delayLabel
            // 
            this.delayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delayLabel.AutoSize = true;
            this.delayLabel.Location = new System.Drawing.Point(11, 324);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(62, 26);
            this.delayLabel.TabIndex = 4;
            this.delayLabel.Text = "Delay";
            // 
            // delayValue
            // 
            this.delayValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delayValue.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.delayValue.Location = new System.Drawing.Point(16, 353);
            this.delayValue.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.delayValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.delayValue.Name = "delayValue";
            this.delayValue.Size = new System.Drawing.Size(120, 28);
            this.delayValue.TabIndex = 3;
            this.delayValue.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // spamTextBox
            // 
            this.spamTextBox.Location = new System.Drawing.Point(12, 423);
            this.spamTextBox.Multiline = true;
            this.spamTextBox.Name = "spamTextBox";
            this.spamTextBox.Size = new System.Drawing.Size(557, 159);
            this.spamTextBox.TabIndex = 4;
            // 
            // console
            // 
            this.console.Font = new System.Drawing.Font("Inconsolata", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.Location = new System.Drawing.Point(575, 54);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console.Size = new System.Drawing.Size(291, 528);
            this.console.TabIndex = 5;
            // 
            // consoleLabel
            // 
            this.consoleLabel.AutoSize = true;
            this.consoleLabel.Font = new System.Drawing.Font("Inconsolata", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleLabel.Location = new System.Drawing.Point(575, 22);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(82, 26);
            this.consoleLabel.TabIndex = 6;
            this.consoleLabel.Text = "Console";
            // 
            // clearConsoleBtn
            // 
            this.clearConsoleBtn.Font = new System.Drawing.Font("Inconsolata", 7.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearConsoleBtn.Location = new System.Drawing.Point(791, 12);
            this.clearConsoleBtn.Name = "clearConsoleBtn";
            this.clearConsoleBtn.Size = new System.Drawing.Size(75, 36);
            this.clearConsoleBtn.TabIndex = 7;
            this.clearConsoleBtn.Text = "Clear";
            this.clearConsoleBtn.UseVisualStyleBackColor = true;
            this.clearConsoleBtn.Click += new System.EventHandler(this.clearConsoleBtn_Click);
            // 
            // infoTooltip
            // 
            this.infoTooltip.AutoSize = true;
            this.infoTooltip.Font = new System.Drawing.Font("Inconsolata", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTooltip.Location = new System.Drawing.Point(510, 24);
            this.infoTooltip.Name = "infoTooltip";
            this.infoTooltip.Size = new System.Drawing.Size(24, 29);
            this.infoTooltip.TabIndex = 9;
            this.infoTooltip.Text = "?";
            this.toolTip.SetToolTip(this.infoTooltip, "Copy to clipboard the text you want to spam, the bot will use the shortcut CRTL+V" +
        "");
            this.infoTooltip.Click += new System.EventHandler(this.infoTooltip_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(878, 594);
            this.Controls.Add(this.clearConsoleBtn);
            this.Controls.Add(this.consoleLabel);
            this.Controls.Add(this.console);
            this.Controls.Add(this.spamTextBox);
            this.Controls.Add(this.parametersGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Auto Typer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.parametersGroup.ResumeLayout(false);
            this.parametersGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startDelayValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button typeBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.GroupBox parametersGroup;
        private System.Windows.Forms.Label delayLabel;
        private System.Windows.Forms.NumericUpDown delayValue;
        private System.Windows.Forms.Label startdelayLabel;
        private System.Windows.Forms.NumericUpDown startDelayValue;
        private System.Windows.Forms.TextBox spamTextBox;
        private System.Windows.Forms.TextBox infoText;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.Label consoleLabel;
        private System.Windows.Forms.Button clearConsoleBtn;
        private System.Windows.Forms.Label infoTooltip;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
