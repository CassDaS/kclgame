using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    bool canPick;
    [SerializeField] GameObject target;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canPick == true)
        {
            this.transform.parent = target.transform;
            this.transform.localEulerAngles = new Vector3(0, 0, 0);
            this.GetComponent<Rigidbody>().isKinematic = true;
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            this.transform.parent = null;
            this.GetComponent<Rigidbody>().isKinematic = false;
        }
    }    
   
    void OnTriggerEnter(Collider other)
    {
        canPick = true;
    }

    void OnTriggerExit(Collider other)
    {
        canPick = false;
    }
}
