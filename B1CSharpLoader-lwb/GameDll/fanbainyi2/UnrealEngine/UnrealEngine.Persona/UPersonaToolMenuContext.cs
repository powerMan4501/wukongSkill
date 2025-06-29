using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UnrealEd;

namespace UnrealEngine.Persona;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Persona.PersonaToolMenuContext", "Persona", UnrealModuleType.Engine)]
public class UPersonaToolMenuContext : UObject
{
	private static bool GetSkeleton_IsValid;

	private static IntPtr GetSkeleton_FunctionAddress;

	private static int GetSkeleton_ParamsSize;

	private static bool GetSkeleton_ReturnValue_IsValid;

	private static FFieldAddress GetSkeleton_ReturnValue_PropertyAddress;

	private static int GetSkeleton_ReturnValue_Offset;

	private static bool GetPreviewMeshComponent_IsValid;

	private static IntPtr GetPreviewMeshComponent_FunctionAddress;

	private static int GetPreviewMeshComponent_ParamsSize;

	private static bool GetPreviewMeshComponent_ReturnValue_IsValid;

	private static FFieldAddress GetPreviewMeshComponent_ReturnValue_PropertyAddress;

	private static int GetPreviewMeshComponent_ReturnValue_Offset;

	private static bool GetMesh_IsValid;

	private static IntPtr GetMesh_FunctionAddress;

	private static int GetMesh_ParamsSize;

	private static bool GetMesh_ReturnValue_IsValid;

	private static FFieldAddress GetMesh_ReturnValue_PropertyAddress;

	private static int GetMesh_ReturnValue_Offset;

	private static bool GetAnimBlueprint_IsValid;

	private static IntPtr GetAnimBlueprint_FunctionAddress;

	private static int GetAnimBlueprint_ParamsSize;

	private static bool GetAnimBlueprint_ReturnValue_IsValid;

	private static FFieldAddress GetAnimBlueprint_ReturnValue_PropertyAddress;

	private static int GetAnimBlueprint_ReturnValue_Offset;

	private static bool GetAnimationAsset_IsValid;

	private static IntPtr GetAnimationAsset_FunctionAddress;

	private static int GetAnimationAsset_ParamsSize;

	private static bool GetAnimationAsset_ReturnValue_IsValid;

	private static FFieldAddress GetAnimationAsset_ReturnValue_PropertyAddress;

