public class AllLinesController : Controller
{
    public AllLinesController(Model model) : base(model)
    { }

    protected override bool AnalyzeResult()
    {
        var slots = model.Slots;
        bool isWin = false;

        for(int i = 0; i < slots.Count && !isWin;  i++)
        {
            if (slots[i] == slots[i + 1] && slots[i + 1] == slots[i + 2]) 
            {
                isWin = true;
            }
            i += 2;
        }

        return isWin;
    }
}
