using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changelook : MonoBehaviour
{
    // declare gameobject which define target where camera shoul look
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        if (target==null)
        {
            target= this.gameObject;
            Debug.Log("defaulting to parent");
        }
    }

    private void OnMouseDown(){
        look.target=target;
        Camera.main.fieldOfView= Mathf.Clamp(60* target.transform.localScale.x,1,100);
    }
}
