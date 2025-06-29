using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.InterchangeCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/InterchangeCore.InterchangePipelineBase", "InterchangeCore", UnrealModuleType.Engine)]
public class UInterchangePipelineBase : UObject
{
	private static bool ScriptedExecutePreImportPipeline_IsValid;

	private IntPtr ScriptedExecutePreImportPipeline_InstanceFunctionAddress;

	private static IntPtr ScriptedExecutePreImportPipeline_FunctionAddress;

	private static int ScriptedExecutePreImportPipeline_ParamsSize;

	private static bool ScriptedExecutePreImportPipeline_BaseNodeContainer_IsValid;

	private static FFieldAddress ScriptedExecutePreImportPipeline_BaseNodeContainer_PropertyAddress;

	private static int ScriptedExecutePreImportPipeline_BaseNodeContainer_Offset;

	private static bool ScriptedExecutePreImportPipeline_SourceDatas_IsValid;

	private static FFieldAddress ScriptedExecutePreImportPipeline_SourceDatas_PropertyAddress;

	private static int ScriptedExecutePreImportPipeline_SourceDatas_Offset;

	private static bool ScriptedExecutePreImportPipeline_ReturnValue_IsValid;

	private static FFieldAddress ScriptedExecutePreImportPipeline_ReturnValue_PropertyAddress;

	private static int ScriptedExecutePreImportPipeline_ReturnValue_Offset;

	private static bool ScriptedExecutePostImportPipeline_IsValid;

	private IntPtr ScriptedExecutePostImportPipeline_InstanceFunctionAddress;

	private static IntPtr ScriptedExecutePostImportPipeline_FunctionAddress;

	private static int ScriptedExecutePostImportPipeline_ParamsSize;

	private static bool ScriptedExecutePostImportPipeline_BaseNodeContainer_IsValid;

	private static FFieldAddress ScriptedExecutePostImportPipeline_BaseNodeContainer_PropertyAddress;

	private static int ScriptedExecutePostImportPipeline_BaseNodeContainer_Offset;

	private static bool ScriptedExecutePostImportPipeline_NodeKey_IsValid;

	private static FFieldAddress ScriptedExecutePostImportPipeline_NodeKey_PropertyAddress;

	private static int ScriptedExecutePostImportPipeline_NodeKey_Offset;

	private static bool ScriptedExecutePostImportPipeline_CreatedAsset_IsValid;

	private static FFieldAddress ScriptedExecutePostImportPipeline_CreatedAsset_PropertyAddress;

	private static int ScriptedExecutePostImportPipeline_CreatedAsset_Offset;

	private static bool ScriptedExecutePostImportPipeline_bIsAReimport_IsValid;

	private static FFieldAddress ScriptedExecutePostImportPipeline_bIsAReimport_PropertyAddress;

	private static int ScriptedExecutePostImportPipeline_bIsAReimport_Offset;

	private static bool ScriptedExecutePostImportPipeline_ReturnValue_IsValid;

	private static FFieldAddress ScriptedExecutePostImportPipeline_ReturnValue_PropertyAddress;

	private static int ScriptedExecutePostImportPipeline_ReturnValue_Offset;

	private static bool ScriptedExecuteExportPipeline_IsValid;

	private IntPtr ScriptedExecuteExportPipeline_InstanceFunctionAddress;

	private static IntPtr ScriptedExecuteExportPipeline_FunctionAddress;

	private static int ScriptedExecuteExportPipeline_ParamsSize;

	private static bool ScriptedExecuteExportPipeline_BaseNodeContainer_IsValid;

	private static FFieldAddress ScriptedExecuteExportPipeline_BaseNodeContainer_PropertyAddress;

	private static int ScriptedExecuteExportPipeline_BaseNodeContainer_Offset;

	private static bool ScriptedExecuteExportPipeline_ReturnValue_IsValid;

	private static FFieldAddress ScriptedExecuteExportPipeline_ReturnValue_PropertyAddress;

	private static int ScriptedExecuteExportPipeline_ReturnValue_Offset;

	private static bool ScriptedCanExecuteOnAnyThread_IsValid;

	private IntPtr ScriptedCanExecuteOnAnyThread_InstanceFunctionAddress;

