using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot2 : MonoBehaviour
{
    private bool canRun = true;
    public Rigidbody rb;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && canRun == true)
        {
            canRun = false;
            Vector3 vel = rb.velocity;
            vel.z = speed * -1;
            rb.velocity = vel;
        }
    }
}
