using UnityEngine;
using System.Collections;

public class DetectEnd : MonoBehaviour {

    public GameObject cartel;
    public MoveCharacter move;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "CardboardMain")
        {
            cartel.SetActive(true);
            move.Finish();
        }
    }
}
