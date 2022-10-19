using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public void ChoiceAdd()
    {
        SceneManager.LoadScene(2);
    }

    public void ChoiceSubstract()
    {
        SceneManager.LoadScene(13);
    }

    public void ChoiceMultiplication()
    {
        SceneManager.LoadScene(21);
    }

    public void ChoiceDivision()
    {
        SceneManager.LoadScene(8);
    }

    public void ReturnBtn()
    {
        SceneManager.LoadScene(0);
    }
}