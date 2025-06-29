using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

public sealed class IRTXSettingsImpl : IInterfaceImpl, IRTXSettings, IInterface
{
	private static bool SetRTXQuality_IsValid;

	private IntPtr SetRTXQuality_InstanceFunctionAddress;

	private static IntPtr SetRTXQuality_FunctionAddress;

	private static int SetRTXQuality_ParamsSize;

	private static bool SetRTXQuality_Quality_IsValid;

	private static FFieldAddress SetRTXQuality_Quality_PropertyAddress;

	private static int SetRTXQuality_Quality_Offset;

	private static bool SetRTXEnabled_IsValid;

	private IntPtr SetRTXEnabled_InstanceFunctionAddress;

	private static IntPtr SetRTXEnabled_FunctionAddress;

	private static int SetRTXEnabled_ParamsSize;

	private static bool SetRTXEnabled_bInEnable_IsValid;

	private static FFieldAddress SetRTXEnabled_bInEnable_PropertyAddress;

	private static int SetRTXEnabled_bInEnable_Offset;

	private static bool SetDlssRREnable_IsValid;

	private IntPtr SetDlssRREnable_InstanceFunctionAddress;

	private static IntPtr SetDlssRREnable_FunctionAddress;

	private static int SetDlssRREnable_ParamsSize;

	private static bool SetDlssRREnable_bEnable_IsValid;

	private static FFieldAddress SetDlssRREnable_bEnable_PropertyAddress;

	private static int SetDlssRREnable_bEnable_Offset;

	private static bool IsRTXEnabled_IsValid;

	private IntPtr IsRTXEnabled_InstanceFunctionAddress;

	private static IntPtr IsRTXEnabled_FunctionAddress;

	private static int IsRTXEnabled_ParamsSize;

	private static bool IsRTXEnabled_ReturnValue_IsValid;

	private static FFieldAddress IsRTXEnabled_ReturnValue_PropertyAddress;

	private static int IsRTXEnabled_ReturnValue_Offset;

	private static bool IsDLSSRREnabled_IsValid;

	private IntPtr IsDLSSRREnabled_InstanceFunctionAddress;

	private static IntPtr IsDLSSRREnabled_FunctionAddress;

	private static int IsDLSSRREnabled_ParamsSize;

	private static bool IsDLSSRREnabled_ReturnValue_IsValid;

	private static FFieldAddress IsDLSSRREnabled_ReturnValue_PropertyAddress;

	private static int IsDLSSRREnabled_ReturnValue_Offset;

	private static bool GetRTXQuality_IsValid;

	private IntPtr GetRTXQuality_InstanceFunctionAddress;

	private static IntPtr GetRTXQuality_FunctionAddress;

	private static int GetRTXQuality_ParamsSize;

	private static bool GetRTXQuality_ReturnValue_IsValid;

	private static FFieldAddress GetRTXQuality_ReturnValue_PropertyAddress;

	private static int GetRTXQuality_ReturnValue_Offset;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/CustomLightSystem.RTXSettings:SetRTXQuality")]
	public unsafe void SetRTXQuality(byte Quality)
	{
		CheckDestroyed();
		if (!SetRTXQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.RTXSettings:SetRTXQuality");
			return;
		}
		if (SetRTXQuality_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetRTXQuality_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetRTXQuality");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRTXQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRTXQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, SetRTXQuality_Quality_Offset), 0, SetRTXQuality_Quality_PropertyAddress.Address, Quality);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRTXQuality_InstanceFunctionAddress, intPtr, SetRTXQuality_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/CustomLightSystem.RTXSettings:SetRTXEnabled")]
	public unsafe void SetRTXEnabled(bool bInEnable)
	{
		CheckDestroyed();
		if (!SetRTXEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.RTXSettings:SetRTXEnabled");
			return;
		}
		if (SetRTXEnabled_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetRTXEnabled_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetRTXEnabled");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRTXEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRTXEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRTXEnabled_bInEnable_Offset), 0, SetRTXEnabled_bInEnable_PropertyAddress.Address, bInEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRTXEnabled_InstanceFunctionAddress, intPtr, SetRTXEnabled_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/CustomLightSystem.RTXSettings:SetDlssRREnable")]
	public unsafe void SetDlssRREnable(bool bEnable)
	{
		CheckDestroyed();
		if (!SetDlssRREnable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.RTXSettings:SetDlssRREnable");
			return;
		}
		if (SetDlssRREnable_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetDlssRREnable_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetDlssRREnable");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDlssRREnable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDlssRREnable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetDlssRREnable_bEnable_Offset), 0, SetDlssRREnable_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDlssRREnable_InstanceFunctionAddress, intPtr, SetDlssRREnable_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/CustomLightSystem.RTXSettings:IsRTXEnabled")]
	public unsafe bool IsRTXEnabled()
	{
		CheckDestroyed();
		if (!IsRTXEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.RTXSettings:IsRTXEnabled");
			return false;
		}
		if (IsRTXEnabled_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsRTXEnabled_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsRTXEnabled");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRTXEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRTXEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsRTXEnabled_InstanceFunctionAddress, intPtr, IsRTXEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRTXEnabled_ReturnValue_Offset), 0, IsRTXEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/CustomLightSystem.RTXSettings:IsDLSSRREnabled")]
	public unsafe bool IsDLSSRREnabled()
	{
		CheckDestroyed();
		if (!IsDLSSRREnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.RTXSettings:IsDLSSRREnabled");
			return false;
		}
		if (IsDLSSRREnabled_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsDLSSRREnabled_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsDLSSRREnabled");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDLSSRREnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDLSSRREnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsDLSSRREnabled_InstanceFunctionAddress, intPtr, IsDLSSRREnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDLSSRREnabled_ReturnValue_Offset), 0, IsDLSSRREnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/CustomLightSystem.RTXSettings:GetRTXQuality")]
	public unsafe byte GetRTXQuality()
	{
		CheckDestroyed();
		if (!GetRTXQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.RTXSettings:GetRTXQuality");
			return 0;
		}
		if (GetRTXQuality_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetRTXQuality_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetRTXQuality");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRTXQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRTXQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRTXQuality_InstanceFunctionAddress, intPtr, GetRTXQuality_ParamsSize);
		return BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(intPtr, GetRTXQuality_ReturnValue_Offset), 0, GetRTXQuality_ReturnValue_PropertyAddress.Address);
	}

