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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            resources.ApplyResources(this.Segredo, "Segredo");
            this.Segredo.Name = "Segredo";
            this.Segredo.TabStop = false;
            this.Segredo.Enter += new System.EventHandler(this.Segredo_Enter);
            // 
            // checkBox5
            // 
            resources.ApplyResources(this.checkBox5, "checkBox5");
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckStateChanged += new System.EventHandler(this.checkBox5_CheckStateChanged);
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.checkBox3_CheckStateChanged);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.digito5_ValueChanged);
            // 
            // digito5
            // 
            this.digito5.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.digito5, "digito5");
            this.digito5.Maximum = 9;
            this.digito5.Name = "digito5";
            this.digito5.Value = 5;
            this.digito5.Scroll += new System.EventHandler(this.digito5_ValueChanged);
            this.digito5.ValueChanged += new System.EventHandler(this.digito5_ValueChanged_1);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.digito4_ValueChanged);
            // 
            // digito4
            // 
            this.digito4.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.digito4, "digito4");
            this.digito4.Maximum = 9;
            this.digito4.Name = "digito4";
            this.digito4.Value = 5;
            this.digito4.Scroll += new System.EventHandler(this.digito4_ValueChanged);
            this.digito4.ValueChanged += new System.EventHandler(this.digito4_ValueChanged_1);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.digito3_ValueChanged);
            // 
            // digito3
            // 
            this.digito3.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.digito3, "digito3");
            this.digito3.Maximum = 9;
            this.digito3.Name = "digito3";
            this.digito3.Value = 5;
            this.digito3.Scroll += new System.EventHandler(this.digito3_ValueChanged);
            this.digito3.ValueChanged += new System.EventHandler(this.digito3_ValueChanged_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.digito2_ValueChanged);
            // 
            // digito2
            // 
            this.digito2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.digito2, "digito2");
            this.digito2.Maximum = 9;
            this.digito2.Name = "digito2";
            this.digito2.Value = 5;
            this.digito2.Scroll += new System.EventHandler(this.digito2_ValueChanged);
            this.digito2.ValueChanged += new System.EventHandler(this.digito2_ValueChanged_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Name = "label1";
            // 
            // digito1
            // 
            this.digito1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.digito1, "digito1");
            this.digito1.Maximum = 9;
            this.digito1.Name = "digito1";
            this.digito1.Value = 5;
            this.digito1.Scroll += new System.EventHandler(this.digito1_ValueChanged);
            this.digito1.ValueChanged += new System.EventHandler(this.digito1_ValueChanged_1);
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.checkBox2_CheckStateChanged);
            // 
            // checkBox4
            // 
            resources.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckStateChanged += new System.EventHandler(this.checkBox4_CheckStateChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            this.button1.Validated += new System.EventHandler(this.checkBox5_CheckStateChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.Segredo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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
        private System.Windows.Forms.Timer timer1;
    }
}

