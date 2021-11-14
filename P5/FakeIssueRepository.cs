using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeIssueRepository : IIssueRepository
    {
        public const string NO_ERROR = "";
        public const string EMPTY_TITLE_ERROR = "A Title is required.";
        public const string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date/Time.";
        public const string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        public const string EMPTY_DISCOVERER_ERROR = "A Discoverer is required.";

        private static List<Issue> Issues;

        public string Add(Issue issue)
        {
            Issues.Add(issue);

            return NO_ERROR;
        }
        public List<Issue> GetAll(int ProjectId)
        {
            return Issues.Where(x => x.ProjectId == ProjectId).ToList();
        }
        public bool Remove(Issue issue)
        {
            return Issues.Remove(issue);
        }
        public string Modify(Issue issue)
        {

        }
        public int GetTotalNumberOfIssues(int ProjectId)
        {
            // Utilize our already existing function to get a list of all Issues with specified ProjectId
            return GetAll(ProjectId).Count();
        }
        public List<string> GetIssuesByMonth(int ProjectId)
        {
        }
        public List<string> GetIssuesByDiscoverer(int ProjectId)
        {

        }
        public Issue GetIssueById(int Id)
        {
            return Issues.Find(x => x.Id == Id);
        }
        
        private string ValidateIssue(Issue issue)
        {
            if (issue.Title.Equals(""))
            {
                return EMPTY_TITLE_ERROR;
            }
            else if(issue.DiscoveryDate.Equals(DateTime.MinValue))
            {
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            }
            else if (DateTime.Compare(issue.DiscoveryDate, DateTime.Now) > 0)
            {
                return FUTURE_DISCOVERY_DATETIME_ERROR;
            }
            else if (issue.Discoverer.Equals(""))
            {
                return EMPTY_DISCOVERER_ERROR;
            }
            else
            {
                return NO_ERROR;
            }
        }
        private bool IsDuplicate(string title)
        {
            return Issues.Exists(x => x.Title.Equals(title));
        }
    }
}
