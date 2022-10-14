using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MultiplicationTenthNumberController : MonoBehaviour
{
    #region Variables
    public InputField inputResult;
    public Text textOperation;
    #endregion

    #region First Example Scene
    public void FirstExample()
    {
        if (inputResult.text == "10")
        {
            textOperation.text = "10 * 6 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "60")
        {
            textOperation.text = "10 * 4 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "40")
        {
            textOperation.text = "10 * 8 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "80")
        {
            textOperation.text = "10 * 5 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "50")
        {
            textOperation.text = "10 * 7 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "70")
        {
            textOperation.text = "10 * 9 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "90")
        {
            textOperation.text = "10 * 0 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            textOperation.text = "10 * 3 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "30")
        {
            textOperation.text = "10 * 10 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "100")
        {
            textOperation.text = "10 * 2 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "20")
        {
            SceneManager.LoadScene(26);
        }
        else
        {
            SceneManager.LoadScene(25);
        }
    }
    #endregion

    #region Buttons Return , ResetFirstScene
    public void ReturnBtn()
    {
        SceneManager.LoadScene(6);
    }

    public void ResetBtn()
    {
        SceneManager.LoadScene(25);
    }

    #endregion
}
