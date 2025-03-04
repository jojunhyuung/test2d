using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger : MonoBehaviour
{
    public SceneFader fader;
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        player.transform.position = new Vector3(-60,0,0);
        
    }
    
}
