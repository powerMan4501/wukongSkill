using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UClass(Flags = (ClassFlags)820510884uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Landscape.LandscapeHeightfieldCollisionComponent", "Landscape", UnrealModuleType.Engine)]
public class ULandscapeHeightfieldCollisionComponent : UPrimitiveComponent
{
	private static bool GetRenderComponent_IsValid;

	private static IntPtr GetRenderComponent_FunctionAddress;

	private static int GetRenderComponent_ParamsSize;

	private static bool GetRenderComponent_ReturnValue_IsValid;

	private static FFieldAddress GetRenderComponent_ReturnValue_PropertyAddress;

	private static int GetRenderComponent_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Landscape.LandscapeHeightfieldCollisionComponent:GetRenderComponent")]
	public unsafe ULandscapeComponent GetRenderComponent()
	{
		CheckDestroyed();
		if (!GetRenderComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Landscape.LandscapeHeightfieldCollisionComponent:GetRenderComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRenderComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRenderComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRenderComponent_FunctionAddress, intPtr, GetRenderComponent_ParamsSize);
		return UObjectMarshaler<ULandscapeComponent>.FromNative(IntPtr.Add(intPtr, GetRenderComponent_ReturnValue_Offset), 0, GetRenderComponent_ReturnValue_PropertyAddress.Address);
	}

	static ULandscapeHeightfieldCollisionComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULandscapeHeightfieldCollisionComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULandscapeHeightfieldCollisionComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Landscape.LandscapeHeightfieldCollisionComponent");
		GetRenderComponent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRenderComponent");
		GetRenderComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRenderComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRenderComponent_ReturnValue_PropertyAddress, GetRenderComponent_FunctionAddress, "ReturnValue");
		GetRenderComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRenderComponent_FunctionAddress, "ReturnValue");
		GetRenderComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRenderComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetRenderComponent_IsValid = GetRenderComponent_FunctionAddress != IntPtr.Zero && GetRenderComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Landscape.LandscapeHeightfieldCollisionComponent:GetRenderComponent", GetRenderComponent_IsValid);
	}
}
