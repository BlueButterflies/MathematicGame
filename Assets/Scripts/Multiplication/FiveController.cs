using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FiveController : MonoBehaviour
{
    #region Variables
    public Text numberFirst;
    public Text numberSecond;

    private AudioSource audioSource;
    public AudioClip[] audioClips;

    public Text firstResult;
    public Text secondResult;
    public Text thirdResult;
    public Text fourthResult;

    private int firstNumber;
    private int secondNumber;
    private int temp;

    private int firstExample;
    private int secondExample;
    private int thirdExample;

    private int result;
    #endregion

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

        Calculated();
        ButtonsResult();
    }

    private void Calculated()
    {
        firstNumber = 5;
        secondNumber = Random.Range(1, 10);

        if (firstNumber - secondNumber < 0)
        {
            temp = secondNumber;
            secondNumber = firstNumber;
            firstNumber = temp;
        }

        result = firstNumber * secondNumber;

        numberFirst.text = firstNumber.ToString();
        numberSecond.text = secondNumber.ToString();
        //Debug.Log($"first {firstNumber} ; second {secondNumber}; result {result}");
    }

    #region Random Buttons Result
    private void ButtonsResult()
    {
        //first example

        temp = UnityEngine.Random.Range(1, 50);
        while (temp == result)
        {
            temp = UnityEngine.Random.Range(1, 50);
        }
        firstExample = temp;

        //second example
        temp = UnityEngine.Random.Range(1, 50);
        while (temp == result || temp == firstExample)
        {
            temp = UnityEngine.Random.Range(1, 50);
        }
        secondExample = temp;

        //third example
        temp = UnityEngine.Random.Range(1, 50);
        while (temp == result || temp == firstExample || temp == secondExample)
        {
            temp = UnityEngine.Random.Range(1, 50);
        }
        thirdExample = temp;

        //random buttons example result

        temp = UnityEngine.Random.Range(1, 7);

        if (temp == 1)
        {
            firstResult.text = result.ToString();
            secondResult.text = firstExample.ToString();
            thirdResult.text = secondExample.ToString();
            fourthResult.text = thirdExample.ToString();
        }

        if (temp == 2)
        {
            firstResult.text = thirdExample.ToString();
            secondResult.text = result.ToString();
            thirdResult.text = firstExample.ToString();
            fourthResult.text = secondExample.ToString();
        }

        if (temp == 3)
        {
            firstResult.text = secondExample.ToString();
            secondResult.text = thirdExample.ToString();
            thirdResult.text = result.ToString();
            fourthResult.text = firstExample.ToString();
        }

        if (temp == 4)
        {
            firstResult.text = result.ToString();
            secondResult.text = firstExample.ToString();
            thirdResult.text = secondExample.ToString();
            fourthResult.text = thirdExample.ToString();
        }

        if (temp == 5)
        {
            firstResult.text = firstExample.ToString();
            secondResult.text = thirdExample.ToString();
            thirdResult.text = secondExample.ToString();
            fourthResult.text = result.ToString();
        }

        if (temp == 6)
        {
            firstResult.text = thirdExample.ToString();
            secondResult.text = secondExample.ToString();
            thirdResult.text = result.ToString();
            fourthResult.text = firstExample.ToString();
        }
    }
    #endregion

    #region Buttons  result
    public void ButtonFirstExample()
    {
        if (firstResult.text == result.ToString())
        {
            audioSource.PlayOneShot(audioClips[0]);
            Start();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void ButtonSecondExample()
    {
        if (secondResult.text == result.ToString())
        {
            audioSource.PlayOneShot(audioClips[0]);
            Start();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void ButtonThirdExample()
    {
        if (thirdResult.text == result.ToString())
        {
            audioSource.PlayOneShot(audioClips[0]);
            Start();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }

    public void ButtonFourthExample()
    {
        if (fourthResult.text == result.ToString())
        {
            audioSource.PlayOneShot(audioClips[0]);
            Start();
        }
        else
        {
            audioSource.PlayOneShot(audioClips[1]);
        }
    }
    #endregion

    #region Buttons Return, Menu
    public void ReturnBtn()
    {
        SceneManager.LoadScene(20);
    }

    public void MenuBtn()
    {
        SceneManager.LoadScene(1);
    }
    #endregion
}
