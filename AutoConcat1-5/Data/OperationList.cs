using System.ComponentModel;

namespace AutoConcat1_5.Data
{
    /// <summary>
    /// Holds all operations in the program.
    /// </summary>
    public sealed class OperationList : BindingList<Operation>
    {
        private static OperationList instance = null;
        private static readonly object padlock = new object();

        public OperationList(){ }

        public static OperationList Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new OperationList();
                    }
                    return instance;
                }
            }
        }

        public void BumpItemDown(int index)
        {
            if (Count > 1 && index > 0)
            {
                SwapAt(index, index - 1);
            }
        }

        public void BumpItemUp(int index)
        {
            if (Count > 1 && index < Count - 1)
            {
                SwapAt(index, index + 1);
            }
        }

        public void SwapAt(int index1, int index2)
        {
            Operation temp1 = this[index1];
            this[index1] = this[index2];
            this[index2] = temp1;
        }
    }
}