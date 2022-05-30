using System.Net.Mime;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    public int hunger = 100;
    public int warm = 100;

    private CharacterStats playerStats;

    int health = 100;

    public Text healthView;
    public Text hungerView;
    public Text warmView;

    private float time = 0.0f;
    private float interpolationPeriod = 5.0f;
    void Start()
    {
        Transform player = PlayerManager.instance.player.transform;
        playerStats = player.GetComponent<CharacterStats>();
        health = playerStats.currentHealth;
        hungerView.text = hunger.ToString();
        warmView.text = warm.ToString();
        healthView.text = health.ToString();
    }

    void Update()
    {
        health = playerStats.currentHealth;
        hungerView.text = hunger.ToString();
        warmView.text = warm.ToString();
        healthView.text = health.ToString();
        time += Time.deltaTime;
        if (time >= interpolationPeriod)
        {
            hunger -= 1;
            warm -= 1;
            time = 0.0f;
        }
    }


    public override void Die()
    {
        base.Die();
        PlayerManager.instance.KillPlayer();
    }
}
