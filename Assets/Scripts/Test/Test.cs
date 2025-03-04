using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Test : MonoBehaviour
{
    public List<GameObject> FoundObjects;
    public GameObject enemy;
    public string TagName;
    public float shortDis;
    public Transform target;
    public float Speed = 5f;


    void Start()
    {
        FoundObjects = new List<GameObject>(GameObject.FindGameObjectsWithTag("Enemy"));
        shortDis = Vector3.Distance(gameObject.transform.position, FoundObjects[0].transform.position); // ù��°�� �������� ����ֱ� 

        enemy = FoundObjects[0]; // ù��°�� ����

        foreach (GameObject found in FoundObjects)
        {
            float Distance = Vector3.Distance(gameObject.transform.position, found.transform.position);

            if (Distance < shortDis) // ������ ���� �������� �Ÿ� ���
            {
                enemy = found;
                shortDis = Distance;
            }
        }
        Debug.Log(enemy.name);
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
    }
}

