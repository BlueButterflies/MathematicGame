using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceNumber : MonoBehaviour
{
    #region Buttons Choice
    public void ChoiceOne()
    {
        SceneManager.LoadScene(7); 
    }

    public void ChoiceTwo()
    {
        SceneManager.LoadScene(9);
    }

    public void ChoiceThree()
    {
        SceneManager.LoadScene(11);
    }

    public void ChoiceFour()
    {
        SceneManager.LoadScene(13);
    }

    public void ChoiceFive()
    {
        SceneManager.LoadScene(15);
    }

    public void ChoiceSix()
    {
        SceneManager.LoadScene(17);
    }

    public void ChoiceSeven()
    {
        SceneManager.LoadScene(19);
    }

    public void ChoiceEight()
    {
        SceneManager.LoadScene(21);
    }

    public void ChoiceNine()
    {
        SceneManager.LoadScene(23);
    }

    public void ChoiceTen()
    {
        SceneManager.LoadScene(25);
    }
    #endregion

    public void Backbtn()
    {
        SceneManager.LoadScene(1);
    }
}
