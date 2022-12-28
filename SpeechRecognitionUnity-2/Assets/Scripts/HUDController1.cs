using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class HUDController1 : MonoBehaviour
{

    public TextMeshProUGUI timerText;
    float startTime = Time.time;
    public TextMeshProUGUI countText;
    private int count = 0;
    public Image healthBar;
    public GameObject player;
    public static int scoreValue = 0;
    public TextMeshProUGUI score;
    public GameObject HealthIncrease;
    public GameObject GameOver;
    public TextMeshProUGUI endOfGameText;
    private bool endOfGame;




    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        score = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString("00");
        string seconds = (t % 60).ToString("00");
        timerText.text = $"{minutes}:{seconds}";

        healthBar.fillAmount -= 0.02f * Time.deltaTime;

        score.text = "Score:" + scoreValue;

        if (healthBar.fillAmount <= 0 * Time.deltaTime)

        {
            SceneManager.LoadScene("GameOver");
        }

        else

            SceneManager.LoadScene(1);

    }


    public void IncrementCount()
    {
        count++;
        countText.text = count.ToString();
    }

    public void ReduceHealth()
    {
        healthBar.fillAmount -= 0.1f;
    }

    public void InceaseHealth()
    {
        healthBar.fillAmount += 0.5f;
        Debug.Log(gameObject.name + " gained Health");
    }

    public void BallSize(float sliderVal)
    {
        player.transform.localScale = new Vector3(sliderVal, sliderVal, sliderVal);
    }
}
   
