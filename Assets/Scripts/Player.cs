using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI comboText;
    public TextMeshProUGUI livesText;
    public Leaderboard leaderboard;
    private int combo;
    private int score;
    private int accuracy;
    public float songSpeed;
    public int lives = 3;
    private float timer = 0.0f;
    private float waitTime = 10.0f;
    public Obstacle hitCheck;

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
        
        scoreText.text = score.ToString();
        comboText.text = combo.ToString();
        livesText.text = lives.ToString();

        if(lives == 0){
            StartCoroutine(Death());
        }
    }

    public void updateScore(){
        score += 200 + (accuracy * combo);
    }

    void OnTriggerStay2D(Collider2D collision){
        hitCheck = collision.gameObject.GetComponent<Obstacle>();
        if(hitCheck != null){
            if (Input.GetMouseButtonDown(0) && hitCheck.hit == false){
                AudioManager.Instance.PlaySFX("HitSound");
                Debug.Log("Space pressed on collision");
                updateScore();
                combo++;
                hitCheck.hit = true;
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision){
        hitCheck = collision.gameObject.GetComponent<Obstacle>();
        if(hitCheck != null){
            if(hitCheck.hit == false){
                combo = 0;
                lives--;
                }
            }
        }

    IEnumerator Death(){
        Time.timeScale = 0f;
        yield return new WaitForSeconds(1f);
        yield return leaderboard.SubmitScoreRoutine(score);
        Time.timeScale = 1f;
    }
}
