using UnityEngine;
using DG.Tweening;

public class DoRotate : MonoBehaviour
{
    public float rotationStrength = 2f;
    public float rotationDuration = 4f;

    private void Start()
    {
        RotateRandomly();
    }

    void RotateRandomly()
    {
        Vector3 randomRotation = new Vector3(
            Random.Range(-rotationStrength, rotationStrength),
            Random.Range(-rotationStrength, rotationStrength),
            Random.Range(-rotationStrength, rotationStrength)
        );

        transform.DOLocalRotate(randomRotation, rotationDuration, RotateMode.Fast)
            .SetEase(Ease.InOutSine)
            .SetLoops(-1, LoopType.Yoyo);
    }
}
