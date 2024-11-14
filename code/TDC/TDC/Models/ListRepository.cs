using System.Security.Cryptography.X509Certificates;

namespace TDC.Models
{
    public class ListRepository
    {
        private readonly List<ToDoList> lists;

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
        }

        public void RemoveList(ToDoList list)
        {
            lists.Remove(list);
        }

        public List<ToDoList> GetLists()
        {
            return lists;
        }

        #endregion
    }
}
