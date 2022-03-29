using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnAndMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float time;
    public GameObject[] enemyPrefab;
    int i;
    float bulletTime;
   
    void Start()
    {
        while (i < 5)
        {
            Instantiate(enemyPrefab[i], transform.position + new Vector3(-5 + i, 4f, 0f), Quaternion.identity);
            i = i + 1;

        }
    }
    // Update is called once per frame
    void Update()
    {
      




    }
}
