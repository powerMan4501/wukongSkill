using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp")]
public class BUS_SceneRotateTriggerConfigComp : UActorEditCompBase
{
	private static bool SkeletalMeshActor_IsValid;

	private static int SkeletalMeshActor_Offset;

	private static bool AnimSequence_IsValid;

	private static int AnimSequence_Offset;

	private static bool AttachPoint_IsValid;

	private static int AttachPoint_Offset;

	private static bool LocationCurve_IsValid;

	private static int LocationCurve_Offset;

	private static bool RotationCurve_IsValid;

	private static int RotationCurve_Offset;

	private static bool MultiplierCurveL_IsValid;

	private static int MultiplierCurveL_Offset;

	private static bool MultiplierCurveR_IsValid;

	private static int MultiplierCurveR_Offset;

	private static bool AffectedLevels_IsValid;

	private static int AffectedLevels_Offset;

	private static FFieldAddress AffectedLevels_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> AffectedLevels_Marshaler;

	private static bool AffectedNiagaraNPC_IsValid;

	private static int AffectedNiagaraNPC_Offset;

	private static FFieldAddress AffectedNiagaraNPC_PropertyAddress;

	private TArrayReadWriteMarshaler<TSoftObject<UNiagaraParameterCollection>> AffectedNiagaraNPC_Marshaler;

	[Category("场景运动配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:SkeletalMeshActor")]
	public TSoftObject<AActor> SkeletalMeshActor
	{
		get
		{
			CheckDestroyed();
			if (!SkeletalMeshActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:SkeletalMeshActor");
				return default(TSoftObject<AActor>);
			}
			return TSoftObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, SkeletalMeshActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkeletalMeshActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:SkeletalMeshActor");
			}
			else
			{
				TSoftObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, SkeletalMeshActor_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("场景运动配置")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:AnimSequence")]
	public UAnimSequence AnimSequence
	{
		get
		{
			CheckDestroyed();
			if (!AnimSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:AnimSequence");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimSequence_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimSequence_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:AnimSequence");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimSequence_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("场景运动配置")]
	[USharpPath("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:AttachPoint")]
	public FName AttachPoint
	{
		get
		{
			CheckDestroyed();
			if (!AttachPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:AttachPoint");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AttachPoint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:AttachPoint");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AttachPoint_Offset), value);
			}
		}
	}

