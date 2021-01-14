using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = guess +1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess -1;
        NextGuess();
    }


    void NextGuess()
    {
        guess = Random.Range(min, max);
        guessText.text = (guess.ToString() + "?");
    }

    /*public string DisplayMaxNumber()
    {
        return max.ToString();
    }
    public string DisplayMinNumber()
    {
        return min.ToString();
    }*/

}
