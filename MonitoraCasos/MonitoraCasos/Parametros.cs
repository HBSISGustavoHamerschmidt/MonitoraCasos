using System;
using static System.Console;
using static System.Convert;
using static System.Int32;
using static System.Threading.Thread;

namespace MonitoraCasos
{
    public static class Parametros
    {

        public static char PessoaSaudavel { get; set; }
        public static char PessoaInfectada { get; set; }
        public static int TempoEmSegundos { get; set; }

        private static string PerguntaEstado()
        {
            WriteLine("Quantos estados deseja monitorar?");
            return ReadLine();
        }

        private static string PerguntaPessoas()
        {
            WriteLine("Quantas pessoas deseja monitorar?");
            return ReadLine();
        }

        private static bool VerificaResposta(string a) => TryParse(a, out _);

        private static void IfNecessaryPrintError(string a, out int b)
        {
            while (!VerificaResposta(a))
            {
                WriteLine("Digite um número.");
                a = PerguntaPessoas();
                Sleep(1000);
            }
            b = ToInt32(a);
        }

        private static int PromptUserSecond()
        {
            var respostaPessoas = PerguntaPessoas();
            IfNecessaryPrintError(respostaPessoas, out var answer);
            return answer;
        }

        public static (int, int) PromptUser()
        {
            int answerEstados;
            do
            {
                var respostaEstados = PerguntaEstado();
                IfNecessaryPrintError(respostaEstados, out answerEstados);

                if (answerEstados > 27)
                    WriteLine("No Brasil temos somente 27 estados.");
            } while (answerEstados > 27);

            Clear();
            return (answerEstados, PromptUserSecond());
        }
    }
}