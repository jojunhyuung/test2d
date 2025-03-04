using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;
using static UnityEngine.GraphicsBuffer;

public class Player : MonoBehaviour
{
    public float playerMaxHP = 5; //�ִ� ü��
    public float playerHP = 5; //���� ü��

    public int Player_Lv = 1;
    public float Player_Exp; // ���� ����ġ
    public float XP = 100;   // ����ġ�� GameManager�� �����ϸ� ����
    public float player_Gold = 0;

    public float PowerBasegold = 5;
    public float HelthBasegold = 5;
    public float RecoveryBasegold = 5;
    public float CriticalhitBasegold = 5;
    public float CriticalBasegold = 5;


    public float PlayerPowerLv = 1;
    public float PlayerHelthLv = 1;
    public float PlayerRecoveryLv = 1;
    public float PlayerCriticalhitLv = 1;
    public float PlayerCriticalLv = 1;

    public float Power = 5;
    public float Helth = 0;
    public float Recovery = 5;
    public float Criticalhit = 1;
    public float Critical = 1;

    public float nextPower = 10;
    public float nextHelth = 5;
    public float nextRecovery = 10;
    public float nextCriticalhit = 2;
    public float nextCritica = 2;



    public GameObject monstar;

    private Animator animators;
    private GameObject taget;
    public string enemyTag = "Enemy";
    public string bossTag = "Boss";
    private Vector3 Move;
    [SerializeField]
    public float Speed = 15f;

    [SerializeField]
    private float attackDamge = 20f;
    private void Awake()
    {

        Move = Vector3.right;
    }
    void Start()
    {

        Player_Lv = GameManager.instance.player_LV;
        Player_Exp = GameManager.instance.player_EXP;
        XP = GameManager.instance.player_XP;
        player_Gold = GameManager.instance.player_gold;

        

        animators = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Move * Speed * Time.deltaTime;

        attackDamge = 20 + Power;

     
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == enemyTag)
        {
            animators.SetInteger("AnimState", 1);
            taget = collision.gameObject;
            Speed = 0f;
            //Debug.Log("���� ������");
        }
        else if (collision.gameObject.tag == bossTag)
        {
            animators.SetInteger("AnimState", 1);
            taget = collision.gameObject;
            Speed = 0f;
            Debug.Log("������ ������");
        }
        if(collision.gameObject.tag == "Item")
        {
            //���߿� �ι� �̺�Ʈ ���� if�� on�϶� 2�� off x
            var py = monstar.GetComponent<IDamage>();//ƨ���� ������
            //Debug.Log("���� �Ա�");
            Destroy(collision.gameObject);
            player_Gold += py.monsterGold;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
            animators.SetInteger("AnimState", 2);
            Speed = 15f;


        
    }
    public void AttackDamage()
    {
        if (taget != null && taget.gameObject.tag == enemyTag)
        {
            taget.transform.GetComponent<IDamage>().MonstartDelete(attackDamge);
            //Debug.Log("���Ͱ���");
        }
        else if(taget != null && taget.gameObject.tag ==enemyTag)
        {
            taget.transform.GetComponent<GoldBox>().Box(attackDamge);
            Debug.Log("�ڽ� ����");
        }
        /*
        if (taget != null && taget.gameObject.tag == bossTag)
        {
            taget.transform.GetComponent<IDamage>().BossDelete(attackDamge);
            Debug.Log("��������");
        }*/
    }




    public void Player_EXP()
    {
        XP = Player_Lv * 100;
    }
    public void Level_UP()
    {
        if (Player_Exp >= XP)
        {
            Player_Exp -= XP;
            Player_Lv++;
            Player_EXP();
            Debug.Log("Level Up");
            //������ �� ���� ����Ʈ 3�� �ֱ� ���߿� ����
        }
    }
    public void onclikPower()
    {
        if (player_Gold >= PowerBasegold)
        {
            player_Gold -= PowerBasegold;
            PlayerPowerLv++;
            powerUp();
            Debug.Log("������");
            //��� �� ���� ������
        }
    }  
    public void onclikHealths()
    {
        if (player_Gold >= HelthBasegold)
        {
            player_Gold -= HelthBasegold;
            PlayerHelthLv++;
            HealthUp();
            Debug.Log("������");
            //��� �� ���� ������
        }
    } 
    public void onclikRecoverys()
    {
        if (player_Gold >= RecoveryBasegold)
        {
            player_Gold -= RecoveryBasegold;
            PlayerRecoveryLv++;
            RecoveryUp();
            Debug.Log("������");
            //��� �� ���� ������
        }
    }  
    public void onclikCriticalhits()
    {
        if (player_Gold >= CriticalhitBasegold)
        {
            player_Gold -= CriticalhitBasegold;
            PlayerCriticalhitLv++;
            criticalhitUp();
            Debug.Log("������");
            //��� �� ���� ������
        }
    }   
    public void onclikCriticals()
    {
        if (player_Gold >= CriticalBasegold)
        {
            player_Gold -= CriticalBasegold;
            PlayerCriticalLv++;
            criticalUp();
            Debug.Log("������");
            //��� �� ���� ������
        }
    }
    public void powerUp()
    {
        PowerBasegold = PowerBasegold + 5;
        nextPower = nextPower + 5;
        Power = Power + 5;
    }  
    public void HealthUp()
    {
        HelthBasegold = HelthBasegold + 5;
        nextHelth = nextHelth + 5;
        Helth = Helth + 5;
        playerMaxHP = Helth + 5;
    }   
    public void RecoveryUp()
    {
        RecoveryBasegold = RecoveryBasegold + 5;
        nextRecovery = nextRecovery + 5;
        Recovery = Recovery + 5;
    }
    public void criticalhitUp()
    {
        CriticalhitBasegold = CriticalhitBasegold + 5;
        nextCriticalhit = nextCriticalhit + 1;
        Criticalhit = Criticalhit + 1;
    }
    public void criticalUp()
    {
        CriticalBasegold = CriticalBasegold + 5;
        nextCritica = nextCritica + 1;
        Critical = Critical + 1;
    }

    public void BossKonckback(float damageAmount)//, Vector2 directionKonckback) //���� ����
    {
        playerHP -= damageAmount;
    }


    
}
/* 
//���� ������ �ֱ�
monstar.GetComponent<Monstars>().MonstarHP -= attackDamge;
���ݹ����� ������ �����ϰ� ������ �ٽ� �����̱�
�������� ���� �����ϰ� �ڿ� Trigger ������ �����ϰ� Restart
*/