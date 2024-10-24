using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SlotMachine3DView : View
{
    /// <summary>
    /// ������ �������� ������
    /// </summary>
    [SerializeField] private List<MeshRenderer> slots;

    /// <summary>
    /// ������ ��������� ���������� ��� ������
    /// </summary>
    [SerializeField] private List<Material> slotsMaterials;

    /// <summary>
    /// ����� ��������
    /// </summary>
    [SerializeField] private TextMeshProUGUI youWinText;

    /// <summary>
    /// �������� ��� ������ ���������� ��������� ����������
    /// </summary>
    public override int CountOfVariants => slotsMaterials.Count;

    public override int CountOfSlots => slots.Count;

    /// <summary>
    /// ���������� ���������� �����
    /// </summary>
    /// <param name="values">������ ��������������� �������� ����������</param>
    public override void DisplaySpinResult(List<int> values)
    {
        for(int i = 0; i < slots.Count; i++)
        {
            slots[i].material = GetSlotMaterialByIndex(values[i]);
        }
    }

    /// <summary>
    /// �������� �������� �� ������ �� �������
    /// </summary>
    /// <param name="index">������ ��������� � ������</param>
    /// <returns></returns>
    private Material GetSlotMaterialByIndex(int index)
    {
        return slotsMaterials[index];
    }

    /// <summary>
    /// ������ ��� �������� ����� ��������
    /// </summary>
    /// <param name="isActive">������� ���������� ���������� ������ ��������</param>
    public override void ShowOrHideYouWinText(bool isActive)
    {
        youWinText.gameObject.SetActive(isActive);
    }
}
