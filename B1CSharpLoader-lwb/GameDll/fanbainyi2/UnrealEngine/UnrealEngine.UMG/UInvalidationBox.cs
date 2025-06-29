using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.InvalidationBox", "UMG", UnrealModuleType.Engine)]
public class UInvalidationBox : UContentWidget
{
	private static bool SetCanCache_IsValid;

	private static IntPtr SetCanCache_FunctionAddress;

	private static int SetCanCache_ParamsSize;

	private static bool SetCanCache_CanCache_IsValid;

	private static FFieldAddress SetCanCache_CanCache_PropertyAddress;

	private static int SetCanCache_CanCache_Offset;

	private static bool GetCanCache_IsValid;

	private static IntPtr GetCanCache_FunctionAddress;

	private static int GetCanCache_ParamsSize;

	private static bool GetCanCache_ReturnValue_IsValid;

	private static FFieldAddress GetCanCache_ReturnValue_PropertyAddress;

	private static int GetCanCache_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.InvalidationBox:SetCanCache")]
	public unsafe void SetCanCache(bool CanCache)
	{
		CheckDestroyed();
		if (!SetCanCache_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.InvalidationBox:SetCanCache");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCanCache_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCanCache_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCanCache_CanCache_Offset), 0, SetCanCache_CanCache_PropertyAddress.Address, CanCache);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCanCache_FunctionAddress, intPtr, SetCanCache_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.InvalidationBox:GetCanCache")]
	public unsafe bool GetCanCache()
	{
		CheckDestroyed();
		if (!GetCanCache_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.InvalidationBox:GetCanCache");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCanCache_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCanCache_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCanCache_FunctionAddress, intPtr, GetCanCache_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCanCache_ReturnValue_Offset), 0, GetCanCache_ReturnValue_PropertyAddress.Address);
	}

	static UInvalidationBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInvalidationBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInvalidationBox));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UMG.InvalidationBox");
		SetCanCache_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCanCache");
		SetCanCache_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCanCache_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCanCache_CanCache_PropertyAddress, SetCanCache_FunctionAddress, "CanCache");
		SetCanCache_CanCache_Offset = NativeReflectionCached.GetPropertyOffset(SetCanCache_FunctionAddress, "CanCache");
		SetCanCache_CanCache_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCanCache_FunctionAddress, "CanCache", Classes.FBoolProperty);
		SetCanCache_IsValid = SetCanCache_FunctionAddress != IntPtr.Zero && SetCanCache_CanCache_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.InvalidationBox:SetCanCache", SetCanCache_IsValid);
		GetCanCache_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCanCache");
		GetCanCache_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCanCache_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCanCache_ReturnValue_PropertyAddress, GetCanCache_FunctionAddress, "ReturnValue");
		GetCanCache_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCanCache_FunctionAddress, "ReturnValue");
		GetCanCache_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCanCache_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCanCache_IsValid = GetCanCache_FunctionAddress != IntPtr.Zero && GetCanCache_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.InvalidationBox:GetCanCache", GetCanCache_IsValid);
	}
}
