using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    Animator anim;
    private int current_tool = 0;

    CharacterCombat combat;

    private SwitchTools tools;

    void Start()
    {
        anim = GetComponent<Animator>();
        tools = GameObject.Find("tools").GetComponent<SwitchTools>();
        combat = PlayerManager.instance.player.GetComponent<CharacterCombat>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            current_tool = tools.selectedTool;
            if (current_tool == 1)
            {
                anim.SetTrigger("knife_attack_trigger");
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 15))
                {
                    Transform target = hit.collider.transform;
                    float distance = Vector3.Distance(target.position, transform.position);
                    if (distance <= 3f)
                    {
                        CharacterStats targetStats = target.GetComponent<CharacterStats>();
                        if (targetStats != null)
                        {
                            combat.Attack(targetStats);
                        }
                    }
                }
            }
        }
    }
}
