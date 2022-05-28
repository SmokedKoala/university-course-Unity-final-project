using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    Animator anim;
    private int current_tool = 0;

    private SwitchTools tools;

    void Start()
    {
        anim = GetComponent<Animator>();
        tools = GameObject.Find("tools").GetComponent<SwitchTools>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            current_tool = tools.selectedTool;
            if (current_tool == 1)
                anim.SetTrigger("knife_attack_trigger");
        }
    }
}
