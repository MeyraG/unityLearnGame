using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeController: MonoBehaviour
{
    public Transform node;
    public float nodeSpeed = 10;

    public bool GetCollected;
  

    void Update()
    {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, node.position.x, Time.deltaTime * nodeSpeed), node.position.y, node.position.z + 1);
    }

    public void DecreaseNode()
    {
        Debug.Log("NodeController'dan geldim");
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            DecreaseNode();
            other.gameObject.GetComponent<MeshCollider>().enabled = false;
        }
    }
}