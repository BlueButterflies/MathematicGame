using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NumbersController : MonoBehaviour
{
    #region Buttons Choice
    public void EndTen()
    {
        SceneManager.LoadScene(3);
    }

    public void EndTwenty()
    {
        SceneManager.LoadScene(4);
    }

    public void EndThirthy()
    {
        SceneManager.LoadScene(5);
    }

    public void EndFourthy()
    {
        SceneManager.LoadScene(6);
    }

    public void EndFifthy()
    {
        SceneManager.LoadScene(7);
    }

    public void EndSixthy()
    {
        SceneManager.LoadScene(8);
    }

    public void EndSeventhy()
    {
        SceneManager.LoadScene(9);
    }

    public void EndEighty()
    {
        SceneManager.LoadScene(10);
    }

    public void EndNinty()
    {
        SceneManager.LoadScene(11);
    }

    public void EndHundred()
    {
        SceneManager.LoadScene(12);
    }
    #endregion

    public void Backbtn()
    {
        SceneManager.LoadScene(1);
    }
}
