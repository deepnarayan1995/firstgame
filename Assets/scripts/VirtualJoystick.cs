using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class VirtualJoystick : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public Image BgImage;
    public Image JoystickImage;
    
    public Vector3 InputDirection { set; get; }

    public void Start()
    {
        BgImage = GetComponent<Image>();
        JoystickImage = transform.GetChild(0).GetComponent<Image>();
        InputDirection = Vector3.zero;
    }

    public virtual void OnDrag(PointerEventData pData)
    {

        Vector2 pos = Vector2.zero;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(
            BgImage.rectTransform, pData.position, pData.pressEventCamera, out pos))
        {
            pos.x = (pos.x / BgImage.rectTransform.sizeDelta.x);
            pos.y = (pos.y / BgImage.rectTransform.sizeDelta.y);

            float x = (BgImage.rectTransform.pivot.x == 1) ? pos.x * 2 + 1 : pos.x * 2 - 1;
            float y = (BgImage.rectTransform.pivot.y == 1) ? pos.y * 2 + 1 : pos.y * 2 - 1;

            InputDirection = new Vector3(x, 0, y);
            InputDirection = (InputDirection.magnitude > 1) ? InputDirection.normalized : InputDirection;

            JoystickImage.rectTransform.anchoredPosition = new Vector3
               ( InputDirection.x * (BgImage.rectTransform.sizeDelta.x / 3),
                 InputDirection.y * (BgImage.rectTransform.sizeDelta.y / 3) );

        }

    }


    public virtual void OnPointerDown(PointerEventData pData)
    {
        OnDrag(pData);
    }

    public virtual void OnPointerUp(PointerEventData pData)
    {
        InputDirection = Vector3.zero;
        JoystickImage.rectTransform.anchoredPosition = Vector3.zero;
    }


}
