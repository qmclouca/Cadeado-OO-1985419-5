namespace Cadeado_OO_1985419_5
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Segredo = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.digito5 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.digito4 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.digito3 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.digito2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.digito1 = new System.Windows.Forms.TrackBar();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Segredo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digito5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digito4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digito3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digito2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digito1)).BeginInit();
            this.SuspendLayout();
            // 
            // Segredo
            // 
            this.Segredo.Controls.Add(this.checkBox5);
            this.Segredo.Controls.Add(this.checkBox3);
            this.Segredo.Controls.Add(this.checkBox1);
            this.Segredo.Controls.Add(this.label5);
            this.Segredo.Controls.Add(this.digito5);
            this.Segredo.Controls.Add(this.label4);
            this.Segredo.Controls.Add(this.digito4);
            this.Segredo.Controls.Add(this.label3);
            this.Segredo.Controls.Add(this.digito3);
            this.Segredo.Controls.Add(this.label2);
            this.Segredo.Controls.Add(this.digito2);
            this.Segredo.Controls.Add(this.label1);
            this.Segredo.Controls.Add(this.digito1);
            this.Segredo.Location = new System.Drawing.Point(12, 12);
            this.Segredo.Name = "Segredo";
            this.Segredo.Size = new System.Drawing.Size(200, 279);
            this.Segredo.TabIndex = 2;
            this.Segredo.TabStop = false;
            this.Segredo.Text = "Segredo";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Enabled = false;
            this.checkBox5.Location = new System.Drawing.Point(157, 242);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(40, 17);
            this.checkBox5.TabIndex = 12;
            this.checkBox5.Text = "Ok";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Visible = false;
            this.checkBox5.CheckStateChanged += new System.EventHandler(this.CheckBox5_CheckStateChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(157, 140);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(40, 17);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Ok";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.CheckBox3_CheckStateChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(157, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(40, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Ok";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.CheckBox1_CheckStateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Location = new System.Drawing.Point(157, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "5";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.Digito5_ValueChanged);
            // 
            // digito5
            // 
            this.digito5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.digito5.Location = new System.Drawing.Point(7, 224);
            this.digito5.Maximum = 9;
            this.digito5.Name = "digito5";
            this.digito5.Size = new System.Drawing.Size(144, 45);
            this.digito5.TabIndex = 4;
            this.digito5.Value = 5;
            this.digito5.Visible = false;
            this.digito5.Scroll += new System.EventHandler(this.Digito5_ValueChanged);
            this.digito5.ValueChanged += new System.EventHandler(this.Digito5_ValueChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(157, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "5";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.Digito4_ValueChanged);
            // 
            // digito4
            // 
            this.digito4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.digito4.Location = new System.Drawing.Point(6, 173);
            this.digito4.Maximum = 9;
            this.digito4.Name = "digito4";
            this.digito4.Size = new System.Drawing.Size(145, 45);
            this.digito4.TabIndex = 3;
            this.digito4.Value = 5;
            this.digito4.Visible = false;
            this.digito4.Scroll += new System.EventHandler(this.Digito4_ValueChanged);
            this.digito4.ValueChanged += new System.EventHandler(this.Digito4_ValueChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(157, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "5";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.Digito3_ValueChanged);
            // 
            // digito3
            // 
            this.digito3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.digito3.Location = new System.Drawing.Point(6, 122);
            this.digito3.Maximum = 9;
            this.digito3.Name = "digito3";
            this.digito3.Size = new System.Drawing.Size(145, 45);
            this.digito3.TabIndex = 2;
            this.digito3.Value = 5;
            this.digito3.Visible = false;
            this.digito3.Scroll += new System.EventHandler(this.Digito3_ValueChanged);
            this.digito3.ValueChanged += new System.EventHandler(this.Digito3_ValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(157, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "5";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.Digito2_ValueChanged);
            // 
            // digito2
            // 
            this.digito2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.digito2.Location = new System.Drawing.Point(6, 71);
            this.digito2.Maximum = 9;
            this.digito2.Name = "digito2";
            this.digito2.Size = new System.Drawing.Size(145, 45);
            this.digito2.TabIndex = 1;
            this.digito2.Value = 5;
            this.digito2.Visible = false;
            this.digito2.Scroll += new System.EventHandler(this.Digito2_ValueChanged);
            this.digito2.ValueChanged += new System.EventHandler(this.Digito2_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(157, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "5";
            // 
            // digito1
            // 
            this.digito1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.digito1.Location = new System.Drawing.Point(7, 19);
            this.digito1.Maximum = 9;
            this.digito1.Name = "digito1";
            this.digito1.Size = new System.Drawing.Size(144, 45);
            this.digito1.TabIndex = 0;
            this.digito1.Value = 5;
            this.digito1.Scroll += new System.EventHandler(this.Digito1_ValueChanged);
            this.digito1.ValueChanged += new System.EventHandler(this.Digito1_ValueChanged_1);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(169, 101);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(40, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Ok";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.CheckBox2_CheckStateChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(169, 203);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(40, 17);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Ok";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Visible = false;
            this.checkBox4.CheckStateChanged += new System.EventHandler(this.CheckBox4_CheckStateChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Rockwell Extra Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(12, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "ABRIR CADEADO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 13;
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 14;
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(91, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 15;
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(132, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.TabIndex = 16;
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(173, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 25);
            this.label10.TabIndex = 17;
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 421);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "label12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 443);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.Segredo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadeado OO";
            
            this.Segredo.ResumeLayout(false);
            this.Segredo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digito5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digito4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digito3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digito2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digito1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Segredo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar digito5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar digito4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar digito3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar digito2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar digito1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

