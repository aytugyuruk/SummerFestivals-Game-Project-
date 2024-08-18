using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tebriklersrcipt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(bekleme());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(5.1f);
        SceneManager.LoadScene("anamenu");

    }
}
