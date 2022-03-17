using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnAndMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float time;
    public GameObject enemyPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time >= 3.0f)
        {
            transform.position = new Vector2(Random.Range(-8.2f, 8.2f), Random.Range(4.2f, 1.2f));
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            time = 0;
        }
    }
}
