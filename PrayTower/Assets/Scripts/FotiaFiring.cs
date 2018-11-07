using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FotiaFiring : MonoBehaviour {

    float timer = 0;
    GameObject a;
    public GameObject fireBall;

    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer >= 5)
        {
            timer = 0;
            a  = Fotia.Instantiate(fireBall, transform.position, transform.rotation);
            a.GetComponent<PlayerController>().moveSpeed = 10f;
        }
        timer += Time.deltaTime;
        Destroy(a, 3f);
    }
}
