using System.Collections.Generic;
using UnityEngine;

public abstract class View : MonoBehaviour
{
    /// <summary>
    /// Количество различных вариантов элементов
    /// </summary>
    public abstract int CountOfVariants { get; }

    /// <summary>
    /// Количество ячеек слотов
    /// </summary>
    public abstract int CountOfSlots { get; }

    /// <summary>
    /// Отобразить результаты спина
    /// </summary>
    /// <param name="values">Список сгенерированных индексов спрайтов</param>
    public abstract void DisplaySpinResult(List<int> values);

    /// <summary>
    /// Показать или спрятать текст выигрыша
    /// </summary>
    /// <param name="isActive">Булевая переменная активности текста выигрыша</param>
    public abstract void ShowOrHideYouWinText(bool isActive);
}
