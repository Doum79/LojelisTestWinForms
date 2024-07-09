using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp.Classes
{
    // Ecrivez la déclaration de la classe abstraite ScoreCalculatorBase 
    // TODO
    ScoreCalculatorBase
    {
        public static string path = Path.Combine(Application.StartupPath, "Datas");

        // Ecrivez la déclaration de la méthode -privée- LoadScore, qui une retourne une liste de type PlayerGamePointsStored, et prend en paramètre la chaine fileName
        // TODO
        LoadScore()
        {
            ScoreSerializer scoreSerializer = new ScoreSerializer();
            List<PlayerGamePointsStored> playersGamePointsStored = scoreSerializer.Deserialize(fileName);
            return playersGamePointsStored;
        }

        // déclarez la métode -abstraite- DoCalculate qui prend en paramètre la liste List<PlayerGamePointsStored> playersGamePointsStored.
        // Cette méthode a une visibilité limitée à cette classe et aux dérivés
        // TODO
        DoCalculate()

        public IEnumerable<ScoreResult> Calculate(string fileName)
        {
            List<PlayerGamePointsStored> playersGamePointsStored = LoadScore(fileName);
            DoCalculate(playersGamePointsStored);
            IEnumerable<ScoreResult> scoreResults =
                // écrivez la requête linq qui retourne un IEnumerable<ScoreResult> extrait à partir de playersGamePointsStored. Renseignez le Name et FinalScore des ScoreResult. Cette liste doit être triée par score final descendant
                // TODO

            return scoreResults;
        }
    }
}
