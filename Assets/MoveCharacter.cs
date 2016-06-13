using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour
{

    public float speed = 40f;
    public bool walkEnabled = true;
    public bool finish = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

        if (!finish && walkEnabled)
        {
            Vector3 pos = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
            pos.y = 23;
            transform.position = pos;
           /* CharacterController controller = GetComponent<CharacterController>();
            Vector3 moveDirection = new Vector3();
            if (controller.isGrounded)
            {
                moveDirection = Camera.main.transform.forward;
                moveDirection *= speed;
            }
            controller.Move(moveDirection * Time.deltaTime);*/
        }
    }

    public void ChangeWalkEnabled()
    {
        walkEnabled = !walkEnabled;
    }

    public void Finish()
    {
        finish = true;
    }

}
