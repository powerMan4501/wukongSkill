using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SpiderOceanMgrComp")]
public class BUS_SpiderOceanMgrComp : UActorEditCompBase
{
	private static bool SpiderNiagara_IsValid;

	private static int SpiderNiagara_Offset;

	private static bool AdditionalSpiderNiagaraList_IsValid;

	private static int AdditionalSpiderNiagaraList_Offset;

	private static FFieldAddress AdditionalSpiderNiagaraList_PropertyAddress;

	private TArrayReadWriteMarshaler<ANiagaraActor> AdditionalSpiderNiagaraList_Marshaler;

	private static bool NiagaraSpline_IsValid;

	private static int NiagaraSpline_Offset;

	private static bool SpiderFollowStartIndex_IsValid;

	private static int SpiderFollowStartIndex_Offset;

	private static bool NiagaraMoveCurve_IsValid;

	private static int NiagaraMoveCurve_Offset;

	private static bool SpiderDistanceCurve_IsValid;

	private static int SpiderDistanceCurve_Offset;

	private static bool SpiderSpawnPointsSelectCurve_IsValid;

	private static int SpiderSpawnPointsSelectCurve_Offset;

	private static bool SpiderSpawnPointTag_IsValid;

	private static int SpiderSpawnPointTag_Offset;

	private static bool SpiderSectorActor_IsValid;

	private static int SpiderSectorActor_Offset;

	private static bool SpiderSectorScaleCurve_IsValid;

	private static int SpiderSectorScaleCurve_Offset;

	private static bool SpiderSpawnPoints_IsValid;

	private static int SpiderSpawnPoints_Offset;

	private static FFieldAddress SpiderSpawnPoints_PropertyAddress;

	private TArrayReadWriteMarshaler<SpiderSpawnPointData> SpiderSpawnPoints_Marshaler;

	private static bool bDrawDebugNiagaraLocation_IsValid;

	private static int bDrawDebugNiagaraLocation_Offset;

	private static FFieldAddress bDrawDebugNiagaraLocation_PropertyAddress;

	private static bool FixedGuid_IsValid;

