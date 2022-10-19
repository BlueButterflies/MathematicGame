using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DivisionController : MonoBehaviour
{
    #region Variables
    public InputField inputResult;
    public Text textOperation;

    private AudioSource audioSource;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    #region First Example Scene
    public void FirstExample()
    {
        if (inputResult.text == "10")
        {
            textOperation.text = "10 * _ = 60";
            inputResult.text = "";
        }
        else if (inputResult.text == "6")
        {
            textOperation.text = "_ * 10 = 30";
            inputResult.text = "";
        }
        else if (inputResult.text == "3")
        {
            textOperation.text = "10 * _ = 80";
            inputResult.text = "";
        }
        else if (inputResult.text == "8")
        {
            textOperation.text = "_ * 10 = 40";
            inputResult.text = "";
        }
        else if (inputResult.text == "4")
        {
            textOperation.text = "10 * _ = 70";
            inputResult.text = "";
        }
        else if (inputResult.text == "7")
        {
            textOperation.text = "10 * _ = 90";
            inputResult.text = "";
        }
        else if (inputResult.text == "9")
        {
            textOperation.text = "_ * 10 = 10";
            inputResult.text = "";
        }
        else if (inputResult.text == "1")
        {
            textOperation.text = "10 * _ = 0";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "10 * _ = 20";
            inputResult.text = "";
        }
        else if (inputResult.text == "2")
        {
            SceneManager.LoadScene(28);
        }
        else
        {
            audioSource.Play();
            inputResult.text = "";
        }
    }
    #endregion

    #region Buttons Retur, Reset
    public void ReturnBtn()
    {
        SceneManager.LoadScene(1);
    }

    public void ResetBtn()
    {
        SceneManager.LoadScene(27);
    }

    #endregion
}
