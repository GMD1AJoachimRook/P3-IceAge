using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConversationManager : MonoBehaviour {

    public Text convText;
    public bool convOn;

	void Start ()
    {
        convOn = false;
        
    }

    void Update()
    {

    }

    public void SetBoxOn()
    {
        convOn = true;
    }

    public void SetBoxOff()
    {
        convOn = false;
    }

}
