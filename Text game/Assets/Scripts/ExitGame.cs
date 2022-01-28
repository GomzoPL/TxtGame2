using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{

AudioSource audio;
    // Update is called once per frame
    private void Start() {
        audio=GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
            
        }
    }
    public void Click()
    {
        audio.Play();
        Application.Quit();
        
    }
}
