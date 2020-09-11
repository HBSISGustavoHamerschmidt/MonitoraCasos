using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Net.Security;
using System.Threading;
using static MonitoraCasos.Parametros;

namespace MonitoraCasos
{
    internal class Program
    {
        private static void Main()
        {
            var backgroundRed = ConsoleColor.DarkRed;
            var backgroundBlack = ConsoleColor.Black;
            PessoaSaudavel = '#';
            PessoaInfectada = '@';
            TempoEmSegundos = 1;

            var (item1, item2) = PromptUser();


            var list = new List<string>();
            var pessoasEstados = string.Empty;


            // Creates list
            for (var i = 0; i < item2; i++)
            {
                pessoasEstados += PessoaSaudavel;
            }
            for (var i = 0; i < item1; i++)
            {
                list.Add(pessoasEstados);
            }

            var timer = 0;

            /* for (var i = 0; i < 60; i++)
            {
                timer += TempoEmSegundos;
                System.Threading.Thread.Sleep(1000 * TempoEmSegundos);
            }


            foreach (var i in list)
            {
                Console.WriteLine(i);
            } */
            while (timer < 60)
            {
                for (var i = 0; i < list.Count; i++)
                {
                    var (state, people) = new Calculo().LocalizaInfectado((item1), (item2));
                    if (i == state)
                    {
                        Console.BackgroundColor = backgroundRed;
                        var newList = string.Empty;

                        for (var j = 0; j < list[i].Length; j++)
                        {
                            
                            if (j != people)
                            {
                                newList += list[i][j];
                            }
                            else
                            {
                                newList += PessoaInfectada;
                            }
                        }

                        list[i] = newList;
                        Console.WriteLine(list[i]);
                    }
                    else
                    {
                        Console.BackgroundColor = backgroundBlack;
                        Console.WriteLine(list[i]);
                    }
                }

                timer++;
                
            }

            Console.ReadKey();
        }
    }
}
