using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5
{
    public class FakeFeatureRepository : IFeatureRepository
    {
        int nextId = 0;
        string NO_ERROR = "Added Successfully.";
        string DUPICATE_TITLE_ERROR = "Title must be unique.";
        string EMPTY_TITLE_ERROR = "Title must have a value";
        string NOT_FOUND_ERROR = "Feature not found.";
        string INVALID_PROJECT_ID_ERROR = "Invalid Project Id for Feature.";
        private static List<Feature> features = new List<Feature>();

        public string Add(Feature _feature)
        {
            if (_feature.Title == "" || _feature.Title == null)
            {
                 return EMPTY_TITLE_ERROR;
            }
            foreach (Feature f in features)
            {
                if (_feature.Title == f.Title)
                {
                    return DUPICATE_TITLE_ERROR;
                }
            }

            //project ID
            FormSelectProject sProject = new FormSelectProject();
            int id = -1;
            id = sProject.currentPID();
            if (id == -1)
            {
                return INVALID_PROJECT_ID_ERROR;
            }
            _feature.ProjectId = id;

            _feature.Id = getNextId();
            MessageBox.Show(_feature.Id.ToString());

            features.Add(_feature);

            return NO_ERROR;
        }
        public List<Feature> GetAll(int ProjectId)
        {
            List<Feature> newList = features.ToList();
            int num = newList.RemoveAll(x => x.ProjectId != ProjectId);
            return features;
        }
        private int getNextId()
        {
            int currentMaxId = 0;
            List<Feature> List = new List<Feature>(features);

            foreach (Feature x in List)
            {
                if (currentMaxId < x.Id)
                {
                    currentMaxId = x.Id;
                }
            }
            return ++currentMaxId;
        }
        public string Remove(Feature _feature)
        {
            features.Remove(_feature);
            return features.Remove(_feature).ToString();
        }
        public string Modify(Feature _feature)
        {
            return "bye";
        }
        public Feature GetFeatureById(int projectId, int featureId)
        {
            FakeFeatureRepository fakefeatures = new FakeFeatureRepository();
            List<Feature> listF = new List<Feature>();
            listF = fakefeatures.GetAll(projectId);

            return listF.Find(x => x.Id == featureId);
        }
        public Feature GetFeatureByTitle(int projectId, string title)
        {
            Feature feature = new Feature();
            return feature;
        }
    }
}
