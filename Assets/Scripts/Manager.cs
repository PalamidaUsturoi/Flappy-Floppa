using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Player player;
    private bool gameOver;
    public CallingMainMenu panel;
    public PauseButton pauseButton;
    public ResumeButton resumeButton;

    private void Start()
    {
        player.OnCollision = GameOver;
        gameOver = false;
        pauseButton.OnClick = ShowPanel;
        resumeButton.OnClick = HidePanel;
        panel.Hide();
    }

    private void Update()
    {
        if (!gameOver && Input.GetKeyDown(KeyCode.Space))
            player.Jump();
    }

    private void GameOver()
    {
        gameOver = true;
        Debug.Log("Game Over");
    }

    private void ShowPanel()
    {
        panel.Show();
    }
    private void HidePanel()
    {
        panel.Hide();
    }
}
