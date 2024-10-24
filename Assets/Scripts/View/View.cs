using System.Collections.Generic;
using UnityEngine;

public abstract class View : MonoBehaviour
{
    /// <summary>
    /// ���������� ��������� ��������� ���������
    /// </summary>
    public abstract int CountOfVariants { get; }

    /// <summary>
    /// ���������� ����� ������
    /// </summary>
    public abstract int CountOfSlots { get; }

    /// <summary>
    /// ���������� ���������� �����
    /// </summary>
    /// <param name="values">������ ��������������� �������� ��������</param>
    public abstract void DisplaySpinResult(List<int> values);

    /// <summary>
    /// �������� ��� �������� ����� ��������
    /// </summary>
    /// <param name="isActive">������� ���������� ���������� ������ ��������</param>
    public abstract void ShowOrHideYouWinText(bool isActive);
}
