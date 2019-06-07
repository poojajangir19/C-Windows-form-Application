namespace Assign1
{
    partial class Form1
    {

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
            this.clearButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.t3 = new System.Windows.Forms.TextBox();
            this.gb = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RESULTS = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Chocolate;
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearButton.Location = new System.Drawing.Point(74, 339);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(129, 55);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Close";
            this.clearButton.UseMnemonic = false;
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.UseWaitCursor = true;
            this.clearButton.Click += new System.EventHandler(this.cancel_Click);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.okButton.Location = new System.Drawing.Point(356, 154);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(106, 32);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Execute";
            this.okButton.UseMnemonic = false;
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.UseWaitCursor = true;
            this.okButton.Click += new System.EventHandler(this.Ok_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(25, 118);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(330, 24);
            this.l.TabIndex = 2;
            this.l.Text = "Type your SQL statement here";
            this.l.UseWaitCursor = true;
            // 
            // t3
            // 
            this.t3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.t3.Location = new System.Drawing.Point(29, 159);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(278, 23);
            this.t3.TabIndex = 7;
            this.t3.UseWaitCursor = true;
            // 
            // gb
            // 
            this.gb.BackColor = System.Drawing.Color.Orange;
            this.gb.Controls.Add(this.button1);
            this.gb.Controls.Add(this.clearButton);
            this.gb.Controls.Add(this.okButton);
            this.gb.Controls.Add(this.t3);
            this.gb.Controls.Add(this.l);
            this.gb.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.gb.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb.Location = new System.Drawing.Point(0, 0);
            this.gb.Name = "gb";
            this.gb.Padding = new System.Windows.Forms.Padding(0, 1, 2, 3);
            this.gb.Size = new System.Drawing.Size(540, 470);
            this.gb.TabIndex = 9;
            this.gb.TabStop = false;
            this.gb.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.Location = new System.Drawing.Point(281, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.clear_Click);
            // 
            // RESULTS
            // 
            this.RESULTS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RESULTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RESULTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RESULTS.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.RESULTS.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESULTS.ForeColor = System.Drawing.SystemColors.Desktop;
            this.RESULTS.FormattingEnabled = true;
            this.RESULTS.HorizontalScrollbar = true;
            this.RESULTS.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.RESULTS.ItemHeight = 17;
            this.RESULTS.Location = new System.Drawing.Point(583, 69);
            this.RESULTS.Margin = new System.Windows.Forms.Padding(5);
            this.RESULTS.Name = "RESULTS";
            this.RESULTS.ScrollAlwaysVisible = true;
            this.RESULTS.Size = new System.Drawing.Size(479, 376);
            this.RESULTS.TabIndex = 10;
            this.RESULTS.UseTabStops = false;
            this.RESULTS.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(733, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "DEPARTMENT DATA";
            this.label1.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1076, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RESULTS);
            this.Controls.Add(this.gb);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.ListBox RESULTS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

