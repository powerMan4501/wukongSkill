using System;
using CSharpModBase;
using CSharpModBase.Input;
using HarmonyLib;
using UnrealEngine.Engine;

namespace Game_Helper;

public class LangManGameHelper : ICSharpMod
{
	public int id;

	private Harmony _Harmony;

	public string Name => "BlackMythWukong_Game_Helper";

	public string Version => "1.0.0.0";

	public void DeInit()
	{
		Tools.gameHelperMgrSystem.StopAll();
		BU_GameData.Init();
		_Harmony.UnpatchAll((string)null);
	}

	public void Init()
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		MyUtils.EnableCNInConsole();
		Utils.RegisterKeyBind((Key)112, (Action)delegate
		{
			AActor controlledPawn = MyUtils.GetControlledPawn();
		});
		Utils.RegisterKeyBind((Key)113, (Action)delegate
		{
		});
		Utils.RegisterKeyBind((Key)114, (Action)delegate
		{
		});
		Tools.GameData = BU_GameData.Get();
		Tools.Init();
		_Harmony = new Harmony(Name);
		_Harmony.PatchAll();
	}
}
