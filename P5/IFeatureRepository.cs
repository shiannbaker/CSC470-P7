using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public interface IFeatureRepository
    {
        string Add(Feature _feature);
        List<Feature> GetAll(int ProjectId);
        string Remove(Feature _feature);
        string Modify(Feature _feature);
        Feature GetFeatureById(int projectId, int featureId);
        Feature GetFeatureByTitle(int projectId, string title);
    }
}
