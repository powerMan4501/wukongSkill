using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AnimGraphRuntime.AnimExecutionContextLibrary", "AnimGraphRuntime", UnrealModuleType.Engine)]
public class UAnimExecutionContextLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetDeltaTime_IsValid;

	private static IntPtr GetDeltaTime_FunctionAddress;

	private static int GetDeltaTime_ParamsSize;

	private static bool GetDeltaTime_Context_IsValid;

	private static FFieldAddress GetDeltaTime_Context_PropertyAddress;

	private static int GetDeltaTime_Context_Offset;

	private static bool GetDeltaTime_ReturnValue_IsValid;

	private static FFieldAddress GetDeltaTime_ReturnValue_PropertyAddress;

	private static int GetDeltaTime_ReturnValue_Offset;

	private static bool GetCurrentWeight_IsValid;

	private static IntPtr GetCurrentWeight_FunctionAddress;

	private static int GetCurrentWeight_ParamsSize;

	private static bool GetCurrentWeight_Context_IsValid;

	private static FFieldAddress GetCurrentWeight_Context_PropertyAddress;

	private static int GetCurrentWeight_Context_Offset;

	private static bool GetCurrentWeight_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentWeight_ReturnValue_PropertyAddress;

	private static int GetCurrentWeight_ReturnValue_Offset;

	private static bool GetAnimInstance_IsValid;

	private static IntPtr GetAnimInstance_FunctionAddress;

	private static int GetAnimInstance_ParamsSize;

	private static bool GetAnimInstance_Context_IsValid;

	private static FFieldAddress GetAnimInstance_Context_PropertyAddress;

	private static int GetAnimInstance_Context_Offset;

	private static bool GetAnimInstance_ReturnValue_IsValid;

	private static FFieldAddress GetAnimInstance_ReturnValue_PropertyAddress;

	private static int GetAnimInstance_ReturnValue_Offset;

	private static bool ConvertToUpdateContext_IsValid;

	private static IntPtr ConvertToUpdateContext_FunctionAddress;

	private static int ConvertToUpdateContext_ParamsSize;

	private static bool ConvertToUpdateContext_Context_IsValid;

	private static FFieldAddress ConvertToUpdateContext_Context_PropertyAddress;

	private static int ConvertToUpdateContext_Context_Offset;

	private static bool ConvertToUpdateContext_Result_IsValid;

	private static FFieldAddress ConvertToUpdateContext_Result_PropertyAddress;

	private static int ConvertToUpdateContext_Result_Offset;

	private static bool ConvertToUpdateContext_ReturnValue_IsValid;

	private static FFieldAddress ConvertToUpdateContext_ReturnValue_PropertyAddress;

	private static int ConvertToUpdateContext_ReturnValue_Offset;

	private static bool ConvertToPoseContext_IsValid;

	private static IntPtr ConvertToPoseContext_FunctionAddress;

	private static int ConvertToPoseContext_ParamsSize;

	private static bool ConvertToPoseContext_Context_IsValid;

	private static FFieldAddress ConvertToPoseContext_Context_PropertyAddress;

	private static int ConvertToPoseContext_Context_Offset;

	private static bool ConvertToPoseContext_Result_IsValid;

	private static FFieldAddress ConvertToPoseContext_Result_PropertyAddress;

	private static int ConvertToPoseContext_Result_Offset;

	private static bool ConvertToPoseContext_ReturnValue_IsValid;

	private static FFieldAddress ConvertToPoseContext_ReturnValue_PropertyAddress;

	private static int ConvertToPoseContext_ReturnValue_Offset;

	private static bool ConvertToInitializationContext_IsValid;

	private static IntPtr ConvertToInitializationContext_FunctionAddress;

	private static int ConvertToInitializationContext_ParamsSize;

	private static bool ConvertToInitializationContext_Context_IsValid;

	private static FFieldAddress ConvertToInitializationContext_Context_PropertyAddress;

	private static int ConvertToInitializationContext_Context_Offset;

	private static bool ConvertToInitializationContext_Result_IsValid;

	private static FFieldAddress ConvertToInitializationContext_Result_PropertyAddress;

	private static int ConvertToInitializationContext_Result_Offset;

	private static bool ConvertToInitializationContext_ReturnValue_IsValid;

	private static FFieldAddress ConvertToInitializationContext_ReturnValue_PropertyAddress;

	private static int ConvertToInitializationContext_ReturnValue_Offset;

	private static bool ConvertToComponentSpacePoseContext_IsValid;

	private static IntPtr ConvertToComponentSpacePoseContext_FunctionAddress;

	private static int ConvertToComponentSpacePoseContext_ParamsSize;

	private static bool ConvertToComponentSpacePoseContext_Context_IsValid;

	private static FFieldAddress ConvertToComponentSpacePoseContext_Context_PropertyAddress;

	private static int ConvertToComponentSpacePoseContext_Context_Offset;

	private static bool ConvertToComponentSpacePoseContext_Result_IsValid;

	private static FFieldAddress ConvertToComponentSpacePoseContext_Result_PropertyAddress;

	private static int ConvertToComponentSpacePoseContext_Result_Offset;

	private static bool ConvertToComponentSpacePoseContext_ReturnValue_IsValid;

	private static FFieldAddress ConvertToComponentSpacePoseContext_ReturnValue_PropertyAddress;

	private static int ConvertToComponentSpacePoseContext_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:GetDeltaTime")]
	public unsafe static float GetDeltaTime(FAnimUpdateContext Context)
	{
		if (!GetDeltaTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:GetDeltaTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDeltaTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDeltaTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetDeltaTime_Context_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(intPtr, GetDeltaTime_Context_Offset), 0, GetDeltaTime_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDeltaTime_FunctionAddress, intPtr, GetDeltaTime_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetDeltaTime_Context_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDeltaTime_ReturnValue_Offset), 0, GetDeltaTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:GetCurrentWeight")]
	public unsafe static float GetCurrentWeight(FAnimUpdateContext Context)
	{
		if (!GetCurrentWeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:GetCurrentWeight");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentWeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentWeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetCurrentWeight_Context_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(intPtr, GetCurrentWeight_Context_Offset), 0, GetCurrentWeight_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentWeight_FunctionAddress, intPtr, GetCurrentWeight_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetCurrentWeight_Context_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCurrentWeight_ReturnValue_Offset), 0, GetCurrentWeight_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:GetAnimInstance")]
	public unsafe static UAnimInstance GetAnimInstance(FAnimExecutionContext Context)
	{
		if (!GetAnimInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:GetAnimInstance");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAnimInstance_Context_PropertyAddress.Address, intPtr);
		FAnimExecutionContext.ToNative(IntPtr.Add(intPtr, GetAnimInstance_Context_Offset), 0, GetAnimInstance_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimInstance_FunctionAddress, intPtr, GetAnimInstance_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAnimInstance_Context_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UAnimInstance>.FromNative(IntPtr.Add(intPtr, GetAnimInstance_ReturnValue_Offset), 0, GetAnimInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:ConvertToUpdateContext")]
	public unsafe static FAnimUpdateContext ConvertToUpdateContext(FAnimExecutionContext Context, out EAnimExecutionContextConversionResult Result)
	{
		if (!ConvertToUpdateContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:ConvertToUpdateContext");
			Result = EAnimExecutionContextConversionResult.Failed;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToUpdateContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToUpdateContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertToUpdateContext_Context_PropertyAddress.Address, intPtr);
		FAnimExecutionContext.ToNative(IntPtr.Add(intPtr, ConvertToUpdateContext_Context_Offset), 0, ConvertToUpdateContext_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToUpdateContext_FunctionAddress, intPtr, ConvertToUpdateContext_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertToUpdateContext_Context_PropertyAddress.Address, intPtr);
		Result = EnumMarshaler<EAnimExecutionContextConversionResult>.FromNative(IntPtr.Add(intPtr, ConvertToUpdateContext_Result_Offset), 0, ConvertToUpdateContext_Result_PropertyAddress.Address);
		FAnimUpdateContext result = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(intPtr, ConvertToUpdateContext_ReturnValue_Offset), 0, ConvertToUpdateContext_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ConvertToUpdateContext_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:ConvertToPoseContext")]
	public unsafe static FAnimPoseContext ConvertToPoseContext(FAnimExecutionContext Context, out EAnimExecutionContextConversionResult Result)
	{
		if (!ConvertToPoseContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:ConvertToPoseContext");
			Result = EAnimExecutionContextConversionResult.Failed;
			return default(FAnimPoseContext);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToPoseContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToPoseContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertToPoseContext_Context_PropertyAddress.Address, intPtr);
		FAnimExecutionContext.ToNative(IntPtr.Add(intPtr, ConvertToPoseContext_Context_Offset), 0, ConvertToPoseContext_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToPoseContext_FunctionAddress, intPtr, ConvertToPoseContext_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertToPoseContext_Context_PropertyAddress.Address, intPtr);
		Result = EnumMarshaler<EAnimExecutionContextConversionResult>.FromNative(IntPtr.Add(intPtr, ConvertToPoseContext_Result_Offset), 0, ConvertToPoseContext_Result_PropertyAddress.Address);
		FAnimPoseContext result = FAnimPoseContext.FromNative(IntPtr.Add(intPtr, ConvertToPoseContext_ReturnValue_Offset), 0, ConvertToPoseContext_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ConvertToPoseContext_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:ConvertToInitializationContext")]
	public unsafe static FAnimInitializationContext ConvertToInitializationContext(FAnimExecutionContext Context, out EAnimExecutionContextConversionResult Result)
	{
		if (!ConvertToInitializationContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:ConvertToInitializationContext");
			Result = EAnimExecutionContextConversionResult.Failed;
			return default(FAnimInitializationContext);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToInitializationContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToInitializationContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertToInitializationContext_Context_PropertyAddress.Address, intPtr);
		FAnimExecutionContext.ToNative(IntPtr.Add(intPtr, ConvertToInitializationContext_Context_Offset), 0, ConvertToInitializationContext_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToInitializationContext_FunctionAddress, intPtr, ConvertToInitializationContext_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertToInitializationContext_Context_PropertyAddress.Address, intPtr);
		Result = EnumMarshaler<EAnimExecutionContextConversionResult>.FromNative(IntPtr.Add(intPtr, ConvertToInitializationContext_Result_Offset), 0, ConvertToInitializationContext_Result_PropertyAddress.Address);
		FAnimInitializationContext result = FAnimInitializationContext.FromNative(IntPtr.Add(intPtr, ConvertToInitializationContext_ReturnValue_Offset), 0, ConvertToInitializationContext_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ConvertToInitializationContext_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:ConvertToComponentSpacePoseContext")]
	public unsafe static FAnimComponentSpacePoseContext ConvertToComponentSpacePoseContext(FAnimExecutionContext Context, out EAnimExecutionContextConversionResult Result)
	{
		if (!ConvertToComponentSpacePoseContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:ConvertToComponentSpacePoseContext");
			Result = EAnimExecutionContextConversionResult.Failed;
			return default(FAnimComponentSpacePoseContext);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToComponentSpacePoseContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToComponentSpacePoseContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ConvertToComponentSpacePoseContext_Context_PropertyAddress.Address, intPtr);
		FAnimExecutionContext.ToNative(IntPtr.Add(intPtr, ConvertToComponentSpacePoseContext_Context_Offset), 0, ConvertToComponentSpacePoseContext_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertToComponentSpacePoseContext_FunctionAddress, intPtr, ConvertToComponentSpacePoseContext_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertToComponentSpacePoseContext_Context_PropertyAddress.Address, intPtr);
		Result = EnumMarshaler<EAnimExecutionContextConversionResult>.FromNative(IntPtr.Add(intPtr, ConvertToComponentSpacePoseContext_Result_Offset), 0, ConvertToComponentSpacePoseContext_Result_PropertyAddress.Address);
		FAnimComponentSpacePoseContext result = FAnimComponentSpacePoseContext.FromNative(IntPtr.Add(intPtr, ConvertToComponentSpacePoseContext_ReturnValue_Offset), 0, ConvertToComponentSpacePoseContext_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ConvertToComponentSpacePoseContext_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UAnimExecutionContextLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimExecutionContextLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimExecutionContextLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AnimGraphRuntime.AnimExecutionContextLibrary");
		GetDeltaTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDeltaTime");
		GetDeltaTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDeltaTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDeltaTime_Context_PropertyAddress, GetDeltaTime_FunctionAddress, "Context");
		GetDeltaTime_Context_Offset = NativeReflectionCached.GetPropertyOffset(GetDeltaTime_FunctionAddress, "Context");
		GetDeltaTime_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDeltaTime_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDeltaTime_ReturnValue_PropertyAddress, GetDeltaTime_FunctionAddress, "ReturnValue");
		GetDeltaTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDeltaTime_FunctionAddress, "ReturnValue");
		GetDeltaTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDeltaTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDeltaTime_IsValid = GetDeltaTime_FunctionAddress != IntPtr.Zero && GetDeltaTime_Context_IsValid && GetDeltaTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:GetDeltaTime", GetDeltaTime_IsValid);
		GetCurrentWeight_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentWeight");
		GetCurrentWeight_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentWeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentWeight_Context_PropertyAddress, GetCurrentWeight_FunctionAddress, "Context");
		GetCurrentWeight_Context_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentWeight_FunctionAddress, "Context");
		GetCurrentWeight_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentWeight_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentWeight_ReturnValue_PropertyAddress, GetCurrentWeight_FunctionAddress, "ReturnValue");
		GetCurrentWeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentWeight_FunctionAddress, "ReturnValue");
		GetCurrentWeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentWeight_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCurrentWeight_IsValid = GetCurrentWeight_FunctionAddress != IntPtr.Zero && GetCurrentWeight_Context_IsValid && GetCurrentWeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:GetCurrentWeight", GetCurrentWeight_IsValid);
		GetAnimInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimInstance");
		GetAnimInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimInstance_Context_PropertyAddress, GetAnimInstance_FunctionAddress, "Context");
		GetAnimInstance_Context_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimInstance_FunctionAddress, "Context");
		GetAnimInstance_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimInstance_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimInstance_ReturnValue_PropertyAddress, GetAnimInstance_FunctionAddress, "ReturnValue");
		GetAnimInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimInstance_FunctionAddress, "ReturnValue");
		GetAnimInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimInstance_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAnimInstance_IsValid = GetAnimInstance_FunctionAddress != IntPtr.Zero && GetAnimInstance_Context_IsValid && GetAnimInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:GetAnimInstance", GetAnimInstance_IsValid);
		ConvertToUpdateContext_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToUpdateContext");
		ConvertToUpdateContext_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToUpdateContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToUpdateContext_Context_PropertyAddress, ConvertToUpdateContext_FunctionAddress, "Context");
		ConvertToUpdateContext_Context_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToUpdateContext_FunctionAddress, "Context");
		ConvertToUpdateContext_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToUpdateContext_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToUpdateContext_Result_PropertyAddress, ConvertToUpdateContext_FunctionAddress, "Result");
		ConvertToUpdateContext_Result_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToUpdateContext_FunctionAddress, "Result");
		ConvertToUpdateContext_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToUpdateContext_FunctionAddress, "Result", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToUpdateContext_ReturnValue_PropertyAddress, ConvertToUpdateContext_FunctionAddress, "ReturnValue");
		ConvertToUpdateContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToUpdateContext_FunctionAddress, "ReturnValue");
		ConvertToUpdateContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToUpdateContext_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ConvertToUpdateContext_IsValid = ConvertToUpdateContext_FunctionAddress != IntPtr.Zero && ConvertToUpdateContext_Context_IsValid && ConvertToUpdateContext_Result_IsValid && ConvertToUpdateContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:ConvertToUpdateContext", ConvertToUpdateContext_IsValid);
		ConvertToPoseContext_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToPoseContext");
		ConvertToPoseContext_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToPoseContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToPoseContext_Context_PropertyAddress, ConvertToPoseContext_FunctionAddress, "Context");
		ConvertToPoseContext_Context_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToPoseContext_FunctionAddress, "Context");
		ConvertToPoseContext_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToPoseContext_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToPoseContext_Result_PropertyAddress, ConvertToPoseContext_FunctionAddress, "Result");
		ConvertToPoseContext_Result_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToPoseContext_FunctionAddress, "Result");
		ConvertToPoseContext_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToPoseContext_FunctionAddress, "Result", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToPoseContext_ReturnValue_PropertyAddress, ConvertToPoseContext_FunctionAddress, "ReturnValue");
		ConvertToPoseContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToPoseContext_FunctionAddress, "ReturnValue");
		ConvertToPoseContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToPoseContext_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ConvertToPoseContext_IsValid = ConvertToPoseContext_FunctionAddress != IntPtr.Zero && ConvertToPoseContext_Context_IsValid && ConvertToPoseContext_Result_IsValid && ConvertToPoseContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:ConvertToPoseContext", ConvertToPoseContext_IsValid);
		ConvertToInitializationContext_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToInitializationContext");
		ConvertToInitializationContext_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToInitializationContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToInitializationContext_Context_PropertyAddress, ConvertToInitializationContext_FunctionAddress, "Context");
		ConvertToInitializationContext_Context_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToInitializationContext_FunctionAddress, "Context");
		ConvertToInitializationContext_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToInitializationContext_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToInitializationContext_Result_PropertyAddress, ConvertToInitializationContext_FunctionAddress, "Result");
		ConvertToInitializationContext_Result_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToInitializationContext_FunctionAddress, "Result");
		ConvertToInitializationContext_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToInitializationContext_FunctionAddress, "Result", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToInitializationContext_ReturnValue_PropertyAddress, ConvertToInitializationContext_FunctionAddress, "ReturnValue");
		ConvertToInitializationContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToInitializationContext_FunctionAddress, "ReturnValue");
		ConvertToInitializationContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToInitializationContext_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ConvertToInitializationContext_IsValid = ConvertToInitializationContext_FunctionAddress != IntPtr.Zero && ConvertToInitializationContext_Context_IsValid && ConvertToInitializationContext_Result_IsValid && ConvertToInitializationContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:ConvertToInitializationContext", ConvertToInitializationContext_IsValid);
		ConvertToComponentSpacePoseContext_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToComponentSpacePoseContext");
		ConvertToComponentSpacePoseContext_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToComponentSpacePoseContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToComponentSpacePoseContext_Context_PropertyAddress, ConvertToComponentSpacePoseContext_FunctionAddress, "Context");
		ConvertToComponentSpacePoseContext_Context_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToComponentSpacePoseContext_FunctionAddress, "Context");
		ConvertToComponentSpacePoseContext_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToComponentSpacePoseContext_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToComponentSpacePoseContext_Result_PropertyAddress, ConvertToComponentSpacePoseContext_FunctionAddress, "Result");
		ConvertToComponentSpacePoseContext_Result_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToComponentSpacePoseContext_FunctionAddress, "Result");
		ConvertToComponentSpacePoseContext_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToComponentSpacePoseContext_FunctionAddress, "Result", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertToComponentSpacePoseContext_ReturnValue_PropertyAddress, ConvertToComponentSpacePoseContext_FunctionAddress, "ReturnValue");
		ConvertToComponentSpacePoseContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToComponentSpacePoseContext_FunctionAddress, "ReturnValue");
		ConvertToComponentSpacePoseContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToComponentSpacePoseContext_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ConvertToComponentSpacePoseContext_IsValid = ConvertToComponentSpacePoseContext_FunctionAddress != IntPtr.Zero && ConvertToComponentSpacePoseContext_Context_IsValid && ConvertToComponentSpacePoseContext_Result_IsValid && ConvertToComponentSpacePoseContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraphRuntime.AnimExecutionContextLibrary:ConvertToComponentSpacePoseContext", ConvertToComponentSpacePoseContext_IsValid);
	}
}
