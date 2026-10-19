using System;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonController : Button
{
    RectTransform rectTransform;

    protected override void Awake()
    {
        base.Awake();
        rectTransform = GetComponent<RectTransform>();
    }

    public override void OnSelect(BaseEventData eventData)
    {
        base.OnSelect(eventData);
        rectTransform.DOPunchScale(Vector3.one * 0.2f, 0.2f, 1, 0.5f).onComplete += () =>
            rectTransform.localScale = Vector3.one;
        
    }

    public override void OnPointerEnter(PointerEventData eventData)
    {
        base.OnPointerEnter(eventData);
        rectTransform.DOPunchScale(Vector3.one * 0.2f, 0.2f, 1, 0.5f).onComplete += () =>
            rectTransform.localScale = Vector3.one;
    }
}
