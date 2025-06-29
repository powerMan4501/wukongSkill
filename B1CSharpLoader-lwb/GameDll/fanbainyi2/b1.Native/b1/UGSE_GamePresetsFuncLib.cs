using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_GamePresetsFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_GamePresetsFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetPlatformGamePresets_IsValid;

	private static IntPtr GetPlatformGamePresets_FunctionAddress;

	private static int GetPlatformGamePresets_ParamsSize;

	private static bool GetPlatformGamePresets_GamePresets_IsValid;

	private static FFieldAddress GetPlatformGamePresets_GamePresets_PropertyAddress;

	private static int GetPlatformGamePresets_GamePresets_Offset;

	private static bool GetPlatformGamePresets_ReturnValue_IsValid;

	private static FFieldAddress GetPlatformGamePresets_ReturnValue_PropertyAddress;

	private static int GetPlatformGamePresets_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_GamePresetsFuncLib:GetPlatformGamePresets")]
	public unsafe static bool GetPlatformGamePresets(out FGamePresets GamePresets)
	{
		if (!GetPlatformGamePresets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_GamePresetsFuncLib:GetPlatformGamePresets");
			GamePresets = default(FGamePresets);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlatformGamePresets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlatformGamePresets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPlatformGamePresets_FunctionAddress, intPtr, GetPlatformGamePresets_ParamsSize);
		GamePresets = BlittableTypeMarshaler<FGamePresets>.FromNative(IntPtr.Add(intPtr, GetPlatformGamePresets_GamePresets_Offset), 0, GetPlatformGamePresets_GamePresets_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetPlatformGamePresets_ReturnValue_Offset), 0, GetPlatformGamePresets_ReturnValue_PropertyAddress.Address);
	}

	static UGSE_GamePresetsFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_GamePresetsFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_GamePresetsFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_GamePresetsFuncLib");
		GetPlatformGamePresets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPlatformGamePresets");
		GetPlatformGamePresets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlatformGamePresets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlatformGamePresets_GamePresets_PropertyAddress, GetPlatformGamePresets_FunctionAddress, "GamePresets");
		GetPlatformGamePresets_GamePresets_Offset = NativeReflectionCached.GetPropertyOffset(GetPlatformGamePresets_FunctionAddress, "GamePresets");
		GetPlatformGamePresets_GamePresets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlatformGamePresets_FunctionAddress, "GamePresets", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlatformGamePresets_ReturnValue_PropertyAddress, GetPlatformGamePresets_FunctionAddress, "ReturnValue");
		GetPlatformGamePresets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlatformGamePresets_FunctionAddress, "ReturnValue");
		GetPlatformGamePresets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlatformGamePresets_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetPlatformGamePresets_IsValid = GetPlatformGamePresets_FunctionAddress != IntPtr.Zero && GetPlatformGamePresets_GamePresets_IsValid && GetPlatformGamePresets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_GamePresetsFuncLib:GetPlatformGamePresets", GetPlatformGamePresets_IsValid);
	}
}
