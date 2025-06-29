using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.EditorSubsystem;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.CinematicPrestreamingEditor;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/CinematicPrestreamingEditor.CinePrestreamingEditorSubsystem", "CinematicPrestreamingEditor", UnrealModuleType.EnginePlugin)]
public class UCinePrestreamingEditorSubsystem : UEditorSubsystem
{
	private static bool OnAssetGenerated_IsValid;

	private static int OnAssetGenerated_Offset;

	private FOnCinePrestreamingGenerateAsset OnAssetGenerated_DelegateCached;

	private static bool IsRendering_IsValid;

	private static IntPtr IsRendering_FunctionAddress;

	private static int IsRendering_ParamsSize;

	private static bool IsRendering_ReturnValue_IsValid;

	private static FFieldAddress IsRendering_ReturnValue_PropertyAddress;

	private static int IsRendering_ReturnValue_Offset;

	private static bool GeneratePrestreamingAsset_IsValid;

	private static IntPtr GeneratePrestreamingAsset_FunctionAddress;

	private static int GeneratePrestreamingAsset_ParamsSize;

	private static bool GeneratePrestreamingAsset_InArgs_IsValid;

	private static FFieldAddress GeneratePrestreamingAsset_InArgs_PropertyAddress;

	private static int GeneratePrestreamingAsset_InArgs_Offset;

	private static bool CreatePackagesFromGeneratedData_IsValid;

	private static IntPtr CreatePackagesFromGeneratedData_FunctionAddress;

	private static int CreatePackagesFromGeneratedData_ParamsSize;

	private static bool CreatePackagesFromGeneratedData_InOutData_IsValid;

	private static FFieldAddress CreatePackagesFromGeneratedData_InOutData_PropertyAddress;

