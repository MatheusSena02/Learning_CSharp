using System;

namespace Exercicio
{
    public class GenericsClass<T>
    {
        T[] array = new T[5];
        // OBS: Dentro desta classe já usamos 'array[index]' normalmente porque 'array' é um T[].
        // Porém, de fora, quem instanciar GenericsClass<T> não enxerga esse campo interno.
        int contador = 0;

        public void Adicionar(T elemento)
        {
            if(contador < 5)
            {
                array[contador] = elemento;
            }
            contador++;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}