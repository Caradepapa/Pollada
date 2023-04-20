using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private float speed = 0.8f;
    private void LateUpdate()
    {
        this.transform.position += new Vector3(0, 0, 1) * speed * Time.deltaTime;
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
