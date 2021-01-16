using UnityEngine;

public class SinCos : MonoBehaviour
{
    [SerializeField] private float amplitudeForSin = 1;
    [SerializeField] private float amplitudeForCos = 1;
    [SerializeField] private float frequencyForSin = .1f;
    [SerializeField] private float frequencyForCos = .1f;

    private void Update()
    {
        float x = Mathf.Cos(Time.time * frequencyForCos) * amplitudeForCos;
        float y = Mathf.Sin(Time.time * frequencyForSin) * amplitudeForSin;
        float z = transform.localPosition.z;

        transform.position = new Vector3(x, y, z);
    }
}
