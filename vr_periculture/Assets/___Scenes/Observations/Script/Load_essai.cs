using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Load_essai : MonoBehaviour
{
    AsyncOperation asyncLoad;
    public GameObject text_warning_fin_licence;
   // public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadYourAsyncScene());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Load_good_scene()

    {
        
        if (DateTime.Now > DateTime.Parse("2021-10-01"))
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            
            asyncLoad.allowSceneActivation = true;
        }
    }

    IEnumerator LoadYourAsyncScene()
    {
        

        asyncLoad = SceneManager.LoadSceneAsync(2);
        asyncLoad.allowSceneActivation = false;

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
