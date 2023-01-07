using CustomizationInSandBox.Patches;
using BepInEx;
using UnboundLib;

namespace CustomizationInSandBox
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    [BepInProcess("Rounds.exe")]

    public class Plugin : BaseUnityPlugin
    {
        void Awake()
        {
            Unbound.RegisterClientSideMod(PluginInfo.GUID);
            HarmonyPatches.ApplyHarmonyPatches();
        }
    }
}
