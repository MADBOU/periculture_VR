using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_point : MonoBehaviour
{
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
            this.GetComponent<Collider>().isTrigger = true;
            if (!instruction_fin.isPlaying)
            {
                instruction_fin.Play();
            }
           
        }
    }
}
