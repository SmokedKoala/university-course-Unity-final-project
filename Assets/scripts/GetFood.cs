using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFood : MonoBehaviour
{
    public string tagName;
    private PlayerStats playerStats;
    void Start()
    {
        playerStats = PlayerManager.instance.player.GetComponent<PlayerStats>();
    }

    private void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag == tagName)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                playerStats.hunger += 30;
                playerStats.Heal(30);
                if (playerStats.hunger > 100)
                {
                    playerStats.hunger = 100;
                }
                Destroy(this.gameObject);
            }
        }
    }
}