	private static int GetAnimationAsset_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Persona.PersonaToolMenuContext:GetSkeleton")]
	public unsafe USkeleton GetSkeleton()
	{
		CheckDestroyed();
		if (!GetSkeleton_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Persona.PersonaToolMenuContext:GetSkeleton");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSkeleton_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSkeleton_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSkeleton_FunctionAddress, intPtr, GetSkeleton_ParamsSize);
		return UObjectMarshaler<USkeleton>.FromNative(IntPtr.Add(intPtr, GetSkeleton_ReturnValue_Offset), 0, GetSkeleton_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Persona.PersonaToolMenuContext:GetPreviewMeshComponent")]
	public unsafe UDebugSkelMeshComponent GetPreviewMeshComponent()
	{
		CheckDestroyed();
		if (!GetPreviewMeshComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Persona.PersonaToolMenuContext:GetPreviewMeshComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPreviewMeshComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPreviewMeshComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPreviewMeshComponent_FunctionAddress, intPtr, GetPreviewMeshComponent_ParamsSize);
		return UObjectMarshaler<UDebugSkelMeshComponent>.FromNative(IntPtr.Add(intPtr, GetPreviewMeshComponent_ReturnValue_Offset), 0, GetPreviewMeshComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Persona.PersonaToolMenuContext:GetMesh")]
	public unsafe USkeletalMesh GetMesh()
	{
		CheckDestroyed();
		if (!GetMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Persona.PersonaToolMenuContext:GetMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMesh_FunctionAddress, intPtr, GetMesh_ParamsSize);
		return UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(intPtr, GetMesh_ReturnValue_Offset), 0, GetMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Persona.PersonaToolMenuContext:GetAnimBlueprint")]
	public unsafe UAnimBlueprint GetAnimBlueprint()
	{
		CheckDestroyed();
		if (!GetAnimBlueprint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Persona.PersonaToolMenuContext:GetAnimBlueprint");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimBlueprint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimBlueprint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAnimBlueprint_FunctionAddress, intPtr, GetAnimBlueprint_ParamsSize);
		return UObjectMarshaler<UAnimBlueprint>.FromNative(IntPtr.Add(intPtr, GetAnimBlueprint_ReturnValue_Offset), 0, GetAnimBlueprint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Persona.PersonaToolMenuContext:GetAnimationAsset")]
	public unsafe UAnimationAsset GetAnimationAsset()
	{
		CheckDestroyed();
		if (!GetAnimationAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Persona.PersonaToolMenuContext:GetAnimationAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAnimationAsset_FunctionAddress, intPtr, GetAnimationAsset_ParamsSize);
		return UObjectMarshaler<UAnimationAsset>.FromNative(IntPtr.Add(intPtr, GetAnimationAsset_ReturnValue_Offset), 0, GetAnimationAsset_ReturnValue_PropertyAddress.Address);
	}

	static UPersonaToolMenuContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPersonaToolMenuContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPersonaToolMenuContext));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Persona.PersonaToolMenuContext");
		GetSkeleton_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSkeleton");
		GetSkeleton_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSkeleton_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSkeleton_ReturnValue_PropertyAddress, GetSkeleton_FunctionAddress, "ReturnValue");
		GetSkeleton_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSkeleton_FunctionAddress, "ReturnValue");
		GetSkeleton_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkeleton_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSkeleton_IsValid = GetSkeleton_FunctionAddress != IntPtr.Zero && GetSkeleton_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Persona.PersonaToolMenuContext:GetSkeleton", GetSkeleton_IsValid);
		GetPreviewMeshComponent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPreviewMeshComponent");
		GetPreviewMeshComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPreviewMeshComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPreviewMeshComponent_ReturnValue_PropertyAddress, GetPreviewMeshComponent_FunctionAddress, "ReturnValue");
		GetPreviewMeshComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviewMeshComponent_FunctionAddress, "ReturnValue");
		GetPreviewMeshComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviewMeshComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPreviewMeshComponent_IsValid = GetPreviewMeshComponent_FunctionAddress != IntPtr.Zero && GetPreviewMeshComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Persona.PersonaToolMenuContext:GetPreviewMeshComponent", GetPreviewMeshComponent_IsValid);
		GetMesh_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetMesh");
		GetMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMesh_ReturnValue_PropertyAddress, GetMesh_FunctionAddress, "ReturnValue");
		GetMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMesh_FunctionAddress, "ReturnValue");
		GetMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetMesh_IsValid = GetMesh_FunctionAddress != IntPtr.Zero && GetMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Persona.PersonaToolMenuContext:GetMesh", GetMesh_IsValid);
		GetAnimBlueprint_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAnimBlueprint");
		GetAnimBlueprint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimBlueprint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimBlueprint_ReturnValue_PropertyAddress, GetAnimBlueprint_FunctionAddress, "ReturnValue");
		GetAnimBlueprint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimBlueprint_FunctionAddress, "ReturnValue");
		GetAnimBlueprint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimBlueprint_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAnimBlueprint_IsValid = GetAnimBlueprint_FunctionAddress != IntPtr.Zero && GetAnimBlueprint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Persona.PersonaToolMenuContext:GetAnimBlueprint", GetAnimBlueprint_IsValid);
		GetAnimationAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAnimationAsset");
		GetAnimationAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationAsset_ReturnValue_PropertyAddress, GetAnimationAsset_FunctionAddress, "ReturnValue");
		GetAnimationAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationAsset_FunctionAddress, "ReturnValue");
		GetAnimationAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAnimationAsset_IsValid = GetAnimationAsset_FunctionAddress != IntPtr.Zero && GetAnimationAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Persona.PersonaToolMenuContext:GetAnimationAsset", GetAnimationAsset_IsValid);
	}
}
