using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_RenderTargetMgr : GameStateSystemBase
{
	public static readonly bool IS_EDITOR_DEBUG = true;

	private BGC_RenderTargetData RenderTargetData;

	public override void OnAttach()
	{
		RenderTargetData = RequireWritableData<BGC_RenderTargetData>();
		base.BGSEventCollection.Evt_BGS_DrawUseMatPainter += new Del_BGS_DrawUseMatPainter(OnDrawUseMatPainter);
		base.BGSEventCollection.Evt_BGS_AddOrUpdateEndTickGameTimeForSurfaceType += new Del_BGS_AddOrUpdateEndTickGameTimeForSurfaceType(OnAddOrUpdateEndTickGameTimeForSurfaceType);
		base.BGSEventCollection.Evt_BGS_PushParamsToPainterMaterial += new Del_BGS_PushParamsToMaterial(OnPushParamsToPainterMaterial);
		base.BGSEventCollection.Evt_BGS_PushParamsToCanvasMaterial += new Del_BGS_PushParamsToMaterial(OnPushParamsToCanvasMaterial);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Combine(bGWEventCollection.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(OnTriggerResetAllActors));
	}

	public override void PreBeginPlay()
	{
		InitCanvas();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_TriggerResetAllActors = (BGW_EventCollection.Del_TriggerResetAllActors)Delegate.Remove(bGWEventCollection.Evt_TriggerResetAllActors, new BGW_EventCollection.Del_TriggerResetAllActors(OnTriggerResetAllActors));
		OnTriggerResetAllActors(EResetActorReason.None);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		HashSet<ESceneItemSurfaceType> hashSet = new HashSet<ESceneItemSurfaceType>();
		foreach (KeyValuePair<ESceneItemSurfaceType, float> pendingTickSurfaceType in RenderTargetData.PendingTickSurfaceTypes)
		{
			if (pendingTickSurfaceType.Value >= UGSE_EngineFuncLib.GetWorldFromObj(Owner).GetTimeSeconds())
			{
				DrawUseMatCanvas(pendingTickSurfaceType.Key, EMatPainterType.Line);
			}
			else
			{
				hashSet.Add(pendingTickSurfaceType.Key);
			}
		}
		foreach (ESceneItemSurfaceType item in hashSet)
		{
			RenderTargetData.PendingTickSurfaceTypes.Remove(item);
		}
		if (RenderTargetData.DrawStateMap == null || RenderTargetData.DrawStateMap.Count <= 0)
		{
			return;
		}
		foreach (ESceneItemSurfaceType key in RenderTargetData.DrawStateMap.Keys)
		{
			DrawUseMatCanvas(key, EMatPainterType.Point);
		}
	}

	private UTextureRenderTarget2D CreateRT(int RTSize)
	{
		UTextureRenderTarget2D uTextureRenderTarget2D = URenderingLibrary.CreateRenderTarget2D(Owner, RTSize, RTSize, ETextureRenderTargetFormat.RTF_RGBA16f, FLinearColor.Black, bAutoGenerateMipMaps: false);
		uTextureRenderTarget2D.AutoGenerateMips = false;
		uTextureRenderTarget2D.LODGroup = ETextureGroup.TEXTUREGROUP_RenderTarget;
		return uTextureRenderTarget2D;
	}

	private void ClearRT(UTextureRenderTarget2D RT)
	{
		if (RT != null)
		{
			URenderingLibrary.ClearRenderTarget2D(Owner, RT, FLinearColor.Black);
		}
	}

	private void InitCanvas()
	{
		RenderTargetData.GlobalRTConfig = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWDataAsset_GlobalRenderTargetConfig>(BGWDataAsset_GlobalRenderTargetConfig.Path, ELoadResourceType.SyncLoadAndCache);
		foreach (KeyValuePair<ESceneItemSurfaceType, CanvasPainterData> item in RenderTargetData.GlobalRTConfig.CanvasPainterMap)
		{
			RenderTargetData.DrawStateMap.Add(item.Key, value: true);
			if (IS_EDITOR_DEBUG)
			{
				ClearRT(item.Value.RTPing.Value);
				ClearRT(item.Value.RTPong.Value);
				ClearRT(item.Value.RTResult.Value);
			}
			else
			{
				int rTSize = ((item.Value.RTSize > 0) ? item.Value.RTSize : 1024);
				RenderTargetData.DynamicRTMap.Add(item.Key, new GrobalRTWrap
				{
					RTPing = CreateRT(rTSize),
					RTPong = CreateRT(rTSize),
					RTResult = CreateRT(rTSize)
				});
			}
		}
		foreach (KeyValuePair<ESceneItemSurfaceType, CanvasPainterData> item2 in RenderTargetData.GlobalRTConfig.CanvasPainterMap)
		{
			List<MaterialScalarParamData> floatValues = new List<MaterialScalarParamData>
			{
				new MaterialScalarParamData(B1GlobalFNames.FadeTime, item2.Value.FadeOutTime)
			};
			PushParamsToCanvasMaterial(item2.Key, floatValues, new List<MaterialVectorParamData>(), new List<MaterialTextureParamData>());
		}
		foreach (KeyValuePair<ESceneItemSurfaceType, CanvasPainterData> item3 in RenderTargetData.GlobalRTConfig.CanvasPainterMap)
		{
			List<MaterialScalarParamData> floatValues2 = new List<MaterialScalarParamData>
			{
				new MaterialScalarParamData(B1GlobalFNames.EndTime, item3.Value.EndTime)
			};
			PushParamsToPainterMaterial(item3.Key, floatValues2, new List<MaterialVectorParamData>(), new List<MaterialTextureParamData>());
		}
	}

	private void SwitchDrawState(ESceneItemSurfaceType SurfaceType)
	{
		RenderTargetData.DrawStateMap[SurfaceType] = !RenderTargetData.DrawStateMap[SurfaceType];
	}

	private void DrawUseMatCanvas(ESceneItemSurfaceType SurfaceType, EMatPainterType MatPainterType)
	{
		if (RenderTargetData.GlobalRTConfig == null || !RenderTargetData.GlobalRTConfig.CanvasPainterMap.TryGetValue(SurfaceType, out var value))
		{
			return;
		}
		if (!RenderTargetData.DynamicCanvasMaterialMap.TryGetValue(SurfaceType, out var value2))
		{
			value2 = new TStrongObjectPtr_NoCollect<UMaterialInstanceDynamic>(UMaterialLibrary.CreateDynamicMaterialInstance(Owner, value.CanvasMaterial, FName.None, EMIDCreationFlags.None));
			RenderTargetData.DynamicCanvasMaterialMap.Add(SurfaceType, value2);
		}
		UTextureRenderTarget2D rTTexture = RenderTargetData.GetRTTexture(value, SurfaceType, RenderTargetData.DrawStateMap[SurfaceType]);
		if (!(rTTexture == null))
		{
			UTextureRenderTarget2D finalRTTexture = RenderTargetData.GetFinalRTTexture(value, SurfaceType);
			if (!(finalRTTexture == null))
			{
				UMaterialInstanceDynamic uMaterialInstanceDynamic = value2.Get();
				uMaterialInstanceDynamic.SetVectorParameterValue(B1GlobalFNames.MaskChanel, (MatPainterType == EMatPainterType.Line) ? new FLinearColor(1f, 0f, 0f) : new FLinearColor(0f, 1f, 0f));
				uMaterialInstanceDynamic.SetTextureParameterValue(B1GlobalFNames.LastFrameCanvasRT, rTTexture);
				URenderingLibrary.DrawMaterialToRenderTarget(Owner, finalRTTexture, uMaterialInstanceDynamic);
			}
		}
	}

	private void UpdateMaterialParams(UMaterialInstanceDynamic MID, List<MaterialScalarParamData> FloatValues, List<MaterialVectorParamData> VectorValues, List<MaterialTextureParamData> TextureValues)
	{
		if (MID == null)
		{
			return;
		}
		if (FloatValues != null)
		{
			foreach (MaterialScalarParamData FloatValue in FloatValues)
			{
				MID.SetScalarParameterValue(FloatValue.ParamName, FloatValue.Value);
			}
		}
		if (VectorValues != null)
		{
			foreach (MaterialVectorParamData VectorValue in VectorValues)
			{
				MID.SetVectorParameterValue(VectorValue.ParamName, VectorValue.Value);
			}
		}
		if (TextureValues == null)
		{
			return;
		}
		foreach (MaterialTextureParamData TextureValue in TextureValues)
		{
			MID.SetTextureParameterValue(TextureValue.ParamName, TextureValue.Value);
		}
	}

	private void PushParamsToPainterMaterial(ESceneItemSurfaceType SurfaceType, List<MaterialScalarParamData> FloatValues, List<MaterialVectorParamData> VectorValues, List<MaterialTextureParamData> TextureValues)
	{
		if (!(RenderTargetData.GlobalRTConfig == null) && RenderTargetData.GlobalRTConfig.CanvasPainterMap.TryGetValue(SurfaceType, out var value))
		{
			if (!RenderTargetData.DynamicPainterMaterialMap.TryGetValue(SurfaceType, out var value2))
			{
				value2 = new TStrongObjectPtr_NoCollect<UMaterialInstanceDynamic>(UMaterialLibrary.CreateDynamicMaterialInstance(Owner, value.PainterMaterial, FName.None, EMIDCreationFlags.None));
				RenderTargetData.DynamicPainterMaterialMap.Add(SurfaceType, value2);
			}
			UpdateMaterialParams(value2.Get(), FloatValues, VectorValues, TextureValues);
		}
	}

	private void PushParamsToCanvasMaterial(ESceneItemSurfaceType SurfaceType, List<MaterialScalarParamData> FloatValues, List<MaterialVectorParamData> VectorValues, List<MaterialTextureParamData> TextureValues)
	{
		if (!(RenderTargetData.GlobalRTConfig == null) && RenderTargetData.GlobalRTConfig.CanvasPainterMap.TryGetValue(SurfaceType, out var value))
		{
			if (!RenderTargetData.DynamicCanvasMaterialMap.TryGetValue(SurfaceType, out var value2))
			{
				value2 = new TStrongObjectPtr_NoCollect<UMaterialInstanceDynamic>(UMaterialLibrary.CreateDynamicMaterialInstance(Owner, value.CanvasMaterial, FName.None, EMIDCreationFlags.None));
				RenderTargetData.DynamicCanvasMaterialMap.Add(SurfaceType, value2);
			}
			UpdateMaterialParams(value2.Get(), FloatValues, VectorValues, TextureValues);
		}
	}

	private void OnAddOrUpdateEndTickGameTimeForSurfaceType(ESceneItemSurfaceType SurfaceType, float EndGameTime)
	{
		if (RenderTargetData.GlobalRTConfig == null || !RenderTargetData.GlobalRTConfig.CanvasPainterMap.TryGetValue(SurfaceType, out var value))
		{
			return;
		}
		float num = EndGameTime + value.FadeOutTime + 1f;
		if (RenderTargetData.PendingTickSurfaceTypes.TryGetValue(SurfaceType, out var value2))
		{
			if (num > value2)
			{
				RenderTargetData.PendingTickSurfaceTypes[SurfaceType] = num;
			}
		}
		else
		{
			RenderTargetData.PendingTickSurfaceTypes.Add(SurfaceType, num);
		}
	}

	private void OnDrawUseMatPainter(ESceneItemSurfaceType SurfaceType, EMatPainterType MatPainterType, List<MaterialScalarParamData> FloatValues, List<MaterialVectorParamData> VectorValues)
	{
		if (!(RenderTargetData.GlobalRTConfig == null) && RenderTargetData.GlobalRTConfig.CanvasPainterMap.TryGetValue(SurfaceType, out var value))
		{
			if (!RenderTargetData.DynamicCanvasMaterialMap.TryGetValue(SurfaceType, out var value2))
			{
				value2 = new TStrongObjectPtr_NoCollect<UMaterialInstanceDynamic>(UMaterialLibrary.CreateDynamicMaterialInstance(Owner, value.CanvasMaterial, FName.None, EMIDCreationFlags.None));
				RenderTargetData.DynamicCanvasMaterialMap.Add(SurfaceType, value2);
			}
			DrawUseMatPainterPingPong(value, SurfaceType, MatPainterType, FloatValues, VectorValues);
			UpdateMaterialParams(value2.Get(), FloatValues, null, null);
		}
	}

	private void DrawUseMatPainterPingPong(CanvasPainterData OutData, ESceneItemSurfaceType SurfaceType, EMatPainterType MatPainterType, List<MaterialScalarParamData> FloatValues, List<MaterialVectorParamData> VectorValues)
	{
		if (!RenderTargetData.DynamicPainterMaterialMap.TryGetValue(SurfaceType, out var value))
		{
			value = new TStrongObjectPtr_NoCollect<UMaterialInstanceDynamic>(UMaterialLibrary.CreateDynamicMaterialInstance(Owner, OutData.PainterMaterial, FName.None, EMIDCreationFlags.None));
			RenderTargetData.DynamicPainterMaterialMap.Add(SurfaceType, value);
		}
		UMaterialInstanceDynamic uMaterialInstanceDynamic = value.Get();
		if (uMaterialInstanceDynamic == null)
		{
			return;
		}
		UTextureRenderTarget2D rTTexture = RenderTargetData.GetRTTexture(OutData, SurfaceType, RenderTargetData.DrawStateMap[SurfaceType]);
		if (!(rTTexture == null))
		{
			SwitchDrawState(SurfaceType);
			UTextureRenderTarget2D rTTexture2 = RenderTargetData.GetRTTexture(OutData, SurfaceType, RenderTargetData.DrawStateMap[SurfaceType]);
			if (rTTexture2 == null)
			{
				SwitchDrawState(SurfaceType);
				return;
			}
			uMaterialInstanceDynamic.SetVectorParameterValue(B1GlobalFNames.MaskChanel, (MatPainterType == EMatPainterType.Line) ? new FLinearColor(1f, 0f, 0f) : new FLinearColor(0f, 1f, 0f));
			uMaterialInstanceDynamic.SetTextureParameterValue(B1GlobalFNames.LastFrameCanvasRT, rTTexture);
			UpdateMaterialParams(uMaterialInstanceDynamic, FloatValues, VectorValues, null);
			URenderingLibrary.DrawMaterialToRenderTarget(Owner, rTTexture2, uMaterialInstanceDynamic);
		}
	}

	private void OnPushParamsToPainterMaterial(List<MaterialScalarParamData> FloatValues, List<MaterialVectorParamData> VectorValues, List<MaterialTextureParamData> TextureValues)
	{
		if (RenderTargetData.GlobalRTConfig == null)
		{
			return;
		}
		foreach (KeyValuePair<ESceneItemSurfaceType, CanvasPainterData> item in RenderTargetData.GlobalRTConfig.CanvasPainterMap)
		{
			PushParamsToPainterMaterial(item.Key, FloatValues, VectorValues, TextureValues);
		}
	}

	private void OnPushParamsToCanvasMaterial(List<MaterialScalarParamData> FloatValues, List<MaterialVectorParamData> VectorValues, List<MaterialTextureParamData> TextureValues)
	{
		if (RenderTargetData.GlobalRTConfig == null)
		{
			return;
		}
		foreach (KeyValuePair<ESceneItemSurfaceType, CanvasPainterData> item in RenderTargetData.GlobalRTConfig.CanvasPainterMap)
		{
			PushParamsToCanvasMaterial(item.Key, FloatValues, VectorValues, TextureValues);
		}
	}

	private void OnTriggerResetAllActors(EResetActorReason ResetReason)
	{
		if (IS_EDITOR_DEBUG)
		{
			foreach (KeyValuePair<ESceneItemSurfaceType, CanvasPainterData> item in RenderTargetData.GlobalRTConfig.CanvasPainterMap)
			{
				RenderTargetData.DrawStateMap[item.Key] = true;
				ClearRT(item.Value.RTPing.Value);
				ClearRT(item.Value.RTPong.Value);
				ClearRT(item.Value.RTResult.Value);
			}
			return;
		}
		foreach (KeyValuePair<ESceneItemSurfaceType, CanvasPainterData> item2 in RenderTargetData.GlobalRTConfig.CanvasPainterMap)
		{
			RenderTargetData.DrawStateMap[item2.Key] = true;
		}
		foreach (KeyValuePair<ESceneItemSurfaceType, GrobalRTWrap> item3 in RenderTargetData.DynamicRTMap)
		{
			ClearRT(item3.Value.RTPing);
			ClearRT(item3.Value.RTPong);
			ClearRT(item3.Value.RTResult);
		}
	}
}
