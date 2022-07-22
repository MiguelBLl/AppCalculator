using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.CodeDom.Compiler;
using System.Reflection;

namespace AppCalculator
{
    public partial class MainPage : ContentPage{

        double firtsNum;
        double secondNum;
        double thirdNum;
        double fothyNum;
        double quintNum;
        string operador_1;
        string operador_2;
        string operador_3;
        string operador_4;
        string[] operadors;
        string inOperador;
        double result = 0;

        public MainPage()
        {
            InitializeComponent();
            operadors = new string[4];
        }

        private void Btn_sumar(object sender, EventArgs e)
        {
            lblNumber.Text += "+";
            inOperador = "+";
        }        

        private void Btn_restar(object sender, EventArgs e)
        {
            lblNumber.Text += "-";
            inOperador = "-";
        }

        private void Btn_producto(object sender, EventArgs e)
        {
            lblNumber.Text += "*";
            inOperador = "*";
        }

        private void Btn_division(object sender, EventArgs e)
        {
            lblNumber.Text += "/";
            inOperador = "/";
        }

        private void Btn_AC(object sender, EventArgs e)
        {
            if (lblNumber.Text != null){
                lblNumber.Text = "";
            }       
        }

        private void Btn_C(object sender, EventArgs e)
        {
            string lblText = lblNumber.Text;
            if (lblText != null){                
                lblNumber.Text = lblText.Remove(lblText.Length - 1);
            }
            
        }
        
        private void Btn_Result(object sender, EventArgs e)
        {
            Operaciones();
            lblNumber.Text = result.ToString();
        }

 

        public void Operaciones(){

            spnSecond.Text = inOperador;
            string lblText = lblNumber.Text;


            for (int i = 0; i < lblText.Length; i++){               //Recorrer el vector de los signos
                if (lblText.Substring(i, 1) == inOperador){
                        spnFirts.Text = lblText.Remove(i, (lblText.Length - i));
                        spnThird.Text = lblText.Remove(0, i+1); ;
                    }
                
            }

            
            switch (inOperador){
                case "+":
                    result = double.Parse(spnFirts.Text) + double.Parse(spnThird.Text);
                    break;
                case "-":
                    result = double.Parse(spnFirts.Text) - double.Parse(spnThird.Text);
                    break;
                case "*":
                    result = double.Parse(spnFirts.Text) * double.Parse(spnThird.Text);
                    break;
                case "/":
                    result = double.Parse(spnFirts.Text) / double.Parse(spnThird.Text);
                    break;
            }

        }

        private void Btn_num1(object sender, EventArgs e)
        {
            lblNumber.Text += "1";
        }
        private void Btn_num2(object sender, EventArgs e)
        {
            lblNumber.Text += "2";
        }
        private void Btn_num3(object sender, EventArgs e)
        {
            lblNumber.Text += "3";
        }
        private void Btn_num4(object sender, EventArgs e)
        {
            lblNumber.Text += "4";
        }
        private void Btn_num5(object sender, EventArgs e)
        {
            lblNumber.Text += "5";
        }
        private void Btn_num6(object sender, EventArgs e)
        {
            lblNumber.Text += "6";
        }
        private void Btn_num7(object sender, EventArgs e)
        {
            lblNumber.Text += "7";
        }
        private void Btn_num8(object sender, EventArgs e)
        {
            lblNumber.Text += "8";
        }
        private void Btn_num9(object sender, EventArgs e)
        {
            lblNumber.Text += "9";
        }
        private void Btn_num0(object sender, EventArgs e)
        {
            lblNumber.Text += "0";
        }
        private void Btn_point(object sender, EventArgs e)
        {
            lblNumber.Text += ".";
        }
    }
}
