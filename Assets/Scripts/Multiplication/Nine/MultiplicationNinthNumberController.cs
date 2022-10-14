using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MultiplicationNinthNumberController : MonoBehaviour
{
    #region Variables
    public InputField inputResult;
    public Text textOperation;
    #endregion

    #region First Example Scene
    public void FirstExample()
    {
        if (inputResult.text == "9")
        {
            textOperation.text = "9 * 6 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "54")
        {
            textOperation.text = "9 * 4 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "36")
        {
            textOperation.text = "9 * 8 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "72")
        {
            textOperation.text = "9 * 5 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "45")
        {
            textOperation.text = "9 * 7 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "63")
        {
            textOperation.text = "9 * 9 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "81")
        {
            textOperation.text = "9 * 0 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "9 * 3 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "27")
        {
            textOperation.text = "9 * 10 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "90")
        {
            textOperation.text = "9 * 2 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "18")
        {
            SceneManager.LoadScene(24);
        }
        else
        {
            SceneManager.LoadScene(23);
        }
    }
    #endregion

    #region Second Example Scene
    public void SecondExample()
    {
        if (inputResult.text == "9")
        {
            textOperation.text = "9 * _ = 54";
            inputResult.text = "";
        }
        else if (inputResult.text == "6")
        {
            textOperation.text = "_ * 9 = 27";
            inputResult.text = "";
        }
        else if (inputResult.text == "3")
        {
            textOperation.text = "9 * _ = 72";
            inputResult.text = "";
        }
        else if (inputResult.text == "8")
        {
            textOperation.text = "_ * 9 = 36";
            inputResult.text = "";
        }
        else if (inputResult.text == "4")
        {
            textOperation.text = "9 * _ = 63";
            inputResult.text = "";
        }
        else if (inputResult.text == "7")
        {
            textOperation.text = "9 * _ = 81";
            inputResult.text = "";
        }
        else if (inputResult.text == "9")
        {
            textOperation.text = "_ * 9 = 9";
            inputResult.text = "";
        }
        else if (inputResult.text == "1")
        {
            textOperation.text = "9 * _ = 0";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "_ * 9 = 18";
            inputResult.text = "";
        }
        else if (inputResult.text == "2")
        {
            textOperation.text = "9 * _ = 90";
            inputResult.text = "";
        }
        else if (inputResult.text == "10")
        {
            SceneManager.LoadScene(25);
        }
        else
        {
            SceneManager.LoadScene(24);
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
        SceneManager.LoadScene(23);
    }

    public void ResetSecondSceneMultiplicationBtn()
    {
        SceneManager.LoadScene(24);
    }

    #endregion
}
