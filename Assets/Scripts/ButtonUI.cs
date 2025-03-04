using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI : MonoBehaviour
{
    public GameObject InventoryUI;
    public GameObject ExpUI;
    public GameObject player;

    public float playerPowerLv = 1;

    public float player_gold = 0;
    public float powerbasegold = 0;

    private void Start()
    {


    }
    private void Update()
    {
        player_gold = player.GetComponent<Player>().player_Gold;
        powerbasegold = player.GetComponent<Player>().PowerBasegold;
        playerPowerLv = player.GetComponent<Player>().PlayerPowerLv;
    }
    public void onclikEquipment()
    {
        InventoryUI.SetActive(true);
        ExpUI.SetActive(false);

    }
    public void onclikExp()
    {
        ExpUI.SetActive(true);
        InventoryUI.SetActive(false);
    }

    public void onclikHealth()
    {

    }
    public void onclikRecovery()
    {

    }
    public void onclikCriticalhit()
    {

    }
    public void onclikCriticalchance()
    {

    }


}
