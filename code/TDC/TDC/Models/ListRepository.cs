using System.Security.Cryptography.X509Certificates;

namespace TDC.Models
{
    public class ListRepository
    {
        private readonly List<ToDoList> lists;
        private readonly string filePath = "C:\\Users\\PC\\Source\\Repos\\Project-TDC\\code\\TDC\\TDC\\lists.csv";

        #region constructors
        public ListRepository()
        {
            lists = new List<ToDoList>();
        }

        public ListRepository(List<ToDoList> lists)
        {
            this.lists = lists;
        }
        #endregion

        #region publics

        public void AddList(ToDoList list)
        {
            lists.Add(list);
            SaveListsToFile(); // Liste nach dem Hinzufügen in CSV speichern
        }

        public void RemoveList(ToDoList list)
        {
            lists.Remove(list);
            SaveListsToFile(); // Liste nach dem Hinzufügen in CSV speichern
        }

        public List<ToDoList> GetLists()
        {
            return lists;
        }

        #endregion
        #region private methods

        private void SaveListsToFile()
        {
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
        #endregion
    }
}
