using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    public Collider2D meleeCollider;
    public float damage = 3;
    Vector2 rightAttackOffset;

    private void Start()
    {
        rightAttackOffset = transform.localPosition;
    }

    public void AttackRight()
    {
        meleeCollider.enabled = true;
        transform.localPosition = rightAttackOffset;
    }

    public void AttackLeft()
    {
        meleeCollider.enabled = true;
        transform.localPosition = new Vector3(rightAttackOffset.x * -1, rightAttackOffset.y);
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
            Slime slime = collision.GetComponent<Slime>();

            if (slime != null)
            {
                slime.Health -= damage;
            }
        }
    }
}
