using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler_PatikaDev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Notlar :

                Atama ve İşlemli Atama Operatörleri (=, +=, -=, *=, /=)
                Mantıksal Operatörler (||, &&, !)
                İlişkisel Operatörler (==,!=, <, >, >=,<=)
                Aritmetik (+, -, *, /, %, ++, --) */


            /*  string sentence = "This sentence has five words.";
              // Extract the second word.
              int startPosition = sentence.IndexOf(" ") + 1;
              string word2 = sentence.Substring(startPosition,
                                                sentence.IndexOf(" ", startPosition) - startPosition);
              Console.WriteLine("Second word: " + word2);
              // The example displays the following output:
              //       Second word: sentence */

            /*  DateTime dateAndTime = new DateTime(2011, 7, 6, 7, 32, 0);
              double temperature = 68.3;
              string result = String.Format("At {0:t} on {0:D}, the temperature was {1:F1} degrees Fahrenheit.",
                                            dateAndTime, temperature);
              Console.WriteLine(result);
            */

            // ATAMA VE İŞLEMLİ ATAMA

              int x = 3;
              int y=4;
              y = y + 10;
              x = x + y;



              Console.WriteLine("x ve y sırasıyla   " +  x + " " + y); 

             // mantıksal operatorler :

               bool isSuccess = true;
               bool isCompleted = false;

               if(isSuccess && isCompleted )
               {
                   Console.WriteLine("Perfect!");

               }
               if(isSuccess || isCompleted )
               {
                   Console.WriteLine("Great!");

               }
               if (isSuccess && !isCompleted ) 
               {
                   Console.WriteLine("Wonderfull!"); 
               }
            

            // ilişkisel operatör:

               int a = 15;
               int b = 24;

               if(a > b)
               {
                   Console.WriteLine("sonuc yanlıs");

               }
               else if(a < b)
               {
                   Console.WriteLine("Sonuc dogru");
               } 
               

            // aritmetik operatörler:

            int sayi = 10;

            int sayi2 = 5;

            int sonuc2 = ++sayi;
            Console.WriteLine(sonuc2);

            int sonuc1 = sayi / sayi2;
            Console.WriteLine(sonuc1);



            Console.ReadLine(); 










        }
    }
}
