using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoMaisonPrefab : MonoBehaviour
{
  
    public int benefice;
    public int _niveau;
    public int _niveauTemp;

    public float _benefparsec;
    public string _nom;
    // Start is called before the first frame update
    void Start()
    {//init valeurs
        _niveau = 1;
        _niveauTemp=0;
        benefice=1;
        _nom="Maison";

    }

    // Update is called once per frame
    void Update()
    {
        
        benefParSec();
        if (_niveauTemp!=_niveau)
        {
        ModificationBenefice();
        ModificationBeneficeParent();
        _niveauTemp=_niveau;
        }
        
        
    }
    
    public void ModificationBenefice()
    //fonction lance apres chaque upgrade

    {
        benefice=_niveau*2;
    }
    public void ModificationBeneficeParent()
    //fonction lance apres chaque upgrade
    {
        MaisonBat _maison = GetComponentInParent<MaisonBat>();
        _maison._beneficeMaison=_maison._beneficeMaison+2;//0.2 ressource par secondes en plus par niveau (2 toutes les 10 sec)

    }
  void benefParSec()
    {
        _benefparsec = benefice / 10f;
    }


}