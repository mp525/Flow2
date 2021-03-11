using UnityEngine;
public class Movement : MonoBehaviour
{
    [SerializeField] [Range(0f, 4f)] float lerpTime;
    [SerializeField] Vector3[] myPositions;
    private int posIndex = 0;
    private int l;

    float t = 0f;
    void Start()
    {
        l = myPositions.Length;

    }
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, myPositions[posIndex], lerpTime * Time.deltaTime);
        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);

        if (t > .9f)
        {

            t = 0f;
            posIndex++;
            posIndex = (posIndex >= l) ? 0 : posIndex;

        }
       

    }
}
