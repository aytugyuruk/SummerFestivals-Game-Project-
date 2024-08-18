using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anamenuscript : MonoBehaviour
{
    
    public Animator anim;
    
    void Start()
    {
        anim.SetBool("basladi", true);
        
        Application.targetFrameRate = 60;
    }

    
   
   
}
