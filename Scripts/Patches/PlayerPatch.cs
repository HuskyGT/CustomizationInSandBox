using HarmonyLib;
using Photon.Pun;

namespace CustomizationInSandBox.Patches
{
    [HarmonyPatch(typeof(Player))]
    [HarmonyPatch("Awake", MethodType.Normal)]

    internal class PlayerPatch
    {
        private static void Postfix(Player __instance)
        {
            if (!PhotonNetwork.OfflineMode)
                return;

            PlayerFace playerFace = CharacterCreatorHandler.instance.selectedPlayerFaces[0];
            __instance.RPCA_SetFace(playerFace.eyeID, playerFace.eyeOffset, playerFace.mouthID, playerFace.mouthOffset, playerFace.detailID, playerFace.detailOffset, playerFace.detail2ID, playerFace.detail2Offset);
        }
    }
}
