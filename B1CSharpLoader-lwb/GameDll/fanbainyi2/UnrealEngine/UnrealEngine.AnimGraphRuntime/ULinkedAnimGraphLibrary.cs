using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AnimGraphRuntime.LinkedAnimGraphLibrary", "AnimGraphRuntime", UnrealModuleType.Engine)]
public class ULinkedAnimGraphLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool HasLinkedAnimInstance_IsValid;

	private static IntPtr HasLinkedAnimInstance_FunctionAddress;

	private static int HasLinkedAnimInstance_ParamsSize;

	private static bool HasLinkedAnimInstance_Node_IsValid;

	private static FFieldAddress HasLinkedAnimInstance_Node_PropertyAddress;

	private static int HasLinkedAnimInstance_Node_Offset;

	private static bool HasLinkedAnimInstance_ReturnValue_IsValid;

	private static FFieldAddress HasLinkedAnimInstance_ReturnValue_PropertyAddress;

	private static int HasLinkedAnimInstance_ReturnValue_Offset;

	private static bool GetLinkedAnimInstance_IsValid;

	private static IntPtr GetLinkedAnimInstance_FunctionAddress;

	private static int GetLinkedAnimInstance_ParamsSize;

	private static bool GetLinkedAnimInstance_Node_IsValid;

	private static FFieldAddress GetLinkedAnimInstance_Node_PropertyAddress;

	private static int GetLinkedAnimInstance_Node_Offset;

	private static bool GetLinkedAnimInstance_ReturnValue_IsValid;

	private static FFieldAddress GetLinkedAnimInstance_ReturnValue_PropertyAddress;

	private static int GetLinkedAnimInstance_ReturnValue_Offset;

	private static bool ConvertToLinkedAnimGraphPure_IsValid;

	private static IntPtr ConvertToLinkedAnimGraphPure_FunctionAddress;

	private static int ConvertToLinkedAnimGraphPure_ParamsSize;

	private static bool ConvertToLinkedAnimGraphPure_Node_IsValid;

	private static FFieldAddress ConvertToLinkedAnimGraphPure_Node_PropertyAddress;

	private static int ConvertToLinkedAnimGraphPure_Node_Offset;

	private static bool ConvertToLinkedAnimGraphPure_LinkedAnimGraph_IsValid;

	private static FFieldAddress ConvertToLinkedAnimGraphPure_LinkedAnimGraph_PropertyAddress;

	private static int ConvertToLinkedAnimGraphPure_LinkedAnimGraph_Offset;

	private static bool ConvertToLinkedAnimGraphPure_Result_IsValid;

	private static FFieldAddress ConvertToLinkedAnimGraphPure_Result_PropertyAddress;

	private static int ConvertToLinkedAnimGraphPure_Result_Offset;

	private static bool ConvertToLinkedAnimGraph_IsValid;

	private static IntPtr ConvertToLinkedAnimGraph_FunctionAddress;

	private static int ConvertToLinkedAnimGraph_ParamsSize;

	private static bool ConvertToLinkedAnimGraph_Node_IsValid;

	private static FFieldAddress ConvertToLinkedAnimGraph_Node_PropertyAddress;

	private static int ConvertToLinkedAnimGraph_Node_Offset;

	private static bool ConvertToLinkedAnimGraph_Result_IsValid;

	private static FFieldAddress ConvertToLinkedAnimGraph_Result_PropertyAddress;

	private static int ConvertToLinkedAnimGraph_Result_Offset;

	private static bool ConvertToLinkedAnimGraph_ReturnValue_IsValid;

	private static FFieldAddress ConvertToLinkedAnimGraph_ReturnValue_PropertyAddress;

	private static int ConvertToLinkedAnimGraph_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.LinkedAnimGraphLibrary:HasLinkedAnimInstance")]
	public unsafe static bool HasLinkedAnimInstance(FLinkedAnimGraphReference Node)
	{
		if (!HasLinkedAnimInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.LinkedAnimGraphLibrary:HasLinkedAnimInstance");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasLinkedAnimInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasLinkedAnimInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(HasLinkedAnimInstance_Node_PropertyAddress.Address, intPtr);
		FLinkedAnimGraphReference.ToNative(IntPtr.Add(intPtr, HasLinkedAnimInstance_Node_Offset), 0, HasLinkedAnimInstance_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HasLinkedAnimInstance_FunctionAddress, intPtr, HasLinkedAnimInstance_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasLinkedAnimInstance_ReturnValue_Offset), 0, HasLinkedAnimInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.LinkedAnimGraphLibrary:GetLinkedAnimInstance")]
	public unsafe static UAnimInstance GetLinkedAnimInstance(FLinkedAnimGraphReference Node)
	{
		if (!GetLinkedAnimInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.LinkedAnimGraphLibrary:GetLinkedAnimInstance");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinkedAnimInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinkedAnimInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLinkedAnimInstance_Node_PropertyAddress.Address, intPtr);
		FLinkedAnimGraphReference.ToNative(IntPtr.Add(intPtr, GetLinkedAnimInstance_Node_Offset), 0, GetLinkedAnimInstance_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLinkedAnimInstance_FunctionAddress, intPtr, GetLinkedAnimInstance_ParamsSize);
		return UObjectMarshaler<UAnimInstance>.FromNative(IntPtr.Add(intPtr, GetLinkedAnimInstance_ReturnValue_Offset), 0, GetLinkedAnimInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.LinkedAnimGraphLibrary:ConvertToLinkedAnimGraphPure")]
	public unsafe static void ConvertToLinkedAnimGraphPure(FAnimNodeReference Node, out FLinkedAnimGraphReference LinkedAnimGraph, out bool Result)
	{
		if (!ConvertToLinkedAnimGraphPure_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.LinkedAnimGraphLibrary:ConvertToLinkedAnimGraphPure");
			LinkedAnimGraph = default(FLinkedAnimGraphReference);
			Result = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToLinkedAnimGraphPure_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToLinkedAnimGraphPure_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertToLinkedAnimGraphPure_Node_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(intPtr, ConvertToLinkedAnimGraphPure_Node_Offset), 0, ConvertToLinkedAnimGraphPure_Node_PropertyAddress.Address, Node);
		NativeReflection.InitializeValue_InContainer(ConvertToLinkedAnimGraphPure_LinkedAnimGraph_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToLinkedAnimGraphPure_FunctionAddress, intPtr, ConvertToLinkedAnimGraphPure_ParamsSize);
		LinkedAnimGraph = FLinkedAnimGraphReference.FromNative(IntPtr.Add(intPtr, ConvertToLinkedAnimGraphPure_LinkedAnimGraph_Offset), 0, ConvertToLinkedAnimGraphPure_LinkedAnimGraph_PropertyAddress.Address);
		Result = BoolMarshaler.FromNative(IntPtr.Add(intPtr, ConvertToLinkedAnimGraphPure_Result_Offset), 0, ConvertToLinkedAnimGraphPure_Result_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimGraphRuntime.LinkedAnimGraphLibrary:ConvertToLinkedAnimGraph")]
	public unsafe static FLinkedAnimGraphReference ConvertToLinkedAnimGraph(FAnimNodeReference Node, out EAnimNodeReferenceConversionResult Result)
	{
		if (!ConvertToLinkedAnimGraph_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.LinkedAnimGraphLibrary:ConvertToLinkedAnimGraph");
			Result = EAnimNodeReferenceConversionResult.Failed;
			return default(FLinkedAnimGraphReference);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToLinkedAnimGraph_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToLinkedAnimGraph_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertToLinkedAnimGraph_Node_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(intPtr, ConvertToLinkedAnimGraph_Node_Offset), 0, ConvertToLinkedAnimGraph_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToLinkedAnimGraph_FunctionAddress, intPtr, ConvertToLinkedAnimGraph_ParamsSize);
		Result = EnumMarshaler<EAnimNodeReferenceConversionResult>.FromNative(IntPtr.Add(intPtr, ConvertToLinkedAnimGraph_Result_Offset), 0, ConvertToLinkedAnimGraph_Result_PropertyAddress.Address);
		return FLinkedAnimGraphReference.FromNative(IntPtr.Add(intPtr, ConvertToLinkedAnimGraph_ReturnValue_Offset), 0, ConvertToLinkedAnimGraph_ReturnValue_PropertyAddress.Address);
	}

	static ULinkedAnimGraphLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULinkedAnimGraphLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULinkedAnimGraphLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AnimGraphRuntime.LinkedAnimGraphLibrary");
		HasLinkedAnimInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HasLinkedAnimInstance");
		HasLinkedAnimInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(HasLinkedAnimInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasLinkedAnimInstance_Node_PropertyAddress, HasLinkedAnimInstance_FunctionAddress, "Node");
		HasLinkedAnimInstance_Node_Offset = NativeReflectionCached.GetPropertyOffset(HasLinkedAnimInstance_FunctionAddress, "Node");
		HasLinkedAnimInstance_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(HasLinkedAnimInstance_FunctionAddress, "Node", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HasLinkedAnimInstance_ReturnValue_PropertyAddress, HasLinkedAnimInstance_FunctionAddress, "ReturnValue");
		HasLinkedAnimInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasLinkedAnimInstance_FunctionAddress, "ReturnValue");
		HasLinkedAnimInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasLinkedAnimInstance_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasLinkedAnimInstance_IsValid = HasLinkedAnimInstance_FunctionAddress != IntPtr.Zero && HasLinkedAnimInstance_Node_IsValid && HasLinkedAnimInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.LinkedAnimGraphLibrary:HasLinkedAnimInstance", HasLinkedAnimInstance_IsValid);
		GetLinkedAnimInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLinkedAnimInstance");
		GetLinkedAnimInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinkedAnimInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinkedAnimInstance_Node_PropertyAddress, GetLinkedAnimInstance_FunctionAddress, "Node");
		GetLinkedAnimInstance_Node_Offset = NativeReflectionCached.GetPropertyOffset(GetLinkedAnimInstance_FunctionAddress, "Node");
		GetLinkedAnimInstance_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinkedAnimInstance_FunctionAddress, "Node", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinkedAnimInstance_ReturnValue_PropertyAddress, GetLinkedAnimInstance_FunctionAddress, "ReturnValue");
		GetLinkedAnimInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLinkedAnimInstance_FunctionAddress, "ReturnValue");
		GetLinkedAnimInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinkedAnimInstance_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetLinkedAnimInstance_IsValid = GetLinkedAnimInstance_FunctionAddress != IntPtr.Zero && GetLinkedAnimInstance_Node_IsValid && GetLinkedAnimInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.LinkedAnimGraphLibrary:GetLinkedAnimInstance", GetLinkedAnimInstance_IsValid);
		ConvertToLinkedAnimGraphPure_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToLinkedAnimGraphPure");
		ConvertToLinkedAnimGraphPure_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToLinkedAnimGraphPure_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToLinkedAnimGraphPure_Node_PropertyAddress, ConvertToLinkedAnimGraphPure_FunctionAddress, "Node");
		ConvertToLinkedAnimGraphPure_Node_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToLinkedAnimGraphPure_FunctionAddress, "Node");
		ConvertToLinkedAnimGraphPure_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToLinkedAnimGraphPure_FunctionAddress, "Node", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToLinkedAnimGraphPure_LinkedAnimGraph_PropertyAddress, ConvertToLinkedAnimGraphPure_FunctionAddress, "LinkedAnimGraph");
		ConvertToLinkedAnimGraphPure_LinkedAnimGraph_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToLinkedAnimGraphPure_FunctionAddress, "LinkedAnimGraph");
		ConvertToLinkedAnimGraphPure_LinkedAnimGraph_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToLinkedAnimGraphPure_FunctionAddress, "LinkedAnimGraph", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToLinkedAnimGraphPure_Result_PropertyAddress, ConvertToLinkedAnimGraphPure_FunctionAddress, "Result");
		ConvertToLinkedAnimGraphPure_Result_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToLinkedAnimGraphPure_FunctionAddress, "Result");
		ConvertToLinkedAnimGraphPure_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToLinkedAnimGraphPure_FunctionAddress, "Result", Classes.FBoolProperty);
		ConvertToLinkedAnimGraphPure_IsValid = ConvertToLinkedAnimGraphPure_FunctionAddress != IntPtr.Zero && ConvertToLinkedAnimGraphPure_Node_IsValid && ConvertToLinkedAnimGraphPure_LinkedAnimGraph_IsValid && ConvertToLinkedAnimGraphPure_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.LinkedAnimGraphLibrary:ConvertToLinkedAnimGraphPure", ConvertToLinkedAnimGraphPure_IsValid);
		ConvertToLinkedAnimGraph_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToLinkedAnimGraph");
		ConvertToLinkedAnimGraph_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToLinkedAnimGraph_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToLinkedAnimGraph_Node_PropertyAddress, ConvertToLinkedAnimGraph_FunctionAddress, "Node");
		ConvertToLinkedAnimGraph_Node_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToLinkedAnimGraph_FunctionAddress, "Node");
		ConvertToLinkedAnimGraph_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToLinkedAnimGraph_FunctionAddress, "Node", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToLinkedAnimGraph_Result_PropertyAddress, ConvertToLinkedAnimGraph_FunctionAddress, "Result");
		ConvertToLinkedAnimGraph_Result_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToLinkedAnimGraph_FunctionAddress, "Result");
		ConvertToLinkedAnimGraph_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToLinkedAnimGraph_FunctionAddress, "Result", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToLinkedAnimGraph_ReturnValue_PropertyAddress, ConvertToLinkedAnimGraph_FunctionAddress, "ReturnValue");
		ConvertToLinkedAnimGraph_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToLinkedAnimGraph_FunctionAddress, "ReturnValue");
		ConvertToLinkedAnimGraph_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToLinkedAnimGraph_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ConvertToLinkedAnimGraph_IsValid = ConvertToLinkedAnimGraph_FunctionAddress != IntPtr.Zero && ConvertToLinkedAnimGraph_Node_IsValid && ConvertToLinkedAnimGraph_Result_IsValid && ConvertToLinkedAnimGraph_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.LinkedAnimGraphLibrary:ConvertToLinkedAnimGraph", ConvertToLinkedAnimGraph_IsValid);
	}
}
