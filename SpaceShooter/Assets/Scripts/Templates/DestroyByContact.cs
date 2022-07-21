using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    ////meu GO explosão
    //public GameObject asteroidExplosion;
    //public GameObject playerExplosion;

    ////Pontuação para cada asteroide destruído
    //private int scoreValue= 10;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (GameController.gc != null)
    //    {
    //        GameController.gc.UpdateScore();
    //    }

    //    //Se for o GO Boundary não faça nada
    //    //caso contrário destrua o míssil e o asteroide
    //    if (other.tag == "Boundary")
    //    {
    //        return;
    //    }

    //    if (other.tag == "Player")
    //    {
    //        GameObject player = Instantiate(playerExplosion, transform.position, transform.rotation) as GameObject;
    //        GameController.gc.GameOver();
    //    }

    //    //Cria a explosão no ponto certo
    //    GameObject asteroid = Instantiate(asteroidExplosion, transform.position, transform.rotation) as GameObject;

    //    //gameController.AddScore(scoreValue);
    //    GameController.gc.AddScore(scoreValue);

    //    //Debug.Log(other.gameObject);
    //    //Destrói o míssil
    //    Destroy(other.gameObject);
    //    //Destrói o asteroide
    //    Destroy(gameObject);
    //}
}
