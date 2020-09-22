using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poster_observation : MonoBehaviour
{
    public GameObject next_point;
   
    // Start is called before the first frame update
    void Start()
    {

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
            this.GetComponent<Collider>().isTrigger =true;
            StartCoroutine(coroutine_next());
        }
    }
    IEnumerator coroutine_next()
    {
        Debug.Log("coroutine  B created");
        yield return new WaitForSeconds(5f);
        next_point.SetActive(true);
    }
}
