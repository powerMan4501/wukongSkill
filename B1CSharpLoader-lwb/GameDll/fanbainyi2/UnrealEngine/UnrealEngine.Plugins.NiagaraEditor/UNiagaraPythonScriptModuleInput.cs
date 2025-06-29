using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraEditor;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput", "NiagaraEditor", UnrealModuleType.EnginePlugin)]
public class UNiagaraPythonScriptModuleInput : UObject
{
	private static bool IsSet_IsValid;

	private static IntPtr IsSet_FunctionAddress;

	private static int IsSet_ParamsSize;

	private static bool IsSet_ReturnValue_IsValid;

	private static FFieldAddress IsSet_ReturnValue_PropertyAddress;

	private static int IsSet_ReturnValue_Offset;

	private static bool IsLocalValue_IsValid;

	private static IntPtr IsLocalValue_FunctionAddress;

	private static int IsLocalValue_ParamsSize;

	private static bool IsLocalValue_ReturnValue_IsValid;

	private static FFieldAddress IsLocalValue_ReturnValue_PropertyAddress;

	private static int IsLocalValue_ReturnValue_Offset;

	private static bool AsVec4_IsValid;

	private static IntPtr AsVec4_FunctionAddress;

	private static int AsVec4_ParamsSize;

	private static bool AsVec4_ReturnValue_IsValid;

	private static FFieldAddress AsVec4_ReturnValue_PropertyAddress;

	private static int AsVec4_ReturnValue_Offset;

	private static bool AsVec3_IsValid;

	private static IntPtr AsVec3_FunctionAddress;

	private static int AsVec3_ParamsSize;

	private static bool AsVec3_ReturnValue_IsValid;

	private static FFieldAddress AsVec3_ReturnValue_PropertyAddress;

	private static int AsVec3_ReturnValue_Offset;

	private static bool AsVec2_IsValid;

	private static IntPtr AsVec2_FunctionAddress;

	private static int AsVec2_ParamsSize;

	private static bool AsVec2_ReturnValue_IsValid;

	private static FFieldAddress AsVec2_ReturnValue_PropertyAddress;

	private static int AsVec2_ReturnValue_Offset;

	private static bool AsQuat_IsValid;

	private static IntPtr AsQuat_FunctionAddress;

	private static int AsQuat_ParamsSize;

	private static bool AsQuat_ReturnValue_IsValid;

	private static FFieldAddress AsQuat_ReturnValue_PropertyAddress;

	private static int AsQuat_ReturnValue_Offset;

	private static bool AsInt_IsValid;

	private static IntPtr AsInt_FunctionAddress;

	private static int AsInt_ParamsSize;

	private static bool AsInt_ReturnValue_IsValid;

	private static FFieldAddress AsInt_ReturnValue_PropertyAddress;

	private static int AsInt_ReturnValue_Offset;

	private static bool AsFloat_IsValid;

	private static IntPtr AsFloat_FunctionAddress;

	private static int AsFloat_ParamsSize;

	private static bool AsFloat_ReturnValue_IsValid;

	private static FFieldAddress AsFloat_ReturnValue_PropertyAddress;

	private static int AsFloat_ReturnValue_Offset;

	private static bool AsEnum_IsValid;

	private static IntPtr AsEnum_FunctionAddress;

	private static int AsEnum_ParamsSize;

	private static bool AsEnum_ReturnValue_IsValid;

	private static FFieldAddress AsEnum_ReturnValue_PropertyAddress;

	private static int AsEnum_ReturnValue_Offset;

	private static bool AsColor_IsValid;

	private static IntPtr AsColor_FunctionAddress;

	private static int AsColor_ParamsSize;

	private static bool AsColor_ReturnValue_IsValid;

	private static FFieldAddress AsColor_ReturnValue_PropertyAddress;

	private static int AsColor_ReturnValue_Offset;

	private static bool AsBool_IsValid;

	private static IntPtr AsBool_FunctionAddress;

	private static int AsBool_ParamsSize;

	private static bool AsBool_ReturnValue_IsValid;

	private static FFieldAddress AsBool_ReturnValue_PropertyAddress;

