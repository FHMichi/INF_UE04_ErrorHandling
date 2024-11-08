namespace INF_UE04_ErrorHandling
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
            txtA = new TextBox();
            txtB = new TextBox();
            btnCalculate = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblC = new Label();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(233, 79);
            txtA.Name = "txtA";
            txtA.Size = new Size(200, 39);
            txtA.TabIndex = 0;
            txtA.TextAlign = HorizontalAlignment.Right;
            // 
            // txtB
            // 
            txtB.Location = new Point(233, 124);
            txtB.Name = "txtB";
            txtB.Size = new Size(200, 39);
            txtB.TabIndex = 1;
            txtB.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(497, 117);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 46);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // button1
            // 
            button1.Location = new Point(382, 356);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 82);
            label1.Name = "label1";
            label1.Size = new Size(59, 32);
            label1.TabIndex = 4;
            label1.Text = "A = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 131);
            label2.Name = "label2";
            label2.Size = new Size(58, 32);
            label2.TabIndex = 5;
            label2.Text = "B = ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 233);
            label3.Name = "label3";
            label3.Size = new Size(59, 32);
            label3.TabIndex = 6;
            label3.Text = "C = ";
            // 
            // lblC
            // 
            lblC.Location = new Point(233, 233);
            lblC.Name = "lblC";
            lblC.Size = new Size(200, 40);
            lblC.TabIndex = 7;
            lblC.Text = "?";
            lblC.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 675);
            Controls.Add(lblC);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnCalculate);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private Button btnCalculate;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblC;
    }
}
