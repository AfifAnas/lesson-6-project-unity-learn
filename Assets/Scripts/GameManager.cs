using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text counterText;
    public Text timerText;

    private int Count = 0;
    private float gameTime = 60f;
    private bool gameOver = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            gameTime -= Time.deltaTime;
            timerText.text = "Time: " + Mathf.Ceil(gameTime);

            if (gameTime <= 0)
            {
                gameOver = true;
                timerText.text = "Game Over!";
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Count += 1;
        counterText.text = "Count : " + Count;
        Destroy(other.gameObject, 1f);
    }

}
