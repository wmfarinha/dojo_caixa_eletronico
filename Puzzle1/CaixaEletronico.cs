using System;

namespace Puzzle1
{
    public class CaixaEletronico
    {
        public Notas Saque(int value)
        {
            int notaResult;

            var notasCem = Math.DivRem(value, 100, out notaResult);
            var notasCinquenta = Math.DivRem(notaResult, 50, out notaResult);
            var notasVinte = Math.DivRem(notaResult, 20, out notaResult);
            var notasDez = Math.DivRem(notaResult, 10, out notaResult);

            //if (notaResult > 0) new Exception("Valor não permitido");

            return new Notas(notasDez, notasVinte, notasCinquenta, notasCem);
        }
    }
}
