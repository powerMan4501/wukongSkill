using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/PCG.PCGBlueprintElement", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGBlueprintElement : UObject
{
	private static bool IsCacheable_IsValid;

	private static FFieldAddress IsCacheable_PropertyAddress;

	private static int IsCacheable_Offset;

	private static bool ComputeFullDataCrc_IsValid;

	private static FFieldAddress ComputeFullDataCrc_PropertyAddress;

	private static int ComputeFullDataCrc_Offset;

	private static bool CanBeMultithreaded_IsValid;

	private static FFieldAddress CanBeMultithreaded_PropertyAddress;

	private static int CanBeMultithreaded_Offset;

	private static bool CustomInputPins_IsValid;

	private static FFieldAddress CustomInputPins_PropertyAddress;

	private static int CustomInputPins_Offset;

	private TArrayReadWriteMarshaler<FPCGPinProperties> CustomInputPins_MarshalerCached;

	private static bool CustomOutputPins_IsValid;

	private static FFieldAddress CustomOutputPins_PropertyAddress;

	private static int CustomOutputPins_Offset;

	private TArrayReadWriteMarshaler<FPCGPinProperties> CustomOutputPins_MarshalerCached;

	private static bool HasDefaultInPin_IsValid;

	private static FFieldAddress HasDefaultInPin_PropertyAddress;

	private static int HasDefaultInPin_Offset;

	private static bool HasDefaultOutPin_IsValid;

	private static FFieldAddress HasDefaultOutPin_PropertyAddress;

	private static int HasDefaultOutPin_Offset;

	private static bool ExposeToLibrary_IsValid;

	private static FFieldAddress ExposeToLibrary_PropertyAddress;

	private static int ExposeToLibrary_Offset;

	private static bool EnablePreconfiguredSettings_IsValid;

	private static FFieldAddress EnablePreconfiguredSettings_PropertyAddress;

	private static int EnablePreconfiguredSettings_Offset;

	private static bool OnlyExposePreconfiguredSettings_IsValid;

	private static FFieldAddress OnlyExposePreconfiguredSettings_PropertyAddress;

	private static int OnlyExposePreconfiguredSettings_Offset;

	private static bool PreconfiguredInfo_IsValid;

	private static FFieldAddress PreconfiguredInfo_PropertyAddress;

	private static int PreconfiguredInfo_Offset;

	private TArrayReadWriteMarshaler<FPCGPreConfiguredSettingsInfo> PreconfiguredInfo_MarshalerCached;

	private static bool Category_IsValid;

	private static int Category_Offset;

	private FText Category_TextCached;

	private static bool Description_IsValid;

	private static int Description_Offset;

	private FText Description_TextCached;

	private static bool DependencyParsingDepth_IsValid;

	private static int DependencyParsingDepth_Offset;

	private static bool VariableLoopBody_IsValid;

	private IntPtr VariableLoopBody_InstanceFunctionAddress;

	private static IntPtr VariableLoopBody_FunctionAddress;

	private static int VariableLoopBody_ParamsSize;

	private static bool VariableLoopBody_InContext_IsValid;

	private static FFieldAddress VariableLoopBody_InContext_PropertyAddress;

	private static int VariableLoopBody_InContext_Offset;

	private static bool VariableLoopBody_InData_IsValid;

	private static FFieldAddress VariableLoopBody_InData_PropertyAddress;

	private static int VariableLoopBody_InData_Offset;

	private static bool VariableLoopBody_InPoint_IsValid;

	private static FFieldAddress VariableLoopBody_InPoint_PropertyAddress;

	private static int VariableLoopBody_InPoint_Offset;

	private static bool VariableLoopBody_OutMetadata_IsValid;

	private static FFieldAddress VariableLoopBody_OutMetadata_PropertyAddress;

	private static int VariableLoopBody_OutMetadata_Offset;

	private static bool VariableLoopBody_ReturnValue_IsValid;

	private static FFieldAddress VariableLoopBody_ReturnValue_PropertyAddress;

	private static int VariableLoopBody_ReturnValue_Offset;

	private static bool VariableLoop_IsValid;

	private static IntPtr VariableLoop_FunctionAddress;

	private static int VariableLoop_ParamsSize;

	private static bool VariableLoop_InContext_IsValid;

	private static FFieldAddress VariableLoop_InContext_PropertyAddress;

	private static int VariableLoop_InContext_Offset;

	private static bool VariableLoop_InData_IsValid;

	private static FFieldAddress VariableLoop_InData_PropertyAddress;

	private static int VariableLoop_InData_Offset;

	private static bool VariableLoop_OutData_IsValid;

	private static FFieldAddress VariableLoop_OutData_PropertyAddress;

	private static int VariableLoop_OutData_Offset;

	private static bool VariableLoop_OptionalOutData_IsValid;

	private static FFieldAddress VariableLoop_OptionalOutData_PropertyAddress;

	private static int VariableLoop_OptionalOutData_Offset;

	private static bool PointLoopBody_IsValid;

	private IntPtr PointLoopBody_InstanceFunctionAddress;

	private static IntPtr PointLoopBody_FunctionAddress;

	private static int PointLoopBody_ParamsSize;

	private static bool PointLoopBody_InContext_IsValid;

	private static FFieldAddress PointLoopBody_InContext_PropertyAddress;

	private static int PointLoopBody_InContext_Offset;

	private static bool PointLoopBody_InData_IsValid;

	private static FFieldAddress PointLoopBody_InData_PropertyAddress;

	private static int PointLoopBody_InData_Offset;

	private static bool PointLoopBody_InPoint_IsValid;

	private static FFieldAddress PointLoopBody_InPoint_PropertyAddress;

	private static int PointLoopBody_InPoint_Offset;

	private static bool PointLoopBody_OutPoint_IsValid;

	private static FFieldAddress PointLoopBody_OutPoint_PropertyAddress;

	private static int PointLoopBody_OutPoint_Offset;

	private static bool PointLoopBody_OutMetadata_IsValid;

	private static FFieldAddress PointLoopBody_OutMetadata_PropertyAddress;

	private static int PointLoopBody_OutMetadata_Offset;

	private static bool PointLoopBody_ReturnValue_IsValid;

	private static FFieldAddress PointLoopBody_ReturnValue_PropertyAddress;

	private static int PointLoopBody_ReturnValue_Offset;

	private static bool PointLoop_IsValid;

	private static IntPtr PointLoop_FunctionAddress;

	private static int PointLoop_ParamsSize;

	private static bool PointLoop_InContext_IsValid;

	private static FFieldAddress PointLoop_InContext_PropertyAddress;

	private static int PointLoop_InContext_Offset;

	private static bool PointLoop_InData_IsValid;

	private static FFieldAddress PointLoop_InData_PropertyAddress;

	private static int PointLoop_InData_Offset;

	private static bool PointLoop_OutData_IsValid;

	private static FFieldAddress PointLoop_OutData_PropertyAddress;

	private static int PointLoop_OutData_Offset;

	private static bool PointLoop_OptionalOutData_IsValid;

	private static FFieldAddress PointLoop_OptionalOutData_PropertyAddress;

	private static int PointLoop_OptionalOutData_Offset;

	private static bool NodeTypeOverride_IsValid;

	private IntPtr NodeTypeOverride_InstanceFunctionAddress;

	private static IntPtr NodeTypeOverride_FunctionAddress;

	private static int NodeTypeOverride_ParamsSize;

	private static bool NodeTypeOverride_ReturnValue_IsValid;

	private static FFieldAddress NodeTypeOverride_ReturnValue_PropertyAddress;

	private static int NodeTypeOverride_ReturnValue_Offset;

	private static bool NodeTitleOverride_IsValid;

	private IntPtr NodeTitleOverride_InstanceFunctionAddress;

	private static IntPtr NodeTitleOverride_FunctionAddress;

	private static int NodeTitleOverride_ParamsSize;

	private static bool NodeTitleOverride_ReturnValue_IsValid;

	private static FFieldAddress NodeTitleOverride_ReturnValue_PropertyAddress;

	private static int NodeTitleOverride_ReturnValue_Offset;

	private static bool NodeColorOverride_IsValid;

	private IntPtr NodeColorOverride_InstanceFunctionAddress;

	private static IntPtr NodeColorOverride_FunctionAddress;

	private static int NodeColorOverride_ParamsSize;

	private static bool NodeColorOverride_ReturnValue_IsValid;

	private static FFieldAddress NodeColorOverride_ReturnValue_PropertyAddress;

	private static int NodeColorOverride_ReturnValue_Offset;

	private static bool NestedLoopBody_IsValid;

	private IntPtr NestedLoopBody_InstanceFunctionAddress;

	private static IntPtr NestedLoopBody_FunctionAddress;

	private static int NestedLoopBody_ParamsSize;

	private static bool NestedLoopBody_InContext_IsValid;

	private static FFieldAddress NestedLoopBody_InContext_PropertyAddress;

	private static int NestedLoopBody_InContext_Offset;

	private static bool NestedLoopBody_InOuterData_IsValid;

	private static FFieldAddress NestedLoopBody_InOuterData_PropertyAddress;

	private static int NestedLoopBody_InOuterData_Offset;

	private static bool NestedLoopBody_InInnerData_IsValid;

	private static FFieldAddress NestedLoopBody_InInnerData_PropertyAddress;

	private static int NestedLoopBody_InInnerData_Offset;

	private static bool NestedLoopBody_InOuterPoint_IsValid;

	private static FFieldAddress NestedLoopBody_InOuterPoint_PropertyAddress;

	private static int NestedLoopBody_InOuterPoint_Offset;

	private static bool NestedLoopBody_InInnerPoint_IsValid;

	private static FFieldAddress NestedLoopBody_InInnerPoint_PropertyAddress;

	private static int NestedLoopBody_InInnerPoint_Offset;

	private static bool NestedLoopBody_OutPoint_IsValid;

	private static FFieldAddress NestedLoopBody_OutPoint_PropertyAddress;

	private static int NestedLoopBody_OutPoint_Offset;

	private static bool NestedLoopBody_OutMetadata_IsValid;

	private static FFieldAddress NestedLoopBody_OutMetadata_PropertyAddress;

	private static int NestedLoopBody_OutMetadata_Offset;

	private static bool NestedLoopBody_ReturnValue_IsValid;

	private static FFieldAddress NestedLoopBody_ReturnValue_PropertyAddress;

	private static int NestedLoopBody_ReturnValue_Offset;

	private static bool NestedLoop_IsValid;

	private static IntPtr NestedLoop_FunctionAddress;

	private static int NestedLoop_ParamsSize;

	private static bool NestedLoop_InContext_IsValid;

	private static FFieldAddress NestedLoop_InContext_PropertyAddress;

	private static int NestedLoop_InContext_Offset;

	private static bool NestedLoop_InOuterData_IsValid;

	private static FFieldAddress NestedLoop_InOuterData_PropertyAddress;

	private static int NestedLoop_InOuterData_Offset;

	private static bool NestedLoop_InInnerData_IsValid;

	private static FFieldAddress NestedLoop_InInnerData_PropertyAddress;

	private static int NestedLoop_InInnerData_Offset;

	private static bool NestedLoop_OutData_IsValid;

	private static FFieldAddress NestedLoop_OutData_PropertyAddress;

	private static int NestedLoop_OutData_Offset;

	private static bool NestedLoop_OptionalOutData_IsValid;

	private static FFieldAddress NestedLoop_OptionalOutData_PropertyAddress;

	private static int NestedLoop_OptionalOutData_Offset;

	private static bool IterationLoopBody_IsValid;

	private IntPtr IterationLoopBody_InstanceFunctionAddress;

	private static IntPtr IterationLoopBody_FunctionAddress;

	private static int IterationLoopBody_ParamsSize;

	private static bool IterationLoopBody_InContext_IsValid;

	private static FFieldAddress IterationLoopBody_InContext_PropertyAddress;

	private static int IterationLoopBody_InContext_Offset;

	private static bool IterationLoopBody_Iteration_IsValid;

	private static FFieldAddress IterationLoopBody_Iteration_PropertyAddress;

	private static int IterationLoopBody_Iteration_Offset;

	private static bool IterationLoopBody_InA_IsValid;

	private static FFieldAddress IterationLoopBody_InA_PropertyAddress;

	private static int IterationLoopBody_InA_Offset;

	private static bool IterationLoopBody_InB_IsValid;

	private static FFieldAddress IterationLoopBody_InB_PropertyAddress;

	private static int IterationLoopBody_InB_Offset;

	private static bool IterationLoopBody_OutPoint_IsValid;

	private static FFieldAddress IterationLoopBody_OutPoint_PropertyAddress;

	private static int IterationLoopBody_OutPoint_Offset;

	private static bool IterationLoopBody_OutMetadata_IsValid;

	private static FFieldAddress IterationLoopBody_OutMetadata_PropertyAddress;

	private static int IterationLoopBody_OutMetadata_Offset;

	private static bool IterationLoopBody_ReturnValue_IsValid;

	private static FFieldAddress IterationLoopBody_ReturnValue_PropertyAddress;

	private static int IterationLoopBody_ReturnValue_Offset;

	private static bool IterationLoop_IsValid;

	private static IntPtr IterationLoop_FunctionAddress;

	private static int IterationLoop_ParamsSize;

	private static bool IterationLoop_InContext_IsValid;

	private static FFieldAddress IterationLoop_InContext_PropertyAddress;

	private static int IterationLoop_InContext_Offset;

	private static bool IterationLoop_NumIterations_IsValid;

	private static FFieldAddress IterationLoop_NumIterations_PropertyAddress;

	private static int IterationLoop_NumIterations_Offset;

	private static bool IterationLoop_OutData_IsValid;

	private static FFieldAddress IterationLoop_OutData_PropertyAddress;

	private static int IterationLoop_OutData_Offset;

	private static bool IterationLoop_OptionalA_IsValid;

	private static FFieldAddress IterationLoop_OptionalA_PropertyAddress;

	private static int IterationLoop_OptionalA_Offset;

	private static bool IterationLoop_OptionalB_IsValid;

	private static FFieldAddress IterationLoop_OptionalB_PropertyAddress;

	private static int IterationLoop_OptionalB_Offset;

	private static bool IterationLoop_OptionalOutData_IsValid;

	private static FFieldAddress IterationLoop_OptionalOutData_PropertyAddress;

	private static int IterationLoop_OptionalOutData_Offset;

	private static bool IsCacheableOverride_IsValid;

	private IntPtr IsCacheableOverride_InstanceFunctionAddress;

	private static IntPtr IsCacheableOverride_FunctionAddress;

	private static int IsCacheableOverride_ParamsSize;

	private static bool IsCacheableOverride_ReturnValue_IsValid;

	private static FFieldAddress IsCacheableOverride_ReturnValue_PropertyAddress;

	private static int IsCacheableOverride_ReturnValue_Offset;

	private static bool GetSeed_IsValid;

	private static IntPtr GetSeed_FunctionAddress;

	private static int GetSeed_ParamsSize;

	private static bool GetSeed_InContext_IsValid;

	private static FFieldAddress GetSeed_InContext_PropertyAddress;

	private static int GetSeed_InContext_Offset;

	private static bool GetSeed_ReturnValue_IsValid;

	private static FFieldAddress GetSeed_ReturnValue_PropertyAddress;

	private static int GetSeed_ReturnValue_Offset;

	private static bool GetRandomStream_IsValid;

	private static IntPtr GetRandomStream_FunctionAddress;

	private static int GetRandomStream_ParamsSize;

	private static bool GetRandomStream_InContext_IsValid;

	private static FFieldAddress GetRandomStream_InContext_PropertyAddress;

	private static int GetRandomStream_InContext_Offset;

	private static bool GetRandomStream_ReturnValue_IsValid;

	private static FFieldAddress GetRandomStream_ReturnValue_PropertyAddress;

	private static int GetRandomStream_ReturnValue_Offset;

	private static bool GetOutputPins_IsValid;

	private static IntPtr GetOutputPins_FunctionAddress;

	private static int GetOutputPins_ParamsSize;

	private static bool GetOutputPins_ReturnValue_IsValid;

	private static FFieldAddress GetOutputPins_ReturnValue_PropertyAddress;

	private static int GetOutputPins_ReturnValue_Offset;

	private static bool GetOutputPinByLabel_IsValid;

	private static IntPtr GetOutputPinByLabel_FunctionAddress;

	private static int GetOutputPinByLabel_ParamsSize;

	private static bool GetOutputPinByLabel_InPinLabel_IsValid;

	private static FFieldAddress GetOutputPinByLabel_InPinLabel_PropertyAddress;

	private static int GetOutputPinByLabel_InPinLabel_Offset;

	private static bool GetOutputPinByLabel_OutFoundPin_IsValid;

	private static FFieldAddress GetOutputPinByLabel_OutFoundPin_PropertyAddress;

	private static int GetOutputPinByLabel_OutFoundPin_Offset;

	private static bool GetOutputPinByLabel_ReturnValue_IsValid;

	private static FFieldAddress GetOutputPinByLabel_ReturnValue_PropertyAddress;

	private static int GetOutputPinByLabel_ReturnValue_Offset;

	private static bool GetInputPins_IsValid;

	private static IntPtr GetInputPins_FunctionAddress;

	private static int GetInputPins_ParamsSize;

	private static bool GetInputPins_ReturnValue_IsValid;

	private static FFieldAddress GetInputPins_ReturnValue_PropertyAddress;

	private static int GetInputPins_ReturnValue_Offset;

	private static bool GetInputPinByLabel_IsValid;

	private static IntPtr GetInputPinByLabel_FunctionAddress;

	private static int GetInputPinByLabel_ParamsSize;

	private static bool GetInputPinByLabel_InPinLabel_IsValid;

	private static FFieldAddress GetInputPinByLabel_InPinLabel_PropertyAddress;

	private static int GetInputPinByLabel_InPinLabel_Offset;

	private static bool GetInputPinByLabel_OutFoundPin_IsValid;

	private static FFieldAddress GetInputPinByLabel_OutFoundPin_PropertyAddress;

	private static int GetInputPinByLabel_OutFoundPin_Offset;

	private static bool GetInputPinByLabel_ReturnValue_IsValid;

	private static FFieldAddress GetInputPinByLabel_ReturnValue_PropertyAddress;

	private static int GetInputPinByLabel_ReturnValue_Offset;

	private static bool GetContext_IsValid;

	private static IntPtr GetContext_FunctionAddress;

	private static int GetContext_ParamsSize;

	private static bool GetContext_ReturnValue_IsValid;

	private static FFieldAddress GetContext_ReturnValue_PropertyAddress;

	private static int GetContext_ReturnValue_Offset;

	private static bool ExecuteWithContext_IsValid;

	private IntPtr ExecuteWithContext_InstanceFunctionAddress;

	private static IntPtr ExecuteWithContext_FunctionAddress;

	private static int ExecuteWithContext_ParamsSize;

	private static bool ExecuteWithContext_InContext_IsValid;

	private static FFieldAddress ExecuteWithContext_InContext_PropertyAddress;

	private static int ExecuteWithContext_InContext_Offset;

	private static bool ExecuteWithContext_Input_IsValid;

	private static FFieldAddress ExecuteWithContext_Input_PropertyAddress;

	private static int ExecuteWithContext_Input_Offset;

	private static bool ExecuteWithContext_Output_IsValid;

	private static FFieldAddress ExecuteWithContext_Output_PropertyAddress;

	private static int ExecuteWithContext_Output_Offset;

	private static bool Execute_IsValid;

	private IntPtr Execute_InstanceFunctionAddress;

	private static IntPtr Execute_FunctionAddress;

	private static int Execute_ParamsSize;

	private static bool Execute_Input_IsValid;

	private static FFieldAddress Execute_Input_PropertyAddress;

	private static int Execute_Input_Offset;

	private static bool Execute_Output_IsValid;

	private static FFieldAddress Execute_Output_PropertyAddress;

	private static int Execute_Output_Offset;

	private static bool CustomOutputLabels_IsValid;

	private static IntPtr CustomOutputLabels_FunctionAddress;

	private static int CustomOutputLabels_ParamsSize;

	private static bool CustomOutputLabels_ReturnValue_IsValid;

	private static FFieldAddress CustomOutputLabels_ReturnValue_PropertyAddress;

	private static int CustomOutputLabels_ReturnValue_Offset;

	private static bool CustomInputLabels_IsValid;

	private static IntPtr CustomInputLabels_FunctionAddress;

	private static int CustomInputLabels_ParamsSize;

	private static bool CustomInputLabels_ReturnValue_IsValid;

	private static FFieldAddress CustomInputLabels_ReturnValue_PropertyAddress;

	private static int CustomInputLabels_ReturnValue_Offset;

	private static bool ApplyPreconfiguredSettings_IsValid;

	private IntPtr ApplyPreconfiguredSettings_InstanceFunctionAddress;

	private static IntPtr ApplyPreconfiguredSettings_FunctionAddress;

	private static int ApplyPreconfiguredSettings_ParamsSize;

	private static bool ApplyPreconfiguredSettings_InPreconfigureInfo_IsValid;

	private static FFieldAddress ApplyPreconfiguredSettings_InPreconfigureInfo_PropertyAddress;

	private static int ApplyPreconfiguredSettings_InPreconfigureInfo_Offset;

	[UProperty(Flags = (PropFlags)6759867280851461uL)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:bIsCacheable")]
	protected bool IsCacheable
	{
		get
		{
			CheckDestroyed();
			if (!IsCacheable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:bIsCacheable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsCacheable_Offset), 0, IsCacheable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsCacheable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:bIsCacheable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsCacheable_Offset), 0, IsCacheable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280851461uL)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:bComputeFullDataCrc")]
	protected bool ComputeFullDataCrc
	{
		get
		{
			CheckDestroyed();
			if (!ComputeFullDataCrc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:bComputeFullDataCrc");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ComputeFullDataCrc_Offset), 0, ComputeFullDataCrc_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ComputeFullDataCrc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:bComputeFullDataCrc");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ComputeFullDataCrc_Offset), 0, ComputeFullDataCrc_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234340357uL)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:bCanBeMultithreaded")]
	protected bool CanBeMultithreaded
	{
		get
		{
			CheckDestroyed();
			if (!CanBeMultithreaded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:bCanBeMultithreaded");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanBeMultithreaded_Offset), 0, CanBeMultithreaded_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanBeMultithreaded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:bCanBeMultithreaded");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanBeMultithreaded_Offset), 0, CanBeMultithreaded_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627436549uL)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:CustomInputPins")]
	protected TArrayReadWrite<FPCGPinProperties> CustomInputPins
	{
		get
		{
			CheckDestroyed();
			if (!CustomInputPins_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:CustomInputPins");
				return null;
			}
			if (CustomInputPins_MarshalerCached == null)
			{
				CustomInputPins_MarshalerCached = new TArrayReadWriteMarshaler<FPCGPinProperties>(1, CustomInputPins_PropertyAddress, CachedMarshalingDelegates<FPCGPinProperties, FPCGPinProperties>.FromNative, CachedMarshalingDelegates<FPCGPinProperties, FPCGPinProperties>.ToNative);
			}
			return CustomInputPins_MarshalerCached.FromNative(IntPtr.Add(base.Address, CustomInputPins_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627436549uL)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:CustomOutputPins")]
	protected TArrayReadWrite<FPCGPinProperties> CustomOutputPins
	{
		get
		{
			CheckDestroyed();
			if (!CustomOutputPins_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:CustomOutputPins");
				return null;
			}
			if (CustomOutputPins_MarshalerCached == null)
			{
				CustomOutputPins_MarshalerCached = new TArrayReadWriteMarshaler<FPCGPinProperties>(1, CustomOutputPins_PropertyAddress, CachedMarshalingDelegates<FPCGPinProperties, FPCGPinProperties>.FromNative, CachedMarshalingDelegates<FPCGPinProperties, FPCGPinProperties>.ToNative);
			}
			return CustomOutputPins_MarshalerCached.FromNative(IntPtr.Add(base.Address, CustomOutputPins_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234340357uL)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:bHasDefaultInPin")]
	protected bool HasDefaultInPin
	{
		get
		{
			CheckDestroyed();
			if (!HasDefaultInPin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:bHasDefaultInPin");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HasDefaultInPin_Offset), 0, HasDefaultInPin_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HasDefaultInPin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:bHasDefaultInPin");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HasDefaultInPin_Offset), 0, HasDefaultInPin_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234340357uL)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:bHasDefaultOutPin")]
	protected bool HasDefaultOutPin
	{
		get
		{
			CheckDestroyed();
			if (!HasDefaultOutPin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:bHasDefaultOutPin");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HasDefaultOutPin_Offset), 0, HasDefaultOutPin_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HasDefaultOutPin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:bHasDefaultOutPin");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HasDefaultOutPin_Offset), 0, HasDefaultOutPin_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756603105706501uL)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:bExposeToLibrary")]
	protected bool ExposeToLibrary
	{
		get
		{
			CheckDestroyed();
			if (!ExposeToLibrary_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:bExposeToLibrary");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ExposeToLibrary_Offset), 0, ExposeToLibrary_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ExposeToLibrary_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:bExposeToLibrary");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ExposeToLibrary_Offset), 0, ExposeToLibrary_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756603105706501uL)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:bEnablePreconfiguredSettings")]
	protected bool EnablePreconfiguredSettings
	{
		get
		{
			CheckDestroyed();
			if (!EnablePreconfiguredSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:bEnablePreconfiguredSettings");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnablePreconfiguredSettings_Offset), 0, EnablePreconfiguredSettings_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnablePreconfiguredSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:bEnablePreconfiguredSettings");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnablePreconfiguredSettings_Offset), 0, EnablePreconfiguredSettings_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756603105706501uL)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:bOnlyExposePreconfiguredSettings")]
	protected bool OnlyExposePreconfiguredSettings
	{
		get
		{
			CheckDestroyed();
			if (!OnlyExposePreconfiguredSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:bOnlyExposePreconfiguredSettings");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OnlyExposePreconfiguredSettings_Offset), 0, OnlyExposePreconfiguredSettings_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OnlyExposePreconfiguredSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:bOnlyExposePreconfiguredSettings");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OnlyExposePreconfiguredSettings_Offset), 0, OnlyExposePreconfiguredSettings_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503633987174917uL)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:PreconfiguredInfo")]
	protected TArrayReadWrite<FPCGPreConfiguredSettingsInfo> PreconfiguredInfo
	{
		get
		{
			CheckDestroyed();
			if (!PreconfiguredInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:PreconfiguredInfo");
				return null;
			}
			if (PreconfiguredInfo_MarshalerCached == null)
			{
				PreconfiguredInfo_MarshalerCached = new TArrayReadWriteMarshaler<FPCGPreConfiguredSettingsInfo>(1, PreconfiguredInfo_PropertyAddress, CachedMarshalingDelegates<FPCGPreConfiguredSettingsInfo, FPCGPreConfiguredSettingsInfo>.FromNative, CachedMarshalingDelegates<FPCGPreConfiguredSettingsInfo, FPCGPreConfiguredSettingsInfo>.ToNative);
			}
			return PreconfiguredInfo_MarshalerCached.FromNative(IntPtr.Add(base.Address, PreconfiguredInfo_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4504733498802181uL)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:Category")]
	protected FText Category
	{
		get
		{
			CheckDestroyed();
			if (!Category_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:Category");
				return null;
			}
			if (Category_TextCached == null)
			{
				Category_TextCached = new FText(IntPtr.Add(base.Address, Category_Offset), createReference: false);
			}
			return Category_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!Category_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:Category");
				return;
			}
			if (Category_TextCached == null)
			{
				Category_TextCached = new FText(IntPtr.Add(base.Address, Category_Offset), createReference: false);
			}
			Category_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)4504733498802181uL)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:Description")]
	protected FText Description
	{
		get
		{
			CheckDestroyed();
			if (!Description_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:Description");
				return null;
			}
			if (Description_TextCached == null)
			{
				Description_TextCached = new FText(IntPtr.Add(base.Address, Description_Offset), createReference: false);
			}
			return Description_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!Description_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:Description");
				return;
			}
			if (Description_TextCached == null)
			{
				Description_TextCached = new FText(IntPtr.Add(base.Address, Description_Offset), createReference: false);
			}
			Description_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)6759901640589829uL)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:DependencyParsingDepth")]
	protected int DependencyParsingDepth
	{
		get
		{
			CheckDestroyed();
			if (!DependencyParsingDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:DependencyParsingDepth");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DependencyParsingDepth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DependencyParsingDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGBlueprintElement:DependencyParsingDepth");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DependencyParsingDepth_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:VariableLoopBody")]
	public unsafe List<FPCGPoint> VariableLoopBody(FPCGContext InContext, UPCGPointData InData, FPCGPoint InPoint, UPCGMetadata OutMetadata)
	{
		CheckDestroyed();
		if (!VariableLoopBody_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:VariableLoopBody");
			return null;
		}
		if (VariableLoopBody_InstanceFunctionAddress == IntPtr.Zero)
		{
			VariableLoopBody_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "VariableLoopBody");
		}
		byte* ptr = stackalloc byte[(int)(uint)(VariableLoopBody_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VariableLoopBody_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(VariableLoopBody_InContext_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, VariableLoopBody_InContext_Offset), 0, VariableLoopBody_InContext_PropertyAddress.Address, InContext);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, VariableLoopBody_InData_Offset), 0, VariableLoopBody_InData_PropertyAddress.Address, InData);
		NativeReflection.InitializeValue_InContainer(VariableLoopBody_InPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, VariableLoopBody_InPoint_Offset), 0, VariableLoopBody_InPoint_PropertyAddress.Address, InPoint);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, VariableLoopBody_OutMetadata_Offset), 0, VariableLoopBody_OutMetadata_PropertyAddress.Address, OutMetadata);
		NativeReflection.InvokeFunctionOptimized(base.Address, VariableLoopBody_InstanceFunctionAddress, intPtr, VariableLoopBody_ParamsSize);
		NativeReflection.DestroyValue_InContainer(VariableLoopBody_InContext_PropertyAddress.Address, intPtr);
		List<FPCGPoint> result = new TArrayCopyMarshaler<FPCGPoint>(1, VariableLoopBody_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FPCGPoint, FPCGPoint>.FromNative, CachedMarshalingDelegates<FPCGPoint, FPCGPoint>.ToNative).FromNative(IntPtr.Add(intPtr, VariableLoopBody_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(VariableLoopBody_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual List<FPCGPoint> VariableLoopBody_Implementation(FPCGContext InContext, UPCGPointData InData, FPCGPoint InPoint, UPCGMetadata OutMetadata)
	{
		CheckDestroyed();
		if (!VariableLoopBody_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:VariableLoopBody");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VariableLoopBody_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VariableLoopBody_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(VariableLoopBody_InContext_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, VariableLoopBody_InContext_Offset), 0, VariableLoopBody_InContext_PropertyAddress.Address, InContext);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, VariableLoopBody_InData_Offset), 0, VariableLoopBody_InData_PropertyAddress.Address, InData);
		NativeReflection.InitializeValue_InContainer(VariableLoopBody_InPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, VariableLoopBody_InPoint_Offset), 0, VariableLoopBody_InPoint_PropertyAddress.Address, InPoint);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, VariableLoopBody_OutMetadata_Offset), 0, VariableLoopBody_OutMetadata_PropertyAddress.Address, OutMetadata);
		NativeReflection.InvokeFunctionOptimized(base.Address, VariableLoopBody_FunctionAddress, intPtr, VariableLoopBody_ParamsSize);
		NativeReflection.DestroyValue_InContainer(VariableLoopBody_InContext_PropertyAddress.Address, intPtr);
		List<FPCGPoint> result = new TArrayCopyMarshaler<FPCGPoint>(1, VariableLoopBody_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FPCGPoint, FPCGPoint>.FromNative, CachedMarshalingDelegates<FPCGPoint, FPCGPoint>.ToNative).FromNative(IntPtr.Add(intPtr, VariableLoopBody_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(VariableLoopBody_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1145177089u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:VariableLoop")]
	public unsafe void VariableLoop(ref FPCGContext InContext, UPCGPointData InData, out UPCGPointData OutData, UPCGPointData OptionalOutData)
	{
		CheckDestroyed();
		if (!VariableLoop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:VariableLoop");
			OutData = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VariableLoop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VariableLoop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(VariableLoop_InContext_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, VariableLoop_InContext_Offset), 0, VariableLoop_InContext_PropertyAddress.Address, InContext);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, VariableLoop_InData_Offset), 0, VariableLoop_InData_PropertyAddress.Address, InData);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, VariableLoop_OptionalOutData_Offset), 0, VariableLoop_OptionalOutData_PropertyAddress.Address, OptionalOutData);
		NativeReflection.InvokeFunctionOptimized(base.Address, VariableLoop_FunctionAddress, intPtr, VariableLoop_ParamsSize);
		InContext = FPCGContext.FromNative(IntPtr.Add(intPtr, VariableLoop_InContext_Offset), 0, VariableLoop_InContext_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(VariableLoop_InContext_PropertyAddress.Address, intPtr);
		OutData = UObjectMarshaler<UPCGPointData>.FromNative(IntPtr.Add(intPtr, VariableLoop_OutData_Offset), 0, VariableLoop_OutData_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:PointLoopBody")]
	public unsafe bool PointLoopBody(FPCGContext InContext, UPCGPointData InData, FPCGPoint InPoint, out FPCGPoint OutPoint, UPCGMetadata OutMetadata)
	{
		CheckDestroyed();
		if (!PointLoopBody_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:PointLoopBody");
			OutPoint = default(FPCGPoint);
			return false;
		}
		if (PointLoopBody_InstanceFunctionAddress == IntPtr.Zero)
		{
			PointLoopBody_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PointLoopBody");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointLoopBody_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointLoopBody_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointLoopBody_InContext_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, PointLoopBody_InContext_Offset), 0, PointLoopBody_InContext_PropertyAddress.Address, InContext);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, PointLoopBody_InData_Offset), 0, PointLoopBody_InData_PropertyAddress.Address, InData);
		NativeReflection.InitializeValue_InContainer(PointLoopBody_InPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, PointLoopBody_InPoint_Offset), 0, PointLoopBody_InPoint_PropertyAddress.Address, InPoint);
		NativeReflection.InitializeValue_InContainer(PointLoopBody_OutPoint_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, PointLoopBody_OutMetadata_Offset), 0, PointLoopBody_OutMetadata_PropertyAddress.Address, OutMetadata);
		NativeReflection.InvokeFunctionOptimized(base.Address, PointLoopBody_InstanceFunctionAddress, intPtr, PointLoopBody_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointLoopBody_InContext_PropertyAddress.Address, intPtr);
		OutPoint = FPCGPoint.FromNative(IntPtr.Add(intPtr, PointLoopBody_OutPoint_Offset), 0, PointLoopBody_OutPoint_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PointLoopBody_ReturnValue_Offset), 0, PointLoopBody_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool PointLoopBody_Implementation(FPCGContext InContext, UPCGPointData InData, FPCGPoint InPoint, out FPCGPoint OutPoint, UPCGMetadata OutMetadata)
	{
		CheckDestroyed();
		if (!PointLoopBody_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:PointLoopBody");
			OutPoint = default(FPCGPoint);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointLoopBody_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointLoopBody_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointLoopBody_InContext_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, PointLoopBody_InContext_Offset), 0, PointLoopBody_InContext_PropertyAddress.Address, InContext);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, PointLoopBody_InData_Offset), 0, PointLoopBody_InData_PropertyAddress.Address, InData);
		NativeReflection.InitializeValue_InContainer(PointLoopBody_InPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, PointLoopBody_InPoint_Offset), 0, PointLoopBody_InPoint_PropertyAddress.Address, InPoint);
		NativeReflection.InitializeValue_InContainer(PointLoopBody_OutPoint_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, PointLoopBody_OutMetadata_Offset), 0, PointLoopBody_OutMetadata_PropertyAddress.Address, OutMetadata);
		NativeReflection.InvokeFunctionOptimized(base.Address, PointLoopBody_FunctionAddress, intPtr, PointLoopBody_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PointLoopBody_InContext_PropertyAddress.Address, intPtr);
		OutPoint = FPCGPoint.FromNative(IntPtr.Add(intPtr, PointLoopBody_OutPoint_Offset), 0, PointLoopBody_OutPoint_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PointLoopBody_ReturnValue_Offset), 0, PointLoopBody_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1145177089u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:PointLoop")]
	public unsafe void PointLoop(ref FPCGContext InContext, UPCGPointData InData, out UPCGPointData OutData, UPCGPointData OptionalOutData)
	{
		CheckDestroyed();
		if (!PointLoop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:PointLoop");
			OutData = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PointLoop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PointLoop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PointLoop_InContext_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, PointLoop_InContext_Offset), 0, PointLoop_InContext_PropertyAddress.Address, InContext);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, PointLoop_InData_Offset), 0, PointLoop_InData_PropertyAddress.Address, InData);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, PointLoop_OptionalOutData_Offset), 0, PointLoop_OptionalOutData_PropertyAddress.Address, OptionalOutData);
		NativeReflection.InvokeFunctionOptimized(base.Address, PointLoop_FunctionAddress, intPtr, PointLoop_ParamsSize);
		InContext = FPCGContext.FromNative(IntPtr.Add(intPtr, PointLoop_InContext_Offset), 0, PointLoop_InContext_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(PointLoop_InContext_PropertyAddress.Address, intPtr);
		OutData = UObjectMarshaler<UPCGPointData>.FromNative(IntPtr.Add(intPtr, PointLoop_OutData_Offset), 0, PointLoop_OutData_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:NodeTypeOverride")]
	public unsafe EPCGSettingsType NodeTypeOverride()
	{
		CheckDestroyed();
		if (!NodeTypeOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:NodeTypeOverride");
			return EPCGSettingsType.InputOutput;
		}
		if (NodeTypeOverride_InstanceFunctionAddress == IntPtr.Zero)
		{
			NodeTypeOverride_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "NodeTypeOverride");
		}
		byte* ptr = stackalloc byte[(int)(uint)(NodeTypeOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NodeTypeOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, NodeTypeOverride_InstanceFunctionAddress, intPtr, NodeTypeOverride_ParamsSize);
		return EnumMarshaler<EPCGSettingsType>.FromNative(IntPtr.Add(intPtr, NodeTypeOverride_ReturnValue_Offset), 0, NodeTypeOverride_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual EPCGSettingsType NodeTypeOverride_Implementation()
	{
		CheckDestroyed();
		if (!NodeTypeOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:NodeTypeOverride");
			return EPCGSettingsType.InputOutput;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NodeTypeOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NodeTypeOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, NodeTypeOverride_FunctionAddress, intPtr, NodeTypeOverride_ParamsSize);
		return EnumMarshaler<EPCGSettingsType>.FromNative(IntPtr.Add(intPtr, NodeTypeOverride_ReturnValue_Offset), 0, NodeTypeOverride_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:NodeTitleOverride")]
	public unsafe FName NodeTitleOverride()
	{
		CheckDestroyed();
		if (!NodeTitleOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:NodeTitleOverride");
			return default(FName);
		}
		if (NodeTitleOverride_InstanceFunctionAddress == IntPtr.Zero)
		{
			NodeTitleOverride_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "NodeTitleOverride");
		}
		byte* ptr = stackalloc byte[(int)(uint)(NodeTitleOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NodeTitleOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, NodeTitleOverride_InstanceFunctionAddress, intPtr, NodeTitleOverride_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, NodeTitleOverride_ReturnValue_Offset), 0, NodeTitleOverride_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual FName NodeTitleOverride_Implementation()
	{
		CheckDestroyed();
		if (!NodeTitleOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:NodeTitleOverride");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(NodeTitleOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NodeTitleOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, NodeTitleOverride_FunctionAddress, intPtr, NodeTitleOverride_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, NodeTitleOverride_ReturnValue_Offset), 0, NodeTitleOverride_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1216482304u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:NodeColorOverride")]
	public unsafe FLinearColor NodeColorOverride()
	{
		CheckDestroyed();
		if (!NodeColorOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:NodeColorOverride");
			return default(FLinearColor);
		}
		if (NodeColorOverride_InstanceFunctionAddress == IntPtr.Zero)
		{
			NodeColorOverride_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "NodeColorOverride");
		}
		byte* ptr = stackalloc byte[(int)(uint)(NodeColorOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NodeColorOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, NodeColorOverride_InstanceFunctionAddress, intPtr, NodeColorOverride_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, NodeColorOverride_ReturnValue_Offset), 0, NodeColorOverride_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual FLinearColor NodeColorOverride_Implementation()
	{
		CheckDestroyed();
		if (!NodeColorOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:NodeColorOverride");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(NodeColorOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NodeColorOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, NodeColorOverride_FunctionAddress, intPtr, NodeColorOverride_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, NodeColorOverride_ReturnValue_Offset), 0, NodeColorOverride_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:NestedLoopBody")]
	public unsafe bool NestedLoopBody(FPCGContext InContext, UPCGPointData InOuterData, UPCGPointData InInnerData, FPCGPoint InOuterPoint, FPCGPoint InInnerPoint, out FPCGPoint OutPoint, UPCGMetadata OutMetadata)
	{
		CheckDestroyed();
		if (!NestedLoopBody_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:NestedLoopBody");
			OutPoint = default(FPCGPoint);
			return false;
		}
		if (NestedLoopBody_InstanceFunctionAddress == IntPtr.Zero)
		{
			NestedLoopBody_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "NestedLoopBody");
		}
		byte* ptr = stackalloc byte[(int)(uint)(NestedLoopBody_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NestedLoopBody_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(NestedLoopBody_InContext_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, NestedLoopBody_InContext_Offset), 0, NestedLoopBody_InContext_PropertyAddress.Address, InContext);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, NestedLoopBody_InOuterData_Offset), 0, NestedLoopBody_InOuterData_PropertyAddress.Address, InOuterData);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, NestedLoopBody_InInnerData_Offset), 0, NestedLoopBody_InInnerData_PropertyAddress.Address, InInnerData);
		NativeReflection.InitializeValue_InContainer(NestedLoopBody_InOuterPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, NestedLoopBody_InOuterPoint_Offset), 0, NestedLoopBody_InOuterPoint_PropertyAddress.Address, InOuterPoint);
		NativeReflection.InitializeValue_InContainer(NestedLoopBody_InInnerPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, NestedLoopBody_InInnerPoint_Offset), 0, NestedLoopBody_InInnerPoint_PropertyAddress.Address, InInnerPoint);
		NativeReflection.InitializeValue_InContainer(NestedLoopBody_OutPoint_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, NestedLoopBody_OutMetadata_Offset), 0, NestedLoopBody_OutMetadata_PropertyAddress.Address, OutMetadata);
		NativeReflection.InvokeFunctionOptimized(base.Address, NestedLoopBody_InstanceFunctionAddress, intPtr, NestedLoopBody_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NestedLoopBody_InContext_PropertyAddress.Address, intPtr);
		OutPoint = FPCGPoint.FromNative(IntPtr.Add(intPtr, NestedLoopBody_OutPoint_Offset), 0, NestedLoopBody_OutPoint_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, NestedLoopBody_ReturnValue_Offset), 0, NestedLoopBody_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool NestedLoopBody_Implementation(FPCGContext InContext, UPCGPointData InOuterData, UPCGPointData InInnerData, FPCGPoint InOuterPoint, FPCGPoint InInnerPoint, out FPCGPoint OutPoint, UPCGMetadata OutMetadata)
	{
		CheckDestroyed();
		if (!NestedLoopBody_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:NestedLoopBody");
			OutPoint = default(FPCGPoint);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NestedLoopBody_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NestedLoopBody_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(NestedLoopBody_InContext_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, NestedLoopBody_InContext_Offset), 0, NestedLoopBody_InContext_PropertyAddress.Address, InContext);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, NestedLoopBody_InOuterData_Offset), 0, NestedLoopBody_InOuterData_PropertyAddress.Address, InOuterData);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, NestedLoopBody_InInnerData_Offset), 0, NestedLoopBody_InInnerData_PropertyAddress.Address, InInnerData);
		NativeReflection.InitializeValue_InContainer(NestedLoopBody_InOuterPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, NestedLoopBody_InOuterPoint_Offset), 0, NestedLoopBody_InOuterPoint_PropertyAddress.Address, InOuterPoint);
		NativeReflection.InitializeValue_InContainer(NestedLoopBody_InInnerPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, NestedLoopBody_InInnerPoint_Offset), 0, NestedLoopBody_InInnerPoint_PropertyAddress.Address, InInnerPoint);
		NativeReflection.InitializeValue_InContainer(NestedLoopBody_OutPoint_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, NestedLoopBody_OutMetadata_Offset), 0, NestedLoopBody_OutMetadata_PropertyAddress.Address, OutMetadata);
		NativeReflection.InvokeFunctionOptimized(base.Address, NestedLoopBody_FunctionAddress, intPtr, NestedLoopBody_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NestedLoopBody_InContext_PropertyAddress.Address, intPtr);
		OutPoint = FPCGPoint.FromNative(IntPtr.Add(intPtr, NestedLoopBody_OutPoint_Offset), 0, NestedLoopBody_OutPoint_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, NestedLoopBody_ReturnValue_Offset), 0, NestedLoopBody_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1145177089u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:NestedLoop")]
	public unsafe void NestedLoop(ref FPCGContext InContext, UPCGPointData InOuterData, UPCGPointData InInnerData, out UPCGPointData OutData, UPCGPointData OptionalOutData)
	{
		CheckDestroyed();
		if (!NestedLoop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:NestedLoop");
			OutData = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NestedLoop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NestedLoop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(NestedLoop_InContext_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, NestedLoop_InContext_Offset), 0, NestedLoop_InContext_PropertyAddress.Address, InContext);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, NestedLoop_InOuterData_Offset), 0, NestedLoop_InOuterData_PropertyAddress.Address, InOuterData);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, NestedLoop_InInnerData_Offset), 0, NestedLoop_InInnerData_PropertyAddress.Address, InInnerData);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, NestedLoop_OptionalOutData_Offset), 0, NestedLoop_OptionalOutData_PropertyAddress.Address, OptionalOutData);
		NativeReflection.InvokeFunctionOptimized(base.Address, NestedLoop_FunctionAddress, intPtr, NestedLoop_ParamsSize);
		InContext = FPCGContext.FromNative(IntPtr.Add(intPtr, NestedLoop_InContext_Offset), 0, NestedLoop_InContext_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(NestedLoop_InContext_PropertyAddress.Address, intPtr);
		OutData = UObjectMarshaler<UPCGPointData>.FromNative(IntPtr.Add(intPtr, NestedLoop_OutData_Offset), 0, NestedLoop_OutData_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:IterationLoopBody")]
	public unsafe bool IterationLoopBody(FPCGContext InContext, long Iteration, UPCGSpatialData InA, UPCGSpatialData InB, out FPCGPoint OutPoint, UPCGMetadata OutMetadata)
	{
		CheckDestroyed();
		if (!IterationLoopBody_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:IterationLoopBody");
			OutPoint = default(FPCGPoint);
			return false;
		}
		if (IterationLoopBody_InstanceFunctionAddress == IntPtr.Zero)
		{
			IterationLoopBody_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IterationLoopBody");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IterationLoopBody_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IterationLoopBody_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IterationLoopBody_InContext_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, IterationLoopBody_InContext_Offset), 0, IterationLoopBody_InContext_PropertyAddress.Address, InContext);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, IterationLoopBody_Iteration_Offset), 0, IterationLoopBody_Iteration_PropertyAddress.Address, Iteration);
		UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(intPtr, IterationLoopBody_InA_Offset), 0, IterationLoopBody_InA_PropertyAddress.Address, InA);
		UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(intPtr, IterationLoopBody_InB_Offset), 0, IterationLoopBody_InB_PropertyAddress.Address, InB);
		NativeReflection.InitializeValue_InContainer(IterationLoopBody_OutPoint_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, IterationLoopBody_OutMetadata_Offset), 0, IterationLoopBody_OutMetadata_PropertyAddress.Address, OutMetadata);
		NativeReflection.InvokeFunctionOptimized(base.Address, IterationLoopBody_InstanceFunctionAddress, intPtr, IterationLoopBody_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IterationLoopBody_InContext_PropertyAddress.Address, intPtr);
		OutPoint = FPCGPoint.FromNative(IntPtr.Add(intPtr, IterationLoopBody_OutPoint_Offset), 0, IterationLoopBody_OutPoint_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IterationLoopBody_ReturnValue_Offset), 0, IterationLoopBody_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IterationLoopBody_Implementation(FPCGContext InContext, long Iteration, UPCGSpatialData InA, UPCGSpatialData InB, out FPCGPoint OutPoint, UPCGMetadata OutMetadata)
	{
		CheckDestroyed();
		if (!IterationLoopBody_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:IterationLoopBody");
			OutPoint = default(FPCGPoint);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IterationLoopBody_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IterationLoopBody_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IterationLoopBody_InContext_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, IterationLoopBody_InContext_Offset), 0, IterationLoopBody_InContext_PropertyAddress.Address, InContext);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, IterationLoopBody_Iteration_Offset), 0, IterationLoopBody_Iteration_PropertyAddress.Address, Iteration);
		UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(intPtr, IterationLoopBody_InA_Offset), 0, IterationLoopBody_InA_PropertyAddress.Address, InA);
		UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(intPtr, IterationLoopBody_InB_Offset), 0, IterationLoopBody_InB_PropertyAddress.Address, InB);
		NativeReflection.InitializeValue_InContainer(IterationLoopBody_OutPoint_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, IterationLoopBody_OutMetadata_Offset), 0, IterationLoopBody_OutMetadata_PropertyAddress.Address, OutMetadata);
		NativeReflection.InvokeFunctionOptimized(base.Address, IterationLoopBody_FunctionAddress, intPtr, IterationLoopBody_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IterationLoopBody_InContext_PropertyAddress.Address, intPtr);
		OutPoint = FPCGPoint.FromNative(IntPtr.Add(intPtr, IterationLoopBody_OutPoint_Offset), 0, IterationLoopBody_OutPoint_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IterationLoopBody_ReturnValue_Offset), 0, IterationLoopBody_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1145177089u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:IterationLoop")]
	public unsafe void IterationLoop(ref FPCGContext InContext, long NumIterations, out UPCGPointData OutData, UPCGSpatialData OptionalA, UPCGSpatialData OptionalB, UPCGPointData OptionalOutData)
	{
		CheckDestroyed();
		if (!IterationLoop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:IterationLoop");
			OutData = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IterationLoop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IterationLoop_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IterationLoop_InContext_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, IterationLoop_InContext_Offset), 0, IterationLoop_InContext_PropertyAddress.Address, InContext);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, IterationLoop_NumIterations_Offset), 0, IterationLoop_NumIterations_PropertyAddress.Address, NumIterations);
		UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(intPtr, IterationLoop_OptionalA_Offset), 0, IterationLoop_OptionalA_PropertyAddress.Address, OptionalA);
		UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(intPtr, IterationLoop_OptionalB_Offset), 0, IterationLoop_OptionalB_PropertyAddress.Address, OptionalB);
		UObjectMarshaler<UPCGPointData>.ToNative(IntPtr.Add(intPtr, IterationLoop_OptionalOutData_Offset), 0, IterationLoop_OptionalOutData_PropertyAddress.Address, OptionalOutData);
		NativeReflection.InvokeFunctionOptimized(base.Address, IterationLoop_FunctionAddress, intPtr, IterationLoop_ParamsSize);
		InContext = FPCGContext.FromNative(IntPtr.Add(intPtr, IterationLoop_InContext_Offset), 0, IterationLoop_InContext_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(IterationLoop_InContext_PropertyAddress.Address, intPtr);
		OutData = UObjectMarshaler<UPCGPointData>.FromNative(IntPtr.Add(intPtr, IterationLoop_OutData_Offset), 0, IterationLoop_OutData_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:IsCacheableOverride")]
	public unsafe bool IsCacheableOverride()
	{
		CheckDestroyed();
		if (!IsCacheableOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:IsCacheableOverride");
			return false;
		}
		if (IsCacheableOverride_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsCacheableOverride_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsCacheableOverride");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCacheableOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCacheableOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsCacheableOverride_InstanceFunctionAddress, intPtr, IsCacheableOverride_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCacheableOverride_ReturnValue_Offset), 0, IsCacheableOverride_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsCacheableOverride_Implementation()
	{
		CheckDestroyed();
		if (!IsCacheableOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:IsCacheableOverride");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCacheableOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCacheableOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsCacheableOverride_FunctionAddress, intPtr, IsCacheableOverride_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCacheableOverride_ReturnValue_Offset), 0, IsCacheableOverride_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:GetSeed")]
	public unsafe int GetSeed(ref FPCGContext InContext)
	{
		CheckDestroyed();
		if (!GetSeed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:GetSeed");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSeed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSeed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetSeed_InContext_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, GetSeed_InContext_Offset), 0, GetSeed_InContext_PropertyAddress.Address, InContext);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSeed_FunctionAddress, intPtr, GetSeed_ParamsSize);
		InContext = FPCGContext.FromNative(IntPtr.Add(intPtr, GetSeed_InContext_Offset), 0, GetSeed_InContext_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSeed_InContext_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSeed_ReturnValue_Offset), 0, GetSeed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1153565697u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:GetRandomStream")]
	public unsafe FRandomStream GetRandomStream(ref FPCGContext InContext)
	{
		CheckDestroyed();
		if (!GetRandomStream_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:GetRandomStream");
			return default(FRandomStream);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRandomStream_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRandomStream_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetRandomStream_InContext_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, GetRandomStream_InContext_Offset), 0, GetRandomStream_InContext_PropertyAddress.Address, InContext);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRandomStream_FunctionAddress, intPtr, GetRandomStream_ParamsSize);
		InContext = FPCGContext.FromNative(IntPtr.Add(intPtr, GetRandomStream_InContext_Offset), 0, GetRandomStream_InContext_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetRandomStream_InContext_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FRandomStream>.FromNative(IntPtr.Add(intPtr, GetRandomStream_ReturnValue_Offset), 0, GetRandomStream_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:GetOutputPins")]
	public unsafe List<FPCGPinProperties> GetOutputPins()
	{
		CheckDestroyed();
		if (!GetOutputPins_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:GetOutputPins");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOutputPins_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOutputPins_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOutputPins_FunctionAddress, intPtr, GetOutputPins_ParamsSize);
		List<FPCGPinProperties> result = new TArrayCopyMarshaler<FPCGPinProperties>(1, GetOutputPins_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FPCGPinProperties, FPCGPinProperties>.FromNative, CachedMarshalingDelegates<FPCGPinProperties, FPCGPinProperties>.ToNative).FromNative(IntPtr.Add(intPtr, GetOutputPins_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetOutputPins_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:GetOutputPinByLabel")]
	public unsafe bool GetOutputPinByLabel(FName InPinLabel, out FPCGPinProperties OutFoundPin)
	{
		CheckDestroyed();
		if (!GetOutputPinByLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:GetOutputPinByLabel");
			OutFoundPin = default(FPCGPinProperties);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOutputPinByLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOutputPinByLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetOutputPinByLabel_InPinLabel_Offset), 0, GetOutputPinByLabel_InPinLabel_PropertyAddress.Address, InPinLabel);
		NativeReflection.InitializeValue_InContainer(GetOutputPinByLabel_OutFoundPin_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOutputPinByLabel_FunctionAddress, intPtr, GetOutputPinByLabel_ParamsSize);
		OutFoundPin = FPCGPinProperties.FromNative(IntPtr.Add(intPtr, GetOutputPinByLabel_OutFoundPin_Offset), 0, GetOutputPinByLabel_OutFoundPin_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetOutputPinByLabel_OutFoundPin_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetOutputPinByLabel_ReturnValue_Offset), 0, GetOutputPinByLabel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:GetInputPins")]
	public unsafe List<FPCGPinProperties> GetInputPins()
	{
		CheckDestroyed();
		if (!GetInputPins_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:GetInputPins");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputPins_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputPins_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInputPins_FunctionAddress, intPtr, GetInputPins_ParamsSize);
		List<FPCGPinProperties> result = new TArrayCopyMarshaler<FPCGPinProperties>(1, GetInputPins_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FPCGPinProperties, FPCGPinProperties>.FromNative, CachedMarshalingDelegates<FPCGPinProperties, FPCGPinProperties>.ToNative).FromNative(IntPtr.Add(intPtr, GetInputPins_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetInputPins_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:GetInputPinByLabel")]
	public unsafe bool GetInputPinByLabel(FName InPinLabel, out FPCGPinProperties OutFoundPin)
	{
		CheckDestroyed();
		if (!GetInputPinByLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:GetInputPinByLabel");
			OutFoundPin = default(FPCGPinProperties);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputPinByLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputPinByLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetInputPinByLabel_InPinLabel_Offset), 0, GetInputPinByLabel_InPinLabel_PropertyAddress.Address, InPinLabel);
		NativeReflection.InitializeValue_InContainer(GetInputPinByLabel_OutFoundPin_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInputPinByLabel_FunctionAddress, intPtr, GetInputPinByLabel_ParamsSize);
		OutFoundPin = FPCGPinProperties.FromNative(IntPtr.Add(intPtr, GetInputPinByLabel_OutFoundPin_Offset), 0, GetInputPinByLabel_OutFoundPin_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetInputPinByLabel_OutFoundPin_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetInputPinByLabel_ReturnValue_Offset), 0, GetInputPinByLabel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:GetContext")]
	public unsafe FPCGContext GetContext()
	{
		CheckDestroyed();
		if (!GetContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:GetContext");
			return default(FPCGContext);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetContext_FunctionAddress, intPtr, GetContext_ParamsSize);
		FPCGContext result = FPCGContext.FromNative(IntPtr.Add(intPtr, GetContext_ReturnValue_Offset), 0, GetContext_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetContext_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 138546176u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:ExecuteWithContext")]
	public unsafe void ExecuteWithContext(ref FPCGContext InContext, FPCGDataCollection Input, out FPCGDataCollection Output)
	{
		CheckDestroyed();
		if (!ExecuteWithContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:ExecuteWithContext");
			Output = default(FPCGDataCollection);
			return;
		}
		if (ExecuteWithContext_InstanceFunctionAddress == IntPtr.Zero)
		{
			ExecuteWithContext_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ExecuteWithContext");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExecuteWithContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExecuteWithContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ExecuteWithContext_InContext_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, ExecuteWithContext_InContext_Offset), 0, ExecuteWithContext_InContext_PropertyAddress.Address, InContext);
		NativeReflection.InitializeValue_InContainer(ExecuteWithContext_Input_PropertyAddress.Address, intPtr);
		FPCGDataCollection.ToNative(IntPtr.Add(intPtr, ExecuteWithContext_Input_Offset), 0, ExecuteWithContext_Input_PropertyAddress.Address, Input);
		NativeReflection.InitializeValue_InContainer(ExecuteWithContext_Output_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExecuteWithContext_InstanceFunctionAddress, intPtr, ExecuteWithContext_ParamsSize);
		InContext = FPCGContext.FromNative(IntPtr.Add(intPtr, ExecuteWithContext_InContext_Offset), 0, ExecuteWithContext_InContext_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ExecuteWithContext_InContext_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ExecuteWithContext_Input_PropertyAddress.Address, intPtr);
		Output = FPCGDataCollection.FromNative(IntPtr.Add(intPtr, ExecuteWithContext_Output_Offset), 0, ExecuteWithContext_Output_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ExecuteWithContext_Output_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void ExecuteWithContext_Implementation(ref FPCGContext InContext, FPCGDataCollection Input, out FPCGDataCollection Output)
	{
		CheckDestroyed();
		if (!ExecuteWithContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:ExecuteWithContext");
			Output = default(FPCGDataCollection);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExecuteWithContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExecuteWithContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ExecuteWithContext_InContext_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, ExecuteWithContext_InContext_Offset), 0, ExecuteWithContext_InContext_PropertyAddress.Address, InContext);
		NativeReflection.InitializeValue_InContainer(ExecuteWithContext_Input_PropertyAddress.Address, intPtr);
		FPCGDataCollection.ToNative(IntPtr.Add(intPtr, ExecuteWithContext_Input_Offset), 0, ExecuteWithContext_Input_PropertyAddress.Address, Input);
		NativeReflection.InitializeValue_InContainer(ExecuteWithContext_Output_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExecuteWithContext_FunctionAddress, intPtr, ExecuteWithContext_ParamsSize);
		InContext = FPCGContext.FromNative(IntPtr.Add(intPtr, ExecuteWithContext_InContext_Offset), 0, ExecuteWithContext_InContext_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ExecuteWithContext_InContext_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ExecuteWithContext_Input_PropertyAddress.Address, intPtr);
		Output = FPCGDataCollection.FromNative(IntPtr.Add(intPtr, ExecuteWithContext_Output_Offset), 0, ExecuteWithContext_Output_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ExecuteWithContext_Output_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 205654016u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:Execute")]
	public unsafe void Execute(FPCGDataCollection Input, out FPCGDataCollection Output)
	{
		CheckDestroyed();
		if (!Execute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:Execute");
			Output = default(FPCGDataCollection);
			return;
		}
		if (Execute_InstanceFunctionAddress == IntPtr.Zero)
		{
			Execute_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Execute");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Execute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Execute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Execute_Input_PropertyAddress.Address, intPtr);
		FPCGDataCollection.ToNative(IntPtr.Add(intPtr, Execute_Input_Offset), 0, Execute_Input_PropertyAddress.Address, Input);
		NativeReflection.InitializeValue_InContainer(Execute_Output_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, Execute_InstanceFunctionAddress, intPtr, Execute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Execute_Input_PropertyAddress.Address, intPtr);
		Output = FPCGDataCollection.FromNative(IntPtr.Add(intPtr, Execute_Output_Offset), 0, Execute_Output_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Execute_Output_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void Execute_Implementation(FPCGDataCollection Input, out FPCGDataCollection Output)
	{
		CheckDestroyed();
		if (!Execute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:Execute");
			Output = default(FPCGDataCollection);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Execute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Execute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Execute_Input_PropertyAddress.Address, intPtr);
		FPCGDataCollection.ToNative(IntPtr.Add(intPtr, Execute_Input_Offset), 0, Execute_Input_PropertyAddress.Address, Input);
		NativeReflection.InitializeValue_InContainer(Execute_Output_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, Execute_FunctionAddress, intPtr, Execute_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Execute_Input_PropertyAddress.Address, intPtr);
		Output = FPCGDataCollection.FromNative(IntPtr.Add(intPtr, Execute_Output_Offset), 0, Execute_Output_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Execute_Output_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:CustomOutputLabels")]
	public unsafe HashSet<FName> CustomOutputLabels()
	{
		CheckDestroyed();
		if (!CustomOutputLabels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:CustomOutputLabels");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CustomOutputLabels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CustomOutputLabels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CustomOutputLabels_FunctionAddress, intPtr, CustomOutputLabels_ParamsSize);
		HashSet<FName> result = new TSetCopyMarshaler<FName>(1, CustomOutputLabels_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, CustomOutputLabels_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(CustomOutputLabels_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:CustomInputLabels")]
	public unsafe HashSet<FName> CustomInputLabels()
	{
		CheckDestroyed();
		if (!CustomInputLabels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:CustomInputLabels");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CustomInputLabels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CustomInputLabels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CustomInputLabels_FunctionAddress, intPtr, CustomInputLabels_ParamsSize);
		HashSet<FName> result = new TSetCopyMarshaler<FName>(1, CustomInputLabels_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, CustomInputLabels_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(CustomInputLabels_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/PCG.PCGBlueprintElement:ApplyPreconfiguredSettings")]
	public unsafe void ApplyPreconfiguredSettings(FPCGPreConfiguredSettingsInfo InPreconfigureInfo)
	{
		CheckDestroyed();
		if (!ApplyPreconfiguredSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:ApplyPreconfiguredSettings");
			return;
		}
		if (ApplyPreconfiguredSettings_InstanceFunctionAddress == IntPtr.Zero)
		{
			ApplyPreconfiguredSettings_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ApplyPreconfiguredSettings");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyPreconfiguredSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyPreconfiguredSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ApplyPreconfiguredSettings_InPreconfigureInfo_PropertyAddress.Address, intPtr);
		FPCGPreConfiguredSettingsInfo.ToNative(IntPtr.Add(intPtr, ApplyPreconfiguredSettings_InPreconfigureInfo_Offset), 0, ApplyPreconfiguredSettings_InPreconfigureInfo_PropertyAddress.Address, InPreconfigureInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyPreconfiguredSettings_InstanceFunctionAddress, intPtr, ApplyPreconfiguredSettings_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ApplyPreconfiguredSettings_InPreconfigureInfo_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void ApplyPreconfiguredSettings_Implementation(FPCGPreConfiguredSettingsInfo InPreconfigureInfo)
	{
		CheckDestroyed();
		if (!ApplyPreconfiguredSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintElement:ApplyPreconfiguredSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyPreconfiguredSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyPreconfiguredSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ApplyPreconfiguredSettings_InPreconfigureInfo_PropertyAddress.Address, intPtr);
		FPCGPreConfiguredSettingsInfo.ToNative(IntPtr.Add(intPtr, ApplyPreconfiguredSettings_InPreconfigureInfo_Offset), 0, ApplyPreconfiguredSettings_InPreconfigureInfo_PropertyAddress.Address, InPreconfigureInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyPreconfiguredSettings_FunctionAddress, intPtr, ApplyPreconfiguredSettings_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ApplyPreconfiguredSettings_InPreconfigureInfo_PropertyAddress.Address, intPtr);
	}

	static UPCGBlueprintElement()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGBlueprintElement)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGBlueprintElement));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/PCG.PCGBlueprintElement");
		NativeReflectionCached.GetPropertyRef(ref IsCacheable_PropertyAddress, intPtr, "bIsCacheable");
		IsCacheable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsCacheable");
		IsCacheable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsCacheable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeFullDataCrc_PropertyAddress, intPtr, "bComputeFullDataCrc");
		ComputeFullDataCrc_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bComputeFullDataCrc");
		ComputeFullDataCrc_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bComputeFullDataCrc", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanBeMultithreaded_PropertyAddress, intPtr, "bCanBeMultithreaded");
		CanBeMultithreaded_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanBeMultithreaded");
		CanBeMultithreaded_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanBeMultithreaded", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CustomInputPins_PropertyAddress, intPtr, "CustomInputPins");
		CustomInputPins_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomInputPins");
		CustomInputPins_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomInputPins", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CustomOutputPins_PropertyAddress, intPtr, "CustomOutputPins");
		CustomOutputPins_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomOutputPins");
		CustomOutputPins_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomOutputPins", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref HasDefaultInPin_PropertyAddress, intPtr, "bHasDefaultInPin");
		HasDefaultInPin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHasDefaultInPin");
		HasDefaultInPin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHasDefaultInPin", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HasDefaultOutPin_PropertyAddress, intPtr, "bHasDefaultOutPin");
		HasDefaultOutPin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHasDefaultOutPin");
		HasDefaultOutPin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHasDefaultOutPin", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExposeToLibrary_PropertyAddress, intPtr, "bExposeToLibrary");
		ExposeToLibrary_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bExposeToLibrary");
		ExposeToLibrary_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bExposeToLibrary", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnablePreconfiguredSettings_PropertyAddress, intPtr, "bEnablePreconfiguredSettings");
		EnablePreconfiguredSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnablePreconfiguredSettings");
		EnablePreconfiguredSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnablePreconfiguredSettings", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OnlyExposePreconfiguredSettings_PropertyAddress, intPtr, "bOnlyExposePreconfiguredSettings");
		OnlyExposePreconfiguredSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOnlyExposePreconfiguredSettings");
		OnlyExposePreconfiguredSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOnlyExposePreconfiguredSettings", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PreconfiguredInfo_PropertyAddress, intPtr, "PreconfiguredInfo");
		PreconfiguredInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreconfiguredInfo");
		PreconfiguredInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreconfiguredInfo", Classes.FArrayProperty);
		Category_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Category");
		Category_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Category", Classes.FTextProperty);
		Description_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Description");
		Description_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Description", Classes.FTextProperty);
		DependencyParsingDepth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DependencyParsingDepth");
		DependencyParsingDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DependencyParsingDepth", Classes.FIntProperty);
		VariableLoopBody_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "VariableLoopBody");
		VariableLoopBody_ParamsSize = NativeReflection.GetFunctionParamsSize(VariableLoopBody_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref VariableLoopBody_InContext_PropertyAddress, VariableLoopBody_FunctionAddress, "InContext");
		VariableLoopBody_InContext_Offset = NativeReflectionCached.GetPropertyOffset(VariableLoopBody_FunctionAddress, "InContext");
		VariableLoopBody_InContext_IsValid = NativeReflectionCached.ValidatePropertyClass(VariableLoopBody_FunctionAddress, "InContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VariableLoopBody_InData_PropertyAddress, VariableLoopBody_FunctionAddress, "InData");
		VariableLoopBody_InData_Offset = NativeReflectionCached.GetPropertyOffset(VariableLoopBody_FunctionAddress, "InData");
		VariableLoopBody_InData_IsValid = NativeReflectionCached.ValidatePropertyClass(VariableLoopBody_FunctionAddress, "InData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref VariableLoopBody_InPoint_PropertyAddress, VariableLoopBody_FunctionAddress, "InPoint");
		VariableLoopBody_InPoint_Offset = NativeReflectionCached.GetPropertyOffset(VariableLoopBody_FunctionAddress, "InPoint");
		VariableLoopBody_InPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(VariableLoopBody_FunctionAddress, "InPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VariableLoopBody_OutMetadata_PropertyAddress, VariableLoopBody_FunctionAddress, "OutMetadata");
		VariableLoopBody_OutMetadata_Offset = NativeReflectionCached.GetPropertyOffset(VariableLoopBody_FunctionAddress, "OutMetadata");
		VariableLoopBody_OutMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(VariableLoopBody_FunctionAddress, "OutMetadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref VariableLoopBody_ReturnValue_PropertyAddress, VariableLoopBody_FunctionAddress, "ReturnValue");
		VariableLoopBody_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(VariableLoopBody_FunctionAddress, "ReturnValue");
		VariableLoopBody_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(VariableLoopBody_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		VariableLoopBody_IsValid = VariableLoopBody_FunctionAddress != IntPtr.Zero && VariableLoopBody_InContext_IsValid && VariableLoopBody_InData_IsValid && VariableLoopBody_InPoint_IsValid && VariableLoopBody_OutMetadata_IsValid && VariableLoopBody_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:VariableLoopBody", VariableLoopBody_IsValid);
		VariableLoop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "VariableLoop");
		VariableLoop_ParamsSize = NativeReflection.GetFunctionParamsSize(VariableLoop_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref VariableLoop_InContext_PropertyAddress, VariableLoop_FunctionAddress, "InContext");
		VariableLoop_InContext_Offset = NativeReflectionCached.GetPropertyOffset(VariableLoop_FunctionAddress, "InContext");
		VariableLoop_InContext_IsValid = NativeReflectionCached.ValidatePropertyClass(VariableLoop_FunctionAddress, "InContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VariableLoop_InData_PropertyAddress, VariableLoop_FunctionAddress, "InData");
		VariableLoop_InData_Offset = NativeReflectionCached.GetPropertyOffset(VariableLoop_FunctionAddress, "InData");
		VariableLoop_InData_IsValid = NativeReflectionCached.ValidatePropertyClass(VariableLoop_FunctionAddress, "InData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref VariableLoop_OutData_PropertyAddress, VariableLoop_FunctionAddress, "OutData");
		VariableLoop_OutData_Offset = NativeReflectionCached.GetPropertyOffset(VariableLoop_FunctionAddress, "OutData");
		VariableLoop_OutData_IsValid = NativeReflectionCached.ValidatePropertyClass(VariableLoop_FunctionAddress, "OutData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref VariableLoop_OptionalOutData_PropertyAddress, VariableLoop_FunctionAddress, "OptionalOutData");
		VariableLoop_OptionalOutData_Offset = NativeReflectionCached.GetPropertyOffset(VariableLoop_FunctionAddress, "OptionalOutData");
		VariableLoop_OptionalOutData_IsValid = NativeReflectionCached.ValidatePropertyClass(VariableLoop_FunctionAddress, "OptionalOutData", Classes.FObjectProperty);
		VariableLoop_IsValid = VariableLoop_FunctionAddress != IntPtr.Zero && VariableLoop_InContext_IsValid && VariableLoop_InData_IsValid && VariableLoop_OutData_IsValid && VariableLoop_OptionalOutData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:VariableLoop", VariableLoop_IsValid);
		PointLoopBody_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PointLoopBody");
		PointLoopBody_ParamsSize = NativeReflection.GetFunctionParamsSize(PointLoopBody_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointLoopBody_InContext_PropertyAddress, PointLoopBody_FunctionAddress, "InContext");
		PointLoopBody_InContext_Offset = NativeReflectionCached.GetPropertyOffset(PointLoopBody_FunctionAddress, "InContext");
		PointLoopBody_InContext_IsValid = NativeReflectionCached.ValidatePropertyClass(PointLoopBody_FunctionAddress, "InContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointLoopBody_InData_PropertyAddress, PointLoopBody_FunctionAddress, "InData");
		PointLoopBody_InData_Offset = NativeReflectionCached.GetPropertyOffset(PointLoopBody_FunctionAddress, "InData");
		PointLoopBody_InData_IsValid = NativeReflectionCached.ValidatePropertyClass(PointLoopBody_FunctionAddress, "InData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PointLoopBody_InPoint_PropertyAddress, PointLoopBody_FunctionAddress, "InPoint");
		PointLoopBody_InPoint_Offset = NativeReflectionCached.GetPropertyOffset(PointLoopBody_FunctionAddress, "InPoint");
		PointLoopBody_InPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(PointLoopBody_FunctionAddress, "InPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointLoopBody_OutPoint_PropertyAddress, PointLoopBody_FunctionAddress, "OutPoint");
		PointLoopBody_OutPoint_Offset = NativeReflectionCached.GetPropertyOffset(PointLoopBody_FunctionAddress, "OutPoint");
		PointLoopBody_OutPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(PointLoopBody_FunctionAddress, "OutPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointLoopBody_OutMetadata_PropertyAddress, PointLoopBody_FunctionAddress, "OutMetadata");
		PointLoopBody_OutMetadata_Offset = NativeReflectionCached.GetPropertyOffset(PointLoopBody_FunctionAddress, "OutMetadata");
		PointLoopBody_OutMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(PointLoopBody_FunctionAddress, "OutMetadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PointLoopBody_ReturnValue_PropertyAddress, PointLoopBody_FunctionAddress, "ReturnValue");
		PointLoopBody_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PointLoopBody_FunctionAddress, "ReturnValue");
		PointLoopBody_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PointLoopBody_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PointLoopBody_IsValid = PointLoopBody_FunctionAddress != IntPtr.Zero && PointLoopBody_InContext_IsValid && PointLoopBody_InData_IsValid && PointLoopBody_InPoint_IsValid && PointLoopBody_OutPoint_IsValid && PointLoopBody_OutMetadata_IsValid && PointLoopBody_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:PointLoopBody", PointLoopBody_IsValid);
		PointLoop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PointLoop");
		PointLoop_ParamsSize = NativeReflection.GetFunctionParamsSize(PointLoop_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PointLoop_InContext_PropertyAddress, PointLoop_FunctionAddress, "InContext");
		PointLoop_InContext_Offset = NativeReflectionCached.GetPropertyOffset(PointLoop_FunctionAddress, "InContext");
		PointLoop_InContext_IsValid = NativeReflectionCached.ValidatePropertyClass(PointLoop_FunctionAddress, "InContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PointLoop_InData_PropertyAddress, PointLoop_FunctionAddress, "InData");
		PointLoop_InData_Offset = NativeReflectionCached.GetPropertyOffset(PointLoop_FunctionAddress, "InData");
		PointLoop_InData_IsValid = NativeReflectionCached.ValidatePropertyClass(PointLoop_FunctionAddress, "InData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PointLoop_OutData_PropertyAddress, PointLoop_FunctionAddress, "OutData");
		PointLoop_OutData_Offset = NativeReflectionCached.GetPropertyOffset(PointLoop_FunctionAddress, "OutData");
		PointLoop_OutData_IsValid = NativeReflectionCached.ValidatePropertyClass(PointLoop_FunctionAddress, "OutData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PointLoop_OptionalOutData_PropertyAddress, PointLoop_FunctionAddress, "OptionalOutData");
		PointLoop_OptionalOutData_Offset = NativeReflectionCached.GetPropertyOffset(PointLoop_FunctionAddress, "OptionalOutData");
		PointLoop_OptionalOutData_IsValid = NativeReflectionCached.ValidatePropertyClass(PointLoop_FunctionAddress, "OptionalOutData", Classes.FObjectProperty);
		PointLoop_IsValid = PointLoop_FunctionAddress != IntPtr.Zero && PointLoop_InContext_IsValid && PointLoop_InData_IsValid && PointLoop_OutData_IsValid && PointLoop_OptionalOutData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:PointLoop", PointLoop_IsValid);
		NodeTypeOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "NodeTypeOverride");
		NodeTypeOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(NodeTypeOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NodeTypeOverride_ReturnValue_PropertyAddress, NodeTypeOverride_FunctionAddress, "ReturnValue");
		NodeTypeOverride_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NodeTypeOverride_FunctionAddress, "ReturnValue");
		NodeTypeOverride_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NodeTypeOverride_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		NodeTypeOverride_IsValid = NodeTypeOverride_FunctionAddress != IntPtr.Zero && NodeTypeOverride_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:NodeTypeOverride", NodeTypeOverride_IsValid);
		NodeTitleOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "NodeTitleOverride");
		NodeTitleOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(NodeTitleOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NodeTitleOverride_ReturnValue_PropertyAddress, NodeTitleOverride_FunctionAddress, "ReturnValue");
		NodeTitleOverride_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NodeTitleOverride_FunctionAddress, "ReturnValue");
		NodeTitleOverride_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NodeTitleOverride_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		NodeTitleOverride_IsValid = NodeTitleOverride_FunctionAddress != IntPtr.Zero && NodeTitleOverride_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:NodeTitleOverride", NodeTitleOverride_IsValid);
		NodeColorOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "NodeColorOverride");
		NodeColorOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(NodeColorOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NodeColorOverride_ReturnValue_PropertyAddress, NodeColorOverride_FunctionAddress, "ReturnValue");
		NodeColorOverride_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NodeColorOverride_FunctionAddress, "ReturnValue");
		NodeColorOverride_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NodeColorOverride_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		NodeColorOverride_IsValid = NodeColorOverride_FunctionAddress != IntPtr.Zero && NodeColorOverride_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:NodeColorOverride", NodeColorOverride_IsValid);
		NestedLoopBody_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "NestedLoopBody");
		NestedLoopBody_ParamsSize = NativeReflection.GetFunctionParamsSize(NestedLoopBody_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NestedLoopBody_InContext_PropertyAddress, NestedLoopBody_FunctionAddress, "InContext");
		NestedLoopBody_InContext_Offset = NativeReflectionCached.GetPropertyOffset(NestedLoopBody_FunctionAddress, "InContext");
		NestedLoopBody_InContext_IsValid = NativeReflectionCached.ValidatePropertyClass(NestedLoopBody_FunctionAddress, "InContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NestedLoopBody_InOuterData_PropertyAddress, NestedLoopBody_FunctionAddress, "InOuterData");
		NestedLoopBody_InOuterData_Offset = NativeReflectionCached.GetPropertyOffset(NestedLoopBody_FunctionAddress, "InOuterData");
		NestedLoopBody_InOuterData_IsValid = NativeReflectionCached.ValidatePropertyClass(NestedLoopBody_FunctionAddress, "InOuterData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NestedLoopBody_InInnerData_PropertyAddress, NestedLoopBody_FunctionAddress, "InInnerData");
		NestedLoopBody_InInnerData_Offset = NativeReflectionCached.GetPropertyOffset(NestedLoopBody_FunctionAddress, "InInnerData");
		NestedLoopBody_InInnerData_IsValid = NativeReflectionCached.ValidatePropertyClass(NestedLoopBody_FunctionAddress, "InInnerData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NestedLoopBody_InOuterPoint_PropertyAddress, NestedLoopBody_FunctionAddress, "InOuterPoint");
		NestedLoopBody_InOuterPoint_Offset = NativeReflectionCached.GetPropertyOffset(NestedLoopBody_FunctionAddress, "InOuterPoint");
		NestedLoopBody_InOuterPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(NestedLoopBody_FunctionAddress, "InOuterPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NestedLoopBody_InInnerPoint_PropertyAddress, NestedLoopBody_FunctionAddress, "InInnerPoint");
		NestedLoopBody_InInnerPoint_Offset = NativeReflectionCached.GetPropertyOffset(NestedLoopBody_FunctionAddress, "InInnerPoint");
		NestedLoopBody_InInnerPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(NestedLoopBody_FunctionAddress, "InInnerPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NestedLoopBody_OutPoint_PropertyAddress, NestedLoopBody_FunctionAddress, "OutPoint");
		NestedLoopBody_OutPoint_Offset = NativeReflectionCached.GetPropertyOffset(NestedLoopBody_FunctionAddress, "OutPoint");
		NestedLoopBody_OutPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(NestedLoopBody_FunctionAddress, "OutPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NestedLoopBody_OutMetadata_PropertyAddress, NestedLoopBody_FunctionAddress, "OutMetadata");
		NestedLoopBody_OutMetadata_Offset = NativeReflectionCached.GetPropertyOffset(NestedLoopBody_FunctionAddress, "OutMetadata");
		NestedLoopBody_OutMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(NestedLoopBody_FunctionAddress, "OutMetadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NestedLoopBody_ReturnValue_PropertyAddress, NestedLoopBody_FunctionAddress, "ReturnValue");
		NestedLoopBody_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NestedLoopBody_FunctionAddress, "ReturnValue");
		NestedLoopBody_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NestedLoopBody_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		NestedLoopBody_IsValid = NestedLoopBody_FunctionAddress != IntPtr.Zero && NestedLoopBody_InContext_IsValid && NestedLoopBody_InOuterData_IsValid && NestedLoopBody_InInnerData_IsValid && NestedLoopBody_InOuterPoint_IsValid && NestedLoopBody_InInnerPoint_IsValid && NestedLoopBody_OutPoint_IsValid && NestedLoopBody_OutMetadata_IsValid && NestedLoopBody_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:NestedLoopBody", NestedLoopBody_IsValid);
		NestedLoop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "NestedLoop");
		NestedLoop_ParamsSize = NativeReflection.GetFunctionParamsSize(NestedLoop_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NestedLoop_InContext_PropertyAddress, NestedLoop_FunctionAddress, "InContext");
		NestedLoop_InContext_Offset = NativeReflectionCached.GetPropertyOffset(NestedLoop_FunctionAddress, "InContext");
		NestedLoop_InContext_IsValid = NativeReflectionCached.ValidatePropertyClass(NestedLoop_FunctionAddress, "InContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NestedLoop_InOuterData_PropertyAddress, NestedLoop_FunctionAddress, "InOuterData");
		NestedLoop_InOuterData_Offset = NativeReflectionCached.GetPropertyOffset(NestedLoop_FunctionAddress, "InOuterData");
		NestedLoop_InOuterData_IsValid = NativeReflectionCached.ValidatePropertyClass(NestedLoop_FunctionAddress, "InOuterData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NestedLoop_InInnerData_PropertyAddress, NestedLoop_FunctionAddress, "InInnerData");
		NestedLoop_InInnerData_Offset = NativeReflectionCached.GetPropertyOffset(NestedLoop_FunctionAddress, "InInnerData");
		NestedLoop_InInnerData_IsValid = NativeReflectionCached.ValidatePropertyClass(NestedLoop_FunctionAddress, "InInnerData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NestedLoop_OutData_PropertyAddress, NestedLoop_FunctionAddress, "OutData");
		NestedLoop_OutData_Offset = NativeReflectionCached.GetPropertyOffset(NestedLoop_FunctionAddress, "OutData");
		NestedLoop_OutData_IsValid = NativeReflectionCached.ValidatePropertyClass(NestedLoop_FunctionAddress, "OutData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NestedLoop_OptionalOutData_PropertyAddress, NestedLoop_FunctionAddress, "OptionalOutData");
		NestedLoop_OptionalOutData_Offset = NativeReflectionCached.GetPropertyOffset(NestedLoop_FunctionAddress, "OptionalOutData");
		NestedLoop_OptionalOutData_IsValid = NativeReflectionCached.ValidatePropertyClass(NestedLoop_FunctionAddress, "OptionalOutData", Classes.FObjectProperty);
		NestedLoop_IsValid = NestedLoop_FunctionAddress != IntPtr.Zero && NestedLoop_InContext_IsValid && NestedLoop_InOuterData_IsValid && NestedLoop_InInnerData_IsValid && NestedLoop_OutData_IsValid && NestedLoop_OptionalOutData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:NestedLoop", NestedLoop_IsValid);
		IterationLoopBody_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IterationLoopBody");
		IterationLoopBody_ParamsSize = NativeReflection.GetFunctionParamsSize(IterationLoopBody_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IterationLoopBody_InContext_PropertyAddress, IterationLoopBody_FunctionAddress, "InContext");
		IterationLoopBody_InContext_Offset = NativeReflectionCached.GetPropertyOffset(IterationLoopBody_FunctionAddress, "InContext");
		IterationLoopBody_InContext_IsValid = NativeReflectionCached.ValidatePropertyClass(IterationLoopBody_FunctionAddress, "InContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IterationLoopBody_Iteration_PropertyAddress, IterationLoopBody_FunctionAddress, "Iteration");
		IterationLoopBody_Iteration_Offset = NativeReflectionCached.GetPropertyOffset(IterationLoopBody_FunctionAddress, "Iteration");
		IterationLoopBody_Iteration_IsValid = NativeReflectionCached.ValidatePropertyClass(IterationLoopBody_FunctionAddress, "Iteration", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref IterationLoopBody_InA_PropertyAddress, IterationLoopBody_FunctionAddress, "InA");
		IterationLoopBody_InA_Offset = NativeReflectionCached.GetPropertyOffset(IterationLoopBody_FunctionAddress, "InA");
		IterationLoopBody_InA_IsValid = NativeReflectionCached.ValidatePropertyClass(IterationLoopBody_FunctionAddress, "InA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IterationLoopBody_InB_PropertyAddress, IterationLoopBody_FunctionAddress, "InB");
		IterationLoopBody_InB_Offset = NativeReflectionCached.GetPropertyOffset(IterationLoopBody_FunctionAddress, "InB");
		IterationLoopBody_InB_IsValid = NativeReflectionCached.ValidatePropertyClass(IterationLoopBody_FunctionAddress, "InB", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IterationLoopBody_OutPoint_PropertyAddress, IterationLoopBody_FunctionAddress, "OutPoint");
		IterationLoopBody_OutPoint_Offset = NativeReflectionCached.GetPropertyOffset(IterationLoopBody_FunctionAddress, "OutPoint");
		IterationLoopBody_OutPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(IterationLoopBody_FunctionAddress, "OutPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IterationLoopBody_OutMetadata_PropertyAddress, IterationLoopBody_FunctionAddress, "OutMetadata");
		IterationLoopBody_OutMetadata_Offset = NativeReflectionCached.GetPropertyOffset(IterationLoopBody_FunctionAddress, "OutMetadata");
		IterationLoopBody_OutMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(IterationLoopBody_FunctionAddress, "OutMetadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IterationLoopBody_ReturnValue_PropertyAddress, IterationLoopBody_FunctionAddress, "ReturnValue");
		IterationLoopBody_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IterationLoopBody_FunctionAddress, "ReturnValue");
		IterationLoopBody_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IterationLoopBody_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IterationLoopBody_IsValid = IterationLoopBody_FunctionAddress != IntPtr.Zero && IterationLoopBody_InContext_IsValid && IterationLoopBody_Iteration_IsValid && IterationLoopBody_InA_IsValid && IterationLoopBody_InB_IsValid && IterationLoopBody_OutPoint_IsValid && IterationLoopBody_OutMetadata_IsValid && IterationLoopBody_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:IterationLoopBody", IterationLoopBody_IsValid);
		IterationLoop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IterationLoop");
		IterationLoop_ParamsSize = NativeReflection.GetFunctionParamsSize(IterationLoop_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IterationLoop_InContext_PropertyAddress, IterationLoop_FunctionAddress, "InContext");
		IterationLoop_InContext_Offset = NativeReflectionCached.GetPropertyOffset(IterationLoop_FunctionAddress, "InContext");
		IterationLoop_InContext_IsValid = NativeReflectionCached.ValidatePropertyClass(IterationLoop_FunctionAddress, "InContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IterationLoop_NumIterations_PropertyAddress, IterationLoop_FunctionAddress, "NumIterations");
		IterationLoop_NumIterations_Offset = NativeReflectionCached.GetPropertyOffset(IterationLoop_FunctionAddress, "NumIterations");
		IterationLoop_NumIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(IterationLoop_FunctionAddress, "NumIterations", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref IterationLoop_OutData_PropertyAddress, IterationLoop_FunctionAddress, "OutData");
		IterationLoop_OutData_Offset = NativeReflectionCached.GetPropertyOffset(IterationLoop_FunctionAddress, "OutData");
		IterationLoop_OutData_IsValid = NativeReflectionCached.ValidatePropertyClass(IterationLoop_FunctionAddress, "OutData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IterationLoop_OptionalA_PropertyAddress, IterationLoop_FunctionAddress, "OptionalA");
		IterationLoop_OptionalA_Offset = NativeReflectionCached.GetPropertyOffset(IterationLoop_FunctionAddress, "OptionalA");
		IterationLoop_OptionalA_IsValid = NativeReflectionCached.ValidatePropertyClass(IterationLoop_FunctionAddress, "OptionalA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IterationLoop_OptionalB_PropertyAddress, IterationLoop_FunctionAddress, "OptionalB");
		IterationLoop_OptionalB_Offset = NativeReflectionCached.GetPropertyOffset(IterationLoop_FunctionAddress, "OptionalB");
		IterationLoop_OptionalB_IsValid = NativeReflectionCached.ValidatePropertyClass(IterationLoop_FunctionAddress, "OptionalB", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IterationLoop_OptionalOutData_PropertyAddress, IterationLoop_FunctionAddress, "OptionalOutData");
		IterationLoop_OptionalOutData_Offset = NativeReflectionCached.GetPropertyOffset(IterationLoop_FunctionAddress, "OptionalOutData");
		IterationLoop_OptionalOutData_IsValid = NativeReflectionCached.ValidatePropertyClass(IterationLoop_FunctionAddress, "OptionalOutData", Classes.FObjectProperty);
		IterationLoop_IsValid = IterationLoop_FunctionAddress != IntPtr.Zero && IterationLoop_InContext_IsValid && IterationLoop_NumIterations_IsValid && IterationLoop_OutData_IsValid && IterationLoop_OptionalA_IsValid && IterationLoop_OptionalB_IsValid && IterationLoop_OptionalOutData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:IterationLoop", IterationLoop_IsValid);
		IsCacheableOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsCacheableOverride");
		IsCacheableOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCacheableOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCacheableOverride_ReturnValue_PropertyAddress, IsCacheableOverride_FunctionAddress, "ReturnValue");
		IsCacheableOverride_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCacheableOverride_FunctionAddress, "ReturnValue");
		IsCacheableOverride_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCacheableOverride_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCacheableOverride_IsValid = IsCacheableOverride_FunctionAddress != IntPtr.Zero && IsCacheableOverride_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:IsCacheableOverride", IsCacheableOverride_IsValid);
		GetSeed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSeed");
		GetSeed_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSeed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSeed_InContext_PropertyAddress, GetSeed_FunctionAddress, "InContext");
		GetSeed_InContext_Offset = NativeReflectionCached.GetPropertyOffset(GetSeed_FunctionAddress, "InContext");
		GetSeed_InContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSeed_FunctionAddress, "InContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSeed_ReturnValue_PropertyAddress, GetSeed_FunctionAddress, "ReturnValue");
		GetSeed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSeed_FunctionAddress, "ReturnValue");
		GetSeed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSeed_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSeed_IsValid = GetSeed_FunctionAddress != IntPtr.Zero && GetSeed_InContext_IsValid && GetSeed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:GetSeed", GetSeed_IsValid);
		GetRandomStream_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRandomStream");
		GetRandomStream_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRandomStream_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRandomStream_InContext_PropertyAddress, GetRandomStream_FunctionAddress, "InContext");
		GetRandomStream_InContext_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomStream_FunctionAddress, "InContext");
		GetRandomStream_InContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomStream_FunctionAddress, "InContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomStream_ReturnValue_PropertyAddress, GetRandomStream_FunctionAddress, "ReturnValue");
		GetRandomStream_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomStream_FunctionAddress, "ReturnValue");
		GetRandomStream_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomStream_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRandomStream_IsValid = GetRandomStream_FunctionAddress != IntPtr.Zero && GetRandomStream_InContext_IsValid && GetRandomStream_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:GetRandomStream", GetRandomStream_IsValid);
		GetOutputPins_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOutputPins");
		GetOutputPins_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOutputPins_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOutputPins_ReturnValue_PropertyAddress, GetOutputPins_FunctionAddress, "ReturnValue");
		GetOutputPins_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOutputPins_FunctionAddress, "ReturnValue");
		GetOutputPins_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOutputPins_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetOutputPins_IsValid = GetOutputPins_FunctionAddress != IntPtr.Zero && GetOutputPins_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:GetOutputPins", GetOutputPins_IsValid);
		GetOutputPinByLabel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOutputPinByLabel");
		GetOutputPinByLabel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOutputPinByLabel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOutputPinByLabel_InPinLabel_PropertyAddress, GetOutputPinByLabel_FunctionAddress, "InPinLabel");
		GetOutputPinByLabel_InPinLabel_Offset = NativeReflectionCached.GetPropertyOffset(GetOutputPinByLabel_FunctionAddress, "InPinLabel");
		GetOutputPinByLabel_InPinLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOutputPinByLabel_FunctionAddress, "InPinLabel", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOutputPinByLabel_OutFoundPin_PropertyAddress, GetOutputPinByLabel_FunctionAddress, "OutFoundPin");
		GetOutputPinByLabel_OutFoundPin_Offset = NativeReflectionCached.GetPropertyOffset(GetOutputPinByLabel_FunctionAddress, "OutFoundPin");
		GetOutputPinByLabel_OutFoundPin_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOutputPinByLabel_FunctionAddress, "OutFoundPin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOutputPinByLabel_ReturnValue_PropertyAddress, GetOutputPinByLabel_FunctionAddress, "ReturnValue");
		GetOutputPinByLabel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOutputPinByLabel_FunctionAddress, "ReturnValue");
		GetOutputPinByLabel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOutputPinByLabel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetOutputPinByLabel_IsValid = GetOutputPinByLabel_FunctionAddress != IntPtr.Zero && GetOutputPinByLabel_InPinLabel_IsValid && GetOutputPinByLabel_OutFoundPin_IsValid && GetOutputPinByLabel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:GetOutputPinByLabel", GetOutputPinByLabel_IsValid);
		GetInputPins_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInputPins");
		GetInputPins_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputPins_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputPins_ReturnValue_PropertyAddress, GetInputPins_FunctionAddress, "ReturnValue");
		GetInputPins_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputPins_FunctionAddress, "ReturnValue");
		GetInputPins_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputPins_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetInputPins_IsValid = GetInputPins_FunctionAddress != IntPtr.Zero && GetInputPins_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:GetInputPins", GetInputPins_IsValid);
		GetInputPinByLabel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetInputPinByLabel");
		GetInputPinByLabel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputPinByLabel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputPinByLabel_InPinLabel_PropertyAddress, GetInputPinByLabel_FunctionAddress, "InPinLabel");
		GetInputPinByLabel_InPinLabel_Offset = NativeReflectionCached.GetPropertyOffset(GetInputPinByLabel_FunctionAddress, "InPinLabel");
		GetInputPinByLabel_InPinLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputPinByLabel_FunctionAddress, "InPinLabel", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputPinByLabel_OutFoundPin_PropertyAddress, GetInputPinByLabel_FunctionAddress, "OutFoundPin");
		GetInputPinByLabel_OutFoundPin_Offset = NativeReflectionCached.GetPropertyOffset(GetInputPinByLabel_FunctionAddress, "OutFoundPin");
		GetInputPinByLabel_OutFoundPin_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputPinByLabel_FunctionAddress, "OutFoundPin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputPinByLabel_ReturnValue_PropertyAddress, GetInputPinByLabel_FunctionAddress, "ReturnValue");
		GetInputPinByLabel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputPinByLabel_FunctionAddress, "ReturnValue");
		GetInputPinByLabel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputPinByLabel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetInputPinByLabel_IsValid = GetInputPinByLabel_FunctionAddress != IntPtr.Zero && GetInputPinByLabel_InPinLabel_IsValid && GetInputPinByLabel_OutFoundPin_IsValid && GetInputPinByLabel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:GetInputPinByLabel", GetInputPinByLabel_IsValid);
		GetContext_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetContext");
		GetContext_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetContext_ReturnValue_PropertyAddress, GetContext_FunctionAddress, "ReturnValue");
		GetContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetContext_FunctionAddress, "ReturnValue");
		GetContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetContext_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetContext_IsValid = GetContext_FunctionAddress != IntPtr.Zero && GetContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:GetContext", GetContext_IsValid);
		ExecuteWithContext_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ExecuteWithContext");
		ExecuteWithContext_ParamsSize = NativeReflection.GetFunctionParamsSize(ExecuteWithContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExecuteWithContext_InContext_PropertyAddress, ExecuteWithContext_FunctionAddress, "InContext");
		ExecuteWithContext_InContext_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteWithContext_FunctionAddress, "InContext");
		ExecuteWithContext_InContext_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteWithContext_FunctionAddress, "InContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ExecuteWithContext_Input_PropertyAddress, ExecuteWithContext_FunctionAddress, "Input");
		ExecuteWithContext_Input_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteWithContext_FunctionAddress, "Input");
		ExecuteWithContext_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteWithContext_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ExecuteWithContext_Output_PropertyAddress, ExecuteWithContext_FunctionAddress, "Output");
		ExecuteWithContext_Output_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteWithContext_FunctionAddress, "Output");
		ExecuteWithContext_Output_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteWithContext_FunctionAddress, "Output", Classes.FStructProperty);
		ExecuteWithContext_IsValid = ExecuteWithContext_FunctionAddress != IntPtr.Zero && ExecuteWithContext_InContext_IsValid && ExecuteWithContext_Input_IsValid && ExecuteWithContext_Output_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:ExecuteWithContext", ExecuteWithContext_IsValid);
		Execute_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Execute");
		Execute_ParamsSize = NativeReflection.GetFunctionParamsSize(Execute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Execute_Input_PropertyAddress, Execute_FunctionAddress, "Input");
		Execute_Input_Offset = NativeReflectionCached.GetPropertyOffset(Execute_FunctionAddress, "Input");
		Execute_Input_IsValid = NativeReflectionCached.ValidatePropertyClass(Execute_FunctionAddress, "Input", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Execute_Output_PropertyAddress, Execute_FunctionAddress, "Output");
		Execute_Output_Offset = NativeReflectionCached.GetPropertyOffset(Execute_FunctionAddress, "Output");
		Execute_Output_IsValid = NativeReflectionCached.ValidatePropertyClass(Execute_FunctionAddress, "Output", Classes.FStructProperty);
		Execute_IsValid = Execute_FunctionAddress != IntPtr.Zero && Execute_Input_IsValid && Execute_Output_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:Execute", Execute_IsValid);
		CustomOutputLabels_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CustomOutputLabels");
		CustomOutputLabels_ParamsSize = NativeReflection.GetFunctionParamsSize(CustomOutputLabels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CustomOutputLabels_ReturnValue_PropertyAddress, CustomOutputLabels_FunctionAddress, "ReturnValue");
		CustomOutputLabels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CustomOutputLabels_FunctionAddress, "ReturnValue");
		CustomOutputLabels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CustomOutputLabels_FunctionAddress, "ReturnValue", Classes.FSetProperty);
		CustomOutputLabels_IsValid = CustomOutputLabels_FunctionAddress != IntPtr.Zero && CustomOutputLabels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:CustomOutputLabels", CustomOutputLabels_IsValid);
		CustomInputLabels_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CustomInputLabels");
		CustomInputLabels_ParamsSize = NativeReflection.GetFunctionParamsSize(CustomInputLabels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CustomInputLabels_ReturnValue_PropertyAddress, CustomInputLabels_FunctionAddress, "ReturnValue");
		CustomInputLabels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CustomInputLabels_FunctionAddress, "ReturnValue");
		CustomInputLabels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CustomInputLabels_FunctionAddress, "ReturnValue", Classes.FSetProperty);
		CustomInputLabels_IsValid = CustomInputLabels_FunctionAddress != IntPtr.Zero && CustomInputLabels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:CustomInputLabels", CustomInputLabels_IsValid);
		ApplyPreconfiguredSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyPreconfiguredSettings");
		ApplyPreconfiguredSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyPreconfiguredSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyPreconfiguredSettings_InPreconfigureInfo_PropertyAddress, ApplyPreconfiguredSettings_FunctionAddress, "InPreconfigureInfo");
		ApplyPreconfiguredSettings_InPreconfigureInfo_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPreconfiguredSettings_FunctionAddress, "InPreconfigureInfo");
		ApplyPreconfiguredSettings_InPreconfigureInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPreconfiguredSettings_FunctionAddress, "InPreconfigureInfo", Classes.FStructProperty);
		ApplyPreconfiguredSettings_IsValid = ApplyPreconfiguredSettings_FunctionAddress != IntPtr.Zero && ApplyPreconfiguredSettings_InPreconfigureInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintElement:ApplyPreconfiguredSettings", ApplyPreconfiguredSettings_IsValid);
	}
}
