using NeonTrees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeonTrees.Interface
{
    public interface IBuildService
    {
        IEnumerable<Build> GetAllBuilds();
        Build GetBuildById(int id);
        void AddBuild(Build build);
        void EditBuild(Build build);
        void DeleteBuild(Build build);
        public List<int> GetBuildPriceData();
        public List<int> GetBuildPerMonth();
        public IEnumerable<Build> GetAllUserBuilds(int user_id);
        public int GetBuildId(Build build);
        public void DeleteBuildId(int id);
    }
}
