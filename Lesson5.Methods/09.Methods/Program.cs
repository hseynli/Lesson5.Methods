void MethodWihInnderMethod()
{
    Console.WriteLine("Outer method");

    void InnerMethod()
    {
        Console.WriteLine("Inner Metod");

        void MethodInInnerMethod()
        {
            Console.WriteLine("MethodInInnerMethod");
        }

        MethodInInnerMethod();
    }

    InnerMethod();

    //Daxili metodun içində olan digər metoda müraciət etmək olmu!
    //Çünki görüntü sahəsindən kənardadır!
    //MethodInInnerMethod();
}

MethodWihInnderMethod();

Console.WriteLine("Done!\n");