using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    public string startMessage;
    public string updatemessage;

    public string message1;
    public string message2;
    public string message3;
    public string message4;
    public string message5;

    public int messagechoice;

    public string[] messages;

    // Start is called before the first frame update
    
    void Start()
    {
        /*
        //Debug.Log(startMessage);//

        //messagechoice = Random.Range(1, 6);//
        
        if (messagechoice == 1)
        {
            Debug.Log(messages[0]);
        }
        else if (messagechoice == 2)
        {
            Debug.Log(messages[1]);
        }
        else if (messagechoice == 3)
        {
            Debug.Log(messages[2]);
        }
        
        else
        {
            Debug.Log("invalid message choice");
        }
        */
        if (messagechoice <= messages.Length - 1 && messagechoice >= 0)
        {
            Debug.Log(messages[messagechoice]);
        }
        else
        {
            Debug.Log("invalid message choice");
        }
        
    }
        
    // Update is called once per frame//

    

    void Update()
    {
        Debug.Log(updatemessage);
    }
}

    

