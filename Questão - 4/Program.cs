using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão___4
{
    class Program
    {
        static void Main(string[] args)
        {
        // calcular a equação horária do carro

            /*
                equação horária do carro:
                x1 = v1*t.

                equação horária do caminhão:
                x2 = 100km - v2 * t.

                tempo de viagem sem os obstáculos(caminhão):
                Tso = 100km / 80km = 1,25h.
            
                porem como perde 10 min o equivalente a (0,17 horas) nos pedágios o tempo
                de viagem dele sera de 1,25h + 0,17h = 1,42h.
                
                velocidade media:
                V2 = 100km / 1,42h = 70,6 km/h.

                nas equações horarias limpamos o tempo e igulamos ela para achar o 
                ponto em que o caminhão e o carro se cruzam.
                
                t = x1 / v1
                t = (x2 - 100km)/(-v2)
                x1 = x2 --> x / v1 = (x-100km) / (-v2)
                -v2 * x = v1 * x - v1 * 100km
                x = (v1 * 100km) / v1+v2 = (110km * 100km) / 110km + 70,6km/h
                x = 60,9km

                Essa é a distancia da cidade de ribeirão preto em que o carro e
                o caminhão se cruzam, ambos estão a mesma distância.

             */
         
        }
    }
}
