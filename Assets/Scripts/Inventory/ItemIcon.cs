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

    [SerializeField] private ItemStack itemStack;
    public ItemStack ItemStack => itemStack;

    public void AssignUIElementsAndUpdate(Image sprImg, TextMeshProUGUI cntTxt)
    {
        itemSpriteImage = sprImg;
        itemCountText = cntTxt;

        itemSpriteImage.sprite = itemStack.ItemType.ItemSprite;
        itemCountText.text = itemStack.Count.ToString();
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
