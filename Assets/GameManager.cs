using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public int Score1 = 0;
    public int Score2 = 0;
    public Text player1Score;
    public Text player2Score;
    public Text win1;
    public Text win2;
    public bool end = false;
    public KeyCode restart = KeyCode.Space;

    public GUISkin layout; //A definition of appearence and behaviour of graphics

    GameObject ball; //A representation of the ball

    // Use this for initialization
    void Start () {
        
        ball = GameObject.FindGameObjectWithTag("Ball");
        player1Score.text = Score1.ToString();
        player2Score.text = Score2.ToString();
        win1.text = "";
        win2.text = "";
        bool end;
	}
	
    void Update()
    {
        Invoke("Score", 0);
        if (Input.GetKey(restart) && end)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void Score()
    {
        
        if(ball.transform.position.x >= 8.3f)
        {
            Score1++;
            player1Score.text = Score1.ToString();
            ball.transform.position = Vector2.zero;
        }
        else if(ball.transform.position.x <= -8.3f)
        {
            Score2++;
            player2Score.text = Score2.ToString();
            ball.transform.position = Vector2.zero;

        }
         if (Score1 == 11)
        {
            win1.text = "Player 1 Wins";
            ball.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            ball.transform.position = Vector2.zero;
            end = true;
        }
        else if(Score2 == 11)
        {
            win2.text = "Player 2 Wins";
            ball.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            ball.transform.position = Vector2.zero;
            end = true;
        }
    }

}
