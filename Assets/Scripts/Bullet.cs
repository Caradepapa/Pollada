using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SphereCollider))]
public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    SphereCollider sc;
    public int BulletDamage = 1;
    void Awake()
    {
        sc = GetComponent<SphereCollider>();
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        sc.isTrigger = true;
    }

   

    private void FixedUpdate()
    {
        rb.velocity = Vector3.forward * 4f;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
