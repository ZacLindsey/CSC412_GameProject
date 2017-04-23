using UnityEngine;
using System.Collections;

public class ChangeDirection : MonoBehaviour
{

    public Vector3 newDirection1 = new Vector3();
    public Vector3 newDirection2 = new Vector3();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        EnemyUnit eu = other.gameObject.GetComponent<EnemyUnit>();
        int dir = Random.Range(0, 2);

        if (eu != null)
        {
            if (dir == 0)
            {
                eu.speed.x = newDirection1.x;
                eu.speed.y = newDirection1.y;
                eu.speed.z = newDirection1.z;
            }
            else if (dir == 1)
            {
                eu.speed.x = newDirection2.x;
                eu.speed.y = newDirection2.y;
                eu.speed.z = newDirection2.z;
            }
        }
    }
}
