using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballDestruct : MonoBehaviour
{
    //attach script to the ball GameObject prefab 

    public GameObject effect0;
    void Start()
    {
        StartCoroutine(SelfDestruct());
    }
    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(15f);
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider co)
    {
        explode();
    }

    void explode()
    {
        Debug.Log("Boom!");
        GameObject plasma0;
        plasma0 = Instantiate(effect0, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
