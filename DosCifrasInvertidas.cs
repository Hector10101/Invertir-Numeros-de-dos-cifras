using System;

namespace Invertir_Numeros_de_Dos_Cifras 
{
    class Program
    {
        static void Main(string[] args){
            //Variables a utilizar
            bool Condition = true;
            bool ConditionInsert;
            int InsertNum;
            string Longitud = "";
            do{
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("****Números Invertidos****");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Inserte Su Numero de dos cifras");

                ConditionInsert = int.TryParse(Console.ReadLine(), out InsertNum);

                /*De ser verdadero, el arreglo en la posición 'i' tomara
                el valor ingresado*/
                if(ConditionInsert == true){
                    /*Longitud Convertira el valos de InsertNum a string para 
                        poder tomar la longitud de este e imprimir los datos.*/
                    Longitud = Convert.ToString(InsertNum);
                    //Se verifica que cumpla con tan solo dos digitos.
                    if(Longitud.Length == 2){
                        Console.Write("\nSu numero a la inversa: ");
                        for(int i=1; i >= 0; i--){
                            Console.Write(Longitud[i]);
                        }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\nSi desea salir pulse '1'");
                        Console.ForegroundColor = ConsoleColor.White;
        
                        string Continuar = Console.ReadLine();
                        //Si se inserta '1'
                        if(Continuar == "1"){
                            /*Cambia la condición a falso, de modo que se 
                                cerrará el programa.*/
                            Condition = false;
                            Console.Clear();
                            Console.WriteLine("Hasta luego! :)");
                        }else{  //Sino
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Reiniciando... ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Pulse alguna tecla.");
                        }
                    }else{ //De no ser dos la longitud del valor ingresado.
                        //Si este es menor.
                        if(Longitud.Length < 2){
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nNo ha alcanzado las dos cifras indicadas");
                        }else if(Longitud.Length > 2){ //Sino, si es mayor a dos.
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nSe excedio la cantidad de cifras");
                        }
                    } 
                }else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Debe ingresar un valor numerico entero!");
                }
                Console.ReadKey();
                Console.Clear();
            }while (Condition == true);          
        }
    }
}

