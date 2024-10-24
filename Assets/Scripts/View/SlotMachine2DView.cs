using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SlotMachine2DView : View
{
    /// <summary>
    /// Список UI слотов
    /// </summary>
    [SerializeField] private List<Image> slots;

    /// <summary>
    /// Список спрайтов для слотов
    /// </summary>
    [SerializeField] private List<Sprite> spritesForSlots;

    /// <summary>
    /// Текст выигрыша
    /// </summary>
    [SerializeField] private TextMeshProUGUI youWinText;

    /// <summary>
    /// Свойство для чтения количества вариантов спрайтов
    /// </summary>
    public override int CountOfVariants => spritesForSlots.Count;

    /// <summary>
    /// Количество ячеек для слотов
    /// </summary>
    public override int CountOfSlots => slots.Count;

    /// <summary>
    /// Отобразить результаты спина
    /// </summary>
    /// <param name="values">Список сгенерированных индексов спрайтов</param>
    public override void DisplaySpinResult(List<int> values)
    {
        for(int i = 0; i < values.Count; i++)
        {
            slots[i].sprite = GetSpriteByIndex(values[i]);
        }
    }

    /// <summary>
    /// Получить спрайт слота по индексу в списке
    /// </summary>
    /// <param name="index">Индекс слота в списке</param>
    /// <returns></returns>
    private Sprite GetSpriteByIndex(int index)
    {
        return spritesForSlots[index];
    }

    /// <summary>
    /// Показать или спрятать текст выигрыша
    /// </summary>
    /// <param name="isActive">Булевая переменная активности текста выигрыша</param>
    public override void ShowOrHideYouWinText(bool isActive)
    {
        youWinText.gameObject.SetActive(isActive);
    }
}
