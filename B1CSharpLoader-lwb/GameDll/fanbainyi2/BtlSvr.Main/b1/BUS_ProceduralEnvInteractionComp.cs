using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_ProceduralEnvInteractionComp : UActorCompBaseCS
{
	private b1.BUC_ProceduralEnvInteractionData ProceduralEnvInteractionData;

	private IBGC_RenderTargetData RenderTargetData;

	public override void OnAttach()
	{
		ProceduralEnvInteractionData = RequireWritableData<b1.BUC_ProceduralEnvInteractionData>();
		RenderTargetData = RequireReadOnlyGameStateData<IBGC_RenderTargetData, BGC_RenderTargetData>();
		base.BUSEventCollection.Evt_AddActiveSurfaceType += new Del_SurfaceType(OnAddActiveSurfaceType);
		base.BUSEventCollection.Evt_RemoveActiveSurfaceType += new Del_SurfaceType(OnRemoveActiveSurfaceType);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		BGUProceduralEnvInteractionActor bGUProceduralEnvInteractionActor = GetOwner() as BGUProceduralEnvInteractionActor;
		if (bGUProceduralEnvInteractionActor == null)
		{
			return;
		}
		BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()).Conv_VectorToVector2D();
		if (ProceduralEnvInteractionData.bEnableDecal)
		{
			UDecalComponent componentByClass = bGUProceduralEnvInteractionActor.GetComponentByClass<UDecalComponent>();
			if (componentByClass != null)
			{
				componentByClass.SetRelativeLocation(FVector.ZeroVector, bSweep: false, out var _, bTeleport: false);
				componentByClass.DecalSize = new FVector(ProceduralEnvInteractionData.WorldSize, 256.0);
			}
		}
		if (ProceduralEnvInteractionData.bEnableMesh)
		{
			UMeshComponent componentByClass2 = bGUProceduralEnvInteractionActor.GetComponentByClass<UMeshComponent>();
			if (componentByClass2 != null)
			{
				float num = 50f;
				FVector worldScale = componentByClass2.GetWorldScale();
				FVector scale3D = BGUFuncLibActorTransformCS.BGUGetActorTransform(bGUProceduralEnvInteractionActor).Scale3D;
				FVector worldLocation = componentByClass2.GetWorldLocation();
				FVector fVector = worldLocation - num * scale3D * worldScale;
				FVector fVector2 = worldLocation + num * scale3D * worldScale;
				FLinearColor fLinearColor = new FLinearColor(fVector.X, fVector.Y, fVector2.X, fVector2.Y);
				base.BUSEventCollection?.Evt_SetMatsParam.Invoke(B1GlobalFNames.WorldMinMax, new MaterialParamInfo(fLinearColor, fLinearColor), ForceUpdateDefaultValue: true);
				List<MaterialVectorParamData> vectorValues = new List<MaterialVectorParamData>
				{
					new MaterialVectorParamData(B1GlobalFNames.WorldMinMax, fLinearColor)
				};
				base.BGSEventCollection.Evt_BGS_PushParamsToPainterMaterial.Invoke(new List<MaterialScalarParamData>(), vectorValues, new List<MaterialTextureParamData>());
				base.BGSEventCollection.Evt_BGS_PushParamsToCanvasMaterial.Invoke(new List<MaterialScalarParamData>(), vectorValues, new List<MaterialTextureParamData>());
				UTextureRenderTarget2D globalRTBySurfaceType = RenderTargetData.GetGlobalRTBySurfaceType(ProceduralEnvInteractionData.DefaultSceneItemSurfaceType);
				FName globalRTParamNameBySurfaceType = RenderTargetData.GetGlobalRTParamNameBySurfaceType(ProceduralEnvInteractionData.DefaultSceneItemSurfaceType);
				base.BUSEventCollection?.Evt_SetMatsParam.Invoke(globalRTParamNameBySurfaceType, new MaterialParamInfo(globalRTBySurfaceType), ForceUpdateDefaultValue: true);
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		foreach (ESceneItemSurfaceType activeSurfaceType in ProceduralEnvInteractionData.ActiveSurfaceTypes)
		{
			RenderTargetData.GetGlobalRTBySurfaceType(activeSurfaceType);
			RenderTargetData.GetGlobalRTParamNameBySurfaceType(activeSurfaceType);
			_ = ProceduralEnvInteractionData.bEnableDecal;
			_ = ProceduralEnvInteractionData.bEnableMesh;
		}
	}

	private void OnAddActiveSurfaceType(ESceneItemSurfaceType SurfaceType)
	{
		ProceduralEnvInteractionData.ActiveSurfaceTypes.Add(SurfaceType);
	}

	private void OnRemoveActiveSurfaceType(ESceneItemSurfaceType SurfaceType)
	{
		ProceduralEnvInteractionData.ActiveSurfaceTypes.Remove(SurfaceType);
	}
}
