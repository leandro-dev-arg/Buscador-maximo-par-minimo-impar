using System;

namespace U5_programa_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,maximopar,minimoimpar;
            bool banderapar;
            bool banderaimpar;
            banderapar=false;
            banderaimpar=false;
            maximopar=0;
            minimoimpar=0;
            //ciclo for que pide 20 numeros y lo va aguardando en la misma variable 
            for (int i = 0; i < 20; i++) {
                Console.WriteLine("ingrese un numero porfavor");
                num=int.Parse(Console.ReadLine());
//aca pregunto si el numero que esta ingresado en este momento, lo divido por dos y el resto me da 0,entonce me voy para el lado de los pares, y vuelvo a preguntar ya hay algun numero para?(banderapara) sino hay(banderapar==0) entonces gurdame el numero que acabdo de poner como el maximo de los pares, y cambiame la banderapa a 1 para indicar que ya hay guardado un maximopar, sino, vuelvo para atras y si la respuesta fusese que ya hay algun maximo par guardado pregunto*
                if (num%2==0)
                {
                 if (banderapar==false){
                    maximopar=num;
                    banderapar=true;
//*el nuevo numero que acabo de ingresar es mayor al maximo par que tenias guardad? si es mayor, guarda el nuevo numero como el maximo par,sino no hagas nada
                 }  else if (num>maximopar){
                    maximopar=num;
                 } 
  //sino, sil resto del numero con dos no da 0,entoces es impar,entoces pregunto,sino tienes ningun numpor impar(!banderaimpar), entonces el minimo impar es el numero actual,y pasa banderaimpar a 1,para avisar que ya hay un nuevo minimo impar,por el contrariosi ya habia un minimoimpar,pregunto,el numero actual,es menor al minimoimpar?si es verdadero entonces el numero actual es el nuevo minimoimpar             
                }else if (!banderaimpar)
                {
                    minimoimpar=num;
                    banderaimpar=true;
                }else if (num<minimoimpar)
                {
                    minimoimpar=num;
                }
            }

            Console.WriteLine("el maximo par es "+maximopar);
            Console.WriteLine("el minimo impar es es "+minimoimpar);
            





        }
    }
}