	private static int CreatePackagesFromGeneratedData_InOutData_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.CinePrestreamingEditorSubsystem:OnAssetGenerated")]
	public FOnCinePrestreamingGenerateAsset OnAssetGenerated
	{
		get
		{
			CheckDestroyed();
			if (!OnAssetGenerated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingEditorSubsystem:OnAssetGenerated");
				return new FOnCinePrestreamingGenerateAsset();
			}
			if (OnAssetGenerated_DelegateCached == null)
			{
				OnAssetGenerated_DelegateCached = new FOnCinePrestreamingGenerateAsset();
				OnAssetGenerated_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnAssetGenerated_Offset));
			}
			return OnAssetGenerated_DelegateCached;
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.CinePrestreamingEditorSubsystem:IsRendering")]
	public unsafe bool IsRendering()
	{
		CheckDestroyed();
		if (!IsRendering_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingEditorSubsystem:IsRendering");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsRendering_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsRendering_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsRendering_FunctionAddress, intPtr, IsRendering_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsRendering_ReturnValue_Offset), 0, IsRendering_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.CinePrestreamingEditorSubsystem:GeneratePrestreamingAsset")]
	public unsafe void GeneratePrestreamingAsset(FCinePrestreamingGenerateAssetArgs InArgs)
	{
		CheckDestroyed();
		if (!GeneratePrestreamingAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingEditorSubsystem:GeneratePrestreamingAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GeneratePrestreamingAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GeneratePrestreamingAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GeneratePrestreamingAsset_InArgs_PropertyAddress.Address, intPtr);
		FCinePrestreamingGenerateAssetArgs.ToNative(IntPtr.Add(intPtr, GeneratePrestreamingAsset_InArgs_Offset), 0, GeneratePrestreamingAsset_InArgs_PropertyAddress.Address, InArgs);
		NativeReflection.InvokeFunctionOptimized(base.Address, GeneratePrestreamingAsset_FunctionAddress, intPtr, GeneratePrestreamingAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GeneratePrestreamingAsset_InArgs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.CinePrestreamingEditorSubsystem:CreatePackagesFromGeneratedData")]
	public unsafe void CreatePackagesFromGeneratedData(out List<FMoviePipelineCinePrestreamingGeneratedData> InOutData)
	{
		CheckDestroyed();
		if (!CreatePackagesFromGeneratedData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CinematicPrestreamingEditor.CinePrestreamingEditorSubsystem:CreatePackagesFromGeneratedData");
			InOutData = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreatePackagesFromGeneratedData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreatePackagesFromGeneratedData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreatePackagesFromGeneratedData_FunctionAddress, intPtr, CreatePackagesFromGeneratedData_ParamsSize);
		InOutData = new TArrayCopyMarshaler<FMoviePipelineCinePrestreamingGeneratedData>(1, CreatePackagesFromGeneratedData_InOutData_PropertyAddress, CachedMarshalingDelegates<FMoviePipelineCinePrestreamingGeneratedData, FMoviePipelineCinePrestreamingGeneratedData>.FromNative, CachedMarshalingDelegates<FMoviePipelineCinePrestreamingGeneratedData, FMoviePipelineCinePrestreamingGeneratedData>.ToNative).FromNative(IntPtr.Add(intPtr, CreatePackagesFromGeneratedData_InOutData_Offset));
		NativeReflection.DestroyValue_InContainer(CreatePackagesFromGeneratedData_InOutData_PropertyAddress.Address, intPtr);
	}

	static UCinePrestreamingEditorSubsystem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCinePrestreamingEditorSubsystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCinePrestreamingEditorSubsystem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/CinematicPrestreamingEditor.CinePrestreamingEditorSubsystem");
		OnAssetGenerated_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnAssetGenerated");
		OnAssetGenerated_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnAssetGenerated", Classes.FMulticastDelegateProperty);
		IsRendering_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsRendering");
		IsRendering_ParamsSize = NativeReflection.GetFunctionParamsSize(IsRendering_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsRendering_ReturnValue_PropertyAddress, IsRendering_FunctionAddress, "ReturnValue");
		IsRendering_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsRendering_FunctionAddress, "ReturnValue");
		IsRendering_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsRendering_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsRendering_IsValid = IsRendering_FunctionAddress != IntPtr.Zero && IsRendering_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicPrestreamingEditor.CinePrestreamingEditorSubsystem:IsRendering", IsRendering_IsValid);
		GeneratePrestreamingAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GeneratePrestreamingAsset");
		GeneratePrestreamingAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GeneratePrestreamingAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GeneratePrestreamingAsset_InArgs_PropertyAddress, GeneratePrestreamingAsset_FunctionAddress, "InArgs");
		GeneratePrestreamingAsset_InArgs_Offset = NativeReflectionCached.GetPropertyOffset(GeneratePrestreamingAsset_FunctionAddress, "InArgs");
		GeneratePrestreamingAsset_InArgs_IsValid = NativeReflectionCached.ValidatePropertyClass(GeneratePrestreamingAsset_FunctionAddress, "InArgs", Classes.FStructProperty);
		GeneratePrestreamingAsset_IsValid = GeneratePrestreamingAsset_FunctionAddress != IntPtr.Zero && GeneratePrestreamingAsset_InArgs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicPrestreamingEditor.CinePrestreamingEditorSubsystem:GeneratePrestreamingAsset", GeneratePrestreamingAsset_IsValid);
		CreatePackagesFromGeneratedData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreatePackagesFromGeneratedData");
		CreatePackagesFromGeneratedData_ParamsSize = NativeReflection.GetFunctionParamsSize(CreatePackagesFromGeneratedData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreatePackagesFromGeneratedData_InOutData_PropertyAddress, CreatePackagesFromGeneratedData_FunctionAddress, "InOutData");
		CreatePackagesFromGeneratedData_InOutData_Offset = NativeReflectionCached.GetPropertyOffset(CreatePackagesFromGeneratedData_FunctionAddress, "InOutData");
		CreatePackagesFromGeneratedData_InOutData_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePackagesFromGeneratedData_FunctionAddress, "InOutData", Classes.FArrayProperty);
		CreatePackagesFromGeneratedData_IsValid = CreatePackagesFromGeneratedData_FunctionAddress != IntPtr.Zero && CreatePackagesFromGeneratedData_InOutData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CinematicPrestreamingEditor.CinePrestreamingEditorSubsystem:CreatePackagesFromGeneratedData", CreatePackagesFromGeneratedData_IsValid);
	}
}
