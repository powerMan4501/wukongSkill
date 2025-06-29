using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/EnhancedInput.EnhancedInputLibrary", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UEnhancedInputLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool RequestRebuildControlMappingsUsingContext_IsValid;

	private static IntPtr RequestRebuildControlMappingsUsingContext_FunctionAddress;

	private static int RequestRebuildControlMappingsUsingContext_ParamsSize;

	private static bool RequestRebuildControlMappingsUsingContext_Context_IsValid;

	private static FFieldAddress RequestRebuildControlMappingsUsingContext_Context_PropertyAddress;

	private static int RequestRebuildControlMappingsUsingContext_Context_Offset;

	private static bool RequestRebuildControlMappingsUsingContext_bForceImmediately_IsValid;

	private static FFieldAddress RequestRebuildControlMappingsUsingContext_bForceImmediately_PropertyAddress;

	private static int RequestRebuildControlMappingsUsingContext_bForceImmediately_Offset;

	private static bool MakeInputActionValue_IsValid;

	private static IntPtr MakeInputActionValue_FunctionAddress;

	private static int MakeInputActionValue_ParamsSize;

	private static bool MakeInputActionValue_X_IsValid;

	private static FFieldAddress MakeInputActionValue_X_PropertyAddress;

	private static int MakeInputActionValue_X_Offset;

	private static bool MakeInputActionValue_Y_IsValid;

	private static FFieldAddress MakeInputActionValue_Y_PropertyAddress;

	private static int MakeInputActionValue_Y_Offset;

	private static bool MakeInputActionValue_Z_IsValid;

	private static FFieldAddress MakeInputActionValue_Z_PropertyAddress;

	private static int MakeInputActionValue_Z_Offset;

	private static bool MakeInputActionValue_MatchValueType_IsValid;

	private static FFieldAddress MakeInputActionValue_MatchValueType_PropertyAddress;

	private static int MakeInputActionValue_MatchValueType_Offset;

	private static bool MakeInputActionValue_ReturnValue_IsValid;

	private static FFieldAddress MakeInputActionValue_ReturnValue_PropertyAddress;

	private static int MakeInputActionValue_ReturnValue_Offset;

	private static bool Conv_InputActionValueToString_IsValid;

	private static IntPtr Conv_InputActionValueToString_FunctionAddress;

	private static int Conv_InputActionValueToString_ParamsSize;

	private static bool Conv_InputActionValueToString_ActionValue_IsValid;

	private static FFieldAddress Conv_InputActionValueToString_ActionValue_PropertyAddress;

	private static int Conv_InputActionValueToString_ActionValue_Offset;

	private static bool Conv_InputActionValueToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_InputActionValueToString_ReturnValue_PropertyAddress;

	private static int Conv_InputActionValueToString_ReturnValue_Offset;

	private static bool BreakInputActionValue_IsValid;

	private static IntPtr BreakInputActionValue_FunctionAddress;

	private static int BreakInputActionValue_ParamsSize;

	private static bool BreakInputActionValue_InActionValue_IsValid;

	private static FFieldAddress BreakInputActionValue_InActionValue_PropertyAddress;

	private static int BreakInputActionValue_InActionValue_Offset;

	private static bool BreakInputActionValue_X_IsValid;

	private static FFieldAddress BreakInputActionValue_X_PropertyAddress;

	private static int BreakInputActionValue_X_Offset;

	private static bool BreakInputActionValue_Y_IsValid;

	private static FFieldAddress BreakInputActionValue_Y_PropertyAddress;

	private static int BreakInputActionValue_Y_Offset;

	private static bool BreakInputActionValue_Z_IsValid;

	private static FFieldAddress BreakInputActionValue_Z_PropertyAddress;

	private static int BreakInputActionValue_Z_Offset;

	[UFunction(Flags = 67249161u)]
	[UMetaPath("/Script/EnhancedInput.EnhancedInputLibrary:RequestRebuildControlMappingsUsingContext")]
	public unsafe static void RequestRebuildControlMappingsUsingContext(UInputMappingContext Context, bool bForceImmediately = false)
	{
		if (!RequestRebuildControlMappingsUsingContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.EnhancedInputLibrary:RequestRebuildControlMappingsUsingContext");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestRebuildControlMappingsUsingContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestRebuildControlMappingsUsingContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInputMappingContext>.ToNative(IntPtr.Add(intPtr, RequestRebuildControlMappingsUsingContext_Context_Offset), 0, RequestRebuildControlMappingsUsingContext_Context_PropertyAddress.Address, Context);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestRebuildControlMappingsUsingContext_bForceImmediately_Offset), 0, RequestRebuildControlMappingsUsingContext_bForceImmediately_PropertyAddress.Address, bForceImmediately);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RequestRebuildControlMappingsUsingContext_FunctionAddress, intPtr, RequestRebuildControlMappingsUsingContext_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/EnhancedInput.EnhancedInputLibrary:MakeInputActionValue")]
	public unsafe static FInputActionValue MakeInputActionValue(float X, float Y, float Z, FInputActionValue MatchValueType)
	{
		if (!MakeInputActionValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.EnhancedInputLibrary:MakeInputActionValue");
			return default(FInputActionValue);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeInputActionValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeInputActionValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeInputActionValue_X_Offset), 0, MakeInputActionValue_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeInputActionValue_Y_Offset), 0, MakeInputActionValue_Y_PropertyAddress.Address, Y);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeInputActionValue_Z_Offset), 0, MakeInputActionValue_Z_PropertyAddress.Address, Z);
		NativeReflection.InitializeValue_InContainer(MakeInputActionValue_MatchValueType_PropertyAddress.Address, intPtr);
		FInputActionValue.ToNative(IntPtr.Add(intPtr, MakeInputActionValue_MatchValueType_Offset), 0, MakeInputActionValue_MatchValueType_PropertyAddress.Address, MatchValueType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeInputActionValue_FunctionAddress, intPtr, MakeInputActionValue_ParamsSize);
		return FInputActionValue.FromNative(IntPtr.Add(intPtr, MakeInputActionValue_ReturnValue_Offset), 0, MakeInputActionValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/EnhancedInput.EnhancedInputLibrary:Conv_InputActionValueToString")]
	public unsafe static string Conv_InputActionValueToString(FInputActionValue ActionValue)
	{
		if (!Conv_InputActionValueToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.EnhancedInputLibrary:Conv_InputActionValueToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_InputActionValueToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_InputActionValueToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Conv_InputActionValueToString_ActionValue_PropertyAddress.Address, intPtr);
		FInputActionValue.ToNative(IntPtr.Add(intPtr, Conv_InputActionValueToString_ActionValue_Offset), 0, Conv_InputActionValueToString_ActionValue_PropertyAddress.Address, ActionValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_InputActionValueToString_FunctionAddress, intPtr, Conv_InputActionValueToString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_InputActionValueToString_ReturnValue_Offset), 0, Conv_InputActionValueToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_InputActionValueToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/EnhancedInput.EnhancedInputLibrary:BreakInputActionValue")]
	public unsafe static void BreakInputActionValue(FInputActionValue InActionValue, out float X, out float Y, out float Z)
	{
		if (!BreakInputActionValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EnhancedInput.EnhancedInputLibrary:BreakInputActionValue");
			X = 0f;
			Y = 0f;
			Z = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BreakInputActionValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BreakInputActionValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(BreakInputActionValue_InActionValue_PropertyAddress.Address, intPtr);
		FInputActionValue.ToNative(IntPtr.Add(intPtr, BreakInputActionValue_InActionValue_Offset), 0, BreakInputActionValue_InActionValue_PropertyAddress.Address, InActionValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BreakInputActionValue_FunctionAddress, intPtr, BreakInputActionValue_ParamsSize);
		X = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BreakInputActionValue_X_Offset), 0, BreakInputActionValue_X_PropertyAddress.Address);
		Y = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BreakInputActionValue_Y_Offset), 0, BreakInputActionValue_Y_PropertyAddress.Address);
		Z = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BreakInputActionValue_Z_Offset), 0, BreakInputActionValue_Z_PropertyAddress.Address);
	}

	static UEnhancedInputLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEnhancedInputLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEnhancedInputLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/EnhancedInput.EnhancedInputLibrary");
		RequestRebuildControlMappingsUsingContext_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestRebuildControlMappingsUsingContext");
		RequestRebuildControlMappingsUsingContext_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestRebuildControlMappingsUsingContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestRebuildControlMappingsUsingContext_Context_PropertyAddress, RequestRebuildControlMappingsUsingContext_FunctionAddress, "Context");
		RequestRebuildControlMappingsUsingContext_Context_Offset = NativeReflectionCached.GetPropertyOffset(RequestRebuildControlMappingsUsingContext_FunctionAddress, "Context");
		RequestRebuildControlMappingsUsingContext_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestRebuildControlMappingsUsingContext_FunctionAddress, "Context", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestRebuildControlMappingsUsingContext_bForceImmediately_PropertyAddress, RequestRebuildControlMappingsUsingContext_FunctionAddress, "bForceImmediately");
		RequestRebuildControlMappingsUsingContext_bForceImmediately_Offset = NativeReflectionCached.GetPropertyOffset(RequestRebuildControlMappingsUsingContext_FunctionAddress, "bForceImmediately");
		RequestRebuildControlMappingsUsingContext_bForceImmediately_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestRebuildControlMappingsUsingContext_FunctionAddress, "bForceImmediately", Classes.FBoolProperty);
		RequestRebuildControlMappingsUsingContext_IsValid = RequestRebuildControlMappingsUsingContext_FunctionAddress != IntPtr.Zero && RequestRebuildControlMappingsUsingContext_Context_IsValid && RequestRebuildControlMappingsUsingContext_bForceImmediately_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.EnhancedInputLibrary:RequestRebuildControlMappingsUsingContext", RequestRebuildControlMappingsUsingContext_IsValid);
		MakeInputActionValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeInputActionValue");
		MakeInputActionValue_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeInputActionValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeInputActionValue_X_PropertyAddress, MakeInputActionValue_FunctionAddress, "X");
		MakeInputActionValue_X_Offset = NativeReflectionCached.GetPropertyOffset(MakeInputActionValue_FunctionAddress, "X");
		MakeInputActionValue_X_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeInputActionValue_FunctionAddress, "X", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeInputActionValue_Y_PropertyAddress, MakeInputActionValue_FunctionAddress, "Y");
		MakeInputActionValue_Y_Offset = NativeReflectionCached.GetPropertyOffset(MakeInputActionValue_FunctionAddress, "Y");
		MakeInputActionValue_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeInputActionValue_FunctionAddress, "Y", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeInputActionValue_Z_PropertyAddress, MakeInputActionValue_FunctionAddress, "Z");
		MakeInputActionValue_Z_Offset = NativeReflectionCached.GetPropertyOffset(MakeInputActionValue_FunctionAddress, "Z");
		MakeInputActionValue_Z_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeInputActionValue_FunctionAddress, "Z", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeInputActionValue_MatchValueType_PropertyAddress, MakeInputActionValue_FunctionAddress, "MatchValueType");
		MakeInputActionValue_MatchValueType_Offset = NativeReflectionCached.GetPropertyOffset(MakeInputActionValue_FunctionAddress, "MatchValueType");
		MakeInputActionValue_MatchValueType_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeInputActionValue_FunctionAddress, "MatchValueType", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeInputActionValue_ReturnValue_PropertyAddress, MakeInputActionValue_FunctionAddress, "ReturnValue");
		MakeInputActionValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeInputActionValue_FunctionAddress, "ReturnValue");
		MakeInputActionValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeInputActionValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeInputActionValue_IsValid = MakeInputActionValue_FunctionAddress != IntPtr.Zero && MakeInputActionValue_X_IsValid && MakeInputActionValue_Y_IsValid && MakeInputActionValue_Z_IsValid && MakeInputActionValue_MatchValueType_IsValid && MakeInputActionValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.EnhancedInputLibrary:MakeInputActionValue", MakeInputActionValue_IsValid);
		Conv_InputActionValueToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_InputActionValueToString");
		Conv_InputActionValueToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_InputActionValueToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_InputActionValueToString_ActionValue_PropertyAddress, Conv_InputActionValueToString_FunctionAddress, "ActionValue");
		Conv_InputActionValueToString_ActionValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_InputActionValueToString_FunctionAddress, "ActionValue");
		Conv_InputActionValueToString_ActionValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_InputActionValueToString_FunctionAddress, "ActionValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_InputActionValueToString_ReturnValue_PropertyAddress, Conv_InputActionValueToString_FunctionAddress, "ReturnValue");
		Conv_InputActionValueToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_InputActionValueToString_FunctionAddress, "ReturnValue");
		Conv_InputActionValueToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_InputActionValueToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_InputActionValueToString_IsValid = Conv_InputActionValueToString_FunctionAddress != IntPtr.Zero && Conv_InputActionValueToString_ActionValue_IsValid && Conv_InputActionValueToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.EnhancedInputLibrary:Conv_InputActionValueToString", Conv_InputActionValueToString_IsValid);
		BreakInputActionValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BreakInputActionValue");
		BreakInputActionValue_ParamsSize = NativeReflection.GetFunctionParamsSize(BreakInputActionValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BreakInputActionValue_InActionValue_PropertyAddress, BreakInputActionValue_FunctionAddress, "InActionValue");
		BreakInputActionValue_InActionValue_Offset = NativeReflectionCached.GetPropertyOffset(BreakInputActionValue_FunctionAddress, "InActionValue");
		BreakInputActionValue_InActionValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakInputActionValue_FunctionAddress, "InActionValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakInputActionValue_X_PropertyAddress, BreakInputActionValue_FunctionAddress, "X");
		BreakInputActionValue_X_Offset = NativeReflectionCached.GetPropertyOffset(BreakInputActionValue_FunctionAddress, "X");
		BreakInputActionValue_X_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakInputActionValue_FunctionAddress, "X", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakInputActionValue_Y_PropertyAddress, BreakInputActionValue_FunctionAddress, "Y");
		BreakInputActionValue_Y_Offset = NativeReflectionCached.GetPropertyOffset(BreakInputActionValue_FunctionAddress, "Y");
		BreakInputActionValue_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakInputActionValue_FunctionAddress, "Y", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakInputActionValue_Z_PropertyAddress, BreakInputActionValue_FunctionAddress, "Z");
		BreakInputActionValue_Z_Offset = NativeReflectionCached.GetPropertyOffset(BreakInputActionValue_FunctionAddress, "Z");
		BreakInputActionValue_Z_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakInputActionValue_FunctionAddress, "Z", Classes.FFloatProperty);
		BreakInputActionValue_IsValid = BreakInputActionValue_FunctionAddress != IntPtr.Zero && BreakInputActionValue_InActionValue_IsValid && BreakInputActionValue_X_IsValid && BreakInputActionValue_Y_IsValid && BreakInputActionValue_Z_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EnhancedInput.EnhancedInputLibrary:BreakInputActionValue", BreakInputActionValue_IsValid);
	}
}
