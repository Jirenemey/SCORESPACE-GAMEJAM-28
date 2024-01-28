using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI comboText;
    public Leaderboard leaderboard;
    private int combo;
    private int score;
    private int accuracy;
    public float songSpeed;
    private float timer = 0.0f;
    private float waitTime = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        songSpeed = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > waitTime){
            songSpeed += 0.1f;
            timer = 0.0f;
        }
        
    }

    public void updateScore(){
        score += 200 + (accuracy * combo);
    }

    void OnCollisionStay(Collision collision){
        if (Input.GetKeyDown("space")){
            Debug.Log("Space pressed on collision");
            updateScore();
            Death();
        }
    }

    IEnumerator Death(){
        Time.timeScale = 0f;
        yield return new WaitForSeconds(1f);
        yield return leaderboard.SubmitScoreRoutine(score);
        Time.timeScale = 1f;
    }
}
