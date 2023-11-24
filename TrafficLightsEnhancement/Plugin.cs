using BepInEx;
using BepInEx.Unity.Mono;
using HarmonyLib;

namespace C2VM.TrafficLightsEnhancement;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)] 
public class Plugin : BaseUnityPlugin
{
    private void Awake()
    {
        Logger.LogInfo($"插件 {MyPluginInfo.PLUGIN_GUID} {MyPluginInfo.PLUGIN_VERSION} 成功加载！"); 

        var harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
        harmony.PatchAll();
    }
}
