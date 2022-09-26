using System;

public class MyProgram
{
    private static Random random = new Random();

    public static void Main(string[] args)
    {
        int enemyHitpoints;
        int playerHitpoints;
        int playerStrength;
        int playerSpeed;
        int enemySpeed;
        int enemyStrength;
        int enemyChoice;

        enemyChoice = random.Next(2);
        enemyHitpoints = 100;
        playerHitpoints = 100;
        playerStrength = 15;
        playerSpeed = 40;
        enemySpeed = 50;
        enemyStrength = 15;
        int es2;
        string attDef;

        es2 = enemyStrength;
        int ps2;

        ps2 = playerStrength;
        while (playerHitpoints > 0 && enemyHitpoints > 0)
        {
            while (enemyHitpoints > 0)
            {
                if (playerSpeed > enemySpeed)
                {
                    Console.WriteLine("Do you want to attack or guard?");
                    attDef = Console.ReadLine();
                    int enemyTurn;

                    enemyTurn = 0;
                    if (playerHitpoints > 0 && enemyHitpoints > 0)
                    {
                    }
                    else
                    {
                        if (playerHitpoints > 0)
                        {
                            if (enemyHitpoints > 0)
                            {
                            }
                            else
                            {
                                Console.WriteLine("The enemy has been slain.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The player was slain.");
                        }
                    }
                    if (attDef == "attack" && playerHitpoints > 0)
                    {
                        if (enemyChoice == 0)
                        {
                            Console.WriteLine("The enemy blocked your attack.");
                        }
                        else
                        {
                            Console.WriteLine("You swing your sword at your opponent.");
                            enemyHitpoints = enemyHitpoints - playerStrength;
                        }
                        Console.WriteLine("The enemy is left with: " + enemyHitpoints + "hp.");
                    }
                    else
                    {
                        if (attDef == "guard" && playerHitpoints > 0)
                        {
                            Console.WriteLine("You raise your sword defensively.");
                        }
                        else
                        {
                            Console.WriteLine("The player was slain.");
                        }
                    }
                    if (enemyTurn == 0)
                    {
                        enemyChoice = 1;
                    }
                    if (enemyChoice == 1 && enemyHitpoints > 0)
                    {
                        if (attDef == "guard")
                        {
                            Console.WriteLine("You blocked the enemy's attack.");
                        }
                        else
                        {
                            Console.WriteLine("The opponent swings their sword at you.");
                            playerHitpoints = playerHitpoints - enemyStrength;
                        }
                        Console.WriteLine("You are left with: " + playerHitpoints + "hp.");
                    }
                    else
                    {
                        if (enemyHitpoints > 0)
                        {
                            Console.WriteLine("The enemy defends.");
                        }
                        else
                        {
                            Console.WriteLine("The opponent was slain.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Do you want to attack or guard?");
                    attDef = Console.ReadLine();
                    Console.WriteLine("It is your opponent's turn.");
                    int enemyTurn;

                    enemyTurn = 1;
                    if (enemyChoice == 1 && enemyHitpoints > 0)
                    {
                        Console.WriteLine("The opponent swings their sword at you.");
                        if (attDef == "guard")
                        {
                            Console.WriteLine("You block the opponent's attack.");
                        }
                        else
                        {
                            playerHitpoints = playerHitpoints - enemyStrength;
                        }
                        Console.WriteLine("You are left with: " + playerHitpoints + "hp.");
                    }
                    else
                    {
                        if (enemyHitpoints > 0)
                        {
                            Console.WriteLine("The enemy defends.");
                        }
                        else
                        {
                            Console.WriteLine("The opponent was slain.");
                        }
                    }
                    enemyTurn = 0;
                    if (playerHitpoints > 0 && enemyHitpoints > 0)
                    {
                    }
                    else
                    {
                        if (playerHitpoints > 0)
                        {
                            if (enemyHitpoints > 0)
                            {
                            }
                            else
                            {
                                Console.WriteLine("The enemy has been slain.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The player was slain.");
                        }
                    }
                    if (attDef == "attack" && playerHitpoints > 0)
                    {
                        if (enemyChoice == 0)
                        {
                            Console.WriteLine("The enemy blocked your attack.");
                        }
                        else
                        {
                            Console.WriteLine("You swing your sword at your opponent.");
                            enemyHitpoints = enemyHitpoints - playerStrength;
                        }
                        Console.WriteLine("The enemy is left with: " + enemyHitpoints + "hp.");
                    }
                    else
                    {
                        if (attDef == "guard" && playerHitpoints > 0)
                        {
                        }
                        else
                        {
                            if (playerHitpoints > 0)
                            {
                                Console.WriteLine("Invalid input.");

                                // Needs a while loop here or it'll just skip the player's turn
                            }
                            else
                            {
                                Console.WriteLine("The player was slain.");
                            }
                        }
                    }
                }
                enemyChoice = random.Next(2);
            }
            Console.WriteLine("The battle ends.");
        }
    }

    public static void End(int exit)
    {
    }

    public static void h()
    {
    }

    // .NET can only read single characters or entire lines from the console.
    // The following function safely reads a double value.
    private static double readValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
