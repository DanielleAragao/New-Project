using System;
using System.Collections.Generic;
using System.Text;

namespace New_Project
{
    public class Calculadora
    {
        private List<string> listahistorico;
        private string data;

        
        public Calculadora(string data)
        {
            listahistorico = new List<string>();
            this.data = data;
        }
       
        public int somar(int num1, int num2)
        {
            int res = num1 + num2;

            listahistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }
        public int subtrair(int num1, int num2)
        {
            int res = num1 - num2;
            listahistorico.Insert(0, "Res: " + res + " - data: " + data); 
            return res;
        }
        public int multiplicar(int num1, int num2)
        {
            int res = num1 * num2;
            listahistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }
        public int dividir(int num1, int num2)
        {
            int res = num1 / num2;
            listahistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }
        public List<string> historico()
        {
            List<string> res;
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }
    }
}
