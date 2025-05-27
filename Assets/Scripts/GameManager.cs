using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject winPanel;
    public TMP_Text timerText;

    public Image starImage; // “олько один Image дл€ звезды
    public Sprite star1Sprite, star2Sprite, star3Sprite, star4Sprite;

    public float[] starThresholds = { 60f, 120f }; // <60 Ч 3 звезды, <120 Ч 2, иначе 1

    private float timer = 0f;
    private bool levelFinished = false;

    void Start()
    {
        winPanel.SetActive(false);
        timer = 0f;
        levelFinished = false;
    }

    void Update()
    {
        if (!levelFinished)
        {
            timer += Time.deltaTime;
            UpdateTimerUI();
        }
    }

    void UpdateTimerUI()
    {
        int seconds = (int)(timer % 60);
        int minutes = (int)(timer / 60) % 60;
        int hours = (int)(timer / 3600);
        timerText.text = $"{hours:00}:{minutes:00}:{seconds:00}";
    }

    public void OnAllCarsPlaced()
    {
        levelFinished = true;
        winPanel.SetActive(true);
        UpdateStarSprite();
    }

    void UpdateStarSprite()
    {
        if (timer < starThresholds[0])
            starImage.sprite = star3Sprite;
        else if (timer < starThresholds[1])
            starImage.sprite = star2Sprite;
        else
            starImage.sprite = star1Sprite;
    }
    

}
