using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chargement : MonoBehaviour
{
    public GameObject ecran_chargement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Afficher_ecran_chargement()
    {
        ecran_chargement.SetActive(true);
    }
}
