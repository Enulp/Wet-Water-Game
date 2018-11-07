using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Transform target;

    public float speed = 15f;
    public GameObject impactEffect;

    public int damageToGive = 1;
    
    public float timeBeforeDestroy = 5f;

    public void Seek(Transform _target)
    {
        target = _target;
    }

    // Update is called once per frame
    void Update()
    {

        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        transform.LookAt(target);
        Destroy(gameObject, timeBeforeDestroy);

    }

    void HitTarget()
    {
        GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectIns, 5f);

        /*if (explosionRadius > 0f)
        {
            Explode();
        }
        else
        {
            Damage(target);
        }*/

        Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (!other.GetComponent<PlayerController>().hasClone && other.gameObject.tag == "Player")
        {
            Vector3 hitDirection = other.transform.position - transform.position;
            hitDirection = hitDirection.normalized;

            FindObjectOfType<HealthManager>().HurtPlayer(damageToGive, hitDirection);
        }
    }
    /*void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }*/
}
