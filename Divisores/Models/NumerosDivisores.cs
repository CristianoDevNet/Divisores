using System.Collections.Generic;

namespace Divisores.Models
{
    public class NumerosDivisores
    {
        public List<int> NaoPrimos { get; set; }

        public List<int> Primos { get; set; }

        public NumerosDivisores()
        {
            NaoPrimos = new List<int>();

            Primos = new List<int>();
        }
    }
}
