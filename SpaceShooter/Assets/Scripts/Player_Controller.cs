using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SerializeField]
public class BoundaryGame //limite de movimento do player
{
    public float xMin, xMax, yMin, yMax;
}

public class Player_Controller : MonoBehaviour
{
    //inclinação
    [SerializeField]
    private float tilt = 4;

    //velocidade da nave
    [SerializeField]
    private int speed = 10;

    //limites de tela
    [SerializeField]
    BoundaryGame boundary;

    //corpo rigido da nave
    private Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        //define quem é o corpo da nave
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //armazena os movimentos gorizontais e verticais da nave
        Vector3 moviment = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //define a velocidade de movimento da nave
        rigidbody.velocity = moviment * speed;

    }
}
