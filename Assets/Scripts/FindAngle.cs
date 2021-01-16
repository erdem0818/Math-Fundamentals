using UnityEngine;

public class FindAngle : MonoBehaviour
{    /*   *  
     *    * *
     *    *  *
     * 12 *   *   13
     *    *    *
     *    *     *
     *    * * * * *
     *       5
     */
    [SerializeField] float x = 5, y = 12;
    float c = 0;

    private void Start()
    {
        c = x * x + y * y;
        c = Mathf.Sqrt(c);
        Debug.Log("Sqrt of hyp. : " + c);

        float valueTan = y / x;
        float valueSin = y / c;

        float angle = Mathf.Atan(valueTan);
        angle = angle * 180 / Mathf.PI;

        float angleSin = Mathf.Asin(valueSin);
        angleSin = angleSin * 180 / Mathf.PI;

        Debug.Log("with arctan: " + angle);
        Debug.Log("with Sin: " + angleSin);
    }
}
