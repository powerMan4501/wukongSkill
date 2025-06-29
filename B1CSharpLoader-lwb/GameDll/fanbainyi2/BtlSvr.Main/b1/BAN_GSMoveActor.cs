using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN Move Actor")]
[USharpPath("/Script/b1-Managed.BAN_GSMoveActor")]
internal class BAN_GSMoveActor : BAN_GSBase
{
	private static bool LocationOffset_IsValid;

	private static int LocationOffset_Offset;

	private static bool RotationOffset_IsValid;

	private static int RotationOffset_Offset;

	private static bool IsLocalSpace_IsValid;

	private static int IsLocalSpace_Offset;

	private static FFieldAddress IsLocalSpace_PropertyAddress;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[Category("Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSMoveActor:LocationOffset")]
	public FVector LocationOffset
	{
		get
		{
			CheckDestroyed();
			if (!LocationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMoveActor:LocationOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, LocationOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LocationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMoveActor:LocationOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, LocationOffset_Offset), value);
			}
		}
	}

	[Category("Config")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSMoveActor:RotationOffset")]
	public FRotator RotationOffset
	{
		get
		{
			CheckDestroyed();
			if (!RotationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMoveActor:RotationOffset");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, RotationOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMoveActor:RotationOffset");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, RotationOffset_Offset), value);
			}
		}
	}

	[Category("Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSMoveActor:IsLocalSpace")]
	public bool IsLocalSpace
	{
		get
		{
			CheckDestroyed();
			if (!IsLocalSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMoveActor:IsLocalSpace");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsLocalSpace_Offset), 0, IsLocalSpace_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsLocalSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMoveActor:IsLocalSpace");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsLocalSpace_Offset), 0, IsLocalSpace_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSMoveActor:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor aActor = NotifyParam.MeshComp?.GetOwner();
		if (!(aActor != null))
		{
			return;
		}
		if (LocationOffset != FVector.ZeroVector)
		{
			if (IsLocalSpace)
			{
				aActor.AddActorLocalOffset(LocationOffset, bSweep: true, out var _, bTeleport: false);
			}
			else
			{
				aActor.AddActorWorldOffset(LocationOffset, bSweep: true, out var _, bTeleport: false);
			}
		}
		if (RotationOffset != FRotator.ZeroRotator)
		{
			if (IsLocalSpace)
			{
				aActor.AddActorLocalRotation(RotationOffset, bSweep: true, out var _, bTeleport: false);
			}
			else
			{
				aActor.AddActorWorldRotation(RotationOffset, bSweep: true, out var _, bTeleport: false);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSMoveActor:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSMoveActor bAN_GSMoveActor = GCHelper.Find<b1.BAN_GSMoveActor>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSMoveActor.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSMoveActor");
		LocationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "LocationOffset");
		LocationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LocationOffset", Classes.FStructProperty);
		RotationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotationOffset");
		RotationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotationOffset", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref IsLocalSpace_PropertyAddress, intPtr, "IsLocalSpace");
		IsLocalSpace_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsLocalSpace");
		IsLocalSpace_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsLocalSpace", Classes.FBoolProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSMoveActor:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSMoveActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSMoveActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSMoveActor));
	}
}
