using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubstractChoice : MonoBehaviour
{
    public void EndTen()
    {
        SceneManager.LoadScene(14);
    }

    public void EndTwenty()
    {
        SceneManager.LoadScene(15);
    }

    public void EndFourty()
    {
        SceneManager.LoadScene(16);
    }
    public void EndSixty()
    {
        SceneManager.LoadScene(17);
    }

    public void EndEighty()
    {
        SceneManager.LoadScene(18);
    }

    public void EndHundred()
    {
        SceneManager.LoadScene(19);
    }

    public void More()
    {
        SceneManager.LoadScene(20);
    }

    public void Backbtn()
    {
        SceneManager.LoadScene(1);
    }
}
