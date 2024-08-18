using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundmovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public static float groundspeed = 1f;
    public static bool baslayabilir;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        groundspeed = 1f;
        baslayabilir = false;
    }

   
    void Update()
    {
        if (baslayabilir)
        {
            rb.velocity = new Vector3(-900 * groundspeed, 0, 0);
        }
       
        if (gordomovement.yapabilir==false)
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
