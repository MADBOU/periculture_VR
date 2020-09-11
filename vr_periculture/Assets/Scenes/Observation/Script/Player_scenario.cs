using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_scenario : MonoBehaviour
{
    public GameObject[] teleport_point;
    // Start is called before the first frame update
    void Start()
    {
        for ( int i=1;i< teleport_point.Length;i++)
        {
            teleport_point[i].SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
