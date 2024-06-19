using System.ComponentModel;

namespace AutoConcat1_5.Data
{
    /// <summary>
    /// Holds saved projects for indexing by the user.
    /// </summary>
    public sealed class DelimiterPresetList : BindingList<DelimiterPreset>
    {
        private static DelimiterPresetList instance = null;
        private static readonly object padlock = new object();

        DelimiterPresetList() { }

        public static DelimiterPresetList Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DelimiterPresetList();
                    }
                    return instance;
                }
            }
        }
    }
}