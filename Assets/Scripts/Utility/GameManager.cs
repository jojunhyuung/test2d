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



    public static GameManager instance; //접근
    public GameObject player;
    public GameObject monsters;
    private void Awake()
    {
        if (instance == null) //instance가 null. 즉, 시스템상에 존재하고 있지 않을때
        {
            instance = this; //내자신을 instance로 넣어줍니다.
            DontDestroyOnLoad(gameObject); //OnLoad(씬이 로드 되었을때) 자신을 파괴하지 않고 유지
        }
        else
        {
            if (instance != this) //instance가 내가 아니라면 이미 instance가 하나 존재하고 있다는 의미
                Destroy(this.gameObject); //둘 이상 존재하면 안되는 객체이니 방금 AWake된 자신을 삭제
        }
    }
    public void GetPlyer()
    {
        //능력치 레벨 받아오기
        playerPowerLv = player.GetComponent<Player>().PlayerPowerLv;
        playerHelthLv = player.GetComponent<Player>().PlayerHelthLv;
        playerRecoveryLv = player.GetComponent<Player>().PlayerRecoveryLv;
        playerCriticalhitLv = player.GetComponent<Player>().PlayerCriticalhitLv;
        playerCriticalLv = player.GetComponent<Player>().PlayerCriticalLv;
        //능력치 받아오기
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
        //플레이어 레벨 경험치 받아오기
        player_LV = player.GetComponent<Player>().Player_Lv;
        player_EXP = player.GetComponent<Player>().Player_Exp;
        player_XP = player.GetComponent<Player>().XP;
    }
    public void GetGold()
    {
        //플레이어 골드 받아오기
        player_gold = player.GetComponent<Player>().player_Gold;
    }

    //esc키 만들기
}
