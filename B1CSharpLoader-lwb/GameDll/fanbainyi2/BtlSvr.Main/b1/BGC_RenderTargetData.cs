using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_RenderTargetData : IBGC_RenderTargetData, IPersistentECSData
{
	private TStrongObjectPtr<BGWDataAsset_GlobalRenderTargetConfig> mGlobalRTConfig = new TStrongObjectPtr<BGWDataAsset_GlobalRenderTargetConfig>();

	public Dictionary<ESceneItemSurfaceType, TStrongObjectPtr<UMaterialInstanceDynamic>> DynamicPainterMaterialMap = new Dictionary<ESceneItemSurfaceType, TStrongObjectPtr<UMaterialInstanceDynamic>>();

	public Dictionary<ESceneItemSurfaceType, TStrongObjectPtr<UMaterialInstanceDynamic>> DynamicCanvasMaterialMap = new Dictionary<ESceneItemSurfaceType, TStrongObjectPtr<UMaterialInstanceDynamic>>();

	public Dictionary<ESceneItemSurfaceType, GrobalRTWrap> DynamicRTMap = new Dictionary<ESceneItemSurfaceType, GrobalRTWrap>();

	public Dictionary<ESceneItemSurfaceType, bool> DrawStateMap = new Dictionary<ESceneItemSurfaceType, bool>();

	public Dictionary<ESceneItemSurfaceType, float> PendingTickSurfaceTypes = new Dictionary<ESceneItemSurfaceType, float>();

	public BGWDataAsset_GlobalRenderTargetConfig GlobalRTConfig
	{
		get
		{
			return mGlobalRTConfig.Get();
		}
		set
		{
			mGlobalRTConfig.Set(value);
		}
	}

	public UTextureRenderTarget2D GetGlobalRTBySurfaceType(ESceneItemSurfaceType SurfaceType)
	{
		if (GlobalRTConfig.CanvasPainterMap.TryGetValue(SurfaceType, out var value))
		{
			return GetFinalRTTexture(value, SurfaceType);
		}
		return null;
	}

	public FName GetGlobalRTParamNameBySurfaceType(ESceneItemSurfaceType SurfaceType)
	{
		if (GlobalRTConfig.CanvasPainterMap.TryGetValue(SurfaceType, out var value))
		{
			return value.RTTextureParamName;
		}
		return FName.None;
	}

	public UTextureRenderTarget2D GetRTTexture(CanvasPainterData Data, ESceneItemSurfaceType SurfaceType, bool bIsPing)
	{
		if (BGS_RenderTargetMgr.IS_EDITOR_DEBUG)
		{
			return (bIsPing ? Data.RTPing : Data.RTPong).Value;
		}
		if (DynamicRTMap.TryGetValue(SurfaceType, out var value))
		{
			if (!bIsPing)
			{
				return value.RTPong;
			}
			return value.RTPing;
		}
		return null;
	}

	public UTextureRenderTarget2D GetFinalRTTexture(CanvasPainterData Data, ESceneItemSurfaceType SurfaceType)
	{
		if (BGS_RenderTargetMgr.IS_EDITOR_DEBUG)
		{
			return Data.RTResult.Value;
		}
		if (!DynamicRTMap.TryGetValue(SurfaceType, out var value))
		{
			return null;
		}
		return value.RTResult;
	}
}
