using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class GoldBox : IDamage
{

    private void Start()
    {
        animators = GetComponent<Animator>();
    }
    public void Box(float damageAmount)
    {
        GameObject hudText = Instantiate(hudDamageText);
        hudText.transform.position = hudPos.position;
        hudText.GetComponent<DamageText>().damage = damageAmount;

        monstersHP -= damageAmount;

        if (monstersHP <= 0)
        {

            var py = player.GetComponent<Player>();
            py.Player_Exp += monstersExp;
            for(int i = 0; i < 5; i++)
            {
                Instantiate(gold, coinPos.transform.position, coinPos.transform.rotation);
            }
            Destroy(gameObject);
        }
    }
}