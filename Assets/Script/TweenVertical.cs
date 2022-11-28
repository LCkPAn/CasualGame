using UnityEngine;
using DG.Tweening;

public class TweenVertical : MonoBehaviour
{
    [SerializeField] private float cycleLength = 1;
    void Start()
    {
        transform.DOMoveY(1.5f, cycleLength).SetEase(Ease.InOutSine).SetLoops(-1,LoopType.Yoyo);
    }
}
