using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamageText : MonoBehaviour
{
    public float textSpeed;
    public float alphaSpeed;
    public float destroyTime;

    TextMeshPro text;
    Color alpha;

    public float damage = 0;
    void Start()
    {
        text = GetComponent<TextMeshPro>();
        text.text = damage.ToString();
        alpha = text.color;
        Invoke("DestroyText", destroyTime);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, textSpeed * Time.deltaTime, 0));
        alpha.a = Mathf.Lerp(alpha.a, 0, Time.deltaTime * alphaSpeed);
        text.color = alpha;
    }

    private void DestroyText() 
    {
        Destroy(gameObject);
    }
}
