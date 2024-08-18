using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haraketmovement : MonoBehaviour
{
    public Rigidbody2D rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-4, 0);
    }
}
