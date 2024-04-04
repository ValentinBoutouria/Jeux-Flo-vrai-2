using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compteur : MonoBehaviour
{
    private float timer = 0f; // Timer pour suivre le temps écoulé
    public int counterSpawnRessources = 0; // Compteur à incrémenter
    public int counterAjoutFerme = 0; // Compteur à incrémenter
    public int counterAjoutChateau = 0; // Compteur à incrémenter
    public int counterAjoutMaison = 0; // Compteur à incrémenter


    void Update()
    {
        // Ajouter le temps écoulé depuis la dernière frame au timer
        timer += Time.deltaTime;

        // Si une seconde est écoulée, incrémenter le compteur et réinitialiser le timer
        if (timer >= 1f)
        {
            counterSpawnRessources++;
            counterAjoutMaison--;
            counterAjoutChateau--;
            counterAjoutFerme--;
            //Debug.Log("Compteur : " + counter);
            timer = 0f;
        }
    }
    
}
