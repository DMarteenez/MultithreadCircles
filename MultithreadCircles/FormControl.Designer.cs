namespace MultithreadCircles
{
    partial class FormControl
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
            this.buttonRun = new System.Windows.Forms.Button();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxLife = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinLife = new System.Windows.Forms.NumericUpDown();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.checkBoxHide = new System.Windows.Forms.CheckBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelLifeMin = new System.Windows.Forms.Label();
            this.labelLifeMax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinLife)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(6, 170);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Location = new System.Drawing.Point(111, 12);
            this.numericUpDownCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(96, 20);
            this.numericUpDownCount.TabIndex = 1;
            this.numericUpDownCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownMaxLife
            // 
            this.numericUpDownMaxLife.Location = new System.Drawing.Point(111, 95);
            this.numericUpDownMaxLife.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxLife.Name = "numericUpDownMaxLife";
            this.numericUpDownMaxLife.Size = new System.Drawing.Size(96, 20);
            this.numericUpDownMaxLife.TabIndex = 2;
            this.numericUpDownMaxLife.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownMinLife
            // 
            this.numericUpDownMinLife.Location = new System.Drawing.Point(111, 67);
            this.numericUpDownMinLife.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMinLife.Name = "numericUpDownMinLife";
            this.numericUpDownMinLife.Size = new System.Drawing.Size(96, 20);
            this.numericUpDownMinLife.TabIndex = 4;
            this.numericUpDownMinLife.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(6, 199);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 5;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(132, 199);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // checkBoxHide
            // 
            this.checkBoxHide.AutoSize = true;
            this.checkBoxHide.Location = new System.Drawing.Point(6, 133);
            this.checkBoxHide.Name = "checkBoxHide";
            this.checkBoxHide.Size = new System.Drawing.Size(81, 17);
            this.checkBoxHide.TabIndex = 7;
            this.checkBoxHide.Text = "Hide circles";
            this.checkBoxHide.UseVisualStyleBackColor = true;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(3, 14);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(85, 13);
            this.labelCount.TabIndex = 8;
            this.labelCount.Text = "Max circle count";
            // 
            // labelLifeMin
            // 
            this.labelLifeMin.AutoSize = true;
            this.labelLifeMin.Location = new System.Drawing.Point(3, 69);
            this.labelLifeMin.Name = "labelLifeMin";
            this.labelLifeMin.Size = new System.Drawing.Size(90, 13);
            this.labelLifeMin.TabIndex = 9;
            this.labelLifeMin.Text = "Circle min life time";
            // 
            // labelLifeMax
            // 
            this.labelLifeMax.AutoSize = true;
            this.labelLifeMax.Location = new System.Drawing.Point(3, 95);
            this.labelLifeMax.Name = "labelLifeMax";
            this.labelLifeMax.Size = new System.Drawing.Size(93, 13);
            this.labelLifeMax.TabIndex = 10;
            this.labelLifeMax.Text = "Circle max life time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Current circle count";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(132, 170);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "0";
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 235);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLifeMax);
            this.Controls.Add(this.labelLifeMin);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.checkBoxHide);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.numericUpDownMinLife);
            this.Controls.Add(this.numericUpDownMaxLife);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.buttonRun);
            this.MaximumSize = new System.Drawing.Size(235, 274);
            this.MinimumSize = new System.Drawing.Size(235, 274);
            this.Name = "FormControl";
            this.Text = "FormControl";
            this.Load += new System.EventHandler(this.FormControl_Load);
            this.Resize += new System.EventHandler(this.FormControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinLife)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonRun;
        public System.Windows.Forms.NumericUpDown numericUpDownCount;
        public System.Windows.Forms.NumericUpDown numericUpDownMaxLife;
        public System.Windows.Forms.NumericUpDown numericUpDownMinLife;
        public System.Windows.Forms.Button buttonPause;
        public System.Windows.Forms.Button buttonClose;
        public System.Windows.Forms.CheckBox checkBoxHide;
        public System.Windows.Forms.Label labelCount;
        public System.Windows.Forms.Label labelLifeMin;
        public System.Windows.Forms.Label labelLifeMax;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttonReset;
        public System.Windows.Forms.Label label2;
    }
}

