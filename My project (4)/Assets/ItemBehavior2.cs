using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior2 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);

            Debug.Log("Oar, will be animated to use boat");
        }
    }



}
