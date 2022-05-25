using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Obstacles : MonoBehaviour
{
    public GameObject spawnedObject;
    private bool canDestroy = false;
    private void OnTriggerStay2D(Collider2D collision)
    {
        /*GameObject obstacle;
        if (collision.tag == "Obstacle")
        {
            obstacle = collision.gameObject;
            canDestroy = true;
            if (canDestroy == true && Input.GetKeyDown(KeyCode.E))
            {
                //Destroy(obstacle);
                Debug.Log("Destroying Obstacle");
            }
        }*/
        if (collision.tag == "Obstacle" && Input.GetButtonDown("Use"))
        {
            Debug.Log("Destroying Object");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(spawnedObject, Vector2.zero, Quaternion.identity);
        }
    }
}