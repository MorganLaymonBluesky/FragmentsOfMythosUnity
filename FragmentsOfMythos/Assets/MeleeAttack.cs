using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{

    Collider2D meleeCollider;
    Vector2 rightAttackOffset;

    private void Start()
    {
        meleeCollider.GetComponent<Collider2D>();
        rightAttackOffset = transform.position;
    }

    public void AttackRight()
    {
        meleeCollider.enabled = true;
        transform.position = rightAttackOffset;
    }

    public void AttackLeft()
    {
        meleeCollider.enabled = true;
        transform.position = new Vector3(rightAttackOffset.x * -1, rightAttackOffset.y);
    }

    public void StopAttack()
    {
        meleeCollider.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            // Deal Damage to Enemy
        }
    }
}
