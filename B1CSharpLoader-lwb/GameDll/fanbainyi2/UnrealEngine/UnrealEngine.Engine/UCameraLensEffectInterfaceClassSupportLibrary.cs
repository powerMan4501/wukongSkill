using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/Engine.CameraLensEffectInterfaceClassSupportLibrary", "Engine", UnrealModuleType.Engine)]
public class UCameraLensEffectInterfaceClassSupportLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetInterfaceClass_IsValid;

	private static IntPtr SetInterfaceClass_FunctionAddress;

	private static int SetInterfaceClass_ParamsSize;

	private static bool SetInterfaceClass_Class_IsValid;

	private static FFieldAddress SetInterfaceClass_Class_PropertyAddress;

	private static int SetInterfaceClass_Class_Offset;

	private static bool SetInterfaceClass_Var_IsValid;

	private static FFieldAddress SetInterfaceClass_Var_PropertyAddress;

	private static int SetInterfaceClass_Var_Offset;

	private static bool SetInterfaceClass_Result_IsValid;

	private static FFieldAddress SetInterfaceClass_Result_PropertyAddress;

	private static int SetInterfaceClass_Result_Offset;

	private static bool IsInterfaceValid_IsValid;

	private static IntPtr IsInterfaceValid_FunctionAddress;

	private static int IsInterfaceValid_ParamsSize;

	private static bool IsInterfaceValid_CameraLens_IsValid;

	private static FFieldAddress IsInterfaceValid_CameraLens_PropertyAddress;

	private static int IsInterfaceValid_CameraLens_Offset;

	private static bool IsInterfaceValid_Result_IsValid;

	private static FFieldAddress IsInterfaceValid_Result_PropertyAddress;

	private static int IsInterfaceValid_Result_Offset;

	private static bool IsInterfaceClassValid_IsValid;

	private static IntPtr IsInterfaceClassValid_FunctionAddress;

	private static int IsInterfaceClassValid_ParamsSize;

	private static bool IsInterfaceClassValid_CameraLens_IsValid;

	private static FFieldAddress IsInterfaceClassValid_CameraLens_PropertyAddress;

	private static int IsInterfaceClassValid_CameraLens_Offset;

	private static bool IsInterfaceClassValid_Result_IsValid;

	private static FFieldAddress IsInterfaceClassValid_Result_PropertyAddress;

	private static int IsInterfaceClassValid_Result_Offset;

	private static bool GetInterfaceClass_IsValid;

	private static IntPtr GetInterfaceClass_FunctionAddress;

	private static int GetInterfaceClass_ParamsSize;

	private static bool GetInterfaceClass_CameraLens_IsValid;

	private static FFieldAddress GetInterfaceClass_CameraLens_PropertyAddress;

	private static int GetInterfaceClass_CameraLens_Offset;

	private static bool GetInterfaceClass_ReturnValue_IsValid;

	private static FFieldAddress GetInterfaceClass_ReturnValue_PropertyAddress;

	private static int GetInterfaceClass_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.CameraLensEffectInterfaceClassSupportLibrary:SetInterfaceClass")]
	public unsafe static void SetInterfaceClass(TSubclassOf<AActor> Class, ref FCameraLensInterfaceClassSupport Var, out EInterfaceValidResult Result)
	{
		if (!SetInterfaceClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraLensEffectInterfaceClassSupportLibrary:SetInterfaceClass");
			Result = EInterfaceValidResult.Valid;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInterfaceClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInterfaceClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetInterfaceClass_Class_Offset), 0, SetInterfaceClass_Class_PropertyAddress.Address, Class);
		NativeReflection.InitializeValue_InContainer(SetInterfaceClass_Var_PropertyAddress.Address, intPtr);
		FCameraLensInterfaceClassSupport.ToNative(IntPtr.Add(intPtr, SetInterfaceClass_Var_Offset), 0, SetInterfaceClass_Var_PropertyAddress.Address, Var);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetInterfaceClass_FunctionAddress, intPtr, SetInterfaceClass_ParamsSize);
		Var = FCameraLensInterfaceClassSupport.FromNative(IntPtr.Add(intPtr, SetInterfaceClass_Var_Offset), 0, SetInterfaceClass_Var_PropertyAddress.Address);
		Result = EnumMarshaler<EInterfaceValidResult>.FromNative(IntPtr.Add(intPtr, SetInterfaceClass_Result_Offset), 0, SetInterfaceClass_Result_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.CameraLensEffectInterfaceClassSupportLibrary:IsInterfaceValid")]
	public unsafe static void IsInterfaceValid(ICameraLensEffectInterface CameraLens, out EInterfaceValidResult Result)
	{
		if (!IsInterfaceValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraLensEffectInterfaceClassSupportLibrary:IsInterfaceValid");
			Result = EInterfaceValidResult.Valid;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInterfaceValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInterfaceValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		InterfaceMarshaler<ICameraLensEffectInterface>.ToNative(IntPtr.Add(intPtr, IsInterfaceValid_CameraLens_Offset), 0, IsInterfaceValid_CameraLens_PropertyAddress.Address, CameraLens);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsInterfaceValid_FunctionAddress, intPtr, IsInterfaceValid_ParamsSize);
		Result = EnumMarshaler<EInterfaceValidResult>.FromNative(IntPtr.Add(intPtr, IsInterfaceValid_Result_Offset), 0, IsInterfaceValid_Result_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/Engine.CameraLensEffectInterfaceClassSupportLibrary:IsInterfaceClassValid")]
	public unsafe static void IsInterfaceClassValid(FCameraLensInterfaceClassSupport CameraLens, out EInterfaceValidResult Result)
	{
		if (!IsInterfaceClassValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraLensEffectInterfaceClassSupportLibrary:IsInterfaceClassValid");
			Result = EInterfaceValidResult.Valid;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInterfaceClassValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInterfaceClassValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsInterfaceClassValid_CameraLens_PropertyAddress.Address, intPtr);
		FCameraLensInterfaceClassSupport.ToNative(IntPtr.Add(intPtr, IsInterfaceClassValid_CameraLens_Offset), 0, IsInterfaceClassValid_CameraLens_PropertyAddress.Address, CameraLens);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsInterfaceClassValid_FunctionAddress, intPtr, IsInterfaceClassValid_ParamsSize);
		Result = EnumMarshaler<EInterfaceValidResult>.FromNative(IntPtr.Add(intPtr, IsInterfaceClassValid_Result_Offset), 0, IsInterfaceClassValid_Result_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/Engine.CameraLensEffectInterfaceClassSupportLibrary:GetInterfaceClass")]
	public unsafe static TSubclassOf<AActor> GetInterfaceClass(FCameraLensInterfaceClassSupport CameraLens)
	{
		if (!GetInterfaceClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraLensEffectInterfaceClassSupportLibrary:GetInterfaceClass");
			return default(TSubclassOf<AActor>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInterfaceClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInterfaceClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetInterfaceClass_CameraLens_PropertyAddress.Address, intPtr);
		FCameraLensInterfaceClassSupport.ToNative(IntPtr.Add(intPtr, GetInterfaceClass_CameraLens_Offset), 0, GetInterfaceClass_CameraLens_PropertyAddress.Address, CameraLens);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInterfaceClass_FunctionAddress, intPtr, GetInterfaceClass_ParamsSize);
		return TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetInterfaceClass_ReturnValue_Offset), 0, GetInterfaceClass_ReturnValue_PropertyAddress.Address);
	}

	static UCameraLensEffectInterfaceClassSupportLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCameraLensEffectInterfaceClassSupportLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCameraLensEffectInterfaceClassSupportLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.CameraLensEffectInterfaceClassSupportLibrary");
		SetInterfaceClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetInterfaceClass");
		SetInterfaceClass_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInterfaceClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInterfaceClass_Class_PropertyAddress, SetInterfaceClass_FunctionAddress, "Class");
		SetInterfaceClass_Class_Offset = NativeReflectionCached.GetPropertyOffset(SetInterfaceClass_FunctionAddress, "Class");
		SetInterfaceClass_Class_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInterfaceClass_FunctionAddress, "Class", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInterfaceClass_Var_PropertyAddress, SetInterfaceClass_FunctionAddress, "Var");
		SetInterfaceClass_Var_Offset = NativeReflectionCached.GetPropertyOffset(SetInterfaceClass_FunctionAddress, "Var");
		SetInterfaceClass_Var_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInterfaceClass_FunctionAddress, "Var", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetInterfaceClass_Result_PropertyAddress, SetInterfaceClass_FunctionAddress, "Result");
		SetInterfaceClass_Result_Offset = NativeReflectionCached.GetPropertyOffset(SetInterfaceClass_FunctionAddress, "Result");
		SetInterfaceClass_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInterfaceClass_FunctionAddress, "Result", Classes.FEnumProperty);
		SetInterfaceClass_IsValid = SetInterfaceClass_FunctionAddress != IntPtr.Zero && SetInterfaceClass_Class_IsValid && SetInterfaceClass_Var_IsValid && SetInterfaceClass_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraLensEffectInterfaceClassSupportLibrary:SetInterfaceClass", SetInterfaceClass_IsValid);
		IsInterfaceValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsInterfaceValid");
		IsInterfaceValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInterfaceValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInterfaceValid_CameraLens_PropertyAddress, IsInterfaceValid_FunctionAddress, "CameraLens");
		IsInterfaceValid_CameraLens_Offset = NativeReflectionCached.GetPropertyOffset(IsInterfaceValid_FunctionAddress, "CameraLens");
		IsInterfaceValid_CameraLens_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInterfaceValid_FunctionAddress, "CameraLens", Classes.FInterfaceProperty);
		NativeReflectionCached.GetPropertyRef(ref IsInterfaceValid_Result_PropertyAddress, IsInterfaceValid_FunctionAddress, "Result");
		IsInterfaceValid_Result_Offset = NativeReflectionCached.GetPropertyOffset(IsInterfaceValid_FunctionAddress, "Result");
		IsInterfaceValid_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInterfaceValid_FunctionAddress, "Result", Classes.FEnumProperty);
		IsInterfaceValid_IsValid = IsInterfaceValid_FunctionAddress != IntPtr.Zero && IsInterfaceValid_CameraLens_IsValid && IsInterfaceValid_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraLensEffectInterfaceClassSupportLibrary:IsInterfaceValid", IsInterfaceValid_IsValid);
		IsInterfaceClassValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsInterfaceClassValid");
		IsInterfaceClassValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInterfaceClassValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInterfaceClassValid_CameraLens_PropertyAddress, IsInterfaceClassValid_FunctionAddress, "CameraLens");
		IsInterfaceClassValid_CameraLens_Offset = NativeReflectionCached.GetPropertyOffset(IsInterfaceClassValid_FunctionAddress, "CameraLens");
		IsInterfaceClassValid_CameraLens_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInterfaceClassValid_FunctionAddress, "CameraLens", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsInterfaceClassValid_Result_PropertyAddress, IsInterfaceClassValid_FunctionAddress, "Result");
		IsInterfaceClassValid_Result_Offset = NativeReflectionCached.GetPropertyOffset(IsInterfaceClassValid_FunctionAddress, "Result");
		IsInterfaceClassValid_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInterfaceClassValid_FunctionAddress, "Result", Classes.FEnumProperty);
		IsInterfaceClassValid_IsValid = IsInterfaceClassValid_FunctionAddress != IntPtr.Zero && IsInterfaceClassValid_CameraLens_IsValid && IsInterfaceClassValid_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraLensEffectInterfaceClassSupportLibrary:IsInterfaceClassValid", IsInterfaceClassValid_IsValid);
		GetInterfaceClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInterfaceClass");
		GetInterfaceClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInterfaceClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInterfaceClass_CameraLens_PropertyAddress, GetInterfaceClass_FunctionAddress, "CameraLens");
		GetInterfaceClass_CameraLens_Offset = NativeReflectionCached.GetPropertyOffset(GetInterfaceClass_FunctionAddress, "CameraLens");
		GetInterfaceClass_CameraLens_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInterfaceClass_FunctionAddress, "CameraLens", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInterfaceClass_ReturnValue_PropertyAddress, GetInterfaceClass_FunctionAddress, "ReturnValue");
		GetInterfaceClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInterfaceClass_FunctionAddress, "ReturnValue");
		GetInterfaceClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInterfaceClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetInterfaceClass_IsValid = GetInterfaceClass_FunctionAddress != IntPtr.Zero && GetInterfaceClass_CameraLens_IsValid && GetInterfaceClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraLensEffectInterfaceClassSupportLibrary:GetInterfaceClass", GetInterfaceClass_IsValid);
	}
}
