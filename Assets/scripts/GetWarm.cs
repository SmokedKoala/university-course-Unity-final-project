using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetWarm : MonoBehaviour
{
    public string tagName;
    private bool getWarm = false;
    private PlayerStats playerStats;

    private float time = 0.0f;
    private float interpolationPeriod = 2.0f;
    void Start()
    {
        playerStats = PlayerManager.instance.player.GetComponent<PlayerStats>();
    }

    void Update()
    {
        time += Time.deltaTime;
        if (time >= interpolationPeriod)
        {
            getWarm = !getWarm;
            time = 0.0f;
        }
    }

    private void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag == tagName)
        {
            if (getWarm)
            {
                playerStats.warm += 30;
                if (playerStats.warm > 100)
                {
                    playerStats.warm = 100;
                }
            }
        }
    }
}
