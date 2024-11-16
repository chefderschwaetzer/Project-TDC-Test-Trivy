using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace TDC.Models
{
    public class ListRepository
    {
        private List<ToDoList> lists;
        private readonly string filePath = "C:\\Users\\PC\\Source\\Repos\\Project-TDC\\code\\TDC\\TDC\\lists.csv";

        #region constructors
        public ListRepository()
        {
            lists = new List<ToDoList>();
            LoadAllListsFromFile();
        }

        public ListRepository(List<ToDoList> lists)
        {
            this.lists = lists;
        }
        #endregion

        #region publics

        public void AddList(ToDoList list)
        {
            SaveListsToFile(list); // Liste nach dem Hinzufügen in CSV speichern
        }

        public void RemoveList(ToDoList list)
        {
            lists.Remove(list);
            //SaveListsToFile(list);  Liste nach dem Hinzufügen in CSV speichern !!!geht nicht mit der aktuellen implementierung
        }

        public List<ToDoList> GetLists()
        {
            return lists;
        }

        #endregion
        #region private methods

        private void SaveListsToFile(ToDoList list)
        {
            // Prüfen, ob eine Liste mit der gleichen ID existiert
            var existingList = lists.FirstOrDefault(l => l.GetID() == list.GetID());

            if (existingList != null)
            {
                // Wenn die Liste existiert, entferne sie
                lists.Remove(existingList);
            }

            // Füge die neue oder aktualisierte Liste hinzu
            lists.Add(list);

            // Schreibe alle Listen in die Datei
            using (var writer = new StreamWriter(filePath))
            {
                // Header für CSV
                writer.WriteLine("ListID,ListName,ItemDescription,Effort,Done,Members");

                // Durch alle Listen und deren Items iterieren und in CSV speichern
                foreach (var todoList in lists)
                {
                    foreach (var item in todoList.GetItems())
                    {
                        // Konvertiere jedes ListItem in CSV-formatierte Zeilen
                        writer.WriteLine($"{todoList.GetID()},{todoList.GetName()},{item.GetDescription()},{item.GetEffort()},{item.IsDone()}");
                    }
                }
            }
        }


        private void LoadAllListsFromFile()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath).Skip(1); // Skip the header line

                // Eine Dictionary für jede ListID erstellen, um die Items später der richtigen Liste zuzuordnen
                var listDict = new Dictionary<string, ToDoList>();

                foreach (var line in lines)
                {
                    var values = line.Split(',');

                    var listId = values[0];
                    var listName = values[1];
                    var itemDescription = values[2];
                    var itemEffort = int.Parse(values[3]);
                    var itemDone = bool.Parse(values[4]);

                    // Wenn die Liste noch nicht existiert, erstellen wir sie und fügen sie zum Dictionary hinzu
                    if (!listDict.ContainsKey(listId))
                    {
                        var todoList = new ToDoList(listName, listId);
                        listDict[listId] = todoList;
                    }

                    // Füge das ListItem zur Liste hinzu
                    var todoItem = new ListItem(itemDescription, itemDone, new List<Profile>(), itemEffort);

                    listDict[listId].AddItem(todoItem);
                }

                // Holen Sie alle Listen aus dem Dictionary und speichern Sie sie in der endgültigen Liste
                lists = listDict.Values.ToList();
            }
        }
        #endregion
    }
}
