using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SlotMachine2DView : View
{
    /// <summary>
    /// ������ UI ������
    /// </summary>
    [SerializeField] private List<Image> slots;

    /// <summary>
    /// ������ �������� ��� ������
    /// </summary>
    [SerializeField] private List<Sprite> spritesForSlots;

    /// <summary>
    /// ����� ��������
    /// </summary>
    [SerializeField] private TextMeshProUGUI youWinText;

    /// <summary>
    /// �������� ��� ������ ���������� ��������� ��������
    /// </summary>
    public override int CountOfVariants => spritesForSlots.Count;

    /// <summary>
    /// ���������� ����� ��� ������
    /// </summary>
    public override int CountOfSlots => slots.Count;

    /// <summary>
    /// ���������� ���������� �����
    /// </summary>
    /// <param name="values">������ ��������������� �������� ��������</param>
    public override void DisplaySpinResult(List<int> values)
    {
        for(int i = 0; i < values.Count; i++)
        {
            slots[i].sprite = GetSpriteByIndex(values[i]);
        }
    }

    /// <summary>
    /// �������� ������ ����� �� ������� � ������
    /// </summary>
    /// <param name="index">������ ����� � ������</param>
    /// <returns></returns>
    private Sprite GetSpriteByIndex(int index)
    {
        return spritesForSlots[index];
    }

    /// <summary>
    /// �������� ��� �������� ����� ��������
    /// </summary>
    /// <param name="isActive">������� ���������� ���������� ������ ��������</param>
    public override void ShowOrHideYouWinText(bool isActive)
    {
        youWinText.gameObject.SetActive(isActive);
    }
}
