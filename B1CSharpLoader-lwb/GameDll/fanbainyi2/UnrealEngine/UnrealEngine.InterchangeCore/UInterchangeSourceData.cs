using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.InterchangeCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/InterchangeCore.InterchangeSourceData", "InterchangeCore", UnrealModuleType.Engine)]
public class UInterchangeSourceData : UObject
{
	private static bool SetFilename_IsValid;

	private static IntPtr SetFilename_FunctionAddress;

	private static int SetFilename_ParamsSize;

	private static bool SetFilename_InFilename_IsValid;

	private static FFieldAddress SetFilename_InFilename_PropertyAddress;

	private static int SetFilename_InFilename_Offset;

	private static bool SetFilename_ReturnValue_IsValid;

	private static FFieldAddress SetFilename_ReturnValue_PropertyAddress;

	private static int SetFilename_ReturnValue_Offset;

	private static bool GetFilename_IsValid;

	private static IntPtr GetFilename_FunctionAddress;

	private static int GetFilename_ParamsSize;

	private static bool GetFilename_ReturnValue_IsValid;

	private static FFieldAddress GetFilename_ReturnValue_PropertyAddress;

	private static int GetFilename_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeSourceData:SetFilename")]
	public unsafe bool SetFilename(string InFilename)
	{
		CheckDestroyed();
		if (!SetFilename_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeSourceData:SetFilename");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilename_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilename_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetFilename_InFilename_Offset), 0, SetFilename_InFilename_PropertyAddress.Address, InFilename);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilename_FunctionAddress, intPtr, SetFilename_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetFilename_InFilename_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetFilename_ReturnValue_Offset), 0, SetFilename_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/InterchangeCore.InterchangeSourceData:GetFilename")]
	public unsafe string GetFilename()
	{
		CheckDestroyed();
		if (!GetFilename_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangeSourceData:GetFilename");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFilename_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFilename_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFilename_FunctionAddress, intPtr, GetFilename_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetFilename_ReturnValue_Offset), 0, GetFilename_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetFilename_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UInterchangeSourceData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeSourceData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeSourceData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeCore.InterchangeSourceData");
		SetFilename_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetFilename");
		SetFilename_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilename_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilename_InFilename_PropertyAddress, SetFilename_FunctionAddress, "InFilename");
		SetFilename_InFilename_Offset = NativeReflectionCached.GetPropertyOffset(SetFilename_FunctionAddress, "InFilename");
		SetFilename_InFilename_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilename_FunctionAddress, "InFilename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFilename_ReturnValue_PropertyAddress, SetFilename_FunctionAddress, "ReturnValue");
		SetFilename_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetFilename_FunctionAddress, "ReturnValue");
		SetFilename_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilename_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetFilename_IsValid = SetFilename_FunctionAddress != IntPtr.Zero && SetFilename_InFilename_IsValid && SetFilename_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeSourceData:SetFilename", SetFilename_IsValid);
		GetFilename_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFilename");
		GetFilename_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFilename_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFilename_ReturnValue_PropertyAddress, GetFilename_FunctionAddress, "ReturnValue");
		GetFilename_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFilename_FunctionAddress, "ReturnValue");
		GetFilename_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFilename_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetFilename_IsValid = GetFilename_FunctionAddress != IntPtr.Zero && GetFilename_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangeSourceData:GetFilename", GetFilename_IsValid);
	}
}
