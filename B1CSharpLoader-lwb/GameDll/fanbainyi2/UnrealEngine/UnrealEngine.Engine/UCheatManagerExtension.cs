using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.CheatManagerExtension", "Engine", UnrealModuleType.Engine)]
public class UCheatManagerExtension : UObject
{
	private static bool GetPlayerController_IsValid;

	private static IntPtr GetPlayerController_FunctionAddress;

	private static int GetPlayerController_ParamsSize;

	private static bool GetPlayerController_ReturnValue_IsValid;

	private static FFieldAddress GetPlayerController_ReturnValue_PropertyAddress;

	private static int GetPlayerController_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.CheatManagerExtension:GetPlayerController")]
	public unsafe APlayerController GetPlayerController()
	{
		CheckDestroyed();
		if (!GetPlayerController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CheatManagerExtension:GetPlayerController");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayerController_FunctionAddress, intPtr, GetPlayerController_ParamsSize);
		return UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(intPtr, GetPlayerController_ReturnValue_Offset), 0, GetPlayerController_ReturnValue_PropertyAddress.Address);
	}

	static UCheatManagerExtension()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCheatManagerExtension)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCheatManagerExtension));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.CheatManagerExtension");
		GetPlayerController_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPlayerController");
		GetPlayerController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerController_ReturnValue_PropertyAddress, GetPlayerController_FunctionAddress, "ReturnValue");
		GetPlayerController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerController_FunctionAddress, "ReturnValue");
		GetPlayerController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerController_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPlayerController_IsValid = GetPlayerController_FunctionAddress != IntPtr.Zero && GetPlayerController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CheatManagerExtension:GetPlayerController", GetPlayerController_IsValid);
	}
}
