using UnityEngine;

public class LockOnTarget : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void Update()
    {
        //mouse
        Vector3 direction = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
        10)) - transform.position;
        //target
        //Vector3 direction = target.position - transform.position;
        Debug.DrawRay(transform.position, direction, Color.red);

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
        // rad2deg(180 / pi) // 270 - 90 - 0 in unity in real world 180 - 90 - 0
        transform.eulerAngles = Vector3.forward * angle;

        //Quaternion angleAxis = Quaternion.AngleAxis(angle, Vector3.forward);
        //transform.rotation = Quaternion.Slerp(transform.rotation, angleAxis, Time.deltaTime * 50);
    }
}
