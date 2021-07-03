using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{
    private float HeightVarience = 1f;
     
    void Update()
    {
        transform.position += Vector3.up * Mathf.Sin(Time.time) * Time.deltaTime * HeightVarience;
    }
}
