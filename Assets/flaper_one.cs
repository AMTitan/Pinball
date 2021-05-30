using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flaper_one : MonoBehaviour
{

    public float speed;
    private float max = -0.8001032f;
    private float min = -0.4619398f;
    public float ballSpeed = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.rotation.y > max)
            {
                transform.Rotate(Vector3.down * speed * Time.deltaTime);
            }
        }
        else
        {
            if (transform.rotation.y < min)
            {
                transform.Rotate(Vector3.up * speed * Time.deltaTime);
            }
        }
    }
    
    
    private void OnCollisionEnter(Collision other)
    {
        if (Input.GetKey(KeyCode.RightArrow) && transform.rotation.y > max && transform.rotation.y < min && other.gameObject.name == "ball")
        {
            Vector3 vel = other.rigidbody.velocity;
            vel.z = ballSpeed * -1;
            other.rigidbody.velocity = vel;
        }
    }
    
    private void OnCollisionStay(Collision other)
    {
        if (Input.GetKey(KeyCode.RightArrow) && transform.rotation.y < max && transform.rotation.y > min && other.gameObject.name == "ball")
        {
            Vector3 vel = other.rigidbody.velocity;
            vel.z = ballSpeed * -1;
            other.rigidbody.velocity = vel;
        }
    }
}
