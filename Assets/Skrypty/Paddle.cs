using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenUnits;
    // Start is called before the first frame update
    void Start()
    {
		Cursor.visible = false;
	}

    // Update is called once per frame
    void Update()
    {
		Debug.Log(Input.mousePosition.x / Screen.width * screenUnits);
        //Debug.Log((Input.mousePosition.x / Screen.width * screenUnits));
        float mousePosInUnits = (Input.mousePosition.x / Screen.width * screenUnits);
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, -1.5f, 16.5f);
        transform.position = paddlePos;
    }
}
