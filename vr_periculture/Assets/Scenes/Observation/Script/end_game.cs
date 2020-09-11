using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (other.gameObject.name == "one_upon")
        {
            other.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            Application.Quit();
        }
    }
}
