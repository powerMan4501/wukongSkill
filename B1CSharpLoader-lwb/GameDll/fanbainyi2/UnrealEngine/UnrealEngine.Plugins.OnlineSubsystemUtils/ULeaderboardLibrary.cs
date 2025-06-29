using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/OnlineSubsystemUtils.LeaderboardBlueprintLibrary", "OnlineSubsystemUtils", UnrealModuleType.EnginePlugin)]
public class ULeaderboardLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool WriteLeaderboardInteger_IsValid;

	private static IntPtr WriteLeaderboardInteger_FunctionAddress;

	private static int WriteLeaderboardInteger_ParamsSize;

	private static bool WriteLeaderboardInteger_PlayerController_IsValid;

	private static FFieldAddress WriteLeaderboardInteger_PlayerController_PropertyAddress;

	private static int WriteLeaderboardInteger_PlayerController_Offset;

	private static bool WriteLeaderboardInteger_StatName_IsValid;

	private static FFieldAddress WriteLeaderboardInteger_StatName_PropertyAddress;

	private static int WriteLeaderboardInteger_StatName_Offset;

	private static bool WriteLeaderboardInteger_StatValue_IsValid;

	private static FFieldAddress WriteLeaderboardInteger_StatValue_PropertyAddress;

	private static int WriteLeaderboardInteger_StatValue_Offset;

	private static bool WriteLeaderboardInteger_ReturnValue_IsValid;

	private static FFieldAddress WriteLeaderboardInteger_ReturnValue_PropertyAddress;

	private static int WriteLeaderboardInteger_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/OnlineSubsystemUtils.LeaderboardBlueprintLibrary:WriteLeaderboardInteger")]
	public unsafe static bool WriteLeaderboardInteger(APlayerController PlayerController, FName StatName, int StatValue)
	{
		if (!WriteLeaderboardInteger_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.LeaderboardBlueprintLibrary:WriteLeaderboardInteger");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WriteLeaderboardInteger_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WriteLeaderboardInteger_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, WriteLeaderboardInteger_PlayerController_Offset), 0, WriteLeaderboardInteger_PlayerController_PropertyAddress.Address, PlayerController);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, WriteLeaderboardInteger_StatName_Offset), 0, WriteLeaderboardInteger_StatName_PropertyAddress.Address, StatName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, WriteLeaderboardInteger_StatValue_Offset), 0, WriteLeaderboardInteger_StatValue_PropertyAddress.Address, StatValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, WriteLeaderboardInteger_FunctionAddress, intPtr, WriteLeaderboardInteger_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, WriteLeaderboardInteger_ReturnValue_Offset), 0, WriteLeaderboardInteger_ReturnValue_PropertyAddress.Address);
	}

	static ULeaderboardLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULeaderboardLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULeaderboardLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/OnlineSubsystemUtils.LeaderboardBlueprintLibrary");
		WriteLeaderboardInteger_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "WriteLeaderboardInteger");
		WriteLeaderboardInteger_ParamsSize = NativeReflection.GetFunctionParamsSize(WriteLeaderboardInteger_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WriteLeaderboardInteger_PlayerController_PropertyAddress, WriteLeaderboardInteger_FunctionAddress, "PlayerController");
		WriteLeaderboardInteger_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(WriteLeaderboardInteger_FunctionAddress, "PlayerController");
		WriteLeaderboardInteger_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteLeaderboardInteger_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteLeaderboardInteger_StatName_PropertyAddress, WriteLeaderboardInteger_FunctionAddress, "StatName");
		WriteLeaderboardInteger_StatName_Offset = NativeReflectionCached.GetPropertyOffset(WriteLeaderboardInteger_FunctionAddress, "StatName");
		WriteLeaderboardInteger_StatName_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteLeaderboardInteger_FunctionAddress, "StatName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteLeaderboardInteger_StatValue_PropertyAddress, WriteLeaderboardInteger_FunctionAddress, "StatValue");
		WriteLeaderboardInteger_StatValue_Offset = NativeReflectionCached.GetPropertyOffset(WriteLeaderboardInteger_FunctionAddress, "StatValue");
		WriteLeaderboardInteger_StatValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteLeaderboardInteger_FunctionAddress, "StatValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteLeaderboardInteger_ReturnValue_PropertyAddress, WriteLeaderboardInteger_FunctionAddress, "ReturnValue");
		WriteLeaderboardInteger_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WriteLeaderboardInteger_FunctionAddress, "ReturnValue");
		WriteLeaderboardInteger_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteLeaderboardInteger_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		WriteLeaderboardInteger_IsValid = WriteLeaderboardInteger_FunctionAddress != IntPtr.Zero && WriteLeaderboardInteger_PlayerController_IsValid && WriteLeaderboardInteger_StatName_IsValid && WriteLeaderboardInteger_StatValue_IsValid && WriteLeaderboardInteger_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.LeaderboardBlueprintLibrary:WriteLeaderboardInteger", WriteLeaderboardInteger_IsValid);
	}
}
