using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToNextPoint : MonoBehaviour
{
    public GameObject next_point;
    private void Start()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PlayerController")
        {

            StartCoroutine(Coroutine_next());

        }
    }
    IEnumerator Coroutine_next()
    {
        Debug.Log("coroutine  women created");
        yield return new WaitForSeconds(5f);
        next_point.SetActive(true);
    }
}
