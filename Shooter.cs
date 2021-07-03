using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab;

    void Update()
    {
       if(Input.GetButtonDown("Fire1"))
        {

            var projectile = Instantiate(

                 projectilePrefab,

                 new Vector3(projectilePrefab.transform.position.x, transform.position.y, 0),

                 projectilePrefab.transform.rotation);
        }
    }
}
