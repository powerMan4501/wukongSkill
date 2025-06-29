using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUAnimShadowInstanceBase")]
public class BUAnimShadowInstanceBase : UAnimInstance
{
	private static bool Snapshot_IsValid;

	private static int Snapshot_Offset;

	[BlueprintReadOnly]
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimShadowInstanceBase:Snapshot")]
	public FPoseSnapshot Snapshot
	{
		get
		{
			CheckDestroyed();
			if (!Snapshot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimShadowInstanceBase:Snapshot");
				return default(FPoseSnapshot);
			}
			return FPoseSnapshot.FromNative(IntPtr.Add(base.Address, Snapshot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Snapshot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimShadowInstanceBase:Snapshot");
			}
			else
			{
				FPoseSnapshot.ToNative(IntPtr.Add(base.Address, Snapshot_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUAnimShadowInstanceBase");
		Snapshot_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Snapshot");
		Snapshot_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Snapshot", Classes.FStructProperty);
	}

	static BUAnimShadowInstanceBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimShadowInstanceBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimShadowInstanceBase));
	}
}
