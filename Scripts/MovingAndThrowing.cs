using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAndThrowing : MonoBehaviour
{
    public float speed = 10.0f;
    public float topBound = 30;
    public float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound)
        {
            Debug.Log("Game over!");
            Destroy(gameObject);
        }
    }
}
