using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FiveMultiplication : MonoBehaviour
{
    #region Variables
    public InputField inputResult;
    public Text textOperation;
    #endregion

    #region First Example Scene
    public void FirstExample()
    {
        if (inputResult.text == "5")
        {
            textOperation.text = "5 * 6 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "30")
        {
            textOperation.text = "5 * 4 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "20")
        {
            textOperation.text = "5 * 8 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "40")
        {
            textOperation.text = "5 * 5 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "25")
        {
            textOperation.text = "5 * 7 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "35")
        {
            textOperation.text = "5 * 9 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "45")
        {
            textOperation.text = "5 * 0 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "5 * 3 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "15")
        {
            textOperation.text = "5 * 10 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "50")
        {
            textOperation.text = "5 * 2 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "10")
        {
            SceneManager.LoadScene(16);
        }
        else
        {
            SceneManager.LoadScene(15);
        }
    }
    #endregion

    #region Second Example Scene
    public void SecondExample()
    {
        if (inputResult.text == "5")
        {
            textOperation.text = "5 * _ = 30";
            inputResult.text = "";
        }
        else if (inputResult.text == "6")
        {
            textOperation.text = "_ * 5 = 15";
            inputResult.text = "";
        }
        else if (inputResult.text == "3")
        {
            textOperation.text = "5 * _ = 40";
            inputResult.text = "";
        }
        else if (inputResult.text == "8")
        {
            textOperation.text = "_ * 5 = 20";
            inputResult.text = "";
        }
        else if (inputResult.text == "4")
        {
            textOperation.text = "5 * _ = 35";
            inputResult.text = "";
        }
        else if (inputResult.text == "7")
        {
            textOperation.text = "5 * _ = 45";
            inputResult.text = "";
        }
        else if (inputResult.text == "9")
        {
            textOperation.text = "_ * 5 = 5";
            inputResult.text = "";
        }
        else if (inputResult.text == "1")
        {
            textOperation.text = "5 * _ = 0";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "_ * 5 = 10";
            inputResult.text = "";
        }
        else if (inputResult.text == "2")
        {
            textOperation.text = "5 * _ = 40";
            inputResult.text = "";
        }
        else if (inputResult.text == "10")
        {
            SceneManager.LoadScene(17);
        }
        else
        {
            SceneManager.LoadScene(16);
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
        SceneManager.LoadScene(15);
    }

    public void ResetSecondSceneMultiplicationBtn()
    {
        SceneManager.LoadScene(16);
    }

    #endregion
}
