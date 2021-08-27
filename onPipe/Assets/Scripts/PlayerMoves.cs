using UnityEngine;

public class PlayerMoves : MonoBehaviour
{
    public PlayerMoves instance;
    public static bool isMove;
    private float playerSpeed = 6.0f;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        isMove = true;
    }

    void Update()
    {
        //oyun bittiðinde player'ýn hýzýný 0'lýyorum.
        if (isMove == true)
            transform.Translate(0, playerSpeed * Time.deltaTime, 0);
        else
            playerSpeed = 0;
    }

}
