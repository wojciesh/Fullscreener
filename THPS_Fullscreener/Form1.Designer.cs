namespace Fullscreener
{
    partial class Form1
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
            this.wintitle = new System.Windows.Forms.TextBox();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.numW = new System.Windows.Forms.NumericUpDown();
            this.numH = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.sts = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbNoborder = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).BeginInit();
            this.ss.SuspendLayout();
            this.SuspendLayout();
            // 
            // wintitle
            // 
            this.wintitle.Location = new System.Drawing.Point(12, 25);
            this.wintitle.Name = "wintitle";
            this.wintitle.Size = new System.Drawing.Size(160, 20);
            this.wintitle.TabIndex = 5;
            this.wintitle.Text = "Tony Hawk\'s Pro Skater 2";
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(12, 64);
            this.numX.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numX.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(77, 20);
            this.numX.TabIndex = 1;
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(95, 64);
            this.numY.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numY.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(77, 20);
            this.numY.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numW
            // 
            this.numW.Location = new System.Drawing.Point(12, 103);
            this.numW.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numW.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.numW.Name = "numW";
            this.numW.Size = new System.Drawing.Size(77, 20);
            this.numW.TabIndex = 3;
            // 
            // numH
            // 
            this.numH.Location = new System.Drawing.Point(95, 103);
            this.numH.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numH.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.numH.Name = "numH";
            this.numH.Size = new System.Drawing.Size(77, 20);
            this.numH.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Window title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X && Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "W && H:";
            // 
            // ss
            // 
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sts});
            this.ss.Location = new System.Drawing.Point(0, 200);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(186, 22);
            this.ss.SizingGrip = false;
            this.ss.TabIndex = 6;
            // 
            // sts
            // 
            this.sts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sts.Name = "sts";
            this.sts.Size = new System.Drawing.Size(171, 17);
            this.sts.Spring = true;
            // 
            // cbNoborder
            // 
            this.cbNoborder.AutoSize = true;
            this.cbNoborder.Checked = true;
            this.cbNoborder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNoborder.Location = new System.Drawing.Point(12, 129);
            this.cbNoborder.Name = "cbNoborder";
            this.cbNoborder.Size = new System.Drawing.Size(152, 17);
            this.cbNoborder.TabIndex = 7;
            this.cbNoborder.Text = "No borders (can be buggy)";
            this.cbNoborder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 222);
            this.Controls.Add(this.cbNoborder);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numH);
            this.Controls.Add(this.numY);
            this.Controls.Add(this.numW);
            this.Controls.Add(this.numX);
            this.Controls.Add(this.wintitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fullscreener";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).EndInit();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wintitle;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numW;
        private System.Windows.Forms.NumericUpDown numH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.ToolStripStatusLabel sts;
        private System.Windows.Forms.CheckBox cbNoborder;
    }
}

