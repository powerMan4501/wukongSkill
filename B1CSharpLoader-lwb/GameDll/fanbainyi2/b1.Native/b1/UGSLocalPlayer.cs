using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549420uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.GSLocalPlayer", "b1", UnrealModuleType.Game)]
public class UGSLocalPlayer : ULocalPlayer
{
	private static bool GetGameLoginOptionsCS_IsValid;

	private IntPtr GetGameLoginOptionsCS_InstanceFunctionAddress;

	private static IntPtr GetGameLoginOptionsCS_FunctionAddress;

	private static int GetGameLoginOptionsCS_ParamsSize;

	private static bool GetGameLoginOptionsCS_ReturnValue_IsValid;

	private static FFieldAddress GetGameLoginOptionsCS_ReturnValue_PropertyAddress;

	private static int GetGameLoginOptionsCS_ReturnValue_Offset;

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/b1.GSLocalPlayer:GetGameLoginOptionsCS")]
	public unsafe string GetGameLoginOptionsCS()
	{
		CheckDestroyed();
		if (!GetGameLoginOptionsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSLocalPlayer:GetGameLoginOptionsCS");
			return FStringMarshaler.DefaultString;
		}
		if (GetGameLoginOptionsCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetGameLoginOptionsCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetGameLoginOptionsCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGameLoginOptionsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGameLoginOptionsCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGameLoginOptionsCS_InstanceFunctionAddress, intPtr, GetGameLoginOptionsCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetGameLoginOptionsCS_ReturnValue_Offset), 0, GetGameLoginOptionsCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetGameLoginOptionsCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetGameLoginOptionsCS_Implementation()
	{
		CheckDestroyed();
		if (!GetGameLoginOptionsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSLocalPlayer:GetGameLoginOptionsCS");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGameLoginOptionsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGameLoginOptionsCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGameLoginOptionsCS_FunctionAddress, intPtr, GetGameLoginOptionsCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetGameLoginOptionsCS_ReturnValue_Offset), 0, GetGameLoginOptionsCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetGameLoginOptionsCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UGSLocalPlayer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSLocalPlayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSLocalPlayer));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.GSLocalPlayer");
		GetGameLoginOptionsCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetGameLoginOptionsCS");
		GetGameLoginOptionsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGameLoginOptionsCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGameLoginOptionsCS_ReturnValue_PropertyAddress, GetGameLoginOptionsCS_FunctionAddress, "ReturnValue");
		GetGameLoginOptionsCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGameLoginOptionsCS_FunctionAddress, "ReturnValue");
		GetGameLoginOptionsCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGameLoginOptionsCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetGameLoginOptionsCS_IsValid = GetGameLoginOptionsCS_FunctionAddress != IntPtr.Zero && GetGameLoginOptionsCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSLocalPlayer:GetGameLoginOptionsCS", GetGameLoginOptionsCS_IsValid);
	}
}
