using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary", "AnimGraphRuntime", UnrealModuleType.Engine)]
public class USequenceEvaluatorLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetSequenceWithInertialBlending_IsValid;

	private static IntPtr SetSequenceWithInertialBlending_FunctionAddress;

	private static int SetSequenceWithInertialBlending_ParamsSize;

	private static bool SetSequenceWithInertialBlending_UpdateContext_IsValid;

	private static FFieldAddress SetSequenceWithInertialBlending_UpdateContext_PropertyAddress;

	private static int SetSequenceWithInertialBlending_UpdateContext_Offset;

	private static bool SetSequenceWithInertialBlending_SequenceEvaluator_IsValid;

	private static FFieldAddress SetSequenceWithInertialBlending_SequenceEvaluator_PropertyAddress;

	private static int SetSequenceWithInertialBlending_SequenceEvaluator_Offset;

	private static bool SetSequenceWithInertialBlending_Sequence_IsValid;

	private static FFieldAddress SetSequenceWithInertialBlending_Sequence_PropertyAddress;

	private static int SetSequenceWithInertialBlending_Sequence_Offset;

	private static bool SetSequenceWithInertialBlending_BlendTime_IsValid;

	private static FFieldAddress SetSequenceWithInertialBlending_BlendTime_PropertyAddress;

	private static int SetSequenceWithInertialBlending_BlendTime_Offset;

	private static bool SetSequenceWithInertialBlending_ReturnValue_IsValid;

	private static FFieldAddress SetSequenceWithInertialBlending_ReturnValue_PropertyAddress;

	private static int SetSequenceWithInertialBlending_ReturnValue_Offset;

	private static bool SetSequence_IsValid;

	private static IntPtr SetSequence_FunctionAddress;

	private static int SetSequence_ParamsSize;

	private static bool SetSequence_SequenceEvaluator_IsValid;

	private static FFieldAddress SetSequence_SequenceEvaluator_PropertyAddress;

	private static int SetSequence_SequenceEvaluator_Offset;

	private static bool SetSequence_Sequence_IsValid;

	private static FFieldAddress SetSequence_Sequence_PropertyAddress;

	private static int SetSequence_Sequence_Offset;

	private static bool SetSequence_ReturnValue_IsValid;

	private static FFieldAddress SetSequence_ReturnValue_PropertyAddress;

	private static int SetSequence_ReturnValue_Offset;

	private static bool SetExplicitTime_IsValid;

	private static IntPtr SetExplicitTime_FunctionAddress;

	private static int SetExplicitTime_ParamsSize;

	private static bool SetExplicitTime_SequenceEvaluator_IsValid;

	private static FFieldAddress SetExplicitTime_SequenceEvaluator_PropertyAddress;

	private static int SetExplicitTime_SequenceEvaluator_Offset;

	private static bool SetExplicitTime_Time_IsValid;

	private static FFieldAddress SetExplicitTime_Time_PropertyAddress;

	private static int SetExplicitTime_Time_Offset;

	private static bool SetExplicitTime_ReturnValue_IsValid;

	private static FFieldAddress SetExplicitTime_ReturnValue_PropertyAddress;

	private static int SetExplicitTime_ReturnValue_Offset;

	private static bool GetSequence_IsValid;

	private static IntPtr GetSequence_FunctionAddress;

	private static int GetSequence_ParamsSize;

	private static bool GetSequence_SequenceEvaluator_IsValid;

	private static FFieldAddress GetSequence_SequenceEvaluator_PropertyAddress;

	private static int GetSequence_SequenceEvaluator_Offset;

	private static bool GetSequence_ReturnValue_IsValid;

	private static FFieldAddress GetSequence_ReturnValue_PropertyAddress;

	private static int GetSequence_ReturnValue_Offset;

	private static bool GetAccumulatedTime_IsValid;

	private static IntPtr GetAccumulatedTime_FunctionAddress;

	private static int GetAccumulatedTime_ParamsSize;

	private static bool GetAccumulatedTime_SequenceEvaluator_IsValid;

	private static FFieldAddress GetAccumulatedTime_SequenceEvaluator_PropertyAddress;

	private static int GetAccumulatedTime_SequenceEvaluator_Offset;

	private static bool GetAccumulatedTime_ReturnValue_IsValid;

	private static FFieldAddress GetAccumulatedTime_ReturnValue_PropertyAddress;

	private static int GetAccumulatedTime_ReturnValue_Offset;

	private static bool ConvertToSequenceEvaluatorPure_IsValid;

	private static IntPtr ConvertToSequenceEvaluatorPure_FunctionAddress;

	private static int ConvertToSequenceEvaluatorPure_ParamsSize;

	private static bool ConvertToSequenceEvaluatorPure_Node_IsValid;

	private static FFieldAddress ConvertToSequenceEvaluatorPure_Node_PropertyAddress;

	private static int ConvertToSequenceEvaluatorPure_Node_Offset;

	private static bool ConvertToSequenceEvaluatorPure_SequenceEvaluator_IsValid;

	private static FFieldAddress ConvertToSequenceEvaluatorPure_SequenceEvaluator_PropertyAddress;

	private static int ConvertToSequenceEvaluatorPure_SequenceEvaluator_Offset;

	private static bool ConvertToSequenceEvaluatorPure_Result_IsValid;

	private static FFieldAddress ConvertToSequenceEvaluatorPure_Result_PropertyAddress;

	private static int ConvertToSequenceEvaluatorPure_Result_Offset;

	private static bool ConvertToSequenceEvaluator_IsValid;

	private static IntPtr ConvertToSequenceEvaluator_FunctionAddress;

	private static int ConvertToSequenceEvaluator_ParamsSize;

	private static bool ConvertToSequenceEvaluator_Node_IsValid;

	private static FFieldAddress ConvertToSequenceEvaluator_Node_PropertyAddress;

	private static int ConvertToSequenceEvaluator_Node_Offset;

	private static bool ConvertToSequenceEvaluator_Result_IsValid;

	private static FFieldAddress ConvertToSequenceEvaluator_Result_PropertyAddress;

	private static int ConvertToSequenceEvaluator_Result_Offset;

	private static bool ConvertToSequenceEvaluator_ReturnValue_IsValid;

	private static FFieldAddress ConvertToSequenceEvaluator_ReturnValue_PropertyAddress;

	private static int ConvertToSequenceEvaluator_ReturnValue_Offset;

	private static bool AdvanceTime_IsValid;

	private static IntPtr AdvanceTime_FunctionAddress;

	private static int AdvanceTime_ParamsSize;

	private static bool AdvanceTime_UpdateContext_IsValid;

	private static FFieldAddress AdvanceTime_UpdateContext_PropertyAddress;

	private static int AdvanceTime_UpdateContext_Offset;

	private static bool AdvanceTime_SequenceEvaluator_IsValid;

	private static FFieldAddress AdvanceTime_SequenceEvaluator_PropertyAddress;

	private static int AdvanceTime_SequenceEvaluator_Offset;

	private static bool AdvanceTime_PlayRate_IsValid;

	private static FFieldAddress AdvanceTime_PlayRate_PropertyAddress;

	private static int AdvanceTime_PlayRate_Offset;

	private static bool AdvanceTime_ReturnValue_IsValid;

	private static FFieldAddress AdvanceTime_ReturnValue_PropertyAddress;

	private static int AdvanceTime_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:SetSequenceWithInertialBlending")]
	public unsafe static FSequenceEvaluatorReference SetSequenceWithInertialBlending(FAnimUpdateContext UpdateContext, FSequenceEvaluatorReference SequenceEvaluator, UAnimSequenceBase Sequence, float BlendTime = 0.2f)
	{
		if (!SetSequenceWithInertialBlending_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:SetSequenceWithInertialBlending");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSequenceWithInertialBlending_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSequenceWithInertialBlending_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSequenceWithInertialBlending_UpdateContext_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(intPtr, SetSequenceWithInertialBlending_UpdateContext_Offset), 0, SetSequenceWithInertialBlending_UpdateContext_PropertyAddress.Address, UpdateContext);
		NativeReflection.InitializeValue_InContainer(SetSequenceWithInertialBlending_SequenceEvaluator_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequenceEvaluatorReference>.ToNative(IntPtr.Add(intPtr, SetSequenceWithInertialBlending_SequenceEvaluator_Offset), 0, SetSequenceWithInertialBlending_SequenceEvaluator_PropertyAddress.Address, SequenceEvaluator);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, SetSequenceWithInertialBlending_Sequence_Offset), 0, SetSequenceWithInertialBlending_Sequence_PropertyAddress.Address, Sequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSequenceWithInertialBlending_BlendTime_Offset), 0, SetSequenceWithInertialBlending_BlendTime_PropertyAddress.Address, BlendTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSequenceWithInertialBlending_FunctionAddress, intPtr, SetSequenceWithInertialBlending_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSequenceWithInertialBlending_UpdateContext_PropertyAddress.Address, intPtr);
		return StructAsClassMarshaler<FSequenceEvaluatorReference>.FromNative(IntPtr.Add(intPtr, SetSequenceWithInertialBlending_ReturnValue_Offset), 0, SetSequenceWithInertialBlending_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:SetSequence")]
	public unsafe static FSequenceEvaluatorReference SetSequence(FSequenceEvaluatorReference SequenceEvaluator, UAnimSequenceBase Sequence)
	{
		if (!SetSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:SetSequence");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSequence_SequenceEvaluator_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequenceEvaluatorReference>.ToNative(IntPtr.Add(intPtr, SetSequence_SequenceEvaluator_Offset), 0, SetSequence_SequenceEvaluator_PropertyAddress.Address, SequenceEvaluator);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, SetSequence_Sequence_Offset), 0, SetSequence_Sequence_PropertyAddress.Address, Sequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSequence_FunctionAddress, intPtr, SetSequence_ParamsSize);
		return StructAsClassMarshaler<FSequenceEvaluatorReference>.FromNative(IntPtr.Add(intPtr, SetSequence_ReturnValue_Offset), 0, SetSequence_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:SetExplicitTime")]
	public unsafe static FSequenceEvaluatorReference SetExplicitTime(FSequenceEvaluatorReference SequenceEvaluator, float Time)
	{
		if (!SetExplicitTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:SetExplicitTime");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetExplicitTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetExplicitTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetExplicitTime_SequenceEvaluator_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequenceEvaluatorReference>.ToNative(IntPtr.Add(intPtr, SetExplicitTime_SequenceEvaluator_Offset), 0, SetExplicitTime_SequenceEvaluator_PropertyAddress.Address, SequenceEvaluator);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetExplicitTime_Time_Offset), 0, SetExplicitTime_Time_PropertyAddress.Address, Time);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetExplicitTime_FunctionAddress, intPtr, SetExplicitTime_ParamsSize);
		return StructAsClassMarshaler<FSequenceEvaluatorReference>.FromNative(IntPtr.Add(intPtr, SetExplicitTime_ReturnValue_Offset), 0, SetExplicitTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:GetSequence")]
	public unsafe static UAnimSequenceBase GetSequence(FSequenceEvaluatorReference SequenceEvaluator)
	{
		if (!GetSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:GetSequence");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetSequence_SequenceEvaluator_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequenceEvaluatorReference>.ToNative(IntPtr.Add(intPtr, GetSequence_SequenceEvaluator_Offset), 0, GetSequence_SequenceEvaluator_PropertyAddress.Address, SequenceEvaluator);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSequence_FunctionAddress, intPtr, GetSequence_ParamsSize);
		return UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(intPtr, GetSequence_ReturnValue_Offset), 0, GetSequence_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:GetAccumulatedTime")]
	public unsafe static float GetAccumulatedTime(FSequenceEvaluatorReference SequenceEvaluator)
	{
		if (!GetAccumulatedTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:GetAccumulatedTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAccumulatedTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAccumulatedTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAccumulatedTime_SequenceEvaluator_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequenceEvaluatorReference>.ToNative(IntPtr.Add(intPtr, GetAccumulatedTime_SequenceEvaluator_Offset), 0, GetAccumulatedTime_SequenceEvaluator_PropertyAddress.Address, SequenceEvaluator);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAccumulatedTime_FunctionAddress, intPtr, GetAccumulatedTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAccumulatedTime_ReturnValue_Offset), 0, GetAccumulatedTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:ConvertToSequenceEvaluatorPure")]
	public unsafe static void ConvertToSequenceEvaluatorPure(FAnimNodeReference Node, out FSequenceEvaluatorReference SequenceEvaluator, out bool Result)
	{
		if (!ConvertToSequenceEvaluatorPure_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:ConvertToSequenceEvaluatorPure");
			SequenceEvaluator = null;
			Result = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToSequenceEvaluatorPure_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToSequenceEvaluatorPure_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertToSequenceEvaluatorPure_Node_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(intPtr, ConvertToSequenceEvaluatorPure_Node_Offset), 0, ConvertToSequenceEvaluatorPure_Node_PropertyAddress.Address, Node);
		NativeReflection.InitializeValue_InContainer(ConvertToSequenceEvaluatorPure_SequenceEvaluator_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToSequenceEvaluatorPure_FunctionAddress, intPtr, ConvertToSequenceEvaluatorPure_ParamsSize);
		SequenceEvaluator = StructAsClassMarshaler<FSequenceEvaluatorReference>.FromNative(IntPtr.Add(intPtr, ConvertToSequenceEvaluatorPure_SequenceEvaluator_Offset), 0, ConvertToSequenceEvaluatorPure_SequenceEvaluator_PropertyAddress.Address);
		Result = BoolMarshaler.FromNative(IntPtr.Add(intPtr, ConvertToSequenceEvaluatorPure_Result_Offset), 0, ConvertToSequenceEvaluatorPure_Result_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:ConvertToSequenceEvaluator")]
	public unsafe static FSequenceEvaluatorReference ConvertToSequenceEvaluator(FAnimNodeReference Node, out EAnimNodeReferenceConversionResult Result)
	{
		if (!ConvertToSequenceEvaluator_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:ConvertToSequenceEvaluator");
			Result = EAnimNodeReferenceConversionResult.Failed;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToSequenceEvaluator_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToSequenceEvaluator_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertToSequenceEvaluator_Node_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(intPtr, ConvertToSequenceEvaluator_Node_Offset), 0, ConvertToSequenceEvaluator_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToSequenceEvaluator_FunctionAddress, intPtr, ConvertToSequenceEvaluator_ParamsSize);
		Result = EnumMarshaler<EAnimNodeReferenceConversionResult>.FromNative(IntPtr.Add(intPtr, ConvertToSequenceEvaluator_Result_Offset), 0, ConvertToSequenceEvaluator_Result_PropertyAddress.Address);
		return StructAsClassMarshaler<FSequenceEvaluatorReference>.FromNative(IntPtr.Add(intPtr, ConvertToSequenceEvaluator_ReturnValue_Offset), 0, ConvertToSequenceEvaluator_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:AdvanceTime")]
	public unsafe static FSequenceEvaluatorReference AdvanceTime(FAnimUpdateContext UpdateContext, FSequenceEvaluatorReference SequenceEvaluator, float PlayRate = 1f)
	{
		if (!AdvanceTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:AdvanceTime");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AdvanceTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AdvanceTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AdvanceTime_UpdateContext_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(intPtr, AdvanceTime_UpdateContext_Offset), 0, AdvanceTime_UpdateContext_PropertyAddress.Address, UpdateContext);
		NativeReflection.InitializeValue_InContainer(AdvanceTime_SequenceEvaluator_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FSequenceEvaluatorReference>.ToNative(IntPtr.Add(intPtr, AdvanceTime_SequenceEvaluator_Offset), 0, AdvanceTime_SequenceEvaluator_PropertyAddress.Address, SequenceEvaluator);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AdvanceTime_PlayRate_Offset), 0, AdvanceTime_PlayRate_PropertyAddress.Address, PlayRate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AdvanceTime_FunctionAddress, intPtr, AdvanceTime_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AdvanceTime_UpdateContext_PropertyAddress.Address, intPtr);
		return StructAsClassMarshaler<FSequenceEvaluatorReference>.FromNative(IntPtr.Add(intPtr, AdvanceTime_ReturnValue_Offset), 0, AdvanceTime_ReturnValue_PropertyAddress.Address);
	}

	static USequenceEvaluatorLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USequenceEvaluatorLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USequenceEvaluatorLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary");
		SetSequenceWithInertialBlending_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSequenceWithInertialBlending");
		SetSequenceWithInertialBlending_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSequenceWithInertialBlending_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSequenceWithInertialBlending_UpdateContext_PropertyAddress, SetSequenceWithInertialBlending_FunctionAddress, "UpdateContext");
		SetSequenceWithInertialBlending_UpdateContext_Offset = NativeReflectionCached.GetPropertyOffset(SetSequenceWithInertialBlending_FunctionAddress, "UpdateContext");
		SetSequenceWithInertialBlending_UpdateContext_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequenceWithInertialBlending_FunctionAddress, "UpdateContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSequenceWithInertialBlending_SequenceEvaluator_PropertyAddress, SetSequenceWithInertialBlending_FunctionAddress, "SequenceEvaluator");
		SetSequenceWithInertialBlending_SequenceEvaluator_Offset = NativeReflectionCached.GetPropertyOffset(SetSequenceWithInertialBlending_FunctionAddress, "SequenceEvaluator");
		SetSequenceWithInertialBlending_SequenceEvaluator_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequenceWithInertialBlending_FunctionAddress, "SequenceEvaluator", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSequenceWithInertialBlending_Sequence_PropertyAddress, SetSequenceWithInertialBlending_FunctionAddress, "Sequence");
		SetSequenceWithInertialBlending_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(SetSequenceWithInertialBlending_FunctionAddress, "Sequence");
		SetSequenceWithInertialBlending_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequenceWithInertialBlending_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSequenceWithInertialBlending_BlendTime_PropertyAddress, SetSequenceWithInertialBlending_FunctionAddress, "BlendTime");
		SetSequenceWithInertialBlending_BlendTime_Offset = NativeReflectionCached.GetPropertyOffset(SetSequenceWithInertialBlending_FunctionAddress, "BlendTime");
		SetSequenceWithInertialBlending_BlendTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequenceWithInertialBlending_FunctionAddress, "BlendTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSequenceWithInertialBlending_ReturnValue_PropertyAddress, SetSequenceWithInertialBlending_FunctionAddress, "ReturnValue");
		SetSequenceWithInertialBlending_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSequenceWithInertialBlending_FunctionAddress, "ReturnValue");
		SetSequenceWithInertialBlending_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequenceWithInertialBlending_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetSequenceWithInertialBlending_IsValid = SetSequenceWithInertialBlending_FunctionAddress != IntPtr.Zero && SetSequenceWithInertialBlending_UpdateContext_IsValid && SetSequenceWithInertialBlending_SequenceEvaluator_IsValid && SetSequenceWithInertialBlending_Sequence_IsValid && SetSequenceWithInertialBlending_BlendTime_IsValid && SetSequenceWithInertialBlending_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:SetSequenceWithInertialBlending", SetSequenceWithInertialBlending_IsValid);
		SetSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSequence");
		SetSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSequence_SequenceEvaluator_PropertyAddress, SetSequence_FunctionAddress, "SequenceEvaluator");
		SetSequence_SequenceEvaluator_Offset = NativeReflectionCached.GetPropertyOffset(SetSequence_FunctionAddress, "SequenceEvaluator");
		SetSequence_SequenceEvaluator_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequence_FunctionAddress, "SequenceEvaluator", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSequence_Sequence_PropertyAddress, SetSequence_FunctionAddress, "Sequence");
		SetSequence_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(SetSequence_FunctionAddress, "Sequence");
		SetSequence_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequence_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSequence_ReturnValue_PropertyAddress, SetSequence_FunctionAddress, "ReturnValue");
		SetSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSequence_FunctionAddress, "ReturnValue");
		SetSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSequence_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetSequence_IsValid = SetSequence_FunctionAddress != IntPtr.Zero && SetSequence_SequenceEvaluator_IsValid && SetSequence_Sequence_IsValid && SetSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:SetSequence", SetSequence_IsValid);
		SetExplicitTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetExplicitTime");
		SetExplicitTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetExplicitTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetExplicitTime_SequenceEvaluator_PropertyAddress, SetExplicitTime_FunctionAddress, "SequenceEvaluator");
		SetExplicitTime_SequenceEvaluator_Offset = NativeReflectionCached.GetPropertyOffset(SetExplicitTime_FunctionAddress, "SequenceEvaluator");
		SetExplicitTime_SequenceEvaluator_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExplicitTime_FunctionAddress, "SequenceEvaluator", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetExplicitTime_Time_PropertyAddress, SetExplicitTime_FunctionAddress, "Time");
		SetExplicitTime_Time_Offset = NativeReflectionCached.GetPropertyOffset(SetExplicitTime_FunctionAddress, "Time");
		SetExplicitTime_Time_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExplicitTime_FunctionAddress, "Time", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetExplicitTime_ReturnValue_PropertyAddress, SetExplicitTime_FunctionAddress, "ReturnValue");
		SetExplicitTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetExplicitTime_FunctionAddress, "ReturnValue");
		SetExplicitTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExplicitTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetExplicitTime_IsValid = SetExplicitTime_FunctionAddress != IntPtr.Zero && SetExplicitTime_SequenceEvaluator_IsValid && SetExplicitTime_Time_IsValid && SetExplicitTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:SetExplicitTime", SetExplicitTime_IsValid);
		GetSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSequence");
		GetSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSequence_SequenceEvaluator_PropertyAddress, GetSequence_FunctionAddress, "SequenceEvaluator");
		GetSequence_SequenceEvaluator_Offset = NativeReflectionCached.GetPropertyOffset(GetSequence_FunctionAddress, "SequenceEvaluator");
		GetSequence_SequenceEvaluator_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequence_FunctionAddress, "SequenceEvaluator", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSequence_ReturnValue_PropertyAddress, GetSequence_FunctionAddress, "ReturnValue");
		GetSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSequence_FunctionAddress, "ReturnValue");
		GetSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequence_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSequence_IsValid = GetSequence_FunctionAddress != IntPtr.Zero && GetSequence_SequenceEvaluator_IsValid && GetSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:GetSequence", GetSequence_IsValid);
		GetAccumulatedTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAccumulatedTime");
		GetAccumulatedTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAccumulatedTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAccumulatedTime_SequenceEvaluator_PropertyAddress, GetAccumulatedTime_FunctionAddress, "SequenceEvaluator");
		GetAccumulatedTime_SequenceEvaluator_Offset = NativeReflectionCached.GetPropertyOffset(GetAccumulatedTime_FunctionAddress, "SequenceEvaluator");
		GetAccumulatedTime_SequenceEvaluator_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAccumulatedTime_FunctionAddress, "SequenceEvaluator", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAccumulatedTime_ReturnValue_PropertyAddress, GetAccumulatedTime_FunctionAddress, "ReturnValue");
		GetAccumulatedTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAccumulatedTime_FunctionAddress, "ReturnValue");
		GetAccumulatedTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAccumulatedTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAccumulatedTime_IsValid = GetAccumulatedTime_FunctionAddress != IntPtr.Zero && GetAccumulatedTime_SequenceEvaluator_IsValid && GetAccumulatedTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:GetAccumulatedTime", GetAccumulatedTime_IsValid);
		ConvertToSequenceEvaluatorPure_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToSequenceEvaluatorPure");
		ConvertToSequenceEvaluatorPure_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToSequenceEvaluatorPure_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSequenceEvaluatorPure_Node_PropertyAddress, ConvertToSequenceEvaluatorPure_FunctionAddress, "Node");
		ConvertToSequenceEvaluatorPure_Node_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSequenceEvaluatorPure_FunctionAddress, "Node");
		ConvertToSequenceEvaluatorPure_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSequenceEvaluatorPure_FunctionAddress, "Node", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSequenceEvaluatorPure_SequenceEvaluator_PropertyAddress, ConvertToSequenceEvaluatorPure_FunctionAddress, "SequenceEvaluator");
		ConvertToSequenceEvaluatorPure_SequenceEvaluator_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSequenceEvaluatorPure_FunctionAddress, "SequenceEvaluator");
		ConvertToSequenceEvaluatorPure_SequenceEvaluator_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSequenceEvaluatorPure_FunctionAddress, "SequenceEvaluator", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSequenceEvaluatorPure_Result_PropertyAddress, ConvertToSequenceEvaluatorPure_FunctionAddress, "Result");
		ConvertToSequenceEvaluatorPure_Result_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSequenceEvaluatorPure_FunctionAddress, "Result");
		ConvertToSequenceEvaluatorPure_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSequenceEvaluatorPure_FunctionAddress, "Result", Classes.FBoolProperty);
		ConvertToSequenceEvaluatorPure_IsValid = ConvertToSequenceEvaluatorPure_FunctionAddress != IntPtr.Zero && ConvertToSequenceEvaluatorPure_Node_IsValid && ConvertToSequenceEvaluatorPure_SequenceEvaluator_IsValid && ConvertToSequenceEvaluatorPure_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:ConvertToSequenceEvaluatorPure", ConvertToSequenceEvaluatorPure_IsValid);
		ConvertToSequenceEvaluator_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToSequenceEvaluator");
		ConvertToSequenceEvaluator_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToSequenceEvaluator_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSequenceEvaluator_Node_PropertyAddress, ConvertToSequenceEvaluator_FunctionAddress, "Node");
		ConvertToSequenceEvaluator_Node_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSequenceEvaluator_FunctionAddress, "Node");
		ConvertToSequenceEvaluator_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSequenceEvaluator_FunctionAddress, "Node", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSequenceEvaluator_Result_PropertyAddress, ConvertToSequenceEvaluator_FunctionAddress, "Result");
		ConvertToSequenceEvaluator_Result_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSequenceEvaluator_FunctionAddress, "Result");
		ConvertToSequenceEvaluator_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSequenceEvaluator_FunctionAddress, "Result", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSequenceEvaluator_ReturnValue_PropertyAddress, ConvertToSequenceEvaluator_FunctionAddress, "ReturnValue");
		ConvertToSequenceEvaluator_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSequenceEvaluator_FunctionAddress, "ReturnValue");
		ConvertToSequenceEvaluator_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSequenceEvaluator_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ConvertToSequenceEvaluator_IsValid = ConvertToSequenceEvaluator_FunctionAddress != IntPtr.Zero && ConvertToSequenceEvaluator_Node_IsValid && ConvertToSequenceEvaluator_Result_IsValid && ConvertToSequenceEvaluator_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:ConvertToSequenceEvaluator", ConvertToSequenceEvaluator_IsValid);
		AdvanceTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AdvanceTime");
		AdvanceTime_ParamsSize = NativeReflection.GetFunctionParamsSize(AdvanceTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTime_UpdateContext_PropertyAddress, AdvanceTime_FunctionAddress, "UpdateContext");
		AdvanceTime_UpdateContext_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTime_FunctionAddress, "UpdateContext");
		AdvanceTime_UpdateContext_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTime_FunctionAddress, "UpdateContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTime_SequenceEvaluator_PropertyAddress, AdvanceTime_FunctionAddress, "SequenceEvaluator");
		AdvanceTime_SequenceEvaluator_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTime_FunctionAddress, "SequenceEvaluator");
		AdvanceTime_SequenceEvaluator_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTime_FunctionAddress, "SequenceEvaluator", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTime_PlayRate_PropertyAddress, AdvanceTime_FunctionAddress, "PlayRate");
		AdvanceTime_PlayRate_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTime_FunctionAddress, "PlayRate");
		AdvanceTime_PlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTime_FunctionAddress, "PlayRate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AdvanceTime_ReturnValue_PropertyAddress, AdvanceTime_FunctionAddress, "ReturnValue");
		AdvanceTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AdvanceTime_FunctionAddress, "ReturnValue");
		AdvanceTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AdvanceTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AdvanceTime_IsValid = AdvanceTime_FunctionAddress != IntPtr.Zero && AdvanceTime_UpdateContext_IsValid && AdvanceTime_SequenceEvaluator_IsValid && AdvanceTime_PlayRate_IsValid && AdvanceTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SequenceEvaluatorLibrary:AdvanceTime", AdvanceTime_IsValid);
	}
}
