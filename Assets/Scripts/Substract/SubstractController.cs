using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SubstractController : MonoBehaviour
{
    #region Variables
    public Text txtOperations;
    public InputField inputResult;
    #endregion

    #region Input Result
    public void ResultCorrectOrNo()
    {
        if (inputResult.text == "2")
        {
            txtOperations.text = "5 - 1 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "4")
        {
            txtOperations.text = "8 - 5 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "3")
        {
            txtOperations.text = "9 - 4 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "5")
        {
            txtOperations.text = "9 - 2 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "7")
        {
            txtOperations.text = "10 - 9 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "1")
        {
            txtOperations.text = "7 - 1 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "6")
        {
            txtOperations.text = "14 - 2 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "12")
        {
            txtOperations.text = "2 - 2 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            txtOperations.text = "18 - 9 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "9")
        {
            txtOperations.text = "20 - 10 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "10")
        {
            txtOperations.text = "15 - 4 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "11")
        {
            txtOperations.text = "9 - 1 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "8")
        {
            txtOperations.text = "16 - 3 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "13")
        {
            txtOperations.text = "16 - 2 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "14")
        {
            txtOperations.text = "18 - 3 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "15")
        {
            txtOperations.text = "20 - 4 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "16")
        {
            txtOperations.text = "20 - 2 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "18")
        {
            txtOperations.text = "18 - 1 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "17")
        {
            txtOperations.text = "20 - 0 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "20")
        {
            SceneManager.LoadScene(5);
        }
        else
        {
            SceneManager.LoadScene(4);
        }
    }
    #endregion

    #region Buttons Reset, Return
    public void ResetBtn()
    {
        SceneManager.LoadScene(4);
    }

    public void ReturnBtn()
    {
        SceneManager.LoadScene(1);
    }

    #endregion
}
