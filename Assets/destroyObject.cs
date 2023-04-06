using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObject : MonoBehaviour
{
    public GameObject tombstone;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "cauldron-objective")
        {
            tombstone = GameObject.Find("gravestone-old-cross-finish");
            Destroy(other.gameObject);
            Destroy(tombstone);
        }
    }
}
