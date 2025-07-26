using System.Collections.Generic;
using b1;
using BtlB1;
using BtlShare;
using CSharpModBase;
using HarmonyLib;
using UnrealEngine.Engine;

namespace BossRushV4;

public class BossRushV4 : ICSharpMod
{
	public List<FUStBossRushConfigDesc> IterationsList = new List<FUStBossRushConfigDesc>();

	public static Dictionary<string, int> DuplicateNameDict = new Dictionary<string, int>();

	public CustomBossIterationConfig CustomBossIterationConfig = new CustomBossIterationConfig();

	private Harmony _harmony;

	public string Name => "BossRushV4";

	public string Version => "1.0.0";

	public string Author => "禽兽-云轩";

	public static BossRushV4 Instance { get; private set; }

	public void Init()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		Instance = this;
		IterationsList = new List<FUStBossRushConfigDesc>();
		_harmony = new Harmony(Name);
		_harmony.PatchAll();
		CustomBossIterationConfig = Utils.LoadConfig<CustomBossIterationConfig>();
	}

	public void DeInit()
	{
		if (_harmony != null)
		{
			_harmony.UnpatchAll((string)null);
		}
	}

	private void setPlayerState()
	{
		APawn controlledPawn = Helper.GetControlledPawn();
		BGUFunctionLibraryCS.BGUSetUnitSimpleState((AActor)controlledPawn, (EBGUSimpleState)1, false);
		BGUFunctionLibraryCS.BGUSetUnitSimpleState((AActor)controlledPawn, (EBGUSimpleState)15, false);
		BGUFunctionLibraryCS.BGUSetAttrValue((AActor)controlledPawn, (EBGUAttrFloat)153, 5000f);
		BGUFunctionLibraryCS.BGUSetAttrValue((AActor)controlledPawn, (EBGUAttrFloat)103, 5000f);
		BGUFunctionLibraryCS.BGUSetAttrValue((AActor)controlledPawn, (EBGUAttrFloat)53, 5000f);
	}
}
