using System;
using System.Collections.Generic;
using System.Linq;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public abstract class BUS_DispLibUnitArtFresnelCompBase : BUS_DispLibCompBase
{
	protected BUC_DispLibUnitArtFresnelRequestsQueueData RequestsQueueData;

	protected BUC_DispLibUnitRendererBaseData UnitRendererBaseData;

	protected abstract BUC_DispLibUnitArtFresnelRequestsQueueData GetRequestsQueueData();

	protected abstract BUC_DispLibUnitRendererBaseData GetUnitCommonData();

	protected abstract BUC_DispLibUnitArtFresnelDataAsset GetSourceUniversalUAFDataAssetByIndex(int Index);

	protected abstract void SetUnitMatsScalarParam(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, FName ParamName, float FloatValue);

	protected abstract void SetUnitMatsFLinearColorParam(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, FName ParamName, FLinearColor FLinearColorValue);

	private bool Interior_CheckCompMatached(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, UPrimitiveComponent MeshComp)
	{
		if (UnitRendererBaseData == null)
		{
			return false;
		}
		if (MeshComp.IsNullOrDestroyed() || UnitRendererBaseData.MeshComp2TagList == null)
		{
			return false;
		}
		if (!UnitRendererBaseData.MeshComp2TagList.TryGetValue(MeshComp, out var value))
		{
			return false;
		}
		switch (FilterMode.CompsFilterMode)
		{
		case DispLibDBCCompsFilterMode.AllComps:
			return true;
		case DispLibDBCCompsFilterMode.ByTags:
			foreach (FName compTag in FilterMode.CompTags)
			{
				if (value.Contains(compTag))
				{
					return true;
				}
			}
			return false;
		case DispLibDBCCompsFilterMode.ByExcludeTags:
			foreach (FName compTag2 in FilterMode.CompTags)
			{
				if (value.Contains(compTag2))
				{
					return false;
				}
			}
			return true;
		default:
			return false;
		}
	}

	public override void OnBeginPlay()
	{
		RequestsQueueData = GetRequestsQueueData();
		if (RequestsQueueData != null)
		{
			_ = RequestsQueueData.Queue;
		}
		UnitRendererBaseData = GetUnitCommonData();
	}

	protected void RequestPauseOneUAF(uint UAFID, bool Pause)
	{
		if (UAFID == 0)
		{
			return;
		}
		foreach (KeyValuePair<UPrimitiveComponent, BUC_DispLibOneUnitArtFresnelData[]> item in RequestsQueueData.Queue)
		{
			BUC_DispLibOneUnitArtFresnelData[] value = item.Value;
			foreach (BUC_DispLibOneUnitArtFresnelData bUC_DispLibOneUnitArtFresnelData in value)
			{
				if (bUC_DispLibOneUnitArtFresnelData == null || !bUC_DispLibOneUnitArtFresnelData.Active || bUC_DispLibOneUnitArtFresnelData.isPause == Pause)
				{
					break;
				}
				PauseOneRequest(bUC_DispLibOneUnitArtFresnelData, Pause);
			}
		}
	}

	protected void RequestEndAllUAF()
	{
		foreach (KeyValuePair<UPrimitiveComponent, BUC_DispLibOneUnitArtFresnelData[]> item in RequestsQueueData.Queue)
		{
			BUC_DispLibOneUnitArtFresnelData[] value = item.Value;
			foreach (BUC_DispLibOneUnitArtFresnelData bUC_DispLibOneUnitArtFresnelData in value)
			{
				if (bUC_DispLibOneUnitArtFresnelData == null || !bUC_DispLibOneUnitArtFresnelData.Active)
				{
					break;
				}
				DeactiveOneRequest(bUC_DispLibOneUnitArtFresnelData);
			}
		}
	}

	protected void RequestEndOneUAF(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, uint UAFID)
	{
		if (UAFID == 0)
		{
			return;
		}
		bool flag = false;
		foreach (KeyValuePair<UPrimitiveComponent, BUC_DispLibOneUnitArtFresnelData[]> item in RequestsQueueData.Queue)
		{
			UPrimitiveComponent key = item.Key;
			BUC_DispLibOneUnitArtFresnelData[] value = item.Value;
			if (!Interior_CheckCompMatached(FilterMode, key))
			{
				continue;
			}
			foreach (BUC_DispLibOneUnitArtFresnelData bUC_DispLibOneUnitArtFresnelData in value)
			{
				if (bUC_DispLibOneUnitArtFresnelData == null || !bUC_DispLibOneUnitArtFresnelData.Active)
				{
					break;
				}
				if (bUC_DispLibOneUnitArtFresnelData.UAFID == UAFID)
				{
					flag = true;
					DeactiveOneRequest(bUC_DispLibOneUnitArtFresnelData);
					ResortRequestsQuene(value);
					break;
				}
			}
		}
	}

	protected void RequestOneUniversalUAF(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, int UniversalDataIndex, int Priority, DispLibRefParam RefParam)
	{
		RequestOneOverrideUniversalUAF(FilterMode, UniversalDataIndex, Priority, RefParam);
	}

	protected void RequestOneOverrideUniversalUAF(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, int UniversalDataIndex, int Priority, DispLibRefParam RefParam, float OverrideTime = 0f, float OverrideOnePeriodTime = 0f, int FOverrideLoop = 0, int OverrideSimpleProgrammedCurve = 0, float OverrideFadeInTime = 0f, float OverrideCommonTime = 0f, float OverrideFadeOutTime = 0f, float OverrideProgrammedPowerMax = 0f)
	{
		RefParam.Clean();
		BUC_DispLibUnitArtFresnelDataAsset sourceUniversalUAFDataAssetByIndex = GetSourceUniversalUAFDataAssetByIndex(UniversalDataIndex);
		if (sourceUniversalUAFDataAssetByIndex == null)
		{
			BGW_LogUtil.LogError($"UAF RequestOneUniversalUAF[{UniversalDataIndex}] == null");
		}
		else
		{
			RequestOneCustomUAFByCustomDataAsset(FilterMode, sourceUniversalUAFDataAssetByIndex, Priority, RefParam, OverrideTime, OverrideOnePeriodTime, FOverrideLoop, OverrideSimpleProgrammedCurve, OverrideFadeInTime, OverrideCommonTime, OverrideFadeOutTime, OverrideProgrammedPowerMax);
		}
	}

	protected void RequestOneCustomUAFByCustomDataAsset(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, BUC_DispLibUnitArtFresnelDataAsset CustomDataAsset, int Priority, DispLibRefParam RefParam, float OverrideTime, float OverrideOnePeriodTime, int FOverrideLoop, int OverrideSimpleProgrammedCurve, float OverrideFadeInTime, float OverrideCommonTime, float OverrideFadeOutTime, float OverrideProgrammedPowerMax)
	{
		RefParam.Clean();
		if (CustomDataAsset == null)
		{
			BGW_LogUtil.LogError("UAF ApplyOneUAFDataByDataAsset  Param CustomDataAsset == null");
			return;
		}
		uint num = RequestsQueueData.RequestNewUniqueID();
		bool flag = false;
		int num2 = -1;
		foreach (KeyValuePair<UPrimitiveComponent, BUC_DispLibOneUnitArtFresnelData[]> item in RequestsQueueData.Queue)
		{
			UPrimitiveComponent key = item.Key;
			BUC_DispLibOneUnitArtFresnelData[] value = item.Value;
			if (!Interior_CheckCompMatached(FilterMode, key))
			{
				continue;
			}
			for (int i = 0; i < value.Length; i++)
			{
				BUC_DispLibOneUnitArtFresnelData bUC_DispLibOneUnitArtFresnelData = value[i];
				if (bUC_DispLibOneUnitArtFresnelData == null)
				{
					flag = true;
					bUC_DispLibOneUnitArtFresnelData = (value[i] = new BUC_DispLibOneUnitArtFresnelData());
				}
				else if (!bUC_DispLibOneUnitArtFresnelData.Active)
				{
					flag = true;
				}
				if (flag)
				{
					RefParam.DBCReturn_uintID = num;
					ActiveOneRequest(FilterMode, bUC_DispLibOneUnitArtFresnelData, CustomDataAsset, Priority, num, OverrideTime, OverrideOnePeriodTime, FOverrideLoop, OverrideSimpleProgrammedCurve, OverrideFadeInTime, OverrideCommonTime, OverrideFadeOutTime, OverrideProgrammedPowerMax);
					break;
				}
				if (Priority >= bUC_DispLibOneUnitArtFresnelData.Priority)
				{
					num2 = i;
					break;
				}
			}
			if (num2 != -1)
			{
				BUC_DispLibOneUnitArtFresnelData bUC_DispLibOneUnitArtFresnelData2 = value.Last();
				if (bUC_DispLibOneUnitArtFresnelData2 == null)
				{
					bUC_DispLibOneUnitArtFresnelData2 = new BUC_DispLibOneUnitArtFresnelData();
				}
				RefParam.DBCReturn_uintID = num;
				ActiveOneRequest(FilterMode, bUC_DispLibOneUnitArtFresnelData2, CustomDataAsset, Priority, num, OverrideTime, OverrideOnePeriodTime, FOverrideLoop, OverrideSimpleProgrammedCurve, OverrideFadeInTime, OverrideCommonTime, OverrideFadeOutTime, OverrideProgrammedPowerMax);
				for (int num3 = value.Length - 1; num3 > num2; num3--)
				{
					value[num3] = value[num3 - 1];
				}
				value[num2] = bUC_DispLibOneUnitArtFresnelData2;
			}
		}
	}

	private void ActiveOneRequest(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, BUC_DispLibOneUnitArtFresnelData CurRequestDataInQueue, BUC_DispLibUnitArtFresnelDataAsset OriginUniversalData, int Priority, uint UAFID, float OverrideTime, float OverrideOnePeriodTime, int OverrideLoop, int OverrideSimpleProgrammedCurve, float OverrideFadeInTime, float OverrideCommonTime, float OverrideFadeOutTime, float OverrideProgrammedPowerMax)
	{
		CurRequestDataInQueue.UAFID = UAFID;
		CurRequestDataInQueue.FilterMode = FilterMode;
		CurRequestDataInQueue.Active = true;
		CurRequestDataInQueue.isPause = false;
		CurRequestDataInQueue.Age = 0f;
		CurRequestDataInQueue.CurPeriodAge = 0f;
		CurRequestDataInQueue.Priority = Priority;
		CurRequestDataInQueue.Time = ((OverrideTime > 0f) ? OverrideTime : OriginUniversalData.Time);
		CurRequestDataInQueue.Loop = ((OverrideLoop <= 0) ? OriginUniversalData.Loop : (OverrideLoop == 2));
		bool flag = OverrideSimpleProgrammedCurve <= 0;
		CurRequestDataInQueue.SimpleProgrammedCurve = (flag ? OriginUniversalData.SimpleProgrammedCurve : (OverrideSimpleProgrammedCurve == 2));
		CurRequestDataInQueue.FadeInTime = ((OverrideFadeInTime > 0f) ? OverrideFadeInTime : OriginUniversalData.FadeInTime);
		CurRequestDataInQueue.FadeInTime = Math.Max(CurRequestDataInQueue.FadeInTime, 0.001f);
		CurRequestDataInQueue.CommonTime = ((OverrideCommonTime > 0f) ? OverrideCommonTime : OriginUniversalData.CommonTime);
		CurRequestDataInQueue.CommonTime = Math.Max(CurRequestDataInQueue.CommonTime, 0.001f);
		CurRequestDataInQueue.FadeOutTime = ((OverrideFadeOutTime > 0f) ? OverrideFadeOutTime : OriginUniversalData.FadeOutTime);
		CurRequestDataInQueue.FadeOutTime = Math.Max(CurRequestDataInQueue.FadeOutTime, 0.001f);
		CurRequestDataInQueue.ProgrammedPowerMax = (((double)OverrideProgrammedPowerMax > 0.001) ? OverrideProgrammedPowerMax : OriginUniversalData.ProgrammedPowerMax);
		if (CurRequestDataInQueue.SimpleProgrammedCurve)
		{
			if (flag)
			{
				CurRequestDataInQueue.OnePeriodTime = OriginUniversalData.FadeInTime + OriginUniversalData.CommonTime + OriginUniversalData.FadeOutTime;
			}
			else
			{
				CurRequestDataInQueue.OnePeriodTime = OverrideFadeInTime + OverrideCommonTime + OverrideFadeOutTime;
			}
		}
		else
		{
			CurRequestDataInQueue.OnePeriodTime = ((OverrideOnePeriodTime > 0f) ? OverrideOnePeriodTime : OriginUniversalData.OnePeriodTime);
		}
		CurRequestDataInQueue.UseVertexNormalNotTex = OriginUniversalData.UseVertexNormalNotTex;
		CurRequestDataInQueue.InvertGSArtFresnel = OriginUniversalData.InvertGSArtFresnel;
		CurRequestDataInQueue.UseContrastInsteadPower = OriginUniversalData.UseContrastInsteadPower;
		CurRequestDataInQueue.BrightValue = OriginUniversalData.BrightValue;
		CurRequestDataInQueue.DarkValue = OriginUniversalData.DarkValue;
		CurRequestDataInQueue.GSArtFresnelPower.Set(OriginUniversalData.GSArtFresnelPower);
		CurRequestDataInQueue.ClampGSArtFresnelDotProduct = OriginUniversalData.ClampGSArtFresnelDotProduct;
		CurRequestDataInQueue.UseHeightGradientRamp = OriginUniversalData.UseHeightGradientRamp;
		CurRequestDataInQueue.TopAlpha = OriginUniversalData.TopAlpha;
		CurRequestDataInQueue.BottomAlpha = OriginUniversalData.BottomAlpha;
		CurRequestDataInQueue.UnitHeight = UnitRendererBaseData.GetUnitOriginHeightFromTable();
		CurRequestDataInQueue.FColor_Out.Set(OriginUniversalData.FColor_Out);
		CurRequestDataInQueue.FColor_In.Set(OriginUniversalData.FColor_In);
	}

	private void ActiveOneRequest(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, BUC_DispLibOneUnitArtFresnelData CurRequestDataInQueue, DispLibCSharpData_ArtFresnel ArtFresnelCSharpData, uint UAFID)
	{
		CurRequestDataInQueue.UAFID = UAFID;
		CurRequestDataInQueue.FilterMode = FilterMode;
		CurRequestDataInQueue.Active = true;
		CurRequestDataInQueue.isPause = false;
		CurRequestDataInQueue.Age = 0f;
		CurRequestDataInQueue.CurPeriodAge = 0f;
		CurRequestDataInQueue.Priority = ArtFresnelCSharpData.Priority;
		CurRequestDataInQueue.Time = ArtFresnelCSharpData.Time;
		CurRequestDataInQueue.OnePeriodTime = ArtFresnelCSharpData.OnePeriodTime;
		CurRequestDataInQueue.Loop = ArtFresnelCSharpData.Loop;
		CurRequestDataInQueue.SimpleProgrammedCurve = ArtFresnelCSharpData.SimpleProgrammedCurve;
		CurRequestDataInQueue.FadeInTime = Math.Max(ArtFresnelCSharpData.FadeInTime, 0.001f);
		CurRequestDataInQueue.CommonTime = Math.Max(ArtFresnelCSharpData.CommonTime, 0.001f);
		CurRequestDataInQueue.FadeOutTime = Math.Max(ArtFresnelCSharpData.FadeOutTime, 0.001f);
		CurRequestDataInQueue.ProgrammedPowerMax = ArtFresnelCSharpData.ProgrammedPowerMax;
		CurRequestDataInQueue.UseVertexNormalNotTex = ArtFresnelCSharpData.UseVertexNormalNotTex;
		CurRequestDataInQueue.InvertGSArtFresnel = ArtFresnelCSharpData.InvertGSArtFresnel;
		CurRequestDataInQueue.UseContrastInsteadPower = ArtFresnelCSharpData.UseContrastInsteadPower;
		CurRequestDataInQueue.BrightValue = ArtFresnelCSharpData.BrightValue;
		CurRequestDataInQueue.DarkValue = ArtFresnelCSharpData.DarkValue;
		CurRequestDataInQueue.GSArtFresnelPower.Set(ArtFresnelCSharpData.GSArtFresnelPower);
		CurRequestDataInQueue.ClampGSArtFresnelDotProduct = ArtFresnelCSharpData.ClampGSArtFresnelDotProduct;
		CurRequestDataInQueue.UseHeightGradientRamp = ArtFresnelCSharpData.UseHeightGradientRamp;
		CurRequestDataInQueue.TopAlpha = ArtFresnelCSharpData.TopAlpha;
		CurRequestDataInQueue.BottomAlpha = ArtFresnelCSharpData.BottomAlpha;
		CurRequestDataInQueue.UnitHeight = UnitRendererBaseData.GetUnitOriginHeightFromTable();
		CurRequestDataInQueue.FColor_Out.Set(ArtFresnelCSharpData.FColor_Out);
		CurRequestDataInQueue.FColor_In.Set(ArtFresnelCSharpData.FColor_In);
	}

	protected void PauseOneRequest(BUC_DispLibOneUnitArtFresnelData CurQueueRequest, bool Pause)
	{
		if (CurQueueRequest != null)
		{
			CurQueueRequest.isPause = Pause;
		}
	}

	protected void DeactiveOneRequest(BUC_DispLibOneUnitArtFresnelData CurQueueRequest)
	{
		if (CurQueueRequest != null)
		{
			CurQueueRequest.UAFID = 0u;
			CurQueueRequest.Active = false;
		}
	}

	private void CheckUAFLifeCycle(BUC_DispLibOneUnitArtFresnelData[] UAFEventCacheQueue)
	{
		foreach (BUC_DispLibOneUnitArtFresnelData bUC_DispLibOneUnitArtFresnelData in UAFEventCacheQueue)
		{
			if (bUC_DispLibOneUnitArtFresnelData == null)
			{
				break;
			}
			if (!bUC_DispLibOneUnitArtFresnelData.Loop && bUC_DispLibOneUnitArtFresnelData.Age >= bUC_DispLibOneUnitArtFresnelData.Time)
			{
				DeactiveOneRequest(bUC_DispLibOneUnitArtFresnelData);
			}
			else if (bUC_DispLibOneUnitArtFresnelData.CurPeriodAge >= bUC_DispLibOneUnitArtFresnelData.OnePeriodTime)
			{
				if (bUC_DispLibOneUnitArtFresnelData.Loop || bUC_DispLibOneUnitArtFresnelData.Age <= bUC_DispLibOneUnitArtFresnelData.Time)
				{
					bUC_DispLibOneUnitArtFresnelData.CurPeriodAge = 0f;
				}
				else
				{
					DeactiveOneRequest(bUC_DispLibOneUnitArtFresnelData);
				}
			}
		}
	}

	private void ResortRequestsQuene(BUC_DispLibOneUnitArtFresnelData[] UAFEventCacheQueue)
	{
		for (int i = 0; i < UAFEventCacheQueue.Length; i++)
		{
			bool flag = false;
			for (int j = 0; j < UAFEventCacheQueue.Length - 1 - i && UAFEventCacheQueue[j + 1] != null; j++)
			{
				if (!UAFEventCacheQueue[j].Active && UAFEventCacheQueue[j + 1].Active)
				{
					BUC_DispLibOneUnitArtFresnelData bUC_DispLibOneUnitArtFresnelData = UAFEventCacheQueue[j];
					UAFEventCacheQueue[j] = UAFEventCacheQueue[j + 1];
					UAFEventCacheQueue[j + 1] = bUC_DispLibOneUnitArtFresnelData;
					if (!flag)
					{
						flag = true;
					}
				}
				else if (UAFEventCacheQueue[j].Priority < UAFEventCacheQueue[j + 1].Priority)
				{
					BUC_DispLibOneUnitArtFresnelData bUC_DispLibOneUnitArtFresnelData = UAFEventCacheQueue[j];
					UAFEventCacheQueue[j] = UAFEventCacheQueue[j + 1];
					UAFEventCacheQueue[j + 1] = bUC_DispLibOneUnitArtFresnelData;
					if (!flag)
					{
						flag = true;
					}
				}
			}
			if (!flag)
			{
				break;
			}
		}
	}

	private float GetCurTime()
	{
		return BGU_DispLibDataUtil.GSTimeAfterBeginPlay(GetOwner());
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		bool flag = false;
		foreach (KeyValuePair<UPrimitiveComponent, BUC_DispLibOneUnitArtFresnelData[]> item in RequestsQueueData.Queue)
		{
			_ = item.Key;
			BUC_DispLibOneUnitArtFresnelData[] value = item.Value;
			foreach (BUC_DispLibOneUnitArtFresnelData bUC_DispLibOneUnitArtFresnelData in value)
			{
				if (bUC_DispLibOneUnitArtFresnelData == null || !bUC_DispLibOneUnitArtFresnelData.Active)
				{
					break;
				}
				bUC_DispLibOneUnitArtFresnelData.Age += DeltaTime;
				bUC_DispLibOneUnitArtFresnelData.CurPeriodAge += DeltaTime;
				if (bUC_DispLibOneUnitArtFresnelData.Age >= bUC_DispLibOneUnitArtFresnelData.Time || bUC_DispLibOneUnitArtFresnelData.CurPeriodAge >= bUC_DispLibOneUnitArtFresnelData.OnePeriodTime)
				{
					flag = true;
				}
			}
			BUC_DispLibOneUnitArtFresnelData bUC_DispLibOneUnitArtFresnelData2 = value[0];
			if (bUC_DispLibOneUnitArtFresnelData2 != null && bUC_DispLibOneUnitArtFresnelData2.Active && !bUC_DispLibOneUnitArtFresnelData2.isPause)
			{
				RequestsQueueData.ApplyAnyUAF = true;
				float inTime = FMath.Clamp(bUC_DispLibOneUnitArtFresnelData2.CurPeriodAge / bUC_DispLibOneUnitArtFresnelData2.OnePeriodTime, 0f, 1f);
				BUC_DispLibDBC_MaterialEffectTargetInfo filterMode = bUC_DispLibOneUnitArtFresnelData2.FilterMode;
				GetCurTime();
				_ = bUC_DispLibOneUnitArtFresnelData2.Age;
				SetUnitMatsScalarParam(filterMode, BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.UseGSArtFresnel, 1f);
				SetUnitMatsScalarParam(filterMode, BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.InvertGSArtFresnel, bUC_DispLibOneUnitArtFresnelData2.InvertGSArtFresnel ? 1f : 0f);
				SetUnitMatsScalarParam(filterMode, BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.ClampGSArtFresnelDotProduct, bUC_DispLibOneUnitArtFresnelData2.ClampGSArtFresnelDotProduct ? 1f : 0f);
				SetUnitMatsScalarParam(filterMode, BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.UseUAFHeightGradientRamp, bUC_DispLibOneUnitArtFresnelData2.UseHeightGradientRamp ? 1f : 0f);
				SetUnitMatsScalarParam(filterMode, BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.UAFUseVertexNormalNotTex, bUC_DispLibOneUnitArtFresnelData2.UseVertexNormalNotTex ? 1f : 0f);
				if (bUC_DispLibOneUnitArtFresnelData2.UseContrastInsteadPower)
				{
					SetUnitMatsScalarParam(filterMode, BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.UseContrastInsteadPower, 1f);
					SetUnitMatsScalarParam(filterMode, BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.BrightValue, bUC_DispLibOneUnitArtFresnelData2.BrightValue);
					SetUnitMatsScalarParam(filterMode, BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.DarkValue, bUC_DispLibOneUnitArtFresnelData2.DarkValue);
				}
				else
				{
					SetUnitMatsScalarParam(filterMode, BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.UseContrastInsteadPower, 0f);
				}
				if (!bUC_DispLibOneUnitArtFresnelData2.UseContrastInsteadPower)
				{
					if (bUC_DispLibOneUnitArtFresnelData2.SimpleProgrammedCurve)
					{
						float num = 0f;
						float floatValue = 1f;
						if (bUC_DispLibOneUnitArtFresnelData2.CurPeriodAge <= bUC_DispLibOneUnitArtFresnelData2.FadeInTime)
						{
							num = ((bUC_DispLibOneUnitArtFresnelData2.FadeInTime <= 0.001f) ? 1f : FMath.Clamp(bUC_DispLibOneUnitArtFresnelData2.CurPeriodAge / bUC_DispLibOneUnitArtFresnelData2.FadeInTime, 0f, 1f));
							floatValue = FMath.Lerp(0f, bUC_DispLibOneUnitArtFresnelData2.ProgrammedPowerMax, num);
						}
						else if (bUC_DispLibOneUnitArtFresnelData2.CurPeriodAge <= bUC_DispLibOneUnitArtFresnelData2.FadeInTime + bUC_DispLibOneUnitArtFresnelData2.CommonTime)
						{
							floatValue = bUC_DispLibOneUnitArtFresnelData2.ProgrammedPowerMax;
						}
						else if (bUC_DispLibOneUnitArtFresnelData2.CurPeriodAge <= bUC_DispLibOneUnitArtFresnelData2.FadeInTime + bUC_DispLibOneUnitArtFresnelData2.CommonTime + bUC_DispLibOneUnitArtFresnelData2.FadeOutTime)
						{
							num = FMath.Clamp((bUC_DispLibOneUnitArtFresnelData2.CurPeriodAge - bUC_DispLibOneUnitArtFresnelData2.FadeInTime - bUC_DispLibOneUnitArtFresnelData2.CommonTime) / bUC_DispLibOneUnitArtFresnelData2.FadeOutTime, 0f, 1f);
							floatValue = FMath.Lerp(bUC_DispLibOneUnitArtFresnelData2.ProgrammedPowerMax, 0f, num);
						}
						SetUnitMatsScalarParam(filterMode, BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.GSArtFresnelPower, floatValue);
					}
					else if (!bUC_DispLibOneUnitArtFresnelData2.GSArtFresnelPower.Get().IsNullOrDestroyed())
					{
						float floatValue2 = bUC_DispLibOneUnitArtFresnelData2.GSArtFresnelPower.Get().GetFloatValue(inTime);
						SetUnitMatsScalarParam(filterMode, BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.GSArtFresnelPower, floatValue2);
					}
				}
				if (bUC_DispLibOneUnitArtFresnelData2.UseHeightGradientRamp)
				{
					SetUnitMatsScalarParam(filterMode, BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.GSUnitHeight, bUC_DispLibOneUnitArtFresnelData2.UnitHeight);
					SetUnitMatsScalarParam(filterMode, BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.UAFTopAlpha, bUC_DispLibOneUnitArtFresnelData2.TopAlpha);
					SetUnitMatsScalarParam(filterMode, BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.UAFBottomAlpha, bUC_DispLibOneUnitArtFresnelData2.BottomAlpha);
				}
				if (!bUC_DispLibOneUnitArtFresnelData2.FColor_Out.Get().IsNullOrDestroyed())
				{
					FLinearColor linearColorValue = bUC_DispLibOneUnitArtFresnelData2.FColor_Out.Get().GetLinearColorValue(inTime);
					SetUnitMatsFLinearColorParam(filterMode, B1GlobalFNames.GSArtFresnelColor_Out, linearColorValue);
				}
				if (!bUC_DispLibOneUnitArtFresnelData2.FColor_In.Get().IsNullOrDestroyed())
				{
					FLinearColor linearColorValue2 = bUC_DispLibOneUnitArtFresnelData2.FColor_In.Get().GetLinearColorValue(inTime);
					SetUnitMatsFLinearColorParam(filterMode, B1GlobalFNames.GSArtFresnelColor_In, linearColorValue2);
				}
			}
			else if (RequestsQueueData.ApplyAnyUAF)
			{
				SetUnitMatsScalarParam(BUC_DispLibDBC_MaterialEffectTargetInfo.AllCompsAllMats, BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.UseGSArtFresnel, 0f);
			}
			if (flag)
			{
				CheckUAFLifeCycle(value);
				ResortRequestsQuene(value);
			}
		}
	}
}
