namespace AutoConcat1_5.Data
{
    public class DelimiterPreset
    {
        public DelimiterPreset(string title, string prefix, string infix, string suffix)
        {
            Title = title;
            Prefix = prefix;
            Infix = infix;
            Suffix = suffix;
        }

        public string Title { get; set; }
        public string Prefix { get; set; }
        public string Infix { get; set; }
        public string Suffix { get; set; }
    }
}
