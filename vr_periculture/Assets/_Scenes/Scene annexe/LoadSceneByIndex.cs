using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneByIndex : MonoBehaviour
{
    public void LoadScene(int sceneIndex)
    {
        StartCoroutine(LoadAscynchrnously(sceneIndex));
    }
   
    IEnumerator LoadAscynchrnously(int sceneIndex)
    {
        SceneManager.LoadSceneAsync(sceneIndex);
         yield return null;

    }
}
