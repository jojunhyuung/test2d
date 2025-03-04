using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int player_LV = 1;
    public float player_EXP = 0;
    public float player_XP = 100;
    public float player_gold = 0;
    public float basegold = 0;

    public float playerPowerLv = 1;
    public float playerHelthLv = 1;
    public float playerRecoveryLv = 1;
    public float playerCriticalhitLv = 1;
    public float playerCriticalLv = 1;

    public float power = 5;
    public float helth = 10;
    public float recovery = 5;
    public float criticalhit = 1;
    public float critical = 1;

    public float NextPower = 10;
    public float NextHelth = 15;
    public float NextRecovery = 10;
    public float NextCriticalhit = 2;
    public float NextCritical = 2;



    public static GameManager instance; //����
    public GameObject player;
    public GameObject monsters;
    private void Awake()
    {
        if (instance == null) //instance�� null. ��, �ý��ۻ� �����ϰ� ���� ������
        {
            instance = this; //���ڽ��� instance�� �־��ݴϴ�.
            DontDestroyOnLoad(gameObject); //OnLoad(���� �ε� �Ǿ�����) �ڽ��� �ı����� �ʰ� ����
        }
        else
        {
            if (instance != this) //instance�� ���� �ƴ϶�� �̹� instance�� �ϳ� �����ϰ� �ִٴ� �ǹ�
                Destroy(this.gameObject); //�� �̻� �����ϸ� �ȵǴ� ��ü�̴� ��� AWake�� �ڽ��� ����
        }
    }
    public void GetPlyer()
    {
        //�ɷ�ġ ���� �޾ƿ���
        playerPowerLv = player.GetComponent<Player>().PlayerPowerLv;
        playerHelthLv = player.GetComponent<Player>().PlayerHelthLv;
        playerRecoveryLv = player.GetComponent<Player>().PlayerRecoveryLv;
        playerCriticalhitLv = player.GetComponent<Player>().PlayerCriticalhitLv;
        playerCriticalLv = player.GetComponent<Player>().PlayerCriticalLv;
        //�ɷ�ġ �޾ƿ���
        power = player.GetComponent<Player>().Power;
        helth = player.GetComponent<Player>().Helth;
        recovery = player.GetComponent<Player>().Recovery;
        criticalhit = player.GetComponent<Player>().Criticalhit;
        critical = player.GetComponent<Player>().Critical;
        NextPower = player.GetComponent<Player>().nextPower;
        NextHelth = player.GetComponent<Player>().nextHelth;
        NextRecovery = player.GetComponent<Player>().nextRecovery;
        NextCriticalhit = player.GetComponent<Player>().nextCriticalhit;
        NextCritical = player.GetComponent<Player>().nextCritica;


    }
    public void GetExp()
    {
        //�÷��̾� ���� ����ġ �޾ƿ���
        player_LV = player.GetComponent<Player>().Player_Lv;
        player_EXP = player.GetComponent<Player>().Player_Exp;
        player_XP = player.GetComponent<Player>().XP;
    }
    public void GetGold()
    {
        //�÷��̾� ��� �޾ƿ���
        player_gold = player.GetComponent<Player>().player_Gold;
    }

    //escŰ �����
}
