using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = ((max - min) / 2) + 1;
        Debug.Log("Number WARLOCK");
        Debug.Log($"The number has to be between {min} and {max}");
        Debug.Log($"Tell me if your number is higher or lower than {guess}");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        // Devido ao arrendondamento pra baixo, max++ é necessário.
        max++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I knew it!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log($"Is it higher or lower than {guess}?");
    }
}
