using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crowMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform tr;
    public scoreManager sc;

    private float crowSpeed = -12f;

    


    // Start is called before the first frame update
    void Start()
    {
        
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //transform.Translate(-0.05f, 0, 0);
        rb.velocity = transform.right * crowSpeed;


    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Des"))
        {
            Destroy(gameObject);
        }



    }
}
