using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maison : MonoBehaviour
{

    public int _prix;
    public AjoutPoint _ajoutPoint;
    public GameObject _validationUI;
    public GameObject InstantiateMaison; // R�f�rence vers le prefab de l'objet � instancier

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    public void CliqueMaison()
    {
        _ajoutPoint.scoreSelect = _ajoutPoint.scoreSelect - (_prix * _ajoutPoint.scoreSelect);//retire le prix pour placer un Maison sur chaque hexagone selectionn�
        _validationUI.SetActive(true);
        InstantiateMaison.gameObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);//changement du scale de la maison
        GameObject Maison = Instantiate(InstantiateMaison, Vector3.zero + new Vector3(0f, 0.2f,0f), Quaternion.identity) ;//a changer



    }
}
