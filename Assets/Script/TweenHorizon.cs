using UnityEngine;
using DG.Tweening;

public class TweenHorizon : MonoBehaviour
{
    [SerializeField] private float TycleLength = 1;
    void Start()
    {
        transform.DOLocalMoveZ(1, TycleLength).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
        
    }
}
