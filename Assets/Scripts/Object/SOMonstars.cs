using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[CreateAssetMenu(fileName = "Monstar Date", menuName = "Scriptable Object/Monstar Data", order = int.MaxValue)]
public class SOMonstars : ScriptableObject
{
    /*
    [SerializeField]
    private string monstarName;
    public string MonstarName { get { return monstarName; } }*/
    [SerializeField]
    private int hp;
    public int Hp { get { return hp; } }
    [SerializeField]
    private int damage;
    public int Damage { get { return damage; } }
    [SerializeField]
    private float exp;
    public float Exp{ get { return exp; } }

}
