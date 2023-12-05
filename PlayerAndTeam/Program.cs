using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAndTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ch;
            //while (ch == "yes")
            do
            {
                try
                {
                    Console.Write("\nEnter 1.To Add Player 2.To Remove Player By Id 3.Get Player By Id 4.Get Player By Name 5.Get All Players: ");
                    int choice = int.Parse(Console.ReadLine());
                    OneDayTeam oneDayTeam = new OneDayTeam();
                    Player player = new Player();
                    switch (choice)
                    {
                        case 1:
                            {
                                oneDayTeam.Add(player);
                                break;
                            }
                        case 2:
                            {
                                Console.Write("Enter Player Id to Remove: ");
                                int id = int.Parse(Console.ReadLine());
                                oneDayTeam.Remove(id);
                                break;
                            }
                        case 3:
                            {
                                Console.Write("Enter Player Id: ");
                                int id = int.Parse(Console.ReadLine());
                                oneDayTeam.GetPlayerById(id);
                                break;
                            }
                        case 4:
                            {
                                Console.Write("Enter Player Name: ");
                                string name = Console.ReadLine();
                                oneDayTeam.GetPlayerByName(name);
                                break;
                            }
                        case 5:
                            {
                                oneDayTeam.GetAllPlayers();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid Choice!!");
                                break;
                            }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error!! " + e.Message);
                }
                finally
                {
                    Console.Write("Do you want to continue (yes/no) ?");
                    ch = Console.ReadLine().ToLower();
                }
            } while (ch == "yes");
        }
    }
}
