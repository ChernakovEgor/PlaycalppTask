using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{

    public float velocity = 0.1f;
    public float distanceToFly = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > distanceToFly) {
            Object.Destroy(this.gameObject);
        }

        transform.position += new Vector3(velocity, 0, 0);
    }
}
