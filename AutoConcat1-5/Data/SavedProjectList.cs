using System.ComponentModel;

namespace AutoConcat1_5.Data
{
    /// <summary>
    /// Holds saved projects for indexing by the user.
    /// </summary>
    public sealed class SavedProjectList : BindingList<Project>
    {
        private static SavedProjectList instance = null;
        private static readonly object padlock = new object();

        SavedProjectList() { }

        public static SavedProjectList Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SavedProjectList();
                    }
                    return instance;
                }
            }
        }
    }
}