using DG.Tweening;
using UnityEngine;

public class PopupAnimation : MonoBehaviour
{
    [SerializeField] private CanvasGroup _popupCVG;

    public void Disappear()
    {
        if (DOTween.IsTweening(transform))
            return;
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(transform.DOScale(0.5f, 0.3f).SetEase(Ease.InBack))
            .Join(_popupCVG.DOFade(0, 0.3f))
            .OnComplete(() => transform.localScale = Vector3.one);


    }
}
