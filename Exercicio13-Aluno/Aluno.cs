using System;

namespace Exercicio
{
    internal class Aluno
    {
        public string Nome;
        public double Nota, Nota1, Nota2;


        public double NotaFinal()
        {
            return Nota + Nota1 + Nota2;

        }
        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }

    }
}
