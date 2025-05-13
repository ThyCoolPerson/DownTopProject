using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject Melee;
    bool isAttacking = false;
    float attackDuration = 0.3f;
    float attackTimer = 0f;

    // Update is called once per frame
    void Update()
    {
        CheckMeleeTimer(); 
        
        if (Input.GetKeyDown(KeyCode.E) || Input.GetMouseButton(0))
        {
            OnAttack();
        }
    }

    void OnAttack()
    {
        if (!isAttacking)
        {
            Melee.SetActive(true);
            isAttacking = true;
        }
    }

    void CheckMeleeTimer()
    {
        if(isAttacking)
        {
            attackTimer += Time.deltaTime;
            if (attackTimer >= attackDuration)
            {
                attackTimer = 0;
                isAttacking = false;
                Melee.SetActive(false);
            }
        }
    }
}
