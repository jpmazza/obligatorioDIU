using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour
{

    public float speed = 40f;
    public bool walkEnabled = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;*/

        if (walkEnabled)
        {
            CharacterController controller = GetComponent<CharacterController>();
            Vector3 moveDirection = new Vector3();
            if (controller.isGrounded)
            {
                moveDirection = Camera.main.transform.forward;
                moveDirection *= speed;
            }
            controller.Move(moveDirection * Time.deltaTime);
        }
    }

    public void ChangeWalkEnabled()
    {
        walkEnabled = !walkEnabled;
    }



}
