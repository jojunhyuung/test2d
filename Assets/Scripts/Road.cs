using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField]
    List<GameObject> MonsterList = new List<GameObject>();
    public GameObject player; 
    [SerializeField]
    private float moveSpeed = 5f;
    [SerializeField]
    private float groundMove = 100f;
    [SerializeField]
    private float stopMove = 5f;
    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(player.transform.position, gameObject.transform.position) < stopMove)
        {
            moveSpeed = 0f;
        }
        transform.Translate(Vector3.left * Time.deltaTime * moveSpeed, Space.World);
    }
}