using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MultiplicationSeventhNumberController : MonoBehaviour
{
    #region Variables
    public InputField inputResult;
    public Text textOperation;
    #endregion

    #region First Example Scene
    public void FirstExample()
    {
        if (inputResult.text == "7")
        {
            textOperation.text = "7 * 6 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "42")
        {
            textOperation.text = "7 * 4 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "28")
        {
            textOperation.text = "7 * 8 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "56")
        {
            textOperation.text = "7 * 5 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "35")
        {
            textOperation.text = "7 * 7 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "49")
        {
            textOperation.text = "7 * 9 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "63")
        {
            textOperation.text = "7 * 0 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "7 * 3 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "21")
        {
            textOperation.text = "7 * 10 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "70")
        {
            textOperation.text = "7 * 2 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "14")
        {
            SceneManager.LoadScene(20);
        }
        else
        {
            SceneManager.LoadScene(19);
        }
    }
    #endregion

    #region Second Example Scene
    public void SecondExample()
    {
        if (inputResult.text == "7")
        {
            textOperation.text = "7 * _ = 42";
            inputResult.text = "";
        }
        else if (inputResult.text == "6")
        {
            textOperation.text = "_ * 7 = 21";
            inputResult.text = "";
        }
        else if (inputResult.text == "3")
        {
            textOperation.text = "7 * _ = 56";
            inputResult.text = "";
        }
        else if (inputResult.text == "8")
        {
            textOperation.text = "_ * 7 = 28";
            inputResult.text = "";
        }
        else if (inputResult.text == "4")
        {
            textOperation.text = "7 * _ = 49";
            inputResult.text = "";
        }
        else if (inputResult.text == "7")
        {
            textOperation.text = "7 * _ = 63";
            inputResult.text = "";
        }
        else if (inputResult.text == "9")
        {
            textOperation.text = "_ * 7 = 7";
            inputResult.text = "";
        }
        else if (inputResult.text == "1")
        {
            textOperation.text = "7 * _ = 0";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "_ * 7 = 14";
            inputResult.text = "";
        }
        else if (inputResult.text == "2")
        {
            textOperation.text = "7 * _ = 70";
            inputResult.text = "";
        }
        else if (inputResult.text == "10")
        {
            SceneManager.LoadScene(21);
        }
        else
        {
            SceneManager.LoadScene(20);
        }
    }
    #endregion

    #region Buttons Return , ResetFirstScene, ResetSecondScene
    public void ReturnBtn()
    {
        SceneManager.LoadScene(6);
    }

    public void ResetFirstSceneMultiplicationBtn()
    {
        SceneManager.LoadScene(19);
    }

    public void ResetSecondSceneMultiplicationBtn()
    {
        SceneManager.LoadScene(20);
    }

    #endregion

    

}