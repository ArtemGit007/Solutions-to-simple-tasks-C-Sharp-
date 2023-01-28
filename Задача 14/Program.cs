int[] a = new int[10];
            int result=1;
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < a.GetLength(0); i++) 
            {
                a[i] = rnd.Next(1, 10);
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                result *= a[i];
            }
            Console.WriteLine("Произведение = {0}", result);
            Console.ReadKey();
