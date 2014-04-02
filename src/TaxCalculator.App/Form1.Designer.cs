﻿namespace TaxCalculator.App
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salaryUpDown = new System.Windows.Forms.NumericUpDown();
            this.childrenUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.salaryUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Children";
            // 
            // salaryUpDown
            // 
            this.salaryUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salaryUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salaryUpDown.Location = new System.Drawing.Point(160, 20);
            this.salaryUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salaryUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.salaryUpDown.Name = "salaryUpDown";
            this.salaryUpDown.Size = new System.Drawing.Size(300, 26);
            this.salaryUpDown.TabIndex = 2;
            this.salaryUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.salaryUpDown.ThousandsSeparator = true;
            this.salaryUpDown.Value = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            // 
            // childrenUpDown
            // 
            this.childrenUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.childrenUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.childrenUpDown.Location = new System.Drawing.Point(160, 66);
            this.childrenUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.childrenUpDown.Name = "childrenUpDown";
            this.childrenUpDown.Size = new System.Drawing.Size(300, 26);
            this.childrenUpDown.TabIndex = 3;
            this.childrenUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ft";
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Location = new System.Drawing.Point(128, 128);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(250, 51);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultTextBox.Location = new System.Drawing.Point(18, 208);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(466, 135);
            this.resultTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 363);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.childrenUpDown);
            this.Controls.Add(this.salaryUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "My Tax Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.salaryUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown salaryUpDown;
        private System.Windows.Forms.NumericUpDown childrenUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

