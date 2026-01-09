



int Room = 1;

int Wins = 0;

int PlayerHealth = 100;
int PlayerDamage = Random.Shared.Next(1, 15);
int PlayerCoins = 0;

int MonsterDamage;
int MonsterHealth;


while (Room != 0)
{
    
    Console.Clear();



    
    List<string> MType = ["Potential slimes", "My dog", "Your bed bugs", "Muscular cat", "Youself?", "Three fast gnomes", 
    "Your long lost pet dragon", "The king of a very small forest", "A dedicated cartographer", 
    "100 ant sized men", "The creator of slugs", "The fleecer of goods", "A blacksmith named Smith Black"];
    // 
    List<int> ListHP = [20, 60, 15, 100, 3, 40, 70, 40, 50, 20, 2300, 30, 80];
    // 
    List<int> ListDamage = [Random.Shared.Next(1, 5), Random.Shared.Next(1, 20), Random.Shared.Next(1, 3), 
    Random.Shared.Next(1, 35), Random.Shared.Next(1, 5), Random.Shared.Next(1, 20), Random.Shared.Next(1, 15), 
    Random.Shared.Next(1, 10), Random.Shared.Next(1, 15), Random.Shared.Next(1, 10),Random.Shared.Next(1, 100),
    Random.Shared.Next(1, 20), Random.Shared.Next(1, 40)];

    int n = Random.Shared.Next(MType.Count);

    if (Room == 1)
    {


        MonsterDamage = ListDamage[n];
        MonsterHealth = ListHP[n];

        String Action = "";
        Action = Action.ToLower();
        
        Console.WriteLine($"Your are fighting {MType[n]}");
        Console.WriteLine($"-----------------");
        Console.WriteLine($"you have {PlayerHealth} health");
        Console.WriteLine($"They have {MonsterHealth} health");
        Console.WriteLine($"-----------------");

        while (Wins != Wins+1)
        {
            
            Action = Console.ReadLine();
            Action = Action.ToLower();

            if (Action == "a")
            {
                MonsterHealth -= PlayerDamage;
                Console.WriteLine($"-----------------");
                Console.WriteLine($"You did {PlayerDamage} damage");
                PlayerHealth -= MonsterDamage;
                Console.WriteLine($"They did {MonsterDamage} damage");
                Console.WriteLine($"-----------------");
                Console.WriteLine($"you have {PlayerHealth} health");
                Console.WriteLine($"They have {MonsterHealth} health");
                Console.WriteLine($"-----------------");

            }
            else
            {
                Console.WriteLine("Press A to Fight");
            }


            if (PlayerHealth <= 0)
            {
                Room = 0;
                break;
                // BreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreakBreak
            }


            if (MonsterHealth <= 0)
            {
                PlayerCoins += 10;
                Wins += 1;

                Console.WriteLine($"You killed it!");
                Console.WriteLine($"-----------------");
                Console.WriteLine($"Where do you want to go?");
                Action = Console.ReadLine();
                Action = Action.ToLower();
                
                if (Action == "e")
                {
                    
                    if (Action == "e")
                    {
                        Console.Clear();
                        Console.WriteLine("You are in the shop!");
                        Console.WriteLine($"You have {PlayerCoins} coins");
                        Console.WriteLine("What do you want to buy?");
                        Console.WriteLine("A: + 10 health : price 10 coins");
                        Console.WriteLine("B: + 5 damage : price 10 coins");

                        Action = Console.ReadLine();
                        Action = Action.ToLower();

                        if (Action == "a")
                        {
                            PlayerHealth += 10;
                        }
                        else if (Action == "b")
                        {
                            PlayerDamage += 5;
                        }



                    }
                }
                else
                {
                    Console.WriteLine("Press A to Fight");
                    Console.WriteLine("Press E to Shop");
                }
            }




        
        }
    }
}

Console.Clear();
Console.WriteLine($"You Died!");
Console.ReadLine();



