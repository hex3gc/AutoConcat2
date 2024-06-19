using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AutoConcat1_5.Data
{
    /// <summary>
    /// Saved data fields and operations for the program.
    /// </summary>
    public class Project
    {
        public Project(string title, string lastSaved, List<Operation> plainOpList, string inBox, string outBox, string prefix, string infix, string suffix)
        {
            Title = title;
            PlainOperationList = plainOpList;
            LastSaved = lastSaved;

            InBox = inBox;
            OutBox = outBox;
            Prefix = prefix;
            Infix = infix;
            Suffix = suffix;
        }

        // Metadata
        public string Title { get; set; }
        public string LastSaved { get; set; }

        // Saved data
        public List<Operation> PlainOperationList { get; set; }

        public string InBox { get; set; }
        public string OutBox { get; set; }
        public string Prefix { get; set; }
        public string Infix { get; set; }
        public string Suffix { get; set; }
        public string ChosenDelimiterName { get; set; }

        public void Update(Project project)
        {
            LastSaved = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");

            PlainOperationList.Clear();
            if (project.PlainOperationList.Count > 0)
            {
                foreach (var op in project.PlainOperationList)
                {
                    PlainOperationList.Add(op.Clone() as Operation);
                }
            }

            InBox = project.InBox;
            OutBox = project.OutBox;
            Prefix = project.Prefix;
            Infix = project.Infix;
            Suffix = project.Suffix;
        }
    }
}