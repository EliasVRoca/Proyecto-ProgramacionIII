using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto___Programacion_III___UPC.Form_num.funct_Num
{
    internal class Operaciones_Numericas_abel
    {
        public int Funcion_Mayor_N(int numero)
        {
            int digito_mayor = 0;
            for (int i = numero; i > 0;)
            {
                int digito = i % 10;
                if (digito > digito_mayor)
                {
                    digito_mayor = digito;
                }
                i = i / 10;
            }
            return digito_mayor;
        }

        public int suma_Pares(int numero)
        {
            int suma_pares = 0;
            for (int i = numero; i > 0;)
            {
                int digito = i % 10;
                if (digito % 2 == 0)
                {
                    suma_pares += digito;
                }
                i = i / 10;
            }
            return suma_pares;
        }

        public string mover_Mayor(string numero)
        {
            string mov_my_end;
            int digito_mayor = 1;
            int posicion_mayor = 0;
            for (int i = 0; i <= numero.Length - 1; i++)
            {
                int digito = int.Parse(numero[i].ToString());
                if (digito > digito_mayor)
                {
                    digito_mayor = digito;
                    posicion_mayor = i;
                }
            }
            mov_my_end = numero.Remove(posicion_mayor, 1) + digito_mayor.ToString();
            return mov_my_end;
        }
        public bool order_number(string numero)
        {

            for (int i = 0; i < numero.Length - 1; i++)
            {
                int r = i + 1;
                int primerV = int.Parse(numero[i].ToString());
                int segundV = int.Parse(numero[r].ToString());
                if (primerV > segundV)
                {
                    return false;

                }
            }
            return true;
        }

        public int contador_Cantidad_impares(string numero)
        {
            int controlador = 0;
            int contador = 0;
            for (int i = 0; i < numero.Length - 1; i++)
            {
                //int iter_normal = int.Parse(numero[i].ToString());
                int iter_sig_numero = int.Parse(numero[i + 1].ToString());

                if (iter_sig_numero % 2 == 0)
                {
                    for (int j = controlador; j <= i + 1; j++)
                    {
                        int iter_sig_numero_j = int.Parse(numero[j].ToString());

                        if (iter_sig_numero_j % 2 != 0)
                        {
                            contador += 1;
                        }
                        else if (j == i + 1)
                        {
                            controlador = i + 1;
                        }
                    }
                }

            }
            return contador;
        }
    }
}
