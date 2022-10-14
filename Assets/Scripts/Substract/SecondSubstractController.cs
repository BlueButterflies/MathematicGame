using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SecondSubstractController : MonoBehaviour
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
            txtOperations.text = "8 - _ = 4";
            inputResult.text = "";
        }
        else if (inputResult.text == "4")
        {
            txtOperations.text = "_ - 3 = 0";
            inputResult.text = "";
        }
        else if (inputResult.text == "3")
        {
            txtOperations.text = "10 - _ = 5";
            inputResult.text = "";
        }
        else if (inputResult.text == "5")
        {
            txtOperations.text = "9 - _ = 2";
            inputResult.text = "";
        }
        else if (inputResult.text == "7")
        {
            txtOperations.text = "7 - _ = 6";
            inputResult.text = "";
        }
        else if (inputResult.text == "1")
        {
            txtOperations.text = "16 - _ = 10";
            inputResult.text = "";
        }
        else if (inputResult.text == "6")
        {
            txtOperations.text = "14 - _ = 2";
            inputResult.text = "";
        }
        else if (inputResult.text == "12")
        {
            txtOperations.text = "_ - 0 = 0";
            inputResult.text = "";
        }
        else if (inputResult.text == "0")
        {
            txtOperations.text = "18 - _ = 9";
            inputResult.text = "";
        }
        else if (inputResult.text == "9")
        {
            txtOperations.text = "_ - 10 = 10";
            inputResult.text = "";
        }
        else if (inputResult.text == "20")
        {
            txtOperations.text = "15 - _ = 4";
            inputResult.text = "";
        }
        else if (inputResult.text == "11")
        {
            txtOperations.text = "9 - _ = 1";
            inputResult.text = "";
        }
        else if (inputResult.text == "8")
        {
            txtOperations.text = "16 - _ = 3";
            inputResult.text = "";
        }
        else if (inputResult.text == "13")
        {
            txtOperations.text = "16 - _ = 2";
            inputResult.text = "";
        }
        else if (inputResult.text == "14")
        {
            txtOperations.text = "18 - _ = 3";
            inputResult.text = "";
        }
        else if (inputResult.text == "15")
        {
            txtOperations.text = "20 - _ = 4";
            inputResult.text = "";
        }
        else if (inputResult.text == "16")
        {
            txtOperations.text = "20 - _ = 2";
            inputResult.text = "";
        }
        else if (inputResult.text == "18")
        {
            txtOperations.text = "18 - _ = 1";
            
        }
        else if (inputResult.text == "17")
        {
            txtOperations.text = "20 - _ = 10";
            inputResult.text = "";
        }
        else if (inputResult.text == "10")
        {
            panel.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene(5);
        }
    }
    #endregion

    #region Buttons Reset, Return
    public void ResetBtn()
    {
        SceneManager.LoadScene(5);
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
