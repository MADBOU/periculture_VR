using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class put_it_right_again : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.localEulerAngles.x !=0 || this.transform.localEulerAngles.x != 0)
        {

            this.transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);
            Debug.Log("corrrrrrrrrrrrrrecting ");
        }
    }
}