	[Category("场景运动配置")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:LocationCurve")]
	public UCurveVector LocationCurve
	{
		get
		{
			CheckDestroyed();
			if (!LocationCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:LocationCurve");
				return null;
			}
			return UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(base.Address, LocationCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LocationCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:LocationCurve");
			}
			else
			{
				UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(base.Address, LocationCurve_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("场景运动配置")]
	[USharpPath("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:RotationCurve")]
	public UCurveVector RotationCurve
	{
		get
		{
			CheckDestroyed();
			if (!RotationCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:RotationCurve");
				return null;
			}
			return UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(base.Address, RotationCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotationCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:RotationCurve");
			}
			else
			{
				UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(base.Address, RotationCurve_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("场景运动配置")]
	[USharpPath("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:MultiplierCurveL")]
	public UCurveVector MultiplierCurveL
	{
		get
		{
			CheckDestroyed();
			if (!MultiplierCurveL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:MultiplierCurveL");
				return null;
			}
			return UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(base.Address, MultiplierCurveL_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MultiplierCurveL_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:MultiplierCurveL");
			}
			else
			{
				UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(base.Address, MultiplierCurveL_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("场景运动配置")]
	[USharpPath("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:MultiplierCurveR")]
	public UCurveVector MultiplierCurveR
	{
		get
		{
			CheckDestroyed();
			if (!MultiplierCurveR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:MultiplierCurveR");
				return null;
			}
			return UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(base.Address, MultiplierCurveR_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MultiplierCurveR_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:MultiplierCurveR");
			}
			else
			{
				UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(base.Address, MultiplierCurveR_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("场景运动配置")]
	[USharpPath("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:AffectedLevels")]
	public TArrayReadWrite<FName> AffectedLevels
	{
		get
		{
			CheckDestroyed();
			if (!AffectedLevels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:AffectedLevels");
				return null;
			}
			if (AffectedLevels_Marshaler == null)
			{
				AffectedLevels_Marshaler = new TArrayReadWriteMarshaler<FName>(1, AffectedLevels_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return AffectedLevels_Marshaler.FromNative(IntPtr.Add(base.Address, AffectedLevels_Offset));
		}
	}

	[Category("场景运动配置")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:AffectedNiagaraNPC")]
	public TArrayReadWrite<TSoftObject<UNiagaraParameterCollection>> AffectedNiagaraNPC
	{
		get
		{
			CheckDestroyed();
			if (!AffectedNiagaraNPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp:AffectedNiagaraNPC");
				return null;
			}
			if (AffectedNiagaraNPC_Marshaler == null)
			{
				AffectedNiagaraNPC_Marshaler = new TArrayReadWriteMarshaler<TSoftObject<UNiagaraParameterCollection>>(1, AffectedNiagaraNPC_PropertyAddress, CachedMarshalingDelegates<TSoftObject<UNiagaraParameterCollection>, TSoftObjectMarshaler<UNiagaraParameterCollection>>.FromNative, CachedMarshalingDelegates<TSoftObject<UNiagaraParameterCollection>, TSoftObjectMarshaler<UNiagaraParameterCollection>>.ToNative);
			}
			return AffectedNiagaraNPC_Marshaler.FromNative(IntPtr.Add(base.Address, AffectedNiagaraNPC_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.IsEditorOnly = false;
	}

	public override void OnDataConvert(AActor Owner)
	{
		b1.BUC_SceneRotateTriggerData bUC_SceneRotateTriggerData = RequireWritableData<b1.BUC_SceneRotateTriggerData>();
		bUC_SceneRotateTriggerData.SkeletalMeshActor = SkeletalMeshActor;
		bUC_SceneRotateTriggerData.AttachPoint = AttachPoint;
		bUC_SceneRotateTriggerData.AnimSequence = AnimSequence;
		bUC_SceneRotateTriggerData.LocationCurve = LocationCurve;
		bUC_SceneRotateTriggerData.RotationCurve = RotationCurve;
		bUC_SceneRotateTriggerData.MultiplierCurveL = MultiplierCurveL;
		bUC_SceneRotateTriggerData.MultiplierCurveR = MultiplierCurveR;
		bUC_SceneRotateTriggerData.AffectedLevels = AffectedLevels.ToList();
		foreach (TSoftObject<UNiagaraParameterCollection> item in AffectedNiagaraNPC)
		{
			if (item.LoadSynchronous() != null)
			{
				bUC_SceneRotateTriggerData.AffectedNiagaraNPC.Add(new TStrongObjectPtr<UNiagaraParameterCollectionInstance>(UNiagaraFunctionLibrary.GetNiagaraParameterCollection(Owner, item.Value)));
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_SceneRotateTriggerConfigComp");
		SkeletalMeshActor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SkeletalMeshActor");
		SkeletalMeshActor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SkeletalMeshActor", Classes.FSoftObjectProperty);
		AnimSequence_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimSequence");
		AnimSequence_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimSequence", Classes.FObjectProperty);
		AttachPoint_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AttachPoint");
		AttachPoint_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AttachPoint", Classes.FNameProperty);
		LocationCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LocationCurve");
		LocationCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LocationCurve", Classes.FObjectProperty);
		RotationCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RotationCurve");
		RotationCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RotationCurve", Classes.FObjectProperty);
		MultiplierCurveL_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MultiplierCurveL");
		MultiplierCurveL_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MultiplierCurveL", Classes.FObjectProperty);
		MultiplierCurveR_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MultiplierCurveR");
		MultiplierCurveR_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MultiplierCurveR", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref AffectedLevels_PropertyAddress, unrealStruct, "AffectedLevels");
		AffectedLevels_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AffectedLevels");
		AffectedLevels_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AffectedLevels", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AffectedNiagaraNPC_PropertyAddress, unrealStruct, "AffectedNiagaraNPC");
		AffectedNiagaraNPC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AffectedNiagaraNPC");
		AffectedNiagaraNPC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AffectedNiagaraNPC", Classes.FArrayProperty);
	}

	static BUS_SceneRotateTriggerConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SceneRotateTriggerConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SceneRotateTriggerConfigComp));
	}
}
