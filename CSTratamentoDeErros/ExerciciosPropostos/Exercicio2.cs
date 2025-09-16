using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPropostos
{
    public class Exercicio2
    {
        private int[] listaNumeros = new int[] {103, 211, 313, 405, 519, 617, 711, 891, 951, 1001};

        public int[] ListaNumeros
        {
            get
            {
                return listaNumeros;
            }
        }

        public void ExibirValores()
        {
            for(int i = 0; i <  listaNumeros.Length; i++)
            {
                Console.WriteLine($"{i+1}. {listaNumeros[i]}");
            }
        }

        public void BuscarPorIndice()
        {
            try
            {
                int indice;
                Console.Write("Digite o índice do valor que deseja imprimir: ");
                indice = Convert.ToInt16(Console.ReadLine());
                if(indice == null)
                {
                    throw new ArgumentNullException("Não é permitido valores nulos");
                }else if(indice > listaNumeros.Length || indice < 0)
                {
                    throw new IndexOutOfRangeException("Índice fora do excopo possível");
                }
                else
                {
                    Console.WriteLine($"Valor correspondente: {listaNumeros[indice]}");
                }
            }catch(ArgumentNullException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                Console.WriteLine(ex.Source);
            }catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\n\tOperação concluída");
            }
        }
    }
}
