using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class women_walking : MonoBehaviour
{
    public GameObject next_point;
    public GameObject women;
    public AudioSource sound_walking;
    Animator animator;
    UnityStandardAssets.Characters.ThirdPerson.AI_Worker_Walking AI_Worker_Walking;
    // Start is called before the first frame update
    void Start()
    {
        animator = women.GetComponent<Animator>();
        AI_Worker_Walking = women.GetComponent<UnityStandardAssets.Characters.ThirdPerson.AI_Worker_Walking>();
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
            this.GetComponent<Collider>().isTrigger = true;
            women.SetActive(true);
            animator.SetBool("IsWalking", true);
            AI_Worker_Walking.isWalking = true;
            StartCoroutine(coroutine_next());
            StartCoroutine(coroutine_stopanimation());
            if (!sound_walking.isPlaying)
            {
                sound_walking.Play();
            }
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
        yield return new WaitForSeconds(15.5f);
        animator.SetBool("IsWalking", false);
        AI_Worker_Walking.isWalking = false;
        sound_walking.Stop();
    }
}
