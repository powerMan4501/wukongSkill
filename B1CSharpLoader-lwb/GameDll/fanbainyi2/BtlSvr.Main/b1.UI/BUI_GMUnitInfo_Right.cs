using System;
using System.Collections.Generic;
using System.Reflection;
using BtlShare;
using Google.Protobuf.Collections;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_GMUnitInfo_Right")]
internal class BUI_GMUnitInfo_Right : BUI_Widget
{
	private const string INFONAME_NAME = "InfoName";

	private const string INFONAME_VALUE = "InfoValue";

	private Dictionary<string, UTextBlock> InfoDic = new Dictionary<string, UTextBlock>();

	private UTextBlock TargetName;

	private UTextBlock SimpleState;

	private UTextBlock UnitState;

	private UVerticalBox InfoBox;

	private const string TARGETNAME_NAME = "TargetName";

	private const string SIMPLESTATE_NAME = "SimpleState";

	private const string UNITSTATE_NAME = "UnitState";

	private const string INFOBOX_NAME = "InfoBox";

	private const string INFOCONTENT_1 = "目标距离";

	private const string INFOCONTENT_2 = "玩家于怪物的角度";

	private const string INFOCONTENT_3 = "目标MMState";

	private const string INFOCONTENT_4 = "目标血量";

	private const string INFOCONTENT_6 = "目标技能破甲值";

	private const string INFOCONTENT_7 = "目标MoveMode";

	private const string INFOCONTENT_8 = "主角MoveMode";

	private const string INFOCONTENT_10 = "目标受击InfoID";

	private UTextBlock BuffText;

	private UTextBlock SkillCDText;

	private UTextBlock CurFSMState;

	private UTextBlock PassiveSkillText;

	private const string BUFFTEXT_NAME = "BuffText";

	private const string SKILLCDTEXT_NAME = "SkillCDText";

	private const string CURFSMSTATE_NAME = "CurFSMState";

	private const string PASSIVESKILL_NAME = "PassiveSkillText";

	private string buffstr;

	private BGUCharacterCS PlayerCharacter;

	private IBUC_TargetInfoData TargetInfoData;

	private BGUCharacterCS Target;

	private BUC_BuffData TargetBuffData;

	private BUC_SimpleStateData SimpStateData;

	private BUC_UnitStateData UnitStateData;

	private IBUC_SkillInstsData TargetSkillData;

	private string SkillCDStr = "SkillID: s\n";

	private string PassiveSkillStr = "PassiveSkill:\n";

	private static bool InfoTemp_IsValid;

