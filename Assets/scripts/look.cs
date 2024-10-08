using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    // target where camera look
    static public GameObject target; 
    // Start is called before the first frame update
    void Start()
    {
        if (target==null)
        {
            target=this.gameObject;
            Debug.Log("defaulting to parent");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target){
            transform.LookAt(target.transform);
        }
    }
}
