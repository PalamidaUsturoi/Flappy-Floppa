using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
    public Player player;
    public MovingPipe[] pipes = new MovingPipe[8];
    public Moving background;
    public Moving floor;
    public Respawn respawn;
    private static int score;
    public PauseButton pauseButton;
    public ResumeButton resumeButton;
    public CallingMainMenu menu;
    // private bool gameOver;

    private void Start() {
        score = 0;
        player.OnCollision = (Collision2D col) => PlayerCollision(col);
        respawn.OnCollision = (Collider2D col) => Respawn(col);
        pauseButton.OnClick = ShowMenu;
        resumeButton.OnClick = HideMenu;
        menu.Hide();
        // gameOver = false;
        foreach (MovingPipe pipe in pipes)
            pipe.coordY = Random.Range(pipe.startY, pipe.endY);
    }

    private void ShowMenu()
    {
        menu.Show();
        pauseButton.Hide();
    }

    private void HideMenu()
    {
        menu.Hide();
        pauseButton.Show();
    }

    private void PlayerCollision(Collision2D col) {
        if ( col.collider.name == "Score" )
            score ++;
        else if (col.collider.name == "Floor" || col.collider.name == "Pipe Up" || col.collider.name == "Pipe Down" || col.collider.name == "Border (1)")
            GameOver();
    }

    private void Respawn(Collider2D col) {
        if ( col.tag == "Obstacle" ) {
            MovingPipe pipe = col.GetComponent<MovingPipe>();
            pipe.coordX = pipe.start;
            pipe.coordY = Random.Range(pipe.startY, pipe.endY);
        }
    }

    private void Update() {
        if ( Input.GetKeyDown(KeyCode.Space) )
            player.Jump();
    }

    private void GameOver() {
        // gameOver = true;
        foreach(MovingPipe pipe in pipes) {
            pipe.Stop();
        }
        player.Stop();
        background.Stop();
        floor.Stop();
    }
}
