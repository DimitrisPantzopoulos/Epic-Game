using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject LoseScreen;
    public GameObject San;
    public GameObject WinScreen;
    public GameObject WinObject;
    public Pla Sans;

    // Start is called before the first frame update
    void Start()
    {
        LoseScreen.SetActive(false);
        WinScreen.SetActive(false);
        San = GameObject.FindGameObjectWithTag("Player");
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(San.transform.position.y < -15){
            GameOver();
        }
        if(San.transform.position.x > 77){
            Win();
        }
        if(Sans.Health <= 0){
            GameOver();

        }
    }

    public void GameOver(){
        LoseScreen.SetActive(true);
        Time.timeScale = 0f;

    }

    public void Win(){
        WinScreen.SetActive(true);
        Time.timeScale = 0f;

    }
    


}
