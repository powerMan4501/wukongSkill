using System;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[BlueprintSpawnableComponent]
[DisplayName("破碎物摧毁关联组件 DestructibleActorRelativeDestroyComp")]
[Tooltip("破碎物摧毁关联组件，用于配置破碎物在破碎的同时，销毁场景中的物体，如特效、光源等")]
[USharpPath("/Script/b1-Managed.BUS_DestructibleActorRelativeDestroyComp")]
public class BUS_DestructibleActorRelativeDestroyComp : UBaseActorComp
{
	private static bool RelativeDestroyActors_IsValid;

	private static int RelativeDestroyActors_Offset;

	private static FFieldAddress RelativeDestroyActors_PropertyAddress;

	private TArrayReadWriteMarshaler<TSoftObject<AActor>> RelativeDestroyActors_Marshaler;

	private static bool RelativeDestroyDestructibles_IsValid;

	private static int RelativeDestroyDestructibles_Offset;

	private static FFieldAddress RelativeDestroyDestructibles_PropertyAddress;

	private TArrayReadWriteMarshaler<TSoftObject<BGUFXActorBase>> RelativeDestroyDestructibles_Marshaler;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	[DisplayName("摧毁关联物体")]
	[EditAnywhere]
	[UProperty]
	[Tooltip("破碎物被摧毁的同时，需要销毁的物品列表")]
	[BlueprintReadWrite]
	[Category("破碎物摧毁关联配置")]
	[USharpPath("/Script/b1-Managed.BUS_DestructibleActorRelativeDestroyComp:RelativeDestroyActors")]
	public TArrayReadWrite<TSoftObject<AActor>> RelativeDestroyActors
	{
		get
		{
			CheckDestroyed();
			if (!RelativeDestroyActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleActorRelativeDestroyComp:RelativeDestroyActors");
				return null;
			}
			if (RelativeDestroyActors_Marshaler == null)
			{
				RelativeDestroyActors_Marshaler = new TArrayReadWriteMarshaler<TSoftObject<AActor>>(1, RelativeDestroyActors_PropertyAddress, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<TSoftObject<AActor>, TSoftObjectMarshaler<AActor>>.ToNative);
			}
			return RelativeDestroyActors_Marshaler.FromNative(IntPtr.Add(base.Address, RelativeDestroyActors_Offset));
		}
	}

	[Category("破碎物摧毁关联配置")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("摧毁关联破碎物")]
	[Tooltip("破碎物被摧毁的同时，需要关联触发破碎的破碎物列表")]
	[USharpPath("/Script/b1-Managed.BUS_DestructibleActorRelativeDestroyComp:RelativeDestroyDestructibles")]
	public TArrayReadWrite<TSoftObject<BGUFXActorBase>> RelativeDestroyDestructibles
	{
		get
		{
			CheckDestroyed();
			if (!RelativeDestroyDestructibles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleActorRelativeDestroyComp:RelativeDestroyDestructibles");
				return null;
			}
			if (RelativeDestroyDestructibles_Marshaler == null)
			{
				RelativeDestroyDestructibles_Marshaler = new TArrayReadWriteMarshaler<TSoftObject<BGUFXActorBase>>(1, RelativeDestroyDestructibles_PropertyAddress, CachedMarshalingDelegates<TSoftObject<BGUFXActorBase>, TSoftObjectMarshaler<BGUFXActorBase>>.FromNative, CachedMarshalingDelegates<TSoftObject<BGUFXActorBase>, TSoftObjectMarshaler<BGUFXActorBase>>.ToNative);
			}
			return RelativeDestroyDestructibles_Marshaler.FromNative(IntPtr.Add(base.Address, RelativeDestroyDestructibles_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BUS_DestructibleActorRelativeDestroyComp:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(GetOwner());
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_DestroyDestructible += new Del_DestroyDestructible(OnDestroyDestructible);
		}
	}

	private void OnDestroyDestructible(FVector HitLocation, FVector ImpulseDir, float ImpulseStrength)
	{
		AActor owner = GetOwner();
		foreach (TSoftObject<AActor> relativeDestroyActor in RelativeDestroyActors)
		{
			AActor value = relativeDestroyActor.Value;
			if (value != null && value != owner)
			{
				BGU_UnrealWorldUtil.DestroyActor(value);
			}
		}
		foreach (TSoftObject<BGUFXActorBase> relativeDestroyDestructible in RelativeDestroyDestructibles)
		{
			BGUFXActorBase value2 = relativeDestroyDestructible.Value;
			if (value2 != null && value2 != owner)
			{
				if ((object)value2 != null)
				{
					BUS_EventCollectionCS.Get(value2)?.Evt_DestroyDestructible.Invoke(HitLocation, ImpulseDir, ImpulseStrength);
				}
				else
				{
					BGU_UnrealWorldUtil.DestroyActor(value2);
				}
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_DestructibleActorRelativeDestroyComp:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_DestructibleActorRelativeDestroyComp bUS_DestructibleActorRelativeDestroyComp = GCHelper.Find<BUS_DestructibleActorRelativeDestroyComp>(obj);
		bUS_DestructibleActorRelativeDestroyComp.BeginPlayInCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_DestructibleActorRelativeDestroyComp");
		NativeReflection.GetPropertyRef(ref RelativeDestroyActors_PropertyAddress, intPtr, "RelativeDestroyActors");
		RelativeDestroyActors_Offset = NativeReflection.GetPropertyOffset(intPtr, "RelativeDestroyActors");
		RelativeDestroyActors_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RelativeDestroyActors", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref RelativeDestroyDestructibles_PropertyAddress, intPtr, "RelativeDestroyDestructibles");
		RelativeDestroyDestructibles_Offset = NativeReflection.GetPropertyOffset(intPtr, "RelativeDestroyDestructibles");
		RelativeDestroyDestructibles_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RelativeDestroyDestructibles", Classes.FArrayProperty);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_DestructibleActorRelativeDestroyComp:BeginPlayInCS", BeginPlayInCS_IsValid);
	}

	static BUS_DestructibleActorRelativeDestroyComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_DestructibleActorRelativeDestroyComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_DestructibleActorRelativeDestroyComp));
	}
}
