using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class Controller
{
    /// <summary>
    /// Модель
    /// </summary>
    protected Model model;

    /// <summary>
    /// Конструктор контроллера
    /// </summary>
    /// <param name="model">Модель</param>
    public Controller(Model model)
    {
        this.model = model;
    }

    /// <summary>
    /// Сгенерировать новые слоты
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
    /// Анализ результата
    /// </summary>
    protected abstract bool AnalyzeResult();
}
