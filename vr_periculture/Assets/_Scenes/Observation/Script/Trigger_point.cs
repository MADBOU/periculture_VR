using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger_point : MonoBehaviour
{
     AsyncOperation asyncLoaddd;
    // Start is called before the first frame update
    public AudioSource instruction_fin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.name == "PlayerController")
        {
            StartCoroutine(LoadYourAsyncScene());
            this.GetComponent<Collider>().isTrigger = true;
            if (!instruction_fin.isPlaying)
            {
                instruction_fin.Play();
            }
           
        }
    }


    IEnumerator LoadYourAsyncScene()
    {


        asyncLoaddd = SceneManager.LoadSceneAsync(6);
        asyncLoaddd.allowSceneActivation = false;

        while (!asyncLoaddd.isDone)
        {
            yield return null;
        }
    }

    public void allow_load()
    {
        asyncLoaddd.allowSceneActivation = true;
    }

}
