using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFood : MonoBehaviour
{
    public string tagName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag == tagName){
            if (Input.GetKeyDown(KeyCode.E)){
                coll.gameObject.GetComponent<PlayerCharacteristics>().hunger += 30;
                if (coll.gameObject.GetComponent<PlayerCharacteristics>().hunger > 101) {
                    coll.gameObject.GetComponent<PlayerCharacteristics>().hunger = 101;
                }
                Destroy(this.gameObject);
            }
        }
    }
}
