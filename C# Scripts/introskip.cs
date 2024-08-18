using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introgecis : MonoBehaviour
{
    public GameObject siyah;
    void Start()
    {
        StartCoroutine(bekleme());
        StartCoroutine(bekleme1());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(4f);
        siyah.SetActive(true);

    }
    IEnumerator bekleme1()
    {
        yield return new WaitForSeconds(4.5f);
        SceneManager.LoadScene("anamenu");

    }
}
