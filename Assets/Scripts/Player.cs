using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    [SerializeField] Vector3 input;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("vertical"));
        print(input);
        if (Input.GetMouseButtonDown(0))
        {
            CreateBullet();
        }
    }
    void FixedUpdate()
    {
        rb.MovePosition(transform.Position + input * Time.fixedDeltaTime * speed);
    }
}
