using System;
using System.Runtime.Remoting.Messaging;

namespace MonitoraCasos
{
    public class Calculo : Monitoramento
    {
        public (int, int) LocalizaInfectado(int qtdEstados, int qtdPessoas)
        {


            QtdEstados = qtdEstados;
            QtdPessoas = qtdPessoas;

            var randomNumberStates = new Random().Next(QtdEstados);
            var randomNumberPeople = new Random().Next(QtdPessoas);
            

            return (randomNumberStates, randomNumberPeople);
        }
    }
}