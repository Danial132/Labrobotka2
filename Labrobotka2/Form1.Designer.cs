﻿
namespace Labrobotka2
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
            this.components = new System.ComponentModel.Container();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.textBox_P3 = new System.Windows.Forms.TextBox();
            this.textBox_Key3 = new System.Windows.Forms.TextBox();
            this.textBox_C3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBox_P
            // 
            this.textBox_P.Location = new System.Drawing.Point(108, 59);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(100, 22);
            this.textBox_P.TabIndex = 0;
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(108, 107);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(100, 22);
            this.textBox_Key.TabIndex = 1;
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(108, 153);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(100, 22);
            this.textBox_C.TabIndex = 2;
            // 
            // textBox_P3
            // 
            this.textBox_P3.Location = new System.Drawing.Point(458, 58);
            this.textBox_P3.Name = "textBox_P3";
            this.textBox_P3.Size = new System.Drawing.Size(100, 22);
            this.textBox_P3.TabIndex = 3;
            // 
            // textBox_Key3
            // 
            this.textBox_Key3.Location = new System.Drawing.Point(458, 107);
            this.textBox_Key3.Name = "textBox_Key3";
            this.textBox_Key3.Size = new System.Drawing.Size(100, 22);
            this.textBox_Key3.TabIndex = 4;
            // 
            // textBox_C3
            // 
            this.textBox_C3.Location = new System.Drawing.Point(458, 152);
            this.textBox_C3.Name = "textBox_C3";
            this.textBox_C3.Size = new System.Drawing.Size(100, 22);
            this.textBox_C3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "XOR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "CLEAN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "P =";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Key =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "C =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "= P";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "= Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(592, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "= C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_C3);
            this.Controls.Add(this.textBox_Key3);
            this.Controls.Add(this.textBox_P3);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.textBox_P);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.TextBox textBox_P3;
        private System.Windows.Forms.TextBox textBox_Key3;
        private System.Windows.Forms.TextBox textBox_C3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

