using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.DataprepCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepEditorScriptingUtilities;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary", "DataprepEditorScriptingUtilities", UnrealModuleType.EnginePlugin)]
public class UEditorDataprepAssetLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SwapSteps_IsValid;

	private static IntPtr SwapSteps_FunctionAddress;

	private static int SwapSteps_ParamsSize;

	private static bool SwapSteps_DataprepAction_IsValid;

	private static FFieldAddress SwapSteps_DataprepAction_PropertyAddress;

	private static int SwapSteps_DataprepAction_Offset;

	private static bool SwapSteps_FirstIndex_IsValid;

	private static FFieldAddress SwapSteps_FirstIndex_PropertyAddress;

	private static int SwapSteps_FirstIndex_Offset;

	private static bool SwapSteps_SecondIndex_IsValid;

	private static FFieldAddress SwapSteps_SecondIndex_PropertyAddress;

	private static int SwapSteps_SecondIndex_Offset;

	private static bool SwapActions_IsValid;

	private static IntPtr SwapActions_FunctionAddress;

	private static int SwapActions_ParamsSize;

	private static bool SwapActions_DataprepAsset_IsValid;

	private static FFieldAddress SwapActions_DataprepAsset_PropertyAddress;

	private static int SwapActions_DataprepAsset_Offset;

	private static bool SwapActions_FirstActionIndex_IsValid;

	private static FFieldAddress SwapActions_FirstActionIndex_PropertyAddress;

	private static int SwapActions_FirstActionIndex_Offset;

	private static bool SwapActions_SecondActionIndex_IsValid;

	private static FFieldAddress SwapActions_SecondActionIndex_PropertyAddress;

	private static int SwapActions_SecondActionIndex_Offset;

	private static bool RemoveStep_IsValid;

	private static IntPtr RemoveStep_FunctionAddress;

	private static int RemoveStep_ParamsSize;

	private static bool RemoveStep_DataprepAction_IsValid;

	private static FFieldAddress RemoveStep_DataprepAction_PropertyAddress;

	private static int RemoveStep_DataprepAction_Offset;

	private static bool RemoveStep_Index_IsValid;

	private static FFieldAddress RemoveStep_Index_PropertyAddress;

	private static int RemoveStep_Index_Offset;

	private static bool RemoveProducer_IsValid;

	private static IntPtr RemoveProducer_FunctionAddress;

	private static int RemoveProducer_ParamsSize;

	private static bool RemoveProducer_DataprepAssetInterface_IsValid;

	private static FFieldAddress RemoveProducer_DataprepAssetInterface_PropertyAddress;

	private static int RemoveProducer_DataprepAssetInterface_Offset;

	private static bool RemoveProducer_Index_IsValid;

	private static FFieldAddress RemoveProducer_Index_PropertyAddress;

	private static int RemoveProducer_Index_Offset;

	private static bool RemoveAction_IsValid;

	private static IntPtr RemoveAction_FunctionAddress;

	private static int RemoveAction_ParamsSize;

	private static bool RemoveAction_DataprepAsset_IsValid;

	private static FFieldAddress RemoveAction_DataprepAsset_PropertyAddress;

	private static int RemoveAction_DataprepAsset_Offset;

	private static bool RemoveAction_Index_IsValid;

	private static FFieldAddress RemoveAction_Index_PropertyAddress;

	private static int RemoveAction_Index_Offset;

	private static bool MoveStep_IsValid;

	private static IntPtr MoveStep_FunctionAddress;

	private static int MoveStep_ParamsSize;

	private static bool MoveStep_DataprepAction_IsValid;

	private static FFieldAddress MoveStep_DataprepAction_PropertyAddress;

	private static int MoveStep_DataprepAction_Offset;

	private static bool MoveStep_StepIndex_IsValid;

	private static FFieldAddress MoveStep_StepIndex_PropertyAddress;

	private static int MoveStep_StepIndex_Offset;

	private static bool MoveStep_DestinationIndex_IsValid;

	private static FFieldAddress MoveStep_DestinationIndex_PropertyAddress;

	private static int MoveStep_DestinationIndex_Offset;

	private static bool GetStepsCount_IsValid;

	private static IntPtr GetStepsCount_FunctionAddress;

	private static int GetStepsCount_ParamsSize;

	private static bool GetStepsCount_DataprepAction_IsValid;

	private static FFieldAddress GetStepsCount_DataprepAction_PropertyAddress;

	private static int GetStepsCount_DataprepAction_Offset;

	private static bool GetStepsCount_ReturnValue_IsValid;

	private static FFieldAddress GetStepsCount_ReturnValue_PropertyAddress;

	private static int GetStepsCount_ReturnValue_Offset;

	private static bool GetStepObject_IsValid;

	private static IntPtr GetStepObject_FunctionAddress;

	private static int GetStepObject_ParamsSize;

	private static bool GetStepObject_DataprepAction_IsValid;

	private static FFieldAddress GetStepObject_DataprepAction_PropertyAddress;

	private static int GetStepObject_DataprepAction_Offset;

	private static bool GetStepObject_Index_IsValid;

	private static FFieldAddress GetStepObject_Index_PropertyAddress;

	private static int GetStepObject_Index_Offset;

	private static bool GetStepObject_ReturnValue_IsValid;

	private static FFieldAddress GetStepObject_ReturnValue_PropertyAddress;

	private static int GetStepObject_ReturnValue_Offset;

	private static bool GetProducersCount_IsValid;

	private static IntPtr GetProducersCount_FunctionAddress;

	private static int GetProducersCount_ParamsSize;

	private static bool GetProducersCount_DataprepAssetInterface_IsValid;

	private static FFieldAddress GetProducersCount_DataprepAssetInterface_PropertyAddress;

	private static int GetProducersCount_DataprepAssetInterface_Offset;

	private static bool GetProducersCount_ReturnValue_IsValid;

	private static FFieldAddress GetProducersCount_ReturnValue_PropertyAddress;

	private static int GetProducersCount_ReturnValue_Offset;

	private static bool GetProducer_IsValid;

	private static IntPtr GetProducer_FunctionAddress;

	private static int GetProducer_ParamsSize;

	private static bool GetProducer_DataprepAssetInterface_IsValid;

	private static FFieldAddress GetProducer_DataprepAssetInterface_PropertyAddress;

	private static int GetProducer_DataprepAssetInterface_Offset;

	private static bool GetProducer_Index_IsValid;

	private static FFieldAddress GetProducer_Index_PropertyAddress;

	private static int GetProducer_Index_Offset;

	private static bool GetProducer_ReturnValue_IsValid;

	private static FFieldAddress GetProducer_ReturnValue_PropertyAddress;

	private static int GetProducer_ReturnValue_Offset;

	private static bool GetConsumer_IsValid;

	private static IntPtr GetConsumer_FunctionAddress;

	private static int GetConsumer_ParamsSize;

	private static bool GetConsumer_DataprepAssetInterface_IsValid;

	private static FFieldAddress GetConsumer_DataprepAssetInterface_PropertyAddress;

	private static int GetConsumer_DataprepAssetInterface_Offset;

	private static bool GetConsumer_ReturnValue_IsValid;

	private static FFieldAddress GetConsumer_ReturnValue_PropertyAddress;

	private static int GetConsumer_ReturnValue_Offset;

	private static bool GetActionCount_IsValid;

	private static IntPtr GetActionCount_FunctionAddress;

	private static int GetActionCount_ParamsSize;

	private static bool GetActionCount_DataprepAsset_IsValid;

	private static FFieldAddress GetActionCount_DataprepAsset_PropertyAddress;

	private static int GetActionCount_DataprepAsset_Offset;

	private static bool GetActionCount_ReturnValue_IsValid;

	private static FFieldAddress GetActionCount_ReturnValue_PropertyAddress;

	private static int GetActionCount_ReturnValue_Offset;

	private static bool GetAction_IsValid;

	private static IntPtr GetAction_FunctionAddress;

	private static int GetAction_ParamsSize;

	private static bool GetAction_DataprepAsset_IsValid;

	private static FFieldAddress GetAction_DataprepAsset_PropertyAddress;

	private static int GetAction_DataprepAsset_Offset;

	private static bool GetAction_Index_IsValid;

	private static FFieldAddress GetAction_Index_PropertyAddress;

	private static int GetAction_Index_Offset;

	private static bool GetAction_ReturnValue_IsValid;

	private static FFieldAddress GetAction_ReturnValue_PropertyAddress;

	private static int GetAction_ReturnValue_Offset;

	private static bool ExecuteDataprep_IsValid;

	private static IntPtr ExecuteDataprep_FunctionAddress;

	private static int ExecuteDataprep_ParamsSize;

	private static bool ExecuteDataprep_DataprepAssetInterface_IsValid;

	private static FFieldAddress ExecuteDataprep_DataprepAssetInterface_PropertyAddress;

	private static int ExecuteDataprep_DataprepAssetInterface_Offset;

	private static bool ExecuteDataprep_LogReportingMethod_IsValid;

	private static FFieldAddress ExecuteDataprep_LogReportingMethod_PropertyAddress;

	private static int ExecuteDataprep_LogReportingMethod_Offset;

	private static bool ExecuteDataprep_ProgressReportingMethod_IsValid;

	private static FFieldAddress ExecuteDataprep_ProgressReportingMethod_PropertyAddress;

	private static int ExecuteDataprep_ProgressReportingMethod_Offset;

	private static bool ExecuteDataprep_ReturnValue_IsValid;

	private static FFieldAddress ExecuteDataprep_ReturnValue_PropertyAddress;

	private static int ExecuteDataprep_ReturnValue_Offset;

	private static bool AddStepByDuplication_IsValid;

	private static IntPtr AddStepByDuplication_FunctionAddress;

	private static int AddStepByDuplication_ParamsSize;

	private static bool AddStepByDuplication_DataprepAction_IsValid;

	private static FFieldAddress AddStepByDuplication_DataprepAction_PropertyAddress;

	private static int AddStepByDuplication_DataprepAction_Offset;

	private static bool AddStepByDuplication_StepObject_IsValid;

	private static FFieldAddress AddStepByDuplication_StepObject_PropertyAddress;

	private static int AddStepByDuplication_StepObject_Offset;

	private static bool AddStepByDuplication_ReturnValue_IsValid;

	private static FFieldAddress AddStepByDuplication_ReturnValue_PropertyAddress;

	private static int AddStepByDuplication_ReturnValue_Offset;

	private static bool AddStep_IsValid;

	private static IntPtr AddStep_FunctionAddress;

	private static int AddStep_ParamsSize;

	private static bool AddStep_DataprepAction_IsValid;

	private static FFieldAddress AddStep_DataprepAction_PropertyAddress;

	private static int AddStep_DataprepAction_Offset;

	private static bool AddStep_StepType_IsValid;

	private static FFieldAddress AddStep_StepType_PropertyAddress;

	private static int AddStep_StepType_Offset;

	private static bool AddStep_ReturnValue_IsValid;

	private static FFieldAddress AddStep_ReturnValue_PropertyAddress;

	private static int AddStep_ReturnValue_Offset;

	private static bool AddProducerAutomated_IsValid;

	private static IntPtr AddProducerAutomated_FunctionAddress;

	private static int AddProducerAutomated_ParamsSize;

	private static bool AddProducerAutomated_DataprepAssetInterface_IsValid;

	private static FFieldAddress AddProducerAutomated_DataprepAssetInterface_PropertyAddress;

	private static int AddProducerAutomated_DataprepAssetInterface_Offset;

	private static bool AddProducerAutomated_ProducerClass_IsValid;

	private static FFieldAddress AddProducerAutomated_ProducerClass_PropertyAddress;

	private static int AddProducerAutomated_ProducerClass_Offset;

	private static bool AddProducerAutomated_ReturnValue_IsValid;

	private static FFieldAddress AddProducerAutomated_ReturnValue_PropertyAddress;

	private static int AddProducerAutomated_ReturnValue_Offset;

	private static bool AddProducer_IsValid;

	private static IntPtr AddProducer_FunctionAddress;

	private static int AddProducer_ParamsSize;

	private static bool AddProducer_DataprepAssetInterface_IsValid;

	private static FFieldAddress AddProducer_DataprepAssetInterface_PropertyAddress;

	private static int AddProducer_DataprepAssetInterface_Offset;

	private static bool AddProducer_ProducerClass_IsValid;

	private static FFieldAddress AddProducer_ProducerClass_PropertyAddress;

	private static int AddProducer_ProducerClass_Offset;

	private static bool AddProducer_ReturnValue_IsValid;

	private static FFieldAddress AddProducer_ReturnValue_PropertyAddress;

	private static int AddProducer_ReturnValue_Offset;

	private static bool AddActionByDuplication_IsValid;

	private static IntPtr AddActionByDuplication_FunctionAddress;

	private static int AddActionByDuplication_ParamsSize;

	private static bool AddActionByDuplication_DataprepAsset_IsValid;

	private static FFieldAddress AddActionByDuplication_DataprepAsset_PropertyAddress;

	private static int AddActionByDuplication_DataprepAsset_Offset;

	private static bool AddActionByDuplication_ActionToDuplicate_IsValid;

	private static FFieldAddress AddActionByDuplication_ActionToDuplicate_PropertyAddress;

	private static int AddActionByDuplication_ActionToDuplicate_Offset;

	private static bool AddActionByDuplication_ReturnValue_IsValid;

	private static FFieldAddress AddActionByDuplication_ReturnValue_PropertyAddress;

	private static int AddActionByDuplication_ReturnValue_Offset;

	private static bool AddAction_IsValid;

	private static IntPtr AddAction_FunctionAddress;

	private static int AddAction_ParamsSize;

	private static bool AddAction_DataprepAsset_IsValid;

	private static FFieldAddress AddAction_DataprepAsset_PropertyAddress;

	private static int AddAction_DataprepAsset_Offset;

	private static bool AddAction_ReturnValue_IsValid;

	private static FFieldAddress AddAction_ReturnValue_PropertyAddress;

	private static int AddAction_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:SwapSteps")]
	public unsafe static void SwapSteps(UDataprepActionAsset DataprepAction, int FirstIndex, int SecondIndex)
	{
		if (!SwapSteps_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:SwapSteps");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwapSteps_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwapSteps_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepActionAsset>.ToNative(IntPtr.Add(intPtr, SwapSteps_DataprepAction_Offset), 0, SwapSteps_DataprepAction_PropertyAddress.Address, DataprepAction);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SwapSteps_FirstIndex_Offset), 0, SwapSteps_FirstIndex_PropertyAddress.Address, FirstIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SwapSteps_SecondIndex_Offset), 0, SwapSteps_SecondIndex_PropertyAddress.Address, SecondIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SwapSteps_FunctionAddress, intPtr, SwapSteps_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:SwapActions")]
	public unsafe static void SwapActions(UDataprepAsset DataprepAsset, int FirstActionIndex, int SecondActionIndex)
	{
		if (!SwapActions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:SwapActions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwapActions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwapActions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepAsset>.ToNative(IntPtr.Add(intPtr, SwapActions_DataprepAsset_Offset), 0, SwapActions_DataprepAsset_PropertyAddress.Address, DataprepAsset);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SwapActions_FirstActionIndex_Offset), 0, SwapActions_FirstActionIndex_PropertyAddress.Address, FirstActionIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SwapActions_SecondActionIndex_Offset), 0, SwapActions_SecondActionIndex_PropertyAddress.Address, SecondActionIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SwapActions_FunctionAddress, intPtr, SwapActions_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:RemoveStep")]
	public unsafe static void RemoveStep(UDataprepActionAsset DataprepAction, int Index)
	{
		if (!RemoveStep_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:RemoveStep");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveStep_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveStep_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepActionAsset>.ToNative(IntPtr.Add(intPtr, RemoveStep_DataprepAction_Offset), 0, RemoveStep_DataprepAction_PropertyAddress.Address, DataprepAction);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RemoveStep_Index_Offset), 0, RemoveStep_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveStep_FunctionAddress, intPtr, RemoveStep_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:RemoveProducer")]
	public unsafe static void RemoveProducer(UDataprepAssetInterface DataprepAssetInterface, int Index)
	{
		if (!RemoveProducer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:RemoveProducer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveProducer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveProducer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepAssetInterface>.ToNative(IntPtr.Add(intPtr, RemoveProducer_DataprepAssetInterface_Offset), 0, RemoveProducer_DataprepAssetInterface_PropertyAddress.Address, DataprepAssetInterface);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RemoveProducer_Index_Offset), 0, RemoveProducer_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveProducer_FunctionAddress, intPtr, RemoveProducer_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:RemoveAction")]
	public unsafe static void RemoveAction(UDataprepAsset DataprepAsset, int Index)
	{
		if (!RemoveAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:RemoveAction");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepAsset>.ToNative(IntPtr.Add(intPtr, RemoveAction_DataprepAsset_Offset), 0, RemoveAction_DataprepAsset_PropertyAddress.Address, DataprepAsset);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RemoveAction_Index_Offset), 0, RemoveAction_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAction_FunctionAddress, intPtr, RemoveAction_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:MoveStep")]
	public unsafe static void MoveStep(UDataprepActionAsset DataprepAction, int StepIndex, int DestinationIndex)
	{
		if (!MoveStep_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:MoveStep");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MoveStep_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoveStep_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepActionAsset>.ToNative(IntPtr.Add(intPtr, MoveStep_DataprepAction_Offset), 0, MoveStep_DataprepAction_PropertyAddress.Address, DataprepAction);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MoveStep_StepIndex_Offset), 0, MoveStep_StepIndex_PropertyAddress.Address, StepIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MoveStep_DestinationIndex_Offset), 0, MoveStep_DestinationIndex_PropertyAddress.Address, DestinationIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MoveStep_FunctionAddress, intPtr, MoveStep_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetStepsCount")]
	public unsafe static int GetStepsCount(UDataprepActionAsset DataprepAction)
	{
		if (!GetStepsCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetStepsCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStepsCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStepsCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepActionAsset>.ToNative(IntPtr.Add(intPtr, GetStepsCount_DataprepAction_Offset), 0, GetStepsCount_DataprepAction_PropertyAddress.Address, DataprepAction);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStepsCount_FunctionAddress, intPtr, GetStepsCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetStepsCount_ReturnValue_Offset), 0, GetStepsCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetStepObject")]
	public unsafe static UDataprepParameterizableObject GetStepObject(UDataprepActionAsset DataprepAction, int Index)
	{
		if (!GetStepObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetStepObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStepObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStepObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepActionAsset>.ToNative(IntPtr.Add(intPtr, GetStepObject_DataprepAction_Offset), 0, GetStepObject_DataprepAction_PropertyAddress.Address, DataprepAction);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetStepObject_Index_Offset), 0, GetStepObject_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStepObject_FunctionAddress, intPtr, GetStepObject_ParamsSize);
		return UObjectMarshaler<UDataprepParameterizableObject>.FromNative(IntPtr.Add(intPtr, GetStepObject_ReturnValue_Offset), 0, GetStepObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetProducersCount")]
	public unsafe static int GetProducersCount(UDataprepAssetInterface DataprepAssetInterface)
	{
		if (!GetProducersCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetProducersCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetProducersCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetProducersCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepAssetInterface>.ToNative(IntPtr.Add(intPtr, GetProducersCount_DataprepAssetInterface_Offset), 0, GetProducersCount_DataprepAssetInterface_PropertyAddress.Address, DataprepAssetInterface);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetProducersCount_FunctionAddress, intPtr, GetProducersCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetProducersCount_ReturnValue_Offset), 0, GetProducersCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetProducer")]
	public unsafe static UDataprepContentProducer GetProducer(UDataprepAssetInterface DataprepAssetInterface, int Index)
	{
		if (!GetProducer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetProducer");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetProducer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetProducer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepAssetInterface>.ToNative(IntPtr.Add(intPtr, GetProducer_DataprepAssetInterface_Offset), 0, GetProducer_DataprepAssetInterface_PropertyAddress.Address, DataprepAssetInterface);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetProducer_Index_Offset), 0, GetProducer_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetProducer_FunctionAddress, intPtr, GetProducer_ParamsSize);
		return UObjectMarshaler<UDataprepContentProducer>.FromNative(IntPtr.Add(intPtr, GetProducer_ReturnValue_Offset), 0, GetProducer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetConsumer")]
	public unsafe static UDataprepContentConsumer GetConsumer(UDataprepAssetInterface DataprepAssetInterface)
	{
		if (!GetConsumer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetConsumer");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConsumer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConsumer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepAssetInterface>.ToNative(IntPtr.Add(intPtr, GetConsumer_DataprepAssetInterface_Offset), 0, GetConsumer_DataprepAssetInterface_PropertyAddress.Address, DataprepAssetInterface);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetConsumer_FunctionAddress, intPtr, GetConsumer_ParamsSize);
		return UObjectMarshaler<UDataprepContentConsumer>.FromNative(IntPtr.Add(intPtr, GetConsumer_ReturnValue_Offset), 0, GetConsumer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetActionCount")]
	public unsafe static int GetActionCount(UDataprepAsset DataprepAsset)
	{
		if (!GetActionCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetActionCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActionCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActionCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepAsset>.ToNative(IntPtr.Add(intPtr, GetActionCount_DataprepAsset_Offset), 0, GetActionCount_DataprepAsset_PropertyAddress.Address, DataprepAsset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActionCount_FunctionAddress, intPtr, GetActionCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetActionCount_ReturnValue_Offset), 0, GetActionCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetAction")]
	public unsafe static UDataprepActionAsset GetAction(UDataprepAsset DataprepAsset, int Index)
	{
		if (!GetAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetAction");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepAsset>.ToNative(IntPtr.Add(intPtr, GetAction_DataprepAsset_Offset), 0, GetAction_DataprepAsset_PropertyAddress.Address, DataprepAsset);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAction_Index_Offset), 0, GetAction_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAction_FunctionAddress, intPtr, GetAction_ParamsSize);
		return UObjectMarshaler<UDataprepActionAsset>.FromNative(IntPtr.Add(intPtr, GetAction_ReturnValue_Offset), 0, GetAction_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:ExecuteDataprep")]
	public unsafe static bool ExecuteDataprep(UDataprepAssetInterface DataprepAssetInterface, EDataprepReportMethod LogReportingMethod, EDataprepReportMethod ProgressReportingMethod)
	{
		if (!ExecuteDataprep_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:ExecuteDataprep");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExecuteDataprep_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExecuteDataprep_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepAssetInterface>.ToNative(IntPtr.Add(intPtr, ExecuteDataprep_DataprepAssetInterface_Offset), 0, ExecuteDataprep_DataprepAssetInterface_PropertyAddress.Address, DataprepAssetInterface);
		EnumMarshaler<EDataprepReportMethod>.ToNative(IntPtr.Add(intPtr, ExecuteDataprep_LogReportingMethod_Offset), 0, ExecuteDataprep_LogReportingMethod_PropertyAddress.Address, LogReportingMethod);
		EnumMarshaler<EDataprepReportMethod>.ToNative(IntPtr.Add(intPtr, ExecuteDataprep_ProgressReportingMethod_Offset), 0, ExecuteDataprep_ProgressReportingMethod_PropertyAddress.Address, ProgressReportingMethod);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExecuteDataprep_FunctionAddress, intPtr, ExecuteDataprep_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ExecuteDataprep_ReturnValue_Offset), 0, ExecuteDataprep_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:AddStepByDuplication")]
	public unsafe static UDataprepParameterizableObject AddStepByDuplication(UDataprepActionAsset DataprepAction, UDataprepParameterizableObject StepObject)
	{
		if (!AddStepByDuplication_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:AddStepByDuplication");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddStepByDuplication_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddStepByDuplication_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepActionAsset>.ToNative(IntPtr.Add(intPtr, AddStepByDuplication_DataprepAction_Offset), 0, AddStepByDuplication_DataprepAction_PropertyAddress.Address, DataprepAction);
		UObjectMarshaler<UDataprepParameterizableObject>.ToNative(IntPtr.Add(intPtr, AddStepByDuplication_StepObject_Offset), 0, AddStepByDuplication_StepObject_PropertyAddress.Address, StepObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddStepByDuplication_FunctionAddress, intPtr, AddStepByDuplication_ParamsSize);
		return UObjectMarshaler<UDataprepParameterizableObject>.FromNative(IntPtr.Add(intPtr, AddStepByDuplication_ReturnValue_Offset), 0, AddStepByDuplication_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:AddStep")]
	public unsafe static UDataprepParameterizableObject AddStep(UDataprepActionAsset DataprepAction, TSubclassOf<UDataprepParameterizableObject> StepType)
	{
		if (!AddStep_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:AddStep");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddStep_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddStep_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepActionAsset>.ToNative(IntPtr.Add(intPtr, AddStep_DataprepAction_Offset), 0, AddStep_DataprepAction_PropertyAddress.Address, DataprepAction);
		TSubclassOfMarshaler<UDataprepParameterizableObject>.ToNative(IntPtr.Add(intPtr, AddStep_StepType_Offset), 0, AddStep_StepType_PropertyAddress.Address, StepType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddStep_FunctionAddress, intPtr, AddStep_ParamsSize);
		return UObjectMarshaler<UDataprepParameterizableObject>.FromNative(IntPtr.Add(intPtr, AddStep_ReturnValue_Offset), 0, AddStep_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:AddProducerAutomated")]
	public unsafe static UDataprepContentProducer AddProducerAutomated(UDataprepAssetInterface DataprepAssetInterface, TSubclassOf<UDataprepContentProducer> ProducerClass)
	{
		if (!AddProducerAutomated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:AddProducerAutomated");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddProducerAutomated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddProducerAutomated_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepAssetInterface>.ToNative(IntPtr.Add(intPtr, AddProducerAutomated_DataprepAssetInterface_Offset), 0, AddProducerAutomated_DataprepAssetInterface_PropertyAddress.Address, DataprepAssetInterface);
		TSubclassOfMarshaler<UDataprepContentProducer>.ToNative(IntPtr.Add(intPtr, AddProducerAutomated_ProducerClass_Offset), 0, AddProducerAutomated_ProducerClass_PropertyAddress.Address, ProducerClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddProducerAutomated_FunctionAddress, intPtr, AddProducerAutomated_ParamsSize);
		return UObjectMarshaler<UDataprepContentProducer>.FromNative(IntPtr.Add(intPtr, AddProducerAutomated_ReturnValue_Offset), 0, AddProducerAutomated_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:AddProducer")]
	public unsafe static UDataprepContentProducer AddProducer(UDataprepAssetInterface DataprepAssetInterface, TSubclassOf<UDataprepContentProducer> ProducerClass)
	{
		if (!AddProducer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:AddProducer");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddProducer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddProducer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepAssetInterface>.ToNative(IntPtr.Add(intPtr, AddProducer_DataprepAssetInterface_Offset), 0, AddProducer_DataprepAssetInterface_PropertyAddress.Address, DataprepAssetInterface);
		TSubclassOfMarshaler<UDataprepContentProducer>.ToNative(IntPtr.Add(intPtr, AddProducer_ProducerClass_Offset), 0, AddProducer_ProducerClass_PropertyAddress.Address, ProducerClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddProducer_FunctionAddress, intPtr, AddProducer_ParamsSize);
		return UObjectMarshaler<UDataprepContentProducer>.FromNative(IntPtr.Add(intPtr, AddProducer_ReturnValue_Offset), 0, AddProducer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:AddActionByDuplication")]
	public unsafe static UDataprepActionAsset AddActionByDuplication(UDataprepAsset DataprepAsset, UDataprepActionAsset ActionToDuplicate)
	{
		if (!AddActionByDuplication_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:AddActionByDuplication");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddActionByDuplication_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddActionByDuplication_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepAsset>.ToNative(IntPtr.Add(intPtr, AddActionByDuplication_DataprepAsset_Offset), 0, AddActionByDuplication_DataprepAsset_PropertyAddress.Address, DataprepAsset);
		UObjectMarshaler<UDataprepActionAsset>.ToNative(IntPtr.Add(intPtr, AddActionByDuplication_ActionToDuplicate_Offset), 0, AddActionByDuplication_ActionToDuplicate_PropertyAddress.Address, ActionToDuplicate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddActionByDuplication_FunctionAddress, intPtr, AddActionByDuplication_ParamsSize);
		return UObjectMarshaler<UDataprepActionAsset>.FromNative(IntPtr.Add(intPtr, AddActionByDuplication_ReturnValue_Offset), 0, AddActionByDuplication_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:AddAction")]
	public unsafe static UDataprepActionAsset AddAction(UDataprepAsset DataprepAsset)
	{
		if (!AddAction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:AddAction");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataprepAsset>.ToNative(IntPtr.Add(intPtr, AddAction_DataprepAsset_Offset), 0, AddAction_DataprepAsset_PropertyAddress.Address, DataprepAsset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddAction_FunctionAddress, intPtr, AddAction_ParamsSize);
		return UObjectMarshaler<UDataprepActionAsset>.FromNative(IntPtr.Add(intPtr, AddAction_ReturnValue_Offset), 0, AddAction_ReturnValue_PropertyAddress.Address);
	}

	static UEditorDataprepAssetLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEditorDataprepAssetLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEditorDataprepAssetLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary");
		SwapSteps_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SwapSteps");
		SwapSteps_ParamsSize = NativeReflection.GetFunctionParamsSize(SwapSteps_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SwapSteps_DataprepAction_PropertyAddress, SwapSteps_FunctionAddress, "DataprepAction");
		SwapSteps_DataprepAction_Offset = NativeReflectionCached.GetPropertyOffset(SwapSteps_FunctionAddress, "DataprepAction");
		SwapSteps_DataprepAction_IsValid = NativeReflectionCached.ValidatePropertyClass(SwapSteps_FunctionAddress, "DataprepAction", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SwapSteps_FirstIndex_PropertyAddress, SwapSteps_FunctionAddress, "FirstIndex");
		SwapSteps_FirstIndex_Offset = NativeReflectionCached.GetPropertyOffset(SwapSteps_FunctionAddress, "FirstIndex");
		SwapSteps_FirstIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SwapSteps_FunctionAddress, "FirstIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SwapSteps_SecondIndex_PropertyAddress, SwapSteps_FunctionAddress, "SecondIndex");
		SwapSteps_SecondIndex_Offset = NativeReflectionCached.GetPropertyOffset(SwapSteps_FunctionAddress, "SecondIndex");
		SwapSteps_SecondIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SwapSteps_FunctionAddress, "SecondIndex", Classes.FIntProperty);
		SwapSteps_IsValid = SwapSteps_FunctionAddress != IntPtr.Zero && SwapSteps_DataprepAction_IsValid && SwapSteps_FirstIndex_IsValid && SwapSteps_SecondIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:SwapSteps", SwapSteps_IsValid);
		SwapActions_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SwapActions");
		SwapActions_ParamsSize = NativeReflection.GetFunctionParamsSize(SwapActions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SwapActions_DataprepAsset_PropertyAddress, SwapActions_FunctionAddress, "DataprepAsset");
		SwapActions_DataprepAsset_Offset = NativeReflectionCached.GetPropertyOffset(SwapActions_FunctionAddress, "DataprepAsset");
		SwapActions_DataprepAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(SwapActions_FunctionAddress, "DataprepAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SwapActions_FirstActionIndex_PropertyAddress, SwapActions_FunctionAddress, "FirstActionIndex");
		SwapActions_FirstActionIndex_Offset = NativeReflectionCached.GetPropertyOffset(SwapActions_FunctionAddress, "FirstActionIndex");
		SwapActions_FirstActionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SwapActions_FunctionAddress, "FirstActionIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SwapActions_SecondActionIndex_PropertyAddress, SwapActions_FunctionAddress, "SecondActionIndex");
		SwapActions_SecondActionIndex_Offset = NativeReflectionCached.GetPropertyOffset(SwapActions_FunctionAddress, "SecondActionIndex");
		SwapActions_SecondActionIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SwapActions_FunctionAddress, "SecondActionIndex", Classes.FIntProperty);
		SwapActions_IsValid = SwapActions_FunctionAddress != IntPtr.Zero && SwapActions_DataprepAsset_IsValid && SwapActions_FirstActionIndex_IsValid && SwapActions_SecondActionIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:SwapActions", SwapActions_IsValid);
		RemoveStep_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveStep");
		RemoveStep_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveStep_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveStep_DataprepAction_PropertyAddress, RemoveStep_FunctionAddress, "DataprepAction");
		RemoveStep_DataprepAction_Offset = NativeReflectionCached.GetPropertyOffset(RemoveStep_FunctionAddress, "DataprepAction");
		RemoveStep_DataprepAction_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveStep_FunctionAddress, "DataprepAction", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveStep_Index_PropertyAddress, RemoveStep_FunctionAddress, "Index");
		RemoveStep_Index_Offset = NativeReflectionCached.GetPropertyOffset(RemoveStep_FunctionAddress, "Index");
		RemoveStep_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveStep_FunctionAddress, "Index", Classes.FIntProperty);
		RemoveStep_IsValid = RemoveStep_FunctionAddress != IntPtr.Zero && RemoveStep_DataprepAction_IsValid && RemoveStep_Index_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:RemoveStep", RemoveStep_IsValid);
		RemoveProducer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveProducer");
		RemoveProducer_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveProducer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveProducer_DataprepAssetInterface_PropertyAddress, RemoveProducer_FunctionAddress, "DataprepAssetInterface");
		RemoveProducer_DataprepAssetInterface_Offset = NativeReflectionCached.GetPropertyOffset(RemoveProducer_FunctionAddress, "DataprepAssetInterface");
		RemoveProducer_DataprepAssetInterface_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveProducer_FunctionAddress, "DataprepAssetInterface", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveProducer_Index_PropertyAddress, RemoveProducer_FunctionAddress, "Index");
		RemoveProducer_Index_Offset = NativeReflectionCached.GetPropertyOffset(RemoveProducer_FunctionAddress, "Index");
		RemoveProducer_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveProducer_FunctionAddress, "Index", Classes.FIntProperty);
		RemoveProducer_IsValid = RemoveProducer_FunctionAddress != IntPtr.Zero && RemoveProducer_DataprepAssetInterface_IsValid && RemoveProducer_Index_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:RemoveProducer", RemoveProducer_IsValid);
		RemoveAction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAction");
		RemoveAction_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAction_DataprepAsset_PropertyAddress, RemoveAction_FunctionAddress, "DataprepAsset");
		RemoveAction_DataprepAsset_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAction_FunctionAddress, "DataprepAsset");
		RemoveAction_DataprepAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAction_FunctionAddress, "DataprepAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAction_Index_PropertyAddress, RemoveAction_FunctionAddress, "Index");
		RemoveAction_Index_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAction_FunctionAddress, "Index");
		RemoveAction_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAction_FunctionAddress, "Index", Classes.FIntProperty);
		RemoveAction_IsValid = RemoveAction_FunctionAddress != IntPtr.Zero && RemoveAction_DataprepAsset_IsValid && RemoveAction_Index_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:RemoveAction", RemoveAction_IsValid);
		MoveStep_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MoveStep");
		MoveStep_ParamsSize = NativeReflection.GetFunctionParamsSize(MoveStep_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoveStep_DataprepAction_PropertyAddress, MoveStep_FunctionAddress, "DataprepAction");
		MoveStep_DataprepAction_Offset = NativeReflectionCached.GetPropertyOffset(MoveStep_FunctionAddress, "DataprepAction");
		MoveStep_DataprepAction_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveStep_FunctionAddress, "DataprepAction", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveStep_StepIndex_PropertyAddress, MoveStep_FunctionAddress, "StepIndex");
		MoveStep_StepIndex_Offset = NativeReflectionCached.GetPropertyOffset(MoveStep_FunctionAddress, "StepIndex");
		MoveStep_StepIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveStep_FunctionAddress, "StepIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveStep_DestinationIndex_PropertyAddress, MoveStep_FunctionAddress, "DestinationIndex");
		MoveStep_DestinationIndex_Offset = NativeReflectionCached.GetPropertyOffset(MoveStep_FunctionAddress, "DestinationIndex");
		MoveStep_DestinationIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveStep_FunctionAddress, "DestinationIndex", Classes.FIntProperty);
		MoveStep_IsValid = MoveStep_FunctionAddress != IntPtr.Zero && MoveStep_DataprepAction_IsValid && MoveStep_StepIndex_IsValid && MoveStep_DestinationIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:MoveStep", MoveStep_IsValid);
		GetStepsCount_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStepsCount");
		GetStepsCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStepsCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStepsCount_DataprepAction_PropertyAddress, GetStepsCount_FunctionAddress, "DataprepAction");
		GetStepsCount_DataprepAction_Offset = NativeReflectionCached.GetPropertyOffset(GetStepsCount_FunctionAddress, "DataprepAction");
		GetStepsCount_DataprepAction_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStepsCount_FunctionAddress, "DataprepAction", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStepsCount_ReturnValue_PropertyAddress, GetStepsCount_FunctionAddress, "ReturnValue");
		GetStepsCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStepsCount_FunctionAddress, "ReturnValue");
		GetStepsCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStepsCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetStepsCount_IsValid = GetStepsCount_FunctionAddress != IntPtr.Zero && GetStepsCount_DataprepAction_IsValid && GetStepsCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetStepsCount", GetStepsCount_IsValid);
		GetStepObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStepObject");
		GetStepObject_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStepObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStepObject_DataprepAction_PropertyAddress, GetStepObject_FunctionAddress, "DataprepAction");
		GetStepObject_DataprepAction_Offset = NativeReflectionCached.GetPropertyOffset(GetStepObject_FunctionAddress, "DataprepAction");
		GetStepObject_DataprepAction_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStepObject_FunctionAddress, "DataprepAction", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStepObject_Index_PropertyAddress, GetStepObject_FunctionAddress, "Index");
		GetStepObject_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetStepObject_FunctionAddress, "Index");
		GetStepObject_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStepObject_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStepObject_ReturnValue_PropertyAddress, GetStepObject_FunctionAddress, "ReturnValue");
		GetStepObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStepObject_FunctionAddress, "ReturnValue");
		GetStepObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStepObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetStepObject_IsValid = GetStepObject_FunctionAddress != IntPtr.Zero && GetStepObject_DataprepAction_IsValid && GetStepObject_Index_IsValid && GetStepObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetStepObject", GetStepObject_IsValid);
		GetProducersCount_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetProducersCount");
		GetProducersCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetProducersCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetProducersCount_DataprepAssetInterface_PropertyAddress, GetProducersCount_FunctionAddress, "DataprepAssetInterface");
		GetProducersCount_DataprepAssetInterface_Offset = NativeReflectionCached.GetPropertyOffset(GetProducersCount_FunctionAddress, "DataprepAssetInterface");
		GetProducersCount_DataprepAssetInterface_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProducersCount_FunctionAddress, "DataprepAssetInterface", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetProducersCount_ReturnValue_PropertyAddress, GetProducersCount_FunctionAddress, "ReturnValue");
		GetProducersCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetProducersCount_FunctionAddress, "ReturnValue");
		GetProducersCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProducersCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetProducersCount_IsValid = GetProducersCount_FunctionAddress != IntPtr.Zero && GetProducersCount_DataprepAssetInterface_IsValid && GetProducersCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetProducersCount", GetProducersCount_IsValid);
		GetProducer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetProducer");
		GetProducer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetProducer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetProducer_DataprepAssetInterface_PropertyAddress, GetProducer_FunctionAddress, "DataprepAssetInterface");
		GetProducer_DataprepAssetInterface_Offset = NativeReflectionCached.GetPropertyOffset(GetProducer_FunctionAddress, "DataprepAssetInterface");
		GetProducer_DataprepAssetInterface_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProducer_FunctionAddress, "DataprepAssetInterface", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetProducer_Index_PropertyAddress, GetProducer_FunctionAddress, "Index");
		GetProducer_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetProducer_FunctionAddress, "Index");
		GetProducer_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProducer_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetProducer_ReturnValue_PropertyAddress, GetProducer_FunctionAddress, "ReturnValue");
		GetProducer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetProducer_FunctionAddress, "ReturnValue");
		GetProducer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProducer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetProducer_IsValid = GetProducer_FunctionAddress != IntPtr.Zero && GetProducer_DataprepAssetInterface_IsValid && GetProducer_Index_IsValid && GetProducer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetProducer", GetProducer_IsValid);
		GetConsumer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetConsumer");
		GetConsumer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConsumer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConsumer_DataprepAssetInterface_PropertyAddress, GetConsumer_FunctionAddress, "DataprepAssetInterface");
		GetConsumer_DataprepAssetInterface_Offset = NativeReflectionCached.GetPropertyOffset(GetConsumer_FunctionAddress, "DataprepAssetInterface");
		GetConsumer_DataprepAssetInterface_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConsumer_FunctionAddress, "DataprepAssetInterface", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConsumer_ReturnValue_PropertyAddress, GetConsumer_FunctionAddress, "ReturnValue");
		GetConsumer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetConsumer_FunctionAddress, "ReturnValue");
		GetConsumer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConsumer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetConsumer_IsValid = GetConsumer_FunctionAddress != IntPtr.Zero && GetConsumer_DataprepAssetInterface_IsValid && GetConsumer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetConsumer", GetConsumer_IsValid);
		GetActionCount_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActionCount");
		GetActionCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActionCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActionCount_DataprepAsset_PropertyAddress, GetActionCount_FunctionAddress, "DataprepAsset");
		GetActionCount_DataprepAsset_Offset = NativeReflectionCached.GetPropertyOffset(GetActionCount_FunctionAddress, "DataprepAsset");
		GetActionCount_DataprepAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActionCount_FunctionAddress, "DataprepAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActionCount_ReturnValue_PropertyAddress, GetActionCount_FunctionAddress, "ReturnValue");
		GetActionCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActionCount_FunctionAddress, "ReturnValue");
		GetActionCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActionCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetActionCount_IsValid = GetActionCount_FunctionAddress != IntPtr.Zero && GetActionCount_DataprepAsset_IsValid && GetActionCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetActionCount", GetActionCount_IsValid);
		GetAction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAction");
		GetAction_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAction_DataprepAsset_PropertyAddress, GetAction_FunctionAddress, "DataprepAsset");
		GetAction_DataprepAsset_Offset = NativeReflectionCached.GetPropertyOffset(GetAction_FunctionAddress, "DataprepAsset");
		GetAction_DataprepAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAction_FunctionAddress, "DataprepAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAction_Index_PropertyAddress, GetAction_FunctionAddress, "Index");
		GetAction_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetAction_FunctionAddress, "Index");
		GetAction_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAction_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAction_ReturnValue_PropertyAddress, GetAction_FunctionAddress, "ReturnValue");
		GetAction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAction_FunctionAddress, "ReturnValue");
		GetAction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAction_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAction_IsValid = GetAction_FunctionAddress != IntPtr.Zero && GetAction_DataprepAsset_IsValid && GetAction_Index_IsValid && GetAction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:GetAction", GetAction_IsValid);
		ExecuteDataprep_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExecuteDataprep");
		ExecuteDataprep_ParamsSize = NativeReflection.GetFunctionParamsSize(ExecuteDataprep_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExecuteDataprep_DataprepAssetInterface_PropertyAddress, ExecuteDataprep_FunctionAddress, "DataprepAssetInterface");
		ExecuteDataprep_DataprepAssetInterface_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteDataprep_FunctionAddress, "DataprepAssetInterface");
		ExecuteDataprep_DataprepAssetInterface_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteDataprep_FunctionAddress, "DataprepAssetInterface", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExecuteDataprep_LogReportingMethod_PropertyAddress, ExecuteDataprep_FunctionAddress, "LogReportingMethod");
		ExecuteDataprep_LogReportingMethod_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteDataprep_FunctionAddress, "LogReportingMethod");
		ExecuteDataprep_LogReportingMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteDataprep_FunctionAddress, "LogReportingMethod", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ExecuteDataprep_ProgressReportingMethod_PropertyAddress, ExecuteDataprep_FunctionAddress, "ProgressReportingMethod");
		ExecuteDataprep_ProgressReportingMethod_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteDataprep_FunctionAddress, "ProgressReportingMethod");
		ExecuteDataprep_ProgressReportingMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteDataprep_FunctionAddress, "ProgressReportingMethod", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ExecuteDataprep_ReturnValue_PropertyAddress, ExecuteDataprep_FunctionAddress, "ReturnValue");
		ExecuteDataprep_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteDataprep_FunctionAddress, "ReturnValue");
		ExecuteDataprep_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteDataprep_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ExecuteDataprep_IsValid = ExecuteDataprep_FunctionAddress != IntPtr.Zero && ExecuteDataprep_DataprepAssetInterface_IsValid && ExecuteDataprep_LogReportingMethod_IsValid && ExecuteDataprep_ProgressReportingMethod_IsValid && ExecuteDataprep_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:ExecuteDataprep", ExecuteDataprep_IsValid);
		AddStepByDuplication_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddStepByDuplication");
		AddStepByDuplication_ParamsSize = NativeReflection.GetFunctionParamsSize(AddStepByDuplication_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddStepByDuplication_DataprepAction_PropertyAddress, AddStepByDuplication_FunctionAddress, "DataprepAction");
		AddStepByDuplication_DataprepAction_Offset = NativeReflectionCached.GetPropertyOffset(AddStepByDuplication_FunctionAddress, "DataprepAction");
		AddStepByDuplication_DataprepAction_IsValid = NativeReflectionCached.ValidatePropertyClass(AddStepByDuplication_FunctionAddress, "DataprepAction", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddStepByDuplication_StepObject_PropertyAddress, AddStepByDuplication_FunctionAddress, "StepObject");
		AddStepByDuplication_StepObject_Offset = NativeReflectionCached.GetPropertyOffset(AddStepByDuplication_FunctionAddress, "StepObject");
		AddStepByDuplication_StepObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddStepByDuplication_FunctionAddress, "StepObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddStepByDuplication_ReturnValue_PropertyAddress, AddStepByDuplication_FunctionAddress, "ReturnValue");
		AddStepByDuplication_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddStepByDuplication_FunctionAddress, "ReturnValue");
		AddStepByDuplication_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddStepByDuplication_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddStepByDuplication_IsValid = AddStepByDuplication_FunctionAddress != IntPtr.Zero && AddStepByDuplication_DataprepAction_IsValid && AddStepByDuplication_StepObject_IsValid && AddStepByDuplication_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:AddStepByDuplication", AddStepByDuplication_IsValid);
		AddStep_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddStep");
		AddStep_ParamsSize = NativeReflection.GetFunctionParamsSize(AddStep_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddStep_DataprepAction_PropertyAddress, AddStep_FunctionAddress, "DataprepAction");
		AddStep_DataprepAction_Offset = NativeReflectionCached.GetPropertyOffset(AddStep_FunctionAddress, "DataprepAction");
		AddStep_DataprepAction_IsValid = NativeReflectionCached.ValidatePropertyClass(AddStep_FunctionAddress, "DataprepAction", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddStep_StepType_PropertyAddress, AddStep_FunctionAddress, "StepType");
		AddStep_StepType_Offset = NativeReflectionCached.GetPropertyOffset(AddStep_FunctionAddress, "StepType");
		AddStep_StepType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddStep_FunctionAddress, "StepType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AddStep_ReturnValue_PropertyAddress, AddStep_FunctionAddress, "ReturnValue");
		AddStep_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddStep_FunctionAddress, "ReturnValue");
		AddStep_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddStep_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddStep_IsValid = AddStep_FunctionAddress != IntPtr.Zero && AddStep_DataprepAction_IsValid && AddStep_StepType_IsValid && AddStep_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:AddStep", AddStep_IsValid);
		AddProducerAutomated_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddProducerAutomated");
		AddProducerAutomated_ParamsSize = NativeReflection.GetFunctionParamsSize(AddProducerAutomated_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddProducerAutomated_DataprepAssetInterface_PropertyAddress, AddProducerAutomated_FunctionAddress, "DataprepAssetInterface");
		AddProducerAutomated_DataprepAssetInterface_Offset = NativeReflectionCached.GetPropertyOffset(AddProducerAutomated_FunctionAddress, "DataprepAssetInterface");
		AddProducerAutomated_DataprepAssetInterface_IsValid = NativeReflectionCached.ValidatePropertyClass(AddProducerAutomated_FunctionAddress, "DataprepAssetInterface", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddProducerAutomated_ProducerClass_PropertyAddress, AddProducerAutomated_FunctionAddress, "ProducerClass");
		AddProducerAutomated_ProducerClass_Offset = NativeReflectionCached.GetPropertyOffset(AddProducerAutomated_FunctionAddress, "ProducerClass");
		AddProducerAutomated_ProducerClass_IsValid = NativeReflectionCached.ValidatePropertyClass(AddProducerAutomated_FunctionAddress, "ProducerClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AddProducerAutomated_ReturnValue_PropertyAddress, AddProducerAutomated_FunctionAddress, "ReturnValue");
		AddProducerAutomated_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddProducerAutomated_FunctionAddress, "ReturnValue");
		AddProducerAutomated_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddProducerAutomated_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddProducerAutomated_IsValid = AddProducerAutomated_FunctionAddress != IntPtr.Zero && AddProducerAutomated_DataprepAssetInterface_IsValid && AddProducerAutomated_ProducerClass_IsValid && AddProducerAutomated_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:AddProducerAutomated", AddProducerAutomated_IsValid);
		AddProducer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddProducer");
		AddProducer_ParamsSize = NativeReflection.GetFunctionParamsSize(AddProducer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddProducer_DataprepAssetInterface_PropertyAddress, AddProducer_FunctionAddress, "DataprepAssetInterface");
		AddProducer_DataprepAssetInterface_Offset = NativeReflectionCached.GetPropertyOffset(AddProducer_FunctionAddress, "DataprepAssetInterface");
		AddProducer_DataprepAssetInterface_IsValid = NativeReflectionCached.ValidatePropertyClass(AddProducer_FunctionAddress, "DataprepAssetInterface", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddProducer_ProducerClass_PropertyAddress, AddProducer_FunctionAddress, "ProducerClass");
		AddProducer_ProducerClass_Offset = NativeReflectionCached.GetPropertyOffset(AddProducer_FunctionAddress, "ProducerClass");
		AddProducer_ProducerClass_IsValid = NativeReflectionCached.ValidatePropertyClass(AddProducer_FunctionAddress, "ProducerClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AddProducer_ReturnValue_PropertyAddress, AddProducer_FunctionAddress, "ReturnValue");
		AddProducer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddProducer_FunctionAddress, "ReturnValue");
		AddProducer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddProducer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddProducer_IsValid = AddProducer_FunctionAddress != IntPtr.Zero && AddProducer_DataprepAssetInterface_IsValid && AddProducer_ProducerClass_IsValid && AddProducer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:AddProducer", AddProducer_IsValid);
		AddActionByDuplication_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddActionByDuplication");
		AddActionByDuplication_ParamsSize = NativeReflection.GetFunctionParamsSize(AddActionByDuplication_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddActionByDuplication_DataprepAsset_PropertyAddress, AddActionByDuplication_FunctionAddress, "DataprepAsset");
		AddActionByDuplication_DataprepAsset_Offset = NativeReflectionCached.GetPropertyOffset(AddActionByDuplication_FunctionAddress, "DataprepAsset");
		AddActionByDuplication_DataprepAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActionByDuplication_FunctionAddress, "DataprepAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActionByDuplication_ActionToDuplicate_PropertyAddress, AddActionByDuplication_FunctionAddress, "ActionToDuplicate");
		AddActionByDuplication_ActionToDuplicate_Offset = NativeReflectionCached.GetPropertyOffset(AddActionByDuplication_FunctionAddress, "ActionToDuplicate");
		AddActionByDuplication_ActionToDuplicate_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActionByDuplication_FunctionAddress, "ActionToDuplicate", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddActionByDuplication_ReturnValue_PropertyAddress, AddActionByDuplication_FunctionAddress, "ReturnValue");
		AddActionByDuplication_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddActionByDuplication_FunctionAddress, "ReturnValue");
		AddActionByDuplication_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActionByDuplication_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddActionByDuplication_IsValid = AddActionByDuplication_FunctionAddress != IntPtr.Zero && AddActionByDuplication_DataprepAsset_IsValid && AddActionByDuplication_ActionToDuplicate_IsValid && AddActionByDuplication_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:AddActionByDuplication", AddActionByDuplication_IsValid);
		AddAction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddAction");
		AddAction_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAction_DataprepAsset_PropertyAddress, AddAction_FunctionAddress, "DataprepAsset");
		AddAction_DataprepAsset_Offset = NativeReflectionCached.GetPropertyOffset(AddAction_FunctionAddress, "DataprepAsset");
		AddAction_DataprepAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAction_FunctionAddress, "DataprepAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAction_ReturnValue_PropertyAddress, AddAction_FunctionAddress, "ReturnValue");
		AddAction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddAction_FunctionAddress, "ReturnValue");
		AddAction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAction_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddAction_IsValid = AddAction_FunctionAddress != IntPtr.Zero && AddAction_DataprepAsset_IsValid && AddAction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DataprepEditorScriptingUtilities.EditorDataprepAssetLibrary:AddAction", AddAction_IsValid);
	}
}
