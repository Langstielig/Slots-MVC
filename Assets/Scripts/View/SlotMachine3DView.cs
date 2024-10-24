using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SlotMachine3DView : View
{
    /// <summary>
    /// Список рендеров слотов
    /// </summary>
    [SerializeField] private List<MeshRenderer> slots;

    /// <summary>
    /// Список вариантов материалов для слотов
    /// </summary>
    [SerializeField] private List<Material> slotsMaterials;

    /// <summary>
    /// Текст выигрыша
    /// </summary>
    [SerializeField] private TextMeshProUGUI youWinText;

    /// <summary>
    /// Свойство для чтения количества вариантов материалов
    /// </summary>
    public override int CountOfVariants => slotsMaterials.Count;

    public override int CountOfSlots => slots.Count;

    /// <summary>
    /// Отобразить результаты спина
    /// </summary>
    /// <param name="values">Список сгенерированных индексов материалов</param>
    public override void DisplaySpinResult(List<int> values)
    {
        for(int i = 0; i < slots.Count; i++)
        {
            slots[i].material = GetSlotMaterialByIndex(values[i]);
        }
    }

    /// <summary>
    /// Получить материал из списка по индексу
    /// </summary>
    /// <param name="index">Индекс материала в списке</param>
    /// <returns></returns>
    private Material GetSlotMaterialByIndex(int index)
    {
        return slotsMaterials[index];
    }

    /// <summary>
    /// Скрыть или показать текст выигрыша
    /// </summary>
    /// <param name="isActive">Булевая переменная активности текста выигрыша</param>
    public override void ShowOrHideYouWinText(bool isActive)
    {
        youWinText.gameObject.SetActive(isActive);
    }
}
