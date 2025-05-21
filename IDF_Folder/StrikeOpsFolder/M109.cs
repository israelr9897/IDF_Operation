using IDF_Operation.IDF_Folder.StrikeOpsFolder.strike_ops;


namespace IDF_Operation.IDF_Folder.StrikeOpsFolder.m109
{
     internal class M109 : StrikeOptions
    {
        public M109(
            string name,
            Dictionary<string, int> ammunitionAmount,
            int fuelSupply,
            string typeTarget) : base(
                "M109",
                new Dictionary<string, int>
                {
                    { "shell", 40 }
                },
                fuelSupply,
                "open areas")
        { }
    }
}