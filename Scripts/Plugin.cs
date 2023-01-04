using CustomizationInSandBox.Patches;
using BepInEx;

namespace CustomizationInSandBox
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    [BepInProcess("Rounds.exe")]

    public class Plugin : BaseUnityPlugin
    {
        void Awake()
        {
            HarmonyPatches.ApplyHarmonyPatches();
        }
    }
}
