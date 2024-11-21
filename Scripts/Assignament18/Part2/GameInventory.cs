using UnityEngine;

public class GameInventory : MonoBehaviour
{
    void Start()
    {
        Inventory potionInventory = new Inventory();
        potionInventory.AddItem("Healing Potion");
        potionInventory.AddItem("Strength Potion");

        Inventory elixirInventory = new Inventory();
        elixirInventory.AddItem("Elixir");
        elixirInventory.AddItem("Dark Elixir");

        // Combine inventories using the overloaded + operator
        Inventory combinedInventory = potionInventory + elixirInventory;
        combinedInventory.ShowItems();
    }
}
