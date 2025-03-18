namespace Task_List
{
    internal class Program
    {
        static void Main(string[] args)
        {

                    //Done
            //- Don't allow duplicate entries
            //- Sorting ASC / DESC
            //- SWAP
            
            Console.Title = "list the numbers";
            Console.ForegroundColor = ConsoleColor.Green;


            List<int> numbers = new List<int>() {};
            string choice;


            do
            {

                Console.WriteLine("\n     ________Menu Options_________ \n");
                Console.WriteLine("|     P - Print numbers                |");
                Console.WriteLine("|     A - Add a number                 |");
                Console.WriteLine("|     M - Display mean of the number   |");
                Console.WriteLine("|     S - Display the smallest numbe   |");
                Console.WriteLine("|     L - Display the largest number   |");
                Console.WriteLine("|     F - Find a number                |");
                Console.WriteLine("|     W - Swap                         |");
                Console.WriteLine("|     R - Sorting                      |");
                Console.WriteLine("|     C - Clear list                   |");
                Console.WriteLine("|     Q - Quit                         |");
                Console.WriteLine("========================================\n");


                Console.Write("Enter Your Choise : ");
                choice = (Console.ReadLine().ToUpper());

                if (choice.Length == 1)
                {

                    switch (choice)
                    {

                        #region Print numbers
                        //   طباعة الارقام   // <<<<<<<<<
                        case "P":

                            if (numbers.Count == 0)
                            {
                               Console.WriteLine("\n\n\n>>> []-The List Is Empty <<<\n\n");
                            }
                            else
                            {
                                Console.Write("\n\n>>> [");
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    Console.Write($" {numbers[i]} ");
                                }
                                Console.Write("] <<<\n\n");
                            }
                            break;
                        #endregion


                        #region Add a number
                        //    اضافة رقم    // <<<<<<<<<<
                        case "A":
                            char askAddNumber;
                            bool repeatNumber = true; //منع تكرار الارقام
                            do
                            {
                                Console.Write("Enter Numper : ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                 for (int i = 0; i < numbers.Count; i++)  //اضافة منع التكرار
                                 {
                                      if (numbers[i] == num )
                                         {
                                           Console.WriteLine("\n>>> The number exists. Enter another number. <<<\n");
                                           repeatNumber = false;
                                           break;
                                         }                  
                                 }
                                
                                 if (repeatNumber == false)
                                 {
                                       break;
                                 }
                                
                                numbers.Add(num);
                                Console.WriteLine($"\n\n>>> Number Is Add {numbers[^1]} <<<\n");
                                numbers.TrimExcess();
                                Console.Write("\nWould you like to enter another number  ? ( y  or  n ) : ");
                                askAddNumber = Convert.ToChar(Console.ReadLine().ToUpper());

                            } while (askAddNumber == 'Y');                           
                            break;
                        #endregion


                        #region Display mean of the numbers
                        //    متوسط القيم    // <<<<<<<<<<
                        case "M":
                            if (numbers.Count == 0)
                            {
                                Console.WriteLine("\n\n>>> Unable to calculate the mean - no data <<<\n");
                            }
                            else
                            {
                                double sum = 0;
                                double mean = 0;
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    sum += numbers[i];
                                }
                                mean = sum / numbers.Count;
                                Console.WriteLine($"\n\n>>> The mean is : {mean} <<<\n");
                            }

                            break;
                        #endregion


                        #region smallest number

                        //    اصغر قيمه    // <<<<<<<<<<
                        case "S":
                            if (numbers.Count == 0)
                            {
                                Console.WriteLine("\n>>> No Data <<<");
                            }
                            else
                            {
                                int small = numbers[0];
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] < small)
                                        small = numbers[i];
                                }
                                Console.WriteLine($"\n>>> The Small Number is : {small} <<<\n");
                            }
                            break;
                        #endregion


                        #region largest number
                        //    اكبر قيمه    // <<<<<<<<<<
                        case "L":
                            if (numbers.Count == 0)
                            {
                                Console.WriteLine("\n>>> No Data <<<");
                            }
                            else
                            {
                                int large = numbers[0];
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] > large)
                                        large = numbers[i];
                                }
                                Console.WriteLine($"\n>>> The Large Number is : {large} <<<\n");
                            }
                            break;
                        #endregion


                        #region Find a number
                        //    ايجاد الرقم    // <<<<<<<<<<
                        case "F":

                            Console.Write("\nPlease Enter a number to fined : ");
                            int finedNum = Convert.ToInt32(Console.ReadLine());
                            bool fined = false;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (finedNum == numbers[i])
                                {
                                    Console.WriteLine($"\n\n>>> Number {finedNum} found at index[{i}]. <<<\n");
                                    fined = true;
                                    break;
                                }
                            }
                            if (fined == false)
                            {
                                Console.WriteLine($"\n\n >>> Number {finedNum} not found in the list. <<<\n");
                            }

                            break;
                        #endregion


                        #region Swap
                        case "W":
                            if (numbers.Count == 0)
                            {
                                Console.WriteLine("\n\n\n>>> []-The List Is Empty <<<\n\n");
                                break;
                            }
                            else
                            {
                                Console.Write("\nNumbers before switching : ");
                                Console.Write("[");
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    Console.Write($" {numbers[i]} ");
                                }
                                Console.WriteLine("]\n");
                            }
                            int temp;
                            bool chek = false;

                            Console.Write("Enter number1 : ");
                            int numOne = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter number2 : ");
                            int numTow = Convert.ToInt32(Console.ReadLine());

                            for (int i = 0; i < numbers.Count; i++)
                            {


                                if (numbers[i] == numOne)
                                {
                                    temp = numbers[i];

                                    for (int j = 0; j < numbers.Count; j++)
                                    {

                                        if (numbers[j] == numTow)
                                        {
                                            numbers[i] = numbers[j];
                                            numbers[j] = temp;
                                            Console.WriteLine($"\n\n>>> index [{i}] = {numbers[i]}   And   index [{j}] = {numbers[j]} <<<");
                                            chek = true;
                                            break;

                                        }
                                    }
                                    break;
                                }


                            }
                            if (chek == true)
                            {
                                Console.Write("\nNumbers after switching : ");
                                Console.Write("[");
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    Console.Write($" {numbers[i]} ");
                                }
                                Console.Write("] <<<\n\n");
                            }
                            else
                            {
                                Console.WriteLine("\n>>> The numbers must be within the numbers shown to complete the operation. <<<\n");
                            }

                            break;

                        #endregion
                            


                        #region Sorting
                     case "R":
                            
                      if (numbers.Count == 0)
                         {
                             Console.WriteLine("\n\n\n>>> []-The List Is Empty <<<\n\n");
                             break;
                         }
                         else
                         {
                            Console.Write("\n\nChoose ascending or descending order (A- ASC / D- DESC) : ");
                            string str = Console.ReadLine().ToUpper();
                            if (str.Length == 1)
                            {
                                switch (str)
                                {
                                    case "A":
                                        //الطباعه قبل الترتيب
                                        Console.Write("\n\n>>> Before [");
                                        for (int i = 0; i < numbers.Count; i++)
                                        {
                                            Console.Write($" {numbers[i]} ");
                                        }
                                        Console.Write("] <<<\n\n");
                        
                        
                        
                                        //عملية الترتيب
                                        for (int p = 0; p < numbers.Count - 1; p++)
                                        {
                                            for (int i = 0; i < numbers.Count - 1; i++)
                                            {
                                                if (numbers[i] > numbers[i + 1])
                                                {
                                                    int sort = numbers[i];
                                                    numbers[i] = numbers[i + 1];
                                                    numbers[i + 1] = sort;
                                                }
                        
                                            }
                                        }
                        
                        
                        
                                        //الطباعه بعد الترتيب
                                        Console.Write("\n\n>>> After  [");
                                        for (int i = 0; i < numbers.Count; i++)
                                        {
                                            Console.Write($" {numbers[i]} ");
                                        }
                                        Console.Write("] <<<\n\n");
                        
                        
                                        break;
                        
                        
                                    case "D":
                                        //الطباعه قبل الترتيب
                                        Console.Write("\n\n>>> Before [");
                                        for (int i = 0; i < numbers.Count; i++)
                                        {
                                            Console.Write($" {numbers[i]} ");
                                        }
                                        Console.Write("] <<<\n\n");
                        
                        
                        
                                        //عملية الترتيب
                                        for (int p = 0; p < numbers.Count - 1; p++)
                                        {
                                            for (int i = 0; i < numbers.Count - 1; i++)
                                            {
                                                if (numbers[i] < numbers[i + 1])
                                                {
                                                    int sort = numbers[i];
                                                    numbers[i] = numbers[i + 1];
                                                    numbers[i + 1] = sort;
                                                }
                        
                                            }
                                        }
                        
                        
                        
                                        //الطباعه بعد الترتيب
                                        Console.Write("\n\n>>> After  [");
                                        for (int i = 0; i < numbers.Count; i++)
                                        {
                                            Console.Write($" {numbers[i]} ");
                                        }
                                        Console.Write("] <<<\n\n");
                        
                        
                                    break;
                        
                                    default:
                                        Console.WriteLine("\n>>> This option is not in the list. <<<\n");
                                        break;
                                }
                                             
                                
                            }
                            else
                            {
                                Console.WriteLine("Enter one letter");
                            }
                         }
                            break;
                        #endregion


                        #region Clear list
                        //    تنظيف القائمه    // <<<<<<<<<<
                        case "C":
                            numbers.Clear();
                            Console.WriteLine("\n\n>>> The list has been emptied <<<\n");
                            break;
                        #endregion


                        #region  Quit
                        //    الخروج من البرنامج    // <<<<<<<<<<
                        case "Q":
                            Console.WriteLine("\nGoodbye!");
                            break;
                        #endregion


                        #region Erorr Enter
                        //    الادخال الخاطئ    // <<<<<<<<<<
                        default:
                            Console.WriteLine("\n>>> This option is not in the list. <<<\n");
                            break;
                            #endregion


                    }

                }
                else { Console.WriteLine("\n\n>>> Enter one letter from the list shown, such as the letter P. <<<\n"); }


            } while (!(choice == "Q"));
        }
    }
}
