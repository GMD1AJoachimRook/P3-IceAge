using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelterDoorOpen : MonoBehaviour {
    public List<GameObject> keycards = new List<GameObject>();
    public int count;
    public int amount;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Door")
        {
            for(int i = 0; i < keycards.Count; i++)
            {
                if(keycards[i].tag == "Key")
                {
                    count++;
                }
            }
            if (count>= amount)
            {
                print("open");
            }
        }
        count = 0;
    }
}
