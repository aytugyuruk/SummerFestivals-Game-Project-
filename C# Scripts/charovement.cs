using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gordomovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public static bool zipla1, zipla2, restart1,baslama,oke,yapabilir;
    public Animator anim;
    public float jumpamount;
    public GameObject gordo, restart,fade,text,text1,baslamabutton,siyah,finalfade;
    
    

    void Start()
    {
      rb= GetComponent<Rigidbody2D>();  
      anim= GetComponent<Animator>();
      yapabilir = true;
      zipla2 = false;
      restart1 = false;
      oke = false;
      baslamabutton.SetActive(true);
      baslama = false;
      StartCoroutine(bekleme3());
      Application.targetFrameRate = 60;
      
    }
    void Update()
    {
    
        if (zipla1)
        {
            if (zipla2)
            {
                if (yapabilir)
                {
                    rb.velocity = new Vector2(0, 1500 * jumpamount*Time.timeScale);
                    
                }        
            }
        }
        if (restart1)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (baslama)
        {
            
            baslamabutton.SetActive(false);
            anim.SetBool("basladi", true);
            if (oke)
            {
                anim.SetBool("basladi", false);

            }
            
        }
    }
  
    public void zipla()
    {
        zipla1 = true;
    }
    public void baslamabuton()
    {
        baslama = true;
    }
    public void ziplabirak()
    {
        zipla1 = false;
    }
    public void restartfonksiyonu()
    {
        restart1 = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "engel")
        {
           
            anim.SetBool("degdi", true);
            oke = true;
            scorepoint.devam =false;


            yapabilir = false;
            restart.SetActive(true);
            
        }
        if (collision.gameObject.name == "SpeedCheck")
        {
            groundmovement.groundspeed=1.15f;
            
            fade.SetActive(true);
            StartCoroutine(bekleme());
            StartCoroutine(bekleme1());

        }
        if (collision.gameObject.name == "SpeedCheck1")
        {
            groundmovement.groundspeed = 1.4f;
       
            fade.SetActive(true);
            StartCoroutine(bekleme());
            StartCoroutine(bekleme1());

        }
        if (collision.gameObject.name == "bitis")
        {
            scorepoint.bitmedi = false;
            finalfade.SetActive(true);
            StartCoroutine(bekleme22());





        }
        if (collision.gameObject.name == "SpeedCheck2")
        {
            groundmovement.groundspeed = 1.6f;
         
            fade.SetActive(true);
            StartCoroutine(bekleme2());
            StartCoroutine(bekleme1());

        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Yer")
        {
            zipla2 = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Yer")
        {
            zipla2 = false;
        }
    }
    IEnumerator bekleme()
    {
        yield return new WaitForSeconds(1.3f);
        text.SetActive(true);

    }
    IEnumerator bekleme22()
    {
        yield return new WaitForSeconds(1.7f);
        SceneManager.LoadScene("tebrikler");

    }
    IEnumerator bekleme2()
    {
        yield return new WaitForSeconds(1.3f);
        text1.SetActive(true);

    }
    IEnumerator bekleme1()
    {
        yield return new WaitForSeconds(5.5f);
        text.SetActive(false);
        fade.SetActive(false);
        text1.SetActive(false);

    }
    IEnumerator bekleme3()
    {
        yield return new WaitForSeconds(2f);
        Destroy(siyah);

    }
   




}
