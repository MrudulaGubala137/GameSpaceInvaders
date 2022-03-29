using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public int bulletSpeed;
   ScoreManager scoreManager;
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up*bulletSpeed*Time.deltaTime);

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="Enemy")
        {
            scoreManager.Score(10);
            Destroy (collision.gameObject);
            Destroy(this.gameObject);
        }
    }
   
}
