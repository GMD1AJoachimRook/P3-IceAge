using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelterDoorOpen : MonoBehaviour {
    public List<GameObject> keycards = new List<GameObject>();



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            if (keycards.Count > 2)
            {
                print("OPEN");
            }
            else if (keycards.Count < 2)
            {
                print("PISSOFF");
            }
        }
    }
}
