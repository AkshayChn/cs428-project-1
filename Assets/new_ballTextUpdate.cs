using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class new_ballTextUpdate : MonoBehaviour
{
    public GameObject Magic8Text;
    public AudioSource audioSource;
    public float volume=0.5f;
    
    int upsideDown = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Magic8Text.GetComponent<TextMeshPro>().text = "Hello";
        if (Vector3.Dot(Magic8Text.transform.up, Vector3.down) > 0) {
            upsideDown = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Magic8Text.GetComponent<TextMeshPro>().text = "Hello";
        //updateText();
        //if flipped updateTest();
        //if (Vector3.Dot(Magic8Text.transform.up, Vector3.down) > 0)
        
        //Magic8Text.GetComponent<TextMeshPro>().text = Vector3.Dot(Magic8Text.transform.up, Vector3.down).ToString();
        if (Vector3.Dot(Magic8Text.transform.up, Vector3.down) > 0) {
            //updateText();
            upsideDown = 1;
        }
        
        if ((Vector3.Dot(Magic8Text.transform.up, Vector3.down) < 0) & upsideDown == 1){
            //updateText();
            upsideDown = 0;
            updateText();
            audioSource.PlayOneShot(audioSource.clip, volume);
        }
    }
    
    void updateText(){
        string[] sayings = new string[] {
                                            "Yesssss!!",
                                            "Absolutely!!",
                                            "I'm Sure of it!",
                                            "I'ts bound to be so!",
                                            "Sure!",
                                            
                                            "Neutral Answer, Try again.",
                                            "lol idk",
                                            "Are you really asking a cube?",
                                            "How can I know?",
                                            "Go Away",


                                            "Lol no",
                                            "Never",
                                            "Absolutely not",
                                            "Heh, you really think so?",
                                            "Impossible"

                                        };
        Random rnd = new Random();
        //int index = rnd.Next(sayings.Length);
        //int index = Random.Range(0, sayings.Length);
        int index = Random.Range(0, sayings.Length);
        Magic8Text.GetComponent<TextMeshPro>().text = sayings[index];
    }
}
