using AutoConcat1_5.Data;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace AutoConcat1_5.Function
{
    public static class Concatenator
    {
        private static DataRepeater _dataRepeater;
        private static RichTextBox _inputBox; 
        private static RichTextBox _outputBox; 
        private static TextBox _prefixBox; 
        private static TextBox _infixBox; 
        private static TextBox _suffixBox;

        /// <summary>
        /// Initialize the Concatenator's source and output fields.
        /// </summary>
        public static void SetDataFields(DataRepeater dataRepeater, RichTextBox inputBox, RichTextBox outputBox, TextBox prefixBox, TextBox infixBox, TextBox suffixBox)
        {
            _dataRepeater = dataRepeater;
            _inputBox = inputBox;
            _outputBox = outputBox;
            _prefixBox = prefixBox;
            _infixBox = infixBox;
            _suffixBox = suffixBox;
        }

        /// <summary>
        /// Carry out the functionality below in sequence. Occurs every 'update' to automatically fill the data fields.
        /// </summary>
        public static void Concatenate()
        {
            string input = _inputBox.Text;
            input = PreProcess(input);
            input = InsertDelimiters(input);
            input = PostProcess(input);
            _outputBox.Text = input;
        }

        // Apply filters and operations to the text before concatenation.
        private static string PreProcess(string input)
        {
            int indexCounter = 0;
            foreach (Operation op in OperationList.Instance)
            {
                if (!op.IsAfterConcat)
                {
                    input = DoOperation(op, input);
                    indexCounter++;
                }
            }
            return input;
        }

        // Concat the text with the given delimiters.
        private static string InsertDelimiters(string input)
        {
            input = Regex.Replace(input, @"\s+", _infixBox.Text);
            input = string.Concat(_prefixBox.Text, input, _suffixBox.Text);
            return input;
        }

        // Apply filters and operations to the text after concatenation.
        private static string PostProcess(string input)
        {
            int indexCounter = 0;
            foreach (Operation op in OperationList.Instance)
            {
                if (op.IsAfterConcat)
                {
                    input = DoOperation(op, input);
                    indexCounter++;
                }
            }
            return input;
        }

        // Routes text through the functionality for all of the operations.
        private static string DoOperation(Operation operation, string input)
        {
            switch (operation.OpType)
            {
                // Replace every instance of the listed characters with a string.
                case OperationType.ReplaceChars:
                    if (!string.IsNullOrEmpty(operation.Text1))
                    {
                        foreach (char c in operation.Text1)
                        {
                            input = input.Replace($"{c}", operation.Text2 ?? "");
                        }
                    }
                    break;

                // Adds a string to the end of the text.
                case OperationType.Append:
                    input = string.Concat(input, operation.Text1);
                    break;

                // Adds a string to the start of the text.
                case OperationType.Prepend:
                    input = string.Concat(operation.Text1, input);
                    break;

                // Replace every instance of the listed characters with a string.
                case OperationType.ReplaceString:
                    if (!string.IsNullOrEmpty(operation.Text1))
                    {
                        input = input.Replace(operation.Text1, operation.Text2 ?? "");
                    }
                    break;

                // Removes leading and trailing whitespace.
                case OperationType.TrimWhitespace:
                    input = input.Trim();
                    break;

                // Trim characters from the start and end of the text, based on the numbers in the top and bottom boxes respectively.
                case OperationType.TrimEdges:
                    if (!string.IsNullOrEmpty(operation.Text1))
                    {
                        if (int.TryParse(operation.Text1, out int intNum))
                        {
                            if (intNum > input.Length)
                            {
                                intNum = input.Length;
                            }
                            input = input.Remove(0, intNum);
                        }
                    }
                    if (!string.IsNullOrEmpty(operation.Text2))
                    {
                        if (int.TryParse(operation.Text2, out int intNum))
                        {
                            if (intNum > input.Length)
                            {
                                intNum = input.Length;
                            }
                            input = input.Substring(0, input.Length - intNum);
                        }
                    }
                    break;

                // Replace each instance of a given string with line breaks.
                case OperationType.InsertLineBreaks:
                    if (!string.IsNullOrEmpty(operation.Text1))
                    {
                        input = input.Replace(operation.Text1, "\n");
                    }
                    break;

                // Replace anything matched by the given Regular Expression with a string.
                case OperationType.RegexReplace:
                    if (!string.IsNullOrEmpty(operation.Text1))
                    {
                        try
                        {
                            input = Regex.Replace(input, operation.Text1, operation.Text2);
                        }
                        catch{ }
                    }
                    break;

                // Makes any letters uppercase.
                case OperationType.ToUpper:
                    input = input.ToUpper();
                    break;

                // Makes any letters lowercase.
                case OperationType.ToLower:
                    input = input.ToLower();
                    break;
            }
            return input;
        }
    }
}
