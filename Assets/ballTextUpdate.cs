using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ballTextUpdate : MonoBehaviour
{
    public GameObject Magic8Text;
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
        }
    }
    
    void updateText(){
        string[] sayings = new string[] {
                                            "It is Certain",
                                            "It is decidedly so",
                                            "Without a doubt",
                                            "Yes definitely",
                                            "You may rely on it",
                                            "As I see it, yes.",
                                            "Most likely",
                                            "Outlook good",
                                            "Yes",
                                            "Signs point to yes",


                                            "Reply hazy, try again",
                                            "Ask again later",
                                            "Better not tell you now",
                                            "Cannot predict now",
                                            "Concentrate and ask again",


                                            "Don't count on it",
                                            "My reply is no",
                                            "My sources say no",
                                            "Outlook not so good",
                                            "Very doubtful"

                                        };
        Random rnd = new Random();
        //int index = rnd.Next(sayings.Length);
        //int index = Random.Range(0, sayings.Length);
        int index = Random.Range(0, sayings.Length);
        Magic8Text.GetComponent<TextMeshPro>().text = sayings[index];
    }
}
