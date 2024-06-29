using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ProgramacionIII
{
    internal class Helpers
    {

        public int nuevoNumero(int numero, int nuevoDigito)
        {
            int digitos = contarDigitos(numero);
            nuevoDigito = nuevoDigito * potencia(10, digitos);
            int respuesta = nuevoDigito + numero;
            return respuesta;
        }

        public bool esFibonacci(int numero)
        {
            int a = 0;
            int b = 1;
            int c = a + b;
            while (c <= numero)
            {
                if (numero == c)
                {
                    return true;
                }
                a = b;
                b = c;
                c = a + b;
            }
            return false;
        }
        public int factorial(int numero)
        {
            int i = 1;
            int resultado = 1;
            while (i <= numero)
            {
                resultado = resultado * i;
                i++;
            }
            return resultado;
        }

        public bool esPrimo(int numero)
        {
            int i = 2;
            while (i < numero)
            {
                if (numero % i == 0)
                {
                    return false;
                }
                i++;
            }
            return true;
        }



        public int colocarInicio(int num)
        {

            int digito = num % 10;
            int resto = num / 10;
            int numeroDigitos = contarDigitos(resto);
            int primero = digito * potencia(10, numeroDigitos);
            int resultado = primero + resto;
            return resultado;
        }

        public bool esPar(int numero)
        {
            if (numero % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int contarDigitos(int num)
        {
            int contador = 0;
            while (num > 0)
            {
                num = num / 10;
                contador++;
            }
            return contador;
        }

        public int potencia(int numero, int elevado)
        {
            int res = 1;
            int i = 0;
            while (i < elevado)
            {
                res = res * numero;
                i++;
            }
            return res;
        }

        public int mayor(int num1, int num2)
        {
            int mayor;
            if (num1 > num2)
            {
                mayor = num1;
            }
            else
            {
                mayor = num2;
            }
            return mayor;
        }

        public int suma(int x, int y)
        {
            int suma = x + y;
            return suma;
        }
    }


}
