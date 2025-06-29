using System;
using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGUEnvironmentSurfaceEffectMgr")]
public class BGUEnvironmentSurfaceEffectMgr : AEnvironmentSurfaceEffectMgr
{
	private Dictionary<int, List<b1.SurfaceTypeOverrideSampleData>> SurfaceTypeOverrideSamples = new Dictionary<int, List<b1.SurfaceTypeOverrideSampleData>>();

	private Dictionary<int, SurfaceTypeOverrideSessionData> SurfaceTypeOverrideSessions = new Dictionary<int, SurfaceTypeOverrideSessionData>();

	private Dictionary<AActor, HashSet<int>> SurfaceFXActorReferences = new Dictionary<AActor, HashSet<int>>();

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	private static bool ReceiveEndPlay_IsValid;

	private static IntPtr ReceiveEndPlay_FunctionAddress;

	private static int ReceiveEndPlay_ParamsSize;

	private static bool ReceiveEndPlay_EndPlayReason_IsValid;

	private static int ReceiveEndPlay_EndPlayReason_Offset;

	private static FFieldAddress ReceiveEndPlay_EndPlayReason_PropertyAddress;

	private static bool ReceiveDestroyed_IsValid;

	private static IntPtr ReceiveDestroyed_FunctionAddress;

	private static int ReceiveDestroyed_ParamsSize;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.PrimaryActorTick.SetCanEverTick(canEverTick: true);
		base.PrimaryActorTick.SetStartWithTickEnabled(startWithTickEnabled: true);
	}

	[USharpPath("/Script/b1-Managed.BGUEnvironmentSurfaceEffectMgr:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(this);
		if (bGS_GSEventCollection != null)
		{
			bGS_GSEventCollection.Evt_BGS_SetEnvironmentSurfaceVolumeEnabled += new Del_BGS_SetEnvironmentSurfaceVolumeEnabled(OnSetEnvironmentSurfaceVolumeEnabled);
		}
	}

	[USharpPath("/Script/b1-Managed.BGUEnvironmentSurfaceEffectMgr:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
		base.ReceiveTick_Implementation(DeltaSeconds);
		DrawSamples();
		TickForSurfaceTypeOverrideSamples(DeltaSeconds);
	}

	[USharpPath("/Script/b1-Managed.BGUEnvironmentSurfaceEffectMgr:ReceiveEndPlay")]
	protected override void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
	{
		base.ReceiveEndPlay_Implementation(EndPlayReason);
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(this);
		if (bGS_GSEventCollection != null)
		{
			bGS_GSEventCollection.Evt_BGS_SetEnvironmentSurfaceVolumeEnabled -= new Del_BGS_SetEnvironmentSurfaceVolumeEnabled(OnSetEnvironmentSurfaceVolumeEnabled);
		}
	}

	[USharpPath("/Script/b1-Managed.BGUEnvironmentSurfaceEffectMgr:ReceiveDestroyed")]
	protected override void ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(this);
		if (bGS_GSEventCollection != null)
		{
			bGS_GSEventCollection.Evt_BGS_SetEnvironmentSurfaceVolumeEnabled -= new Del_BGS_SetEnvironmentSurfaceVolumeEnabled(OnSetEnvironmentSurfaceVolumeEnabled);
		}
	}

	private void OnSetEnvironmentSurfaceVolumeEnabled(TSoftObject<ABGWEnvironmentSurfaceVolume> VolumeRef, bool bIsEnabled, bool IsDisableVolume = true)
	{
		if (bIsEnabled)
		{
			RegisterVolume(VolumeRef);
		}
		else
		{
			UnregisterVolume(VolumeRef, IsDisableVolume);
		}
	}

	public ESceneItemSurfaceType EvaluateSurfaceTypeOverrideByPosition(FVector2D Position)
	{
		foreach (KeyValuePair<int, List<b1.SurfaceTypeOverrideSampleData>> surfaceTypeOverrideSample in SurfaceTypeOverrideSamples)
		{
			List<b1.SurfaceTypeOverrideSampleData> value = surfaceTypeOverrideSample.Value;
			for (int i = 0; i < value.Count - 1; i++)
			{
				FVector2D position = value[i].Position;
				if (!value[i].bIsLastSample)
				{
					FVector2D position2 = value[i + 1].Position;
					float Alpha;
					float num = CalculateSdfSegament(Position, position, position2, out Alpha);
					float num2 = MathLib.Lerp(value[i].Size, value[i + 1].Size, Alpha);
					if (num <= num2)
					{
						int index = ((Alpha < 0.5f) ? i : (i + 1));
						return value[index].SurfaceType;
					}
				}
			}
		}
		return ESceneItemSurfaceType.DefaultSurface;
	}

	private bool DoesTargetPassFilter(int Filter, AActor Target)
	{
		IBUC_ActorBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_ActorBasicData, BUC_ActorBasicData>(Target);
		if (readOnlyData != null)
		{
			if (readOnlyData.ActorType == BGU_ActorType.CharacterPlayer && (Filter & 1) > 0)
			{
				return true;
			}
		}
		return false;
	}

	public float GetEnvironmentAbnormalEffectTriggerInterval(int EffectID)
	{
		if (EffectID == -1)
		{
			return 0f;
		}
		FUStEnvironmentSurfaceEffectDesc environmentSurfaceEffectDesc = BGW_GameDB.GetEnvironmentSurfaceEffectDesc(EffectID);
		if (environmentSurfaceEffectDesc != null)
		{
			BGWDataAsset_EnvironmentAbnormalEffectConfig bGWDataAsset_EnvironmentAbnormalEffectConfig = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWDataAsset_EnvironmentAbnormalEffectConfig>(environmentSurfaceEffectDesc.EnvironmentAbnormalEffectDA, ELoadResourceType.AsyncLoadAndCache);
			if (bGWDataAsset_EnvironmentAbnormalEffectConfig != null)
			{
				return bGWDataAsset_EnvironmentAbnormalEffectConfig.Interval;
			}
		}
		return 0f;
	}

	public void ApplyEnvironmentAbnormalEffect(int EffectID, AActor Caster, AActor Target, out List<EBGUSimpleState> DisableAutoRecoverSSList, out Dictionary<EAbnormalStateType, float> AbnormalStateAutoRecoverRateMap)
	{
		DisableAutoRecoverSSList = new List<EBGUSimpleState>();
		AbnormalStateAutoRecoverRateMap = new Dictionary<EAbnormalStateType, float>();
		if (EffectID == -1)
		{
			return;
		}
		FUStEnvironmentSurfaceEffectDesc environmentSurfaceEffectDesc = BGW_GameDB.GetEnvironmentSurfaceEffectDesc(EffectID);
		if (environmentSurfaceEffectDesc == null)
		{
			return;
		}
		BGWDataAsset_EnvironmentAbnormalEffectConfig bGWDataAsset_EnvironmentAbnormalEffectConfig = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWDataAsset_EnvironmentAbnormalEffectConfig>(environmentSurfaceEffectDesc.EnvironmentAbnormalEffectDA, ELoadResourceType.AsyncLoadAndCache);
		if (!(bGWDataAsset_EnvironmentAbnormalEffectConfig != null))
		{
			return;
		}
		foreach (EnvironmentAbnormalEffectConfig environmentAbnormalEffect in bGWDataAsset_EnvironmentAbnormalEffectConfig.EnvironmentAbnormalEffectList)
		{
			int abnormalStateAccEffectOrBuffID = BGUFuncLib_AbnormalState.GetAbnormalStateAccEffectOrBuffID(Caster, environmentAbnormalEffect.AbnormalStateConfig);
			if (abnormalStateAccEffectOrBuffID <= 0 || !DoesTargetPassFilter(environmentSurfaceEffectDesc.TargetFilter, Target))
			{
				continue;
			}
			BUS_EventCollectionCS.Get(Caster).Evt_TriggerSkillEffect.Invoke(abnormalStateAccEffectOrBuffID, default(FEffectInstReq), Target);
			if (environmentAbnormalEffect.bDisableAutoRecover)
			{
				EBGUSimpleState eBGUSimpleState = EBGUSimpleState.Normal;
				switch (environmentAbnormalEffect.AbnormalStateConfig.AbnormalStateType)
				{
				case EAbnormalStateType.Abnormal_Freeze:
					eBGUSimpleState = EBGUSimpleState.DisableAutoRecoverFreeze;
					break;
				case EAbnormalStateType.Abnormal_Burn:
					eBGUSimpleState = EBGUSimpleState.DisableAutoRecoverBurn;
					break;
				case EAbnormalStateType.Abnormal_Poison:
					eBGUSimpleState = EBGUSimpleState.DisableAutoRecoverPoison;
					break;
				case EAbnormalStateType.Abnormal_Thunder:
					eBGUSimpleState = EBGUSimpleState.DisableAutoRecoverThunder;
					break;
				case EAbnormalStateType.Abnormal_Yin:
					eBGUSimpleState = EBGUSimpleState.DisableAutoRecoverYin;
					break;
				case EAbnormalStateType.Abnormal_Yang:
					eBGUSimpleState = EBGUSimpleState.DisableAutoRecoverYang;
					break;
				}
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(Target, eBGUSimpleState, IsRemove: false);
				DisableAutoRecoverSSList.Add(eBGUSimpleState);
			}
		}
		foreach (EnvironmentAbnormalRecoverRate environmentAbnormalAutoRecoverRate in bGWDataAsset_EnvironmentAbnormalEffectConfig.EnvironmentAbnormalAutoRecoverRateList)
		{
			if (!AbnormalStateAutoRecoverRateMap.ContainsKey(environmentAbnormalAutoRecoverRate.AbnormalStateType))
			{
				AbnormalStateAutoRecoverRateMap.Add(environmentAbnormalAutoRecoverRate.AbnormalStateType, environmentAbnormalAutoRecoverRate.AutoRecoverRate);
			}
		}
	}

	public void ApplyEffect(int EffectID, ESceneItemSurfaceType SurfaceType, AActor Caster, AActor Target)
	{
		if (EffectID == -1)
		{
			return;
		}
		foreach (KeyValuePair<int, FUStEnvironmentSurfaceEffectDesc> item in BGW_GameDB.GetAllEnvironmentSurfaceEffectDesc())
		{
			if (item.Key != EffectID)
			{
				continue;
			}
			FUStEnvironmentSurfaceEffectDesc value = item.Value;
			if (value.SurfaceType != SurfaceType || !DoesTargetPassFilter(value.TargetFilter, Target))
			{
				break;
			}
			{
				foreach (int surfaceBuff in value.SurfaceBuffList)
				{
					BGUFunctionLibraryCS.BGUAddBuff(Caster, Target, surfaceBuff, EBuffSourceType.EnvironmentSurfaceEffect);
				}
				break;
			}
		}
	}

	public void RemoveEffect(int EffectID, ESceneItemSurfaceType SurfaceType, AActor Target)
	{
		if (EffectID == -1)
		{
			return;
		}
		foreach (KeyValuePair<int, FUStEnvironmentSurfaceEffectDesc> item in BGW_GameDB.GetAllEnvironmentSurfaceEffectDesc())
		{
			if (item.Key != EffectID)
			{
				continue;
			}
			FUStEnvironmentSurfaceEffectDesc value = item.Value;
			if (value.SurfaceType != SurfaceType || !DoesTargetPassFilter(value.TargetFilter, Target))
			{
				break;
			}
			{
				foreach (int surfaceBuff in value.SurfaceBuffList)
				{
					BGUFunctionLibraryCS.BGURemoveBuff(Target, surfaceBuff, EBuffEffectTriggerType.None, 1);
				}
				break;
			}
		}
	}

	public void OnSweepHitWorldItemForSurfaceTypeOverrideDraw(AActor HitActor, FVector2D Position, float Size, ESceneItemSurfaceType OverrideSurfaceType, float OverrideSurfacePersistTime, FName OverrideSurfaceFXActorTag, int EntityID, bool bDrawDebug, float DebugDrawOffset)
	{
		if (!DoesSurfaceTypeOverrideTimeDataExist(EntityID))
		{
			OnSurfaceTypeOverrideSessionBegin(EntityID, OverrideSurfacePersistTime, OverrideSurfaceType, OverrideSurfaceFXActorTag, bDrawDebug, HitActor.GetActorLocation().Z + DebugDrawOffset);
		}
		float endGameTime = GetEndGameTime(EntityID);
		List<MaterialScalarParamData> floatValues = new List<MaterialScalarParamData>
		{
			new MaterialScalarParamData(B1GlobalFNames.AffectRadius, Size),
			new MaterialScalarParamData(B1GlobalFNames.EndTime, endGameTime)
		};
		FLinearColor inValue = Position.Conv_Vector2DToVector().Conv_VectorToLinearColor();
		List<MaterialVectorParamData> vectorValues = new List<MaterialVectorParamData>
		{
			new MaterialVectorParamData(B1GlobalFNames.HitPositionWS, inValue)
		};
		BGS_EventCollectionCS.Get(this).Evt_BGS_DrawUseMatPainter.Invoke(OverrideSurfaceType, EMatPainterType.Line, floatValues, vectorValues);
	}

	public void OnSweepHitWorldItemForSurfaceTypeOverride(FVector2D Position, float Size, ESceneItemSurfaceType OverrideSurfaceType, int EntityID)
	{
		b1.SurfaceTypeOverrideSampleData surfaceTypeOverrideSampleData = new b1.SurfaceTypeOverrideSampleData();
		surfaceTypeOverrideSampleData.Position = Position;
		surfaceTypeOverrideSampleData.Size = Size;
		surfaceTypeOverrideSampleData.SurfaceType = OverrideSurfaceType;
		if (!SurfaceTypeOverrideSamples.ContainsKey(EntityID))
		{
			SurfaceTypeOverrideSamples.Add(EntityID, new List<b1.SurfaceTypeOverrideSampleData>());
		}
		SurfaceTypeOverrideSamples[EntityID].Add(surfaceTypeOverrideSampleData);
	}

	private void OnSurfaceTypeOverrideSessionBegin(int EntityID, float TotalTime, ESceneItemSurfaceType SurfaceType, FName SurfaceFXActorTag, bool bDrawDebug, float DebugDrawZ)
	{
		float endGameTime = ((TotalTime <= 0f) ? (-1f) : (base.World.GetTimeSeconds() + TotalTime));
		SurfaceTypeOverrideSessionData surfaceTypeOverrideSessionData = new SurfaceTypeOverrideSessionData();
		surfaceTypeOverrideSessionData.SurfaceType = SurfaceType;
		if (SurfaceFXActorTag != FName.None)
		{
			UGameplayStatics.GetAllActorsOfClassWithTag(this, UClass.GetClass<AActor>(), SurfaceFXActorTag, out var OutActors);
			foreach (AActor item in OutActors)
			{
				BUS_EventCollectionCS.Get(item).Evt_AddActiveSurfaceType.Invoke(SurfaceType);
				if (!SurfaceFXActorReferences.ContainsKey(item))
				{
					SurfaceFXActorReferences.Add(item, new HashSet<int>());
				}
				SurfaceFXActorReferences[item].Add(EntityID);
			}
		}
		surfaceTypeOverrideSessionData.RemainingTime = TotalTime;
		surfaceTypeOverrideSessionData.EndGameTime = endGameTime;
		surfaceTypeOverrideSessionData.bDrawDebug = bDrawDebug;
		surfaceTypeOverrideSessionData.DebugDrawZ = DebugDrawZ;
		SurfaceTypeOverrideSessions.Add(EntityID, surfaceTypeOverrideSessionData);
		BGS_EventCollectionCS.Get(this).Evt_BGS_AddOrUpdateEndTickGameTimeForSurfaceType.Invoke(SurfaceType, endGameTime);
	}

	private void DrawSamples()
	{
		foreach (KeyValuePair<int, List<b1.SurfaceTypeOverrideSampleData>> surfaceTypeOverrideSample in SurfaceTypeOverrideSamples)
		{
			int key = surfaceTypeOverrideSample.Key;
			SurfaceTypeOverrideSessionData surfaceTypeOverrideSessionData = SurfaceTypeOverrideSessions[key];
			if (!surfaceTypeOverrideSessionData.bDrawDebug)
			{
				continue;
			}
			List<b1.SurfaceTypeOverrideSampleData> value = surfaceTypeOverrideSample.Value;
			for (int i = 0; i < value.Count; i++)
			{
				if (i > 0)
				{
					b1.SurfaceTypeOverrideSampleData surfaceTypeOverrideSampleData = value[i - 1];
					if (!surfaceTypeOverrideSampleData.bIsLastSample)
					{
						b1.SurfaceTypeOverrideSampleData surfaceTypeOverrideSampleData2 = value[i];
						float debugDrawZ = surfaceTypeOverrideSessionData.DebugDrawZ;
						FVector fVector = new FVector(surfaceTypeOverrideSampleData.Position, debugDrawZ);
						FVector fVector2 = new FVector(surfaceTypeOverrideSampleData2.Position, debugDrawZ);
						FVector safeNormal = (fVector - fVector2).GetSafeNormal();
						FVector fVector3 = FVector.CrossProduct(safeNormal, FVector.UpVector);
						USystemLibrary.DrawDebugArrow(this, fVector + fVector3 * surfaceTypeOverrideSampleData.Size, fVector2 + fVector3 * surfaceTypeOverrideSampleData2.Size, 20000f, FLinearColor.Red, 0f, 10f);
						USystemLibrary.DrawDebugArrow(this, fVector - fVector3 * surfaceTypeOverrideSampleData.Size, fVector2 - fVector3 * surfaceTypeOverrideSampleData2.Size, 20000f, FLinearColor.Red, 0f, 10f);
						UGSE_EngineFuncLib.DrawDebugCircleArc(this, fVector, surfaceTypeOverrideSampleData.Size, safeNormal, MathLib.DegreesToRadians(90f), 32, FLinearColor.Red, 0f, 10f);
						UGSE_EngineFuncLib.DrawDebugCircleArc(this, fVector2, surfaceTypeOverrideSampleData2.Size, -safeNormal, MathLib.DegreesToRadians(90f), 32, FLinearColor.Red, 0f, 10f);
					}
				}
			}
		}
	}

	private void TickForSurfaceTypeOverrideSamples(float DeltaTime)
	{
		foreach (int item in SurfaceTypeOverrideSessions.Keys.ToList())
		{
			SurfaceTypeOverrideSessionData surfaceTypeOverrideSessionData = SurfaceTypeOverrideSessions[item];
			if (!(surfaceTypeOverrideSessionData.EndGameTime <= 0f))
			{
				surfaceTypeOverrideSessionData.RemainingTime -= DeltaTime;
				if (surfaceTypeOverrideSessionData.RemainingTime <= 0f)
				{
					OnSurfaceTypeOverrideSessionEnd(item, surfaceTypeOverrideSessionData.SurfaceType);
				}
			}
		}
	}

	private void OnSurfaceTypeOverrideSessionEnd(int EntityID, ESceneItemSurfaceType SurfaceType)
	{
		List<AActor> list = new List<AActor>();
		foreach (KeyValuePair<AActor, HashSet<int>> surfaceFXActorReference in SurfaceFXActorReferences)
		{
			AActor key = surfaceFXActorReference.Key;
			HashSet<int> value = surfaceFXActorReference.Value;
			value.Remove(EntityID);
			if (value.Count == 0)
			{
				list.Add(key);
			}
			bool flag = false;
			foreach (int item in value)
			{
				if (SurfaceTypeOverrideSessions[item].SurfaceType == SurfaceType)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				BUS_EventCollectionCS.Get(key).Evt_RemoveActiveSurfaceType.Invoke(SurfaceType);
			}
		}
		foreach (AActor item2 in list)
		{
			SurfaceFXActorReferences.Remove(item2);
		}
		SurfaceTypeOverrideSessions.Remove(EntityID);
		SurfaceTypeOverrideSamples.Remove(EntityID);
	}

	private bool DoesSurfaceTypeOverrideTimeDataExist(int EntityID)
	{
		return SurfaceTypeOverrideSessions.ContainsKey(EntityID);
	}

	private float GetEndGameTime(int EntityID)
	{
		if (SurfaceTypeOverrideSessions.TryGetValue(EntityID, out var value))
		{
			return value.EndGameTime;
		}
		return -1f;
	}

	private float Dot2(FVector2D V)
	{
		return MathLib.DotProduct2D(V, V);
	}

	private FVector2D Abs(FVector2D V)
	{
		return new FVector2D(MathLib.Abs(V.X), MathLib.Abs(V.Y));
	}

	private FVector2D Pow(FVector2D X, FVector2D Y)
	{
		return new FVector2D(MathLib.Power(X.X, Y.X), MathLib.Power(X.Y, Y.Y));
	}

	private FVector2D Sign(FVector2D V)
	{
		return new FVector2D(FMath.Sign(V.X), FMath.Sign(V.Y));
	}

	private FVector Clamp(FVector V, float Min, float Max)
	{
		return new FVector(MathLib.Clamp(V.X, Min, Max), MathLib.Clamp(V.Y, Min, Max), MathLib.Clamp(V.Z, Min, Max));
	}

	private float CalculateSdfSegament(FVector2D Position, FVector2D A, FVector2D B, out float Alpha)
	{
		FVector2D fVector2D = Position - A;
		FVector2D fVector2D2 = B - A;
		Alpha = MathLib.Clamp(MathLib.DotProduct2D(fVector2D, fVector2D2) / MathLib.DotProduct2D(fVector2D2, fVector2D2), 0f, 1f);
		return (fVector2D - fVector2D2 * Alpha).Size();
	}

	private float CalculateSdfQuadraticBezier(FVector2D Position, FVector2D A, FVector2D B, FVector2D C)
	{
		FVector2D fVector2D = B - A;
		FVector2D fVector2D2 = A - 2.0 * B + C;
		FVector2D fVector2D3 = fVector2D * 2.0;
		FVector2D fVector2D4 = A - Position;
		float num = 1f / MathLib.DotProduct2D(fVector2D2, fVector2D2);
		float num2 = num * MathLib.DotProduct2D(fVector2D, fVector2D2);
		float num3 = num * (2f * MathLib.DotProduct2D(fVector2D, fVector2D) + MathLib.DotProduct2D(fVector2D4, fVector2D2)) / 3f;
		float num4 = num * MathLib.DotProduct2D(fVector2D4, fVector2D);
		float num5 = 0f;
		float num6 = num3 - num2 * num2;
		float num7 = num6 * num6 * num6;
		float num8 = num2 * (2f * num2 * num2 - 3f * num3) + num4;
		float num9 = num8 * num8 + 4f * num7;
		if (num9 >= 0f)
		{
			num9 = MathLib.Sqrt(num9);
			FVector2D v = (new FVector2D(num9, 0f - num9) - num8) / 2.0;
			FVector2D fVector2D5 = Sign(v) * Pow(Abs(v), new FVector2D(0.3333333432674408, 0.3333333432674408));
			float num10 = MathLib.Clamp(fVector2D5.X + fVector2D5.Y - num2, 0f, 1f);
			num5 = Dot2(fVector2D4 + (fVector2D3 + fVector2D2 * num10) * num10);
		}
		else
		{
			float num11 = MathLib.Sqrt(0f - num6);
			float val = FMath.Acos(num8 / (num6 * num11 * 2f)) / 3f;
			float num12 = MathLib.Cos(val);
			float num13 = MathLib.Sin(val) * 1.7320508f;
			FVector fVector = Clamp(new FVector(num12 + num12, 0f - num13 - num12, num13 - num12) * num11 - num2, 0f, 1f);
			num5 = FMath.Min(Dot2(fVector2D4 + (fVector2D3 + fVector2D2 * fVector.X) * fVector.X), Dot2(fVector2D4 + (fVector2D3 + fVector2D2 * fVector.Y) * fVector.Y));
		}
		return MathLib.Sqrt(num5);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUEnvironmentSurfaceEffectMgr:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUEnvironmentSurfaceEffectMgr bGUEnvironmentSurfaceEffectMgr = GCHelper.Find<BGUEnvironmentSurfaceEffectMgr>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		bGUEnvironmentSurfaceEffectMgr.ReceiveTick_Implementation(deltaSeconds);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUEnvironmentSurfaceEffectMgr:ReceiveEndPlay")]
	private static void ReceiveEndPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUEnvironmentSurfaceEffectMgr bGUEnvironmentSurfaceEffectMgr = GCHelper.Find<BGUEnvironmentSurfaceEffectMgr>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, ReceiveEndPlay_EndPlayReason_Offset), 0, ReceiveEndPlay_EndPlayReason_PropertyAddress.Address);
		bGUEnvironmentSurfaceEffectMgr.ReceiveEndPlay_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUEnvironmentSurfaceEffectMgr:ReceiveDestroyed")]
	private static void ReceiveDestroyed__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUEnvironmentSurfaceEffectMgr bGUEnvironmentSurfaceEffectMgr = GCHelper.Find<BGUEnvironmentSurfaceEffectMgr>(obj);
		bGUEnvironmentSurfaceEffectMgr.ReceiveDestroyed_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUEnvironmentSurfaceEffectMgr:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUEnvironmentSurfaceEffectMgr bGUEnvironmentSurfaceEffectMgr = GCHelper.Find<BGUEnvironmentSurfaceEffectMgr>(obj);
		bGUEnvironmentSurfaceEffectMgr.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUEnvironmentSurfaceEffectMgr");
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUEnvironmentSurfaceEffectMgr:ReceiveTick", ReceiveTick_IsValid);
		ReceiveEndPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveEndPlay");
		ReceiveEndPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveEndPlay_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ReceiveEndPlay_EndPlayReason_PropertyAddress, ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(ReceiveEndPlay_FunctionAddress, "EndPlayReason");
		ReceiveEndPlay_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(ReceiveEndPlay_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		ReceiveEndPlay_IsValid = ReceiveEndPlay_FunctionAddress != IntPtr.Zero && ReceiveEndPlay_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUEnvironmentSurfaceEffectMgr:ReceiveEndPlay", ReceiveEndPlay_IsValid);
		ReceiveDestroyed_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveDestroyed");
		ReceiveDestroyed_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveDestroyed_FunctionAddress);
		ReceiveDestroyed_IsValid = ReceiveDestroyed_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUEnvironmentSurfaceEffectMgr:ReceiveDestroyed", ReceiveDestroyed_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUEnvironmentSurfaceEffectMgr:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}

	static BGUEnvironmentSurfaceEffectMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUEnvironmentSurfaceEffectMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUEnvironmentSurfaceEffectMgr));
	}
}
