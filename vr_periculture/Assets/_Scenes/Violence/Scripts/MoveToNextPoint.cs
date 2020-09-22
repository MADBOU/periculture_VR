using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToNextPoint : MonoBehaviour
{
    public GameObject next_point;
    public int risksToComplete;
    private int counter;
    private void Start()
    {
        counter = 0;
        Debug.Log("Start MoveToNextPoint");
        Debug.Log("Counter in Start : " + counter);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PlayerController")
        {
            this.gameObject.GetComponent<CapsuleCollider>().isTrigger = true;
        }
    }
    //IEnumerator Coroutine_next()
    //{
    //    yield return new WaitForSeconds(5f);
    //    next_point.SetActive(true);
    //}

    public void CheckAndActivateNextCheckPoint()
    {
        counter++;
        Debug.Log("Counter: " + counter);
        if(risksToComplete == counter)
        {
            this.gameObject.SetActive(false);
            next_point.SetActive(true);
            //counter = 0;
            Debug.Log("CheckPoint name: " +next_point.gameObject.name);
            Debug.Log("CheckPoint Activated: ");
        }
    }
}
