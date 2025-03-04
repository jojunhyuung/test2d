using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//이름 몬스터 스크립트로 변경예정
public class IDamage : MonoBehaviour
{
    public Animator animators;
    public GameObject player;
    public GameObject hudDamageText;

    public Transform hudPos;
    public GameObject coinPos;

    public GameObject gold;

    public float monsterGold = 10;
    public float monstersHP = 0;
    [SerializeField]
    public float monstersExp = 10;
    public float monstersDamge = 10f;
    private void Start()
    {
        animators = GetComponent<Animator>();
    }
    public void MonstartDelete(float damageAmount)
    {
        GameObject hudText = Instantiate(hudDamageText);
        hudText.transform.position = hudPos.position;
        hudText.GetComponent<DamageText>().damage = damageAmount;

        monstersHP -= damageAmount;

        animators.SetTrigger("Damage");
        if (monstersHP <= 0)
        {
           
            var py = player.GetComponent<Player>();
            py.Player_Exp += monstersExp;
            Instantiate(gold, coinPos.transform.position, coinPos.transform.rotation);
            Destroy(gameObject);
        }
    }
    /*
    public void BossKonckback(float damageAmount)//, Vector2 directionKonckback) //보스 공격
    {
        GameObject hudText = Instantiate(hudDamageText);
        hudText.transform.position = hudPos.position;
        hudText.GetComponent<DamageText>().damage = damageAmount;

        var pH = GetComponent<Player>().playerHP;
        pH -= damageAmount;
    }*/
    /*
    public void BossDelete(float damageAmount) //플레이어가 보스 공격
    {
        GameObject hudText = Instantiate(hudDamageText);
        hudText.transform.position = hudPos.position;
        hudText.GetComponent<DamageText>().damage = damageAmount;


        monstersHP -= damageAmount;
        animators.SetTrigger("Damage");
        if (monstersHP <= 0)
        {
            Destroy(gameObject);
            var py = player.GetComponent<Player>();
            py.Player_Exp += monstersExp;
        }
    }
    */



}
