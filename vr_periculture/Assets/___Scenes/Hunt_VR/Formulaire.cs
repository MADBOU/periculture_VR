using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Formulaire : MonoBehaviour
{
   // Text prenon;
    //Text nom;
    public TextMeshProUGUI prenon_vr;
    public TextMeshProUGUI nom_vr;
    GameObject error_popup;
    bool champ_obli = false;
    Add_user add_nom;
    AsyncOperation asyncLoad;
    
    
    // Start is called before the first frame update

    void Start()
    {
       
        //prenon = GameObject.Find("Prenom/Text").GetComponent<Text>();
       // nom = GameObject.Find("Nom/Text").GetComponent<Text>();
        error_popup = GameObject.Find("error_popup");
        error_popup.SetActive(false);
        add_nom = GameObject.FindObjectOfType<Add_user>();
        StartCoroutine(LoadYourAsyncScene());
    }


    void Champ_obligatoire(TextMeshProUGUI text)
    {

        //text.color = Color.red; 
        // Debug.Log(text.transform.parent.name + "/Placeholder");
        text.color = Color.red;
        GameObject.Find(text.transform.parent.name + "/Placeholder_vr").GetComponent<TextMeshProUGUI>().color = Color.red;
        error_popup.SetActive(true);

    }
    public void save_user()
    {
        if (prenon_vr.text == "")
        {
            Champ_obligatoire(prenon_vr);
           
        }
        if (nom_vr.text == "")
        {
            Champ_obligatoire(nom_vr);
            
        }
        if (nom_vr.text != "" && nom_vr.text != "")
        {
            champ_obli = true;
            Debug.Log("333333333");//champ_vide();
        }
        if (champ_obli)
        {
            Debug.Log("nom est " + nom_vr.text.ToString());
            Debug.Log("Prenom est " + prenon_vr.text);
            add_nom.prenom_s = prenon_vr.text;
            add_nom.nom_s = nom_vr.text;
            
            asyncLoad.allowSceneActivation = true;
           
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator LoadYourAsyncScene()
    {


        asyncLoad = SceneManager.LoadSceneAsync(3);
        asyncLoad.allowSceneActivation = false;

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

   


}
