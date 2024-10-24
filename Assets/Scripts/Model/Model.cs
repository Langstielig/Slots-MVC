using System.Collections.Generic;
using System.Linq;

public abstract class Model
{
    /// <summary>
    /// ���
    /// </summary>
    protected View view;

    /// <summary>
    /// ������ ������
    /// </summary>
    protected List<int> slots;

    /// <summary>
    /// �������� ��� ������ ������ ������
    /// </summary>
    public List<int> Slots => slots;

    /// <summary>
    /// �������� ��� ������ ���������� ������
    /// </summary>
    public int CountOfSlots => slots.Count;

    /// <summary>
    /// ���������� ��������� ��������� ��������� ������
    /// </summary>
    public int CountOfVariants => view.CountOfVariants;

    /// <summary>
    /// 
    /// </summary>
    protected bool isWin;

    /// <summary>
    /// 
    /// </summary>
    public bool IsWin => isWin;

    /// <summary>
    /// ����������� ������
    /// </summary>
    /// <param name="view">���</param>
    public Model(View view)
    {
        this.view = view;
        slots = new int[view.CountOfSlots].ToList();
    }

    /// <summary>
    /// ���������� �����
    /// </summary>
    /// <param name="newState">����� �����</param>
    public void SetState(List<int> newState)
    {
        slots = newState;
        view.DisplaySpinResult(slots);
    }

    public void SetWinState(bool isWin)
    {
        this.isWin = isWin;
        view.ShowOrHideYouWinText(this.isWin);
    }
}
