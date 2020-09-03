using System;
using System.Threading;
using static System.Int32;

namespace MonitoraCasos
{
    public static class Parametros
    {
        public static char PessoaSaudavel { get; set; }
        public static char PessoaInfectada { get; set; }

        private static string PerguntaEstado()
        {
            Console.WriteLine("Quantos estados deseja monitorar?");
            return Console.ReadLine();
        }
        private static string PerguntaPessoas()
        {
            Console.WriteLine("Quantas pessoas deseja monitorar?");
            return Console.ReadLine();
        }

        private static bool IsNumber(string a) => TryParse(a, out _);

        private static void Error(this string a)
        {
            if (!IsNumber(a))
            {
                Console.WriteLine("Digite um número.");
                Thread.Sleep(1000);
            }
        }

        private static int QuestionarioPessoas()
        {
            var respostaPessoas = PerguntaPessoas();

            while (!IsNumber(respostaPessoas))
            {
                Error(respostaPessoas);
                respostaPessoas = PerguntaPessoas();
            }
            return Parse(respostaPessoas);

            var respostaEstados = PerguntaEstado();
            while (!IsNumber(respostaEstados))
            {
                Error(respostaEstados);
                respostaEstados = PerguntaPessoas();
            }
            var numeroEstados = Parse(respostaEstados);
        }
    }
}