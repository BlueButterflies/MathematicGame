using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AddSecondController : MonoBehaviour
{
    #region Variables
    public Text txtOperations;
    public InputField inputResult;
    public GameObject panel;
    #endregion

    #region Input Result
    public void ResultCorrectOrNo()
    {
        if (inputResult.text == "2")
        {
            txtOperations.text = "1 + _ = 5";
            inputResult.text = "";
        }
        else if (inputResult.text == "4")
        {
            txtOperations.text = "0 + _ = 3";
            inputResult.text = "";
        }
        else if (inputResult.text == "3")
        {
            txtOperations.text = "_ + 3 = 8";
            inputResult.text = "";
        }
        else if (inputResult.text == "5")
        {
            txtOperations.text = "2 + _ = 9";
            inputResult.text = "";
        }
        else if (inputResult.text == "7")
        {
            txtOperations.text = "10 + _ = 11";
            inputResult.text = "";
        }
        else if (inputResult.text == "1")
        {
            txtOperations.text = "4 + _ = 10";
            inputResult.text = "";
        }
        else if (inputResult.text == "6")
        {
            txtOperations.text = "_ + 2 = 14";
            inputResult.text = "";
        }
        else if (inputResult.text == "12")
        {
            txtOperations.text = "2 + _ = 2";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            txtOperations.text = "_ + 9 = 18";
            inputResult.text = "";
        }
        else if (inputResult.text == "9")
        {
            txtOperations.text = "10 + _ = 20";
            inputResult.text = "";
        }
        else if (inputResult.text == "10")
        {
            txtOperations.text = "_ + 4 = 15";
            inputResult.text = "";
        }
        else if (inputResult.text == "11")
        {
            txtOperations.text = "_ + 1 = 9";
            inputResult.text = "";
        }
        else if (inputResult.text == "8")
        {
            txtOperations.text = "3 + _ = 16";
            inputResult.text = "";
        }
        else if (inputResult.text == "13")
        {
            txtOperations.text = "_ + 2 = 16";
            inputResult.text = "";
        }
        else if (inputResult.text == "14")
        {
            txtOperations.text = "3 + _ = 18";
            inputResult.text = "";
        }
        else if (inputResult.text == "15")
        {
            txtOperations.text = "_ + 4 = 20";
            inputResult.text = "";
        }
        else if (inputResult.text == "16")
        {
            txtOperations.text = "2 + _= 20";
            inputResult.text = "";
        }
        else if (inputResult.text == "18")
        {
            txtOperations.text = "1 + _ = 18";
            inputResult.text = "";
        }
        else if (inputResult.text == "17")
        {
            txtOperations.text = "_ + 0 = 20";
            inputResult.text = "";
        }
        else if (inputResult.text == "20")
        {
            panel.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene(3);
        }
    }
    #endregion

    #region Buttons Reset, Return, Back
    public void ResetBtn()
    {
        SceneManager.LoadScene(3);
    }

    public void ReturnBtn()
    {
        SceneManager.LoadScene(1);
    }

    public void BtnBack()
    {
        ResetBtn();
    }
    #endregion
}
