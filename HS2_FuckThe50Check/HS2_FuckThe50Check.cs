using BepInEx;
using HarmonyLib;

namespace HS2_FuckThe50Check
{
    [BepInProcess("HoneySelect2")]
    [BepInPlugin(nameof(HS2_FuckThe50Check), nameof(HS2_FuckThe50Check), VERSION)]
    public class HS2_FuckThe50Check : BaseUnityPlugin
    {
        public const string VERSION = "1.0.0";

        private void Awake() => Harmony.CreateAndPatchAll(typeof(HS2_FuckThe50Check), nameof(HS2_FuckThe50Check));

        [HarmonyPrefix, HarmonyPatch(typeof(Manager.GameSystem), "IsPathAdd50")]
        public static bool GameSystem_IsPathAdd50_Bypass(ref bool __result)
        {
            __result = true;
            return false;
        }
    }
}