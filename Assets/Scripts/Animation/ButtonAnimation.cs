using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonAnimation : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        DOTween.Kill(transform);
        transform.localScale = Vector3.one;
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(transform.DOScale(0.7f, 0.1f))
            .Append(transform.DOScale(1, 0.3f).SetEase(Ease.OutBack));
    }
}
