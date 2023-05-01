using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyObject : MonoBehaviour
{
    public GameObject tombstone;
    public GameObject objPanel;
    public Text objText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "cauldron-objective")
        {
            tombstone = GameObject.Find("gravestone-old-cross-finish");
            Destroy(other.gameObject);
            Destroy(tombstone);
            StartCoroutine(StartText());
        }
    }

    IEnumerator StartText()
    {
        objText.text = "Find the exit";
        objPanel.SetActive(true);
        yield return new WaitForSeconds(5);
        objPanel.SetActive(false);
    }
}
