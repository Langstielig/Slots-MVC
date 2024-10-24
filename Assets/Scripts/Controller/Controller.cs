using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class Controller
{
    /// <summary>
    /// ������
    /// </summary>
    protected Model model;

    /// <summary>
    /// ����������� �����������
    /// </summary>
    /// <param name="model">������</param>
    public Controller(Model model)
    {
        this.model = model;
    }

    /// <summary>
    /// ������������� ����� �����
    /// </summary>
    public void Spin()
    {
        List<int> generatedSlots = new int[model.CountOfSlots].ToList();

        for(int i = 0; i < generatedSlots.Count; i++)
        {
            generatedSlots[i] = Random.Range(0, model.CountOfVariants);
        }

        model.SetState(generatedSlots);

        bool isWin = AnalyzeResult();
        model.SetWinState(isWin);
    }

    /// <summary>
    /// ������ ����������
    /// </summary>
    protected abstract bool AnalyzeResult();
}
