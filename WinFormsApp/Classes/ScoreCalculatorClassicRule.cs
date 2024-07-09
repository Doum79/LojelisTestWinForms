using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WinFormsApp.Classes
{
    // Ecrivez la déclaration de la classe ScoreCalculatorClassicRule qui dérive de ScoreCalculatorBase 
    // TODO
   public  class ScoreCalculatorClassicRule : ScoreCalculatorBase
    {
        // déclarez la surcharge de la métode abstraite DoCalculate déclarée dans ScoreCalculatorBase
        // TODO
        protected override void DoCalculate(List<PlayerGamePointsStored> playersGamePointsStored)
        {
            // calculer le score final de chaque joueur, à partir de ses points de parties (scoreStored.GamePoints), et stockez le dans chaque scoreStored.FinalScore

            // régle de calcul du score final avec la règle classique :
            // ajouter 1 au score final pour chaque résultat de partie pair 
            // ajouter 3 au score final pour chaque résultat de partie impair 
            // ajouter 5 au score final pour chaque résultat de partie égal à 8 
            // pour déterminer si un chiffre est pair : points % 2 == 0

            // si vous connaissez Parallel, n'hésitez pas à l'utiliser avec une lambda pour calculer en parallèle le score final de chaque joueur ;)
            // TODO

            Parallel.ForEach(playersGamePointsStored, scoreStored =>
            {
                int finalScore = 0;

                foreach (var gamePoints in scoreStored.GamePoints)
                {
                    if (gamePoints == 8)
                    {
                        finalScore += 5;
                    }
                    else if (gamePoints % 2 == 0)
                    {
                        finalScore += 1;
                    }
                    else
                    {
                        finalScore += 3;
                    }
                }

                scoreStored.FinalScore = (Int16)finalScore;
            });

        }
    }
}
