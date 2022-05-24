// See https://aka.ms/new-console-template for more information

using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

SqlConnection cnn;
var connectionString = @"Server=.;Database=TestDatabase;Trusted_Connection=True;";
cnn = new SqlConnection(connectionString);
cnn.Open();

string insertText = @"insert into Persons(PersonID, LastName, FirstName, Address)
values(1, 'Baranauskas', 'Mantas', 'Vilnius')";

var command = cnn.CreateCommand();
command.CommandText = insertText;
command.ExecuteNonQuery();

cnn.Close();  