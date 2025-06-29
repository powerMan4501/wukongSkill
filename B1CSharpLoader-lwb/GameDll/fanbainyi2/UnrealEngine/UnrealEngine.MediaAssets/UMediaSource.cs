using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[Abstract]
[UClass(Flags = (ClassFlags)810553505uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MediaAssets.MediaSource", "MediaAssets", UnrealModuleType.Engine)]
public class UMediaSource : UObject
{
	private static bool Validate_IsValid;

	private static IntPtr Validate_FunctionAddress;

	private static int Validate_ParamsSize;

	private static bool Validate_ReturnValue_IsValid;

	private static FFieldAddress Validate_ReturnValue_PropertyAddress;

	private static int Validate_ReturnValue_Offset;

	private static bool SetMediaOptionString_IsValid;

	private static IntPtr SetMediaOptionString_FunctionAddress;

	private static int SetMediaOptionString_ParamsSize;

	private static bool SetMediaOptionString_Key_IsValid;

	private static FFieldAddress SetMediaOptionString_Key_PropertyAddress;

	private static int SetMediaOptionString_Key_Offset;

	private static bool SetMediaOptionString_Value_IsValid;

	private static FFieldAddress SetMediaOptionString_Value_PropertyAddress;

	private static int SetMediaOptionString_Value_Offset;

	private static bool SetMediaOptionInt64_IsValid;

	private static IntPtr SetMediaOptionInt64_FunctionAddress;

	private static int SetMediaOptionInt64_ParamsSize;

	private static bool SetMediaOptionInt64_Key_IsValid;

	private static FFieldAddress SetMediaOptionInt64_Key_PropertyAddress;

	private static int SetMediaOptionInt64_Key_Offset;

	private static bool SetMediaOptionInt64_Value_IsValid;

	private static FFieldAddress SetMediaOptionInt64_Value_PropertyAddress;

	private static int SetMediaOptionInt64_Value_Offset;

	private static bool SetMediaOptionFloat_IsValid;

	private static IntPtr SetMediaOptionFloat_FunctionAddress;

	private static int SetMediaOptionFloat_ParamsSize;

	private static bool SetMediaOptionFloat_Key_IsValid;

	private static FFieldAddress SetMediaOptionFloat_Key_PropertyAddress;

	private static int SetMediaOptionFloat_Key_Offset;

	private static bool SetMediaOptionFloat_Value_IsValid;

	private static FFieldAddress SetMediaOptionFloat_Value_PropertyAddress;

	private static int SetMediaOptionFloat_Value_Offset;

	private static bool SetMediaOptionBool_IsValid;

	private static IntPtr SetMediaOptionBool_FunctionAddress;

	private static int SetMediaOptionBool_ParamsSize;

	private static bool SetMediaOptionBool_Key_IsValid;

	private static FFieldAddress SetMediaOptionBool_Key_PropertyAddress;

	private static int SetMediaOptionBool_Key_Offset;

	private static bool SetMediaOptionBool_Value_IsValid;

	private static FFieldAddress SetMediaOptionBool_Value_PropertyAddress;

	private static int SetMediaOptionBool_Value_Offset;

	private static bool GetUrl_IsValid;

	private static IntPtr GetUrl_FunctionAddress;

	private static int GetUrl_ParamsSize;

	private static bool GetUrl_ReturnValue_IsValid;

	private static FFieldAddress GetUrl_ReturnValue_PropertyAddress;

	private static int GetUrl_ReturnValue_Offset;

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/MediaAssets.MediaSource:Validate")]
	public unsafe bool Validate()
	{
		CheckDestroyed();
		if (!Validate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaSource:Validate");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Validate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Validate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Validate_FunctionAddress, intPtr, Validate_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Validate_ReturnValue_Offset), 0, Validate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MediaAssets.MediaSource:SetMediaOptionString")]
	public unsafe void SetMediaOptionString(FName Key, string Value)
	{
		CheckDestroyed();
		if (!SetMediaOptionString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaSource:SetMediaOptionString");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMediaOptionString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMediaOptionString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetMediaOptionString_Key_Offset), 0, SetMediaOptionString_Key_PropertyAddress.Address, Key);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetMediaOptionString_Value_Offset), 0, SetMediaOptionString_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMediaOptionString_FunctionAddress, intPtr, SetMediaOptionString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMediaOptionString_Value_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MediaAssets.MediaSource:SetMediaOptionInt64")]
	public unsafe void SetMediaOptionInt64(FName Key, long Value)
	{
		CheckDestroyed();
		if (!SetMediaOptionInt64_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaSource:SetMediaOptionInt64");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMediaOptionInt64_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMediaOptionInt64_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetMediaOptionInt64_Key_Offset), 0, SetMediaOptionInt64_Key_PropertyAddress.Address, Key);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, SetMediaOptionInt64_Value_Offset), 0, SetMediaOptionInt64_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMediaOptionInt64_FunctionAddress, intPtr, SetMediaOptionInt64_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MediaAssets.MediaSource:SetMediaOptionFloat")]
	public unsafe void SetMediaOptionFloat(FName Key, float Value)
	{
		CheckDestroyed();
		if (!SetMediaOptionFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaSource:SetMediaOptionFloat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMediaOptionFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMediaOptionFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetMediaOptionFloat_Key_Offset), 0, SetMediaOptionFloat_Key_PropertyAddress.Address, Key);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMediaOptionFloat_Value_Offset), 0, SetMediaOptionFloat_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMediaOptionFloat_FunctionAddress, intPtr, SetMediaOptionFloat_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MediaAssets.MediaSource:SetMediaOptionBool")]
	public unsafe void SetMediaOptionBool(FName Key, bool Value)
	{
		CheckDestroyed();
		if (!SetMediaOptionBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaSource:SetMediaOptionBool");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMediaOptionBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMediaOptionBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetMediaOptionBool_Key_Offset), 0, SetMediaOptionBool_Key_PropertyAddress.Address, Key);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetMediaOptionBool_Value_Offset), 0, SetMediaOptionBool_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMediaOptionBool_FunctionAddress, intPtr, SetMediaOptionBool_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/MediaAssets.MediaSource:GetUrl")]
	public unsafe string GetUrl()
	{
		CheckDestroyed();
		if (!GetUrl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.MediaSource:GetUrl");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUrl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUrl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUrl_FunctionAddress, intPtr, GetUrl_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetUrl_ReturnValue_Offset), 0, GetUrl_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetUrl_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UMediaSource()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMediaSource)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMediaSource));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MediaAssets.MediaSource");
		Validate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Validate");
		Validate_ParamsSize = NativeReflection.GetFunctionParamsSize(Validate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Validate_ReturnValue_PropertyAddress, Validate_FunctionAddress, "ReturnValue");
		Validate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Validate_FunctionAddress, "ReturnValue");
		Validate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Validate_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Validate_IsValid = Validate_FunctionAddress != IntPtr.Zero && Validate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaSource:Validate", Validate_IsValid);
		SetMediaOptionString_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetMediaOptionString");
		SetMediaOptionString_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMediaOptionString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMediaOptionString_Key_PropertyAddress, SetMediaOptionString_FunctionAddress, "Key");
		SetMediaOptionString_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetMediaOptionString_FunctionAddress, "Key");
		SetMediaOptionString_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMediaOptionString_FunctionAddress, "Key", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMediaOptionString_Value_PropertyAddress, SetMediaOptionString_FunctionAddress, "Value");
		SetMediaOptionString_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetMediaOptionString_FunctionAddress, "Value");
		SetMediaOptionString_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMediaOptionString_FunctionAddress, "Value", Classes.FStrProperty);
		SetMediaOptionString_IsValid = SetMediaOptionString_FunctionAddress != IntPtr.Zero && SetMediaOptionString_Key_IsValid && SetMediaOptionString_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaSource:SetMediaOptionString", SetMediaOptionString_IsValid);
		SetMediaOptionInt64_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetMediaOptionInt64");
		SetMediaOptionInt64_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMediaOptionInt64_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMediaOptionInt64_Key_PropertyAddress, SetMediaOptionInt64_FunctionAddress, "Key");
		SetMediaOptionInt64_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetMediaOptionInt64_FunctionAddress, "Key");
		SetMediaOptionInt64_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMediaOptionInt64_FunctionAddress, "Key", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMediaOptionInt64_Value_PropertyAddress, SetMediaOptionInt64_FunctionAddress, "Value");
		SetMediaOptionInt64_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetMediaOptionInt64_FunctionAddress, "Value");
		SetMediaOptionInt64_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMediaOptionInt64_FunctionAddress, "Value", Classes.FInt64Property);
		SetMediaOptionInt64_IsValid = SetMediaOptionInt64_FunctionAddress != IntPtr.Zero && SetMediaOptionInt64_Key_IsValid && SetMediaOptionInt64_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaSource:SetMediaOptionInt64", SetMediaOptionInt64_IsValid);
		SetMediaOptionFloat_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetMediaOptionFloat");
		SetMediaOptionFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMediaOptionFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMediaOptionFloat_Key_PropertyAddress, SetMediaOptionFloat_FunctionAddress, "Key");
		SetMediaOptionFloat_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetMediaOptionFloat_FunctionAddress, "Key");
		SetMediaOptionFloat_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMediaOptionFloat_FunctionAddress, "Key", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMediaOptionFloat_Value_PropertyAddress, SetMediaOptionFloat_FunctionAddress, "Value");
		SetMediaOptionFloat_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetMediaOptionFloat_FunctionAddress, "Value");
		SetMediaOptionFloat_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMediaOptionFloat_FunctionAddress, "Value", Classes.FFloatProperty);
		SetMediaOptionFloat_IsValid = SetMediaOptionFloat_FunctionAddress != IntPtr.Zero && SetMediaOptionFloat_Key_IsValid && SetMediaOptionFloat_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaSource:SetMediaOptionFloat", SetMediaOptionFloat_IsValid);
		SetMediaOptionBool_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetMediaOptionBool");
		SetMediaOptionBool_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMediaOptionBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMediaOptionBool_Key_PropertyAddress, SetMediaOptionBool_FunctionAddress, "Key");
		SetMediaOptionBool_Key_Offset = NativeReflectionCached.GetPropertyOffset(SetMediaOptionBool_FunctionAddress, "Key");
		SetMediaOptionBool_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMediaOptionBool_FunctionAddress, "Key", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMediaOptionBool_Value_PropertyAddress, SetMediaOptionBool_FunctionAddress, "Value");
		SetMediaOptionBool_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetMediaOptionBool_FunctionAddress, "Value");
		SetMediaOptionBool_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMediaOptionBool_FunctionAddress, "Value", Classes.FBoolProperty);
		SetMediaOptionBool_IsValid = SetMediaOptionBool_FunctionAddress != IntPtr.Zero && SetMediaOptionBool_Key_IsValid && SetMediaOptionBool_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaSource:SetMediaOptionBool", SetMediaOptionBool_IsValid);
		GetUrl_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetUrl");
		GetUrl_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUrl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUrl_ReturnValue_PropertyAddress, GetUrl_FunctionAddress, "ReturnValue");
		GetUrl_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUrl_FunctionAddress, "ReturnValue");
		GetUrl_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUrl_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetUrl_IsValid = GetUrl_FunctionAddress != IntPtr.Zero && GetUrl_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.MediaSource:GetUrl", GetUrl_IsValid);
	}
}
