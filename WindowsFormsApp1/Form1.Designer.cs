namespace WindowsFormsApp1
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
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEvent = new System.Windows.Forms.Label();
            this.btnAutoSell = new System.Windows.Forms.Button();
            this.lbAutoSell = new System.Windows.Forms.Label();
            this.btnFarmIn = new System.Windows.Forms.Button();
            this.lbFarmIn = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.lbR1 = new System.Windows.Forms.Label();
            this.lbG1 = new System.Windows.Forms.Label();
            this.lbB1 = new System.Windows.Forms.Label();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.lbR2 = new System.Windows.Forms.Label();
            this.lbG2 = new System.Windows.Forms.Label();
            this.lbB2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(12, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(15, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "R";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(11, 39);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(14, 13);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "B";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(431, 490);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Start";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 461);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(12, 64);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(15, 13);
            this.lb3.TabIndex = 4;
            this.lb3.Text = "G";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(99, 9);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(14, 13);
            this.lbX.TabIndex = 5;
            this.lbX.Text = "X";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(99, 39);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(14, 13);
            this.lbY.TabIndex = 6;
            this.lbY.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Event Processing";
            // 
            // lbEvent
            // 
            this.lbEvent.AutoSize = true;
            this.lbEvent.Location = new System.Drawing.Point(126, 117);
            this.lbEvent.Name = "lbEvent";
            this.lbEvent.Size = new System.Drawing.Size(0, 13);
            this.lbEvent.TabIndex = 8;
            // 
            // btnAutoSell
            // 
            this.btnAutoSell.Location = new System.Drawing.Point(349, 12);
            this.btnAutoSell.Name = "btnAutoSell";
            this.btnAutoSell.Size = new System.Drawing.Size(80, 23);
            this.btnAutoSell.TabIndex = 9;
            this.btnAutoSell.Text = "Auto sell";
            this.btnAutoSell.UseVisualStyleBackColor = true;
            this.btnAutoSell.Click += new System.EventHandler(this.btnAutoSell_Click);
            // 
            // lbAutoSell
            // 
            this.lbAutoSell.AutoSize = true;
            this.lbAutoSell.Location = new System.Drawing.Point(451, 17);
            this.lbAutoSell.Name = "lbAutoSell";
            this.lbAutoSell.Size = new System.Drawing.Size(47, 13);
            this.lbAutoSell.TabIndex = 10;
            this.lbAutoSell.Text = "Stopped";
            // 
            // btnFarmIn
            // 
            this.btnFarmIn.Location = new System.Drawing.Point(354, 54);
            this.btnFarmIn.Name = "btnFarmIn";
            this.btnFarmIn.Size = new System.Drawing.Size(75, 23);
            this.btnFarmIn.TabIndex = 11;
            this.btnFarmIn.Text = "Auto Farm In";
            this.btnFarmIn.UseVisualStyleBackColor = true;
            this.btnFarmIn.Click += new System.EventHandler(this.btnFarmIn_Click);
            // 
            // lbFarmIn
            // 
            this.lbFarmIn.AutoSize = true;
            this.lbFarmIn.Location = new System.Drawing.Point(451, 59);
            this.lbFarmIn.Name = "lbFarmIn";
            this.lbFarmIn.Size = new System.Drawing.Size(47, 13);
            this.lbFarmIn.TabIndex = 12;
            this.lbFarmIn.Text = "Stopped";
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(15, 170);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(100, 20);
            this.txtX1.TabIndex = 13;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(121, 170);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(100, 20);
            this.txtY1.TabIndex = 14;
            // 
            // lbR1
            // 
            this.lbR1.AutoSize = true;
            this.lbR1.Location = new System.Drawing.Point(238, 160);
            this.lbR1.Name = "lbR1";
            this.lbR1.Size = new System.Drawing.Size(35, 13);
            this.lbR1.TabIndex = 15;
            this.lbR1.Text = "label2";
            // 
            // lbG1
            // 
            this.lbG1.AutoSize = true;
            this.lbG1.Location = new System.Drawing.Point(335, 160);
            this.lbG1.Name = "lbG1";
            this.lbG1.Size = new System.Drawing.Size(35, 13);
            this.lbG1.TabIndex = 16;
            this.lbG1.Text = "label3";
            // 
            // lbB1
            // 
            this.lbB1.AutoSize = true;
            this.lbB1.Location = new System.Drawing.Point(422, 159);
            this.lbB1.Name = "lbB1";
            this.lbB1.Size = new System.Drawing.Size(35, 13);
            this.lbB1.TabIndex = 17;
            this.lbB1.Text = "label4";
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(15, 245);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(100, 20);
            this.txtX2.TabIndex = 18;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(121, 245);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(100, 20);
            this.txtY2.TabIndex = 19;
            // 
            // lbR2
            // 
            this.lbR2.AutoSize = true;
            this.lbR2.Location = new System.Drawing.Point(238, 245);
            this.lbR2.Name = "lbR2";
            this.lbR2.Size = new System.Drawing.Size(35, 13);
            this.lbR2.TabIndex = 20;
            this.lbR2.Text = "label5";
            // 
            // lbG2
            // 
            this.lbG2.AutoSize = true;
            this.lbG2.Location = new System.Drawing.Point(335, 244);
            this.lbG2.Name = "lbG2";
            this.lbG2.Size = new System.Drawing.Size(35, 13);
            this.lbG2.TabIndex = 21;
            this.lbG2.Text = "label6";
            // 
            // lbB2
            // 
            this.lbB2.AutoSize = true;
            this.lbB2.Location = new System.Drawing.Point(422, 245);
            this.lbB2.Name = "lbB2";
            this.lbB2.Size = new System.Drawing.Size(35, 13);
            this.lbB2.TabIndex = 22;
            this.lbB2.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 525);
            this.Controls.Add(this.lbB2);
            this.Controls.Add(this.lbG2);
            this.Controls.Add(this.lbR2);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.lbB1);
            this.Controls.Add(this.lbG1);
            this.Controls.Add(this.lbR1);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.lbFarmIn);
            this.Controls.Add(this.btnFarmIn);
            this.Controls.Add(this.lbAutoSell);
            this.Controls.Add(this.btnAutoSell);
            this.Controls.Add(this.lbEvent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbEvent;
        private System.Windows.Forms.Button btnAutoSell;
        private System.Windows.Forms.Label lbAutoSell;
        private System.Windows.Forms.Button btnFarmIn;
        private System.Windows.Forms.Label lbFarmIn;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.Label lbR1;
        private System.Windows.Forms.Label lbG1;
        private System.Windows.Forms.Label lbB1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Label lbR2;
        private System.Windows.Forms.Label lbG2;
        private System.Windows.Forms.Label lbB2;
    }
}

