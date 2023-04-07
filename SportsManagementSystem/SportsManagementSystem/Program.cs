using Microsoft.Data.SqlClient;

namespace SportsManagementSystem
{
    internal class Program
    {
        public static void EditScoreboards(SqlConnection connection) {
            string query = "UPDATE Scoreboards SET team1_score = @team1_score, team2_score = @team2_score WHERE scoreboard_id = @scoreboard_id";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                Console.WriteLine("Enter Scoreboard Id: ");
                int scoreboard_id = int.Parse(Console.ReadLine());
                command.Parameters.AddWithValue("@scoreboard_id", scoreboard_id);

                Console.WriteLine("Enter Scoreboard Id: ");
                int team1_score = int.Parse(Console.ReadLine());
                command.Parameters.AddWithValue("@team1_score", team1_score);

                Console.WriteLine("Enter Scoreboard Id: ");
                int team2_score = int.Parse(Console.ReadLine());
                command.Parameters.AddWithValue("@team2_score", team2_score);
                command.ExecuteNonQuery();

            }
        }
        public static void AddScoreboards(SqlConnection connection)
        {
            string query = "INSERT INTO Scoreboards (scoreboard_name, tournament_id, sport_id, match_date, match_time, Team1_Id, Team2_Id, Team1_Score, Team2_Score) " +
                   "VALUES (@scoreboard_name, @tournament_id, @sport_id, @match_date, @match_time, @Team1_Id, @Team2_Id, @Team1_Score, @Team2_Score)";


            SqlCommand command = new SqlCommand(query, connection);
            Console.WriteLine("Enter Scoreboard name: ");

            string scoreboard_name = Console.ReadLine();
            command.Parameters.AddWithValue("@scoreboard_name", scoreboard_name);

                Console.WriteLine("Enter Tournament Id: ");
                int tournament_id = int.Parse(Console.ReadLine());
                command.Parameters.AddWithValue("@tournament_id", tournament_id);
                Console.WriteLine("Enter Sport Id: ");
                int sport_id = int.Parse(Console.ReadLine());
                command.Parameters.AddWithValue("@sport_id", sport_id);
                Console.WriteLine("Enter Match Date (yyyy-MM-dd): ");
                DateTime match_date = DateTime.Parse(Console.ReadLine());
                command.Parameters.AddWithValue("@match_date", match_date);

                Console.WriteLine("Enter Match Time (hh:mm:ss): ");
                TimeSpan match_time = TimeSpan.Parse(Console.ReadLine());
                command.Parameters.AddWithValue("@match_time", match_time);

                Console.WriteLine("Enter Team 1 Id: ");
                int team1Id = int.Parse(Console.ReadLine());
                command.Parameters.AddWithValue("@Team1_Id", team1Id);
                Console.WriteLine("Enter Team 2 Id: ");
                int team2Id = int.Parse(Console.ReadLine());
                command.Parameters.AddWithValue("@Team2_Id", team2Id);
                Console.WriteLine("Enter Team 1 Score: ");
                int team1Score = int.Parse(Console.ReadLine());
                command.Parameters.AddWithValue("@Team1_Score", team1Score);
                Console.WriteLine("Enter Team 2 Score: ");
                int team2Score = int.Parse(Console.ReadLine());
                command.Parameters.AddWithValue("@Team2_Score", team2Score);

                int result = command.ExecuteNonQuery();

                // Check if the scoreboard was added successfully
                if (result > 0)
                {
                    Console.WriteLine("Scoreboard added successfully!");
                }
                else
                {
                    Console.WriteLine("Unable to add scoreboard. Please try again.");
                }
            
        }
            public static void AddTournamentWithSports(SqlConnection connection) {
            Console.Write("Enter tournament name: ");
            string tournamentName = Console.ReadLine();
            Console.Write("Enter tournament date (yyyy-mm-dd): ");
            string tournamentDate = Console.ReadLine();
            Console.Write("Enter tournament location: ");
            string tournamentLocation = Console.ReadLine();

            string query = "INSERT INTO Tournaments (tournament_name, tournament_date, tournament_location) VALUES (@TournamentName, @TournamentDate, @TournamentLocation); SELECT SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TournamentName", tournamentName);
            command.Parameters.AddWithValue("@TournamentDate", tournamentDate);
            command.Parameters.AddWithValue("@TournamentLocation", tournamentLocation);
            int tournamentId = Convert.ToInt32(command.ExecuteScalar());

            Console.WriteLine("Tournament added successfully!");

            Console.Write("Enter number of sports for the tournament: ");
            int numSports = int.Parse(Console.ReadLine());

            for (int i = 0; i < numSports; i++)
            {
                Console.Write($"Enter sport{i + 1} ID: ");
                int sportId = int.Parse(Console.ReadLine());

                string tournamentSportsQuery = "INSERT INTO TournamentSports (tournament_id, sport_id) VALUES (@TournamentId, @SportId)";
                SqlCommand tournamentSportsCommand = new SqlCommand(tournamentSportsQuery, connection);
                tournamentSportsCommand.Parameters.AddWithValue("@TournamentId", tournamentId);
                tournamentSportsCommand.Parameters.AddWithValue("@SportId", sportId);
                tournamentSportsCommand.ExecuteNonQuery();
            }

            Console.WriteLine("Sports added to tournament successfully!");
        }

        public static void AddSports(SqlConnection connection) {
            Console.Write("Enter sport name: ");
            string sportName = Console.ReadLine();
            Console.Write("Enter sport description: ");
            string sportDescription = Console.ReadLine();

            string query = "INSERT INTO Sports (sport_name, sport_description) VALUES (@SportName, @SportDescription)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SportName", sportName);
            command.Parameters.AddWithValue("@SportDescription", sportDescription);
            command.ExecuteNonQuery();

            Console.WriteLine("Sport added successfully!");
        }

        public static void RemoveTournament(SqlConnection connection)
        {
            string query = "DELETE FROM Tournaments WHERE tournament_id = @tournament_id";
            Console.Write("Enter Tournament ID: ");
            int tournament_id = int.Parse(Console.ReadLine());
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@tournament_id", tournament_id);
                command.ExecuteNonQuery();
            }
        }
            public static void RemoveSports(SqlConnection connection)
        {
            Console.Write("Enter sport ID to remove: ");
            int sport_id = Convert.ToInt32(Console.ReadLine());


            string query = "DELETE from Sports WHERE sport_id = @sport_id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@sport_id", sport_id);
            command.ExecuteNonQuery();
            Console.WriteLine("Sport deleted successfully!");
        }

        static void Main(string[] args)
        {
            string connectionString = "Data Source=DESKTOP-IRQ8TH4; Integrated Security=True; Encrypt=False; Initial Catalog=TestDB";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                Console.WriteLine("Connected");
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString()); 
            }

            int choice = 0;

            do
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Add Sport");
                Console.WriteLine("2. Remove Sport");
                Console.WriteLine("3. Add tournament with Sports");
                Console.WriteLine("4. Delete tournament");
                Console.WriteLine("5. Add scoreboards");
                Console.WriteLine("6. Edit scoreboards");
                Console.WriteLine("7. Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddSports(connection);
                        break;

                    case 2:
                        RemoveSports(connection);
                        break;

                    case 3:
                        AddTournamentWithSports(connection);
                        break;

                    case 4:
                        RemoveTournament(connection);
                        break;

                    case 5:
                        AddScoreboards(connection);
                        break;

                    case 6:
                        EditScoreboards(connection);
                        break;

                    case 7:
                        connection.Close();
                        Console.WriteLine("Exiting Program...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (choice != 6);
        }
    }
    
}