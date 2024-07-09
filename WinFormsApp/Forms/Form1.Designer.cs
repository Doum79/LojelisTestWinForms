
namespace WinFormsApp.Forms
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.richTextBoxAquitaineRule = new System.Windows.Forms.RichTextBox();
            this.richTextBoxClassicRule = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(258, 12);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(266, 76);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculer Les scores";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // richTextBoxAquitaineRule
            // 
            this.richTextBoxAquitaineRule.Location = new System.Drawing.Point(12, 148);
            this.richTextBoxAquitaineRule.Name = "richTextBoxAquitaineRule";
            this.richTextBoxAquitaineRule.Size = new System.Drawing.Size(342, 158);
            this.richTextBoxAquitaineRule.TabIndex = 1;
            this.richTextBoxAquitaineRule.Text = "";
            // 
            // richTextBoxClassicRule
            // 
            this.richTextBoxClassicRule.Location = new System.Drawing.Point(446, 148);
            this.richTextBoxClassicRule.Name = "richTextBoxClassicRule";
            this.richTextBoxClassicRule.Size = new System.Drawing.Size(342, 158);
            this.richTextBoxClassicRule.TabIndex = 2;
            this.richTextBoxClassicRule.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Règle classique";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Règle Aquitaine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Résultat attendu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Résultat attendu";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(446, 354);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(342, 158);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Merlin 13\nGuenièvre 11\nArthur 10\nPerceval 9";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 354);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(342, 158);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "Perceval 38\nMerlin 29\nGuenièvre 8\nArthur 8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxClassicRule);
            this.Controls.Add(this.richTextBoxAquitaineRule);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.RichTextBox richTextBoxAquitaineRule;
        private System.Windows.Forms.RichTextBox richTextBoxClassicRule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

