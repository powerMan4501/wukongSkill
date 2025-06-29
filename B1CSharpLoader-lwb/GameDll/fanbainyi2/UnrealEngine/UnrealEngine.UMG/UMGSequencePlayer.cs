using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)810549416uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UMG.UMGSequencePlayer", "UMG", UnrealModuleType.Engine)]
public class UMGSequencePlayer : UObject
{
	private static bool SetUserTag_IsValid;

	private static IntPtr SetUserTag_FunctionAddress;

	private static int SetUserTag_ParamsSize;

	private static bool SetUserTag_InUserTag_IsValid;

	private static FFieldAddress SetUserTag_InUserTag_PropertyAddress;

	private static int SetUserTag_InUserTag_Offset;

	private static bool GetUserTag_IsValid;

	private static IntPtr GetUserTag_FunctionAddress;

	private static int GetUserTag_ParamsSize;

	private static bool GetUserTag_ReturnValue_IsValid;

	private static FFieldAddress GetUserTag_ReturnValue_PropertyAddress;

	private static int GetUserTag_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.UMGSequencePlayer:SetUserTag")]
	public unsafe void SetUserTag(FName InUserTag)
	{
		CheckDestroyed();
		if (!SetUserTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UMGSequencePlayer:SetUserTag");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUserTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUserTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetUserTag_InUserTag_Offset), 0, SetUserTag_InUserTag_PropertyAddress.Address, InUserTag);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUserTag_FunctionAddress, intPtr, SetUserTag_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.UMGSequencePlayer:GetUserTag")]
	public unsafe FName GetUserTag()
	{
		CheckDestroyed();
		if (!GetUserTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.UMGSequencePlayer:GetUserTag");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUserTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUserTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUserTag_FunctionAddress, intPtr, GetUserTag_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetUserTag_ReturnValue_Offset), 0, GetUserTag_ReturnValue_PropertyAddress.Address);
	}

	static UMGSequencePlayer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMGSequencePlayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMGSequencePlayer));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UMG.UMGSequencePlayer");
		SetUserTag_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetUserTag");
		SetUserTag_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUserTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUserTag_InUserTag_PropertyAddress, SetUserTag_FunctionAddress, "InUserTag");
		SetUserTag_InUserTag_Offset = NativeReflectionCached.GetPropertyOffset(SetUserTag_FunctionAddress, "InUserTag");
		SetUserTag_InUserTag_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUserTag_FunctionAddress, "InUserTag", Classes.FNameProperty);
		SetUserTag_IsValid = SetUserTag_FunctionAddress != IntPtr.Zero && SetUserTag_InUserTag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UMGSequencePlayer:SetUserTag", SetUserTag_IsValid);
		GetUserTag_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetUserTag");
		GetUserTag_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUserTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUserTag_ReturnValue_PropertyAddress, GetUserTag_FunctionAddress, "ReturnValue");
		GetUserTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUserTag_FunctionAddress, "ReturnValue");
		GetUserTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUserTag_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetUserTag_IsValid = GetUserTag_FunctionAddress != IntPtr.Zero && GetUserTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.UMGSequencePlayer:GetUserTag", GetUserTag_IsValid);
	}
}