	private static int AsBool_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:IsSet")]
	public unsafe bool IsSet()
	{
		CheckDestroyed();
		if (!IsSet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:IsSet");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSet_FunctionAddress, intPtr, IsSet_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSet_ReturnValue_Offset), 0, IsSet_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:IsLocalValue")]
	public unsafe bool IsLocalValue()
	{
		CheckDestroyed();
		if (!IsLocalValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:IsLocalValue");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLocalValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLocalValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLocalValue_FunctionAddress, intPtr, IsLocalValue_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLocalValue_ReturnValue_Offset), 0, IsLocalValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsVec4")]
	public unsafe FVector4 AsVec4()
	{
		CheckDestroyed();
		if (!AsVec4_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsVec4");
			return default(FVector4);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsVec4_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsVec4_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, AsVec4_FunctionAddress, intPtr, AsVec4_ParamsSize);
		return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(intPtr, AsVec4_ReturnValue_Offset), 0, AsVec4_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsVec3")]
	public unsafe FVector AsVec3()
	{
		CheckDestroyed();
		if (!AsVec3_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsVec3");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsVec3_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsVec3_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, AsVec3_FunctionAddress, intPtr, AsVec3_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, AsVec3_ReturnValue_Offset), 0, AsVec3_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsVec2")]
	public unsafe FVector2D AsVec2()
	{
		CheckDestroyed();
		if (!AsVec2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsVec2");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsVec2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsVec2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, AsVec2_FunctionAddress, intPtr, AsVec2_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, AsVec2_ReturnValue_Offset), 0, AsVec2_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsQuat")]
	public unsafe FQuat AsQuat()
	{
		CheckDestroyed();
		if (!AsQuat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsQuat");
			return default(FQuat);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsQuat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsQuat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, AsQuat_FunctionAddress, intPtr, AsQuat_ParamsSize);
		return BlittableTypeMarshaler<FQuat>.FromNative(IntPtr.Add(intPtr, AsQuat_ReturnValue_Offset), 0, AsQuat_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsInt")]
	public unsafe int AsInt()
	{
		CheckDestroyed();
		if (!AsInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsInt");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, AsInt_FunctionAddress, intPtr, AsInt_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, AsInt_ReturnValue_Offset), 0, AsInt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsFloat")]
	public unsafe float AsFloat()
	{
		CheckDestroyed();
		if (!AsFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsFloat");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, AsFloat_FunctionAddress, intPtr, AsFloat_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, AsFloat_ReturnValue_Offset), 0, AsFloat_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsEnum")]
	public unsafe string AsEnum()
	{
		CheckDestroyed();
		if (!AsEnum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsEnum");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsEnum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsEnum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, AsEnum_FunctionAddress, intPtr, AsEnum_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, AsEnum_ReturnValue_Offset), 0, AsEnum_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AsEnum_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsColor")]
	public unsafe FLinearColor AsColor()
	{
		CheckDestroyed();
		if (!AsColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsColor");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, AsColor_FunctionAddress, intPtr, AsColor_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, AsColor_ReturnValue_Offset), 0, AsColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsBool")]
	public unsafe bool AsBool()
	{
		CheckDestroyed();
		if (!AsBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsBool");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AsBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AsBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, AsBool_FunctionAddress, intPtr, AsBool_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AsBool_ReturnValue_Offset), 0, AsBool_ReturnValue_PropertyAddress.Address);
	}

	static UNiagaraPythonScriptModuleInput()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraPythonScriptModuleInput)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraPythonScriptModuleInput));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput");
		IsSet_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsSet");
		IsSet_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSet_ReturnValue_PropertyAddress, IsSet_FunctionAddress, "ReturnValue");
		IsSet_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSet_FunctionAddress, "ReturnValue");
		IsSet_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSet_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSet_IsValid = IsSet_FunctionAddress != IntPtr.Zero && IsSet_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:IsSet", IsSet_IsValid);
		IsLocalValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsLocalValue");
		IsLocalValue_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLocalValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLocalValue_ReturnValue_PropertyAddress, IsLocalValue_FunctionAddress, "ReturnValue");
		IsLocalValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLocalValue_FunctionAddress, "ReturnValue");
		IsLocalValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLocalValue_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLocalValue_IsValid = IsLocalValue_FunctionAddress != IntPtr.Zero && IsLocalValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:IsLocalValue", IsLocalValue_IsValid);
		AsVec4_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AsVec4");
		AsVec4_ParamsSize = NativeReflection.GetFunctionParamsSize(AsVec4_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsVec4_ReturnValue_PropertyAddress, AsVec4_FunctionAddress, "ReturnValue");
		AsVec4_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsVec4_FunctionAddress, "ReturnValue");
		AsVec4_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsVec4_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AsVec4_IsValid = AsVec4_FunctionAddress != IntPtr.Zero && AsVec4_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsVec4", AsVec4_IsValid);
		AsVec3_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AsVec3");
		AsVec3_ParamsSize = NativeReflection.GetFunctionParamsSize(AsVec3_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsVec3_ReturnValue_PropertyAddress, AsVec3_FunctionAddress, "ReturnValue");
		AsVec3_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsVec3_FunctionAddress, "ReturnValue");
		AsVec3_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsVec3_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AsVec3_IsValid = AsVec3_FunctionAddress != IntPtr.Zero && AsVec3_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsVec3", AsVec3_IsValid);
		AsVec2_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AsVec2");
		AsVec2_ParamsSize = NativeReflection.GetFunctionParamsSize(AsVec2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsVec2_ReturnValue_PropertyAddress, AsVec2_FunctionAddress, "ReturnValue");
		AsVec2_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsVec2_FunctionAddress, "ReturnValue");
		AsVec2_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsVec2_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AsVec2_IsValid = AsVec2_FunctionAddress != IntPtr.Zero && AsVec2_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsVec2", AsVec2_IsValid);
		AsQuat_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AsQuat");
		AsQuat_ParamsSize = NativeReflection.GetFunctionParamsSize(AsQuat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsQuat_ReturnValue_PropertyAddress, AsQuat_FunctionAddress, "ReturnValue");
		AsQuat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsQuat_FunctionAddress, "ReturnValue");
		AsQuat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsQuat_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AsQuat_IsValid = AsQuat_FunctionAddress != IntPtr.Zero && AsQuat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsQuat", AsQuat_IsValid);
		AsInt_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AsInt");
		AsInt_ParamsSize = NativeReflection.GetFunctionParamsSize(AsInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsInt_ReturnValue_PropertyAddress, AsInt_FunctionAddress, "ReturnValue");
		AsInt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsInt_FunctionAddress, "ReturnValue");
		AsInt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsInt_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		AsInt_IsValid = AsInt_FunctionAddress != IntPtr.Zero && AsInt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsInt", AsInt_IsValid);
		AsFloat_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AsFloat");
		AsFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(AsFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsFloat_ReturnValue_PropertyAddress, AsFloat_FunctionAddress, "ReturnValue");
		AsFloat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsFloat_FunctionAddress, "ReturnValue");
		AsFloat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsFloat_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		AsFloat_IsValid = AsFloat_FunctionAddress != IntPtr.Zero && AsFloat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsFloat", AsFloat_IsValid);
		AsEnum_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AsEnum");
		AsEnum_ParamsSize = NativeReflection.GetFunctionParamsSize(AsEnum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsEnum_ReturnValue_PropertyAddress, AsEnum_FunctionAddress, "ReturnValue");
		AsEnum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsEnum_FunctionAddress, "ReturnValue");
		AsEnum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsEnum_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		AsEnum_IsValid = AsEnum_FunctionAddress != IntPtr.Zero && AsEnum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsEnum", AsEnum_IsValid);
		AsColor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AsColor");
		AsColor_ParamsSize = NativeReflection.GetFunctionParamsSize(AsColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsColor_ReturnValue_PropertyAddress, AsColor_FunctionAddress, "ReturnValue");
		AsColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsColor_FunctionAddress, "ReturnValue");
		AsColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsColor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AsColor_IsValid = AsColor_FunctionAddress != IntPtr.Zero && AsColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsColor", AsColor_IsValid);
		AsBool_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AsBool");
		AsBool_ParamsSize = NativeReflection.GetFunctionParamsSize(AsBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AsBool_ReturnValue_PropertyAddress, AsBool_FunctionAddress, "ReturnValue");
		AsBool_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AsBool_FunctionAddress, "ReturnValue");
		AsBool_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AsBool_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AsBool_IsValid = AsBool_FunctionAddress != IntPtr.Zero && AsBool_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NiagaraEditor.NiagaraPythonScriptModuleInput:AsBool", AsBool_IsValid);
	}
}
