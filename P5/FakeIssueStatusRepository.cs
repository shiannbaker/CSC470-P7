using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private static List<IssueStatus> _IssueStatuses;

        public void Add(int Id, string value)
        {
            // Create a new list status and add it to the list
            var newItem = new IssueStatus();
            newItem.Id = Id;
            newItem.Value = value;

            _IssueStatuses.Add(newItem);
        }

        public List<IssueStatus> GetAll()
        {
            return _IssueStatuses;
        }

        public int GetIdByStatus(string value)
        {
            if (_IssueStatuses.Exists(x => x.Value.Equals(value)))
            {
                return _IssueStatuses.Find(x => x.Value.Equals(value)).Id;
            }
            else
            {
                // Should this return something else?
                return -1;
            }
        }

        public string GetValueById(int Id)
        {
            if (_IssueStatuses.Exists(x => x.Id.Equals(Id)))
            {
                return _IssueStatuses.Find(x => x.Id.Equals(Id)).Value;
            }
            else
            {
                // Should this return something else?
                return "";
            }
        }
    }
}
