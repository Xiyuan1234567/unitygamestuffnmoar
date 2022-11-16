using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject effect;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            spawnBall();
        }   
    }

    public void spawnBall()
    {
        GameObject ball;
        ball = Instantiate(effect, transform.position, Quaternion.identity);

        ball.GetComponent<Rigidbody>().AddRelativeForce(transform.forward*20f, ForceMode.Impulse);
    }
}
