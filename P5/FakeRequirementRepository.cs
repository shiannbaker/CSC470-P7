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
            return "annyeong";
        }
        public List<Requirement> GetAll(int ProjectId)
        {
            return requirements;
        }
        public string Remove(Requirement requirement)
        {
            return "bye";
        }
        public string Modify(Requirement requirement)
        {
            return "hi";
        }
        public Requirement GetRequirementById(int requirementId)
        {
            Requirement requirement = new Requirement();
            return requirement;
        }
        public int CountByFeatureId(int featureId)
        {
            return -1;
        }
        public void RemoveByFeatureId(int featureId)
        {

        }
    }
}
