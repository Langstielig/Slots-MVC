using System.Collections.Generic;
using System.Linq;

public abstract class Model
{
    /// <summary>
    /// Вид
    /// </summary>
    protected View view;

    /// <summary>
    /// Список слотов
    /// </summary>
    protected List<int> slots;

    /// <summary>
    /// Свойство для чтения списка слотов
    /// </summary>
    public List<int> Slots => slots;

    /// <summary>
    /// Свойство для чтения количества слотов
    /// </summary>
    public int CountOfSlots => slots.Count;

    /// <summary>
    /// Количество различных вариантов элементов слотов
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
    /// Конструктор модели
    /// </summary>
    /// <param name="view">Вид</param>
    public Model(View view)
    {
        this.view = view;
        slots = new int[view.CountOfSlots].ToList();
    }

    /// <summary>
    /// Установить слоты
    /// </summary>
    /// <param name="newState">Новые слоты</param>
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
