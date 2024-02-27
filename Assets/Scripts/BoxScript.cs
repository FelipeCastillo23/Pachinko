using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxScript : MonoBehaviour
{
    int nextScene = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (nextScene < 4)
        {
            if (gameObject.tag == "GreenBox")
            {
                int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
                SceneManager.LoadScene(nextScene);
            }
            else if (gameObject.tag == "YellowBox")
            {
                Ball ball = other.gameObject.GetComponent<Ball>();
                ball.Respawn();
            }

        }
        else
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene("MainMenu");

        }

    }
}
