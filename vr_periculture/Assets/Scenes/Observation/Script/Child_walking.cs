using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child_walking : MonoBehaviour
{
    public GameObject next_point;
    public GameObject child;
    Animator animator;
    UnityStandardAssets.Characters.ThirdPerson.AI_Worker_Walking AI_Worker_Walking;
    // Start is called before the first frame update
    void Start()
    {
        animator = child.GetComponent<Animator>();
        AI_Worker_Walking = child.GetComponent<UnityStandardAssets.Characters.ThirdPerson.AI_Worker_Walking>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "PlayerController")
        {
            child.SetActive(true);
            animator.SetBool("IsWalking", true);
            AI_Worker_Walking.isWalking = true;
            StartCoroutine(coroutine_next());
            //StartCoroutine(coroutine_stopanimation());
        }
    }
    IEnumerator coroutine_next()
    {
        Debug.Log("coroutine  women created");
        yield return new WaitForSeconds(5f);
        next_point.SetActive(true);
    }
    IEnumerator coroutine_stopanimation()
    {
        Debug.Log("coroutine  stop created");
        yield return new WaitForSeconds(10f);
        animator.SetBool("IsWalking", false);
        AI_Worker_Walking.isWalking = false;
    }
}
