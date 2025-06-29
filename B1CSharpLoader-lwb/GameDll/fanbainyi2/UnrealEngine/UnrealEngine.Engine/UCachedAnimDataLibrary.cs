using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.CachedAnimDataLibrary", "Engine", UnrealModuleType.Engine)]
public class UCachedAnimDataLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool StateMachine_IsStateRelevant_IsValid;

	private static IntPtr StateMachine_IsStateRelevant_FunctionAddress;

	private static int StateMachine_IsStateRelevant_ParamsSize;

	private static bool StateMachine_IsStateRelevant_InAnimInstance_IsValid;

	private static FFieldAddress StateMachine_IsStateRelevant_InAnimInstance_PropertyAddress;

	private static int StateMachine_IsStateRelevant_InAnimInstance_Offset;

	private static bool StateMachine_IsStateRelevant_CachedAnimStateData_IsValid;

	private static FFieldAddress StateMachine_IsStateRelevant_CachedAnimStateData_PropertyAddress;

	private static int StateMachine_IsStateRelevant_CachedAnimStateData_Offset;

	private static bool StateMachine_IsStateRelevant_ReturnValue_IsValid;

	private static FFieldAddress StateMachine_IsStateRelevant_ReturnValue_PropertyAddress;

	private static int StateMachine_IsStateRelevant_ReturnValue_Offset;

	private static bool StateMachine_GetLocalWeight_IsValid;

	private static IntPtr StateMachine_GetLocalWeight_FunctionAddress;

	private static int StateMachine_GetLocalWeight_ParamsSize;

	private static bool StateMachine_GetLocalWeight_InAnimInstance_IsValid;

	private static FFieldAddress StateMachine_GetLocalWeight_InAnimInstance_PropertyAddress;

	private static int StateMachine_GetLocalWeight_InAnimInstance_Offset;

	private static bool StateMachine_GetLocalWeight_CachedAnimStateData_IsValid;

	private static FFieldAddress StateMachine_GetLocalWeight_CachedAnimStateData_PropertyAddress;

	private static int StateMachine_GetLocalWeight_CachedAnimStateData_Offset;

	private static bool StateMachine_GetLocalWeight_ReturnValue_IsValid;

	private static FFieldAddress StateMachine_GetLocalWeight_ReturnValue_PropertyAddress;

	private static int StateMachine_GetLocalWeight_ReturnValue_Offset;

	private static bool StateMachine_GetGlobalWeight_IsValid;

	private static IntPtr StateMachine_GetGlobalWeight_FunctionAddress;

	private static int StateMachine_GetGlobalWeight_ParamsSize;

	private static bool StateMachine_GetGlobalWeight_InAnimInstance_IsValid;

	private static FFieldAddress StateMachine_GetGlobalWeight_InAnimInstance_PropertyAddress;

	private static int StateMachine_GetGlobalWeight_InAnimInstance_Offset;

	private static bool StateMachine_GetGlobalWeight_CachedAnimStateData_IsValid;

	private static FFieldAddress StateMachine_GetGlobalWeight_CachedAnimStateData_PropertyAddress;

	private static int StateMachine_GetGlobalWeight_CachedAnimStateData_Offset;

	private static bool StateMachine_GetGlobalWeight_ReturnValue_IsValid;

	private static FFieldAddress StateMachine_GetGlobalWeight_ReturnValue_PropertyAddress;

	private static int StateMachine_GetGlobalWeight_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.CachedAnimDataLibrary:StateMachine_IsStateRelevant")]
	public unsafe static bool StateMachine_IsStateRelevant(UAnimInstance InAnimInstance, FCachedAnimStateData CachedAnimStateData)
	{
		if (!StateMachine_IsStateRelevant_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CachedAnimDataLibrary:StateMachine_IsStateRelevant");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StateMachine_IsStateRelevant_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StateMachine_IsStateRelevant_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, StateMachine_IsStateRelevant_InAnimInstance_Offset), 0, StateMachine_IsStateRelevant_InAnimInstance_PropertyAddress.Address, InAnimInstance);
		NativeReflection.InitializeValue_InContainer(StateMachine_IsStateRelevant_CachedAnimStateData_PropertyAddress.Address, intPtr);
		FCachedAnimStateData.ToNative(IntPtr.Add(intPtr, StateMachine_IsStateRelevant_CachedAnimStateData_Offset), 0, StateMachine_IsStateRelevant_CachedAnimStateData_PropertyAddress.Address, CachedAnimStateData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StateMachine_IsStateRelevant_FunctionAddress, intPtr, StateMachine_IsStateRelevant_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, StateMachine_IsStateRelevant_ReturnValue_Offset), 0, StateMachine_IsStateRelevant_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.CachedAnimDataLibrary:StateMachine_GetLocalWeight")]
	public unsafe static float StateMachine_GetLocalWeight(UAnimInstance InAnimInstance, FCachedAnimStateData CachedAnimStateData)
	{
		if (!StateMachine_GetLocalWeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CachedAnimDataLibrary:StateMachine_GetLocalWeight");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StateMachine_GetLocalWeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StateMachine_GetLocalWeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, StateMachine_GetLocalWeight_InAnimInstance_Offset), 0, StateMachine_GetLocalWeight_InAnimInstance_PropertyAddress.Address, InAnimInstance);
		NativeReflection.InitializeValue_InContainer(StateMachine_GetLocalWeight_CachedAnimStateData_PropertyAddress.Address, intPtr);
		FCachedAnimStateData.ToNative(IntPtr.Add(intPtr, StateMachine_GetLocalWeight_CachedAnimStateData_Offset), 0, StateMachine_GetLocalWeight_CachedAnimStateData_PropertyAddress.Address, CachedAnimStateData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StateMachine_GetLocalWeight_FunctionAddress, intPtr, StateMachine_GetLocalWeight_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, StateMachine_GetLocalWeight_ReturnValue_Offset), 0, StateMachine_GetLocalWeight_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.CachedAnimDataLibrary:StateMachine_GetGlobalWeight")]
	public unsafe static float StateMachine_GetGlobalWeight(UAnimInstance InAnimInstance, FCachedAnimStateData CachedAnimStateData)
	{
		if (!StateMachine_GetGlobalWeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CachedAnimDataLibrary:StateMachine_GetGlobalWeight");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StateMachine_GetGlobalWeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StateMachine_GetGlobalWeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, StateMachine_GetGlobalWeight_InAnimInstance_Offset), 0, StateMachine_GetGlobalWeight_InAnimInstance_PropertyAddress.Address, InAnimInstance);
		NativeReflection.InitializeValue_InContainer(StateMachine_GetGlobalWeight_CachedAnimStateData_PropertyAddress.Address, intPtr);
		FCachedAnimStateData.ToNative(IntPtr.Add(intPtr, StateMachine_GetGlobalWeight_CachedAnimStateData_Offset), 0, StateMachine_GetGlobalWeight_CachedAnimStateData_PropertyAddress.Address, CachedAnimStateData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StateMachine_GetGlobalWeight_FunctionAddress, intPtr, StateMachine_GetGlobalWeight_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, StateMachine_GetGlobalWeight_ReturnValue_Offset), 0, StateMachine_GetGlobalWeight_ReturnValue_PropertyAddress.Address);
	}

	static UCachedAnimDataLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCachedAnimDataLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCachedAnimDataLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.CachedAnimDataLibrary");
		StateMachine_IsStateRelevant_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StateMachine_IsStateRelevant");
		StateMachine_IsStateRelevant_ParamsSize = NativeReflection.GetFunctionParamsSize(StateMachine_IsStateRelevant_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StateMachine_IsStateRelevant_InAnimInstance_PropertyAddress, StateMachine_IsStateRelevant_FunctionAddress, "InAnimInstance");
		StateMachine_IsStateRelevant_InAnimInstance_Offset = NativeReflectionCached.GetPropertyOffset(StateMachine_IsStateRelevant_FunctionAddress, "InAnimInstance");
		StateMachine_IsStateRelevant_InAnimInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(StateMachine_IsStateRelevant_FunctionAddress, "InAnimInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StateMachine_IsStateRelevant_CachedAnimStateData_PropertyAddress, StateMachine_IsStateRelevant_FunctionAddress, "CachedAnimStateData");
		StateMachine_IsStateRelevant_CachedAnimStateData_Offset = NativeReflectionCached.GetPropertyOffset(StateMachine_IsStateRelevant_FunctionAddress, "CachedAnimStateData");
		StateMachine_IsStateRelevant_CachedAnimStateData_IsValid = NativeReflectionCached.ValidatePropertyClass(StateMachine_IsStateRelevant_FunctionAddress, "CachedAnimStateData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref StateMachine_IsStateRelevant_ReturnValue_PropertyAddress, StateMachine_IsStateRelevant_FunctionAddress, "ReturnValue");
		StateMachine_IsStateRelevant_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StateMachine_IsStateRelevant_FunctionAddress, "ReturnValue");
		StateMachine_IsStateRelevant_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StateMachine_IsStateRelevant_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		StateMachine_IsStateRelevant_IsValid = StateMachine_IsStateRelevant_FunctionAddress != IntPtr.Zero && StateMachine_IsStateRelevant_InAnimInstance_IsValid && StateMachine_IsStateRelevant_CachedAnimStateData_IsValid && StateMachine_IsStateRelevant_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CachedAnimDataLibrary:StateMachine_IsStateRelevant", StateMachine_IsStateRelevant_IsValid);
		StateMachine_GetLocalWeight_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StateMachine_GetLocalWeight");
		StateMachine_GetLocalWeight_ParamsSize = NativeReflection.GetFunctionParamsSize(StateMachine_GetLocalWeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StateMachine_GetLocalWeight_InAnimInstance_PropertyAddress, StateMachine_GetLocalWeight_FunctionAddress, "InAnimInstance");
		StateMachine_GetLocalWeight_InAnimInstance_Offset = NativeReflectionCached.GetPropertyOffset(StateMachine_GetLocalWeight_FunctionAddress, "InAnimInstance");
		StateMachine_GetLocalWeight_InAnimInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(StateMachine_GetLocalWeight_FunctionAddress, "InAnimInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StateMachine_GetLocalWeight_CachedAnimStateData_PropertyAddress, StateMachine_GetLocalWeight_FunctionAddress, "CachedAnimStateData");
		StateMachine_GetLocalWeight_CachedAnimStateData_Offset = NativeReflectionCached.GetPropertyOffset(StateMachine_GetLocalWeight_FunctionAddress, "CachedAnimStateData");
		StateMachine_GetLocalWeight_CachedAnimStateData_IsValid = NativeReflectionCached.ValidatePropertyClass(StateMachine_GetLocalWeight_FunctionAddress, "CachedAnimStateData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref StateMachine_GetLocalWeight_ReturnValue_PropertyAddress, StateMachine_GetLocalWeight_FunctionAddress, "ReturnValue");
		StateMachine_GetLocalWeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StateMachine_GetLocalWeight_FunctionAddress, "ReturnValue");
		StateMachine_GetLocalWeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StateMachine_GetLocalWeight_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		StateMachine_GetLocalWeight_IsValid = StateMachine_GetLocalWeight_FunctionAddress != IntPtr.Zero && StateMachine_GetLocalWeight_InAnimInstance_IsValid && StateMachine_GetLocalWeight_CachedAnimStateData_IsValid && StateMachine_GetLocalWeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CachedAnimDataLibrary:StateMachine_GetLocalWeight", StateMachine_GetLocalWeight_IsValid);
		StateMachine_GetGlobalWeight_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StateMachine_GetGlobalWeight");
		StateMachine_GetGlobalWeight_ParamsSize = NativeReflection.GetFunctionParamsSize(StateMachine_GetGlobalWeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StateMachine_GetGlobalWeight_InAnimInstance_PropertyAddress, StateMachine_GetGlobalWeight_FunctionAddress, "InAnimInstance");
		StateMachine_GetGlobalWeight_InAnimInstance_Offset = NativeReflectionCached.GetPropertyOffset(StateMachine_GetGlobalWeight_FunctionAddress, "InAnimInstance");
		StateMachine_GetGlobalWeight_InAnimInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(StateMachine_GetGlobalWeight_FunctionAddress, "InAnimInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StateMachine_GetGlobalWeight_CachedAnimStateData_PropertyAddress, StateMachine_GetGlobalWeight_FunctionAddress, "CachedAnimStateData");
		StateMachine_GetGlobalWeight_CachedAnimStateData_Offset = NativeReflectionCached.GetPropertyOffset(StateMachine_GetGlobalWeight_FunctionAddress, "CachedAnimStateData");
		StateMachine_GetGlobalWeight_CachedAnimStateData_IsValid = NativeReflectionCached.ValidatePropertyClass(StateMachine_GetGlobalWeight_FunctionAddress, "CachedAnimStateData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref StateMachine_GetGlobalWeight_ReturnValue_PropertyAddress, StateMachine_GetGlobalWeight_FunctionAddress, "ReturnValue");
		StateMachine_GetGlobalWeight_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StateMachine_GetGlobalWeight_FunctionAddress, "ReturnValue");
		StateMachine_GetGlobalWeight_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StateMachine_GetGlobalWeight_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		StateMachine_GetGlobalWeight_IsValid = StateMachine_GetGlobalWeight_FunctionAddress != IntPtr.Zero && StateMachine_GetGlobalWeight_InAnimInstance_IsValid && StateMachine_GetGlobalWeight_CachedAnimStateData_IsValid && StateMachine_GetGlobalWeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CachedAnimDataLibrary:StateMachine_GetGlobalWeight", StateMachine_GetGlobalWeight_IsValid);
	}
}
