using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour
{
    //���̴� �̹��� ( Color(R,G,B,A) : R0~1, G0~1, B0~1, A0~1 => 0:0 ~ 1:255 )
    public Image img;

    //��(Value)�� Ŀ�갪���� ȯ�����
    public AnimationCurve curve;

    [SerializeField]
    private float fadeTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //�����ϸ� ������ ȭ���� ������
        img.color = new Color(0, 0, 0, 1);
    }

    public void InFade(float fadeDelay)
    {
        StartCoroutine(FadeIn(fadeDelay));
    }

    //�� ���۽� 1�ʵ��� ���̵��� ȿ�� (���İ� �̿�) - �ڷ�ƾ
    IEnumerator FadeIn(float fadeDelay)
    {
        if (fadeDelay > 0)
        {
            yield return new WaitForSeconds(fadeDelay);
        }

        float t = 1f;

        while (t > 0)
        {
            t -= Time.deltaTime;
            float a = curve.Evaluate(t);
            img.color = new Color(0, 0, 0, a);
            yield return 0;
        }
    }

    //�� �̵�
    public void FadeTo(string sceneName)
    {
        StartCoroutine(FadeOut(sceneName));
    }

    public void FadeTo(int sceneNumber)
    {
        StartCoroutine(FadeOut(sceneNumber));
    }

    //�� ���۽� 1�ʵ��� ���̵�ƿ� ȿ�� �� �� �̵� (���İ� �̿�)
    IEnumerator FadeOut(string sceneName)
    {
        float t = 0f;

        while (t < 1f)
        {
            t += Time.deltaTime;
            float a = curve.Evaluate(t);
            img.color = new Color(0, 0, 0, a);
            yield return 0;
        }

        SceneManager.LoadScene(sceneName);
    }

    IEnumerator FadeOut(int sceneNumber)
    {
        float t = 0f;

        while (t < 1f)
        {
            t += Time.deltaTime;
            float a = curve.Evaluate(t);
            img.color = new Color(0, 0, 0, a);
            yield return 0;
        }

        SceneManager.LoadScene(sceneNumber);
    }


}
