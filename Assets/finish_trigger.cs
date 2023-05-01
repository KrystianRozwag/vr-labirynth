using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish_trigger : MonoBehaviour
{
    public GameObject finishText;
    public GameObject finishTrigger;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == finishTrigger)
        {
            finishText.SetActive(true);
        }
    }
}
