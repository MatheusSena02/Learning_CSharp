using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeExtensao
{ 
    //Precisa ser público e estático
    public static class StringExtension    //Cria-se uma classe que servirá para instanciar o método de extensão
    {
        public static  string? InverteString(this string str)  //O operador this é essencial, pois indica onde estará sendo feita a extensão. Nesse caso, está sendo feita uma extensão do tipo string
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        } 
    }
}
