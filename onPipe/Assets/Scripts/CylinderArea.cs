
using System.Collections;
using UnityEngine;

public class CylinderArea : MonoBehaviour
{
    public bool isScale;

    //hareket halindeki oyuncu
    public GameObject player;

    //oyuncunun yeri ve olcegi
    private float playerPlace;
    Vector3 scalePlayer;



    private void Start()
    {
        playerPlace = player.transform.position.y;
        scalePlayer = player.transform.localScale;
    }

    void Update()
    {
        //player'�n konumunu al�yorum.
        playerPlace = player.transform.position.y;

        //player'�n konumunun hangi sutun uzerinde olacag�n� buluyorum.
        int childObjectCount = (((int)playerPlace) / 8);

        if (Input.GetMouseButton(0))
        {
            //kendinden sonraki objenin scale'�n x'inden b�y�k veya esit ise oyuna devam eder.
            if (transform.GetChild(childObjectCount).transform.localScale.x >= transform.GetChild(childObjectCount + 1).localScale.x)
            {
                StartCoroutine(changeScale(transform.GetChild(childObjectCount).transform.localScale / 2)) ;
            }
            else 
            {
                //kendinden genis bi sonraki objeye degerse oyun biter.
                if (playerPlace > ((childObjectCount + 1) * 8)-0.5f && playerPlace <= (childObjectCount + 1) * 8)
                {
                    FindObjectOfType<GameManager>().EndGame();


                }
                StartCoroutine(changeScale(transform.GetChild(childObjectCount).transform.localScale / 2));
            }
        }
        else
        {
            //ekrana bas�l� tutmuyor isem player'�n normal scale �l��s�ne d�nd�r�yorum.
            StartCoroutine(changeScale(scalePlayer));
        }
    }
    private IEnumerator changeScale(Vector3 scale)
    { 
       if(!isScale)
        {
            isScale = true;
            var totalTime = 0.14f;
            var time = 0f;
            while (time <= 1.0)
            {
                time += Time.deltaTime / totalTime;
                player.transform.localScale = Vector3.Lerp(player.transform.localScale, scale, Mathf.SmoothStep(0f, 1f, time));
                yield return null;
            }
            isScale = false;
        }
    }
 
}
