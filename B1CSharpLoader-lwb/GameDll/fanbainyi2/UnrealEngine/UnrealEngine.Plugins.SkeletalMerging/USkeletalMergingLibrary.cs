using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SkeletalMerging;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/SkeletalMerging.SkeletalMergingLibrary", "SkeletalMerging", UnrealModuleType.EnginePlugin)]
public class USkeletalMergingLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool MergeSkeletons_IsValid;

	private static IntPtr MergeSkeletons_FunctionAddress;

	private static int MergeSkeletons_ParamsSize;

	private static bool MergeSkeletons_Params_IsValid;

	private static FFieldAddress MergeSkeletons_Params_PropertyAddress;

	private static int MergeSkeletons_Params_Offset;

	private static bool MergeSkeletons_ReturnValue_IsValid;

	private static FFieldAddress MergeSkeletons_ReturnValue_PropertyAddress;

	private static int MergeSkeletons_ReturnValue_Offset;

	private static bool MergeMeshes_IsValid;

	private static IntPtr MergeMeshes_FunctionAddress;

	private static int MergeMeshes_ParamsSize;

	private static bool MergeMeshes_Params_IsValid;

	private static FFieldAddress MergeMeshes_Params_PropertyAddress;

	private static int MergeMeshes_Params_Offset;

	private static bool MergeMeshes_ReturnValue_IsValid;

	private static FFieldAddress MergeMeshes_ReturnValue_PropertyAddress;

	private static int MergeMeshes_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SkeletalMerging.SkeletalMergingLibrary:MergeSkeletons")]
	public unsafe static USkeleton MergeSkeletons(FSkeletonMergeParams Params)
	{
		if (!MergeSkeletons_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SkeletalMerging.SkeletalMergingLibrary:MergeSkeletons");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MergeSkeletons_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MergeSkeletons_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MergeSkeletons_Params_PropertyAddress.Address, intPtr);
		FSkeletonMergeParams.ToNative(IntPtr.Add(intPtr, MergeSkeletons_Params_Offset), 0, MergeSkeletons_Params_PropertyAddress.Address, Params);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MergeSkeletons_FunctionAddress, intPtr, MergeSkeletons_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MergeSkeletons_Params_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<USkeleton>.FromNative(IntPtr.Add(intPtr, MergeSkeletons_ReturnValue_Offset), 0, MergeSkeletons_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SkeletalMerging.SkeletalMergingLibrary:MergeMeshes")]
	public unsafe static USkeletalMesh MergeMeshes(FSkeletalMeshMergeParams Params)
	{
		if (!MergeMeshes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SkeletalMerging.SkeletalMergingLibrary:MergeMeshes");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MergeMeshes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MergeMeshes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MergeMeshes_Params_PropertyAddress.Address, intPtr);
		FSkeletalMeshMergeParams.ToNative(IntPtr.Add(intPtr, MergeMeshes_Params_Offset), 0, MergeMeshes_Params_PropertyAddress.Address, Params);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MergeMeshes_FunctionAddress, intPtr, MergeMeshes_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MergeMeshes_Params_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(intPtr, MergeMeshes_ReturnValue_Offset), 0, MergeMeshes_ReturnValue_PropertyAddress.Address);
	}

	static USkeletalMergingLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USkeletalMergingLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USkeletalMergingLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/SkeletalMerging.SkeletalMergingLibrary");
		MergeSkeletons_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MergeSkeletons");
		MergeSkeletons_ParamsSize = NativeReflection.GetFunctionParamsSize(MergeSkeletons_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MergeSkeletons_Params_PropertyAddress, MergeSkeletons_FunctionAddress, "Params");
		MergeSkeletons_Params_Offset = NativeReflectionCached.GetPropertyOffset(MergeSkeletons_FunctionAddress, "Params");
		MergeSkeletons_Params_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeSkeletons_FunctionAddress, "Params", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeSkeletons_ReturnValue_PropertyAddress, MergeSkeletons_FunctionAddress, "ReturnValue");
		MergeSkeletons_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MergeSkeletons_FunctionAddress, "ReturnValue");
		MergeSkeletons_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeSkeletons_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		MergeSkeletons_IsValid = MergeSkeletons_FunctionAddress != IntPtr.Zero && MergeSkeletons_Params_IsValid && MergeSkeletons_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SkeletalMerging.SkeletalMergingLibrary:MergeSkeletons", MergeSkeletons_IsValid);
		MergeMeshes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MergeMeshes");
		MergeMeshes_ParamsSize = NativeReflection.GetFunctionParamsSize(MergeMeshes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MergeMeshes_Params_PropertyAddress, MergeMeshes_FunctionAddress, "Params");
		MergeMeshes_Params_Offset = NativeReflectionCached.GetPropertyOffset(MergeMeshes_FunctionAddress, "Params");
		MergeMeshes_Params_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeMeshes_FunctionAddress, "Params", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeMeshes_ReturnValue_PropertyAddress, MergeMeshes_FunctionAddress, "ReturnValue");
		MergeMeshes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MergeMeshes_FunctionAddress, "ReturnValue");
		MergeMeshes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeMeshes_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		MergeMeshes_IsValid = MergeMeshes_FunctionAddress != IntPtr.Zero && MergeMeshes_Params_IsValid && MergeMeshes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SkeletalMerging.SkeletalMergingLibrary:MergeMeshes", MergeMeshes_IsValid);
	}
}
