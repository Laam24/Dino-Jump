using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform tr;

    private float enemySpeed = -10f;

    


    // Start is called before the first frame update
    void Start()
    {
        
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

        rb.velocity = transform.right * enemySpeed;


    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Des"))
        {
            Destroy(gameObject);
        }

       

    }

   

}
