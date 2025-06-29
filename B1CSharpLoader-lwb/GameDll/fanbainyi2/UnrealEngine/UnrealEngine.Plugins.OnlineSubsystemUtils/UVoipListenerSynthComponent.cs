using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AudioMixer;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/OnlineSubsystemUtils.VoipListenerSynthComponent", "OnlineSubsystemUtils", UnrealModuleType.EnginePlugin)]
public class UVoipListenerSynthComponent : USynthComponent
{
	private static bool IsIdling_IsValid;

	private static IntPtr IsIdling_FunctionAddress;

	private static int IsIdling_ParamsSize;

	private static bool IsIdling_ReturnValue_IsValid;

	private static FFieldAddress IsIdling_ReturnValue_PropertyAddress;

	private static int IsIdling_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/OnlineSubsystemUtils.VoipListenerSynthComponent:IsIdling")]
	public unsafe bool IsIdling()
	{
		CheckDestroyed();
		if (!IsIdling_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.VoipListenerSynthComponent:IsIdling");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsIdling_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsIdling_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsIdling_FunctionAddress, intPtr, IsIdling_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsIdling_ReturnValue_Offset), 0, IsIdling_ReturnValue_PropertyAddress.Address);
	}

	static UVoipListenerSynthComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UVoipListenerSynthComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UVoipListenerSynthComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/OnlineSubsystemUtils.VoipListenerSynthComponent");
		IsIdling_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsIdling");
		IsIdling_ParamsSize = NativeReflection.GetFunctionParamsSize(IsIdling_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsIdling_ReturnValue_PropertyAddress, IsIdling_FunctionAddress, "ReturnValue");
		IsIdling_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsIdling_FunctionAddress, "ReturnValue");
		IsIdling_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsIdling_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsIdling_IsValid = IsIdling_FunctionAddress != IntPtr.Zero && IsIdling_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.VoipListenerSynthComponent:IsIdling", IsIdling_IsValid);
	}
}