	private static IntPtr ScriptedCanExecuteOnAnyThread_FunctionAddress;

	private static int ScriptedCanExecuteOnAnyThread_ParamsSize;

	private static bool ScriptedCanExecuteOnAnyThread_PipelineTask_IsValid;

	private static FFieldAddress ScriptedCanExecuteOnAnyThread_PipelineTask_PropertyAddress;

	private static int ScriptedCanExecuteOnAnyThread_PipelineTask_Offset;

	private static bool ScriptedCanExecuteOnAnyThread_ReturnValue_IsValid;

	private static FFieldAddress ScriptedCanExecuteOnAnyThread_ReturnValue_PropertyAddress;

	private static int ScriptedCanExecuteOnAnyThread_ReturnValue_Offset;

	[UFunction(Flags = 205655040u)]
	[UMetaPath("/Script/InterchangeCore.InterchangePipelineBase:ScriptedExecutePreImportPipeline")]
	public unsafe bool ScriptedExecutePreImportPipeline(UInterchangeBaseNodeContainer BaseNodeContainer, List<UInterchangeSourceData> SourceDatas)
	{
		CheckDestroyed();
		if (!ScriptedExecutePreImportPipeline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangePipelineBase:ScriptedExecutePreImportPipeline");
			return false;
		}
		if (ScriptedExecutePreImportPipeline_InstanceFunctionAddress == IntPtr.Zero)
		{
			ScriptedExecutePreImportPipeline_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ScriptedExecutePreImportPipeline");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptedExecutePreImportPipeline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptedExecutePreImportPipeline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInterchangeBaseNodeContainer>.ToNative(IntPtr.Add(intPtr, ScriptedExecutePreImportPipeline_BaseNodeContainer_Offset), 0, ScriptedExecutePreImportPipeline_BaseNodeContainer_PropertyAddress.Address, BaseNodeContainer);
		new TArrayCopyMarshaler<UInterchangeSourceData>(1, ScriptedExecutePreImportPipeline_SourceDatas_PropertyAddress, CachedMarshalingDelegates<UInterchangeSourceData, UObjectMarshaler<UInterchangeSourceData>>.FromNative, CachedMarshalingDelegates<UInterchangeSourceData, UObjectMarshaler<UInterchangeSourceData>>.ToNative).ToNative(IntPtr.Add(intPtr, ScriptedExecutePreImportPipeline_SourceDatas_Offset), SourceDatas);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptedExecutePreImportPipeline_InstanceFunctionAddress, intPtr, ScriptedExecutePreImportPipeline_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScriptedExecutePreImportPipeline_SourceDatas_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ScriptedExecutePreImportPipeline_ReturnValue_Offset), 0, ScriptedExecutePreImportPipeline_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool ScriptedExecutePreImportPipeline_Implementation(UInterchangeBaseNodeContainer BaseNodeContainer, List<UInterchangeSourceData> SourceDatas)
	{
		CheckDestroyed();
		if (!ScriptedExecutePreImportPipeline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangePipelineBase:ScriptedExecutePreImportPipeline");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptedExecutePreImportPipeline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptedExecutePreImportPipeline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInterchangeBaseNodeContainer>.ToNative(IntPtr.Add(intPtr, ScriptedExecutePreImportPipeline_BaseNodeContainer_Offset), 0, ScriptedExecutePreImportPipeline_BaseNodeContainer_PropertyAddress.Address, BaseNodeContainer);
		new TArrayCopyMarshaler<UInterchangeSourceData>(1, ScriptedExecutePreImportPipeline_SourceDatas_PropertyAddress, CachedMarshalingDelegates<UInterchangeSourceData, UObjectMarshaler<UInterchangeSourceData>>.FromNative, CachedMarshalingDelegates<UInterchangeSourceData, UObjectMarshaler<UInterchangeSourceData>>.ToNative).ToNative(IntPtr.Add(intPtr, ScriptedExecutePreImportPipeline_SourceDatas_Offset), SourceDatas);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptedExecutePreImportPipeline_FunctionAddress, intPtr, ScriptedExecutePreImportPipeline_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScriptedExecutePreImportPipeline_SourceDatas_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ScriptedExecutePreImportPipeline_ReturnValue_Offset), 0, ScriptedExecutePreImportPipeline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/InterchangeCore.InterchangePipelineBase:ScriptedExecutePostImportPipeline")]
	public unsafe bool ScriptedExecutePostImportPipeline(UInterchangeBaseNodeContainer BaseNodeContainer, string NodeKey, UObject CreatedAsset, bool bIsAReimport)
	{
		CheckDestroyed();
		if (!ScriptedExecutePostImportPipeline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangePipelineBase:ScriptedExecutePostImportPipeline");
			return false;
		}
		if (ScriptedExecutePostImportPipeline_InstanceFunctionAddress == IntPtr.Zero)
		{
			ScriptedExecutePostImportPipeline_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ScriptedExecutePostImportPipeline");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptedExecutePostImportPipeline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptedExecutePostImportPipeline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInterchangeBaseNodeContainer>.ToNative(IntPtr.Add(intPtr, ScriptedExecutePostImportPipeline_BaseNodeContainer_Offset), 0, ScriptedExecutePostImportPipeline_BaseNodeContainer_PropertyAddress.Address, BaseNodeContainer);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ScriptedExecutePostImportPipeline_NodeKey_Offset), 0, ScriptedExecutePostImportPipeline_NodeKey_PropertyAddress.Address, NodeKey);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ScriptedExecutePostImportPipeline_CreatedAsset_Offset), 0, ScriptedExecutePostImportPipeline_CreatedAsset_PropertyAddress.Address, CreatedAsset);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ScriptedExecutePostImportPipeline_bIsAReimport_Offset), 0, ScriptedExecutePostImportPipeline_bIsAReimport_PropertyAddress.Address, bIsAReimport);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptedExecutePostImportPipeline_InstanceFunctionAddress, intPtr, ScriptedExecutePostImportPipeline_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScriptedExecutePostImportPipeline_NodeKey_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ScriptedExecutePostImportPipeline_ReturnValue_Offset), 0, ScriptedExecutePostImportPipeline_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool ScriptedExecutePostImportPipeline_Implementation(UInterchangeBaseNodeContainer BaseNodeContainer, string NodeKey, UObject CreatedAsset, bool bIsAReimport)
	{
		CheckDestroyed();
		if (!ScriptedExecutePostImportPipeline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangePipelineBase:ScriptedExecutePostImportPipeline");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptedExecutePostImportPipeline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptedExecutePostImportPipeline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInterchangeBaseNodeContainer>.ToNative(IntPtr.Add(intPtr, ScriptedExecutePostImportPipeline_BaseNodeContainer_Offset), 0, ScriptedExecutePostImportPipeline_BaseNodeContainer_PropertyAddress.Address, BaseNodeContainer);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ScriptedExecutePostImportPipeline_NodeKey_Offset), 0, ScriptedExecutePostImportPipeline_NodeKey_PropertyAddress.Address, NodeKey);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ScriptedExecutePostImportPipeline_CreatedAsset_Offset), 0, ScriptedExecutePostImportPipeline_CreatedAsset_PropertyAddress.Address, CreatedAsset);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ScriptedExecutePostImportPipeline_bIsAReimport_Offset), 0, ScriptedExecutePostImportPipeline_bIsAReimport_PropertyAddress.Address, bIsAReimport);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptedExecutePostImportPipeline_FunctionAddress, intPtr, ScriptedExecutePostImportPipeline_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScriptedExecutePostImportPipeline_NodeKey_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ScriptedExecutePostImportPipeline_ReturnValue_Offset), 0, ScriptedExecutePostImportPipeline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/InterchangeCore.InterchangePipelineBase:ScriptedExecuteExportPipeline")]
	public unsafe bool ScriptedExecuteExportPipeline(UInterchangeBaseNodeContainer BaseNodeContainer)
	{
		CheckDestroyed();
		if (!ScriptedExecuteExportPipeline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangePipelineBase:ScriptedExecuteExportPipeline");
			return false;
		}
		if (ScriptedExecuteExportPipeline_InstanceFunctionAddress == IntPtr.Zero)
		{
			ScriptedExecuteExportPipeline_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ScriptedExecuteExportPipeline");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptedExecuteExportPipeline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptedExecuteExportPipeline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInterchangeBaseNodeContainer>.ToNative(IntPtr.Add(intPtr, ScriptedExecuteExportPipeline_BaseNodeContainer_Offset), 0, ScriptedExecuteExportPipeline_BaseNodeContainer_PropertyAddress.Address, BaseNodeContainer);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptedExecuteExportPipeline_InstanceFunctionAddress, intPtr, ScriptedExecuteExportPipeline_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ScriptedExecuteExportPipeline_ReturnValue_Offset), 0, ScriptedExecuteExportPipeline_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool ScriptedExecuteExportPipeline_Implementation(UInterchangeBaseNodeContainer BaseNodeContainer)
	{
		CheckDestroyed();
		if (!ScriptedExecuteExportPipeline_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangePipelineBase:ScriptedExecuteExportPipeline");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptedExecuteExportPipeline_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptedExecuteExportPipeline_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInterchangeBaseNodeContainer>.ToNative(IntPtr.Add(intPtr, ScriptedExecuteExportPipeline_BaseNodeContainer_Offset), 0, ScriptedExecuteExportPipeline_BaseNodeContainer_PropertyAddress.Address, BaseNodeContainer);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptedExecuteExportPipeline_FunctionAddress, intPtr, ScriptedExecuteExportPipeline_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ScriptedExecuteExportPipeline_ReturnValue_Offset), 0, ScriptedExecuteExportPipeline_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/InterchangeCore.InterchangePipelineBase:ScriptedCanExecuteOnAnyThread")]
	public unsafe bool ScriptedCanExecuteOnAnyThread(EInterchangePipelineTask PipelineTask)
	{
		CheckDestroyed();
		if (!ScriptedCanExecuteOnAnyThread_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangePipelineBase:ScriptedCanExecuteOnAnyThread");
			return false;
		}
		if (ScriptedCanExecuteOnAnyThread_InstanceFunctionAddress == IntPtr.Zero)
		{
			ScriptedCanExecuteOnAnyThread_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ScriptedCanExecuteOnAnyThread");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptedCanExecuteOnAnyThread_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptedCanExecuteOnAnyThread_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EInterchangePipelineTask>.ToNative(IntPtr.Add(intPtr, ScriptedCanExecuteOnAnyThread_PipelineTask_Offset), 0, ScriptedCanExecuteOnAnyThread_PipelineTask_PropertyAddress.Address, PipelineTask);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptedCanExecuteOnAnyThread_InstanceFunctionAddress, intPtr, ScriptedCanExecuteOnAnyThread_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ScriptedCanExecuteOnAnyThread_ReturnValue_Offset), 0, ScriptedCanExecuteOnAnyThread_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool ScriptedCanExecuteOnAnyThread_Implementation(EInterchangePipelineTask PipelineTask)
	{
		CheckDestroyed();
		if (!ScriptedCanExecuteOnAnyThread_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeCore.InterchangePipelineBase:ScriptedCanExecuteOnAnyThread");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScriptedCanExecuteOnAnyThread_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScriptedCanExecuteOnAnyThread_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EInterchangePipelineTask>.ToNative(IntPtr.Add(intPtr, ScriptedCanExecuteOnAnyThread_PipelineTask_Offset), 0, ScriptedCanExecuteOnAnyThread_PipelineTask_PropertyAddress.Address, PipelineTask);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScriptedCanExecuteOnAnyThread_FunctionAddress, intPtr, ScriptedCanExecuteOnAnyThread_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ScriptedCanExecuteOnAnyThread_ReturnValue_Offset), 0, ScriptedCanExecuteOnAnyThread_ReturnValue_PropertyAddress.Address);
	}

	static UInterchangePipelineBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangePipelineBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangePipelineBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeCore.InterchangePipelineBase");
		ScriptedExecutePreImportPipeline_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ScriptedExecutePreImportPipeline");
		ScriptedExecutePreImportPipeline_ParamsSize = NativeReflection.GetFunctionParamsSize(ScriptedExecutePreImportPipeline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScriptedExecutePreImportPipeline_BaseNodeContainer_PropertyAddress, ScriptedExecutePreImportPipeline_FunctionAddress, "BaseNodeContainer");
		ScriptedExecutePreImportPipeline_BaseNodeContainer_Offset = NativeReflectionCached.GetPropertyOffset(ScriptedExecutePreImportPipeline_FunctionAddress, "BaseNodeContainer");
		ScriptedExecutePreImportPipeline_BaseNodeContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptedExecutePreImportPipeline_FunctionAddress, "BaseNodeContainer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScriptedExecutePreImportPipeline_SourceDatas_PropertyAddress, ScriptedExecutePreImportPipeline_FunctionAddress, "SourceDatas");
		ScriptedExecutePreImportPipeline_SourceDatas_Offset = NativeReflectionCached.GetPropertyOffset(ScriptedExecutePreImportPipeline_FunctionAddress, "SourceDatas");
		ScriptedExecutePreImportPipeline_SourceDatas_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptedExecutePreImportPipeline_FunctionAddress, "SourceDatas", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ScriptedExecutePreImportPipeline_ReturnValue_PropertyAddress, ScriptedExecutePreImportPipeline_FunctionAddress, "ReturnValue");
		ScriptedExecutePreImportPipeline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScriptedExecutePreImportPipeline_FunctionAddress, "ReturnValue");
		ScriptedExecutePreImportPipeline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptedExecutePreImportPipeline_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ScriptedExecutePreImportPipeline_IsValid = ScriptedExecutePreImportPipeline_FunctionAddress != IntPtr.Zero && ScriptedExecutePreImportPipeline_BaseNodeContainer_IsValid && ScriptedExecutePreImportPipeline_SourceDatas_IsValid && ScriptedExecutePreImportPipeline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangePipelineBase:ScriptedExecutePreImportPipeline", ScriptedExecutePreImportPipeline_IsValid);
		ScriptedExecutePostImportPipeline_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ScriptedExecutePostImportPipeline");
		ScriptedExecutePostImportPipeline_ParamsSize = NativeReflection.GetFunctionParamsSize(ScriptedExecutePostImportPipeline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScriptedExecutePostImportPipeline_BaseNodeContainer_PropertyAddress, ScriptedExecutePostImportPipeline_FunctionAddress, "BaseNodeContainer");
		ScriptedExecutePostImportPipeline_BaseNodeContainer_Offset = NativeReflectionCached.GetPropertyOffset(ScriptedExecutePostImportPipeline_FunctionAddress, "BaseNodeContainer");
		ScriptedExecutePostImportPipeline_BaseNodeContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptedExecutePostImportPipeline_FunctionAddress, "BaseNodeContainer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScriptedExecutePostImportPipeline_NodeKey_PropertyAddress, ScriptedExecutePostImportPipeline_FunctionAddress, "NodeKey");
		ScriptedExecutePostImportPipeline_NodeKey_Offset = NativeReflectionCached.GetPropertyOffset(ScriptedExecutePostImportPipeline_FunctionAddress, "NodeKey");
		ScriptedExecutePostImportPipeline_NodeKey_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptedExecutePostImportPipeline_FunctionAddress, "NodeKey", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ScriptedExecutePostImportPipeline_CreatedAsset_PropertyAddress, ScriptedExecutePostImportPipeline_FunctionAddress, "CreatedAsset");
		ScriptedExecutePostImportPipeline_CreatedAsset_Offset = NativeReflectionCached.GetPropertyOffset(ScriptedExecutePostImportPipeline_FunctionAddress, "CreatedAsset");
		ScriptedExecutePostImportPipeline_CreatedAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptedExecutePostImportPipeline_FunctionAddress, "CreatedAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScriptedExecutePostImportPipeline_bIsAReimport_PropertyAddress, ScriptedExecutePostImportPipeline_FunctionAddress, "bIsAReimport");
		ScriptedExecutePostImportPipeline_bIsAReimport_Offset = NativeReflectionCached.GetPropertyOffset(ScriptedExecutePostImportPipeline_FunctionAddress, "bIsAReimport");
		ScriptedExecutePostImportPipeline_bIsAReimport_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptedExecutePostImportPipeline_FunctionAddress, "bIsAReimport", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ScriptedExecutePostImportPipeline_ReturnValue_PropertyAddress, ScriptedExecutePostImportPipeline_FunctionAddress, "ReturnValue");
		ScriptedExecutePostImportPipeline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScriptedExecutePostImportPipeline_FunctionAddress, "ReturnValue");
		ScriptedExecutePostImportPipeline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptedExecutePostImportPipeline_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ScriptedExecutePostImportPipeline_IsValid = ScriptedExecutePostImportPipeline_FunctionAddress != IntPtr.Zero && ScriptedExecutePostImportPipeline_BaseNodeContainer_IsValid && ScriptedExecutePostImportPipeline_NodeKey_IsValid && ScriptedExecutePostImportPipeline_CreatedAsset_IsValid && ScriptedExecutePostImportPipeline_bIsAReimport_IsValid && ScriptedExecutePostImportPipeline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangePipelineBase:ScriptedExecutePostImportPipeline", ScriptedExecutePostImportPipeline_IsValid);
		ScriptedExecuteExportPipeline_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ScriptedExecuteExportPipeline");
		ScriptedExecuteExportPipeline_ParamsSize = NativeReflection.GetFunctionParamsSize(ScriptedExecuteExportPipeline_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScriptedExecuteExportPipeline_BaseNodeContainer_PropertyAddress, ScriptedExecuteExportPipeline_FunctionAddress, "BaseNodeContainer");
		ScriptedExecuteExportPipeline_BaseNodeContainer_Offset = NativeReflectionCached.GetPropertyOffset(ScriptedExecuteExportPipeline_FunctionAddress, "BaseNodeContainer");
		ScriptedExecuteExportPipeline_BaseNodeContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptedExecuteExportPipeline_FunctionAddress, "BaseNodeContainer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScriptedExecuteExportPipeline_ReturnValue_PropertyAddress, ScriptedExecuteExportPipeline_FunctionAddress, "ReturnValue");
		ScriptedExecuteExportPipeline_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScriptedExecuteExportPipeline_FunctionAddress, "ReturnValue");
		ScriptedExecuteExportPipeline_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptedExecuteExportPipeline_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ScriptedExecuteExportPipeline_IsValid = ScriptedExecuteExportPipeline_FunctionAddress != IntPtr.Zero && ScriptedExecuteExportPipeline_BaseNodeContainer_IsValid && ScriptedExecuteExportPipeline_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangePipelineBase:ScriptedExecuteExportPipeline", ScriptedExecuteExportPipeline_IsValid);
		ScriptedCanExecuteOnAnyThread_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ScriptedCanExecuteOnAnyThread");
		ScriptedCanExecuteOnAnyThread_ParamsSize = NativeReflection.GetFunctionParamsSize(ScriptedCanExecuteOnAnyThread_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScriptedCanExecuteOnAnyThread_PipelineTask_PropertyAddress, ScriptedCanExecuteOnAnyThread_FunctionAddress, "PipelineTask");
		ScriptedCanExecuteOnAnyThread_PipelineTask_Offset = NativeReflectionCached.GetPropertyOffset(ScriptedCanExecuteOnAnyThread_FunctionAddress, "PipelineTask");
		ScriptedCanExecuteOnAnyThread_PipelineTask_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptedCanExecuteOnAnyThread_FunctionAddress, "PipelineTask", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ScriptedCanExecuteOnAnyThread_ReturnValue_PropertyAddress, ScriptedCanExecuteOnAnyThread_FunctionAddress, "ReturnValue");
		ScriptedCanExecuteOnAnyThread_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScriptedCanExecuteOnAnyThread_FunctionAddress, "ReturnValue");
		ScriptedCanExecuteOnAnyThread_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScriptedCanExecuteOnAnyThread_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ScriptedCanExecuteOnAnyThread_IsValid = ScriptedCanExecuteOnAnyThread_FunctionAddress != IntPtr.Zero && ScriptedCanExecuteOnAnyThread_PipelineTask_IsValid && ScriptedCanExecuteOnAnyThread_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeCore.InterchangePipelineBase:ScriptedCanExecuteOnAnyThread", ScriptedCanExecuteOnAnyThread_IsValid);
	}
}
