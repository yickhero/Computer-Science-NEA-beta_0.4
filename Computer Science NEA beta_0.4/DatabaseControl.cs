using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data.Entity.Core.Metadata.Edm;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms.VisualStyles;

namespace NEA_Computer_Science_BETA_0._3
{
    internal class DatabaseControl
    {
        private static string connectionString = @"Data Source=..\..\Files\Login.db;Version=3;";
        public static void InitializeDatabase()
        {
            if (!File.Exists(@"..\..\Files\Login.db"))
            {
                SQLiteConnection.CreateFile(@"..\..\Files\Login.db");

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string createLoginTableQuery = @"
                        CREATE TABLE IF NOT EXISTS logins (
                            userid INTEGER PRIMARY KEY AUTOINCREMENT, 
                            username TEXT NOT NULL, 
                            email TEXT NOT NULL, 
                            password TEXT NOT NULL
                        );";
                    string createFolderTableQuery = @"
                        CREATE TABLE IF NOT EXISTS folders (
                            userid INTEGER, 
                            cardid INTEGER,
                            tags_1 STRING,
                            tags_2 STRING,
                            tags_3 STRING,
                            tags_4 STRING,
                            tags_5 STRING,
                            tags_6 STRING,
                            tags_7 STRING,
                            tags_8 STRING,
                            tags_9 STRING,
                            tags_10 STRING,
                            folderid INTEGER PRIMARY KEY AUTOINCREMENT, 
                            foldername STRING NOT NULL,
                            foldertype STRING NOT NULL,
                            FOREIGN KEY (userid) REFERENCES logins(userid)
                            FOREIGN KEY (cardid) REFERENCES cards(cardid)
                        );";
                    string createCardTableQuery = @"
                        CREATE TABLE IF NOT EXISTS cards (
                            userid INTEGER, 
                            folderid INTEGER,
                            cardid INTEGER PRIMARY KEY AUTOINCREMENT,
                            imagelocationfront TEXT,
                            imagelocationback TEXT,
                            question TEXT NOT NULL,
                            answer TEXT NOT NULL,
                            score DOUBLE,
                            FOREIGN KEY (userid) REFERENCES logins(userid)
                            FOREIGN KEY (folderid) REFERENCES folders(folderid)
                        );";
                    string createFolderScoreTableQuery = @"
                        CREATE TABLE IF NOT EXISTS folderscore (
                            folderid INTEGER,
                            veryeasycount INTEGER NOT NULL,
                            easycount INTEGER NOT NULL,
                            okaycount INTEGER NOT NULL,
                            difficultcount INTEGER NOT NULL,
                            verydifficultcount INTEGER NOT NULL,
                            FOREIGN KEY (folderid) REFERENCES folders(folderid)
                        );";
                    string createCardScoreTableQuery = @"
                        CREATE TABLE IF NOT EXISTS cardscore (
                            cardid INTEGER,
                            veryeasycount INTEGER NOT NULL,
                            easycount INTEGER NOT NULL,
                            okaycount INTEGER NOT NULL,
                            difficultcount INTEGER NOT NULL,
                            verydifficultcount INTEGER NOT NULL,
                            FOREIGN KEY (cardid) REFERENCES cards(cardid)
                        );";
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText = createLoginTableQuery;
                        command.ExecuteNonQuery();
                        command.CommandText = createFolderTableQuery;
                        command.ExecuteNonQuery();
                        command.CommandText = createCardTableQuery;
                        command.ExecuteNonQuery();
                        command.CommandText = createFolderScoreTableQuery;
                        command.ExecuteNonQuery();
                        command.CommandText = createCardScoreTableQuery;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        public static void AddUsers(string username, string email, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO logins (username, email, password)
                        VALUES (@username, @email, @password);";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }


            }
        }

        public static void CreateFolder(string userid, string foldername, string foldertype, string tags_1, string tags_2, string tags_3, string tags_4, string tags_5, string tags_6, string tags_7, string tags_8, string tags_9, string tags_10)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO folders (userid, foldername, foldertype, tags_1, tags_2, tags_3, tags_4, tags_5, tags_6, tags_7, tags_8, tags_9, tags_10)
                        VALUES (@userid, @foldername, @foldertype, @tags_1, @tags_2, @tags_3, @tags_4, @tags_5, @tags_6, @tags_7, @tags_8, @tags_9, @tags_10);";
                    command.Parameters.AddWithValue(@"userid", userid);
                    command.Parameters.AddWithValue("@foldername", foldername);
                    command.Parameters.AddWithValue("@foldertype", foldertype);
                    command.Parameters.AddWithValue("@tags_1", tags_1);
                    command.Parameters.AddWithValue("@tags_2", tags_2);
                    command.Parameters.AddWithValue("@tags_3", tags_3);
                    command.Parameters.AddWithValue("@tags_4", tags_4);
                    command.Parameters.AddWithValue("@tags_5", tags_5);
                    command.Parameters.AddWithValue("@tags_6", tags_6);
                    command.Parameters.AddWithValue("@tags_7", tags_7);
                    command.Parameters.AddWithValue("@tags_8", tags_8);
                    command.Parameters.AddWithValue("@tags_9", tags_9);
                    command.Parameters.AddWithValue("@tags_10", tags_10);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
        public static List<List<string>> GetFolderList()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM folders";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        List<List<string>> folderNames = new List<List<string>>();
                        List<Folder> folders = new List<Folder>();
                        while (reader.Read())
                        {
                            string userid_check = Convert.ToString(reader.GetInt32(reader.GetOrdinal("userid")));
                            string foldername = reader.GetString(reader.GetOrdinal("foldername"));
                            string foldertype = reader.GetString(reader.GetOrdinal("foldertype"));
                            string folderid = Convert.ToString(reader.GetInt32(reader.GetOrdinal("folderid")));
                            List<string> tags = new List<string>();
                            string[] user = DatabaseControl.GetUserFromEmail(Form1.email_login);
                            string userid = user[0];
                            string score = Convert.ToString(DatabaseControl.CalculateFolderscore(reader.GetInt32(reader.GetOrdinal("folderid"))));
                            if (userid_check == userid)
                            {
                                //chatgpt code
                                for (int i = 1; i <= 10; i++)
                                {
                                    string column = $"tags_{i}";
                                    int columnIndex = reader.GetOrdinal(column);

                                    if (!reader.IsDBNull(columnIndex))
                                    {
                                        string tag = reader.GetString(columnIndex);
                                        tags.Add(tag);
                                    }
                                }
                                // Concatenate tags with newline character
                                string concatenatedTags = string.Join("\n", tags);
                                List<string> folderRow = new List<string> { foldername, foldertype, concatenatedTags, folderid, score };
                                folders.Add(new Folder(Convert.ToInt32(application.userid), Convert.ToInt32(folderid), foldername, foldertype, tags));
                                folderNames.Add(folderRow);
                                //chatgpt code
                            }

                        }
                        return folderNames;
                    }

                }
            }
        }
        public static int GetCardIDFromQuestion(string question)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM cards";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        int cardid = 0;
                        while (reader.Read())
                        {
                            int cardid_check = reader.GetInt32(reader.GetOrdinal("cardid"));
                            string question_check = reader.GetString(reader.GetOrdinal("question"));
                            if (question_check == question)
                            {
                                cardid = cardid_check;
                            }
                        }
                        return cardid;
                    }

                }
            }
        }
        public static List<List<string>> GetFolderListSearched(List<string> list)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM folders";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        List<List<string>> folderNames = new List<List<string>>();
                        while (reader.Read())
                        {
                            string userid_check = Convert.ToString(reader.GetInt32(reader.GetOrdinal("userid")));
                            string foldername = reader.GetString(reader.GetOrdinal("foldername"));
                            string foldertype = reader.GetString(reader.GetOrdinal("foldertype"));
                            string folderid = Convert.ToString(reader.GetInt32(reader.GetOrdinal("folderid")));
                            List<string> tags = new List<string>();
                            string[] user = DatabaseControl.GetUserFromEmail(Form1.email_login);
                            string userid = user[0];
                            string score = Convert.ToString(DatabaseControl.CalculateFolderscore(reader.GetInt32(reader.GetOrdinal("folderid"))));
                            if (userid_check == userid)
                            {
                                foreach (var foldername_check in list)
                                {
                                    if (foldername_check == foldername)
                                    {
                                        for (int i = 1; i <= 10; i++)
                                        {
                                            string column = $"tags_{i}";
                                            int columnIndex = reader.GetOrdinal(column);

                                            if (!reader.IsDBNull(columnIndex))
                                            {
                                                string tag = reader.GetString(columnIndex);
                                                tags.Add(tag);
                                            }
                                        }
                                        // Concatenate tags with newline character
                                        string concatenatedTags = string.Join("\n", tags);
                                        List<string> folderRow = new List<string> { foldername, foldertype, concatenatedTags, folderid, score };
                                        folderNames.Add(folderRow);
                                    }
                                }
                            }
                        }
                        return folderNames;
                    }

                }
            }

        }
        public static List<string> GetFolderTypes()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM folders";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        List<string> folderTypes = new List<string>();
                        while (reader.Read())
                        {
                            string foldertype = reader.GetString(reader.GetOrdinal("foldertype"));
                            folderTypes.Add(foldertype);
                        }
                        return folderTypes;
                    }
                }
            }
        }
        public static void CreateCards(int folderid, int userid, string imagelocationfront, string imagelocationback, string question, string answer)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO cards (userid, folderid, imagelocationfront, imagelocationback, question, answer)
                        VALUES (@userid, @folderid, @imagelocationfront, @imagelocationback, @question, @answer);";
                    command.Parameters.AddWithValue("@userid", userid);
                    command.Parameters.AddWithValue("@folderid", folderid);
                    command.Parameters.AddWithValue("@imagelocationfront", imagelocationfront);
                    command.Parameters.AddWithValue("@imagelocationback", imagelocationback);
                    command.Parameters.AddWithValue("@question", question);
                    command.Parameters.AddWithValue("@answer", answer);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
        public static void AddFolderScore(int folderid, int veryeasy_count, int easy_count, int okay_count, int difficult_count, int verydifficult_count)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Check if the folderid already exists
                    using (SQLiteCommand checkCommand = new SQLiteCommand("SELECT COUNT(*) FROM folderscore WHERE folderid = @folderid", connection))
                    {
                        checkCommand.Parameters.AddWithValue("@folderid", folderid);
                        long count = (long)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            // Update the existing record by adding the new counts to the existing counts
                            using (SQLiteCommand updateCommand = new SQLiteCommand(connection))
                            {
                                updateCommand.CommandText =
                                    @"UPDATE folderscore
                              SET veryeasycount = veryeasycount + @veryeasy_count,
                                  easycount = easycount + @easy_count,
                                  okaycount = okaycount + @okay_count,
                                  difficultcount = difficultcount + @difficult_count,
                                  verydifficultcount = verydifficultcount + @verydifficult_count
                              WHERE folderid = @folderid;";

                                updateCommand.Parameters.AddWithValue("@folderid", folderid);
                                updateCommand.Parameters.AddWithValue("@veryeasy_count", veryeasy_count);
                                updateCommand.Parameters.AddWithValue("@easy_count", easy_count);
                                updateCommand.Parameters.AddWithValue("@okay_count", okay_count);
                                updateCommand.Parameters.AddWithValue("@difficult_count", difficult_count);
                                updateCommand.Parameters.AddWithValue("@verydifficult_count", verydifficult_count);

                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Insert a new record
                            using (SQLiteCommand insertCommand = new SQLiteCommand(connection))
                            {
                                insertCommand.CommandText =
                                    @"INSERT INTO folderscore 
                              (folderid, veryeasycount, easycount, okaycount, difficultcount, verydifficultcount)
                              VALUES 
                              (@folderid, @veryeasy_count, @easy_count, @okay_count, @difficult_count, @verydifficult_count);";

                                insertCommand.Parameters.AddWithValue("@folderid", folderid);
                                insertCommand.Parameters.AddWithValue("@veryeasy_count", veryeasy_count);
                                insertCommand.Parameters.AddWithValue("@easy_count", easy_count);
                                insertCommand.Parameters.AddWithValue("@okay_count", okay_count);
                                insertCommand.Parameters.AddWithValue("@difficult_count", difficult_count);
                                insertCommand.Parameters.AddWithValue("@verydifficult_count", verydifficult_count);

                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception here
                Console.WriteLine($"Error inserting or updating score: {ex.Message}");
                throw;
            }
        }
        public static void AddCardScore(int cardid, int veryeasy_count, int easy_count, int okay_count, int difficult_count, int verydifficult_count)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Check if the folderid already exists
                using (SQLiteCommand checkCommand = new SQLiteCommand("SELECT COUNT(*) FROM cardscore WHERE cardid = @cardid", connection))
                {
                    checkCommand.Parameters.AddWithValue("@cardid", cardid);
                    long count = (long)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        // Update the existing record by adding the new counts to the existing counts
                        using (SQLiteCommand updateCommand = new SQLiteCommand(connection))
                        {
                            updateCommand.CommandText =
                                @"UPDATE cardscore
                              SET veryeasycount = veryeasycount + @veryeasy_count,
                                  easycount = easycount + @easy_count,
                                  okaycount = okaycount + @okay_count,
                                  difficultcount = difficultcount + @difficult_count,
                                  verydifficultcount = verydifficultcount + @verydifficult_count
                              WHERE cardid = @cardid;";

                            updateCommand.Parameters.AddWithValue("@cardid", cardid);
                            updateCommand.Parameters.AddWithValue("@veryeasy_count", veryeasy_count);
                            updateCommand.Parameters.AddWithValue("@easy_count", easy_count);
                            updateCommand.Parameters.AddWithValue("@okay_count", okay_count);
                            updateCommand.Parameters.AddWithValue("@difficult_count", difficult_count);
                            updateCommand.Parameters.AddWithValue("@verydifficult_count", verydifficult_count);

                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // Insert a new record
                        using (SQLiteCommand insertCommand = new SQLiteCommand(connection))
                        {
                            insertCommand.CommandText =
                                @"INSERT INTO cardscore 
                              (cardid, veryeasycount, easycount, okaycount, difficultcount, verydifficultcount)
                              VALUES 
                              (@cardid, @veryeasy_count, @easy_count, @okay_count, @difficult_count, @verydifficult_count);";

                            insertCommand.Parameters.AddWithValue("@cardid", cardid);
                            insertCommand.Parameters.AddWithValue("@veryeasy_count", veryeasy_count);
                            insertCommand.Parameters.AddWithValue("@easy_count", easy_count);
                            insertCommand.Parameters.AddWithValue("@okay_count", okay_count);
                            insertCommand.Parameters.AddWithValue("@difficult_count", difficult_count);
                            insertCommand.Parameters.AddWithValue("@verydifficult_count", verydifficult_count);

                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
        public static void AddCalculatedCardScore(int cardid)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    double score = DatabaseControl.CalculateCardscore(cardid);
                    command.CommandText =
                        @"UPDATE cards
                      SET score = @score
                      WHERE cardid = @cardid;";
                    command.Parameters.AddWithValue("@score", score);
                    command.Parameters.AddWithValue("@cardid", cardid);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();

                }
            }
        } 
        public static double CalculateFolderscore(int folderid)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM folderscore";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        double score = 0;
                        while (reader.Read())
                        {
                            int folderid_check = reader.GetInt32(reader.GetOrdinal("folderid"));
                            int veryeasycount = reader.GetInt32(reader.GetOrdinal("veryeasycount"));
                            int easycount = reader.GetInt32(reader.GetOrdinal("easycount"));
                            int okaycount = reader.GetInt32(reader.GetOrdinal("okaycount"));
                            int difficultcount = reader.GetInt32(reader.GetOrdinal("difficultcount"));
                            int verydifficultcount = reader.GetInt32(reader.GetOrdinal("verydifficultcount"));
                            if(folderid_check == folderid)
                            {
                                score = Math.Ceiling((veryeasycount * 1 + easycount * 0.75 + okaycount * 0.5 + difficultcount * 0.25 + verydifficultcount * 0.0) / (veryeasycount + easycount + okaycount + difficultcount + verydifficultcount) * 100 * 100) / 100;
                            }
                        }
                        return score;
                    }
                }

            }
        }
        public static double CalculateCardscore(int cardid)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM cardscore";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        double score = 0;
                        while (reader.Read())
                        {
                            int cardid_check = reader.GetInt32(reader.GetOrdinal("cardid"));
                            int veryeasycount = reader.GetInt32(reader.GetOrdinal("veryeasycount"));
                            int easycount = reader.GetInt32(reader.GetOrdinal("easycount"));
                            int okaycount = reader.GetInt32(reader.GetOrdinal("okaycount"));
                            int difficultcount = reader.GetInt32(reader.GetOrdinal("difficultcount"));
                            int verydifficultcount = reader.GetInt32(reader.GetOrdinal("verydifficultcount"));
                            if (cardid_check == cardid)
                            {
                                score = Math.Ceiling((veryeasycount * 1 + easycount * 0.75 + okaycount * 0.5 + difficultcount * 0.25 + verydifficultcount * 0.0) / (veryeasycount + easycount + okaycount + difficultcount + verydifficultcount) * 100 * 100) / 100;
                            }
                        }
                        return score;
                    }
                }

            }
        }

        public static void CheckUsers(string email, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM logins";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        bool login_suc = false;
                        while (reader.Read())
                        {
                            int userid_check = reader.GetInt32(reader.GetOrdinal("userid"));
                            string username_check = reader.GetString(reader.GetOrdinal("username"));
                            string email_check = reader.GetString(reader.GetOrdinal("email"));
                            string password_check = reader.GetString(reader.GetOrdinal("password"));


                            if (email_check == email & password_check == password)
                            {
                                MessageBox.Show("login successfull");
                                login_suc = true;
                                Form1.CreateAndDeleteForm();
                            }


                        }
                        if (login_suc == false)
                        {
                            MessageBox.Show("Incorrect Email or Password");
                        }


                    }
                }
            }
        }
        public static string[] GetUserFromEmail(string email)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM logins";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string[] users_array = new string[3];
                        while (reader.Read())
                        {
                            int userid_check = reader.GetInt32(reader.GetOrdinal("userid"));
                            string username_check = reader.GetString(reader.GetOrdinal("username"));
                            string email_check = reader.GetString(reader.GetOrdinal("email"));
                            string password_check = reader.GetString(reader.GetOrdinal("password"));
                            if (email_check == email)
                            {
                                users_array[0] = Convert.ToString(userid_check);
                                users_array[1] = username_check;
                                users_array[2] = email_check;
                                return users_array;
                            }

                        }
                        return null;

                    }
                }
            }
        }
        public static int GetFolderIDFromFolderName(string folderName)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM folders";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        int folderid = 0;
                        while (reader.Read())
                        {
                            int folderid_check = reader.GetInt32(reader.GetOrdinal("folderid"));
                            string foldername_check = reader.GetString(reader.GetOrdinal("foldername"));
                            if (foldername_check == folderName)
                            {
                                folderid = folderid_check;
                            }
                        }
                        return folderid;
                    }
                }
            }
        }
        public static List<Cards> GetCardList(string folderid)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM cards";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        int userid = Convert.ToInt32( application.userid);
                        List<Cards> Cards = new List<Cards>();
                        while (reader.Read())
                        {
                            string cardid = Convert.ToString( reader.GetInt32(reader.GetOrdinal("cardid")));
                            string folderid_check = Convert.ToString(reader.GetInt32(reader.GetOrdinal("folderid")));
                            string question = reader.GetString(reader.GetOrdinal("question"));
                            string answer = reader.GetString(reader.GetOrdinal("answer"));
                            double score = 0;
                            try
                            {
                                score = reader.GetDouble(reader.GetOrdinal("score"));
                            }
                            catch (Exception)
                            {
                                score = 0;
                            }
                            


                            if (folderid_check == folderid)
                            {
                                Cards.Add(new Cards(userid, Convert.ToInt32( cardid),Convert.ToInt32( folderid), question, answer, score));
                            }


                        }
                        return Cards;
                    }
                }
            }
        }
        public static string GetFolderidFromFoldername(string foldername)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open ();
                string query = "SELECT * FROM folders";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string folderid = "";
                        while (reader.Read())
                        {
                            int folderid_check = reader.GetInt32(reader.GetOrdinal("folderid"));
                            string foldername_check = reader.GetString(reader.GetOrdinal("foldername"));
                            if (foldername_check == foldername)
                            {
                                folderid = Convert.ToString(folderid_check);
                            }
                        }
                        return folderid;
                    }
                }
            }
        }
        public static Queue<string> GetCardsFromFolderID(string folderid, string cardsperround)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open ();
                string query = "SELECT * FROM cards";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        Queue<string> cards = new Queue<string>();
                        while (reader.Read())
                        {
                            int folderid_check = reader.GetInt32(reader.GetOrdinal("folderid"));
                            string imagelocationfront = reader.GetString(reader.GetOrdinal("imagelocationfront"));
                            string imagelocationback = reader.GetString(reader.GetOrdinal("imagelocationback"));
                            string question = reader.GetString(reader.GetOrdinal("question"));
                            string answer = reader.GetString(reader.GetOrdinal("answer"));
                            if (folderid_check == Convert.ToInt32(folderid) && cardsperround == "ALL" || cardsperround == "")
                            {
                                if (imagelocationfront != "")
                                {
                                    cards.Enqueue(question + "|" +imagelocationfront);
                                }
                                else
                                {
                                    cards.Enqueue(question);
                                }
                                if (imagelocationback != "")
                                {
                                    cards.Enqueue(answer + "|" +imagelocationback);
                                }
                                else
                                {
                                    cards.Enqueue (answer);
                                }
                            }
                            else if (folderid_check == Convert.ToInt32(folderid) && cards.Count < Convert.ToInt32(cardsperround)*2)
                            {
                                cards.Enqueue(question);
                                cards.Enqueue(answer);
                            }
                        }
                        return cards;
                    }
                }
            }
        }
    }
}


        
            