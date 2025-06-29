using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

public sealed class IBUAnimLocomotionExImpl : IInterfaceImpl, IBUAnimLocomotionEx, IInterface
{
	private static bool SetLocoExSettings_IsValid;

	private IntPtr SetLocoExSettings_InstanceFunctionAddress;

	private static IntPtr SetLocoExSettings_FunctionAddress;

	private static int SetLocoExSettings_ParamsSize;

	private static bool SetLocoExSettings_Settings_IsValid;

	private static FFieldAddress SetLocoExSettings_Settings_PropertyAddress;

	private static int SetLocoExSettings_Settings_Offset;

	private static bool SetLocoExEnable_IsValid;

	private IntPtr SetLocoExEnable_InstanceFunctionAddress;

	private static IntPtr SetLocoExEnable_FunctionAddress;

	private static int SetLocoExEnable_ParamsSize;

	private static bool SetLocoExEnable_bEnable_IsValid;

	private static FFieldAddress SetLocoExEnable_bEnable_PropertyAddress;

	private static int SetLocoExEnable_bEnable_Offset;

	[UFunction(Flags = 205655040u)]
	[UMetaPath("/Script/b1.BUAnimLocomotionEx:SetLocoExSettings")]
	public unsafe void SetLocoExSettings(FBUAnimSettingsLocomotionEx Settings)
	{
		CheckDestroyed();
		if (!SetLocoExSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUAnimLocomotionEx:SetLocoExSettings");
			return;
		}
		if (SetLocoExSettings_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetLocoExSettings_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetLocoExSettings");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLocoExSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLocoExSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FBUAnimSettingsLocomotionEx.ToNative(IntPtr.Add(intPtr, SetLocoExSettings_Settings_Offset), 0, SetLocoExSettings_Settings_PropertyAddress.Address, Settings);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLocoExSettings_InstanceFunctionAddress, intPtr, SetLocoExSettings_ParamsSize);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/b1.BUAnimLocomotionEx:SetLocoExEnable")]
	public unsafe void SetLocoExEnable(bool bEnable)
	{
		CheckDestroyed();
		if (!SetLocoExEnable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BUAnimLocomotionEx:SetLocoExEnable");
			return;
		}
		if (SetLocoExEnable_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetLocoExEnable_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetLocoExEnable");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLocoExEnable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLocoExEnable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocoExEnable_bEnable_Offset), 0, SetLocoExEnable_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLocoExEnable_InstanceFunctionAddress, intPtr, SetLocoExEnable_ParamsSize);
	}

	public override void ResetInterface()
	{
		SetLocoExSettings_InstanceFunctionAddress = IntPtr.Zero;
		SetLocoExEnable_InstanceFunctionAddress = IntPtr.Zero;
	}

	static IBUAnimLocomotionExImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IBUAnimLocomotionExImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IBUAnimLocomotionExImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BUAnimLocomotionEx");
		SetLocoExSettings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLocoExSettings");
		SetLocoExSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLocoExSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLocoExSettings_Settings_PropertyAddress, SetLocoExSettings_FunctionAddress, "Settings");
		SetLocoExSettings_Settings_Offset = NativeReflectionCached.GetPropertyOffset(SetLocoExSettings_FunctionAddress, "Settings");
		SetLocoExSettings_Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocoExSettings_FunctionAddress, "Settings", Classes.FStructProperty);
		SetLocoExSettings_IsValid = SetLocoExSettings_FunctionAddress != IntPtr.Zero && SetLocoExSettings_Settings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUAnimLocomotionEx:SetLocoExSettings", SetLocoExSettings_IsValid);
		SetLocoExEnable_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLocoExEnable");
		SetLocoExEnable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLocoExEnable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLocoExEnable_bEnable_PropertyAddress, SetLocoExEnable_FunctionAddress, "bEnable");
		SetLocoExEnable_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetLocoExEnable_FunctionAddress, "bEnable");
		SetLocoExEnable_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocoExEnable_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SetLocoExEnable_IsValid = SetLocoExEnable_FunctionAddress != IntPtr.Zero && SetLocoExEnable_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BUAnimLocomotionEx:SetLocoExEnable", SetLocoExEnable_IsValid);
	}
}
