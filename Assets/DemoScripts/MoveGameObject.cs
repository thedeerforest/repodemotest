using UnityEngine;

public class MoveGameObject: MonoBehaviour
{
    // The speed that the GameObject will move
    public float _speed = 1.25f;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            transform.position += (Vector3.right * _speed) * Time.deltaTime;
        }
        // Move the GameObject to the right this frame

        if (Input.GetKey("up"))
        {
            transform.position += (Vector3.up * _speed) * Time.deltaTime;
        }

        if (Input.GetKey("down"))
        {
            transform.position += (Vector3.down * _speed) * Time.deltaTime;
        }

        if (Input.GetKey("left"))
        {
            transform.position += (Vector3.left * _speed) * Time.deltaTime;
        }

    }
}
