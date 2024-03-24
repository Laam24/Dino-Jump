using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UI;

public class spawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    public GameObject crow;
    public GameObject hill;


    

    // Start is called before the first frame update
    void Start()
    {

        
        InvokeRepeating("spawn", 2.5f, 3f);
        InvokeRepeating("crowSpawn", 15f, 5.5f);
        InvokeRepeating("hillSpawn", 3f, 15f);


    }

    // Update is called once per frame
    void Update()
    {

        if(player == null)
        {
            CancelInvoke("spawn");
            CancelInvoke("crowSpawn");
            CancelInvoke("hillSpawn");
        }
    }

    void spawn()
    {
        float randomX = Random.Range(10.6f, 18.3f);

        Vector3 enemySpawn = new Vector3(randomX, -2.551f, 0);
        Instantiate(enemy, enemySpawn , Quaternion.identity);
    }

    void crowSpawn()
    {
        float randomX = Random.Range(10.6f, 20.5f);
        float randomY = Random.Range(-0.5f, 1.95f);

        Vector3 crowSpawn = new Vector3(randomX, randomY, 0);
        Instantiate(crow, crowSpawn, Quaternion.identity);
    }

    void hillSpawn()
    {
        float randomX = Random.Range(14.90f, 15.5f);
        

        Vector3 hillSpawn = new Vector3(randomX, -2.2f, 0);
        Instantiate(hill, hillSpawn, Quaternion.identity);
    }





}
