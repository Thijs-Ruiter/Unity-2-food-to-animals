using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xrange = 15;
    public float cooldown = 2;
    private float timeStamp = 0;
    private float currentCooldown;
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (transform.position.x < -xrange)
        {
            transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xrange)
        {
            transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space) && timeStamp <= Time.time)
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            timeStamp = Time.time + cooldown;
        }
    }
}
