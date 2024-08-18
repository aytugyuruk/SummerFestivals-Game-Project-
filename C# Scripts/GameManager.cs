using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        if (gordomovement.baslama)
        {
           groundmovement.baslayabilir = true; 
        }
    }
}