	private static int InfoTemp_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_GMUnitInfo_Right:InfoTemp")]
	public TSubclassOf<UUserWidget> InfoTemp
	{
		get
		{
			CheckDestroyed();
			if (!InfoTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMUnitInfo_Right:InfoTemp");
				return default(TSubclassOf<UUserWidget>);
			}
			return TSubclassOfMarshaler<UUserWidget>.FromNative(IntPtr.Add(base.Address, InfoTemp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InfoTemp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_GMUnitInfo_Right:InfoTemp");
			}
			else
			{
				TSubclassOfMarshaler<UUserWidget>.ToNative(IntPtr.Add(base.Address, InfoTemp_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (firstLocalPlayerController == null)
		{
			return;
		}
		AActor controlledPawn = firstLocalPlayerController.GetControlledPawn();
		PlayerCharacter = controlledPawn as BGUCharacterCS;
		if (!(controlledPawn == null) && !(PlayerCharacter == null))
		{
			TargetInfoData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(PlayerCharacter);
			TargetName = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("TargetName")) as UTextBlock;
			InfoBox = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("InfoBox")) as UVerticalBox;
			BuffText = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("BuffText")) as UTextBlock;
			SkillCDText = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("SkillCDText")) as UTextBlock;
			SimpleState = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("SimpleState")) as UTextBlock;
			UnitState = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("UnitState")) as UTextBlock;
			CurFSMState = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("CurFSMState")) as UTextBlock;
			PassiveSkillText = UGSE_UMGFuncLib.GetWidgetFromName(this, new FName("PassiveSkillText")) as UTextBlock;
			if (!(TargetName == null) && !(InfoBox == null) && !(BuffText == null) && !(SimpleState == null) && !(UnitState == null) && !(CurFSMState == null))
			{
				AddInitInfo(InfoBox, "目标距离");
				AddInitInfo(InfoBox, "玩家于怪物的角度");
				AddInitInfo(InfoBox, "目标MMState");
				AddInitInfo(InfoBox, "目标血量");
				AddInitInfo(InfoBox, "目标技能破甲值");
				AddInitInfo(InfoBox, "目标MoveMode");
				AddInitInfo(InfoBox, "主角MoveMode");
				AddInitInfo(InfoBox, "目标受击InfoID");
			}
		}
	}

	protected override void OnUIGSSlowTickImpl(FGeometry MyGeometry, float InDeltaTime)
	{
		if (!IsVisible())
		{
			return;
		}
		if (PlayerCharacter == null || PlayerCharacter.IsPendingKill)
		{
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
			if (firstLocalPlayerController == null)
			{
				return;
			}
			AActor controlledPawn = firstLocalPlayerController.GetControlledPawn();
			PlayerCharacter = controlledPawn as BGUCharacterCS;
			TargetInfoData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(PlayerCharacter);
		}
		if (PlayerCharacter == null || PlayerCharacter.IsPendingKill)
		{
			return;
		}
		UpdateFSMInfo();
		UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
		Target = targetInfo.LockTargetActor as BGUCharacterCS;
		Target = ((Target == null) ? PlayerCharacter : Target);
		if (Target == null)
		{
			if (TargetName != null)
			{
				TargetName.SetText(FText.FromString("NoTarget"));
			}
			return;
		}
		TargetName.SetText(FText.FromString(Target.GetName()));
		UpdateBaseInfo();
		UpdateBuffInfo();
		UpdateStateInfo();
		UpdateSkillCDInfo();
		UpdatePassiveSkillInfo();
	}

	private void AddInitInfo(UVerticalBox infobox, string infoname)
	{
		if (!(infobox == null))
		{
			UUserWidget uUserWidget = UGSE_UMGFuncLib.CreateUserWidgetWithClass(this, InfoTemp.Value);
			(UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("InfoName")) as UTextBlock).SetText(FText.FromString(infoname));
			UTextBlock value = UGSE_UMGFuncLib.GetWidgetFromName(uUserWidget, new FName("InfoValue")) as UTextBlock;
			InfoDic.Add(infoname, value);
			infobox.AddChild(uUserWidget);
		}
	}

	private void UpdateBuffInfo()
	{
		TargetBuffData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(Target);
		buffstr = "BuffID [Layer] Time\n";
		foreach (BuffInstData allBuffInstDatum in TargetBuffData.GetAllBuffInstData())
		{
			int num = (int)allBuffInstDatum.LeftTime;
			buffstr += $"{allBuffInstDatum.BuffID} [{allBuffInstDatum.Layer}] {num}s \n";
		}
		BuffText.SetText(FText.FromString(buffstr));
	}

	private void UpdateBaseInfo()
	{
		if (Target == null || PlayerCharacter == null || PlayerCharacter.IsPendingKill)
		{
			return;
		}
		if (Target != PlayerCharacter)
		{
			InfoDic["目标距离"].SetText(FText.FromString(Target.GetDistanceTo(PlayerCharacter).ToString()));
			float num = UMathLibrary.NormalizeAxis(UMathLibrary.NormalizeAxis(UMathLibrary.FindLookAtRotation(BGUFuncLibActorTransformCS.BGUGetActorLocation(Target), BGUFuncLibActorTransformCS.BGUGetActorLocation(PlayerCharacter)).Yaw) - UMathLibrary.NormalizeAxis(BGUFuncLibActorTransformCS.BGUGetActorRotation(Target).Yaw));
			InfoDic["玩家于怪物的角度"].SetText(FText.FromString(num.ToString("0.00")));
			InfoDic["目标技能破甲值"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.SkillSuperArmor) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.SkillSuperArmorMax)));
			IBUC_BeAttackData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>(Target);
			InfoDic["目标受击InfoID"].SetText(FText.FromString($"{readOnlyData.GetCurrentBeAttackedInfoID()}"));
		}
		else
		{
			InfoDic["目标距离"].SetText(FText.FromString(""));
			InfoDic["玩家于怪物的角度"].SetText(FText.FromString(""));
			InfoDic["目标技能破甲值"].SetText(FText.FromString(""));
			InfoDic["目标受击InfoID"].SetText(FText.FromString(""));
		}
		InfoDic["目标血量"].SetText(FText.FromString(BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.Hp) + " / " + BGUFunctionLibraryCS.BGUGetFloatAttr(Target, EBGUAttrFloat.HpMax)));
		IBUC_ABPMotionMatchingData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPMotionMatchingData>(Target);
		if (unPersistentReadOnlyData != null)
		{
			InfoDic["目标MMState"].SetText(FText.FromString(unPersistentReadOnlyData.MotionMatchingState.ToString()));
		}
		BUC_MovementModes unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_MovementModes>(Target);
		if (Target == null || Target == PlayerCharacter)
		{
			InfoDic["目标MoveMode"].SetText(FText.FromString("No Target"));
		}
		else if (unPersistentReadOnlyData2 != null)
		{
			BUC_MoveModeBase activeMover = unPersistentReadOnlyData2.ActiveMover;
			if (activeMover != null)
			{
				string[] array = activeMover.ToString().Split('_');
				InfoDic["目标MoveMode"].SetText(FText.FromString(array[1]));
			}
			else
			{
				InfoDic["目标MoveMode"].SetText(FText.FromString("No ActiveMover"));
			}
		}
		BUC_MovementModes unPersistentReadOnlyData3 = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_MovementModes>(PlayerCharacter);
		if (unPersistentReadOnlyData3 != null)
		{
			BUC_MoveModeBase activeMover2 = unPersistentReadOnlyData3.ActiveMover;
			if (activeMover2 != null)
			{
				string[] array2 = activeMover2.ToString().Split('_');
				InfoDic["主角MoveMode"].SetText(FText.FromString(array2[1]));
			}
			else
			{
				InfoDic["主角MoveMode"].SetText(FText.FromString("No ActiveMover"));
			}
		}
	}

	private void UpdateFSMInfo()
	{
		CurFSMState.SetText(FText.FromString("TODO Show Wukong GCFSM State"));
	}

	private void UpdateStateInfo()
	{
		string text = "";
		string text2 = "";
		SimpStateData = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(Target);
		string text3 = SimpStateData.GetString();
		string text4 = "SimpleStateList:";
		string text5 = text3.Substring(text4.Length, text3.Length - text4.Length);
		for (int i = 0; i < text5.Length; i++)
		{
			text = ((text5[i] == ',') ? (text + "\n") : (text + text5[i]));
		}
		SimpleState.SetText(FText.FromString(text));
		UnitStateData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Target);
		string text6 = UnitStateData.GetString();
		string text7 = "UnitStateData:";
		string text8 = text6.Substring(text7.Length, text6.Length - text7.Length);
		for (int j = 0; j < text8.Length; j++)
		{
			text2 = ((text8[j] == ',') ? (text2 + "\n") : (text2 + text8[j]));
		}
		UnitState.SetText(FText.FromString(text2));
	}

	private void UpdateSkillCDInfo()
	{
		SkillCDStr = "SkillID: \n";
		if (Target == null || Target.GetResID() == 10)
		{
			SkillCDText.SetText(FText.FromString(SkillCDStr));
			return;
		}
		TargetSkillData = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(Target);
		int num = Target.GetResID() * 100 + 99;
		for (int i = Target.GetResID() * 100 + 1; i < num; i++)
		{
			if (BGW_GameDB.GetSkillSDesc(i, Target) == null)
			{
				continue;
			}
			if (!TargetSkillData.GetSkillCooldownTime(i, out var RemainingCooldownTime, out var RemainingPreCooldownTime))
			{
				if (RemainingPreCooldownTime > 0f)
				{
					SkillCDStr = SkillCDStr + i + "  PreCD：" + RemainingPreCooldownTime + "s\n";
				}
				else if (RemainingCooldownTime > 0f)
				{
					SkillCDStr = SkillCDStr + i + "  CD：" + RemainingCooldownTime + "s\n";
				}
			}
			else
			{
				SkillCDStr = SkillCDStr + i + "  NoCd\n";
			}
		}
		SkillCDText.SetText(FText.FromString(SkillCDStr));
	}

	private void UpdatePassiveSkillInfo()
	{
		PassiveSkillStr = "PassiveSkill:\n";
		if (Target == null)
		{
			return;
		}
		IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(Target);
		if (readOnlyData == null)
		{
			return;
		}
		foreach (KeyValuePair<int, FUStSkillSDesc> cachedSkillSDesc in readOnlyData.CachedSkillSDescs)
		{
			FUStSkillSDesc value = cachedSkillSDesc.Value;
			FUStSkillSDesc originalSkillSDesc = BGW_GameDB.GetOriginalSkillSDesc(cachedSkillSDesc.Key);
			FieldInfo[] fields = typeof(FUStSkillSDesc).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
			for (int i = 0; i < fields.Length; i++)
			{
				string text = fields[i].GetValue(value).ToString();
				string text2 = fields[i].GetValue(originalSkillSDesc).ToString();
				if (text != text2)
				{
					PassiveSkillStr = PassiveSkillStr + fields[i].Name + " (SkillSDesc): " + text + "(" + text2 + ")\n";
				}
			}
		}
		foreach (KeyValuePair<int, FUStSkillEffectDesc> cachedSkillEffectDesc in readOnlyData.CachedSkillEffectDescs)
		{
			FUStSkillEffectDesc value2 = cachedSkillEffectDesc.Value;
			FUStSkillEffectDesc originalSkillEffectDesc = BGW_GameDB.GetOriginalSkillEffectDesc(cachedSkillEffectDesc.Key);
			FieldInfo[] fields2 = typeof(FUStSkillEffectDesc).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
			for (int j = 0; j < fields2.Length; j++)
			{
				RepeatedField<float> repeatedField = fields2[j].GetValue(value2) as RepeatedField<float>;
				RepeatedField<float> repeatedField2 = fields2[j].GetValue(originalSkillEffectDesc) as RepeatedField<float>;
				if (repeatedField == null || repeatedField2 == null)
				{
					continue;
				}
				for (int k = 0; k < repeatedField.Count; k++)
				{
					if (repeatedField[k] != repeatedField2[k])
					{
						PassiveSkillStr = PassiveSkillStr + fields2[j].Name + "[" + k + "] (SkillEffectDesc): " + repeatedField[k] + "(" + repeatedField2[k] + ")\n";
					}
				}
			}
		}
		foreach (KeyValuePair<int, Dictionary<string, float>> cachedBuffModifyDatum in readOnlyData.CachedBuffModifyData)
		{
			int key = cachedBuffModifyDatum.Key;
			Dictionary<string, float> value3 = cachedBuffModifyDatum.Value;
			BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(key, value3);
			if (buffDescRuntime == null)
			{
				continue;
			}
			FUStBuffDesc originalBuffDesc = BGW_GameDB.GetOriginalBuffDesc(key);
			FieldInfo[] fields3 = typeof(FUStBuffDesc).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
			for (int l = 0; l < fields3.Length; l++)
			{
				if (fields3[l].GetValue(originalBuffDesc) is RepeatedField<FUStBuffEffectAttr> repeatedField3)
				{
					for (int m = 0; m < repeatedField3.Count; m++)
					{
						for (int n = 0; n < repeatedField3[m].EffectParamsFloat.Count; n++)
						{
							float floatEffectParam = buffDescRuntime.GetFloatEffectParam(m, n);
							float num = repeatedField3[m].EffectParamsFloat[n];
							if (floatEffectParam != num)
							{
								PassiveSkillStr = PassiveSkillStr + fields3[l].Name + "[" + m + "][EffectParamsFloat" + n + "] (BuffDesc): " + floatEffectParam + "(" + num + ")\n";
							}
						}
					}
					continue;
				}
				string text3 = "";
				string text4 = fields3[l].GetValue(originalBuffDesc).ToString();
				if (fields3[l].Name == "Duration")
				{
					text3 = buffDescRuntime.GetDuration().ToString();
				}
				else if (fields3[l].Name == "Interval")
				{
					text3 = buffDescRuntime.GetInterval().ToString();
				}
				else if (fields3[l].Name == "MaxLayer")
				{
					text3 = buffDescRuntime.GetMaxLayer().ToString();
				}
				else if (fields3[l].Name == "TargetCount")
				{
					text3 = buffDescRuntime.GetTargetCount().ToString();
				}
				else if (fields3[l].Name == "Range")
				{
					text3 = buffDescRuntime.GetRangeParam(0).ToString();
					text4 = originalBuffDesc.Range.RangeParam[0].ToString();
				}
				if (text3 != text4)
				{
					PassiveSkillStr = PassiveSkillStr + fields3[l].Name + " (BuffDesc): " + text3 + "(" + text4 + ")\n";
				}
			}
		}
		PassiveSkillText.SetText(FText.FromString(PassiveSkillStr));
	}

	private void ChangeInfoValueByName(string infoname, string infovalue)
	{
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_GMUnitInfo_Right");
		InfoTemp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InfoTemp");
		InfoTemp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InfoTemp", Classes.FClassProperty);
	}

	static BUI_GMUnitInfo_Right()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.UI.BUI_GMUnitInfo_Right)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.UI.BUI_GMUnitInfo_Right));
	}
}
