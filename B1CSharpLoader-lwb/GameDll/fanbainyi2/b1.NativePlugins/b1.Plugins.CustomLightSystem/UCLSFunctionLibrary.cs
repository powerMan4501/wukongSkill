using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/CustomLightSystem.CLSFunctionLibrary", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public class UCLSFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool UnregisterNeedPointLightControlActor_IsValid;

	private static IntPtr UnregisterNeedPointLightControlActor_FunctionAddress;

	private static int UnregisterNeedPointLightControlActor_ParamsSize;

	private static bool UnregisterNeedPointLightControlActor_InTag_IsValid;

	private static FFieldAddress UnregisterNeedPointLightControlActor_InTag_PropertyAddress;

	private static int UnregisterNeedPointLightControlActor_InTag_Offset;

	private static bool RegisterNeedPointLightControlActor_IsValid;

	private static IntPtr RegisterNeedPointLightControlActor_FunctionAddress;

	private static int RegisterNeedPointLightControlActor_ParamsSize;

	private static bool RegisterNeedPointLightControlActor_InTag_IsValid;

	private static FFieldAddress RegisterNeedPointLightControlActor_InTag_PropertyAddress;

	private static int RegisterNeedPointLightControlActor_InTag_Offset;

	private static bool RegisterNeedPointLightControlActor_InActor_IsValid;

	private static FFieldAddress RegisterNeedPointLightControlActor_InActor_PropertyAddress;

	private static int RegisterNeedPointLightControlActor_InActor_Offset;

	private static bool OverrideEnvLightBlendInSpeed_IsValid;

	private static IntPtr OverrideEnvLightBlendInSpeed_FunctionAddress;

	private static int OverrideEnvLightBlendInSpeed_ParamsSize;

	private static bool OverrideEnvLightBlendInSpeed_bOverride_IsValid;

	private static FFieldAddress OverrideEnvLightBlendInSpeed_bOverride_PropertyAddress;

	private static int OverrideEnvLightBlendInSpeed_bOverride_Offset;

	private static bool OverrideEnvLightBlendInSpeed_InBlendInSpeed_IsValid;

	private static FFieldAddress OverrideEnvLightBlendInSpeed_InBlendInSpeed_PropertyAddress;

	private static int OverrideEnvLightBlendInSpeed_InBlendInSpeed_Offset;

	private static bool GetCurrentCLSManager_IsValid;

	private static IntPtr GetCurrentCLSManager_FunctionAddress;

	private static int GetCurrentCLSManager_ParamsSize;

	private static bool GetCurrentCLSManager_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentCLSManager_ReturnValue_PropertyAddress;

	private static int GetCurrentCLSManager_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/CustomLightSystem.CLSFunctionLibrary:UnregisterNeedPointLightControlActor")]
	public unsafe static void UnregisterNeedPointLightControlActor(FName InTag)
	{
		if (!UnregisterNeedPointLightControlActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSFunctionLibrary:UnregisterNeedPointLightControlActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnregisterNeedPointLightControlActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnregisterNeedPointLightControlActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, UnregisterNeedPointLightControlActor_InTag_Offset), 0, UnregisterNeedPointLightControlActor_InTag_PropertyAddress.Address, InTag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UnregisterNeedPointLightControlActor_FunctionAddress, intPtr, UnregisterNeedPointLightControlActor_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/CustomLightSystem.CLSFunctionLibrary:RegisterNeedPointLightControlActor")]
	public unsafe static void RegisterNeedPointLightControlActor(FName InTag, AActor InActor)
	{
		if (!RegisterNeedPointLightControlActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSFunctionLibrary:RegisterNeedPointLightControlActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterNeedPointLightControlActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterNeedPointLightControlActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RegisterNeedPointLightControlActor_InTag_Offset), 0, RegisterNeedPointLightControlActor_InTag_PropertyAddress.Address, InTag);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RegisterNeedPointLightControlActor_InActor_Offset), 0, RegisterNeedPointLightControlActor_InActor_PropertyAddress.Address, InActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RegisterNeedPointLightControlActor_FunctionAddress, intPtr, RegisterNeedPointLightControlActor_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/CustomLightSystem.CLSFunctionLibrary:OverrideEnvLightBlendInSpeed")]
	public unsafe static void OverrideEnvLightBlendInSpeed(bool bOverride, float InBlendInSpeed)
	{
		if (!OverrideEnvLightBlendInSpeed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSFunctionLibrary:OverrideEnvLightBlendInSpeed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OverrideEnvLightBlendInSpeed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OverrideEnvLightBlendInSpeed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OverrideEnvLightBlendInSpeed_bOverride_Offset), 0, OverrideEnvLightBlendInSpeed_bOverride_PropertyAddress.Address, bOverride);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OverrideEnvLightBlendInSpeed_InBlendInSpeed_Offset), 0, OverrideEnvLightBlendInSpeed_InBlendInSpeed_PropertyAddress.Address, InBlendInSpeed);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OverrideEnvLightBlendInSpeed_FunctionAddress, intPtr, OverrideEnvLightBlendInSpeed_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/CustomLightSystem.CLSFunctionLibrary:GetCurrentCLSManager")]
	public unsafe static ACLSManager GetCurrentCLSManager()
	{
		if (!GetCurrentCLSManager_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CustomLightSystem.CLSFunctionLibrary:GetCurrentCLSManager");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentCLSManager_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentCLSManager_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentCLSManager_FunctionAddress, intPtr, GetCurrentCLSManager_ParamsSize);
		return UObjectMarshaler<ACLSManager>.FromNative(IntPtr.Add(intPtr, GetCurrentCLSManager_ReturnValue_Offset), 0, GetCurrentCLSManager_ReturnValue_PropertyAddress.Address);
	}

	static UCLSFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCLSFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCLSFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/CustomLightSystem.CLSFunctionLibrary");
		UnregisterNeedPointLightControlActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UnregisterNeedPointLightControlActor");
		UnregisterNeedPointLightControlActor_ParamsSize = NativeReflection.GetFunctionParamsSize(UnregisterNeedPointLightControlActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnregisterNeedPointLightControlActor_InTag_PropertyAddress, UnregisterNeedPointLightControlActor_FunctionAddress, "InTag");
		UnregisterNeedPointLightControlActor_InTag_Offset = NativeReflectionCached.GetPropertyOffset(UnregisterNeedPointLightControlActor_FunctionAddress, "InTag");
		UnregisterNeedPointLightControlActor_InTag_IsValid = NativeReflectionCached.ValidatePropertyClass(UnregisterNeedPointLightControlActor_FunctionAddress, "InTag", Classes.FNameProperty);
		UnregisterNeedPointLightControlActor_IsValid = UnregisterNeedPointLightControlActor_FunctionAddress != IntPtr.Zero && UnregisterNeedPointLightControlActor_InTag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSFunctionLibrary:UnregisterNeedPointLightControlActor", UnregisterNeedPointLightControlActor_IsValid);
		RegisterNeedPointLightControlActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegisterNeedPointLightControlActor");
		RegisterNeedPointLightControlActor_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterNeedPointLightControlActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterNeedPointLightControlActor_InTag_PropertyAddress, RegisterNeedPointLightControlActor_FunctionAddress, "InTag");
		RegisterNeedPointLightControlActor_InTag_Offset = NativeReflectionCached.GetPropertyOffset(RegisterNeedPointLightControlActor_FunctionAddress, "InTag");
		RegisterNeedPointLightControlActor_InTag_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterNeedPointLightControlActor_FunctionAddress, "InTag", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterNeedPointLightControlActor_InActor_PropertyAddress, RegisterNeedPointLightControlActor_FunctionAddress, "InActor");
		RegisterNeedPointLightControlActor_InActor_Offset = NativeReflectionCached.GetPropertyOffset(RegisterNeedPointLightControlActor_FunctionAddress, "InActor");
		RegisterNeedPointLightControlActor_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterNeedPointLightControlActor_FunctionAddress, "InActor", Classes.FObjectProperty);
		RegisterNeedPointLightControlActor_IsValid = RegisterNeedPointLightControlActor_FunctionAddress != IntPtr.Zero && RegisterNeedPointLightControlActor_InTag_IsValid && RegisterNeedPointLightControlActor_InActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSFunctionLibrary:RegisterNeedPointLightControlActor", RegisterNeedPointLightControlActor_IsValid);
		OverrideEnvLightBlendInSpeed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OverrideEnvLightBlendInSpeed");
		OverrideEnvLightBlendInSpeed_ParamsSize = NativeReflection.GetFunctionParamsSize(OverrideEnvLightBlendInSpeed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OverrideEnvLightBlendInSpeed_bOverride_PropertyAddress, OverrideEnvLightBlendInSpeed_FunctionAddress, "bOverride");
		OverrideEnvLightBlendInSpeed_bOverride_Offset = NativeReflectionCached.GetPropertyOffset(OverrideEnvLightBlendInSpeed_FunctionAddress, "bOverride");
		OverrideEnvLightBlendInSpeed_bOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideEnvLightBlendInSpeed_FunctionAddress, "bOverride", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideEnvLightBlendInSpeed_InBlendInSpeed_PropertyAddress, OverrideEnvLightBlendInSpeed_FunctionAddress, "InBlendInSpeed");
		OverrideEnvLightBlendInSpeed_InBlendInSpeed_Offset = NativeReflectionCached.GetPropertyOffset(OverrideEnvLightBlendInSpeed_FunctionAddress, "InBlendInSpeed");
		OverrideEnvLightBlendInSpeed_InBlendInSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideEnvLightBlendInSpeed_FunctionAddress, "InBlendInSpeed", Classes.FFloatProperty);
		OverrideEnvLightBlendInSpeed_IsValid = OverrideEnvLightBlendInSpeed_FunctionAddress != IntPtr.Zero && OverrideEnvLightBlendInSpeed_bOverride_IsValid && OverrideEnvLightBlendInSpeed_InBlendInSpeed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSFunctionLibrary:OverrideEnvLightBlendInSpeed", OverrideEnvLightBlendInSpeed_IsValid);
		GetCurrentCLSManager_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentCLSManager");
		GetCurrentCLSManager_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentCLSManager_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentCLSManager_ReturnValue_PropertyAddress, GetCurrentCLSManager_FunctionAddress, "ReturnValue");
		GetCurrentCLSManager_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentCLSManager_FunctionAddress, "ReturnValue");
		GetCurrentCLSManager_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentCLSManager_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCurrentCLSManager_IsValid = GetCurrentCLSManager_FunctionAddress != IntPtr.Zero && GetCurrentCLSManager_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CustomLightSystem.CLSFunctionLibrary:GetCurrentCLSManager", GetCurrentCLSManager_IsValid);
	}
}
