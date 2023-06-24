using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Entity : MonoBehaviour
{
    [SerializeField] protected Rigidbody rb;
    [SerializeField] protected float speed;
    [SerializeField] protected GameObject bullet;
    [SerializeField] protected GameObject bulletSpawnPoint;

    protected void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    protected void CreateBullet()
    {
        GameObject go = Instantiate(bullet, bulletSpawnPoint.transform.position, Quaternion.identity);
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