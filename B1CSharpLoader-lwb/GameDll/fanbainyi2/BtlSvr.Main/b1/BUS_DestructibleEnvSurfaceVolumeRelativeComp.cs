using System;
using b1.EventDelDefine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintSpawnableComponent]
[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BUS_DestructibleEnvSurfaceVolumeRelativeComp")]
public class BUS_DestructibleEnvSurfaceVolumeRelativeComp : UBaseActorComp
{
	private static bool RelativeEnvironmentSurfaceVolumes_IsValid;

	private static int RelativeEnvironmentSurfaceVolumes_Offset;

	private static FFieldAddress RelativeEnvironmentSurfaceVolumes_PropertyAddress;

	private TArrayReadWriteMarshaler<TSoftObject<ABGWEnvironmentSurfaceVolume>> RelativeEnvironmentSurfaceVolumes_Marshaler;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_DestructibleEnvSurfaceVolumeRelativeComp:RelativeEnvironmentSurfaceVolumes")]
	public TArrayReadWrite<TSoftObject<ABGWEnvironmentSurfaceVolume>> RelativeEnvironmentSurfaceVolumes
	{
		get
		{
			CheckDestroyed();
			if (!RelativeEnvironmentSurfaceVolumes_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_DestructibleEnvSurfaceVolumeRelativeComp:RelativeEnvironmentSurfaceVolumes");
				return null;
			}
			if (RelativeEnvironmentSurfaceVolumes_Marshaler == null)
			{
				RelativeEnvironmentSurfaceVolumes_Marshaler = new TArrayReadWriteMarshaler<TSoftObject<ABGWEnvironmentSurfaceVolume>>(1, RelativeEnvironmentSurfaceVolumes_PropertyAddress, CachedMarshalingDelegates<TSoftObject<ABGWEnvironmentSurfaceVolume>, TSoftObjectMarshaler<ABGWEnvironmentSurfaceVolume>>.FromNative, CachedMarshalingDelegates<TSoftObject<ABGWEnvironmentSurfaceVolume>, TSoftObjectMarshaler<ABGWEnvironmentSurfaceVolume>>.ToNative);
			}
			return RelativeEnvironmentSurfaceVolumes_Marshaler.FromNative(IntPtr.Add(base.Address, RelativeEnvironmentSurfaceVolumes_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BUS_DestructibleEnvSurfaceVolumeRelativeComp:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(GetOwner());
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_DestroyDestructible += new Del_DestroyDestructible(OnDestroyDestructible);
		}
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(this);
		if (!(bGS_GSEventCollection != null))
		{
			return;
		}
		foreach (TSoftObject<ABGWEnvironmentSurfaceVolume> relativeEnvironmentSurfaceVolume in RelativeEnvironmentSurfaceVolumes)
		{
			bGS_GSEventCollection.Evt_BGS_SetEnvironmentSurfaceVolumeEnabled.Invoke(relativeEnvironmentSurfaceVolume, bIsEnabled: true);
		}
	}

	private void OnDestroyDestructible(FVector HitLocation, FVector ImpulseDir, float ImpulseStrength)
	{
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(this);
		if (!(bGS_GSEventCollection != null))
		{
			return;
		}
		foreach (TSoftObject<ABGWEnvironmentSurfaceVolume> relativeEnvironmentSurfaceVolume in RelativeEnvironmentSurfaceVolumes)
		{
			bGS_GSEventCollection.Evt_BGS_SetEnvironmentSurfaceVolumeEnabled.Invoke(relativeEnvironmentSurfaceVolume, bIsEnabled: false);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_DestructibleEnvSurfaceVolumeRelativeComp:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_DestructibleEnvSurfaceVolumeRelativeComp bUS_DestructibleEnvSurfaceVolumeRelativeComp = GCHelper.Find<BUS_DestructibleEnvSurfaceVolumeRelativeComp>(obj);
		bUS_DestructibleEnvSurfaceVolumeRelativeComp.BeginPlayInCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_DestructibleEnvSurfaceVolumeRelativeComp");
		NativeReflection.GetPropertyRef(ref RelativeEnvironmentSurfaceVolumes_PropertyAddress, intPtr, "RelativeEnvironmentSurfaceVolumes");
		RelativeEnvironmentSurfaceVolumes_Offset = NativeReflection.GetPropertyOffset(intPtr, "RelativeEnvironmentSurfaceVolumes");
		RelativeEnvironmentSurfaceVolumes_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RelativeEnvironmentSurfaceVolumes", Classes.FArrayProperty);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_DestructibleEnvSurfaceVolumeRelativeComp:BeginPlayInCS", BeginPlayInCS_IsValid);
	}

	static BUS_DestructibleEnvSurfaceVolumeRelativeComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_DestructibleEnvSurfaceVolumeRelativeComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_DestructibleEnvSurfaceVolumeRelativeComp));
	}
}
