using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AnimGraphRuntime.AnimationStateMachineLibrary", "AnimGraphRuntime", UnrealModuleType.Engine)]
public class UAnimationStateMachineLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool IsStateBlendingOut_IsValid;

	private static IntPtr IsStateBlendingOut_FunctionAddress;

	private static int IsStateBlendingOut_ParamsSize;

	private static bool IsStateBlendingOut_UpdateContext_IsValid;

	private static FFieldAddress IsStateBlendingOut_UpdateContext_PropertyAddress;

	private static int IsStateBlendingOut_UpdateContext_Offset;

	private static bool IsStateBlendingOut_Node_IsValid;

	private static FFieldAddress IsStateBlendingOut_Node_PropertyAddress;

	private static int IsStateBlendingOut_Node_Offset;

	private static bool IsStateBlendingOut_ReturnValue_IsValid;

	private static FFieldAddress IsStateBlendingOut_ReturnValue_PropertyAddress;

	private static int IsStateBlendingOut_ReturnValue_Offset;

	private static bool IsStateBlendingIn_IsValid;

	private static IntPtr IsStateBlendingIn_FunctionAddress;

	private static int IsStateBlendingIn_ParamsSize;

	private static bool IsStateBlendingIn_UpdateContext_IsValid;

	private static FFieldAddress IsStateBlendingIn_UpdateContext_PropertyAddress;

	private static int IsStateBlendingIn_UpdateContext_Offset;

	private static bool IsStateBlendingIn_Node_IsValid;

	private static FFieldAddress IsStateBlendingIn_Node_PropertyAddress;

	private static int IsStateBlendingIn_Node_Offset;

	private static bool IsStateBlendingIn_ReturnValue_IsValid;

	private static FFieldAddress IsStateBlendingIn_ReturnValue_PropertyAddress;

	private static int IsStateBlendingIn_ReturnValue_Offset;

	private static bool ConvertToAnimationStateResultPure_IsValid;

	private static IntPtr ConvertToAnimationStateResultPure_FunctionAddress;

	private static int ConvertToAnimationStateResultPure_ParamsSize;

	private static bool ConvertToAnimationStateResultPure_Node_IsValid;

	private static FFieldAddress ConvertToAnimationStateResultPure_Node_PropertyAddress;

	private static int ConvertToAnimationStateResultPure_Node_Offset;

	private static bool ConvertToAnimationStateResultPure_AnimationState_IsValid;

	private static FFieldAddress ConvertToAnimationStateResultPure_AnimationState_PropertyAddress;

	private static int ConvertToAnimationStateResultPure_AnimationState_Offset;

	private static bool ConvertToAnimationStateResultPure_Result_IsValid;

	private static FFieldAddress ConvertToAnimationStateResultPure_Result_PropertyAddress;

	private static int ConvertToAnimationStateResultPure_Result_Offset;

	private static bool ConvertToAnimationStateResult_IsValid;

	private static IntPtr ConvertToAnimationStateResult_FunctionAddress;

	private static int ConvertToAnimationStateResult_ParamsSize;

	private static bool ConvertToAnimationStateResult_Node_IsValid;

	private static FFieldAddress ConvertToAnimationStateResult_Node_PropertyAddress;

	private static int ConvertToAnimationStateResult_Node_Offset;

	private static bool ConvertToAnimationStateResult_AnimationState_IsValid;

	private static FFieldAddress ConvertToAnimationStateResult_AnimationState_PropertyAddress;

	private static int ConvertToAnimationStateResult_AnimationState_Offset;

	private static bool ConvertToAnimationStateResult_Result_IsValid;

	private static FFieldAddress ConvertToAnimationStateResult_Result_PropertyAddress;

	private static int ConvertToAnimationStateResult_Result_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimationStateMachineLibrary:IsStateBlendingOut")]
	public unsafe static bool IsStateBlendingOut(FAnimUpdateContext UpdateContext, FAnimationStateResultReference Node)
	{
		if (!IsStateBlendingOut_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.AnimationStateMachineLibrary:IsStateBlendingOut");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsStateBlendingOut_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsStateBlendingOut_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsStateBlendingOut_UpdateContext_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(intPtr, IsStateBlendingOut_UpdateContext_Offset), 0, IsStateBlendingOut_UpdateContext_PropertyAddress.Address, UpdateContext);
		NativeReflection.InitializeValue_InContainer(IsStateBlendingOut_Node_PropertyAddress.Address, intPtr);
		FAnimationStateResultReference.ToNative(IntPtr.Add(intPtr, IsStateBlendingOut_Node_Offset), 0, IsStateBlendingOut_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsStateBlendingOut_FunctionAddress, intPtr, IsStateBlendingOut_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsStateBlendingOut_UpdateContext_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsStateBlendingOut_ReturnValue_Offset), 0, IsStateBlendingOut_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimationStateMachineLibrary:IsStateBlendingIn")]
	public unsafe static bool IsStateBlendingIn(FAnimUpdateContext UpdateContext, FAnimationStateResultReference Node)
	{
		if (!IsStateBlendingIn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.AnimationStateMachineLibrary:IsStateBlendingIn");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsStateBlendingIn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsStateBlendingIn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsStateBlendingIn_UpdateContext_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(intPtr, IsStateBlendingIn_UpdateContext_Offset), 0, IsStateBlendingIn_UpdateContext_PropertyAddress.Address, UpdateContext);
		NativeReflection.InitializeValue_InContainer(IsStateBlendingIn_Node_PropertyAddress.Address, intPtr);
		FAnimationStateResultReference.ToNative(IntPtr.Add(intPtr, IsStateBlendingIn_Node_Offset), 0, IsStateBlendingIn_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsStateBlendingIn_FunctionAddress, intPtr, IsStateBlendingIn_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsStateBlendingIn_UpdateContext_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsStateBlendingIn_ReturnValue_Offset), 0, IsStateBlendingIn_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimationStateMachineLibrary:ConvertToAnimationStateResultPure")]
	public unsafe static void ConvertToAnimationStateResultPure(FAnimNodeReference Node, out FAnimationStateResultReference AnimationState, out bool Result)
	{
		if (!ConvertToAnimationStateResultPure_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.AnimationStateMachineLibrary:ConvertToAnimationStateResultPure");
			AnimationState = default(FAnimationStateResultReference);
			Result = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToAnimationStateResultPure_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToAnimationStateResultPure_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertToAnimationStateResultPure_Node_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(intPtr, ConvertToAnimationStateResultPure_Node_Offset), 0, ConvertToAnimationStateResultPure_Node_PropertyAddress.Address, Node);
		NativeReflection.InitializeValue_InContainer(ConvertToAnimationStateResultPure_AnimationState_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToAnimationStateResultPure_FunctionAddress, intPtr, ConvertToAnimationStateResultPure_ParamsSize);
		AnimationState = FAnimationStateResultReference.FromNative(IntPtr.Add(intPtr, ConvertToAnimationStateResultPure_AnimationState_Offset), 0, ConvertToAnimationStateResultPure_AnimationState_PropertyAddress.Address);
		Result = BoolMarshaler.FromNative(IntPtr.Add(intPtr, ConvertToAnimationStateResultPure_Result_Offset), 0, ConvertToAnimationStateResultPure_Result_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimationStateMachineLibrary:ConvertToAnimationStateResult")]
	public unsafe static void ConvertToAnimationStateResult(FAnimNodeReference Node, out FAnimationStateResultReference AnimationState, out EAnimNodeReferenceConversionResult Result)
	{
		if (!ConvertToAnimationStateResult_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.AnimationStateMachineLibrary:ConvertToAnimationStateResult");
			AnimationState = default(FAnimationStateResultReference);
			Result = EAnimNodeReferenceConversionResult.Failed;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToAnimationStateResult_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToAnimationStateResult_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertToAnimationStateResult_Node_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(intPtr, ConvertToAnimationStateResult_Node_Offset), 0, ConvertToAnimationStateResult_Node_PropertyAddress.Address, Node);
		NativeReflection.InitializeValue_InContainer(ConvertToAnimationStateResult_AnimationState_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToAnimationStateResult_FunctionAddress, intPtr, ConvertToAnimationStateResult_ParamsSize);
		AnimationState = FAnimationStateResultReference.FromNative(IntPtr.Add(intPtr, ConvertToAnimationStateResult_AnimationState_Offset), 0, ConvertToAnimationStateResult_AnimationState_PropertyAddress.Address);
		Result = EnumMarshaler<EAnimNodeReferenceConversionResult>.FromNative(IntPtr.Add(intPtr, ConvertToAnimationStateResult_Result_Offset), 0, ConvertToAnimationStateResult_Result_PropertyAddress.Address);
	}

	static UAnimationStateMachineLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimationStateMachineLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimationStateMachineLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AnimGraphRuntime.AnimationStateMachineLibrary");
		IsStateBlendingOut_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsStateBlendingOut");
		IsStateBlendingOut_ParamsSize = NativeReflection.GetFunctionParamsSize(IsStateBlendingOut_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsStateBlendingOut_UpdateContext_PropertyAddress, IsStateBlendingOut_FunctionAddress, "UpdateContext");
		IsStateBlendingOut_UpdateContext_Offset = NativeReflectionCached.GetPropertyOffset(IsStateBlendingOut_FunctionAddress, "UpdateContext");
		IsStateBlendingOut_UpdateContext_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStateBlendingOut_FunctionAddress, "UpdateContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsStateBlendingOut_Node_PropertyAddress, IsStateBlendingOut_FunctionAddress, "Node");
		IsStateBlendingOut_Node_Offset = NativeReflectionCached.GetPropertyOffset(IsStateBlendingOut_FunctionAddress, "Node");
		IsStateBlendingOut_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStateBlendingOut_FunctionAddress, "Node", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsStateBlendingOut_ReturnValue_PropertyAddress, IsStateBlendingOut_FunctionAddress, "ReturnValue");
		IsStateBlendingOut_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsStateBlendingOut_FunctionAddress, "ReturnValue");
		IsStateBlendingOut_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStateBlendingOut_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsStateBlendingOut_IsValid = IsStateBlendingOut_FunctionAddress != IntPtr.Zero && IsStateBlendingOut_UpdateContext_IsValid && IsStateBlendingOut_Node_IsValid && IsStateBlendingOut_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.AnimationStateMachineLibrary:IsStateBlendingOut", IsStateBlendingOut_IsValid);
		IsStateBlendingIn_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsStateBlendingIn");
		IsStateBlendingIn_ParamsSize = NativeReflection.GetFunctionParamsSize(IsStateBlendingIn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsStateBlendingIn_UpdateContext_PropertyAddress, IsStateBlendingIn_FunctionAddress, "UpdateContext");
		IsStateBlendingIn_UpdateContext_Offset = NativeReflectionCached.GetPropertyOffset(IsStateBlendingIn_FunctionAddress, "UpdateContext");
		IsStateBlendingIn_UpdateContext_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStateBlendingIn_FunctionAddress, "UpdateContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsStateBlendingIn_Node_PropertyAddress, IsStateBlendingIn_FunctionAddress, "Node");
		IsStateBlendingIn_Node_Offset = NativeReflectionCached.GetPropertyOffset(IsStateBlendingIn_FunctionAddress, "Node");
		IsStateBlendingIn_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStateBlendingIn_FunctionAddress, "Node", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsStateBlendingIn_ReturnValue_PropertyAddress, IsStateBlendingIn_FunctionAddress, "ReturnValue");
		IsStateBlendingIn_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsStateBlendingIn_FunctionAddress, "ReturnValue");
		IsStateBlendingIn_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStateBlendingIn_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsStateBlendingIn_IsValid = IsStateBlendingIn_FunctionAddress != IntPtr.Zero && IsStateBlendingIn_UpdateContext_IsValid && IsStateBlendingIn_Node_IsValid && IsStateBlendingIn_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.AnimationStateMachineLibrary:IsStateBlendingIn", IsStateBlendingIn_IsValid);
		ConvertToAnimationStateResultPure_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToAnimationStateResultPure");
		ConvertToAnimationStateResultPure_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToAnimationStateResultPure_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToAnimationStateResultPure_Node_PropertyAddress, ConvertToAnimationStateResultPure_FunctionAddress, "Node");
		ConvertToAnimationStateResultPure_Node_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToAnimationStateResultPure_FunctionAddress, "Node");
		ConvertToAnimationStateResultPure_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToAnimationStateResultPure_FunctionAddress, "Node", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToAnimationStateResultPure_AnimationState_PropertyAddress, ConvertToAnimationStateResultPure_FunctionAddress, "AnimationState");
		ConvertToAnimationStateResultPure_AnimationState_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToAnimationStateResultPure_FunctionAddress, "AnimationState");
		ConvertToAnimationStateResultPure_AnimationState_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToAnimationStateResultPure_FunctionAddress, "AnimationState", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToAnimationStateResultPure_Result_PropertyAddress, ConvertToAnimationStateResultPure_FunctionAddress, "Result");
		ConvertToAnimationStateResultPure_Result_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToAnimationStateResultPure_FunctionAddress, "Result");
		ConvertToAnimationStateResultPure_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToAnimationStateResultPure_FunctionAddress, "Result", Classes.FBoolProperty);
		ConvertToAnimationStateResultPure_IsValid = ConvertToAnimationStateResultPure_FunctionAddress != IntPtr.Zero && ConvertToAnimationStateResultPure_Node_IsValid && ConvertToAnimationStateResultPure_AnimationState_IsValid && ConvertToAnimationStateResultPure_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.AnimationStateMachineLibrary:ConvertToAnimationStateResultPure", ConvertToAnimationStateResultPure_IsValid);
		ConvertToAnimationStateResult_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToAnimationStateResult");
		ConvertToAnimationStateResult_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToAnimationStateResult_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToAnimationStateResult_Node_PropertyAddress, ConvertToAnimationStateResult_FunctionAddress, "Node");
		ConvertToAnimationStateResult_Node_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToAnimationStateResult_FunctionAddress, "Node");
		ConvertToAnimationStateResult_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToAnimationStateResult_FunctionAddress, "Node", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToAnimationStateResult_AnimationState_PropertyAddress, ConvertToAnimationStateResult_FunctionAddress, "AnimationState");
		ConvertToAnimationStateResult_AnimationState_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToAnimationStateResult_FunctionAddress, "AnimationState");
		ConvertToAnimationStateResult_AnimationState_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToAnimationStateResult_FunctionAddress, "AnimationState", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToAnimationStateResult_Result_PropertyAddress, ConvertToAnimationStateResult_FunctionAddress, "Result");
		ConvertToAnimationStateResult_Result_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToAnimationStateResult_FunctionAddress, "Result");
		ConvertToAnimationStateResult_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToAnimationStateResult_FunctionAddress, "Result", Classes.FEnumProperty);
		ConvertToAnimationStateResult_IsValid = ConvertToAnimationStateResult_FunctionAddress != IntPtr.Zero && ConvertToAnimationStateResult_Node_IsValid && ConvertToAnimationStateResult_AnimationState_IsValid && ConvertToAnimationStateResult_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.AnimationStateMachineLibrary:ConvertToAnimationStateResult", ConvertToAnimationStateResult_IsValid);
	}
}
