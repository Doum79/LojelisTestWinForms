using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WinFormsApp.Classes
{
    // Ecrivez la déclaration de la classe ScoreCalculatorAquitaineRule qui dérive de ScoreCalculatorBase 
    // TODO
  public  class ScoreCalculatorAquitaineRule : ScoreCalculatorBase
    {
        // déclarez la surcharge de la métode abstraite DoCalculate déclarée dans ScoreCalculatorBase
        // TODO
        protected override void DoCalculate(List<PlayerGamePointsStored> playersGamePointsStored)
        {
            // calculer le score final de chaque joueur, à partir de ses points de parties (playerScoreStored.GamePoints), et stockez le dans chaque playerScoreStored.FinalScore

            // régle de calcul du score final avec la règle à l'Aquitaine :
            // totalisez les points de chaque partie, divisez ce chiffre par 2, arrondi à l'entier supérieur

            // si vous connaissez Parallel, n'hésitez pas à l'utiliser pour calculer en parallèle le score final de chaque joueur ;)
            // TODO

            Parallel.ForEach(playersGamePointsStored, playerScoreStored =>
            {
                int totalPoints = playerScoreStored.GamePoints.Select(p => (int)p).Sum();  // Convertir en int et totaliser les points de chaque partie
                int finalScore = (int)Math.Ceiling(totalPoints / 2.0);  // Diviser par 2 et arrondir à l'entier supérieur

                // Conversion explicite de int 
                playerScoreStored.FinalScore = (Int16)finalScore;
            });
        }
    }
    
}
