using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AnimGraphRuntime.SkeletalControlLibrary", "AnimGraphRuntime", UnrealModuleType.Engine)]
public class USkeletalControlLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetAlpha_IsValid;

	private static IntPtr SetAlpha_FunctionAddress;

	private static int SetAlpha_ParamsSize;

	private static bool SetAlpha_SkeletalControl_IsValid;

	private static FFieldAddress SetAlpha_SkeletalControl_PropertyAddress;

	private static int SetAlpha_SkeletalControl_Offset;

	private static bool SetAlpha_Alpha_IsValid;

	private static FFieldAddress SetAlpha_Alpha_PropertyAddress;

	private static int SetAlpha_Alpha_Offset;

	private static bool SetAlpha_ReturnValue_IsValid;

	private static FFieldAddress SetAlpha_ReturnValue_PropertyAddress;

	private static int SetAlpha_ReturnValue_Offset;

	private static bool GetAlpha_IsValid;

	private static IntPtr GetAlpha_FunctionAddress;

	private static int GetAlpha_ParamsSize;

	private static bool GetAlpha_SkeletalControl_IsValid;

	private static FFieldAddress GetAlpha_SkeletalControl_PropertyAddress;

	private static int GetAlpha_SkeletalControl_Offset;

	private static bool GetAlpha_ReturnValue_IsValid;

	private static FFieldAddress GetAlpha_ReturnValue_PropertyAddress;

	private static int GetAlpha_ReturnValue_Offset;

	private static bool ConvertToSkeletalControlPure_IsValid;

	private static IntPtr ConvertToSkeletalControlPure_FunctionAddress;

	private static int ConvertToSkeletalControlPure_ParamsSize;

	private static bool ConvertToSkeletalControlPure_Node_IsValid;

	private static FFieldAddress ConvertToSkeletalControlPure_Node_PropertyAddress;

	private static int ConvertToSkeletalControlPure_Node_Offset;

	private static bool ConvertToSkeletalControlPure_SkeletalControl_IsValid;

	private static FFieldAddress ConvertToSkeletalControlPure_SkeletalControl_PropertyAddress;

	private static int ConvertToSkeletalControlPure_SkeletalControl_Offset;

	private static bool ConvertToSkeletalControlPure_Result_IsValid;

	private static FFieldAddress ConvertToSkeletalControlPure_Result_PropertyAddress;

	private static int ConvertToSkeletalControlPure_Result_Offset;

	private static bool ConvertToSkeletalControl_IsValid;

	private static IntPtr ConvertToSkeletalControl_FunctionAddress;

	private static int ConvertToSkeletalControl_ParamsSize;

	private static bool ConvertToSkeletalControl_Node_IsValid;

	private static FFieldAddress ConvertToSkeletalControl_Node_PropertyAddress;

	private static int ConvertToSkeletalControl_Node_Offset;

	private static bool ConvertToSkeletalControl_Result_IsValid;

	private static FFieldAddress ConvertToSkeletalControl_Result_PropertyAddress;

	private static int ConvertToSkeletalControl_Result_Offset;

	private static bool ConvertToSkeletalControl_ReturnValue_IsValid;

	private static FFieldAddress ConvertToSkeletalControl_ReturnValue_PropertyAddress;

	private static int ConvertToSkeletalControl_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimGraphRuntime.SkeletalControlLibrary:SetAlpha")]
	public unsafe static FSkeletalControlReference SetAlpha(FSkeletalControlReference SkeletalControl, float Alpha)
	{
		if (!SetAlpha_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SkeletalControlLibrary:SetAlpha");
			return default(FSkeletalControlReference);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAlpha_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAlpha_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetAlpha_SkeletalControl_PropertyAddress.Address, intPtr);
		FSkeletalControlReference.ToNative(IntPtr.Add(intPtr, SetAlpha_SkeletalControl_Offset), 0, SetAlpha_SkeletalControl_PropertyAddress.Address, SkeletalControl);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAlpha_Alpha_Offset), 0, SetAlpha_Alpha_PropertyAddress.Address, Alpha);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAlpha_FunctionAddress, intPtr, SetAlpha_ParamsSize);
		return FSkeletalControlReference.FromNative(IntPtr.Add(intPtr, SetAlpha_ReturnValue_Offset), 0, SetAlpha_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.SkeletalControlLibrary:GetAlpha")]
	public unsafe static float GetAlpha(FSkeletalControlReference SkeletalControl)
	{
		if (!GetAlpha_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SkeletalControlLibrary:GetAlpha");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAlpha_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAlpha_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAlpha_SkeletalControl_PropertyAddress.Address, intPtr);
		FSkeletalControlReference.ToNative(IntPtr.Add(intPtr, GetAlpha_SkeletalControl_Offset), 0, GetAlpha_SkeletalControl_PropertyAddress.Address, SkeletalControl);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAlpha_FunctionAddress, intPtr, GetAlpha_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetAlpha_ReturnValue_Offset), 0, GetAlpha_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.SkeletalControlLibrary:ConvertToSkeletalControlPure")]
	public unsafe static void ConvertToSkeletalControlPure(FAnimNodeReference Node, out FSkeletalControlReference SkeletalControl, out bool Result)
	{
		if (!ConvertToSkeletalControlPure_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SkeletalControlLibrary:ConvertToSkeletalControlPure");
			SkeletalControl = default(FSkeletalControlReference);
			Result = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToSkeletalControlPure_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToSkeletalControlPure_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertToSkeletalControlPure_Node_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(intPtr, ConvertToSkeletalControlPure_Node_Offset), 0, ConvertToSkeletalControlPure_Node_PropertyAddress.Address, Node);
		NativeReflection.InitializeValue_InContainer(ConvertToSkeletalControlPure_SkeletalControl_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToSkeletalControlPure_FunctionAddress, intPtr, ConvertToSkeletalControlPure_ParamsSize);
		SkeletalControl = FSkeletalControlReference.FromNative(IntPtr.Add(intPtr, ConvertToSkeletalControlPure_SkeletalControl_Offset), 0, ConvertToSkeletalControlPure_SkeletalControl_PropertyAddress.Address);
		Result = BoolMarshaler.FromNative(IntPtr.Add(intPtr, ConvertToSkeletalControlPure_Result_Offset), 0, ConvertToSkeletalControlPure_Result_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimGraphRuntime.SkeletalControlLibrary:ConvertToSkeletalControl")]
	public unsafe static FSkeletalControlReference ConvertToSkeletalControl(FAnimNodeReference Node, out EAnimNodeReferenceConversionResult Result)
	{
		if (!ConvertToSkeletalControl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.SkeletalControlLibrary:ConvertToSkeletalControl");
			Result = EAnimNodeReferenceConversionResult.Failed;
			return default(FSkeletalControlReference);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToSkeletalControl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToSkeletalControl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertToSkeletalControl_Node_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(intPtr, ConvertToSkeletalControl_Node_Offset), 0, ConvertToSkeletalControl_Node_PropertyAddress.Address, Node);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToSkeletalControl_FunctionAddress, intPtr, ConvertToSkeletalControl_ParamsSize);
		Result = EnumMarshaler<EAnimNodeReferenceConversionResult>.FromNative(IntPtr.Add(intPtr, ConvertToSkeletalControl_Result_Offset), 0, ConvertToSkeletalControl_Result_PropertyAddress.Address);
		return FSkeletalControlReference.FromNative(IntPtr.Add(intPtr, ConvertToSkeletalControl_ReturnValue_Offset), 0, ConvertToSkeletalControl_ReturnValue_PropertyAddress.Address);
	}

	static USkeletalControlLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USkeletalControlLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USkeletalControlLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AnimGraphRuntime.SkeletalControlLibrary");
		SetAlpha_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAlpha");
		SetAlpha_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAlpha_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAlpha_SkeletalControl_PropertyAddress, SetAlpha_FunctionAddress, "SkeletalControl");
		SetAlpha_SkeletalControl_Offset = NativeReflectionCached.GetPropertyOffset(SetAlpha_FunctionAddress, "SkeletalControl");
		SetAlpha_SkeletalControl_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAlpha_FunctionAddress, "SkeletalControl", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAlpha_Alpha_PropertyAddress, SetAlpha_FunctionAddress, "Alpha");
		SetAlpha_Alpha_Offset = NativeReflectionCached.GetPropertyOffset(SetAlpha_FunctionAddress, "Alpha");
		SetAlpha_Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAlpha_FunctionAddress, "Alpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAlpha_ReturnValue_PropertyAddress, SetAlpha_FunctionAddress, "ReturnValue");
		SetAlpha_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAlpha_FunctionAddress, "ReturnValue");
		SetAlpha_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAlpha_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetAlpha_IsValid = SetAlpha_FunctionAddress != IntPtr.Zero && SetAlpha_SkeletalControl_IsValid && SetAlpha_Alpha_IsValid && SetAlpha_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SkeletalControlLibrary:SetAlpha", SetAlpha_IsValid);
		GetAlpha_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAlpha");
		GetAlpha_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAlpha_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAlpha_SkeletalControl_PropertyAddress, GetAlpha_FunctionAddress, "SkeletalControl");
		GetAlpha_SkeletalControl_Offset = NativeReflectionCached.GetPropertyOffset(GetAlpha_FunctionAddress, "SkeletalControl");
		GetAlpha_SkeletalControl_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAlpha_FunctionAddress, "SkeletalControl", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAlpha_ReturnValue_PropertyAddress, GetAlpha_FunctionAddress, "ReturnValue");
		GetAlpha_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAlpha_FunctionAddress, "ReturnValue");
		GetAlpha_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAlpha_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAlpha_IsValid = GetAlpha_FunctionAddress != IntPtr.Zero && GetAlpha_SkeletalControl_IsValid && GetAlpha_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SkeletalControlLibrary:GetAlpha", GetAlpha_IsValid);
		ConvertToSkeletalControlPure_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToSkeletalControlPure");
		ConvertToSkeletalControlPure_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToSkeletalControlPure_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSkeletalControlPure_Node_PropertyAddress, ConvertToSkeletalControlPure_FunctionAddress, "Node");
		ConvertToSkeletalControlPure_Node_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSkeletalControlPure_FunctionAddress, "Node");
		ConvertToSkeletalControlPure_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSkeletalControlPure_FunctionAddress, "Node", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSkeletalControlPure_SkeletalControl_PropertyAddress, ConvertToSkeletalControlPure_FunctionAddress, "SkeletalControl");
		ConvertToSkeletalControlPure_SkeletalControl_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSkeletalControlPure_FunctionAddress, "SkeletalControl");
		ConvertToSkeletalControlPure_SkeletalControl_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSkeletalControlPure_FunctionAddress, "SkeletalControl", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSkeletalControlPure_Result_PropertyAddress, ConvertToSkeletalControlPure_FunctionAddress, "Result");
		ConvertToSkeletalControlPure_Result_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSkeletalControlPure_FunctionAddress, "Result");
		ConvertToSkeletalControlPure_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSkeletalControlPure_FunctionAddress, "Result", Classes.FBoolProperty);
		ConvertToSkeletalControlPure_IsValid = ConvertToSkeletalControlPure_FunctionAddress != IntPtr.Zero && ConvertToSkeletalControlPure_Node_IsValid && ConvertToSkeletalControlPure_SkeletalControl_IsValid && ConvertToSkeletalControlPure_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SkeletalControlLibrary:ConvertToSkeletalControlPure", ConvertToSkeletalControlPure_IsValid);
		ConvertToSkeletalControl_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToSkeletalControl");
		ConvertToSkeletalControl_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToSkeletalControl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSkeletalControl_Node_PropertyAddress, ConvertToSkeletalControl_FunctionAddress, "Node");
		ConvertToSkeletalControl_Node_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSkeletalControl_FunctionAddress, "Node");
		ConvertToSkeletalControl_Node_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSkeletalControl_FunctionAddress, "Node", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSkeletalControl_Result_PropertyAddress, ConvertToSkeletalControl_FunctionAddress, "Result");
		ConvertToSkeletalControl_Result_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSkeletalControl_FunctionAddress, "Result");
		ConvertToSkeletalControl_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSkeletalControl_FunctionAddress, "Result", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToSkeletalControl_ReturnValue_PropertyAddress, ConvertToSkeletalControl_FunctionAddress, "ReturnValue");
		ConvertToSkeletalControl_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToSkeletalControl_FunctionAddress, "ReturnValue");
		ConvertToSkeletalControl_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToSkeletalControl_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ConvertToSkeletalControl_IsValid = ConvertToSkeletalControl_FunctionAddress != IntPtr.Zero && ConvertToSkeletalControl_Node_IsValid && ConvertToSkeletalControl_Result_IsValid && ConvertToSkeletalControl_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.SkeletalControlLibrary:ConvertToSkeletalControl", ConvertToSkeletalControl_IsValid);
	}
}
