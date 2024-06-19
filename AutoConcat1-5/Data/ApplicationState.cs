using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace AutoConcat1_5.Data
{
    /// <summary>
    /// Holds all the global settings for the program.
    /// </summary>
    public sealed class ApplicationState
    {
        public static string AppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AutoConcat2\\");
        public static string AppDataFile = Path.Combine(AppDataPath, "application.json");

        private static ApplicationState instance = null;
        private static readonly object padlock = new object();

        ApplicationState(){ }

        public static ApplicationState Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ApplicationState();
                    }
                    return instance;
                }
            }
        }

        // UI / UX settings
        public bool LightMode { get; set; }

        // Saving settings
        public string SavePath { get; set; }

        public void SaveApplicationToFile()
        {
            JObject finalJson = new JObject();

            // Settings
            JObject saveObject = new JObject
            {
                ["LightMode"] = LightMode,
                ["SavePath"] = SavePath
            };

            // Projects
            JArray projectsArray = new JArray();
            foreach (var project in SavedProjectList.Instance)
            {
                JObject projectObject = new JObject
                {
                    ["Title"] = project.Title,
                    ["LastSaved"] = project.LastSaved,
                    ["InBox"] = project.InBox,
                    ["OutBox"] = project.OutBox,
                    ["Prefix"] = project.Prefix,
                    ["Infix"] = project.Infix,
                    ["Suffix"] = project.Suffix,
                    ["ChosenDelimiterName"] = project.ChosenDelimiterName
                };
                JArray projectOperationArray= new JArray();
                foreach (Operation op in project.PlainOperationList)
                {
                    projectOperationArray.Add(new JObject
                    {
                        ["OpType"] = op.OpType.ToString(),
                        ["Text1"] = op.Text1,
                        ["Text2"] = op.Text2,
                        ["IsAfterConcat"] = op.IsAfterConcat
                    });
                }
                projectObject.Add(new JProperty("Operations", projectOperationArray));
                projectsArray.Add(projectObject);
            }

            // Delimiter Presets
            JArray delimiterPresetsArray = new JArray();
            foreach (var delimiterPreset in DelimiterPresetList.Instance)
            {
                delimiterPresetsArray.Add(new JObject
                {
                    ["Title"] = delimiterPreset.Title,
                    ["Prefix"] = delimiterPreset.Prefix,
                    ["Infix"] = delimiterPreset.Infix,
                    ["Suffix"] = delimiterPreset.Suffix
                });
            }

            finalJson.Add(new JProperty("Settings", saveObject));
            finalJson.Add(new JProperty("Projects", projectsArray));
            finalJson.Add(new JProperty("DelimiterPresets", delimiterPresetsArray));

            string serializedJson = JsonConvert.SerializeObject(finalJson);

            File.WriteAllText(AppDataFile, serializedJson);
        }

        public bool LoadApplicationFromFile()
        {
            string fileText = string.Empty;
            try
            {
                fileText = File.ReadAllText(AppDataFile);
                if (string.IsNullOrWhiteSpace(fileText))
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            var deserializedFile = JsonConvert.DeserializeObject<dynamic>(fileText);

            // Init settings
            instance.LightMode = deserializedFile.Settings.LightMode;
            instance.SavePath = Convert.ToString(deserializedFile.Settings.SavePath);

            // Saved projects & operations
            SavedProjectList.Instance.Clear();
            foreach (var project in deserializedFile.Projects)
            {
                List<Operation> operations = new List<Operation>();
                foreach (var operation in project.Operations)
                {
                    string opTypeStr = operation.OpType;
                    Operation op = new Operation((OperationType)Enum.Parse(typeof(OperationType), opTypeStr));
                    op.Text1 = Convert.ToString(operation.Text1);
                    op.Text2 = Convert.ToString(operation.Text2);
                    op.IsAfterConcat = operation.IsAfterConcat;

                    operations.Add(op);
                }

                Project projectData = new Project(
                    Convert.ToString(project.Title),
                    Convert.ToString(project.LastSaved),
                    operations,
                    Convert.ToString(project.InBox),
                    Convert.ToString(project.OutBox),
                    Convert.ToString(project.Prefix),
                    Convert.ToString(project.Infix),
                    Convert.ToString(project.Suffix)
                );
                projectData.ChosenDelimiterName = Convert.ToString(project.ChosenDelimiterName); // What if this is a non-existent preset?
                SavedProjectList.Instance.Add(projectData);
            }

            // Delimiters
            DelimiterPresetList.Instance.Clear();
            foreach (var delimiterPreset in deserializedFile.DelimiterPresets)
            {
                DelimiterPreset newPreset = new DelimiterPreset(
                    Convert.ToString(delimiterPreset.Title),
                    Convert.ToString(delimiterPreset.Prefix),
                    Convert.ToString(delimiterPreset.Infix),
                    Convert.ToString(delimiterPreset.Suffix)
                    );
                DelimiterPresetList.Instance.Add(newPreset);
            }

            return true;
        }
    }
}