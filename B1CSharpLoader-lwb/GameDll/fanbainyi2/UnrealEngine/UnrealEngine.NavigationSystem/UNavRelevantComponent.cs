using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/NavigationSystem.NavRelevantComponent", "NavigationSystem", UnrealModuleType.Engine)]
public class UNavRelevantComponent : UActorComponent, INavRelevantInterface, IInterface
{
	private static bool SetNavigationRelevancy_IsValid;

	private static IntPtr SetNavigationRelevancy_FunctionAddress;

	private static int SetNavigationRelevancy_ParamsSize;

	private static bool SetNavigationRelevancy_bRelevant_IsValid;

	private static FFieldAddress SetNavigationRelevancy_bRelevant_PropertyAddress;

	private static int SetNavigationRelevancy_bRelevant_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NavigationSystem.NavRelevantComponent:SetNavigationRelevancy")]
	public unsafe void SetNavigationRelevancy(bool bRelevant)
	{
		CheckDestroyed();
		if (!SetNavigationRelevancy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavRelevantComponent:SetNavigationRelevancy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNavigationRelevancy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNavigationRelevancy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNavigationRelevancy_bRelevant_Offset), 0, SetNavigationRelevancy_bRelevant_PropertyAddress.Address, bRelevant);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNavigationRelevancy_FunctionAddress, intPtr, SetNavigationRelevancy_ParamsSize);
	}

	static UNavRelevantComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNavRelevantComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNavRelevantComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/NavigationSystem.NavRelevantComponent");
		SetNavigationRelevancy_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetNavigationRelevancy");
		SetNavigationRelevancy_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNavigationRelevancy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNavigationRelevancy_bRelevant_PropertyAddress, SetNavigationRelevancy_FunctionAddress, "bRelevant");
		SetNavigationRelevancy_bRelevant_Offset = NativeReflectionCached.GetPropertyOffset(SetNavigationRelevancy_FunctionAddress, "bRelevant");
		SetNavigationRelevancy_bRelevant_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNavigationRelevancy_FunctionAddress, "bRelevant", Classes.FBoolProperty);
		SetNavigationRelevancy_IsValid = SetNavigationRelevancy_FunctionAddress != IntPtr.Zero && SetNavigationRelevancy_bRelevant_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavRelevantComponent:SetNavigationRelevancy", SetNavigationRelevancy_IsValid);
	}
}
