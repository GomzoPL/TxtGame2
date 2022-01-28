using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    
   AudioSource audio;
    public void Start() {
        audio=GetComponent<AudioSource>();
    }
    public void Click()
    {
        audio.Play();
        SceneManager.LoadScene(1);
        
    }
    
        
   
}
