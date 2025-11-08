using CSharpModBase;
using HarmonyLib;

namespace BlackMythWukong_Game_Helper;

public class Game_Helper : ICSharpMod
{
	public Harmony Harmony_;

	public string Name => "BlackMythWukong_Game_Helper";

	public string Version => "2025.8.26";

	public void DeInit()
	{
		Harmony_.UnpatchAll((string)null);
		GlobalObjectMgr.Get<GameStateSystemMgr>()?.SetRunOrStop(isRun: false);
		GlobalObjectMgr.Remove();
	}

	public void Init()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		GlobalObjectMgr.Init();
		GlobalObjectMgr.Get<TB_BossInfoA>().Init();
		KeyHookMgr.Get().RegistAllKey();
		PlayerGm.Init();
		Harmony_ = new Harmony(Name);
		Harmony_.PatchAll();
	}
}
