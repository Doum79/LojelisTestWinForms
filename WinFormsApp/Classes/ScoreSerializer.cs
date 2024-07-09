using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace WinFormsApp.Classes
{
    public class ScoreSerializer
    {
        public static void CreateSamples()
        {
            ScoreSerializer scoreSerializer = new ScoreSerializer();

            List<PlayerGamePointsStored> playersGamePointsStored = new List<PlayerGamePointsStored> {
                new PlayerGamePointsStored { Name = "Guenièvre", GamePoints = new Int16[] { 1, 2, 3, 4, 5 } },
                new PlayerGamePointsStored { Name = "Perceval", GamePoints = new Int16[] { 25, 15, 35 } },
                new PlayerGamePointsStored { Name = "Arthur", GamePoints = new Int16[] { 8, 8 }},
                new PlayerGamePointsStored { Name = "Merlin", GamePoints = new Int16[] { 23, 12, 8, 6, 9 } }
            };
            scoreSerializer.Serialize(playersGamePointsStored, "Scores_1.json");
        }

        public void Serialize(List<PlayerGamePointsStored> playersGamePointsStored, string name)
        {
            string fileName = Path.Combine(ScoreCalculatorBase.path, name);
            if (File.Exists(fileName))
                File.Delete(fileName);
            using FileStream createStream = File.Create(fileName);
            {
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { WriteIndented = true };
                //string s = JsonSerializer.Serialize<List<ScoreStored>>(scores);
                JsonSerializer.SerializeAsync<List<PlayerGamePointsStored>>(createStream, playersGamePointsStored, jsonSerializerOptions).Wait();
                createStream.Flush();
                createStream.Close();
            }
        }

        public List<PlayerGamePointsStored> Deserialize(string fileName)
        {
            List<PlayerGamePointsStored> playersGamePointsStored;
            using FileStream stream = File.OpenRead(fileName);
            {
                playersGamePointsStored = JsonSerializer.DeserializeAsync<List<PlayerGamePointsStored>>(stream).Result;
                stream.Close();
            }
            return playersGamePointsStored;
        }
    }
}
