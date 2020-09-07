using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhirligigSawController : MonoBehaviour
{
    [SerializeField]
    protected float
        rotationSpeed = 10f,
        hitRadius = 0.85f,
        touchDamage = 1000f;

    [SerializeField]
    protected LayerMask whatIsPlayer;

    protected AttackDetails attackDetails;

    protected virtual void Start()
    {
        attackDetails.damageAmout = touchDamage;
        attackDetails.position = transform.position;
    }

    protected virtual void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, rotationSpeed));

        CheckPlayerHit();
    }

    protected virtual void CheckPlayerHit()
    {

        Collider2D[] detectedObjects = Physics2D.OverlapCircleAll(transform.position, hitRadius, whatIsPlayer);

        foreach (Collider2D collider in detectedObjects)
        {
            collider.transform.SendMessage("Damage", attackDetails);
        }
    }

    protected virtual void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, hitRadius);
    }
}
