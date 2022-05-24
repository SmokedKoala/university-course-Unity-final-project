using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFire : MonoBehaviour
{
    public string tagName;
    private int num = 0;
    public GameObject Prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (num >= 2){
            createFire();
        }
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == tagName){
            num++;
            Destroy(coll.gameObject);
            Debug.Log(num);
        }
    }

    private void createFire(){
        Instantiate(Prefab, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
