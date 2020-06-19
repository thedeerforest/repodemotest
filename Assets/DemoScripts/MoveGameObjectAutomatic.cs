using UnityEngine;

public class MoveGameObjectAutomatic: MonoBehaviour
{
    // The speed that the GameObject will move
    public float _speed = 3;
    
    // Update is called once per frame
    void Update()
    {
        // Move the GameObject to the right this frame
        transform.position += (Vector3.right * _speed) * Time.deltaTime;
             
    }
}
