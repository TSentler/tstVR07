using System.Collections.Generic;
using UnityEngine;

public class PotionSystem : MonoBehaviour
{
    public PotionSpawner spawner;
    public Cauldron cauldron;
    public GameObject MagicGrib;
    public GameObject Skrizal;
    public GameObject regeneration;
    public GameObject vaza;
    public GameObject KOL;

    public void BrewPotion()
    {
        List<IngredientType> ingredients = cauldron.currentIngredients;
        // vision potion
        if (ingredients.Contains(IngredientType.Mushroom) &&
            ingredients.Contains(IngredientType.Water) &&
            ingredients.Contains(IngredientType.svetok) &&
            ingredients.Contains(IngredientType.Watermelon) &&
            ingredients.Count == 4)
        {
            Debug.Log("зелье регенерации готово!");
            spawner.Spawn(regeneration);
        }
        else if (ingredients.Contains(IngredientType.Water) &&
            ingredients.Contains(IngredientType.Water) &&
            ingredients.Contains(IngredientType.Eye) &&
            ingredients.Contains(IngredientType.Eye) &&
            ingredients.Contains(IngredientType.Eye) &&
            ingredients.Count == 5)
        {
            Debug.Log("зелье вреда готово!");
        }
        else if (ingredients.Contains(IngredientType.Eye) &&
            ingredients.Contains(IngredientType.svetok) &&
        ingredients.Count == 2)
        {
            Debug.Log("зелье тошноты готово!");
            spawner.Spawn(Skrizal);
        }
        else if (ingredients.Contains(IngredientType.RedGrib) &&
        ingredients.Contains(IngredientType.Mushroom) &&
        ingredients.Contains(IngredientType.Water) &&
        ingredients.Contains(IngredientType.Magic) &&
    ingredients.Count == 4)
        {
            Debug.Log("Магичесский ГРИБ готов");
            spawner.Spawn(MagicGrib);
        }
        else if (ingredients.Contains(IngredientType.MiniEye) &&
    ingredients.Contains(IngredientType.Water) &&
ingredients.Count == 2)
        {
            Debug.Log("Большой ГЛАЗ готов");

        }
        else if (ingredients.Contains(IngredientType.SK) &&
        ingredients.Contains(IngredientType.MiniEye) &&
        ingredients.Contains(IngredientType.KOL) &&
    ingredients.Count == 3)
        {
            Debug.Log("Колба магии готова");
            spawner.Spawn(KOL);
        }
        else if (ingredients.Contains(IngredientType.svetok) &&
            ingredients.Contains(IngredientType.svetok) &&
            ingredients.Contains(IngredientType.svetok) &&
            ingredients.Contains(IngredientType.svetok) &&
            ingredients.Contains(IngredientType.Water) &&
            ingredients.Count == 5)
        {
            Debug.Log("зелье роста готово!");
            spawner.Spawn(vaza);
        }
        else if (ingredients.Contains(IngredientType.Watermelon) &&
        ingredients.Contains(IngredientType.Mushroom) &&
        ingredients.Contains(IngredientType.Mushroom) &&
        ingredients.Contains(IngredientType.svetok) &&
        ingredients.Contains(IngredientType.Water) &&
        ingredients.Contains(IngredientType.Eye) &&
        ingredients.Contains(IngredientType.RedGrib) &&
        ingredients.Contains(IngredientType.Watermelon) &&
        ingredients.Contains(IngredientType.Water) &&
        ingredients.Contains(IngredientType.MagicGrib) &&
        ingredients.Count == 10)
        {
            Debug.Log("ПредФинальное зелье готово!");
        }
        cauldron.ClearCauldron();


    }
}
