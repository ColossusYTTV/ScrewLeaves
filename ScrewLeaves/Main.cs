
using BepInEx;
using UnityEngine;

namespace Colossal
{
    [BepInPlugin("org.ColossusYTTV", "ScrewLeaves", "1.0.0")]
    public class Main : BaseUnityPlugin
    {
        private void OnEnable()
        {
            HarmonyPatches.ApplyHarmonyPatches();
        }

        private void OnDisable()
        {
            HarmonyPatches.RemoveHarmonyPatches();
        }

        public bool AlreadyToggled = false;

        private void Update()
        {
            if(AlreadyToggled == false)
            {
				foreach (var gameObj in FindObjectsOfType(typeof(GameObject)) as GameObject[])
				{
					if (gameObj.name == "smallleaves (1)")
					{
						gameObj.SetActive(false);
					}
				}
				foreach (var gameObj1 in FindObjectsOfType(typeof(GameObject)) as GameObject[])
				{
					if (gameObj1.name == "smallleaves.001")
					{
						gameObj1.SetActive(false);
					}
				}
				foreach (var gameObj2 in FindObjectsOfType(typeof(GameObject)) as GameObject[])
				{
					if (gameObj2.name == "smallleaves.002")
					{
						gameObj2.SetActive(false);
					}
				}
				foreach (var gameObj3 in FindObjectsOfType(typeof(GameObject)) as GameObject[])
				{
					if (gameObj3.name == "smallleaves.003")
					{
						gameObj3.SetActive(false);
					}
				}
				AlreadyToggled = true;
			}
        }
    }
}