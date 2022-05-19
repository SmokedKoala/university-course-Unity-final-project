using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetWarm : MonoBehaviour
{
    public string tagName;
    private bool getWarm;    
    private float time = 0.0f;
    private float interpolationPeriod = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        getWarm = false;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= interpolationPeriod) {
            getWarm = !getWarm;
            time = 0.0f;
        }
    }

        private void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag == tagName){
            if (getWarm) {
                coll.gameObject.GetComponent<PlayerCharacteristics>().warm += 30;
                if (coll.gameObject.GetComponent<PlayerCharacteristics>().warm > 101) {
                    coll.gameObject.GetComponent<PlayerCharacteristics>().warm = 101;
                }
            }
        }
    }
}
