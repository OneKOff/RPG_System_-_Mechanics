using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemIcon : MonoBehaviour, IPointerDownHandler, IPointerMoveHandler, IPointerUpHandler
{
    [SerializeField] private Image itemSpriteImage;
    [SerializeField] private TextMeshProUGUI itemCountText;
    
    [SerializeField] private ItemType type;
    public ItemType Type => type;
    [SerializeField] private int count;
    public int Count => count;

    public void AssignUIElementsAndUpdate(Image sprImg, TextMeshProUGUI cntTxt)
    {
        itemSpriteImage = sprImg;
        itemCountText = cntTxt;

        itemSpriteImage.sprite = type.ItemSprite;
        itemCountText.text = count.ToString();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
