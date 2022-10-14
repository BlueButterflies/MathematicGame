using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MultiplicationSixNumberController : MonoBehaviour
{
    #region Variables
    public InputField inputResult;
    public Text textOperation;
    #endregion

    #region First Example Scene
    public void FirstExample()
    {
        if (inputResult.text == "6")
        {
            textOperation.text = "6 * 6 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "36")
        {
            textOperation.text = "6 * 4 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "24")
        {
            textOperation.text = "6 * 8 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "48")
        {
            textOperation.text = "6 * 5 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "30")
        {
            textOperation.text = "6 * 7 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "42")
        {
            textOperation.text = "6 * 9 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "54")
        {
            textOperation.text = "6 * 0 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "6 * 3 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "18")
        {
            textOperation.text = "6 * 10 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "60")
        {
            textOperation.text = "6 * 2 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "12")
        {
            SceneManager.LoadScene(18);
        }
        else
        {
            SceneManager.LoadScene(17);
        }
    }
    #endregion

    #region Second Example Scene
    public void SecondExample()
    {
        if (inputResult.text == "6")
        {
            textOperation.text = "6 * _ = 36";
            inputResult.text = "";
        }
        else if (inputResult.text == "6")
        {
            textOperation.text = "_ * 6 = 18";
            inputResult.text = "";
        }
        else if (inputResult.text == "3")
        {
            textOperation.text = "6 * _ = 48";
            inputResult.text = "";
        }
        else if (inputResult.text == "8")
        {
            textOperation.text = "_ * 6 = 24";
            inputResult.text = "";
        }
        else if (inputResult.text == "4")
        {
            textOperation.text = "6 * _ = 42";
            inputResult.text = "";
        }
        else if (inputResult.text == "7")
        {
            textOperation.text = "6 * _ = 54";
            inputResult.text = "";
        }
        else if (inputResult.text == "9")
        {
            textOperation.text = "_ * 6 = 6";
            inputResult.text = "";
        }
        else if (inputResult.text == "1")
        {
            textOperation.text = "6 * _ = 0";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "_ * 6 = 12";
            inputResult.text = "";
        }
        else if (inputResult.text == "2")
        {
            textOperation.text = "6 * _ = 60";
            inputResult.text = "";
        }
        else if (inputResult.text == "10")
        {
            SceneManager.LoadScene(19);
        }
        else
        {
            SceneManager.LoadScene(18);
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
        SceneManager.LoadScene(17);
    }

    public void ResetSecondSceneMultiplicationBtn()
    {
        SceneManager.LoadScene(18);
    }

    #endregion
}
