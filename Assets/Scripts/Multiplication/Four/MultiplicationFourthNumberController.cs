using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MultiplicationFourthNumberController : MonoBehaviour
{
    #region Variables
    public InputField inputResult;
    public Text textOperation;
    #endregion

    #region First Example Scene
    public void FirstExample()
    {
        if (inputResult.text == "4")
        {
            textOperation.text = "4 * 6 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "24")
        {
            textOperation.text = "4 * 4 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "16")
        {
            textOperation.text = "4 * 8 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "32")
        {
            textOperation.text = "4 * 5 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "20")
        {
            textOperation.text = "4 * 7 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "28")
        {
            textOperation.text = "4 * 9 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "36")
        {
            textOperation.text = "4 * 0 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "4 * 3 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "12")
        {
            textOperation.text = "4 * 10 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "40")
        {
            textOperation.text = "4 * 2 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "8")
        {
            SceneManager.LoadScene(14);
        }
        else
        {
            SceneManager.LoadScene(13);
        }
    }
    #endregion

    #region Second Example Scene
    public void SecondExample()
    {
        if (inputResult.text == "4")
        {
            textOperation.text = "4 * _ = 24";
            inputResult.text = "";
        }
        else if (inputResult.text == "6")
        {
            textOperation.text = "_ * 3 = 12";
            inputResult.text = "";
        }
        else if (inputResult.text == "4")
        {
            textOperation.text = "4 * _ = 32";
            inputResult.text = "";
        }
        else if (inputResult.text == "8")
        {
            textOperation.text = "_ * 4 = 20";
            inputResult.text = "";
        }
        else if (inputResult.text == "5")
        {
            textOperation.text = "4 * _ = 28";
            inputResult.text = "";
        }
        else if (inputResult.text == "7")
        {
            textOperation.text = "4 * _ = 36";
            inputResult.text = "";
        }
        else if (inputResult.text == "9")
        {
            textOperation.text = "_ * 4 = 4";
            inputResult.text = "";
        }
        else if (inputResult.text == "1")
        {
            textOperation.text = "4 * _ = 0";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "_ * 4 = 8";
            inputResult.text = "";
        }
        else if (inputResult.text == "2")
        {
            textOperation.text = "4 * _ = 40";
            inputResult.text = "";
        }
        else if (inputResult.text == "10")
        {
            SceneManager.LoadScene(15);
        }
        else
        {
            SceneManager.LoadScene(14);
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
        SceneManager.LoadScene(13);
    }

    public void ResetSecondSceneMultiplicationBtn()
    {
        SceneManager.LoadScene(14);
    }

    #endregion
}
