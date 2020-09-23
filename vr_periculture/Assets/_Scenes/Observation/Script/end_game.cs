using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end_game : MonoBehaviour
{
    Trigger_point trigger;
    // Start is called before the first frame update
    private void Awake()
    {
        trigger = GameObject.FindObjectOfType<Trigger_point>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.name == "Book_upon")
        {
            trigger.allow_load();
            other.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
            //Debug.Log("GameOver!!!");
            //Application.Quit();
            //SceneManager.LoadSceneAsync(6);
            
        }
    }
}
