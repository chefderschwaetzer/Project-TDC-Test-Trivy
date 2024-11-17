namespace TDC.Models
{
    public class ListRepository
    {
        private List<ToDoList> lists;

        private readonly string projectPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\.."));
        private readonly string filePath;

        #region constructors
        public ListRepository()
        {
            filePath = Path.Combine(projectPath, "lists.csv");
            #if ANDROID
             string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath); // Verzeichnis erstellen, wenn es nicht existiert
                }

                filePath = Path.Combine(directoryPath, "lists.csv");
            #endif
            lists = new List<ToDoList>();
            LoadAllListsFromFile();
        }

#endregion

        #region publics

        public void AddList(ToDoList list)
        {
            SaveListsToFile(list);
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

        #region privates
        private void SaveListsToFile(ToDoList list)
        {
            // check if list with id exists
            var existingList = lists.FirstOrDefault(l => l.GetID() == list.GetID());

            if (existingList != null)
            {
                // if list exists, remove line
                lists.Remove(existingList);
            }

            // add new/updated list
            lists.Add(list);

            // overwrite updated list array to csv
            using (var writer = new StreamWriter(filePath))
            {
                // Header for CSV
                writer.WriteLine("ListID;ListName;ItemDescription;Effort;Done;Members");

                foreach (var todoList in lists)
                {
                    foreach (var item in todoList.GetItems())
                    {
                        // convert to csv
                        writer.WriteLine($"{todoList.GetID()};{todoList.GetName()};{item.GetDescription()};{item.GetEffort()};{item.IsDone()}");
                    }
                }
            }
        }

        private void LoadAllListsFromFile()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath).Skip(1); // Skip the header line

                // create dict for each list id, to place items in the correct list
                var listDict = new Dictionary<string, ToDoList>();

                foreach (var line in lines)
                {
                    var values = line.Split(';');

                    var listId = values[0];
                    var listName = values[1];
                    var itemDescription = values[2];
                    var itemEffort = int.Parse(values[3]);
                    var itemDone = bool.Parse(values[4]);

                    // if list doesnt ecist, create and add to dict
                    if (!listDict.ContainsKey(listId))
                    {
                        var todoList = new ToDoList(listName, listId);
                        listDict[listId] = todoList;
                    }

                    // add list item
                    var todoItem = new ListItem(itemDescription, itemDone, new List<Profile>(), itemEffort);

                    listDict[listId].AddItem(todoItem);
                }

                // get all lists from dict and save to actual buffer
                lists = listDict.Values.ToList();
            }
        }
        #endregion
    }
}
