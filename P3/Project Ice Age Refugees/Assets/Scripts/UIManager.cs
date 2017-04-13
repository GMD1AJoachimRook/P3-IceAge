using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public GameManager gameManager;
    public GameObject player;
    public Text diaText; //onscreen text
    public Text yesNo;
    public Text pressE;

    void Start()
    {
        yesNo.enabled = false;
        pressE.enabled = false;
    }

    void Update ()
    {

	}

    public void DisplayText(string dialogueText)
    {
        diaText.text = dialogueText;
    }

    public void Question()
    {
        yesNo.enabled = true;
        pressE.enabled = false;
    }

    public void QuestionDisabled()
    {
        yesNo.enabled = false;
        pressE.enabled = true;
    }

    public void InteractActive()
    {
        pressE.enabled = true;
    }

    public void InteractInactive()
    {
        pressE.enabled = false;
    }
}
