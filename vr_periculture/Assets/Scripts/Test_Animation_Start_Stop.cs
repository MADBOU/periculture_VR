using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Animation_Start_Stop : MonoBehaviour
{
    public GameObject test_gameObject;
    Animator animator;
    UnityStandardAssets.Characters.ThirdPerson.AI_Worker_Walking AI_Worker_Walking;
    void Start()
    {
        animator = test_gameObject.GetComponent<Animator>();
        AI_Worker_Walking = test_gameObject.GetComponent<UnityStandardAssets.Characters.ThirdPerson.AI_Worker_Walking>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            // Turn the Humanoid

            // Once Turned now Walk
            animator.SetBool("IsWalking", true);
            AI_Worker_Walking.isWalking = true;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            animator.SetBool("IsWalking", false);
            AI_Worker_Walking.isWalking = false;
        }
    }
}
