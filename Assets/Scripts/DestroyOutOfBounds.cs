using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float _topBound = 18;
    private float _lowerBound = -5;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        if (transform.position.z > _topBound)
        {
            Destroy(this.gameObject);
        }

        else if (transform.position.z < _lowerBound)
        {
            Destroy(this.gameObject);
        }
    }
}
