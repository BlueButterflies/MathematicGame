using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceNumber : MonoBehaviour
{
    #region Buttons Choice
    public void ChoiceOne()
    {
        SceneManager.LoadScene(22); 
    }

    public void ChoiceTwo()
    {
        SceneManager.LoadScene(23);
    }

    public void ChoiceThree()
    {
        SceneManager.LoadScene(24);
    }

    public void ChoiceFour()
    {
        SceneManager.LoadScene(25);
    }

    public void ChoiceFive()
    {
        SceneManager.LoadScene(26);
    }

    public void ChoiceSix()
    {
        SceneManager.LoadScene(27);
    }

    public void ChoiceSeven()
    {
        SceneManager.LoadScene(28);
    }

    public void ChoiceEight()
    {
        SceneManager.LoadScene(29);
    }

    public void ChoiceNine()
    {
        SceneManager.LoadScene(30);
    }

    public void ChoiceTen()
    {
        SceneManager.LoadScene(31);
    }
    #endregion

    public void Backbtn()
    {
        SceneManager.LoadScene(1);
    }
}
