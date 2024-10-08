using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // declaring a varible to select a rotation target
    public Transform target;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotate around
        // 1st para - target position
        // 2nd para - axis of rotation
        // 3rd para - speed of rotation
        transform.RotateAround(target.transform.position,target.transform.up,speed * Time.deltaTime);

    }
}
