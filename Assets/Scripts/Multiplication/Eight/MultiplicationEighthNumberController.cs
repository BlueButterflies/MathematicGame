using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MultiplicationEighthNumberController : MonoBehaviour
{
    #region Variables
    public InputField inputResult;
    public Text textOperation;
    #endregion

    #region First Example Scene
    public void FirstExample()
    {
        if (inputResult.text == "8")
        {
            textOperation.text = "8 * 6 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "48")
        {
            textOperation.text = "8 * 4 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "32")
        {
            textOperation.text = "8 * 8 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "64")
        {
            textOperation.text = "8 * 5 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "40")
        {
            textOperation.text = "8 * 7 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "56")
        {
            textOperation.text = "8 * 9 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "72")
        {
            textOperation.text = "8 * 0 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "8 * 3 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "24")
        {
            textOperation.text = "8 * 10 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "80")
        {
            textOperation.text = "8 * 2 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "16")
        {
            SceneManager.LoadScene(22);
        }
        else
        {
            SceneManager.LoadScene(21);
        }
    }
    #endregion

    #region Second Example Scene
    public void SecondExample()
    {
        if (inputResult.text == "8")
        {
            textOperation.text = "8 * _ = 48";
            inputResult.text = "";
        }
        else if (inputResult.text == "6")
        {
            textOperation.text = "_ * 8 = 24";
            inputResult.text = "";
        }
        else if (inputResult.text == "3")
        {
            textOperation.text = "8 * _ = 64";
            inputResult.text = "";
        }
        else if (inputResult.text == "8")
        {
            textOperation.text = "_ * 8 = 32";
            inputResult.text = "";
        }
        else if (inputResult.text == "4")
        {
            textOperation.text = "8 * _ = 56";
            inputResult.text = "";
        }
        else if (inputResult.text == "7")
        {
            textOperation.text = "8 * _ = 72";
            inputResult.text = "";
        }
        else if (inputResult.text == "9")
        {
            textOperation.text = "_ * 8 = 8";
            inputResult.text = "";
        }
        else if (inputResult.text == "1")
        {
            textOperation.text = "8 * _ = 0";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "_ * 8 = 16";
            inputResult.text = "";
        }
        else if (inputResult.text == "2")
        {
            textOperation.text = "8 * _ = 80";
            inputResult.text = "";
        }
        else if (inputResult.text == "10")
        {
            SceneManager.LoadScene(23);
        }
        else
        {
            SceneManager.LoadScene(22);
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
        SceneManager.LoadScene(21);
    }

    public void ResetSecondSceneMultiplicationBtn()
    {
        SceneManager.LoadScene(22);
    }

    #endregion
}
