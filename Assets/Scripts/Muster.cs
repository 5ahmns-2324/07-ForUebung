using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muster : MonoBehaviour
{
       int zeilenAnzahl = 3;

    void Start()
    {
        for (int zeile = 1; zeile <= zeilenAnzahl; zeile++)
        {
            string ausgabe = GeneriereMusterZeile(zeile, zeilenAnzahl);
            Debug.Log(ausgabe);
        }
    }

    private string GeneriereMusterZeile(int aktuelleZeile, int gesamtZeilenAnzahl)
    {
        string ausgabe = "";

        // Minus vor Sternen
        for (int minus = 1; minus <= gesamtZeilenAnzahl - aktuelleZeile; minus++)
        {
            ausgabe += "-";
        }

        // Sterne
        for (int sterne = 1; sterne <= 2 * aktuelleZeile - 1; sterne++)
        {
            ausgabe += "*";
        }

        // Minus nach Sternen
        for (int minus = 1; minus <= gesamtZeilenAnzahl - aktuelleZeile; minus++)
        {
            ausgabe += "-";
        }

        return ausgabe;
    }

}
