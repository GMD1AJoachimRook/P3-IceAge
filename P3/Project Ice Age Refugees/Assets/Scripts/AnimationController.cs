using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {
    public MovementScript moof;
    public Animator anims;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (moof.animation == true)
        {
            anims.SetBool("IsWalking", true);
        }
        else
        {
            anims.SetBool("IsWalking", false);
        }
	}
}
