using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    private Vector3 backOffset = new Vector3(0, 4, -9);
    private Vector3 frontOffset = new Vector3(0, 4, 12);
    private Vector3 frontAngle1 = new Vector3(0, 0, 0);
    private Vector3 backAngle1 = new Vector3(0, 180, 0);
    public bool keyInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

        if (Input.GetButtonDown("p"))
        {
            keyInput = !keyInput;
        };

        if (keyInput)
        {
            //offset camera behind the player by adding to the player's position
            transform.localPosition = backOffset;
            transform.eulerAngles = Player.transform.eulerAngles + backAngle1;
        }
        transform.localPosition = frontOffset;
        transform.eulerAngles = Player.transform.eulerAngles + frontAngle1 ;
    }
}
