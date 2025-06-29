using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN TeleportPlayerTo")]
[USharpPath("/Script/b1-Managed.BAN_TeleportPlayerTo")]
internal class BAN_TeleportPlayerTo : BAN_GSBase
{
	private static bool TeleportPointName_IsValid;

	private static int TeleportPointName_Offset;

	private static bool ResetCamera_IsValid;

	private static int ResetCamera_Offset;

	private static FFieldAddress ResetCamera_PropertyAddress;

	private static bool ControlRot_IsValid;

	private static int ControlRot_Offset;

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

	[BlueprintReadWrite]
	[UProperty]
	[Category("Anim Notify")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_TeleportPlayerTo:TeleportPointName")]
	public string TeleportPointName
	{
		get
		{
			CheckDestroyed();
			if (!TeleportPointName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_TeleportPlayerTo:TeleportPointName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, TeleportPointName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TeleportPointName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_TeleportPlayerTo:TeleportPointName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, TeleportPointName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_TeleportPlayerTo:ResetCamera")]
	public bool ResetCamera
	{
		get
		{
			CheckDestroyed();
			if (!ResetCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_TeleportPlayerTo:ResetCamera");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ResetCamera_Offset), 0, ResetCamera_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ResetCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_TeleportPlayerTo:ResetCamera");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ResetCamera_Offset), 0, ResetCamera_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_TeleportPlayerTo:ControlRot")]
	public FRotator ControlRot
	{
		get
		{
			CheckDestroyed();
			if (!ControlRot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_TeleportPlayerTo:ControlRot");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, ControlRot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ControlRot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_TeleportPlayerTo:ControlRot");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, ControlRot_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_TeleportPlayerTo:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_TeleportPlayerTo:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner == null))
		{
			USystemLibrary.ExecuteConsoleCommand(this, "b.teleport " + TeleportPointName, null);
			UGameplayStatics.GetPlayerCharacter(owner, 0);
			AController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
			if (ResetCamera && !firstLocalPlayerController.IsNullOrDestroyed())
			{
				firstLocalPlayerController.SetControlRotation(ControlRot);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_TeleportPlayerTo:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_TeleportPlayerTo bAN_TeleportPlayerTo = GCHelper.Find<b1.BAN_TeleportPlayerTo>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_TeleportPlayerTo.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_TeleportPlayerTo:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_TeleportPlayerTo bAN_TeleportPlayerTo = GCHelper.Find<b1.BAN_TeleportPlayerTo>(obj);
		bool value = bAN_TeleportPlayerTo.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_TeleportPlayerTo");
		TeleportPointName_Offset = NativeReflection.GetPropertyOffset(intPtr, "TeleportPointName");
		TeleportPointName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TeleportPointName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref ResetCamera_PropertyAddress, intPtr, "ResetCamera");
		ResetCamera_Offset = NativeReflection.GetPropertyOffset(intPtr, "ResetCamera");
		ResetCamera_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ResetCamera", Classes.FBoolProperty);
		ControlRot_Offset = NativeReflection.GetPropertyOffset(intPtr, "ControlRot");
		ControlRot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ControlRot", Classes.FStructProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_TeleportPlayerTo:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_TeleportPlayerTo:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_TeleportPlayerTo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_TeleportPlayerTo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_TeleportPlayerTo));
	}
}
