
namespace chp_4_programming_problem_1_gjohn2_lab
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
            this.button1DisplayRN = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.romanNumeral = new System.Windows.Forms.Label();
            this.readvalue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1DisplayRN
            // 
            this.button1DisplayRN.Location = new System.Drawing.Point(78, 84);
            this.button1DisplayRN.Name = "button1DisplayRN";
            this.button1DisplayRN.Size = new System.Drawing.Size(105, 38);
            this.button1DisplayRN.TabIndex = 0;
            this.button1DisplayRN.Text = "Display Roman Numeral";
            this.button1DisplayRN.UseVisualStyleBackColor = true;
            this.button1DisplayRN.Click += new System.EventHandler(this.button1DisplayRN_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(189, 145);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(91, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // romanNumeral
            // 
            this.romanNumeral.AutoSize = true;
            this.romanNumeral.Location = new System.Drawing.Point(235, 97);
            this.romanNumeral.Name = "romanNumeral";
            this.romanNumeral.Size = new System.Drawing.Size(182, 13);
            this.romanNumeral.TabIndex = 2;
            this.romanNumeral.Text = "What would be the Roman Numeral?";
            // 
            // readvalue
            // 
            this.readvalue.Location = new System.Drawing.Point(238, 38);
            this.readvalue.Name = "readvalue";
            this.readvalue.Size = new System.Drawing.Size(100, 20);
            this.readvalue.TabIndex = 3;
            this.readvalue.Text = "12";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter an integer between 1 and 10 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter an integer then select Display Roman Numeral button!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readvalue);
            this.Controls.Add(this.romanNumeral);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button1DisplayRN);
            this.Name = "Form1";
            this.Text = "Roman Numeral Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1DisplayRN;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label romanNumeral;
        private System.Windows.Forms.TextBox readvalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

