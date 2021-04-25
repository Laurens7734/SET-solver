namespace SetSolver
{
    partial class ShapeCardSolver
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
            this.shape1 = new System.Windows.Forms.RadioButton();
            this.shape2 = new System.Windows.Forms.RadioButton();
            this.shape3 = new System.Windows.Forms.RadioButton();
            this.colour1 = new System.Windows.Forms.RadioButton();
            this.colour2 = new System.Windows.Forms.RadioButton();
            this.colour3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fill3 = new System.Windows.Forms.RadioButton();
            this.fill2 = new System.Windows.Forms.RadioButton();
            this.fill1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.amount3 = new System.Windows.Forms.RadioButton();
            this.amount2 = new System.Windows.Forms.RadioButton();
            this.amount1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.CardList = new System.Windows.Forms.ListBox();
            this.solutionsfield = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // shape1
            // 
            this.shape1.AutoSize = true;
            this.shape1.Location = new System.Drawing.Point(6, 19);
            this.shape1.Name = "shape1";
            this.shape1.Size = new System.Drawing.Size(67, 17);
            this.shape1.TabIndex = 0;
            this.shape1.Tag = "1";
            this.shape1.Text = "Diamond";
            this.shape1.UseVisualStyleBackColor = true;
            // 
            // shape2
            // 
            this.shape2.AutoSize = true;
            this.shape2.Location = new System.Drawing.Point(6, 42);
            this.shape2.Name = "shape2";
            this.shape2.Size = new System.Drawing.Size(47, 17);
            this.shape2.TabIndex = 1;
            this.shape2.TabStop = true;
            this.shape2.Tag = "2";
            this.shape2.Text = "Oval";
            this.shape2.UseVisualStyleBackColor = true;
            // 
            // shape3
            // 
            this.shape3.AutoSize = true;
            this.shape3.Location = new System.Drawing.Point(6, 65);
            this.shape3.Name = "shape3";
            this.shape3.Size = new System.Drawing.Size(59, 17);
            this.shape3.TabIndex = 2;
            this.shape3.TabStop = true;
            this.shape3.Tag = "3";
            this.shape3.Text = "Squigly";
            this.shape3.UseVisualStyleBackColor = true;
            // 
            // colour1
            // 
            this.colour1.AutoSize = true;
            this.colour1.Location = new System.Drawing.Point(6, 19);
            this.colour1.Name = "colour1";
            this.colour1.Size = new System.Drawing.Size(45, 17);
            this.colour1.TabIndex = 3;
            this.colour1.TabStop = true;
            this.colour1.Tag = "1";
            this.colour1.Text = "Red";
            this.colour1.UseVisualStyleBackColor = true;
            // 
            // colour2
            // 
            this.colour2.AutoSize = true;
            this.colour2.Location = new System.Drawing.Point(6, 42);
            this.colour2.Name = "colour2";
            this.colour2.Size = new System.Drawing.Size(54, 17);
            this.colour2.TabIndex = 4;
            this.colour2.TabStop = true;
            this.colour2.Tag = "2";
            this.colour2.Text = "Green";
            this.colour2.UseVisualStyleBackColor = true;
            // 
            // colour3
            // 
            this.colour3.AutoSize = true;
            this.colour3.Location = new System.Drawing.Point(6, 65);
            this.colour3.Name = "colour3";
            this.colour3.Size = new System.Drawing.Size(55, 17);
            this.colour3.TabIndex = 5;
            this.colour3.TabStop = true;
            this.colour3.Tag = "3";
            this.colour3.Text = "Purple";
            this.colour3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.shape3);
            this.groupBox1.Controls.Add(this.shape2);
            this.groupBox1.Controls.Add(this.shape1);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 107);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shape";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.colour3);
            this.groupBox2.Controls.Add(this.colour2);
            this.groupBox2.Controls.Add(this.colour1);
            this.groupBox2.Location = new System.Drawing.Point(147, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 107);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colour";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fill3);
            this.groupBox3.Controls.Add(this.fill2);
            this.groupBox3.Controls.Add(this.fill1);
            this.groupBox3.Location = new System.Drawing.Point(12, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(97, 107);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fill";
            // 
            // fill3
            // 
            this.fill3.AutoSize = true;
            this.fill3.Location = new System.Drawing.Point(6, 65);
            this.fill3.Name = "fill3";
            this.fill3.Size = new System.Drawing.Size(41, 17);
            this.fill3.TabIndex = 2;
            this.fill3.TabStop = true;
            this.fill3.Tag = "3";
            this.fill3.Text = "Full";
            this.fill3.UseVisualStyleBackColor = true;
            // 
            // fill2
            // 
            this.fill2.AutoSize = true;
            this.fill2.Location = new System.Drawing.Point(6, 42);
            this.fill2.Name = "fill2";
            this.fill2.Size = new System.Drawing.Size(58, 17);
            this.fill2.TabIndex = 1;
            this.fill2.TabStop = true;
            this.fill2.Tag = "2";
            this.fill2.Text = "Striped";
            this.fill2.UseVisualStyleBackColor = true;
            // 
            // fill1
            // 
            this.fill1.AutoSize = true;
            this.fill1.Location = new System.Drawing.Point(6, 19);
            this.fill1.Name = "fill1";
            this.fill1.Size = new System.Drawing.Size(54, 17);
            this.fill1.TabIndex = 0;
            this.fill1.TabStop = true;
            this.fill1.Tag = "1";
            this.fill1.Text = "Empty";
            this.fill1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.amount3);
            this.groupBox4.Controls.Add(this.amount2);
            this.groupBox4.Controls.Add(this.amount1);
            this.groupBox4.Location = new System.Drawing.Point(147, 182);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(96, 107);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amount";
            // 
            // amount3
            // 
            this.amount3.AutoSize = true;
            this.amount3.Location = new System.Drawing.Point(6, 65);
            this.amount3.Name = "amount3";
            this.amount3.Size = new System.Drawing.Size(31, 17);
            this.amount3.TabIndex = 10;
            this.amount3.TabStop = true;
            this.amount3.Tag = "3";
            this.amount3.Text = "3";
            this.amount3.UseVisualStyleBackColor = true;
            // 
            // amount2
            // 
            this.amount2.AutoSize = true;
            this.amount2.Location = new System.Drawing.Point(6, 42);
            this.amount2.Name = "amount2";
            this.amount2.Size = new System.Drawing.Size(31, 17);
            this.amount2.TabIndex = 1;
            this.amount2.TabStop = true;
            this.amount2.Tag = "2";
            this.amount2.Text = "2";
            this.amount2.UseVisualStyleBackColor = true;
            // 
            // amount1
            // 
            this.amount1.AutoSize = true;
            this.amount1.Location = new System.Drawing.Point(6, 19);
            this.amount1.Name = "amount1";
            this.amount1.Size = new System.Drawing.Size(31, 17);
            this.amount1.TabIndex = 0;
            this.amount1.TabStop = true;
            this.amount1.Tag = "1";
            this.amount1.Text = "1";
            this.amount1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Card";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CardList
            // 
            this.CardList.FormattingEnabled = true;
            this.CardList.Location = new System.Drawing.Point(282, 42);
            this.CardList.Name = "CardList";
            this.CardList.Size = new System.Drawing.Size(181, 381);
            this.CardList.TabIndex = 11;
            // 
            // solutionsfield
            // 
            this.solutionsfield.FormattingEnabled = true;
            this.solutionsfield.Location = new System.Drawing.Point(488, 57);
            this.solutionsfield.Name = "solutionsfield";
            this.solutionsfield.Size = new System.Drawing.Size(296, 108);
            this.solutionsfield.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Solve";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(513, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 34);
            this.button3.TabIndex = 14;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ShapeCardSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.solutionsfield);
            this.Controls.Add(this.CardList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShapeCardSolver";
            this.Text = "Shape Card Solver";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton shape1;
        private System.Windows.Forms.RadioButton shape2;
        private System.Windows.Forms.RadioButton shape3;
        private System.Windows.Forms.RadioButton colour1;
        private System.Windows.Forms.RadioButton colour2;
        private System.Windows.Forms.RadioButton colour3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton fill3;
        private System.Windows.Forms.RadioButton fill2;
        private System.Windows.Forms.RadioButton fill1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton amount3;
        private System.Windows.Forms.RadioButton amount2;
        private System.Windows.Forms.RadioButton amount1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox CardList;
        private System.Windows.Forms.ListBox solutionsfield;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

