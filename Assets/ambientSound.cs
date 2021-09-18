using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ambientSound : MonoBehaviour
{
    
    public AudioSource ambient;
    public AudioSource chatter;
    
    // Start is called before the first frame update
    void Start()
    {
        ambient.Play();
        chatter.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
