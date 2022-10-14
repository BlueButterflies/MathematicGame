using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MultiplicationThirdNumberController : MonoBehaviour
{
    #region Variables
    public InputField inputResult;
    public Text textOperation;
    #endregion

    #region First Example Scene
    public void FirstExample()
    {
        if (inputResult.text == "3")
        {
            textOperation.text = "3 * 6 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "18")
        {
            textOperation.text = "3 * 4 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "12")
        {
            textOperation.text = "3 * 8 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "24")
        {
            textOperation.text = "3 * 5 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "15")
        {
            textOperation.text = "3 * 7 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "21")
        {
            textOperation.text = "3 * 9 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "27")
        {
            textOperation.text = "3 * 0 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "3 * 3 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "9")
        {
            textOperation.text = "3 * 10 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "30")
        {
            textOperation.text = "3 * 2 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "6")
        {
            SceneManager.LoadScene(12);
        }
        else
        {
            SceneManager.LoadScene(11);
        }
    }
    #endregion

    #region Second Example Scene
    public void SecondExample()
    {
        if (inputResult.text == "3")
        {
            textOperation.text = "3 * _ = 18";
            inputResult.text = "";
        }
        else if (inputResult.text == "6")
        {
            textOperation.text = "_ * 3 = 12";
            inputResult.text = "";
        }
        else if (inputResult.text == "4")
        {
            textOperation.text = "3 * _ = 24";
            inputResult.text = "";
        }
        else if (inputResult.text == "8")
        {
            textOperation.text = "_ * 3 = 15";
            inputResult.text = "";
        }
        else if (inputResult.text == "5")
        {
            textOperation.text = "3 * _ = 21";
            inputResult.text = "";
        }
        else if (inputResult.text == "7")
        {
            textOperation.text = "3 * _ = 27";
            inputResult.text = "";
        }
        else if (inputResult.text == "9")
        {
            textOperation.text = "_ * 3 = 3";
            inputResult.text = "";
        }
        else if (inputResult.text == "1")
        {
            textOperation.text = "3 * _ = 0";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "_ * 3 = 6";
            inputResult.text = "";
        }
        else if (inputResult.text == "2")
        {
            textOperation.text = "3 * _ = 30";
            inputResult.text = "";
        }
        else if (inputResult.text == "10")
        {
            SceneManager.LoadScene(13);
        }
        else
        {
            SceneManager.LoadScene(12);
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
        SceneManager.LoadScene(11);
    }

    public void ResetSecondSceneMultiplicationBtn()
    {
        SceneManager.LoadScene(12);
    }

    #endregion
}
