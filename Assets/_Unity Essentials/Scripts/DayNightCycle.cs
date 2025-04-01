using UnityEngine;

public class DayNightCycle : MonoBehaviour
{

    public float rotationSpeed = 1.0f;


    public float dayDuration = 60.0f;

    

    private float timePassed = 0.0f;

    void Start()
    {
       
        rotationSpeed = Mathf.Abs(rotationSpeed);
    }

    void Update()
    {
        
        float angleToRotate = (360.0f / dayDuration) * Time.deltaTime;

        transform.Rotate(Vector3.right, angleToRotate * rotationSpeed);

        timePassed += Time.deltaTime;

        if (timePassed >= dayDuration)
        {
            timePassed = 0.0f;
        }
    }
}

