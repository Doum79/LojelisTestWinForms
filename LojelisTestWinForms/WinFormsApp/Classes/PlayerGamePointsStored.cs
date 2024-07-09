using System;
using System.Text.Json.Serialization;

namespace WinFormsApp.Classes
{
    public class PlayerGamePointsStored
    {
        public string Name { get; set; }
        public Int16[] GamePoints { get; set; }
        [JsonIgnore]
        public Int16 FinalScore { get; set; }
    }
}
