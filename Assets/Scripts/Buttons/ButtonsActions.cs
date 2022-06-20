using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonsActions : MonoBehaviour
{
    public void FirstButton()
    {
        StartCoroutine(nameof(FirstButtonCoroutine));
    }

    IEnumerator FirstButtonCoroutine()
    {
        Image buttonImage = GameObject.Find("Button First").GetComponent<Image>();

        buttonImage.color = Color.green;
        yield return new WaitForSeconds(1);
        buttonImage.color = new Color(0, 0, 179);
    }

    public void SecondButton()
    {
        StartCoroutine(nameof(SecondButtonCoroutine));
    }

    IEnumerator SecondButtonCoroutine()
    {
        Image buttonImage = GameObject.Find("Button Second").GetComponent<Image>();

        for (int i = 0; i < 2; i++)
        {
            buttonImage.color = Color.red;
            yield return new WaitForSeconds(0.1f);
            buttonImage.color = new Color(0, 0, 230);
            yield return new WaitForSeconds(0.1f);    
        }
    }

    public void ThirdButton()
    {
        StartCoroutine(nameof(ThirdButtonCoroutine));
    }

    IEnumerator ThirdButtonCoroutine()
    {
        GameObject button = GameObject.Find("Button Third");

        button.transform.DOScaleX(1.2f, 0.3f).SetEase(Ease.OutBack).onComplete = () =>
        {
            button.transform.DOScaleX(1.0f, 0.3f).SetEase(Ease.OutBack);
        };

        yield return new WaitForSeconds(0.6f);

        button.transform.DOScaleY(1.2f, 0.3f).SetEase(Ease.OutBack).onComplete = () =>
        {
            button.transform.DOScaleY(1.0f, 0.3f).SetEase(Ease.OutBack);
        };
    }

    public void FourthButton()
    {
        StartCoroutine(nameof(FourthButtonCoroutine));
    }

    IEnumerator FourthButtonCoroutine()
    {
        GameObject button = GameObject.Find("Button Fourth");

        button.transform.DOShakeRotation(0.5f, new Vector3(0, 0, 20), 10);

        yield return new WaitForSeconds(1f);

        button.transform.DOLocalRotate(new Vector3(0, 0, 360), 0.5f, RotateMode.LocalAxisAdd);
    }
}
