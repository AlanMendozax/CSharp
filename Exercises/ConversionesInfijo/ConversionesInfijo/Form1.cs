using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionesInfijo
{
    public partial class Form1 : Form
    {
        Stack pila = new Stack();
        char dato;
        int tope = -1, max=0;
        Boolean res;       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        } 
        PilaAA(int max)
        {
            this.max = max;
            pila= new Stack[max];
            dato = '0';
        }
        public void borrarPila()
        {
            tope = -1;
        }
        public Boolean llena()
        {
            if (tope == (max -1))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
        public Boolean vacia()
        {
            if(tope == -1)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
        public Boolean push(char dato)
        {
            if (llena())
            {
                MessageBox.Show("Error: Pila llena");
            }
            else
            {
                tope++;
                pila[tope] = dato;
                res = true;
            }
            return res;
        }
        public char pop()
        {
            if (vacia())
            {
                MessageBox.Show("Sub-desbordamiento: Pila vacia");
            }
            else
            {
                dato = pila[tope];
                tope--;
            }
            return dato;
        }

        public char GetTope()
        {
            char top = '0';
            if (vacia())
            {

            }
            else
            {
                top = pila[tope];
                return top;
            }            
        }
    }
}
