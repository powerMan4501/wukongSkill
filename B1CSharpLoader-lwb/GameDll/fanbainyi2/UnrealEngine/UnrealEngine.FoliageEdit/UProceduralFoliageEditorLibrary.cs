using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Foliage;
using UnrealEngine.Runtime;

namespace UnrealEngine.FoliageEdit;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/FoliageEdit.ProceduralFoliageEditorLibrary", "FoliageEdit", UnrealModuleType.Engine)]
public class UProceduralFoliageEditorLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ResimulateProceduralFoliageVolumes_IsValid;

	private static IntPtr ResimulateProceduralFoliageVolumes_FunctionAddress;

	private static int ResimulateProceduralFoliageVolumes_ParamsSize;

	private static bool ResimulateProceduralFoliageVolumes_ProceduralFoliageVolumes_IsValid;

	private static FFieldAddress ResimulateProceduralFoliageVolumes_ProceduralFoliageVolumes_PropertyAddress;

	private static int ResimulateProceduralFoliageVolumes_ProceduralFoliageVolumes_Offset;

	private static bool ResimulateProceduralFoliageComponents_IsValid;

	private static IntPtr ResimulateProceduralFoliageComponents_FunctionAddress;

	private static int ResimulateProceduralFoliageComponents_ParamsSize;

	private static bool ResimulateProceduralFoliageComponents_ProceduralFoliageComponents_IsValid;

	private static FFieldAddress ResimulateProceduralFoliageComponents_ProceduralFoliageComponents_PropertyAddress;

	private static int ResimulateProceduralFoliageComponents_ProceduralFoliageComponents_Offset;

	private static bool ClearProceduralFoliageVolumes_IsValid;

	private static IntPtr ClearProceduralFoliageVolumes_FunctionAddress;

	private static int ClearProceduralFoliageVolumes_ParamsSize;

	private static bool ClearProceduralFoliageVolumes_ProceduralFoliageVolumes_IsValid;

	private static FFieldAddress ClearProceduralFoliageVolumes_ProceduralFoliageVolumes_PropertyAddress;

	private static int ClearProceduralFoliageVolumes_ProceduralFoliageVolumes_Offset;

	private static bool ClearProceduralFoliageComponents_IsValid;

	private static IntPtr ClearProceduralFoliageComponents_FunctionAddress;

	private static int ClearProceduralFoliageComponents_ParamsSize;

	private static bool ClearProceduralFoliageComponents_ProceduralFoliageComponents_IsValid;

	private static FFieldAddress ClearProceduralFoliageComponents_ProceduralFoliageComponents_PropertyAddress;

	private static int ClearProceduralFoliageComponents_ProceduralFoliageComponents_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FoliageEdit.ProceduralFoliageEditorLibrary:ResimulateProceduralFoliageVolumes")]
	public unsafe static void ResimulateProceduralFoliageVolumes(List<AProceduralFoliageVolume> ProceduralFoliageVolumes)
	{
		if (!ResimulateProceduralFoliageVolumes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FoliageEdit.ProceduralFoliageEditorLibrary:ResimulateProceduralFoliageVolumes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResimulateProceduralFoliageVolumes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResimulateProceduralFoliageVolumes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AProceduralFoliageVolume>(1, ResimulateProceduralFoliageVolumes_ProceduralFoliageVolumes_PropertyAddress, CachedMarshalingDelegates<AProceduralFoliageVolume, UObjectMarshaler<AProceduralFoliageVolume>>.FromNative, CachedMarshalingDelegates<AProceduralFoliageVolume, UObjectMarshaler<AProceduralFoliageVolume>>.ToNative).ToNative(IntPtr.Add(intPtr, ResimulateProceduralFoliageVolumes_ProceduralFoliageVolumes_Offset), ProceduralFoliageVolumes);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResimulateProceduralFoliageVolumes_FunctionAddress, intPtr, ResimulateProceduralFoliageVolumes_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ResimulateProceduralFoliageVolumes_ProceduralFoliageVolumes_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FoliageEdit.ProceduralFoliageEditorLibrary:ResimulateProceduralFoliageComponents")]
	public unsafe static void ResimulateProceduralFoliageComponents(List<UProceduralFoliageComponent> ProceduralFoliageComponents)
	{
		if (!ResimulateProceduralFoliageComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FoliageEdit.ProceduralFoliageEditorLibrary:ResimulateProceduralFoliageComponents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResimulateProceduralFoliageComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResimulateProceduralFoliageComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UProceduralFoliageComponent>(1, ResimulateProceduralFoliageComponents_ProceduralFoliageComponents_PropertyAddress, CachedMarshalingDelegates<UProceduralFoliageComponent, UObjectMarshaler<UProceduralFoliageComponent>>.FromNative, CachedMarshalingDelegates<UProceduralFoliageComponent, UObjectMarshaler<UProceduralFoliageComponent>>.ToNative).ToNative(IntPtr.Add(intPtr, ResimulateProceduralFoliageComponents_ProceduralFoliageComponents_Offset), ProceduralFoliageComponents);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResimulateProceduralFoliageComponents_FunctionAddress, intPtr, ResimulateProceduralFoliageComponents_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ResimulateProceduralFoliageComponents_ProceduralFoliageComponents_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FoliageEdit.ProceduralFoliageEditorLibrary:ClearProceduralFoliageVolumes")]
	public unsafe static void ClearProceduralFoliageVolumes(List<AProceduralFoliageVolume> ProceduralFoliageVolumes)
	{
		if (!ClearProceduralFoliageVolumes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FoliageEdit.ProceduralFoliageEditorLibrary:ClearProceduralFoliageVolumes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearProceduralFoliageVolumes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearProceduralFoliageVolumes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AProceduralFoliageVolume>(1, ClearProceduralFoliageVolumes_ProceduralFoliageVolumes_PropertyAddress, CachedMarshalingDelegates<AProceduralFoliageVolume, UObjectMarshaler<AProceduralFoliageVolume>>.FromNative, CachedMarshalingDelegates<AProceduralFoliageVolume, UObjectMarshaler<AProceduralFoliageVolume>>.ToNative).ToNative(IntPtr.Add(intPtr, ClearProceduralFoliageVolumes_ProceduralFoliageVolumes_Offset), ProceduralFoliageVolumes);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearProceduralFoliageVolumes_FunctionAddress, intPtr, ClearProceduralFoliageVolumes_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ClearProceduralFoliageVolumes_ProceduralFoliageVolumes_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FoliageEdit.ProceduralFoliageEditorLibrary:ClearProceduralFoliageComponents")]
	public unsafe static void ClearProceduralFoliageComponents(List<UProceduralFoliageComponent> ProceduralFoliageComponents)
	{
		if (!ClearProceduralFoliageComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FoliageEdit.ProceduralFoliageEditorLibrary:ClearProceduralFoliageComponents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearProceduralFoliageComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearProceduralFoliageComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UProceduralFoliageComponent>(1, ClearProceduralFoliageComponents_ProceduralFoliageComponents_PropertyAddress, CachedMarshalingDelegates<UProceduralFoliageComponent, UObjectMarshaler<UProceduralFoliageComponent>>.FromNative, CachedMarshalingDelegates<UProceduralFoliageComponent, UObjectMarshaler<UProceduralFoliageComponent>>.ToNative).ToNative(IntPtr.Add(intPtr, ClearProceduralFoliageComponents_ProceduralFoliageComponents_Offset), ProceduralFoliageComponents);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearProceduralFoliageComponents_FunctionAddress, intPtr, ClearProceduralFoliageComponents_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ClearProceduralFoliageComponents_ProceduralFoliageComponents_PropertyAddress.Address, intPtr);
	}

	static UProceduralFoliageEditorLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UProceduralFoliageEditorLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UProceduralFoliageEditorLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FoliageEdit.ProceduralFoliageEditorLibrary");
		ResimulateProceduralFoliageVolumes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResimulateProceduralFoliageVolumes");
		ResimulateProceduralFoliageVolumes_ParamsSize = NativeReflection.GetFunctionParamsSize(ResimulateProceduralFoliageVolumes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResimulateProceduralFoliageVolumes_ProceduralFoliageVolumes_PropertyAddress, ResimulateProceduralFoliageVolumes_FunctionAddress, "ProceduralFoliageVolumes");
		ResimulateProceduralFoliageVolumes_ProceduralFoliageVolumes_Offset = NativeReflectionCached.GetPropertyOffset(ResimulateProceduralFoliageVolumes_FunctionAddress, "ProceduralFoliageVolumes");
		ResimulateProceduralFoliageVolumes_ProceduralFoliageVolumes_IsValid = NativeReflectionCached.ValidatePropertyClass(ResimulateProceduralFoliageVolumes_FunctionAddress, "ProceduralFoliageVolumes", Classes.FArrayProperty);
		ResimulateProceduralFoliageVolumes_IsValid = ResimulateProceduralFoliageVolumes_FunctionAddress != IntPtr.Zero && ResimulateProceduralFoliageVolumes_ProceduralFoliageVolumes_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FoliageEdit.ProceduralFoliageEditorLibrary:ResimulateProceduralFoliageVolumes", ResimulateProceduralFoliageVolumes_IsValid);
		ResimulateProceduralFoliageComponents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResimulateProceduralFoliageComponents");
		ResimulateProceduralFoliageComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(ResimulateProceduralFoliageComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResimulateProceduralFoliageComponents_ProceduralFoliageComponents_PropertyAddress, ResimulateProceduralFoliageComponents_FunctionAddress, "ProceduralFoliageComponents");
		ResimulateProceduralFoliageComponents_ProceduralFoliageComponents_Offset = NativeReflectionCached.GetPropertyOffset(ResimulateProceduralFoliageComponents_FunctionAddress, "ProceduralFoliageComponents");
		ResimulateProceduralFoliageComponents_ProceduralFoliageComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(ResimulateProceduralFoliageComponents_FunctionAddress, "ProceduralFoliageComponents", Classes.FArrayProperty);
		ResimulateProceduralFoliageComponents_IsValid = ResimulateProceduralFoliageComponents_FunctionAddress != IntPtr.Zero && ResimulateProceduralFoliageComponents_ProceduralFoliageComponents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FoliageEdit.ProceduralFoliageEditorLibrary:ResimulateProceduralFoliageComponents", ResimulateProceduralFoliageComponents_IsValid);
		ClearProceduralFoliageVolumes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearProceduralFoliageVolumes");
		ClearProceduralFoliageVolumes_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearProceduralFoliageVolumes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearProceduralFoliageVolumes_ProceduralFoliageVolumes_PropertyAddress, ClearProceduralFoliageVolumes_FunctionAddress, "ProceduralFoliageVolumes");
		ClearProceduralFoliageVolumes_ProceduralFoliageVolumes_Offset = NativeReflectionCached.GetPropertyOffset(ClearProceduralFoliageVolumes_FunctionAddress, "ProceduralFoliageVolumes");
		ClearProceduralFoliageVolumes_ProceduralFoliageVolumes_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearProceduralFoliageVolumes_FunctionAddress, "ProceduralFoliageVolumes", Classes.FArrayProperty);
		ClearProceduralFoliageVolumes_IsValid = ClearProceduralFoliageVolumes_FunctionAddress != IntPtr.Zero && ClearProceduralFoliageVolumes_ProceduralFoliageVolumes_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FoliageEdit.ProceduralFoliageEditorLibrary:ClearProceduralFoliageVolumes", ClearProceduralFoliageVolumes_IsValid);
		ClearProceduralFoliageComponents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearProceduralFoliageComponents");
		ClearProceduralFoliageComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearProceduralFoliageComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearProceduralFoliageComponents_ProceduralFoliageComponents_PropertyAddress, ClearProceduralFoliageComponents_FunctionAddress, "ProceduralFoliageComponents");
		ClearProceduralFoliageComponents_ProceduralFoliageComponents_Offset = NativeReflectionCached.GetPropertyOffset(ClearProceduralFoliageComponents_FunctionAddress, "ProceduralFoliageComponents");
		ClearProceduralFoliageComponents_ProceduralFoliageComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearProceduralFoliageComponents_FunctionAddress, "ProceduralFoliageComponents", Classes.FArrayProperty);
		ClearProceduralFoliageComponents_IsValid = ClearProceduralFoliageComponents_FunctionAddress != IntPtr.Zero && ClearProceduralFoliageComponents_ProceduralFoliageComponents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FoliageEdit.ProceduralFoliageEditorLibrary:ClearProceduralFoliageComponents", ClearProceduralFoliageComponents_IsValid);
	}
}
