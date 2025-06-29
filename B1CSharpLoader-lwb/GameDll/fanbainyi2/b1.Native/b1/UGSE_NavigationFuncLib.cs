using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_NavigationFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_NavigationFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetCollisionNavDynamicObstacle_IsValid;

	private static IntPtr SetCollisionNavDynamicObstacle_FunctionAddress;

	private static int SetCollisionNavDynamicObstacle_ParamsSize;

	private static bool SetCollisionNavDynamicObstacle_Collision_IsValid;

	private static FFieldAddress SetCollisionNavDynamicObstacle_Collision_PropertyAddress;

	private static int SetCollisionNavDynamicObstacle_Collision_Offset;

	private static bool SetCollisionNavDynamicObstacle_bDynamicObstacle_IsValid;

	private static FFieldAddress SetCollisionNavDynamicObstacle_bDynamicObstacle_PropertyAddress;

	private static int SetCollisionNavDynamicObstacle_bDynamicObstacle_Offset;

	private static bool SetCollisionNavAreaClass_IsValid;

	private static IntPtr SetCollisionNavAreaClass_FunctionAddress;

	private static int SetCollisionNavAreaClass_ParamsSize;

	private static bool SetCollisionNavAreaClass_Collision_IsValid;

	private static FFieldAddress SetCollisionNavAreaClass_Collision_PropertyAddress;

	private static int SetCollisionNavAreaClass_Collision_Offset;

	private static bool SetCollisionNavAreaClass_AreaClass_IsValid;

	private static FFieldAddress SetCollisionNavAreaClass_AreaClass_PropertyAddress;

	private static int SetCollisionNavAreaClass_AreaClass_Offset;

	private static bool ModifyCanEverAffectNavigation_IsValid;

	private static IntPtr ModifyCanEverAffectNavigation_FunctionAddress;

	private static int ModifyCanEverAffectNavigation_ParamsSize;

	private static bool ModifyCanEverAffectNavigation_TargetActors_IsValid;

	private static FFieldAddress ModifyCanEverAffectNavigation_TargetActors_PropertyAddress;

	private static int ModifyCanEverAffectNavigation_TargetActors_Offset;

	private static bool ModifyCanEverAffectNavigation_isEnable_IsValid;

	private static FFieldAddress ModifyCanEverAffectNavigation_isEnable_PropertyAddress;

	private static int ModifyCanEverAffectNavigation_isEnable_Offset;

	private static bool FindAndTagAllUnaffectNavActors_IsValid;

	private static IntPtr FindAndTagAllUnaffectNavActors_FunctionAddress;

	private static int FindAndTagAllUnaffectNavActors_ParamsSize;

	private static bool FindAndTagAllUnaffectNavActors_ReturnValue_IsValid;

	private static FFieldAddress FindAndTagAllUnaffectNavActors_ReturnValue_PropertyAddress;

	private static int FindAndTagAllUnaffectNavActors_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_NavigationFuncLib:SetCollisionNavDynamicObstacle")]
	public unsafe static void SetCollisionNavDynamicObstacle(UShapeComponent Collision, bool bDynamicObstacle)
	{
		if (!SetCollisionNavDynamicObstacle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_NavigationFuncLib:SetCollisionNavDynamicObstacle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionNavDynamicObstacle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionNavDynamicObstacle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UShapeComponent>.ToNative(IntPtr.Add(intPtr, SetCollisionNavDynamicObstacle_Collision_Offset), 0, SetCollisionNavDynamicObstacle_Collision_PropertyAddress.Address, Collision);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCollisionNavDynamicObstacle_bDynamicObstacle_Offset), 0, SetCollisionNavDynamicObstacle_bDynamicObstacle_PropertyAddress.Address, bDynamicObstacle);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCollisionNavDynamicObstacle_FunctionAddress, intPtr, SetCollisionNavDynamicObstacle_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_NavigationFuncLib:SetCollisionNavAreaClass")]
	public unsafe static void SetCollisionNavAreaClass(UShapeComponent Collision, TSubclassOf<UNavAreaBase> AreaClass)
	{
		if (!SetCollisionNavAreaClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_NavigationFuncLib:SetCollisionNavAreaClass");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCollisionNavAreaClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCollisionNavAreaClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UShapeComponent>.ToNative(IntPtr.Add(intPtr, SetCollisionNavAreaClass_Collision_Offset), 0, SetCollisionNavAreaClass_Collision_PropertyAddress.Address, Collision);
		TSubclassOfMarshaler<UNavAreaBase>.ToNative(IntPtr.Add(intPtr, SetCollisionNavAreaClass_AreaClass_Offset), 0, SetCollisionNavAreaClass_AreaClass_PropertyAddress.Address, AreaClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCollisionNavAreaClass_FunctionAddress, intPtr, SetCollisionNavAreaClass_ParamsSize);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/UnrealExtent.GSE_NavigationFuncLib:ModifyCanEverAffectNavigation")]
	public unsafe static void ModifyCanEverAffectNavigation(List<AActor> TargetActors, bool isEnable)
	{
		if (!ModifyCanEverAffectNavigation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_NavigationFuncLib:ModifyCanEverAffectNavigation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ModifyCanEverAffectNavigation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ModifyCanEverAffectNavigation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, ModifyCanEverAffectNavigation_TargetActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, ModifyCanEverAffectNavigation_TargetActors_Offset), TargetActors);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ModifyCanEverAffectNavigation_isEnable_Offset), 0, ModifyCanEverAffectNavigation_isEnable_PropertyAddress.Address, isEnable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ModifyCanEverAffectNavigation_FunctionAddress, intPtr, ModifyCanEverAffectNavigation_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ModifyCanEverAffectNavigation_TargetActors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_NavigationFuncLib:FindAndTagAllUnaffectNavActors")]
	public unsafe static List<AActor> FindAndTagAllUnaffectNavActors()
	{
		if (!FindAndTagAllUnaffectNavActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_NavigationFuncLib:FindAndTagAllUnaffectNavActors");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindAndTagAllUnaffectNavActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindAndTagAllUnaffectNavActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindAndTagAllUnaffectNavActors_FunctionAddress, intPtr, FindAndTagAllUnaffectNavActors_ParamsSize);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, FindAndTagAllUnaffectNavActors_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, FindAndTagAllUnaffectNavActors_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FindAndTagAllUnaffectNavActors_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UGSE_NavigationFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_NavigationFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_NavigationFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_NavigationFuncLib");
		SetCollisionNavDynamicObstacle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCollisionNavDynamicObstacle");
		SetCollisionNavDynamicObstacle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionNavDynamicObstacle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionNavDynamicObstacle_Collision_PropertyAddress, SetCollisionNavDynamicObstacle_FunctionAddress, "Collision");
		SetCollisionNavDynamicObstacle_Collision_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionNavDynamicObstacle_FunctionAddress, "Collision");
		SetCollisionNavDynamicObstacle_Collision_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionNavDynamicObstacle_FunctionAddress, "Collision", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionNavDynamicObstacle_bDynamicObstacle_PropertyAddress, SetCollisionNavDynamicObstacle_FunctionAddress, "bDynamicObstacle");
		SetCollisionNavDynamicObstacle_bDynamicObstacle_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionNavDynamicObstacle_FunctionAddress, "bDynamicObstacle");
		SetCollisionNavDynamicObstacle_bDynamicObstacle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionNavDynamicObstacle_FunctionAddress, "bDynamicObstacle", Classes.FBoolProperty);
		SetCollisionNavDynamicObstacle_IsValid = SetCollisionNavDynamicObstacle_FunctionAddress != IntPtr.Zero && SetCollisionNavDynamicObstacle_Collision_IsValid && SetCollisionNavDynamicObstacle_bDynamicObstacle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_NavigationFuncLib:SetCollisionNavDynamicObstacle", SetCollisionNavDynamicObstacle_IsValid);
		SetCollisionNavAreaClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCollisionNavAreaClass");
		SetCollisionNavAreaClass_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCollisionNavAreaClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionNavAreaClass_Collision_PropertyAddress, SetCollisionNavAreaClass_FunctionAddress, "Collision");
		SetCollisionNavAreaClass_Collision_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionNavAreaClass_FunctionAddress, "Collision");
		SetCollisionNavAreaClass_Collision_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionNavAreaClass_FunctionAddress, "Collision", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCollisionNavAreaClass_AreaClass_PropertyAddress, SetCollisionNavAreaClass_FunctionAddress, "AreaClass");
		SetCollisionNavAreaClass_AreaClass_Offset = NativeReflectionCached.GetPropertyOffset(SetCollisionNavAreaClass_FunctionAddress, "AreaClass");
		SetCollisionNavAreaClass_AreaClass_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCollisionNavAreaClass_FunctionAddress, "AreaClass", Classes.FClassProperty);
		SetCollisionNavAreaClass_IsValid = SetCollisionNavAreaClass_FunctionAddress != IntPtr.Zero && SetCollisionNavAreaClass_Collision_IsValid && SetCollisionNavAreaClass_AreaClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_NavigationFuncLib:SetCollisionNavAreaClass", SetCollisionNavAreaClass_IsValid);
		ModifyCanEverAffectNavigation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ModifyCanEverAffectNavigation");
		ModifyCanEverAffectNavigation_ParamsSize = NativeReflection.GetFunctionParamsSize(ModifyCanEverAffectNavigation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ModifyCanEverAffectNavigation_TargetActors_PropertyAddress, ModifyCanEverAffectNavigation_FunctionAddress, "TargetActors");
		ModifyCanEverAffectNavigation_TargetActors_Offset = NativeReflectionCached.GetPropertyOffset(ModifyCanEverAffectNavigation_FunctionAddress, "TargetActors");
		ModifyCanEverAffectNavigation_TargetActors_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyCanEverAffectNavigation_FunctionAddress, "TargetActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyCanEverAffectNavigation_isEnable_PropertyAddress, ModifyCanEverAffectNavigation_FunctionAddress, "isEnable");
		ModifyCanEverAffectNavigation_isEnable_Offset = NativeReflectionCached.GetPropertyOffset(ModifyCanEverAffectNavigation_FunctionAddress, "isEnable");
		ModifyCanEverAffectNavigation_isEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyCanEverAffectNavigation_FunctionAddress, "isEnable", Classes.FBoolProperty);
		ModifyCanEverAffectNavigation_IsValid = ModifyCanEverAffectNavigation_FunctionAddress != IntPtr.Zero && ModifyCanEverAffectNavigation_TargetActors_IsValid && ModifyCanEverAffectNavigation_isEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_NavigationFuncLib:ModifyCanEverAffectNavigation", ModifyCanEverAffectNavigation_IsValid);
		FindAndTagAllUnaffectNavActors_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindAndTagAllUnaffectNavActors");
		FindAndTagAllUnaffectNavActors_ParamsSize = NativeReflection.GetFunctionParamsSize(FindAndTagAllUnaffectNavActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindAndTagAllUnaffectNavActors_ReturnValue_PropertyAddress, FindAndTagAllUnaffectNavActors_FunctionAddress, "ReturnValue");
		FindAndTagAllUnaffectNavActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindAndTagAllUnaffectNavActors_FunctionAddress, "ReturnValue");
		FindAndTagAllUnaffectNavActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindAndTagAllUnaffectNavActors_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FindAndTagAllUnaffectNavActors_IsValid = FindAndTagAllUnaffectNavActors_FunctionAddress != IntPtr.Zero && FindAndTagAllUnaffectNavActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_NavigationFuncLib:FindAndTagAllUnaffectNavActors", FindAndTagAllUnaffectNavActors_IsValid);
	}
}
