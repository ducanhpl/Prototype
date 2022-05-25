using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField]
    private float speed;
    
    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.position = transform.position + playerInput.normalized * speed * Time.deltaTime;  
    }
}