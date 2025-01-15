namespace ReadExcireWindowsForms;

using System;
using System.Data.SQLite;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        // Example initialization for ListView
        listViewAnnotations.View = View.Details;
        listViewAnnotations.FullRowSelect = true; // Ensures the entire row is selectable.
        listViewAnnotations.Columns.Add("Annotation", 500); // Column for annotations
        listViewAnnotations.Columns.Add("Image Count", 110); // Column for image count
    }

    private void buttonReadAnnotations_Click(object sender, EventArgs e)
    {
        // throw new System.NotImplementedException();
        ConnectToDatabaseAndRetrieveData();
    }

    void ConnectToDatabaseAndRetrieveData()
    {
        // Pfad zur SQLite-Datenbank
        // string databasePath = @"C:\Users\edlei\OneDrive\access\excire\ideacenter01lightroom01-v13-3 Excire.excat";
        string databasePath =
            @"D:\Lightroom\LightroomCatalog2023-02\LightroomCatalog2023-02\LightroomCatalog2023-02-v13-3 Excire.excat";

        try
        {
            // Verbindung zur SQLite-Datenbank herstellen
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databasePath};Version=3;"))
            {
                connection.Open();
                Console.WriteLine($"Connected to database: {databasePath}");

                // SQL-Befehle ausführen
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    // Beispiel: Tabellen abrufen
                    command.CommandText = "SELECT name FROM sqlite_master WHERE type='table';";
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("Available Tables:");
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString(0));
                        }
                    }
                    
                    // Beispiel: Annotationen abrufen
                    listViewAnnotations.Items.Clear();
                    command.CommandText = "SELECT annotation, images_count FROM annotations ORDER BY annotation;";
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        int totalAnnotations = 0;
                        
                        while (reader.Read())
                        {
                            string annotation = reader.GetString(0);
                            int imagesCount = reader.GetInt32(1);
                            Console.WriteLine($"{annotation} {imagesCount}");
                            // Add to ListView
                            AddAnnotationToListView(annotation, imagesCount);
                            totalAnnotations++;
                        }
                        labelTotalAnnotations.Text = totalAnnotations.ToString();
                        
                    }
                }

                // Verbindung schließen
                connection.Close();
                Console.WriteLine("Connection closed.");
            }
        }
        catch (SQLiteException ex)
        {
            Console.WriteLine($"Error while connecting to SQLite: {ex.Message}");
        }
    }
    private void AddAnnotationToListView(string annotation, int imagesCount)
    {
        // Create a new item
        ListViewItem item = new ListViewItem(annotation); // First column value
        item.SubItems.Add(imagesCount.ToString()); // Second column value

        // Add the item to the ListView
        listViewAnnotations.Items.Add(item);
    }

    private void listViewAnnotations_SelectedIndexChanged(object sender, EventArgs e)
    {
        // throw new System.NotImplementedException();
    }
    
}