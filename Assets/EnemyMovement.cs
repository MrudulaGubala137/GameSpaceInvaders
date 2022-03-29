using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float time;
    bool flag = false;
    EnemySpawnAndMovement enemySpawner;
    public GameObject enemybulletPrefab;
    void Start()
    {
        enemySpawner =GameObject.Find("SpawnManager").GetComponent<EnemySpawnAndMovement>();
    }

    // Update is called once per frame
    void Update()
    {
       /* if (transform.position.x > -8f && transform.position.x < 8f)
            {
           transform.Translate(Vector2.right * 2f * Time.deltaTime);
        }
        
       
            if (transform.position.x <-8f ) 
        {
            transform.position = new Vector2( transform.position.x,transform.position.y - 1f);
            transform.Translate(Vector2.right * 2f * Time.deltaTime);
        }
        if (transform.position.x > 8f)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 1f);
            transform.Translate(Vector2.left * 2f * Time.deltaTime);
        }*/
      
        if (flag == false)
        {
            time = time + Time.deltaTime;
            transform.Translate(Vector2.right * 2f * Time.deltaTime);
            
            if (time > 3f)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);
                time = 0;
                flag = true;
            }
        }
      else if(flag==true)
        {
            transform.Translate(Vector2.left * 2f * Time.deltaTime);
            
            time = time + Time.deltaTime;
            if (time > 3f)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);
                time = 0;
                flag = false;
            }
        }
       


    }
}
