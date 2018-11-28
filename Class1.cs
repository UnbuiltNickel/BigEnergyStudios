using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject player;
    public GameObject enemy;

    private int score;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<RigidBody>();
    }

    private void Update()
    {
        rb.Translate(Vector3.up);

        if(something)
        {
            something();
        }

        for(int i = 0; i < somethijng; i++)
        {

        }
    }
}