using System.Data.SqlClient;

namespace ToodedSuskevits
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Koguslbl = new System.Windows.Forms.Label();
            this.Hindlbl = new System.Windows.Forms.Label();
            this.Todelbl = new System.Windows.Forms.Label();
            this.kogusBox = new System.Windows.Forms.TextBox();
            this.HindBox = new System.Windows.Forms.TextBox();
            this.Todebox = new System.Windows.Forms.TextBox();
            this.Uuendabtn = new System.Windows.Forms.Button();
            this.KustutaBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(99, 399);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(242, 277);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 280);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategooriad: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lisa Kategooriat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Koguslbl
            // 
            this.Koguslbl.AutoSize = true;
            this.Koguslbl.Location = new System.Drawing.Point(158, 113);
            this.Koguslbl.Name = "Koguslbl";
            this.Koguslbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Koguslbl.Size = new System.Drawing.Size(43, 23);
            this.Koguslbl.TabIndex = 4;
            this.Koguslbl.Text = "Kogus: ";
            // 
            // Hindlbl
            // 
            this.Hindlbl.AutoSize = true;
            this.Hindlbl.Location = new System.Drawing.Point(158, 161);
            this.Hindlbl.Name = "Hindlbl";
            this.Hindlbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Hindlbl.Size = new System.Drawing.Size(35, 23);
            this.Hindlbl.TabIndex = 5;
            this.Hindlbl.Text = "Hind: ";
            // 
            // Todelbl
            // 
            this.Todelbl.AutoSize = true;
            this.Todelbl.Location = new System.Drawing.Point(158, 62);
            this.Todelbl.Name = "Todelbl";
            this.Todelbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Todelbl.Size = new System.Drawing.Size(38, 23);
            this.Todelbl.TabIndex = 6;
            this.Todelbl.Text = "Tode: ";
            // 
            // kogusBox
            // 
            this.kogusBox.Location = new System.Drawing.Point(242, 110);
            this.kogusBox.Name = "kogusBox";
            this.kogusBox.Size = new System.Drawing.Size(100, 20);
            this.kogusBox.TabIndex = 7;
            // 
            // HindBox
            // 
            this.HindBox.Location = new System.Drawing.Point(242, 158);
            this.HindBox.Name = "HindBox";
            this.HindBox.Size = new System.Drawing.Size(100, 20);
            this.HindBox.TabIndex = 8;
            // 
            // Todebox
            // 
            this.Todebox.Location = new System.Drawing.Point(242, 65);
            this.Todebox.Name = "Todebox";
            this.Todebox.Size = new System.Drawing.Size(100, 20);
            this.Todebox.TabIndex = 9;
            // 
            // Uuendabtn
            // 
            this.Uuendabtn.Location = new System.Drawing.Point(276, 321);
            this.Uuendabtn.Name = "Uuendabtn";
            this.Uuendabtn.Size = new System.Drawing.Size(75, 23);
            this.Uuendabtn.TabIndex = 10;
            this.Uuendabtn.Text = "Uuenda";
            this.Uuendabtn.UseVisualStyleBackColor = true;
            this.Uuendabtn.Click += new System.EventHandler(this.Uuendabtn_Click);
            // 
            // KustutaBtn
            // 
            this.KustutaBtn.Location = new System.Drawing.Point(385, 321);
            this.KustutaBtn.Name = "KustutaBtn";
            this.KustutaBtn.Size = new System.Drawing.Size(75, 23);
            this.KustutaBtn.TabIndex = 11;
            this.KustutaBtn.Text = "Kustuta ";
            this.KustutaBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "KUSTUTA KATEGORIA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(99, 399);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(585, 202);
            this.dgv.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 655);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.KustutaBtn);
            this.Controls.Add(this.Uuendabtn);
            this.Controls.Add(this.Todebox);
            this.Controls.Add(this.HindBox);
            this.Controls.Add(this.kogusBox);
            this.Controls.Add(this.Todelbl);
            this.Controls.Add(this.Hindlbl);
            this.Controls.Add(this.Koguslbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        
         

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Koguslbl;
        private System.Windows.Forms.Label Hindlbl;
        private System.Windows.Forms.Label Todelbl;
        private System.Windows.Forms.TextBox kogusBox;
        private System.Windows.Forms.TextBox HindBox;
        private System.Windows.Forms.TextBox Todebox;
        private System.Windows.Forms.Button Uuendabtn;
        private System.Windows.Forms.Button KustutaBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv;
    }
}

