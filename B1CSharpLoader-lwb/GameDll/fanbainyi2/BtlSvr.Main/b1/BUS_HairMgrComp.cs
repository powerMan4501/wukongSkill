using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using b1.Plugins.TressFX;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_HairMgrComp : UActorCompBaseCS
{
	private b1.BUC_HairMgrData HairMgrData;

	public override void OnAttach()
	{
		HairMgrData = RequireWritableData<b1.BUC_HairMgrData>();
		base.BUSEventCollection.Evt_BeginForSetCurveValueToHair += new Del_BeginForSetCurveValueToHair(BeginForSetCurveValueToHair);
		base.BUSEventCollection.Evt_OverForSetCurveValueToHair += new Del_OverForSetCurveValueToHair(OverForSetCurveValueToHair);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickForSetCurveValueToMesh(DeltaTime);
	}

	private void BeginForSetCurveValueToHair(int InstID, EGSHairType HairType, TArrayReadWrite<FName> HairCompTagList, TArrayReadWrite<FGSFloatCurveToParam> FloatCurveParamList, float TotalDuration)
	{
		if (HairMgrData.SetCurveValueToHairDic.ContainsKey(InstID))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS == null && bGUCharacterCS.IsPendingKill)
		{
			return;
		}
		SetCurveValueToHairUnitInfo setCurveValueToHairUnitInfo = new SetCurveValueToHairUnitInfo();
		setCurveValueToHairUnitInfo.CurTime = 0f;
		setCurveValueToHairUnitInfo.TotalTime = TotalDuration;
		setCurveValueToHairUnitInfo.HairType = HairType;
		setCurveValueToHairUnitInfo.FloatCurveParamList = FloatCurveParamList.ToList();
		for (int i = 0; i < HairCompTagList.Count; i++)
		{
			switch (HairType)
			{
			case EGSHairType.TressFX:
				foreach (UActorComponent item in bGUCharacterCS.GetComponentsByTag(UClass.GetClass<UTressFXComponent>(), HairCompTagList[i]))
				{
					UTressFXComponent uTressFXComponent = item as UTressFXComponent;
					if (uTressFXComponent != null)
					{
						setCurveValueToHairUnitInfo.TressFXCompList.Add(uTressFXComponent);
					}
				}
				break;
			case EGSHairType.HairStrands:
				foreach (UActorComponent item2 in bGUCharacterCS.GetComponentsByTag(UClass.GetClass<UMeshComponent>(), HairCompTagList[i]))
				{
					UMeshComponent uMeshComponent = item2 as UMeshComponent;
					if (uMeshComponent != null)
					{
						setCurveValueToHairUnitInfo.HairStrandsCompList.Add(uMeshComponent);
					}
				}
				break;
			}
		}
		HairMgrData.SetCurveValueToHairDic.Add(InstID, setCurveValueToHairUnitInfo);
		SetCurveValueToHairUnitInfoByTime(setCurveValueToHairUnitInfo, 0f);
	}

	private void TickForSetCurveValueToMesh(float DeltaTime)
	{
		if (HairMgrData.SetCurveValueToHairDic.Count >= 1)
		{
			int[] array = HairMgrData.SetCurveValueToHairDic.Keys.ToArray();
			foreach (int key in array)
			{
				SetCurveValueToHairUnitInfo setCurveValueToHairUnitInfo = HairMgrData.SetCurveValueToHairDic[key];
				setCurveValueToHairUnitInfo.CurTime += DeltaTime;
				float time = setCurveValueToHairUnitInfo.CurTime / setCurveValueToHairUnitInfo.TotalTime;
				MathLib.Clamp(setCurveValueToHairUnitInfo.CurTime, 0f, 1f);
				SetCurveValueToHairUnitInfoByTime(setCurveValueToHairUnitInfo, time);
			}
		}
	}

	private void SetCurveValueToHairUnitInfoByTime(SetCurveValueToHairUnitInfo _SetCurveValueToHairUnitInfo, float Time, bool IsEnd = false)
	{
		foreach (FGSFloatCurveToParam floatCurveParam in _SetCurveValueToHairUnitInfo.FloatCurveParamList)
		{
			float num = 0f;
			if (floatCurveParam.NotUseCurve)
			{
				if (Time != 0f)
				{
					continue;
				}
				num = ((!IsEnd) ? floatCurveParam.TargetFloatValue : floatCurveParam.OriFloatValue);
			}
			else
			{
				if (floatCurveParam.CurveFloat == null)
				{
					continue;
				}
				num = floatCurveParam.CurveFloat.GetFloatValue(Time);
			}
			if (_SetCurveValueToHairUnitInfo.HairType == EGSHairType.TressFX)
			{
				foreach (UTressFXComponent tressFXComp in _SetCurveValueToHairUnitInfo.TressFXCompList)
				{
					SetParamToTressFXMatInst(tressFXComp, floatCurveParam.ParamName, num, floatCurveParam.Association, floatCurveParam.LayerFunction);
				}
			}
			else
			{
				if (_SetCurveValueToHairUnitInfo.HairType != EGSHairType.HairStrands)
				{
					continue;
				}
				foreach (UMeshComponent hairStrandsComp in _SetCurveValueToHairUnitInfo.HairStrandsCompList)
				{
					SetVisibleToHairStrands(hairStrandsComp, num);
				}
			}
		}
	}

	private void OverForSetCurveValueToHair(int NotifyInstID, bool NeedRecovery)
	{
		if (HairMgrData.SetCurveValueToHairDic.ContainsKey(NotifyInstID))
		{
			SetCurveValueToHairUnitInfo setCurveValueToHairUnitInfo = HairMgrData.SetCurveValueToHairDic[NotifyInstID];
			float time = 0f;
			if (!NeedRecovery)
			{
				time = 1f;
			}
			SetCurveValueToHairUnitInfoByTime(setCurveValueToHairUnitInfo, time, IsEnd: true);
			HairMgrData.SetCurveValueToHairDic.Remove(NotifyInstID);
		}
	}

	private void SetParamToTressFXMatInst(UTressFXComponent TressFX, FName ParameterName, float ParamValue, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction = null)
	{
		if (TressFX == null)
		{
			return;
		}
		UMaterialInterface hairMaterial = TressFX.HairMaterial;
		if (!(hairMaterial != null))
		{
			return;
		}
		UMaterialInstanceDynamic uMaterialInstanceDynamic = hairMaterial as UMaterialInstanceDynamic;
		if (uMaterialInstanceDynamic == null)
		{
			uMaterialInstanceDynamic = UMaterialLibrary.CreateDynamicMaterialInstance(Owner.World, hairMaterial, FName.None, EMIDCreationFlags.None);
			TressFX.SetMaterial(0, uMaterialInstanceDynamic);
		}
		if (uMaterialInstanceDynamic != null)
		{
			if (Association == EMaterialParameterAssociation.GlobalParameter)
			{
				uMaterialInstanceDynamic.SetScalarParameterValue(ParameterName, ParamValue);
				return;
			}
			FMaterialParameterInfo matParameterInfo = GetMatParameterInfo(TressFX, uMaterialInstanceDynamic, ParameterName, Association, LayerFunction);
			uMaterialInstanceDynamic.SetScalarParameterValueByInfo(matParameterInfo, ParamValue);
		}
	}

	private FMaterialParameterInfo GetMatParameterInfo(UTressFXComponent TressFX, UMaterialInstanceDynamic DynamicMaterial, FName ParameterName, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction)
	{
		int uniqueID = (int)TressFX.GetUniqueID();
		FMaterialParameterInfo result = default(FMaterialParameterInfo);
		if (HairMgrData.MatParameterLayerIndexCache.ContainsKey(uniqueID))
		{
			if (HairMgrData.MatParameterLayerIndexCache[uniqueID].ContainsKey(ParameterName))
			{
				result.Association = Association;
				result.Name = ParameterName;
				result.Index = HairMgrData.MatParameterLayerIndexCache[uniqueID][ParameterName];
			}
			else
			{
				result = DynamicMaterial.GetParameterInfo(Association, ParameterName, LayerFunction);
				HairMgrData.MatParameterLayerIndexCache[uniqueID].Add(ParameterName, result.Index);
			}
		}
		else
		{
			result = DynamicMaterial.GetParameterInfo(Association, ParameterName, LayerFunction);
			Dictionary<FName, int> dictionary = new Dictionary<FName, int>();
			dictionary.Add(ParameterName, result.Index);
			HairMgrData.MatParameterLayerIndexCache.Add(uniqueID, dictionary);
		}
		return result;
	}

	private void SetVisibleToHairStrands(UMeshComponent HairStrands, float ParamValue)
	{
		if (ParamValue > 0f)
		{
			if (!HairStrands.IsVisible())
			{
				HairStrands.SetVisibility(bNewVisibility: true);
			}
		}
		else if (HairStrands.IsVisible())
		{
			HairStrands.SetVisibility(bNewVisibility: false);
		}
	}
}
