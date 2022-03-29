using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectController : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            other.gameObject.transform.position = transform.position + Vector3.forward;
            //Destroy(gameObject.GetComponent<CollectController>());
            other.gameObject.AddComponent<CollectController>();
            //other.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            other.gameObject.AddComponent<NodeController>().node = transform;
            other.gameObject.tag = "hasCollected";
            other.gameObject.GetComponent<MeshCollider>().enabled = false;           
        }

        if (other.gameObject.CompareTag("Obstacle"))
        {
            if (gameObject.CompareTag("Collectible"))
            {
               other.gameObject.AddComponent<GameManager>();
            }          
        }
    }
}