using System;
using System.Runtime.Remoting.Messaging;

namespace MonitoraCasos
{
    public class Calculo : Monitoramento
    {
        public (int, int) Infectados()
        {
            var monitoras = new Monitoramento();


            var randomNumber = new Random().Next(QtdCidades * QtdEstados);

            return (1, 1);
        }
    }
}