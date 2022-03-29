using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerSpeed;
    public GameObject bulletPrefab;
    private Vector3 offSet;
    Rigidbody2D rb;
    private float time;
   public  int health = 30;
    public GameObject gameOverPanel;
    public Text winOrlostText;
    public Text playerHealth;
    ScoreManager scoreManager;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        scoreManager=GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float inputx = Input.GetAxis("Horizontal");
        transform.Translate(inputx * playerSpeed * Time.deltaTime, 0f, 0f);
        if (transform.position.x < -8.0f)
            transform.position = new Vector2(-8.0f, transform.position.y);
        if (transform.position.x > 8.0f)
            transform.position = new Vector2(8.0f, transform.position.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab,transform.position+offSet,Quaternion.identity);
            
        }
        if(time>3.0f)
        {
            Destroy(bulletPrefab);
        }
        if(scoreManager.health<=0)
        {
           playerHealth.text= (scoreManager.health.ToString());
            Destroy(this.gameObject);
             gameOverPanel.SetActive(true);
            winOrlostText.text = "You Lost";

        }
        if(scoreManager.score==50)
        {
            gameOverPanel.SetActive(true);
            winOrlostText.text = "You Won";
        }

    }
   

}
