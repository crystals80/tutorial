using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour
{

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        this.GetComponent<Transform>().LookAt(target.transform);
        // or this.GetComponent<Transform>().LookAt(target.GetComponent<Transform>())

        // this. is optional, you can just write transform right away
        this.transform.Translate(new Vector3(0,0,0.01f), Space.Self);
    }
}
