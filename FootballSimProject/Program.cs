namespace FootballSimProject
{
    //-Initialt, vad ska finnas?
    // 	+Möjlighet att skapa serie
    // 	+Möjlighet att lägga till lag
    // 	+Möjlighet att lägga till spelare med stats
    // 	+Statsen på spelarna i laget ska lägga grund för
    // 	 hur sannolikt det är att ett lag ska vinna/förlora
    internal class Program
    {
        /* Metod för att skapa ett nytt lag och returnera det
        static Team CreateNewTeam(string teamname, int attack, int defense, int coaching)
        {
            Team newTeam = new Team(teamname, attack, defense, coaching);
            return newTeam;
        }*/
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            //Lägg till lag med konstruktorn i class_team
            Team fcbarcelona = new Team("FC Barcelona", 90, 84, 85);
            Team realmadrid = new Team("Real Madrid", 91, 86, 88);
            Team girona = new Team("Girona FC", 84, 83, 91);

            //Lägg till lag i listan
            teams.Add(fcbarcelona);
            teams.Add(realmadrid);
            teams.Add(girona);

            foreach (var team in teams)
            {
                Console.WriteLine($"Team: {team.TeamName} ({team.Attack}," +
                    $"{team.Defense},{team.Coaching})");
            }
        }
    }
}