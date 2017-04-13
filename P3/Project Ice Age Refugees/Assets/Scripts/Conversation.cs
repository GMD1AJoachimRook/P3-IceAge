using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversation : MonoBehaviour {

    public ConversationManager convMan;
    public UIManager uiManager;
    public List<string> convStrings = new List<string>();
    public int count;
    public int npcNumber;
    public bool questions;
    public bool oneTimeConv;
    public bool ableToTalk;
    public bool convDone;
    public bool actionDone;

	void Update ()
    {

        if (questions == true && ableToTalk == true)
        {
            if (Input.GetButtonDown("One"))
            {
                uiManager.DisplayText(convStrings[count + 3]);
                uiManager.QuestionDisabled();
                count += 5;
                questions = false;
            }
            if (Input.GetButtonDown("Two"))
            {
                uiManager.DisplayText(convStrings[count + 5]);
                uiManager.QuestionDisabled();
                count += 5;
                questions = false;
            }
        }

        if (Input.GetButtonDown("E") && convMan.convOn == true && questions ==  false && ableToTalk == true)
        {
            count++;
            if(count > convStrings.Count - 1)
            {
                if (oneTimeConv == false)
                {
                    count = 0;
                }
                else
                {
                    convDone = true;
                }
            }
            if (convDone == false)
            {
                if (convStrings[count] == "???")
                {
                    uiManager.DisplayText(convStrings[count + 1]);
                    uiManager.Question();
                    questions = true;
                }

                else
                {
                    uiManager.DisplayText(convStrings[count]);
                }
            }
            
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (convDone == false)
        {
            convMan.SetBoxOn();
            ableToTalk = true;
            uiManager.DisplayText("");
        }
        uiManager.InteractActive();
    }

    void OnTriggerExit(Collider other)
    {
        convMan.SetBoxOff();
        ableToTalk = false;
        uiManager.DisplayText("");
        count = 0;
        if (questions == true)
        {
            questions = false;
        }
        if (actionDone == true)
        {
            convDone = true;
        }
        uiManager.QuestionDisabled();
        uiManager.InteractInactive();
    }
}
