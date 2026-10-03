using HarmonyLib;

namespace ProtobufLoader;

[HarmonyPatch(/*Could not decode attribute arguments.*/)]
internal class PatchGameInstanceInit2
{
	private static void Postfix()
	{
		if (!MyMod.FirstInitCalled)
		{
			MyExten.Log("Init upon GSLocalization init");
			MyMod.ResetAndLoadAllDataFiles();
		}
	}
}
