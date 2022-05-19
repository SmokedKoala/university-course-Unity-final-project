
using System.Net.Mime;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacteristics : MonoBehaviour
{
    public int hunger = 100;
    public int warm = 100;
    public Text hungerView;
    public Text warmView;

    private float time = 0.0f;
    private float interpolationPeriod = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        hungerView.text = hunger.ToString();
        warmView.text = warm.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= interpolationPeriod) {
            hunger -= 1;
            warm -= 1;
            hungerView.text = hunger.ToString();
            warmView.text = warm.ToString();
            time = 0.0f;
        }
    }
}
