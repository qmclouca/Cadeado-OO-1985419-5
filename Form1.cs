using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cadeado_OO_1985419_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int senha = 58419;

        public int Senha { get => senha; set => senha = value; }

        private void AddMyScrollEventHandlers()
        {
            // Create and initialize a VScrollBar.
            VScrollBar digito1 = new VScrollBar();
            VScrollBar digito2 = new VScrollBar();
            VScrollBar digito3 = new VScrollBar();
            VScrollBar digito4 = new VScrollBar();
            VScrollBar digito5 = new VScrollBar();
            // Add event handlers for the OnScroll and OnValueChanged events.
            digito1.Scroll += new ScrollEventHandler(
               this.digito1_Scroll);
            digito1.ValueChanged += new EventHandler(
               this.digito1_ValueChanged);
            digito2.Scroll += new ScrollEventHandler(
                  this.digito2_Scroll);
            digito2.ValueChanged += new EventHandler(
               this.digito2_ValueChanged);
            digito3.Scroll += new ScrollEventHandler(
              this.digito3_Scroll);
            digito3.ValueChanged += new EventHandler(
               this.digito3_ValueChanged);
            digito4.Scroll += new ScrollEventHandler(
              this.digito4_Scroll);
            digito4.ValueChanged += new EventHandler(
               this.digito4_ValueChanged);
            digito5.Scroll += new ScrollEventHandler(
              this.digito5_Scroll);
            digito5.ValueChanged += new EventHandler(
               this.digito5_ValueChanged);
        }
        private void digito1_ValueChanged(Object sender,
                                              EventArgs e)
        {
            // Display the new value in the label.
            label1.Text = "vScrollBar Value:(OnValueChanged Event) " + digito1.Value.ToString();
        }
        private void digito2_ValueChanged(Object sender,
                                             EventArgs e)
        {
            // Display the new value in the label.
            label2.Text = "vScrollBar Value:(OnValueChanged Event) " + digito2.Value.ToString();
        }
        private void digito3_ValueChanged(Object sender,
                                             EventArgs e)
        {
            // Display the new value in the label.
            label3.Text = "vScrollBar Value:(OnValueChanged Event) " + digito3.Value.ToString();
        }
        private void digito4_ValueChanged(Object sender,
                                             EventArgs e)
        {
            // Display the new value in the label.
            label4.Text = "vScrollBar Value:(OnValueChanged Event) " + digito4.Value.ToString();
        }
        private void digito5_ValueChanged(Object sender,
                                             EventArgs e)
        {
            // Display the new value in the label.
            label5.Text = "vScrollBar Value:(OnValueChanged Event) " + digito5.Value.ToString();
        }
        private void digito1_Scroll(Object sender,
                                        ScrollEventArgs e)
        {
            // Display the new value in the label.
            label1.Text = "VScrollBar Value:(OnScroll Event) " + e.NewValue.ToString();
        }
        private void digito2_Scroll(Object sender,
                                       ScrollEventArgs e)
        {
            // Display the new value in the label.
            label2.Text = "VScrollBar Value:(OnScroll Event) " + e.NewValue.ToString();
        }
        private void digito3_Scroll(Object sender,
                                       ScrollEventArgs e)
        {
            // Display the new value in the label.
            label3.Text = "VScrollBar Value:(OnScroll Event) " + e.NewValue.ToString();
        }
        private void digito4_Scroll(Object sender,
                                       ScrollEventArgs e)
        {
            // Display the new value in the label.
            label4.Text = "VScrollBar Value:(OnScroll Event) " + e.NewValue.ToString();
        }
        private void digito5_Scroll(Object sender,
                                       ScrollEventArgs e)
        {
            // Display the new value in the label.
            label5.Text = "VScrollBar Value:(OnScroll Event) " + e.NewValue.ToString();
        }
        private void Button1_Click(Object sender,
                                  EventArgs e)
        {


        }
        private void digito1_ValueChanged_1(object sender, EventArgs e)
        {
            label1.Text = digito1.Value.ToString();
        }
        private void digito2_ValueChanged_1(object sender, EventArgs e)
        {
            label2.Text = digito2.Value.ToString();
        }
        private void digito3_ValueChanged_1(object sender, EventArgs e)
        {
            label3.Text = digito3.Value.ToString();
        }
        private void digito4_ValueChanged_1(object sender, EventArgs e)
        {
            label4.Text = digito4.Value.ToString();
        }
        private void digito5_ValueChanged_1(object sender, EventArgs e)
        {
            label5.Text = digito5.Value.ToString();
        }
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            digito1.Enabled = false;
            digito2.Visible = true;
            label2.Visible = true;
            checkBox1.Enabled = false;
            checkBox2.Visible = true;
            checkBox2.Enabled = true;
            label6.Text = label1.Text;
            label6.Visible = true;


        }
        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            digito2.Enabled = false;
            digito3.Visible = true;
            label3.Visible = true;
            checkBox2.Enabled = false;
            checkBox3.Visible = true;
            checkBox3.Enabled = true;
            label7.Text = label2.Text;
            label7.Visible = true;
        }
        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            digito3.Enabled = false;
            digito4.Visible = true;
            label4.Visible = true;
            checkBox3.Enabled = false;
            checkBox4.Visible = true;
            checkBox4.Enabled = true;
            label8.Text = label3.Text;
            label8.Visible = true;

        }
        private void checkBox4_CheckStateChanged(object sender, EventArgs e)
        {
            digito4.Enabled = false;
            digito5.Visible = true;
            label5.Visible = true;
            checkBox4.Enabled = false;
            checkBox5.Visible = true;
            checkBox5.Enabled = true;
            label9.Text = label4.Text;
            label9.Visible = true;
        }
        private void checkBox5_CheckStateChanged(object sender, EventArgs e)
        {
            digito5.Enabled = false;
            label5.Visible = true;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            label10.Text = label5.Text;
            label10.Visible = true;
            button1.Visible = true;
            //colocar o método responsável pela comparação das senhas no button1
        }
        private void Segredo_Enter(object sender, EventArgs e)
        {

        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            int senhainformada = digito1.Value * 10000 + digito2.Value * 1000 + digito3.Value * 100 + digito4.Value * 10 + digito5.Value;
            timer1.Enabled = true;
            if (senha.Equals(senhainformada))
            {
                button1.Text = "Senha Correta!";
                button1.BackColor = Color.BlueViolet;
            
            } else
            {
                button1.BackColor = Color.Red;
                button1.Text = "Senha Incorreta";
                if (timer1.Equals(10000))
                {
                    Application.Exit();
                }

            }
        }
        
    
    }
}
