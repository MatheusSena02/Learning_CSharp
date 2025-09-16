using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPropostos
{
    public class Exercicio1
    {
        private int valor;

        public int Valor
        {
            get { return valor; } 
            set { valor = value; }
        }

        public void SetValor()
        {
            try
            {
                string? entrada = null;
                Console.Write("Digite o valor: ");
                entrada = Console.ReadLine();
                if(entrada == null)
                {
                    throw new ArgumentNullException(entrada, "A entrada não permite valores nulos");
                    //Essa exceção é lançada quando um método é invocado e pelo menos um dos argumentos passados é null, mas nunca deveria ser null
                }else if (string.IsNullOrWhiteSpace(entrada)) //Indica se uma cadeia de caracteres é null, vazia ou consiste apenas em caracteres de espaço em branco
                {
                    throw new ArgumentException("A entrada não pode ser vazia");
                }
                else
                {
                    Console.Write($"Entrada: {entrada}\n");
                }
            }catch (ArgumentNullException ex) 
            {
                Console.WriteLine($"Erro: {ex.Message}");  
            }catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }finally
            {
                Console.WriteLine("Operação concluída");
            }
            
        }
    }
}
