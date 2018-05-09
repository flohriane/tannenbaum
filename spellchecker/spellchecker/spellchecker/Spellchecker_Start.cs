﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace spellchecker
{
    public class Spellchecker_Start
    {
        public static string[] Text_in_Wörter_zerlegen(string text)
        {
            var prüfwörter = text.Split(new [] {'.', ',', ';', '!', '?', ' ', '\t', '\n', '\r', '\b', '\v'}, StringSplitOptions.RemoveEmptyEntries);

            return prüfwörter;
        }

        public static List<string> Wörter_auf_Fehler_überprüfen(string[] wörter, string[] prüfwörter)
        {
            var fehlerliste = new List<string>();

            // einfachere Lösung mit Lambdafunktionen ???

            foreach (string pw in prüfwörter)
            {
                var zähler = 0;
                foreach (string w in wörter)
                {
                    if (w != pw)
                    {
                        zähler++;
                    }
                }

                if (zähler == wörter.Count()) // kein gleiches Wort gefunden
                {
                    fehlerliste.Add(pw);
                }
            }
            return fehlerliste;
        }
    }
}