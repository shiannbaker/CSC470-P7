using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeRequirementRepository : IRequirementRepository
    {
        string NO_ERROR = "";
        string DUPLICATE_STATEMENT_ERROR = "Statements must be unique.";
        string EMPTY_STATEMENT_ERROR = "Statement must have a value.";
        string REQUIREMENT_NOT_FOUND_ERROR = "Requirement does not exist.";
        string MISSING_FEATUREID_ERROR = "Must select a feature for this requirement.";
        string MISSING_PROJECTID_ERROR = "Must select a project for this requirement.";
        private static List<Requirement> requirements = new List<Requirement>();

        public string Add(Requirement requirement)
        {
            if (requirement.Statement.Equals(""))
            {
                return EMPTY_STATEMENT_ERROR;
            }
            foreach(Requirement r in requirements)
            {
                if (r.Statement.Equals(requirement.Statement))
                {
                    return DUPLICATE_STATEMENT_ERROR;
                }
            }
            if (requirement.FeatureId < 0)
            {
                return MISSING_FEATUREID_ERROR;
            }
            if (requirement.ProjectId < 0)
            {
                return MISSING_PROJECTID_ERROR;
            }

            requirement.Id = GetNextId();
            requirements.Add(requirement);

            return NO_ERROR;
        }
        public List<Requirement> GetAll(int ProjectId)
        {
            return requirements;
        }
        public string Remove(Requirement requirement)
        {
            if (requirements.Contains(requirement))
            {
                requirements.Remove(requirement);
                return NO_ERROR;
            }
            else
            {
                return REQUIREMENT_NOT_FOUND_ERROR;
            }
        }
        public string Modify(Requirement requirement)
        {
            if (requirement.Statement.Equals(""))
            {
                return EMPTY_STATEMENT_ERROR;
            }
            foreach (Requirement r in requirements)
            {
                if (r.Statement.Equals(requirement.Statement) && r.Id != requirement.Id)
                {
                    return DUPLICATE_STATEMENT_ERROR;
                }
            }
            if (requirement.FeatureId < 0)
            {
                return MISSING_FEATUREID_ERROR;
            }
            if (requirement.ProjectId < 0)
            {
                return MISSING_PROJECTID_ERROR;
            }


            // remove the old from the list
            requirements.RemoveAll(x => x.Id == requirement.Id);
            // Add the new "modified" version
            requirements.Add(requirement);
            return NO_ERROR;
        }
        public Requirement GetRequirementById(int requirementId)
        {
            List<Requirement> newList = new List<Requirement>(requirements);
            Requirement req = newList.Find(x => x.Id == requirementId);
            return req;
        }
        public int CountByFeatureId(int featureId)
        {
            List<Requirement> newList = new List<Requirement>(requirements);
            return newList.FindAll(x => x.FeatureId == featureId).Count();
        }
        public void RemoveByFeatureId(int featureId)
        {
            requirements.RemoveAll(x => x.FeatureId == featureId);
        }

        private int GetNextId()
        {
            int currentMaxId = 0;
            foreach (Requirement r in requirements)
            {
                currentMaxId = r.Id;
            }
            return ++currentMaxId;
        }
    }
}
