using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MultiplicationSecondNumberController : MonoBehaviour
{
    #region Variables
    public InputField inputResult;
    public Text textOperation;
    #endregion

    #region First Example Scene
    public void FirstExample()
    {
        if (inputResult.text == "2")
        {
            textOperation.text = "2 * 6 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "12")
        {
            textOperation.text = "2 * 4 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "8")
        {
            textOperation.text = "2 * 8 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "16")
        {
            textOperation.text = "2 * 5 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "10")
        {
            textOperation.text = "2 * 7 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "14")
        {
            textOperation.text = "2 * 9 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "18")
        {
            textOperation.text = "2 * 0 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "2 * 3 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "6")
        {
            textOperation.text = "2 * 10 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "20")
        {
            SceneManager.LoadScene(10);
        }
        else
        {
            SceneManager.LoadScene(9);
        }
    }
    #endregion

    #region Second Example Scene
    public void SecondExample()
    {
        if (inputResult.text == "2")
        {
            textOperation.text = "2 * _ = 12";
            inputResult.text = "";
        }
        else if (inputResult.text == "6")
        {
            textOperation.text = "2 * _ = 8";
            inputResult.text = "";
        }
        else if (inputResult.text == "4")
        {
            textOperation.text = "2 * _ = 16";
            inputResult.text = "";
        }
        else if (inputResult.text == "8")
        {
            textOperation.text = "2 * _ = 10";
            inputResult.text = "";
        }
        else if (inputResult.text == "5")
        {
            textOperation.text = "2 * _ = 14";
            inputResult.text = "";
        }
        else if (inputResult.text == "7")
        {
            textOperation.text = "2 * _ = 18";
            inputResult.text = "";
        }
        else if (inputResult.text == "9")
        {
            textOperation.text = "2 * _ = 2";
            inputResult.text = "";
        }
        else if (inputResult.text == "1")
        {
            textOperation.text = "2 * _ = 0";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "2 * _ = 6";
            inputResult.text = "";
        }
        else if (inputResult.text == "3")
        {
            textOperation.text = "2 * _ = 20";
            inputResult.text = "";
        }
        else if (inputResult.text == "10")
        {
            SceneManager.LoadScene(11);
        }
        else
        {
            SceneManager.LoadScene(10);
        }
    }
    #endregion

    #region Buttons Return , ResetFirstScene,ResetSecondScene
    public void ReturnBtn()
    {
        SceneManager.LoadScene(6);
    }

    public void ResetFirstSceneMultiplicationBtn()
    {
        SceneManager.LoadScene(9);
    }

    public void ResetSecondSceneMultiplicationBtn()
    {
        SceneManager.LoadScene(10);
    }

    #endregion
}
