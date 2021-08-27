using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngelCarpma : MonoBehaviour
{
    public ParticleSystem deathParticle;

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag=="Engel")
        {
            FindObjectOfType<GameManager>().EndGame();
            DestroyPlayer();
        }
        else if (other.gameObject.tag == "Corns")
        {
            Destroy(other.gameObject);
            Score.explosionCorns++;
        }

        //son halkaya geldiðinde
        else if (other.gameObject.tag == "Finish")
        {
            FindObjectOfType<GameManager>().nextLevel();
            gameObject.SetActive(false); //baska bi efekt tarzý kullanýlabilir.
        }
    }

    private void DestroyPlayer()
    {
        gameObject.SetActive(false);
        deathParticle.transform.position = transform.position + new Vector3(0, transform.localScale.y, 0);

        deathParticle.Play();

    }
}
