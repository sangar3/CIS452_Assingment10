using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    #region Attributes
    private const int defaultPoolSize = 20;
    public static bool expandWhenNecessary = true;
    public static Dictionary<string, List<GameObject>> objectPools = new Dictionary<string, List<GameObject>>(); //attr. to store all the gameobjects by string 
    #endregion
   
    #region Object Pool Checks 

    private static bool PoolExistsForPrefab(string prefabpath)
    {
        return objectPools.ContainsKey(prefabpath); //adding key if it doesnt exist
    }

    private static bool IsAvailableForReuse(GameObject gameObject )
    {
        return !gameObject.activeSelf;

    }

    #endregion

    #region Object Pool Creation 
     


    #endregion

}
