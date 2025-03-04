using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public SceneFader fader;
    public GameObject player;
    public Transform[] sqwanPoint;
    public GameObject enemy;
    [SerializeField]
    public int sqwanMonstars = 0;
    // Update is called once per frame
    private void Start()
    {
        SpawnEnemy();
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpawnEnemy();
        player.transform.position = new Vector3(-60, 8.110001f, 0);
    }
    public void SpawnEnemy()
    {
        for (int i = 0; i < sqwanMonstars; i++)
        {
            GameObject obj = Instantiate(enemy, sqwanPoint[i].position, Quaternion.Euler(new Vector3(0, 180, 0)));
            obj.transform.GetComponent<IDamage>().player = GameManager.instance.player;
        }

    }
}
