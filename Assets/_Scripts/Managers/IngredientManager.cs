using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientManager
{

    /// <summary>
    /// This is responsible for added ingredients.
    /// </summary>
    public List<IngredientBase> ingredientList;

    #region Singleton things
    private static IngredientManager instance = null;
    private static readonly object padlock = new object();

    IngredientManager()
    {
        ingredientList = new List<IngredientBase>();
    }

    public static IngredientManager Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new IngredientManager();
                }
                return instance;
            }
        }
    }

    #endregion

}
