using System.Collections.Generic;
using System.IO;
using b1.GSFile;
using b1.Localization;
using BtlShare;
using LitJson;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_GMUnitDataComp : UActorCompBaseCS
{
	private BGUCharacterCS TargetCharacter;

	private IBUC_AttrContainer AttrContainer;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SimpleStateData UnitSimpleStateData;

	private BUC_BuffData BuffData;

	private GMUnitData TargetGMUnitData = new GMUnitData();

	private readonly string FilePath = "GSGMUnitData";

	private bool IsInitSuccess;

	public override void OnAttach()
	{
	}

	public override void OnBeginPlay()
	{
		TargetCharacter = UGameplayStatics.GetPlayerCharacter(GetOwner().World, 0) as BGUCharacterCS;
		InitCharacterData(TargetCharacter);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
	}

	private void CheckCharacterData()
	{
		if (!IsInitSuccess || TargetCharacter.IsNullOrDestroyed() || UnitStateData.HasState(EBGUUnitState.Dead))
		{
			return;
		}
		TargetGMUnitData.DictBuff.Clear();
		foreach (BuffInstData allBuffInstDatum in BuffData.GetAllBuffInstData())
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("Duration", allBuffInstDatum.Duration.ToString());
			dictionary.Add("Layer", allBuffInstDatum.Layer.ToString());
			TargetGMUnitData.DictBuff.Add(allBuffInstDatum.BuffID.ToString(), dictionary);
		}
		TargetGMUnitData.HasStateList.Clear();
		for (int i = 0; i < 45; i++)
		{
			if (UnitStateData.HasState((EBGUUnitState)i))
			{
				TargetGMUnitData.HasStateList.Add(((EBGUUnitState)i/*cast due to .constrained prefix*/).ToString());
			}
		}
		TargetGMUnitData.HasSimpleStateList.Clear();
		for (int j = 0; j < 174; j++)
		{
			if (UnitSimpleStateData.HasSimpleState((EBGUSimpleState)j))
			{
				TargetGMUnitData.HasSimpleStateList.Add(((EBGUSimpleState)j/*cast due to .constrained prefix*/).ToString());
			}
		}
		TargetGMUnitData.DictAttr.Clear();
		TargetGMUnitData.DictAttr.Add("血量", AttrContainer.GetFloatValue(EBGUAttrFloat.Hp) + "/" + AttrContainer.GetFloatValMax(EBGUAttrFloat.Hp));
		TargetGMUnitData.DictAttr.Add("蓝量", AttrContainer.GetFloatValue(EBGUAttrFloat.Mp) + "/" + AttrContainer.GetFloatValMax(EBGUAttrFloat.Mp));
		TargetGMUnitData.DictAttr.Add("攻击力", AttrContainer.GetFloatValue(EBGUAttrFloat.Atk).ToString());
		TargetGMUnitData.DictAttr.Add("防御力", AttrContainer.GetFloatValue(EBGUAttrFloat.Def).ToString());
		TargetGMUnitData.DictAttr.Add("体力", AttrContainer.GetFloatValue(EBGUAttrFloat.Stamina) + "/" + AttrContainer.GetFloatValMax(EBGUAttrFloat.Stamina));
		TargetGMUnitData.DictAttr.Add("暴击率", AttrContainer.GetFloatValue(EBGUAttrFloat.CritRate).ToString());
	}

	private void SaveDataToFile()
	{
		string contents = JsonMapper.ToJson(TargetGMUnitData);
		if (!Directory.Exists(GSEFileUtil.ProjectPersistentDownloadDir))
		{
			Directory.CreateDirectory(GSEFileUtil.ProjectPersistentDownloadDir);
		}
		File.WriteAllText(Path.Combine(GSEFileUtil.ProjectPersistentDownloadDir, FilePath), contents);
	}

	private void InitCharacterData(BGUCharacterCS HitCharacter)
	{
		TargetGMUnitData.ClearData();
		if (HitCharacter.IsNullOrDestroyed())
		{
			return;
		}
		TargetCharacter = HitCharacter;
		AttrContainer = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(TargetCharacter);
		UnitStateData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(TargetCharacter);
		UnitSimpleStateData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(TargetCharacter);
		BuffData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(TargetCharacter);
		if (AttrContainer != null && UnitStateData != null && UnitSimpleStateData != null && BuffData != null)
		{
			int resID = TargetCharacter.GetResID();
			TargetGMUnitData.ResID = resID;
			FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(TargetCharacter.GetFinalBattleInfoExtendID());
			if (unitBattleInfoExtendDesc != null)
			{
				TargetGMUnitData.Name = unitBattleInfoExtendDesc.UnitName.ToFText().ToString();
				IsInitSuccess = true;
			}
		}
	}

	private void OnAnyKeyInput(bool IsPressed, FKey Key)
	{
		if (IsPressed && Key.Equals(EKeys.LeftMouseButton))
		{
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetOwner());
			if (!(firstLocalPlayerController == null) && firstLocalPlayerController.DeprojectMousePositionToWorld(out var _, out var WorldDirection))
			{
				FVector worldLocation = UGSE_EngineFuncLib.GetLocalPlayerCameraManager(firstLocalPlayerController).TransformComponent.GetWorldLocation();
				FVector end = worldLocation + WorldDirection * 100000.0;
				FLinearColor fLinearColor = new FLinearColor(1f, 0f, 0f);
				firstLocalPlayerController.World.LineTraceSingle(worldLocation, end, ETraceTypeQuery.TraceTypeQuery4, bTraceComplex: true, null, EDrawDebugTrace.None, out var _, bIgnoreSelf: true, fLinearColor, fLinearColor, 2f);
			}
		}
	}
}
