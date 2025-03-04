using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AttackZone : MonoBehaviour
{
    private Animator animator;
    //°ø°Ý·Â
    [SerializeField]
    private float attackDamage = 10f;

    [SerializeField]
    private Vector2 knockback = Vector2.zero;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}

