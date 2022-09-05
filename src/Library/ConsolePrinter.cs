using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {

        //Principio SRP por single responsability principle ya que Recipy.cs ya no se encarga de imprimir el ticket, ahora ConsolePrinter lo hace.

        public static void PrintToConsole(ArrayList steps,Product FinalProduct){
            Console.WriteLine($"Receta de {FinalProduct.Description}:");
            foreach (Step step in steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}