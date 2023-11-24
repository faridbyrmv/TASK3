namespace TASK;
class Program
{
    static void Main(string[] args)
    {
        /* MISAL 1

        Console.Write("1");
        int inputNumber = 555;

        int result = inputNumber * 1000 + inputNumber;

        Console.WriteLine($"Neticen : {result}");

        */

         /*-------------------------------------------------------*/
         
        /* MISAL 2

        Console.Write("2");
        int inputNumber = 6666;

        int firstPart = inputNumber * 10 + 7 ;

        int result = firstPart * 10 + 8;

        Console.WriteLine($"Netice : {result}");

        */

         /*-------------------------------------------------------*/

         /* MISAL 3

        Console.Write("3");
        int inputNumber = 12345;

        double firstPercentage = inputNumber * 0.18;

        double secondPercentage = inputNumber * 0.03;

        Console.WriteLine($"Evvelinde 18% : {firstPercentage}");
        Console.WriteLine($"Sonra ise 3% : {secondPercentage}");
        */

        /*-------------------------------------------------------*/

        /* MISAL 4

        Console.Write("4");
        int inputNumber = 976;

        int result = inputNumber + 7;

        double percentage = result * 0.07;

        Console.WriteLine($"Evveline 7 elave edilib: {result}");
        Console.WriteLine($"Sonra ise 7%: {percentage}");

        */

         /*-------------------------------------------------------*/
         
         /* MISAL 5

         Console.Write("5");
         int inputNumber = 1111;

         int firstPart = (inputNumber / 1000 + 4) * 1000;

         int result = firstPart + 44;

         double percentage = result * 0.44;

         Console.WriteLine($"Evvvelindeki 4 artirilib : {firstPart}");
         Console.WriteLine($"Sonra ise 44 elave edilib : {result}");
         Console.WriteLine($"Sonra ise 44%: {percentage}");
        */
        
         /*-------------------------------------------------------*/
         
         /*  MISAL 6

         Console.Write("6");

        int inputNumber = 7678;

        double firstPercentage = inputNumber * 0.20;

        double secondPercentage = (inputNumber + firstPercentage) * 0.10;

        double resultSquare = Math.Pow(inputNumber + firstPercentage + secondPercentage, 2);

        Console.WriteLine($"Evvelindeki 20%: {firstPercentage}");
        Console.WriteLine($"Sonra ise cavabin 10%: {secondPercentage}");
        Console.WriteLine($"Sonra ise cavabin kvadrati: {resultSquare}");
        */
        
         /*-------------------------------------------------------*/
         
         /*  MISAL 7

         Console.Write("");
         int firstNumber = 22222;

         Console.Write("");
         int secondNumber = 11111;

        // Ededleri topluyur
         int sum = firstNumber + secondNumber;

        // Elde edilen neticenin evvelinde ve axrinda 5 elave et
         int result = sum + 5;

        // Neticenin 5% tap
         double percentage = result * 0.05;

        // Neticeni cap et
        Console.WriteLine($"Ededlerin cemi: {sum}");
        Console.WriteLine($"Elde edilen neticenin evvelinde ve axrinda 5 elave edilib: {result}");
        Console.WriteLine($"Sonra ise necitenin 5%: {percentage}");
        */

         /*-------------------------------------------------------*/
         
        /* MISAL 8
        Console.Write("");
        int firstNumber = 4444;

        Console.Write("");
        long secondNumber = 3333666;

        double firstPercentage = firstNumber * 0.04;

        double secondPercentage = secondNumber * 0.09;

        double sum0fPercentages = firstPercentage + secondPercentage;

        double finalPercentage = sum0fPercentages * 0.10;

        Console.WriteLine($"Birinci ededin 4%: {firstPercentage}");
        Console.WriteLine($"Ikinci ededin 9%: {secondPercentage}");
        Console.WriteLine($"Faizlerin cemi: {sum0fPercentages}");
        Console.WriteLine($"Sonra ise neticenin 10%: {finalPercentage}");
        */

        /*-------------------------------------------------------*/

        /* MISAL 9
        Console.Write("");
        long firstNumber = 111111;

        Console.Write("");
        long secondNumber = 222222;

        Console.Write("");
        long thirdNumber = 333333;

        double firstPercentage = firstNumber * 0.10;
        double secondPercentage = secondNumber * 0.10;
        double thirdPercentage = thirdNumber * 0.10;

        double sum0fPercentages = firstPercentage + secondPercentage + thirdPercentage;

        double finalPercentage = sum0fPercentages * 0.10;

        Console.WriteLine($"Birinci ededin 10%: {firstPercentage}");
        Console.WriteLine($"ikinci ededin 10$: {secondPercentage}");
        Console.WriteLine($"ucuncu ededin 10%: {thirdPercentage}");
        Console.WriteLine($"faizlerin cemi: {sum0fPercentages}");
        Console.WriteLine($"Sonra ise cemin 10%: {finalPercentage}");
        */

        /*-------------------------------------------------------*/

        Console.Write("");
        int firstNumber = 2000;

        Console.Write("");
        int secondNumber = 3000;

        Console.Write("");
        int thirdNumber = 1000;

        double firstPercentage = firstNumber * 0.01;
        double secondPercentage = secondNumber * 0.02;
        double thirdPercentage = thirdNumber * 0.03;

        double subtractionResult = firstPercentage - secondPercentage - thirdPercentage;

        double finalResult = subtractionResult + ( thirdNumber * 0.07);

        Console.WriteLine($"Birinci ededin 1%: {firstPercentage}");
        Console.WriteLine($"Ikinci ededin 2%: {secondPercentage}");
        Console.WriteLine($"Ucuncu ededin 3%: {thirdPercentage}");
        Console.WriteLine($"Faizlerin bir birinden cixmaq: {subtractionResult}");
        Console.WriteLine($"Sonra ise III ededin 7% faizi edlave edilib: {finalResult}");


    }
}
