using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    public float MinY = -3.8f;
    public float MaxY = 3.8f;

    public Text ScoreTxt;
    public float Score = 0;
    void Start()
    {
        
    }
    void Update()
    {
        ScoreTxt.text = "Score: " + Score;
        transform.position = new Vector3(0, Mathf.Clamp(transform.position.y, MinY, MaxY), 0);
        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(-8.5f , verticalInput * speed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Score++;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Score = 0;
            SceneManager.LoadScene("GameOver");
        }
        
    }
    
}
