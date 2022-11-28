using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text MyscoreText;
    public Text highscoreText;
    public int ScoreNum;
    public static Score pi;

    private bool isDead = false;
    public DeathMenu deathMenu;

    

    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "" + ScoreNum;
    }

   

    private void Update()
    {
        if (isDead)
        {
            return;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "score")
        {
            ScoreNum += 1;
            MyscoreText.text = "" + ScoreNum;
            print("gg");
        }
    }

    public void OnDeath()
    {
        isDead = true;
        deathMenu.ToggleEndMenu(ScoreNum);
    }
}
