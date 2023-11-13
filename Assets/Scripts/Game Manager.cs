using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI livesText;
     public int lives;

     public int lossLife;


    void Start()
    {
        lives = 3;
        livesText.text = "Lives: " + lives;

    }

    // Update is called once per frame
    void Update()
    {
      
    }
     
     public void subtractLife ()
     {
        lossLife = 1;
        lives = lives - lossLife;
        livesText.text = "Lives: " + lives;


  }
    
}
