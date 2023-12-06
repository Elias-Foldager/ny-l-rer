        bool win = false;

        while (!win)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Jens har lavet chokoladekage vil du spise den?");
            Console.WriteLine("Der er 20% chance for at du får ondt i maven og 5% chance at du dør af cyanid forgiftning");
            Console.WriteLine("Vil du spise kagen? (ja/nej)");

            string input = Console.ReadLine();

            if (input1.ToLower() == "ja")
            {
                Console.WriteLine("Du spiser kagen");
                Random random = new Random();
                int chance = random.Next(1, 101);

                if (chance <= 20)
                {
                    int skidChance = random.Next(1, 101);
                    int skid = 5; 
                    Console.WriteLine("Du får ondt i maven");
                    win = true;
                    if (random.Next(1, 101) <= skidChance)
                    {
                        Console.WriteLine("Du er nødt til at gå på toilettet!");
                        Console.WriteLine("Spil videre...");
                        win = true;
                    }
                }
                else if (chance <= 5)
                {
                    Console.WriteLine("Du dør af cyanid forgiftning");
                    Console.WriteLine("Game Over - Start over!");
                }
                else
                {
                    Console.WriteLine("Du har det fint!");
                    Console.WriteLine("Spil videre...");
                    win = true; // Set win to true to exit the loop
                }
            }
            else if (input.ToLower() == "nej")
            {
                Console.WriteLine("Du spiser ikke kagen");
                Console.WriteLine("Spil videre...");
                win = true; // Set win to true to exit the loop
            }
            else
            {
          Console.WriteLine("Ugyldigt valg. Prøv igen.");
            }
        }
 Console.WriteLine("du skal nu ind i klassen og have matematik");
 Thread.Sleep(600);
Console.WriteLine("du går ind i klassen og sætter dig ned");
Thread.Sleep(600);
Console.WriteLine("Du opdager efter 10 minutter at du skal skide meget");
Console.WriteLine("Problemt er at i skal have test om 20 min og det læren siger er vigtigt til denne eksamen");
Console.WriteLine("går du på toilet ja/nej");

string input = Console.ReadLine();
     if (input.ToLower() == "ja")
            {
                Console.WriteLine("Du går på toilet");
                Random random = new Random();
                int chance = random.Next(1, 101);

                if (chance <= 20)
                {
                    int skidChance = random.Next(1, 101);
                    int skid = 5; 
                    Console.WriteLine("Du har hård mave og det tager dig 30 min");
                    Console.WriteLine("Du dumper eksamen");
                    if (random.Next(1, 101) <= skidChance)
                    {
                        Console.WriteLine("du er tilbage efter 10 min");
                        Console.WriteLine("Der står meget på tavlen som du ikke forstår");
                        win = true;
                    }
                }
                else if (chance <= 5)
                {
                    Console.WriteLine("du dør mens du er på toilettet");
                    Console.WriteLine("Game Over - Start over!");
                }
                else
                {
                    Console.WriteLine("Du er hurtigt tilbage");
                     Console.WriteLine("Du hører at læren siger at en blåhvals testikler vejer 400 kg, det er vigtigt tænker du");
                    Console.WriteLine("Du kan godt nå at klare testen");
                    win = true; // Set win to true to exit the loop
                }
            }
            else if (input.ToLower() == "nej")
            {
                Console.WriteLine("Du går ikke på toilet");
                Console.WriteLine("du skider i bukserne og klarer ikke eksamen");
                
            }
            else
            {
          Console.WriteLine("Det kan du ikke");
            }
