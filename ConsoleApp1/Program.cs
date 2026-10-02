Console.WriteLine("Hejsan senpai, vad heter du?");

string name = Console.ReadLine().ToLower();

if (name == "huseyn" || name == "husse")
{
    Thread.Sleep(2000);
    Console.WriteLine("Välkommen");
    Thread.Sleep(1000);

    // Drakens guld
    Console.WriteLine("Du går på en stig i skogen och stöter på en drake som sover på sitt guld. Ska du sno drakens guld?");
    Console.WriteLine("A) Ja   B) Nej");

    string svar1 = Console.ReadLine().ToLower();

    if (svar1 == "b" || svar1 == "B")
    {
        Console.WriteLine("Du är inte greedy, bra. Annars skulle du brännas upp, kanske.");
        Thread.Sleep(2000);

        // Chudsen gangar upp på agartha
        Console.WriteLine("Du fortsätter och stöter på ett fyrpack monster i en isgrotta med en kille som heter Jakub.");
        Console.WriteLine("Han välkomnar dig till ett ställe som heter Agartha.");
        Console.WriteLine("Ska du chilla med Jakub eller ta ditt monster och tagga hem?");
        Console.WriteLine("A) Chilla   B) Tagga hem");

        string svar2 = Console.ReadLine().ToLower();

        if (svar2 == "a" || svar2 == "A")
        {
            Console.WriteLine("Bra val. Du sitter och chillar med Jakub.");
            Thread.Sleep(2000);

            Console.WriteLine("Plötsligt anfaller en massa chuds Agartha!");
            Console.WriteLine("Ska du fly eller skydda Agartha?");
            Console.WriteLine("A) Fly   B) Skydda");

            string svar3 = Console.ReadLine().ToLower();

            if (svar3 == "a" || svar3 == "A")
            {
                Console.WriteLine("Du flyr från Agartha och lyckas överleva.");
                Thread.Sleep(2000);
                Console.WriteLine("Du kanske inte är en hjälte, men du lever. Slut!");
            }
            else if (svar3 == "b" || svar3 == "B")
            {
                Console.WriteLine("Du bestämmer dig för att skydda Agartha tillsammans med Jakub.");
                Thread.Sleep(2000);
                Console.WriteLine("Ni lyckas försvara Agartha och blir legender!");
                Console.WriteLine("Jakub bjuder på pizza. Du vann!");
            }
            else
            {
                Console.WriteLine("Ogiltigt val. Chuds anfaller medan du tvekar!");
            }
        }
        else if (svar2 == "b" || svar2 == "B")
        {
            Console.WriteLine("Du tar ditt monster och taggar hem.");
            Thread.Sleep(2000);
            Console.WriteLine("Du lever ett lugnt liv. Slut!");
        }
        else
        {
            Console.WriteLine("Ogiltigt val. Jakub tittar förvirrat på dig.");
        }
    }
    else if (svar1 == "a" || svar1 == "A")
    {
        Console.WriteLine("Du försöker sno drakens guld.");
        Thread.Sleep(2000);
        Console.WriteLine("Draken vaknar och du dör... Womp Womp.");
    }
    else
    {
        Console.WriteLine("Ogiltigt val. Draken fortsätter sova.");
    }
}
else
{
    Console.WriteLine("Du är inte välkommen här, hejdå!");
}

Console.ReadLine();














