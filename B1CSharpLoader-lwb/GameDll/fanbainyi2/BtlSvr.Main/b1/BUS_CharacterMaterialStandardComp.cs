using System.Collections.Generic;
using b1.BGW;
using BtlB1;
using GSDispLib;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_CharacterMaterialStandardComp : UActorCompBaseCS
{
	private UBUC_ACharacterComponent CharComp;

	private BUC_CharacterMaterialData MatData;

	private BUS_DispLibEventCollection DispLibBE;

	public override void OnAttach()
	{
		CharComp = RequireWritableData<UBUC_ACharacterComponent>();
		MatData = RequireWritableData<BUC_CharacterMaterialData>();
		DispLibBE = BUS_DispLibEventCollection.Get(this);
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
		InitChangeMaterialByAttrRequest();
	}

	public override void OnBeginPlay()
	{
	}

	private void InitChangeMaterialByAttrRequest()
	{
		FUStUnitChangeMaterialByAttrDesc unitChangeMaterialByAttrDesc = BGW_GameDB.GetUnitChangeMaterialByAttrDesc(GetActorResID());
		if (unitChangeMaterialByAttrDesc == null)
		{
			return;
		}
		BGWDataAsset_ChangeMaterialByUnitAttrConfig bGWDataAsset_ChangeMaterialByUnitAttrConfig = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<BGWDataAsset_ChangeMaterialByUnitAttrConfig>(unitChangeMaterialByAttrDesc.ConfigDAPath, ELoadResourceType.AsyncLoadAndCache);
		if (bGWDataAsset_ChangeMaterialByUnitAttrConfig == null)
		{
			return;
		}
		MatData.ChangeMaterialByAttrRequest.Clear();
		foreach (FChangeMaterialByUnitAttrConfig config in bGWDataAsset_ChangeMaterialByUnitAttrConfig.ConfigList)
		{
			if (!MatData.ChangeMaterialByAttrRequest.TryGetValue(config.UnitAttrType, out var value))
			{
				value = new List<MaterialParameterConfig>();
				MatData.ChangeMaterialByAttrRequest.Add(config.UnitAttrType, value);
			}
			BUChangeMaterialUnitAttrTemplate changeMaterialUnitAttrTemplate = BGW_EffectTemplateList.Get(Owner).GetChangeMaterialUnitAttrTemplate(config.UnitAttrType);
			foreach (FMaterialParameterConfig item in config.MaterialParameterConfig)
			{
				MaterialParameterConfig materialParameterConfig = new MaterialParameterConfig();
				materialParameterConfig.InterpSpeed = item.InterpSpeed;
				materialParameterConfig.AttrValueMapCurve = item.AttrValueMapCurve;
				materialParameterConfig.ParameterAssociation = item.ParameterAssociation;
				materialParameterConfig.ParameterName = item.ParameterName;
				materialParameterConfig.ParameterLayerFunction = item.ParameterLayerFunction;
				materialParameterConfig.LastInputValue = changeMaterialUnitAttrTemplate?.GetAttrValue(Owner) ?? 0f;
				value.Add(materialParameterConfig);
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickForChangeMaterialByUnitAttr(DeltaTime);
	}

	private void TickForChangeMaterialByUnitAttr(float DeltaTime)
	{
		if (MatData.ChangeMaterialByAttrRequest.Count == 0)
		{
			InitChangeMaterialByAttrRequest();
		}
		foreach (KeyValuePair<EChangeMatUnitAttrType, List<MaterialParameterConfig>> item in MatData.ChangeMaterialByAttrRequest)
		{
			BUChangeMaterialUnitAttrTemplate changeMaterialUnitAttrTemplate = BGW_EffectTemplateList.Get(Owner).GetChangeMaterialUnitAttrTemplate(item.Key);
			if (changeMaterialUnitAttrTemplate == null)
			{
				continue;
			}
			float attrValue = changeMaterialUnitAttrTemplate.GetAttrValue(Owner);
			foreach (MaterialParameterConfig item2 in item.Value)
			{
				float num = FMath.FInterpTo(item2.LastInputValue, attrValue, DeltaTime, item2.InterpSpeed);
				float scalarValue = ((item2.AttrValueMapCurve != null) ? item2.AttrValueMapCurve.GetFloatValue(num) : num);
				DispLibBE.Evt_SetUnitMatsScalarParamByInfo_Immed(BUC_DispLibDBC_MaterialEffectTargetInfo.AllCompsAllMats, item2.ParameterAssociation, item2.ParameterName, item2.ParameterLayerFunction, scalarValue, 0f, 0);
				item2.LastInputValue = num;
			}
		}
	}
}
