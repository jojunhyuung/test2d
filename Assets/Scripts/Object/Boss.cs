    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

public class Boss : IDamage
{ 
    [SerializeField]
    private GameObject taget;
    
    public Transform playhudPos;

    public string enemyTag = "Player";

    private void Start()
    {
        
    }
    private void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.gameObject.tag == enemyTag)
            {
                taget = collision.gameObject;

                animators.SetInteger("BossState", 1);
                Debug.Log("플레이어를 만났다");
            }
    }
    public void AttackDamage()
    {
        if (taget != null && taget.gameObject.tag == enemyTag)
        {
            taget.transform.GetComponent<Player>().BossKonckback(monstersDamge);
            Debug.Log("몬스터공격");
        }
    }

}
