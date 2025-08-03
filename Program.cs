var (seasoningChoice, foodTypeChoice, ingredientChoice) = ( seasoning(), MainIngredient(), Type());

Console.Write($"You want to make {seasoningChoice} {foodTypeChoice} {ingredientChoice}.");
FoodType Type()
{
    while (true)
    { 
    Console.WriteLine("            1. Soup");
    Console.WriteLine("            2. Stew");
    Console.WriteLine("            3. Gumbo");

    Console.WriteLine("What food type do you want to make?");
    string foodType = Console.ReadLine().ToLower();

        if (foodType != "soup" && foodType != "stew" && foodType != "gumbo")
        {
            Console.WriteLine("Invalid food type.");
            continue; // Prompt again for valid food type
        }
        else
        { 
            return foodType switch
            {
                "soup" => FoodType.Soup,
                "stew" => FoodType.Stew,
                "gumbo" => FoodType.Gumbo,

            };
        }
    }
}
Ingredient MainIngredient()
{
    while (true)
    {
    Console.WriteLine("            1. Mushroom");
    Console.WriteLine("            2. Chicken");
    Console.WriteLine("            3. Carrots");
    Console.WriteLine("            4. Potatoes");

    Console.WriteLine("What ingredient do you want to use?");
    string mainIngredient = Console.ReadLine().ToLower();
    
    if (mainIngredient != "mushroom" && mainIngredient != "chicken" && mainIngredient != "carrots" && mainIngredient != "potatoes")
    {
        Console.WriteLine("Invalid ingredient type.");
        continue; // Prompt again for valid ingredient
    }
        else
        {
            return mainIngredient switch
            {
                "mushroom" => Ingredient.Mushroom,
                "chicken" => Ingredient.Chicken,
                "carrots" => Ingredient.Carrot,
                "potatoes" => Ingredient.Potatoe,
            };
        
        }

    }
}
Seasoning seasoning()
{
    while (true)
    { 
    Console.WriteLine("            1. Spicy");
    Console.WriteLine("            2. Salty");
    Console.WriteLine("            3. Sweet");

    Console.WriteLine("What seasoning do you want to use?");
    string seasoning = Console.ReadLine().ToLower();

        if (seasoning != "spicy" && seasoning != "salty" && seasoning != "sweet")
        {
            Console.WriteLine("Invalid seasoning type.");
            continue; // Prompt again for valid seasoning
        }
        else
        { 
            return seasoning switch
            {
                "spicy" => Seasoning.Spicy,
                "salty" => Seasoning.Salty,
                "sweet" => Seasoning.Sweet,
            };
        
        }
    }
}

enum FoodType { Soup, Stew, Gumbo }
enum Ingredient { Mushroom, Chicken, Carrot, Potatoe }
enum Seasoning { Spicy, Salty, Sweet }
