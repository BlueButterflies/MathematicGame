using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceNumber : MonoBehaviour
{
    #region Buttons Choice
    public void ChoiceOne()
    {
        SceneManager.LoadScene(21); 
    }

    public void ChoiceTwo()
    {
        SceneManager.LoadScene(22);
    }

    public void ChoiceThree()
    {
        SceneManager.LoadScene(23);
    }

    public void ChoiceFour()
    {
        SceneManager.LoadScene(24);
    }

    public void ChoiceFive()
    {
        SceneManager.LoadScene(25);
    }

    public void ChoiceSix()
    {
        SceneManager.LoadScene(26);
    }

    public void ChoiceSeven()
    {
        SceneManager.LoadScene(27);
    }

    public void ChoiceEight()
    {
        SceneManager.LoadScene(28);
    }

    public void ChoiceNine()
    {
        SceneManager.LoadScene(29);
    }

    public void ChoiceTen()
    {
        SceneManager.LoadScene(30);
    }
    #endregion

    public void Backbtn()
    {
        SceneManager.LoadScene(1);
    }
}
