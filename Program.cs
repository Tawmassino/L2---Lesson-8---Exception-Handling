namespace L2___Lesson_8___Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ================= task 1 =================");
            string task1 = "stringas";
            try
            {
                double task1Double = Convert.ToDouble(task1);
            }
            catch (FormatException ex) { Console.WriteLine(ex.Message); }
            catch (InvalidCastException ex) { Console.WriteLine(ex.Message); }
            catch (OverflowException ex) { Console.WriteLine(ex.Message); }
            catch (Exception ex) { Console.WriteLine($"Unable to convert to double.The type was: {task1.GetType()}, and value {task1}"); }


            #region task2

            Console.WriteLine(" ================= task 2 =================");


            try
            {
                int[] arr = { 1, 2, 3, 4, 5 };

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);

                }
                Console.WriteLine(arr[7]);
            }
            catch (IndexOutOfRangeException ex) { Console.WriteLine($"error: {ex.Message}"); }

            #endregion

            #region task3
            Console.WriteLine(" ================= task 3 =================");
            try
            {
                int[] arr2 = { 19, 0, 75, 52 };
                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.WriteLine(arr2[i] / arr2[i + 1]);
                }
            }
            catch (DivideByZeroException ex) { Console.WriteLine($"error: {ex.Message}"); }
            catch (OverflowException ex) { Console.WriteLine(ex.Message); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            #endregion

            // methods
            // ====== end of main====
        }

    }
}