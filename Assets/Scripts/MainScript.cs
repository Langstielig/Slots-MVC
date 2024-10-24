using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    [SerializeField] private SlotMachine2DView view2d;
    [SerializeField] private Button spinButton;
    [SerializeField] private bool is3D;
    [SerializeField] private bool isCentralLineWin;
    Controller controller;

    private void Awake()
    {
        //тут должен быть выбор из двух
        View viewPrefab = view2d;

        View view = Instantiate(viewPrefab);
        Model model = new UnlimitedSpinsModel(view);

        if(isCentralLineWin)
        {
            controller = new CenterLineController(model);
        }
        else
        {
            controller = new AllLinesController(model);
        }

        //spinButton.onClick.AddListener(() =>
        //{
        //    controller.Spin();
        //});
    }

    public void OnSpinButtonClick()
    {
        controller.Spin();
    }
}
