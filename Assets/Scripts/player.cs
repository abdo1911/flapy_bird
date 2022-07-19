using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Vector3 direction;
    public float gravity = -9.8f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Obs")
        {
            FindObjectOfType<GameManger>().GameOver();
        }else if(other.gameObject.tag == "Scoring")
        {
            FindObjectOfType<GameManger>().IncreaseScore();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            direction = Vector3.up * 5f;
        }
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime; 
    }
    
        
}
