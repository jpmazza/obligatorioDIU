using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour
{

    public float speed = 40f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
    }
}
