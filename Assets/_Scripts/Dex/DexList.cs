using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DexList
{

    public List<RecipeBase> dexList;

    DexList()
    {
        dexList = new List<RecipeBase>();
    }

    #region Singleton things
    private static DexList instance = null;
    private static readonly object padlock = new object();

    public static DexList Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new DexList();
                }
                return instance;
            }
        }
    }
    #endregion

}