	public override void ResetInterface()
	{
		SetRTXQuality_InstanceFunctionAddress = IntPtr.Zero;
		SetRTXEnabled_InstanceFunctionAddress = IntPtr.Zero;
		SetDlssRREnable_InstanceFunctionAddress = IntPtr.Zero;
		IsRTXEnabled_InstanceFunctionAddress = IntPtr.Zero;
		IsDLSSRREnabled_InstanceFunctionAddress = IntPtr.Zero;
		GetRTXQuality_InstanceFunctionAddress = IntPtr.Zero;
	}

	static IRTXSettingsImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IRTXSettingsImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IRTXSettingsImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/CustomLightSystem.RTXSettings");
		SetRTXQuality_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetRTXQuality");
		SetRTXQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRTXQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRTXQuality_Quality_PropertyAddress, SetRTXQuality_FunctionAddress, "Quality");
		SetRTXQuality_Quality_Offset = NativeReflectionCached.GetPropertyOffset(SetRTXQuality_FunctionAddress, "Quality");
		SetRTXQuality_Quality_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRTXQuality_FunctionAddress, "Quality", Classes.FByteProperty);
		SetRTXQuality_IsValid = SetRTXQuality_FunctionAddress != IntPtr.Zero && SetRTXQuality_Quality_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.RTXSettings:SetRTXQuality", SetRTXQuality_IsValid);
		SetRTXEnabled_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetRTXEnabled");
		SetRTXEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRTXEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRTXEnabled_bInEnable_PropertyAddress, SetRTXEnabled_FunctionAddress, "bInEnable");
		SetRTXEnabled_bInEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetRTXEnabled_FunctionAddress, "bInEnable");
		SetRTXEnabled_bInEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRTXEnabled_FunctionAddress, "bInEnable", Classes.FBoolProperty);
		SetRTXEnabled_IsValid = SetRTXEnabled_FunctionAddress != IntPtr.Zero && SetRTXEnabled_bInEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.RTXSettings:SetRTXEnabled", SetRTXEnabled_IsValid);
		SetDlssRREnable_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDlssRREnable");
		SetDlssRREnable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDlssRREnable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDlssRREnable_bEnable_PropertyAddress, SetDlssRREnable_FunctionAddress, "bEnable");
		SetDlssRREnable_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetDlssRREnable_FunctionAddress, "bEnable");
		SetDlssRREnable_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDlssRREnable_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SetDlssRREnable_IsValid = SetDlssRREnable_FunctionAddress != IntPtr.Zero && SetDlssRREnable_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.RTXSettings:SetDlssRREnable", SetDlssRREnable_IsValid);
		IsRTXEnabled_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsRTXEnabled");
		IsRTXEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRTXEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRTXEnabled_ReturnValue_PropertyAddress, IsRTXEnabled_FunctionAddress, "ReturnValue");
		IsRTXEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRTXEnabled_FunctionAddress, "ReturnValue");
		IsRTXEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRTXEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRTXEnabled_IsValid = IsRTXEnabled_FunctionAddress != IntPtr.Zero && IsRTXEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.RTXSettings:IsRTXEnabled", IsRTXEnabled_IsValid);
		IsDLSSRREnabled_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsDLSSRREnabled");
		IsDLSSRREnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDLSSRREnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDLSSRREnabled_ReturnValue_PropertyAddress, IsDLSSRREnabled_FunctionAddress, "ReturnValue");
		IsDLSSRREnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDLSSRREnabled_FunctionAddress, "ReturnValue");
		IsDLSSRREnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDLSSRREnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDLSSRREnabled_IsValid = IsDLSSRREnabled_FunctionAddress != IntPtr.Zero && IsDLSSRREnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.RTXSettings:IsDLSSRREnabled", IsDLSSRREnabled_IsValid);
		GetRTXQuality_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRTXQuality");
		GetRTXQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRTXQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRTXQuality_ReturnValue_PropertyAddress, GetRTXQuality_FunctionAddress, "ReturnValue");
		GetRTXQuality_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRTXQuality_FunctionAddress, "ReturnValue");
		GetRTXQuality_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRTXQuality_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetRTXQuality_IsValid = GetRTXQuality_FunctionAddress != IntPtr.Zero && GetRTXQuality_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.RTXSettings:GetRTXQuality", GetRTXQuality_IsValid);
	}
}
