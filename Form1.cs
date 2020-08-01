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
        private void Digito1_ValueChanged(Object sender, EventArgs e){
            label1.Text = digito1.Value.ToString();
        }
        private void Digito2_ValueChanged(Object sender, EventArgs e){
            label2.Text = digito2.Value.ToString();
        }
        private void Digito3_ValueChanged(Object sender, EventArgs e){
            label3.Text = digito3.Value.ToString();
        }
        private void Digito4_ValueChanged(Object sender, EventArgs e){
            label4.Text = digito4.Value.ToString();
        }
        private void Digito5_ValueChanged(Object sender, EventArgs e){
            label5.Text = digito5.Value.ToString();
        }
        // Create the Scroll event handler.
        private void Digito1_Scroll(Object sender, ScrollEventArgs e)
        {
            // Display the new value in the label.
            label1.Text = "VScrollBar Value:(OnScroll Event) " + e.NewValue.ToString();
        }
        private void Digito2_Scroll(Object sender, ScrollEventArgs e)
        {
            // Display the new value in the label.
            label2.Text = "VScrollBar Value:(OnScroll Event) " + e.NewValue.ToString();
        }
        private void Digito3_Scroll(Object sender, ScrollEventArgs e)
        {
            // Display the new value in the label.
            label3.Text = "VScrollBar Value:(OnScroll Event) " + e.NewValue.ToString();
        }

        private void Digito4_Scroll(Object sender, ScrollEventArgs e)
        {
            // Display the new value in the label.
            label4.Text = "VScrollBar Value:(OnScroll Event) " + e.NewValue.ToString();
        }

        private void Digito5_Scroll(Object sender, ScrollEventArgs e)
        {
            // Display the new value in the label.
            label5.Text = "VScrollBar Value:(OnScroll Event) " + e.NewValue.ToString();
        }
        private void Digito1_ValueChanged_1(object sender, EventArgs e){
            label1.Text = digito1.Value.ToString();
        }
        private void Digito2_ValueChanged_1(object sender, EventArgs e){
            label2.Text = digito2.Value.ToString();
        }
        private void Digito3_ValueChanged_1(object sender, EventArgs e){
            label3.Text = digito3.Value.ToString();
        }
        private void Digito4_ValueChanged_1(object sender, EventArgs e){
            label4.Text = digito4.Value.ToString();
        }
        private void Digito5_ValueChanged_1(object sender, EventArgs e){
            label5.Text = digito5.Value.ToString();
        }
        private void CheckBox1_CheckStateChanged(object sender, EventArgs e)
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
        private void CheckBox2_CheckStateChanged(object sender, EventArgs e)
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
        private void CheckBox3_CheckStateChanged(object sender, EventArgs e)
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
        private void CheckBox4_CheckStateChanged(object sender, EventArgs e)
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
        private void CheckBox5_CheckStateChanged(object sender, EventArgs e)
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
        private void Button1_Click(Object sender, EventArgs e)
        {


        }
    }
}
