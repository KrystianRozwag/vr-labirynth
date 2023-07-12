using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//wrzucasz ten skrypt na ka¿d¹ przeszkodê i do ka¿dej instancji odpowiednio podpinasz obiekty
public class HitObstacle : MonoBehaviour
{
    public GameObject player; //tutaj wrzucasz obiekt gracza który siê porusza i ma collidera
    public Transform respawnPoint; //tutaj wrzucasz gameobject ustawiony w miejscu respawnu
    public Button respawnBtn; //tutaj wrzucasz przycisk, po klikniêciu którego przenosi gracza do punktu z respawnPoint
    public GameObject respawnPanel;

    //listener for the button to removing the game objects
    void Update()
    {
        respawnBtn.onClick.AddListener(() => Respawn());
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            respawnPanel.SetActive(true);
            player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }

    //method for removing the game objects - uses DestroyImmediate method with given root to delete
    void Respawn()
    {
        player.transform.position = respawnPoint.position;
        respawnPanel.SetActive(false);
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
    }
}