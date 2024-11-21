using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    void Start()
    {
        GameContainer<string> potionContainer = new GameContainer<string>();
        potionContainer.SetItem("Healing Potion");
        string savedItem = potionContainer.GetItem();
        Debug.Log($"Stored item: {savedItem}");
        string description = GameUtils.DescribeItem(savedItem);
        Debug.Log(description);
    }
}