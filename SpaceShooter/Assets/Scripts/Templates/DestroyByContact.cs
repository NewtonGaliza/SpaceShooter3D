using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    ////meu GO explos�o
    //public GameObject asteroidExplosion;
    //public GameObject playerExplosion;

    ////Pontua��o para cada asteroide destru�do
    //private int scoreValue= 10;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (GameController.gc != null)
    //    {
    //        GameController.gc.UpdateScore();
    //    }

    //    //Se for o GO Boundary n�o fa�a nada
    //    //caso contr�rio destrua o m�ssil e o asteroide
    //    if (other.tag == "Boundary")
    //    {
    //        return;
    //    }

    //    if (other.tag == "Player")
    //    {
    //        GameObject player = Instantiate(playerExplosion, transform.position, transform.rotation) as GameObject;
    //        GameController.gc.GameOver();
    //    }

    //    //Cria a explos�o no ponto certo
    //    GameObject asteroid = Instantiate(asteroidExplosion, transform.position, transform.rotation) as GameObject;

    //    //gameController.AddScore(scoreValue);
    //    GameController.gc.AddScore(scoreValue);

    //    //Debug.Log(other.gameObject);
    //    //Destr�i o m�ssil
    //    Destroy(other.gameObject);
    //    //Destr�i o asteroide
    //    Destroy(gameObject);
    //}
}
