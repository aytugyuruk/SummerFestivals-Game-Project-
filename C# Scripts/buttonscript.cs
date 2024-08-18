using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonscrpit : MonoBehaviour
{
    public bool basti;
    void Start()
    {
        basti = false;
    }

   
    void Update()
    {
        if (basti)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    public void button()
    {
        basti = true;
    }
}
