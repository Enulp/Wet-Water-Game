using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletForMultiplayer : MonoBehaviour
{

    public int damageToGive;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject hit = collision.gameObject;
        Health health = hit.GetComponent<Health>();

        if (health != null)
        {
            health.TakeDamage(damageToGive);
        }
        Destroy(gameObject);
    }
}
