using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN Launch Character")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSLaunchCharacter")]
internal class BAN_GSLaunchCharacter : BAN_GSBase
{
	private static bool LaunchVelocity_IsValid;

	private static int LaunchVelocity_Offset;

	private static bool bXYOverride_IsValid;

	private static int bXYOverride_Offset;

	private static FFieldAddress bXYOverride_PropertyAddress;

	private static bool bZOverride_IsValid;

	private static int bZOverride_Offset;

	private static FFieldAddress bZOverride_PropertyAddress;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[Category("Launch Character Config")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSLaunchCharacter:LaunchVelocity")]
	public FVector LaunchVelocity
	{
		get
		{
			CheckDestroyed();
			if (!LaunchVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSLaunchCharacter:LaunchVelocity");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, LaunchVelocity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LaunchVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSLaunchCharacter:LaunchVelocity");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, LaunchVelocity_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Launch Character Config")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSLaunchCharacter:bXYOverride")]
	private bool bXYOverride
	{
		get
		{
			CheckDestroyed();
			if (!bXYOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSLaunchCharacter:bXYOverride");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bXYOverride_Offset), 0, bXYOverride_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bXYOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSLaunchCharacter:bXYOverride");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bXYOverride_Offset), 0, bXYOverride_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Launch Character Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSLaunchCharacter:bZOverride")]
	private bool bZOverride
	{
		get
		{
			CheckDestroyed();
			if (!bZOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSLaunchCharacter:bZOverride");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bZOverride_Offset), 0, bZOverride_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bZOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSLaunchCharacter:bZOverride");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bZOverride_Offset), 0, bZOverride_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSLaunchCharacter:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSLaunchCharacter:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		ACharacter aCharacter = NotifyParam.owner as ACharacter;
		if (!(aCharacter == null))
		{
			FVector launchVelocity = MathLib.TransformDirection(BGUFuncLibActorTransformCS.BGUGetActorTransform(aCharacter), LaunchVelocity.GetSafeNormal()) * LaunchVelocity.Size();
			aCharacter.LaunchCharacter(launchVelocity, bXYOverride, bZOverride);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSLaunchCharacter:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSLaunchCharacter bAN_GSLaunchCharacter = GCHelper.Find<b1.BAN_GSLaunchCharacter>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSLaunchCharacter.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSLaunchCharacter:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSLaunchCharacter bAN_GSLaunchCharacter = GCHelper.Find<b1.BAN_GSLaunchCharacter>(obj);
		bool value = bAN_GSLaunchCharacter.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSLaunchCharacter");
		LaunchVelocity_Offset = NativeReflection.GetPropertyOffset(intPtr, "LaunchVelocity");
		LaunchVelocity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LaunchVelocity", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bXYOverride_PropertyAddress, intPtr, "bXYOverride");
		bXYOverride_Offset = NativeReflection.GetPropertyOffset(intPtr, "bXYOverride");
		bXYOverride_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bXYOverride", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bZOverride_PropertyAddress, intPtr, "bZOverride");
		bZOverride_Offset = NativeReflection.GetPropertyOffset(intPtr, "bZOverride");
		bZOverride_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bZOverride", Classes.FBoolProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSLaunchCharacter:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSLaunchCharacter:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSLaunchCharacter()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSLaunchCharacter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSLaunchCharacter));
	}
}
