using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerController : MonoBehaviour
{
    private Rigidbody2D rd;
    private float speed = 5f;
    public float boundary = 10f;
    private float facingDirection = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        Vector3 moveDirection = new Vector3 (moveInput, 0, 0);
        transform.Translate (moveDirection * speed * Time.deltaTime);
        Vector3 currentPosition = transform.position;
        if (currentPosition.x < -boundary)
        {
            currentPosition.x = -boundary;
        }
        else if (currentPosition.x > boundary)
        {
            facingDirection = 1;
            currentPosition.x = boundary;
        }
        if (Input.GetKey(KeyCode.A))
        {
            facingDirection = -1;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            facingDirection = 1;            
        }
        Vector3 newScale = transform.localScale;
        newScale.x = facingDirection;
        transform.localScale = newScale;
        transform.position = currentPosition;
    }
}
