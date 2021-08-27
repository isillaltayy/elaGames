using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score : MonoBehaviour
{

    public Score instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI lastScoreText;
    public TextMeshProUGUI highScoreText;
    public static int explosionCorns;
    private int howManyCorns;
 

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        explosionCorns = 0;
    }



    void Update()
    {
        //bir sýrada 30 corn olduðu için çarptým
        howManyCorns = explosionCorns * 30;
        scoreText.text = howManyCorns.ToString();

        if(PlayerPrefs.GetInt("Score")<=howManyCorns)
             PlayerPrefs.SetInt("Score", howManyCorns);
        highScoreText.text = PlayerPrefs.GetInt("Score").ToString();
        lastScoreText.text = howManyCorns.ToString();
    }


}
