ystem.Console.WriteLine("========================================================================================");
hi:
salom:
System.Console.WriteLine("\nMenyu -----------------------------------------------\n\nAsosiy        |        Chizish      |      Calculator\n-----------------------------------------------------");
string menyu = Console.ReadLine();

if(menyu == "1"){
    System.Console.WriteLine("Sizga nimani topish kerak?\n-------------------------------------\n");
    System.Console.WriteLine("Kubning hajmini   |   Turtburchakning P   |   Uchburchakning S   |   ........");
    string yunalish = Console.ReadLine();

    if(yunalish == "1"){
        System.Console.WriteLine("Kubning tomonlarini kiriting\n");
        System.Console.Write("A: ");
        int a = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("B: ");
        int b = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("C: ");
        int c = Convert.ToInt32(Console.ReadLine());
        System.Console.Write($"Kubingizning hajmi: {a * b * c}");
    }
    else if(yunalish == "2"){
        System.Console.WriteLine("Turtburchak tomonlarini kiriting\n");
        System.Console.Write("A: ");
        int a1 = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("B: ");
        int b1 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"Turtburchakingizning Perimetri: {(a1 + b1)* 2}");
    }
    else if(yunalish == "3"){
        System.Console.WriteLine("Uchburchak tomonlarini kiriting\n");
        System.Console.Write("A: ");
        int a2 = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("B: ");
        int b2 = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("C: ");
        int c2 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"Uchburchaknign Yuzi : {a2 * b2 * c2}");
    }
}
else if(menyu == "2"){
    System.Console.WriteLine("Sizga nimaning chizmasi kerak?\n--------------------------------------\n");
    System.Console.WriteLine("Turtburchak   |   Uchburchak   |   Kvadrat   |   ......");
    string yunalish2 = Console.ReadLine();
    if(yunalish2 == "1"){
        System.Console.WriteLine("***********\n*         *\n*         *\n*         *\n*         *\n*         *\n***********\n");
    }
    else if(yunalish2 == "2"){
        Console.WriteLine("       *\n     *  *\n    *    *\n   *      *\n  *        *\n *          *\n**************");
    }
    else if(yunalish2 == "3"){
        Console.WriteLine("**********\n*        *\n*        *\n*        *\n**********\n");
    }
}
else if(menyu == "3"){
    ok:
    System.Console.WriteLine("----------- Calculator -----------\n");
    System.Console.Write("Sonni kiriting: ");
    int a3 = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Amalni kiriting: ");
    string amal = Console.ReadLine();
    System.Console.Write("Sonni kiriting: ");
    int b3 = Convert.ToInt32(Console.ReadLine());
    if(amal == "+"){
        System.Console.WriteLine("----------- Javob -----------");
        System.Console.WriteLine($"{a3} + {b3} = {a3 + b3}");
    }
    else if(amal == "-"){
        System.Console.WriteLine($"{a3} - {b3} = {a3 - b3}");
    }
    else if(amal == "*"){
        System.Console.WriteLine($"{a3} * {b3} = {a3 * b3}");
    }
    else if(amal == "/"){
        System.Console.WriteLine($"{a3} / {b3} = {a3 / b3}");
    }

    System.Console.WriteLine("\n---------------------------------\nCalculatordan yana foydalanasizmi?\n---------------------------------");
    string s1 = Console.ReadLine();
    if(s1 == "ha" || s1 == "yes"){
        goto ok;
}
    }

else if(menyu == "yordam" || menyu == "help"){
    System.Console.WriteLine("Siz menyudagi suzlarni tanlash uchun sonlardan foydalanasiz.\nBu dastur sizga qayta qayta ishlab bera oladi.\nAgar dasturda belgilanmagan shart bersangiz siz dasturdan chiqib ketasiz.\n");
    string d = Console.ReadLine();
    goto salom;
}
else{
    
}

System.Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n---------------------------\nDasturni davom ettirasizmi?\n---------------------------\n");
string s = Console.ReadLine();

if(s == "ha" || s == "yes" || s == "1"){
    goto hi;
}
else
    System.Console.WriteLine(" ");