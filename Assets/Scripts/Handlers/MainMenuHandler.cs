using UnityEngine;

public class MainMenuHandler : MonoBehaviour
{
    public GameObject MenuItemPrefab, MainWindow;
    private int PosX = -220;
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            var obj = Instantiate(MenuItemPrefab,
                new Vector2(PosX + (110 * i), 110), Quaternion.identity);
            obj.transform.SetParent(MainWindow.transform, false);
        }
    }

}
