using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MultiplicationFirstNumberController : MonoBehaviour
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
            textOperation.text = "1 * 6 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "6")
        {
            textOperation.text = "1 * 4 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "4")
        {
            textOperation.text = "1 * 8 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "8")
        {
            textOperation.text = "1 * 5 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "5")
        {
            textOperation.text = "1 * 7 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "7")
        {
            textOperation.text = "1 * 9 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "9")
        {
            textOperation.text = "1 * 1 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "1")
        {
            textOperation.text = "1 * 0 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "1 * 3 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "3")
        {
            textOperation.text = "1 * 10 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "10")
        {
            SceneManager.LoadScene(8);
        }
        else
        {
            SceneManager.LoadScene(7);
        }
    }
    #endregion

    #region Second Example Scene
    public void SecondExample()
    {
        if (inputResult.text == "2")
        {
            textOperation.text = "1 * _ = 6";
            inputResult.text = "";
        }
        else if (inputResult.text == "6")
        {
            textOperation.text = "1 * _= 4";
            inputResult.text = "";
        }
        else if (inputResult.text == "4")
        {
            textOperation.text = "1 * _ = 8";
            inputResult.text = "";
        }
        else if (inputResult.text == "8")
        {
            textOperation.text = "1 * _ = 5";
            inputResult.text = "";
        }
        else if (inputResult.text == "5")
        {
            textOperation.text = "1 * _ =";
            inputResult.text = "";
        }
        else if (inputResult.text == "7")
        {
            textOperation.text = "1 * _ = 9";
            inputResult.text = "";
        }
        else if (inputResult.text == "9")
        {
            textOperation.text = "1 * _ = 1";
            inputResult.text = "";
        }
        else if (inputResult.text == "1")
        {
            textOperation.text = "1 * _ = 0";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "1 * _ = 3";
            inputResult.text = "";
        }
        else if (inputResult.text == "3")
        {
            textOperation.text = "1 * _ = 10";
            inputResult.text = "";
        }
        else if (inputResult.text == "10")
        {
            SceneManager.LoadScene(9);
        }
        else
        {
            SceneManager.LoadScene(8);
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
        SceneManager.LoadScene(7);
    }

    public void ResetSecondSceneMultiplicationBtn()
    {
        SceneManager.LoadScene(8);
    }


    #endregion
}
