﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCard : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        print("1");
        if (collision.gameObject.tag == "Player")
        {

            collision.gameObject.GetComponent<ShelterDoorOpen>().keycards.Add(gameObject);
            print("2");
            this.GetComponent<MeshRenderer>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
        }
    }


}
