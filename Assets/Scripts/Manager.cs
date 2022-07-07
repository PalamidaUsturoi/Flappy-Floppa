using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
    public Player player;
    private bool gameOver;

    private void Start() {
        player.OnCollision = GameOver;
        gameOver = false;
    }

    private void Update() {
        if ( !gameOver && Input.GetKeyDown(KeyCode.Space) )
            player.Jump();
    }

    private void GameOver() {
        gameOver = true;
        Debug.Log("Game Over");
    }
}
