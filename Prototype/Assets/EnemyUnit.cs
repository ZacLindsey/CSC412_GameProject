using UnityEngine;
using System.Collections;

public class EnemyUnit : MonoBehaviour
{

    public float health;
    public Vector3 speed = new Vector3();

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward + speed;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + speed;
    }

    public void explode()
    {
        Destroy(gameObject);
    }

}
