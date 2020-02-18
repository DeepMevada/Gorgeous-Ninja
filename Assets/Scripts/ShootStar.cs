using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootStar : MonoBehaviour
{
    public Transform firePoint;
    public GameObject star;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
       // anim.SetTrigger("attack");
        Instantiate(star, firePoint.position, firePoint.rotation);
    }
}
