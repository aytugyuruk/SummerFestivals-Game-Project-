using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorepoint : MonoBehaviour
{
    public Text scoretext;
    public float scoreamount, pointincreasedpersecond;
    public static bool devam, bitmedi;

    void Start()
    {
        scoreamount = 0f;
        pointincreasedpersecond = 1.7f;
        devam = true;
        bitmedi = true;
    }

    void Update()
    {
        if (gordomovement.baslama)
        {
            if (devam)
            {
                if (bitmedi)
                {
                    scoretext.text = (int)scoreamount + " %";
                    scoreamount += pointincreasedpersecond * Time.deltaTime;
                }
            }
        } 
    }
}
