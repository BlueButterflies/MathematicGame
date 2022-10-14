using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class AddController : MonoBehaviour
{
    #region Variables
    public Text txtOperations;
    public InputField inputResult;
    #endregion

    #region Result
    public void ResultCorrectOrNo()
    {
        if (inputResult.text == "5")
        {
            txtOperations.text = "3 + 4 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "7")
        {
            txtOperations.text = "0 + 4 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "4")
        {
            txtOperations.text = "5 + 3 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "8")
        {
            txtOperations.text = "7 + 2 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "9")
        {
            txtOperations.text = "3 + 3 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "6")
        {
            txtOperations.text = "5 + 5 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "10")
        {
            txtOperations.text = "12 + 2 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "14")
        {
            txtOperations.text = "1 + 1 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "2")
        {
            txtOperations.text = "8 + 9 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "17")
        {
            txtOperations.text = "10 + 10 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "20")
        {
            txtOperations.text = "12 + 4 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "16")
        {
            txtOperations.text = "2 + 1 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "3")
        {
            txtOperations.text = "15 + 4 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "19")
        {
            txtOperations.text = "13 + 5 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "18")
        {
            txtOperations.text = "13 + 2=";
            inputResult.text = "";
        }
        else if (inputResult.text == "15")
        {
            txtOperations.text = "3 + 10 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "13")
        {
            txtOperations.text = "0 + 1=";
            inputResult.text = "";
        }
        else if (inputResult.text == "1")
        {
            txtOperations.text = "11 + 1 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "12")
        {
            txtOperations.text = "10 + 1 =";
            inputResult.text = "";
        }
        else if (inputResult.text == "11")
        {
            SceneManager.LoadScene(3);
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }
    #endregion

    #region Buttons Reset, Return
    public void ResetBtn()
    {
        SceneManager.LoadScene(2);
    }

    public void ReturnBtn()
    {
        SceneManager.LoadScene(1);
    }
    #endregion

}
