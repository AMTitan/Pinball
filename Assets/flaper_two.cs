using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flaper_two : MonoBehaviour
{
    public float speed;
    private float max = 0.8001032f;
    private float min = 0.4619398f;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.rotation.y);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.rotation.y < max)
            {
                transform.Rotate(Vector3.up * speed * Time.deltaTime);
            }
        }
        else
        {
            if (transform.rotation.y > min)
            {
                transform.Rotate(Vector3.down * speed * Time.deltaTime);
            }
        }
    }
}
