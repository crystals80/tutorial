using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionResponse : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

       if (collision.collider.gameObject == player) 
       {
            // Allow Player to kick the ball
            Vector3 force = this.transform.position - collision.collider.gameObject.transform.position;
            force = force * 50f;
            this.GetComponent<Rigidbody>().AddForce(force);
            // Make the ball bounces slightly and bounces away if hit Player
            // .f → float
            //this.GetComponent<Rigidbody>().AddForce(new Vector3(0,200.0f,0)); 
        }
    }
}
