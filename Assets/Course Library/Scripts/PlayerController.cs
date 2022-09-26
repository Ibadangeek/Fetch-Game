using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public float horizontalInput;
    public float speed = 10.0f;
    public float leftSide = -10;
    public float rightSide = 33;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < leftSide) {
            transform.position = new Vector3(transform.position.x, transform.position.y, leftSide);
        }
        if (transform.position.z > rightSide) {
            transform.position = new Vector3(transform.position.x, transform.position.y, rightSide);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Lauch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
