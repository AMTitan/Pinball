using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class shoot : MonoBehaviour
{

    private bool canRun = true;
    private float times;
    public float speed = 5;
    public float time = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && canRun == true)
        {
            canRun = false;
            times = Time.time + time;
        }

        if (!canRun && times > Time.time)
        {
            transform.position += transform.forward * speed * Time.deltaTime * -1;
        }
    }
}
