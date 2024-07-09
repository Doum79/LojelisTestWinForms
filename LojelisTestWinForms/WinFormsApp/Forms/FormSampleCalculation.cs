﻿using System.Collections.Generic;
using System.IO;
using WinFormsApp.Classes;

namespace WinFormsApp.Forms
{
    public class FormSampleCalculation
    {
        public static void CalculateSample(out string aquitaineRuleText, out string classicRuleText)
        {
            string fileName = Path.Combine(ScoreCalculatorBase.path, "Scores_1.json");

            // Calculez les scores finaux pour les 2 régles de calcul, à partir du fichier fileName déclaré kuste au dessus (le fichier existe)
            // Ensuite formatez le résultat en text en appelant la méthode FormatResult ci-aprés
            // stockez les résultats dans les strings aquitaineRuleText et classicRuleText, pour qu'ils soient affichés dans la fénêtre principale

            // TODO

        }

        private static string FormatResult(IEnumerable<ScoreResult> scoreResults)
        {
            string text = "";
            foreach (var item in scoreResults)
            {
                text += $"{item.Name} {item.FinalScore}\n";
            }
            return text;
        }
    }
}
