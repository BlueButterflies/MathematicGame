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
        SceneManager.LoadScene(4);
    }

    public void ChoiceMultiplication()
    {
        SceneManager.LoadScene(6);
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