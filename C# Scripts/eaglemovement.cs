using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eaglemovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public static float groundspeed = 1f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        groundspeed = 1f;
    }


    void Update()
    {
        if (gordomovement.baslama)
        {
            rb.velocity = new Vector3(-2000 * groundspeed, 0, 0);
        }
        
        if (gordomovement.yapabilir == false)
        {
            rb.velocity = new Vector3(0, 0, 0);

        }

    }
}
