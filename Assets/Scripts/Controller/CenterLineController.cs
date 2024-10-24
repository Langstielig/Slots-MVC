public class CenterLineController : Controller
{
    /// <summary>
    /// Конструктор контроллера с проверкой центральной линии
    /// </summary>
    /// <param name="model"></param>
    /// <param name="view"></param>
    public CenterLineController(Model model) : base(model)
    { }

    /// <summary>
    /// Анализ результата
    /// </summary>
    protected override bool AnalyzeResult()
    {
        bool isWin = false;
        var slots = model.Slots;

        if (slots[3] == slots[4] && slots[4] == slots[5]) 
        {
            isWin = true;
        }

        return isWin;
    }
}
