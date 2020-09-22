using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end_game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Book_upon")
        {
            
            other.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
            //Debug.Log("GameOver!!!");
            //Application.Quit();
            SceneManager.LoadSceneAsync(6);
        }
    }
}
