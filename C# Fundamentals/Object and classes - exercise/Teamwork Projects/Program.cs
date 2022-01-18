using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamsToRegister = int.Parse(Console.ReadLine());
            List<TeamUsers> teams = new List<TeamUsers>();
            for (int i = 0; i < teamsToRegister; i++)
            {
                string[] cmdArr = Console.ReadLine().Split("-");
                string user = cmdArr[0];
                string team = cmdArr[1];

                TeamUsers newTeam = new TeamUsers(user, team);

                bool isTeamNameExist = teams.Select(x => x.Team).Contains(team);
                bool isCreatorExist = teams.Select(x => x.User).Contains(user);

                if (!isTeamNameExist)
                {
                    if (!isCreatorExist)
                    {
                        teams.Add(newTeam);
                        Console.WriteLine($"Team {team} has been created by {user}!");
                    }
                    else
                    {
                        Console.WriteLine($"{user} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {team} was already created!");
                }
            }
            string secondUser = Console.ReadLine().ToLower();
            while (secondUser != "end of assignment")
            {
                string[] secondUserArr = secondUser.Split(new char[] { '-', '>' });
                string newUser = secondUserArr[0];
                string teamName = secondUserArr[1];

                bool isTeamExist = teams
                                    .Select(x => x.Team)
                                    .Contains(teamName);
                bool isCreatorExist = teams
                                    .Select(x => x.User)
                                    .Contains(newUser);
                bool isMemberExist = teams
                                    .Select(x => x.Member)
                                    .Any(x => x.Contains(newUser));
                
                if (!isTeamExist)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (isCreatorExist || isMemberExist)
                {
                    Console.WriteLine($"Member {newUser} cannot join team {teamName}!");
                }
                else 
                {
                    int index = teams.FindIndex(x => x.Team == teamName);
                    teams[index].Member.Add(newUser);
                }
            }

            TeamUsers[] teamsToDisband = teams.OrderBy(x => x.Team)
                .Where(x => x.Member.Count == 0)
                .ToArray();

            TeamUsers[] fullTeam = teams.OrderByDescending(x => x.Member.Count)
                .ThenBy(x => x.Team)
                .Where(x => x.Member.Count > 0)
                .ToArray();

            StringBuilder sb = new StringBuilder();
            foreach (TeamUsers team in fullTeam)
            {
                sb.AppendLine($"{team.Team}");
                sb.AppendLine($"{team.User}");

                foreach (var member in team.Member.OrderBy(x => x))
                {
                    sb.AppendLine($"-- {member}");
                }
            }

            sb.AppendLine("Teams to disband:");
            foreach (TeamUsers item in teamsToDisband)
            {
                sb.AppendLine(item.Team);
            }

            Console.WriteLine(sb.ToString());
        }
    }
    class TeamUsers
    {
        public TeamUsers(string user, string team)
        {
            User = user;
            Team = team;
            Member = new List<string>();
        }

        public string User { get; set; }
        public string Team { get; set; }
        public List<string> Member { get; set; }
    }
}
