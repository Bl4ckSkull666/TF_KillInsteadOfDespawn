using UnityEngine;
using TheForest.Utils;
using System.Collections.Generic;
using System;

namespace KillInsteadOfDespawn
{
    public class WentLightAndDarkEx : sceneTracker
    {
        public override void WentLight()
        {
            setDayAnimalAmount();
            if (Cheats.NoEnemiesDuringDay)
            {
                KillCannibals(Scene.MutantControler.ActiveCannibals);
                KillCannibals(Scene.MutantControler.ActiveInstantSpawnedCannibals);
                KillCannibals(Scene.MutantControler.ActiveWorldCannibals);
            }
            else
            {
                base.WentLight();
            }
        }

        public override void WentDark()
        {
            base.WentDark();
        }

        private void KillCannibals(List<GameObject> obj)
        {
            try
            {
                List<GameObject> list = new List<GameObject>(obj);
                if (list.Count > 0)
                {
                    foreach (GameObject item in list)
                    {
                        if(item != null)
                            KillIt(item);
                    }
                }
            }
            catch (Exception ex)
            {
                ModAPI.Log.Write("Error in Kill Cannibals. " + ex.Message);
            }
        }

        private void KillIt(GameObject obj)
        {
            if ((bool)obj)
            {
                obj.SendMessage("killThisEnemy", SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}