	private static int FixedGuid_Offset;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderNiagara")]
	public ANiagaraActor SpiderNiagara
	{
		get
		{
			CheckDestroyed();
			if (!SpiderNiagara_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderNiagara");
				return null;
			}
			return UObjectMarshaler<ANiagaraActor>.FromNative(IntPtr.Add(base.Address, SpiderNiagara_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpiderNiagara_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderNiagara");
			}
			else
			{
				UObjectMarshaler<ANiagaraActor>.ToNative(IntPtr.Add(base.Address, SpiderNiagara_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_SpiderOceanMgrComp:AdditionalSpiderNiagaraList")]
	public TArrayReadWrite<ANiagaraActor> AdditionalSpiderNiagaraList
	{
		get
		{
			CheckDestroyed();
			if (!AdditionalSpiderNiagaraList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:AdditionalSpiderNiagaraList");
				return null;
			}
			if (AdditionalSpiderNiagaraList_Marshaler == null)
			{
				AdditionalSpiderNiagaraList_Marshaler = new TArrayReadWriteMarshaler<ANiagaraActor>(1, AdditionalSpiderNiagaraList_PropertyAddress, CachedMarshalingDelegates<ANiagaraActor, UObjectMarshaler<ANiagaraActor>>.FromNative, CachedMarshalingDelegates<ANiagaraActor, UObjectMarshaler<ANiagaraActor>>.ToNative);
			}
			return AdditionalSpiderNiagaraList_Marshaler.FromNative(IntPtr.Add(base.Address, AdditionalSpiderNiagaraList_Offset));
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_SpiderOceanMgrComp:NiagaraSpline")]
	public BGUSplineActor NiagaraSpline
	{
		get
		{
			CheckDestroyed();
			if (!NiagaraSpline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:NiagaraSpline");
				return null;
			}
			return UObjectMarshaler<BGUSplineActor>.FromNative(IntPtr.Add(base.Address, NiagaraSpline_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NiagaraSpline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:NiagaraSpline");
			}
			else
			{
				UObjectMarshaler<BGUSplineActor>.ToNative(IntPtr.Add(base.Address, NiagaraSpline_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Tooltip("Spider niagara在spline的哪个index开始跟随玩家")]
	[USharpPath("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderFollowStartIndex")]
	public int SpiderFollowStartIndex
	{
		get
		{
			CheckDestroyed();
			if (!SpiderFollowStartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderFollowStartIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SpiderFollowStartIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpiderFollowStartIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderFollowStartIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SpiderFollowStartIndex_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Tooltip("NiagaraActor移动速度曲线，横轴为Spline上点的Index，纵轴为速度")]
	[USharpPath("/Script/b1-Managed.BUS_SpiderOceanMgrComp:NiagaraMoveCurve")]
	public UCurveFloat NiagaraMoveCurve
	{
		get
		{
			CheckDestroyed();
			if (!NiagaraMoveCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:NiagaraMoveCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, NiagaraMoveCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NiagaraMoveCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:NiagaraMoveCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, NiagaraMoveCurve_Offset), value);
			}
		}
	}

	[Tooltip("Spider移动距离曲线，横轴为时间，纵轴为Spider距离NiagaraActor多远会停下")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderDistanceCurve")]
	public UCurveFloat SpiderDistanceCurve
	{
		get
		{
			CheckDestroyed();
			if (!SpiderDistanceCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderDistanceCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, SpiderDistanceCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpiderDistanceCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderDistanceCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, SpiderDistanceCurve_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Tooltip("Spider出生点选择曲线，横轴为Spline上点的Index，纵轴为当前选择的场景中SpawnPoints的数量")]
	[USharpPath("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderSpawnPointsSelectCurve")]
	public UCurveFloat SpiderSpawnPointsSelectCurve
	{
		get
		{
			CheckDestroyed();
			if (!SpiderSpawnPointsSelectCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderSpawnPointsSelectCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, SpiderSpawnPointsSelectCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpiderSpawnPointsSelectCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderSpawnPointsSelectCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, SpiderSpawnPointsSelectCurve_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderSpawnPointTag")]
	public FName SpiderSpawnPointTag
	{
		get
		{
			CheckDestroyed();
			if (!SpiderSpawnPointTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderSpawnPointTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SpiderSpawnPointTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpiderSpawnPointTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderSpawnPointTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SpiderSpawnPointTag_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderSectorActor")]
	public AActor SpiderSectorActor
	{
		get
		{
			CheckDestroyed();
			if (!SpiderSectorActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderSectorActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, SpiderSectorActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpiderSectorActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderSectorActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, SpiderSectorActor_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Tooltip("蛛海扇形缩放曲线")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderSectorScaleCurve")]
	public UCurveVector SpiderSectorScaleCurve
	{
		get
		{
			CheckDestroyed();
			if (!SpiderSectorScaleCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderSectorScaleCurve");
				return null;
			}
			return UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(base.Address, SpiderSectorScaleCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpiderSectorScaleCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderSectorScaleCurve");
			}
			else
			{
				UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(base.Address, SpiderSectorScaleCurve_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderSpawnPoints")]
	public TArrayReadWrite<SpiderSpawnPointData> SpiderSpawnPoints
	{
		get
		{
			CheckDestroyed();
			if (!SpiderSpawnPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:SpiderSpawnPoints");
				return null;
			}
			if (SpiderSpawnPoints_Marshaler == null)
			{
				SpiderSpawnPoints_Marshaler = new TArrayReadWriteMarshaler<SpiderSpawnPointData>(1, SpiderSpawnPoints_PropertyAddress, CachedMarshalingDelegates<SpiderSpawnPointData, SpiderSpawnPointData>.FromNative, CachedMarshalingDelegates<SpiderSpawnPointData, SpiderSpawnPointData>.ToNative);
			}
			return SpiderSpawnPoints_Marshaler.FromNative(IntPtr.Add(base.Address, SpiderSpawnPoints_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_SpiderOceanMgrComp:bDrawDebugNiagaraLocation")]
	public bool bDrawDebugNiagaraLocation
	{
		get
		{
			CheckDestroyed();
			if (!bDrawDebugNiagaraLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:bDrawDebugNiagaraLocation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDrawDebugNiagaraLocation_Offset), 0, bDrawDebugNiagaraLocation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDrawDebugNiagaraLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:bDrawDebugNiagaraLocation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDrawDebugNiagaraLocation_Offset), 0, bDrawDebugNiagaraLocation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_SpiderOceanMgrComp:FixedGuid")]
	public FUnitGuidData FixedGuid
	{
		get
		{
			CheckDestroyed();
			if (!FixedGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:FixedGuid");
				return default(FUnitGuidData);
			}
			return BlittableTypeMarshaler<FUnitGuidData>.FromNative(IntPtr.Add(base.Address, FixedGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FixedGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpiderOceanMgrComp:FixedGuid");
			}
			else
			{
				BlittableTypeMarshaler<FUnitGuidData>.ToNative(IntPtr.Add(base.Address, FixedGuid_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		SpiderFollowStartIndex = -1;
	}

	public override void OnDataConvert(AActor Owner)
	{
		RequireWritableData<BUC_SpiderOceanMgrData>().CopyBPDataToData(SpiderNiagara, AdditionalSpiderNiagaraList.ToList(), NiagaraSpline, SpiderFollowStartIndex, SpiderSectorActor, NiagaraMoveCurve, SpiderDistanceCurve, SpiderSpawnPoints.ToList(), SpiderSpawnPointsSelectCurve, bDrawDebugNiagaraLocation, SpiderSpawnPointTag, SpiderSectorScaleCurve);
		RequireWritableData<BUC_GuidData>().CopyBPDataToData(FixedGuid);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_SpiderOceanMgrComp");
		SpiderNiagara_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpiderNiagara");
		SpiderNiagara_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpiderNiagara", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref AdditionalSpiderNiagaraList_PropertyAddress, unrealStruct, "AdditionalSpiderNiagaraList");
		AdditionalSpiderNiagaraList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AdditionalSpiderNiagaraList");
		AdditionalSpiderNiagaraList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AdditionalSpiderNiagaraList", Classes.FArrayProperty);
		NiagaraSpline_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NiagaraSpline");
		NiagaraSpline_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NiagaraSpline", Classes.FObjectProperty);
		SpiderFollowStartIndex_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpiderFollowStartIndex");
		SpiderFollowStartIndex_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpiderFollowStartIndex", Classes.FIntProperty);
		NiagaraMoveCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NiagaraMoveCurve");
		NiagaraMoveCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NiagaraMoveCurve", Classes.FObjectProperty);
		SpiderDistanceCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpiderDistanceCurve");
		SpiderDistanceCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpiderDistanceCurve", Classes.FObjectProperty);
		SpiderSpawnPointsSelectCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpiderSpawnPointsSelectCurve");
		SpiderSpawnPointsSelectCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpiderSpawnPointsSelectCurve", Classes.FObjectProperty);
		SpiderSpawnPointTag_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpiderSpawnPointTag");
		SpiderSpawnPointTag_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpiderSpawnPointTag", Classes.FNameProperty);
		SpiderSectorActor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpiderSectorActor");
		SpiderSectorActor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpiderSectorActor", Classes.FObjectProperty);
		SpiderSectorScaleCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpiderSectorScaleCurve");
		SpiderSectorScaleCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpiderSectorScaleCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SpiderSpawnPoints_PropertyAddress, unrealStruct, "SpiderSpawnPoints");
		SpiderSpawnPoints_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpiderSpawnPoints");
		SpiderSpawnPoints_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpiderSpawnPoints", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bDrawDebugNiagaraLocation_PropertyAddress, unrealStruct, "bDrawDebugNiagaraLocation");
		bDrawDebugNiagaraLocation_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bDrawDebugNiagaraLocation");
		bDrawDebugNiagaraLocation_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bDrawDebugNiagaraLocation", Classes.FBoolProperty);
		FixedGuid_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FixedGuid");
		FixedGuid_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FixedGuid", Classes.FStructProperty);
	}

	static BUS_SpiderOceanMgrComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SpiderOceanMgrComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SpiderOceanMgrComp));
	}
}
