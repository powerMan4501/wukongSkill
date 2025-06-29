using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

[UClass(Flags = (ClassFlags)818938534uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/NavigationSystem.RecastNavMesh", "NavigationSystem", UnrealModuleType.Engine)]
public class ARecastNavMesh : ANavigationData
{
	private static bool ReplaceAreaInTileBounds_IsValid;

	private static IntPtr ReplaceAreaInTileBounds_FunctionAddress;

	private static int ReplaceAreaInTileBounds_ParamsSize;

	private static bool ReplaceAreaInTileBounds_Bounds_IsValid;

	private static FFieldAddress ReplaceAreaInTileBounds_Bounds_PropertyAddress;

	private static int ReplaceAreaInTileBounds_Bounds_Offset;

	private static bool ReplaceAreaInTileBounds_OldArea_IsValid;

	private static FFieldAddress ReplaceAreaInTileBounds_OldArea_PropertyAddress;

	private static int ReplaceAreaInTileBounds_OldArea_Offset;

	private static bool ReplaceAreaInTileBounds_NewArea_IsValid;

	private static FFieldAddress ReplaceAreaInTileBounds_NewArea_PropertyAddress;

	private static int ReplaceAreaInTileBounds_NewArea_Offset;

	private static bool ReplaceAreaInTileBounds_ReplaceLinks_IsValid;

	private static FFieldAddress ReplaceAreaInTileBounds_ReplaceLinks_PropertyAddress;

	private static int ReplaceAreaInTileBounds_ReplaceLinks_Offset;

	private static bool ReplaceAreaInTileBounds_ReturnValue_IsValid;

	private static FFieldAddress ReplaceAreaInTileBounds_ReturnValue_PropertyAddress;

	private static int ReplaceAreaInTileBounds_ReturnValue_Offset;

	[UFunction(Flags = 75629569u, OriginalName = "K2_ReplaceAreaInTileBounds")]
	[UMetaPath("/Script/NavigationSystem.RecastNavMesh:K2_ReplaceAreaInTileBounds")]
	public unsafe bool ReplaceAreaInTileBounds(FBox Bounds, TSubclassOf<UNavArea> OldArea, TSubclassOf<UNavArea> NewArea, bool ReplaceLinks = true)
	{
		CheckDestroyed();
		if (!ReplaceAreaInTileBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.RecastNavMesh:K2_ReplaceAreaInTileBounds");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceAreaInTileBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceAreaInTileBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, ReplaceAreaInTileBounds_Bounds_Offset), 0, ReplaceAreaInTileBounds_Bounds_PropertyAddress.Address, Bounds);
		TSubclassOfMarshaler<UNavArea>.ToNative(IntPtr.Add(intPtr, ReplaceAreaInTileBounds_OldArea_Offset), 0, ReplaceAreaInTileBounds_OldArea_PropertyAddress.Address, OldArea);
		TSubclassOfMarshaler<UNavArea>.ToNative(IntPtr.Add(intPtr, ReplaceAreaInTileBounds_NewArea_Offset), 0, ReplaceAreaInTileBounds_NewArea_PropertyAddress.Address, NewArea);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ReplaceAreaInTileBounds_ReplaceLinks_Offset), 0, ReplaceAreaInTileBounds_ReplaceLinks_PropertyAddress.Address, ReplaceLinks);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReplaceAreaInTileBounds_FunctionAddress, intPtr, ReplaceAreaInTileBounds_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReplaceAreaInTileBounds_ReturnValue_Offset), 0, ReplaceAreaInTileBounds_ReturnValue_PropertyAddress.Address);
	}

	static ARecastNavMesh()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ARecastNavMesh)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ARecastNavMesh));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/NavigationSystem.RecastNavMesh");
		ReplaceAreaInTileBounds_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_ReplaceAreaInTileBounds");
		ReplaceAreaInTileBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceAreaInTileBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAreaInTileBounds_Bounds_PropertyAddress, ReplaceAreaInTileBounds_FunctionAddress, "Bounds");
		ReplaceAreaInTileBounds_Bounds_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAreaInTileBounds_FunctionAddress, "Bounds");
		ReplaceAreaInTileBounds_Bounds_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAreaInTileBounds_FunctionAddress, "Bounds", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAreaInTileBounds_OldArea_PropertyAddress, ReplaceAreaInTileBounds_FunctionAddress, "OldArea");
		ReplaceAreaInTileBounds_OldArea_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAreaInTileBounds_FunctionAddress, "OldArea");
		ReplaceAreaInTileBounds_OldArea_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAreaInTileBounds_FunctionAddress, "OldArea", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAreaInTileBounds_NewArea_PropertyAddress, ReplaceAreaInTileBounds_FunctionAddress, "NewArea");
		ReplaceAreaInTileBounds_NewArea_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAreaInTileBounds_FunctionAddress, "NewArea");
		ReplaceAreaInTileBounds_NewArea_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAreaInTileBounds_FunctionAddress, "NewArea", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAreaInTileBounds_ReplaceLinks_PropertyAddress, ReplaceAreaInTileBounds_FunctionAddress, "ReplaceLinks");
		ReplaceAreaInTileBounds_ReplaceLinks_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAreaInTileBounds_FunctionAddress, "ReplaceLinks");
		ReplaceAreaInTileBounds_ReplaceLinks_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAreaInTileBounds_FunctionAddress, "ReplaceLinks", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAreaInTileBounds_ReturnValue_PropertyAddress, ReplaceAreaInTileBounds_FunctionAddress, "ReturnValue");
		ReplaceAreaInTileBounds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAreaInTileBounds_FunctionAddress, "ReturnValue");
		ReplaceAreaInTileBounds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAreaInTileBounds_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReplaceAreaInTileBounds_IsValid = ReplaceAreaInTileBounds_FunctionAddress != IntPtr.Zero && ReplaceAreaInTileBounds_Bounds_IsValid && ReplaceAreaInTileBounds_OldArea_IsValid && ReplaceAreaInTileBounds_NewArea_IsValid && ReplaceAreaInTileBounds_ReplaceLinks_IsValid && ReplaceAreaInTileBounds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.RecastNavMesh:K2_ReplaceAreaInTileBounds", ReplaceAreaInTileBounds_IsValid);
	}
}
