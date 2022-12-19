using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] private Image ItemImage;
    private Button thisBtn;
    private string Name;
    public int Count;
    public int MaxCount;
    public Item ItemInfo;

    private void Awake()
    {
        thisBtn = this.GetComponent<Button>();
        thisBtn.onClick.AddListener(ClickIcon);
    }

    private void FixedUpdate()
    {
        UIConstantChange();
    }

    private void ClickIcon()
    {
        Debug.Log(transform.localPosition);
    }

    // �κ��丮�� ��ȭ�� üũ�Ͽ� ��ȭ�����ִ� �Լ�
    // ��ũ���ͺ� ������Ʈ�� ������ �޾ƿ´�.
    private void UIConstantChange()
    {
        if (gameObject.activeSelf && ItemInfo != null)
        {
            //ItemImage.sprite = ItemInfo.ItemImage;
            MaxCount = ItemInfo.InvenMaxCount;
            Name = ItemInfo.ItemName;
        }
    }
}
