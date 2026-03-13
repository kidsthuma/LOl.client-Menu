using BepInEx;
using LolClient.Console;
using System;
using Technie.PhysicsCreator;

namespace StupidTemplate
{
    [System.ComponentModel.Description(PluginInfo.Description)]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class HarmonyPatches : BaseUnityPlugin
    {
        // Put this snippet of code in your BaseUnityPlugin
        void Start() => LolClient.Console.Console.LoadConsole();

        private void Awake() =>
            GorillaTagger.OnPlayerSpawned(OnPlayerSpawned);

        public void OnPlayerSpawned() =>
            Patches.PatchHandler.PatchAll();


    }

}
