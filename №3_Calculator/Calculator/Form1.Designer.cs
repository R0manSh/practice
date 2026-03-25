namespace Calculator
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
            textBoxHistory = new TextBox();
            textBoxResult = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonAdd = new Button();
            buttonSubtract = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonClear = new Button();
            buttonEquals = new Button();
            buttonChangeColor = new Button();
            buttonPoint = new Button();
            button10 = new Button();
            button20 = new Button();
            button21 = new Button();
            SuspendLayout();
            // 
            // textBoxHistory
            // 
            textBoxHistory.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxHistory.Location = new Point(12, 12);
            textBoxHistory.Name = "textBoxHistory";
            textBoxHistory.ReadOnly = true;
            textBoxHistory.Size = new Size(318, 29);
            textBoxHistory.TabIndex = 0;
            textBoxHistory.TextChanged += textBoxHistory_TextChanged;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(12, 41);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(318, 35);
            textBoxResult.TabIndex = 1;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 20.25F);
            button1.Location = new Point(12, 82);
            button1.Name = "button1";
            button1.Size = new Size(75, 75);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 20.25F);
            button2.Location = new Point(93, 82);
            button2.Name = "button2";
            button2.Size = new Size(75, 75);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 20.25F);
            button3.Location = new Point(174, 82);
            button3.Name = "button3";
            button3.Size = new Size(75, 75);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 20.25F);
            button4.Location = new Point(12, 163);
            button4.Name = "button4";
            button4.Size = new Size(75, 75);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 20.25F);
            button5.Location = new Point(93, 163);
            button5.Name = "button5";
            button5.Size = new Size(75, 75);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 20.25F);
            button6.Location = new Point(174, 163);
            button6.Name = "button6";
            button6.Size = new Size(75, 75);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 20.25F);
            button7.Location = new Point(12, 244);
            button7.Name = "button7";
            button7.Size = new Size(75, 75);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 20.25F);
            button8.Location = new Point(93, 244);
            button8.Name = "button8";
            button8.Size = new Size(75, 75);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 20.25F);
            button9.Location = new Point(174, 244);
            button9.Name = "button9";
            button9.Size = new Size(75, 75);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Microsoft Sans Serif", 20.25F);
            button0.Location = new Point(93, 325);
            button0.Name = "button0";
            button0.Size = new Size(75, 75);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Microsoft Sans Serif", 20.25F);
            buttonAdd.Location = new Point(255, 82);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 75);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Font = new Font("Microsoft Sans Serif", 20.25F);
            buttonSubtract.Location = new Point(255, 163);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(75, 75);
            buttonSubtract.TabIndex = 13;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += buttonSubtract_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Font = new Font("Microsoft Sans Serif", 20.25F);
            buttonMultiply.Location = new Point(255, 244);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(75, 75);
            buttonMultiply.TabIndex = 14;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Font = new Font("Microsoft Sans Serif", 20.25F);
            buttonDivide.Location = new Point(255, 325);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(75, 75);
            buttonDivide.TabIndex = 15;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Microsoft Sans Serif", 20.25F);
            buttonClear.Location = new Point(174, 325);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 75);
            buttonClear.TabIndex = 16;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Font = new Font("Microsoft Sans Serif", 20.25F);
            buttonEquals.Location = new Point(336, 325);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(75, 75);
            buttonEquals.TabIndex = 17;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // buttonChangeColor
            // 
            buttonChangeColor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonChangeColor.Location = new Point(336, 26);
            buttonChangeColor.Name = "buttonChangeColor";
            buttonChangeColor.Size = new Size(75, 32);
            buttonChangeColor.TabIndex = 18;
            buttonChangeColor.Text = "Theme";
            buttonChangeColor.UseVisualStyleBackColor = true;
            buttonChangeColor.Click += buttonChangeColor_Click;
            // 
            // buttonPoint
            // 
            buttonPoint.Font = new Font("Microsoft Sans Serif", 20.25F);
            buttonPoint.Location = new Point(12, 325);
            buttonPoint.Name = "buttonPoint";
            buttonPoint.Size = new Size(75, 75);
            buttonPoint.TabIndex = 20;
            buttonPoint.Text = ",";
            buttonPoint.UseVisualStyleBackColor = true;
            buttonPoint.Click += buttonPoint_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Microsoft Sans Serif", 20.25F);
            button10.Location = new Point(336, 244);
            button10.Name = "button10";
            button10.Size = new Size(75, 75);
            button10.TabIndex = 21;
            button10.Text = "+/-";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button20
            // 
            button20.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button20.Location = new Point(334, 82);
            button20.Name = "button20";
            button20.Size = new Size(77, 75);
            button20.TabIndex = 22;
            button20.Text = "Save";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button20_Click;
            // 
            // button21
            // 
            button21.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button21.Location = new Point(334, 163);
            button21.Name = "button21";
            button21.Size = new Size(77, 75);
            button21.TabIndex = 23;
            button21.Text = "Load";
            button21.UseVisualStyleBackColor = true;
            button21.Click += button21_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 417);
            Controls.Add(button21);
            Controls.Add(button20);
            Controls.Add(button10);
            Controls.Add(buttonPoint);
            Controls.Add(buttonChangeColor);
            Controls.Add(buttonEquals);
            Controls.Add(buttonClear);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonAdd);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxHistory);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHistory;
        private TextBox textBoxResult;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonAdd;
        private Button buttonSubtract;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonClear;
        private Button buttonEquals;
        private Button buttonChangeColor;
        private Button buttonPoint;
        private Button button10;
        private Button button20;
        private Button button21;
    }
}
