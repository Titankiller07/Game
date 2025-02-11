using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static private Text _UI_TEXT;
    static private int _SCORE = 1000;
    private Text txtCom;
    
    void Awake(){
        _UI_TEXT = this.GetComponent<Text>();
        if (PlayerPrefs.HasKey("HighScore"))
        {
            SCORE = PlayerPrefs.GetInt("HighScore");
        }
        PlayerPrefs.SetInt("HighScore", SCORE);
    }
    static public int SCORE{
        get{
            return(_SCORE);
        }
        private set{
            _SCORE = value;
            PlayerPrefs.SetInt("HighScore", value);
            if(_UI_TEXT != null){
                _UI_TEXT.text = "High Score: " + value.ToString("#,0");
            }
        }
    }
    static public void TRY_SET_NEW_HIGH_SCORE(int scoreToTry){
        if(scoreToTry <= SCORE)return;
            SCORE = scoreToTry;
    }

    [Tooltip("Check this box to reset the HighScore to 1000")]
    public bool resetHighScore = false;

    void OnDrawGizmos(){
        if (resetHighScore){
            resetHighScore = false;
            PlayerPrefs.SetInt("HighScore", 1000);
            Debug.LogWarning("PlayerPrefs HighScore reset to 1000");
        }
    }
}
