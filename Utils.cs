using System;
using System.Collections.Generic;
using TheForest.Utils;
using UnityEngine;

namespace KillInsteadOfDespawn
{
    public class Utils
    {
        public static void killCannibals()
        {
            try
            {
                List<GameObject> list = new List<GameObject>(Scene.MutantControler.ActiveWorldCannibals);
                foreach (GameObject item in Scene.MutantControler.activeInstantSpawnedCannibals)
                {
                    if (!list.Contains(item))
                    {
                        list.Add(item);
                    }
                }

                list.RemoveAll((GameObject o) => o == null);
                //list.RemoveAll((GameObject o) => o != o.activeSelf);
                if (list.Count > 0)
                {
                    foreach (GameObject item in list)
                    {
                        ModAPI.Log.Write("Hit " + item.name + " (" + item.layer + ")");
                        item.SendMessage("hit", 100, SendMessageOptions.DontRequireReceiver);
                    }
                }
            }
            catch (Exception ex)
            {
                ModAPI.Log.Write("Error in Kill Cannibals. " + ex.Message);
            }
        }
    }
}
