Console.WriteLine("Enter your age");
        int Age = Convert.ToInt32(Console.ReadLine());

        if (Age < 18)
        {
            Console.WriteLine("You are a minor");
        }
        else if (Age == 18)
        {
            Console.WriteLine("You just became an adult");
        }
        else
        {
            Console.WriteLine("You are an adult");
        }



