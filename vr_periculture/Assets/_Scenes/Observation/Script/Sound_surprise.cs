using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_surprise : MonoBehaviour
{

    public AudioSource msg_surprise;
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
        if (other.gameObject.name == "Woman_FBX")
        {
            if (!msg_surprise.isPlaying)
            {
                msg_surprise.Play();
            }
           
        }
    }
}
