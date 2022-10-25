using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DivisionChoice : MonoBehaviour
{
    public void WithOneNumber()
    {
        SceneManager.LoadScene(32);
    }

    public void WithTwoNumber()
    {
        SceneManager.LoadScene(33);
    }

    public void Return()
    {
        SceneManager.LoadScene(1);
    }
}
