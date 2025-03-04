using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class UIManager : Player
{
    [SerializeField]
    private string loadToScene = "Boss";

    //public GameObject lV;
    //public GameObject Gold;
    public GameObject slider;
    public GameObject player;

    public Slider ExpBar;

    public TextMeshProUGUI Lv_txt;
    public TextMeshProUGUI NeedExp;
    public TextMeshProUGUI gold_txt;
    //구현
    public TextMeshProUGUI Power_Lvtxt;
    public TextMeshProUGUI Health_Lvtxt;
    public TextMeshProUGUI Recovery_Lvtxt;
    public TextMeshProUGUI Criticalhit_Lvtxt;
    public TextMeshProUGUI Critical_Lvtxt;

    public TextMeshProUGUI PowerButtonText;
    public TextMeshProUGUI HealthButtonText;
    public TextMeshProUGUI RecoveryButtonText;
    public TextMeshProUGUI CriticalhitButtonText;
    public TextMeshProUGUI CriticalButtonText; 
    
    public TextMeshProUGUI NowPower;
    public TextMeshProUGUI NowHealth;
    public TextMeshProUGUI NowRecovery;
    public TextMeshProUGUI NowCriticalhit;
    public TextMeshProUGUI NowCritical; 

    public int player_LV;
    public float player_EXP;
    public float player_XP;
    public float player_gold;

    public float player_PowerBasegold;
    public float player_HelthBasegold;
    public float player_RecoveryBasegold;
    public float player_CriticalhitBasegold;
    public float player_CriticalBasegold;

    //캐릭터 능력치 받아서 와서 정보 저장
    public float player_Power;
    public float player_nextPower;

    public float player_Helth;
    public float player_nextHelth;

    public float player_Recovery;
    public float player_nextRecovery;

    public float player_Criticalhit;
    public float player_nextCriticalhit;

    public float player_Critical;
    public float player_nextCritical;

    //누를때 베이스골드 증가



    // Start is called before the first frame update
    void Start()
    {
        //lV = GameObject.Find("LvManager").transform.Find("LV").gameObject; ;
        //slider = GameObject.Find("LvManager").transform.Find("Slider").gameObject;
        //Lv_txt = lV.GetComponent<TextMeshProUGUI>();
        //gold_txt = Gold.GetComponent<TextMeshProUGUI>();
        player = GameObject.Find("Player");
        ExpBar = slider.GetComponent<Slider>();


    }

    // Update is called once per frame
    void Update()
    {
        Level();
        LevelBar();
        text();
    }
    public void Level()
    {
        player_LV = player.GetComponent<Player>().Player_Lv;
        player_EXP = player.GetComponent<Player>().Player_Exp;  //현재 경험치
        player_XP = player.GetComponent<Player>().XP;           //레벨업에 필요한 경험치
        player_gold = player.GetComponent<Player>().player_Gold;
        //레벨 정보 받아오기
        PlayerPowerLv = player.GetComponent<Player>().PlayerPowerLv;
        PlayerHelthLv = player.GetComponent<Player>().PlayerHelthLv;
        PlayerRecoveryLv = player.GetComponent<Player>().PlayerRecoveryLv;
        PlayerCriticalhitLv = player.GetComponent<Player>().PlayerCriticalhitLv;
        PlayerCriticalLv = player.GetComponent<Player>().PlayerCriticalLv;

        //베이스 골드 받아오기
        player_PowerBasegold = player.GetComponent<Player>().PowerBasegold;
        player_HelthBasegold = player.GetComponent<Player>().HelthBasegold;
        player_RecoveryBasegold = player.GetComponent<Player>().RecoveryBasegold;
        player_CriticalhitBasegold = player.GetComponent<Player>().CriticalhitBasegold;;
        player_CriticalBasegold = player.GetComponent<Player>().CriticalBasegold;

        player_Power = player.GetComponent<Player>().Power; //플레이어 힘 가져오기
        player_nextPower = player.GetComponent<Player>().nextPower; 
        player_Helth = player.GetComponent<Player>().Helth; //플레이어 체력 가져오기
        player_nextHelth = player.GetComponent <Player>().nextHelth;

        player_Recovery = player.GetComponent <Player>().Recovery;     //플레이어 회복량 가져오기
        player_nextRecovery = player.GetComponent <Player>().nextRecovery;

        player_Criticalhit = player.GetComponent <Player>().Criticalhit;  //플레이어 크리티컬 공격력 가져오기
        player_nextCriticalhit = player.GetComponent <Player>().nextCriticalhit;

        player_Critical = player.GetComponent <Player>().Critical;     //플레이어 크리확률 가져오기
        player_nextCritical = player.GetComponent <Player>().nextCritica;




}

    public void LevelBar()
    {
        gold_txt.text = player_gold.ToString();
        ExpBar.value = player_EXP / player_XP;
    }
    public void text()
    {
        NeedExp.text = player_EXP.ToString() + "    /   " + player_XP.ToString();

        Lv_txt.text = "Lv" + player_LV;
        Power_Lvtxt.text = "Lv" + PlayerPowerLv;
        Health_Lvtxt.text = "Lv" + PlayerHelthLv;
        Recovery_Lvtxt.text = "Lv" + PlayerRecoveryLv;
        Criticalhit_Lvtxt.text = "Lv" + PlayerCriticalhitLv;
        Critical_Lvtxt.text = "Lv" + PlayerCriticalLv;
        //베이스 골드 텍스트
        PowerButtonText.text = player_PowerBasegold.ToString();
        HealthButtonText.text = player_HelthBasegold.ToString();
        RecoveryButtonText.text = player_RecoveryBasegold.ToString();
        CriticalhitButtonText.text = player_CriticalhitBasegold.ToString();
        CriticalButtonText.text = player_CriticalBasegold.ToString();

        NowPower.text = player_Power.ToString() + "  ->  " + player_nextPower.ToString();
        NowHealth.text = player_Helth.ToString() + "  ->  " + player_nextHelth.ToString();
        NowRecovery.text = player_Recovery.ToString() + "  ->  " + player_nextRecovery.ToString();
        NowCriticalhit.text = player_Criticalhit.ToString() + "  ->  " + player_nextCriticalhit.ToString();
        NowCritical.text = player_Critical.ToString()+ "  ->  " + player_nextCritical.ToString();
    }
    public void onclikBoss()
    {
        GameManager.instance.GetExp();
        GameManager.instance.GetPlyer();
        GameManager.instance.GetGold();
        SceneManager.LoadScene(loadToScene);
    }
    //공격력 체력 체력회복량 치명타 확률 치명타 구현
}

//게임 오브젝트 