using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI1 : MonoBehaviour
{
    public GameObject player;
    public bool aggro = false;
    public float speed;
    public float thrust;

    //enemy rb
    public Rigidbody rb;
    public float rotationSpd;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Behavior();
    }

    void Chase()
    {
        //look at player
        Vector3 targetDirection = player.transform.position - transform.position;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, speed*Time.deltaTime, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);

        rb.AddRelativeForce(Vector3.forward * Mathf.Clamp(targetDirection.magnitude-30,0f,1f) * thrust);
        if (Vector3.Distance(transform.position, player.transform.position) <= 20f)
        {
            Attack();
        }
    }
    
    void Attack()
    {



    }

    void Patrol()
    {

    }

    void Behavior()
    {
        
        if (Vector3.Distance(transform.position, player.transform.position) <= 50f)
        {
            aggro = true;
        }
        else
        {
            aggro = false;
        }

        if (aggro)
        {
            Chase();
        }
        if (!aggro)
        {
            Patrol();
        }

    }
}