using AutoConcat1_5;
using Microsoft.VisualBasic.PowerPacks;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AutoConcat1_5.Data
{
    /// <summary>
    /// A modifier that applies before or after concatenation depending on its values.
    /// </summary>
    public class Operation : ICloneable
    {
        public Operation(OperationType opType)
        {
            OpType = opType;
            IsAfterConcat = false;
            Text1Visible = true;
            Text2Visible = true;
            IntWarningVisible = false;

            switch (opType)
            {
                case OperationType.ReplaceChars:
                    Title = "Replace Characters";
                    Description = "Replace every instance of the listed characters with a string.";
                    break;
                case OperationType.Prepend:
                    Title = "Prepend String";
                    Description = "Adds a string to the start of the text.";
                    Text2Visible = false;
                    break;
                case OperationType.Append:
                    Title = "Append String";
                    Description = "Adds a string to the end of the text.";
                    Text2Visible = false;
                    break;
                case OperationType.ReplaceString:
                    Title = "Replace Strings";
                    Description = "Replace every instance of the listed string with a string.";
                    break;
                case OperationType.TrimWhitespace:
                    Title = "Trim Whitespace";
                    Description = "Removes leading and trailing whitespace.";
                    Text1Visible = false;
                    Text2Visible = false;
                    break;
                case OperationType.TrimEdges:
                    Title = "Trim Edges";
                    Description = "Trim an amount of characters from the start and end of the text based on the numbers in the top and bottom boxes respectively.";
                    IntWarningVisible = true;
                    break;
                case OperationType.InsertLineBreaks:
                    Title = "Insert Line Breaks";
                    Description = "Replace each instance of a given string with a line break.";
                    Text2Visible = false;
                    break;
                case OperationType.RegexReplace:
                    Title = "Regex Replace";
                    Description = "Replace anything matched by the given Regular Expression with a string.";
                    break;
                case OperationType.ToUpper:
                    Title = "To Uppercase";
                    Description = "Makes any letters uppercase.";
                    Text1Visible = false;
                    Text2Visible = false;
                    break;
                case OperationType.ToLower:
                    Title = "To Lowercase";
                    Description = "Makes any letters lowercase.";
                    Text1Visible = false;
                    Text2Visible = false;
                    break;
            }
        }

        public OperationType OpType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }

        public bool IsAfterConcat { get; set; }
        public bool Text1Visible { get; set; }
        public bool Text2Visible { get; set; }
        public bool IntWarningVisible { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
