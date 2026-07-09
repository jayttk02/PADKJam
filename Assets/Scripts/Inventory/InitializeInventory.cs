using UnityEngine;

public class InitializeInventory : MonoBehaviour
{
    [SerializeField] protected int width;
    [SerializeField] protected int height;
    [SerializeField] protected GameObject slot;
    string[,] slotItem; // Get item in slot (if any)
    GameObject[,] slotImage; // Display item-image section in inventory slot
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slotItem = new string[width, height];
        slotImage = new GameObject[width, height];

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                GameObject obj = Instantiate(slot, gameObject.transform);
                obj.name = "(" + i + ", " + j + ")";
                RectTransform rectTransform = obj.GetComponent<RectTransform>();
                rectTransform.anchoredPosition = new Vector2(100f + (i * 50), -100f - (j * 50));
                slotImage[i, j] = obj;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
