using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OpenColorIO;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/OpenColorIO.OpenColorIODisplayExtensionWrapper", "OpenColorIO", UnrealModuleType.EnginePlugin)]
public class UOpenColorIODisplayExtensionWrapper : UObject
{
	private static IntPtr classAddress;

	private static bool SetSceneExtensionIsActiveFunctions_IsValid;

	private static IntPtr SetSceneExtensionIsActiveFunctions_FunctionAddress;

	private static int SetSceneExtensionIsActiveFunctions_ParamsSize;

	private static bool SetSceneExtensionIsActiveFunctions_IsActiveFunctions_IsValid;

	private static FFieldAddress SetSceneExtensionIsActiveFunctions_IsActiveFunctions_PropertyAddress;

	private static int SetSceneExtensionIsActiveFunctions_IsActiveFunctions_Offset;

	private static bool SetSceneExtensionIsActiveFunction_IsValid;

	private static IntPtr SetSceneExtensionIsActiveFunction_FunctionAddress;

	private static int SetSceneExtensionIsActiveFunction_ParamsSize;

	private static bool SetSceneExtensionIsActiveFunction_IsActiveFunction_IsValid;

	private static FFieldAddress SetSceneExtensionIsActiveFunction_IsActiveFunction_PropertyAddress;

	private static int SetSceneExtensionIsActiveFunction_IsActiveFunction_Offset;

	private static bool SetOpenColorIOConfiguration_IsValid;

	private static IntPtr SetOpenColorIOConfiguration_FunctionAddress;

	private static int SetOpenColorIOConfiguration_ParamsSize;

	private static bool SetOpenColorIOConfiguration_InDisplayConfiguration_IsValid;

	private static FFieldAddress SetOpenColorIOConfiguration_InDisplayConfiguration_PropertyAddress;

	private static int SetOpenColorIOConfiguration_InDisplayConfiguration_Offset;

	private static bool RemoveSceneExtension_IsValid;

	private static IntPtr RemoveSceneExtension_FunctionAddress;

	private static int RemoveSceneExtension_ParamsSize;

	private static bool CreateOpenColorIODisplayExtension_IsValid;

	private static IntPtr CreateOpenColorIODisplayExtension_FunctionAddress;

	private static int CreateOpenColorIODisplayExtension_ParamsSize;

	private static bool CreateOpenColorIODisplayExtension_InDisplayConfiguration_IsValid;

	private static FFieldAddress CreateOpenColorIODisplayExtension_InDisplayConfiguration_PropertyAddress;

	private static int CreateOpenColorIODisplayExtension_InDisplayConfiguration_Offset;

	private static bool CreateOpenColorIODisplayExtension_IsActiveFunction_IsValid;

	private static FFieldAddress CreateOpenColorIODisplayExtension_IsActiveFunction_PropertyAddress;

	private static int CreateOpenColorIODisplayExtension_IsActiveFunction_Offset;

	private static bool CreateOpenColorIODisplayExtension_ReturnValue_IsValid;

	private static FFieldAddress CreateOpenColorIODisplayExtension_ReturnValue_PropertyAddress;

	private static int CreateOpenColorIODisplayExtension_ReturnValue_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/OpenColorIO.OpenColorIODisplayExtensionWrapper:SetSceneExtensionIsActiveFunctions")]
	public unsafe void SetSceneExtensionIsActiveFunctions(List<FSceneViewExtensionIsActiveFunctor> IsActiveFunctions)
	{
		CheckDestroyed();
		if (!SetSceneExtensionIsActiveFunctions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OpenColorIO.OpenColorIODisplayExtensionWrapper:SetSceneExtensionIsActiveFunctions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSceneExtensionIsActiveFunctions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSceneExtensionIsActiveFunctions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FSceneViewExtensionIsActiveFunctor>(1, SetSceneExtensionIsActiveFunctions_IsActiveFunctions_PropertyAddress, CachedMarshalingDelegates<FSceneViewExtensionIsActiveFunctor, FSceneViewExtensionIsActiveFunctor>.FromNative, CachedMarshalingDelegates<FSceneViewExtensionIsActiveFunctor, FSceneViewExtensionIsActiveFunctor>.ToNative).ToNative(IntPtr.Add(intPtr, SetSceneExtensionIsActiveFunctions_IsActiveFunctions_Offset), IsActiveFunctions);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSceneExtensionIsActiveFunctions_FunctionAddress, intPtr, SetSceneExtensionIsActiveFunctions_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSceneExtensionIsActiveFunctions_IsActiveFunctions_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/OpenColorIO.OpenColorIODisplayExtensionWrapper:SetSceneExtensionIsActiveFunction")]
	public unsafe void SetSceneExtensionIsActiveFunction(FSceneViewExtensionIsActiveFunctor IsActiveFunction)
	{
		CheckDestroyed();
		if (!SetSceneExtensionIsActiveFunction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OpenColorIO.OpenColorIODisplayExtensionWrapper:SetSceneExtensionIsActiveFunction");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSceneExtensionIsActiveFunction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSceneExtensionIsActiveFunction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSceneExtensionIsActiveFunction_IsActiveFunction_PropertyAddress.Address, intPtr);
		FSceneViewExtensionIsActiveFunctor.ToNative(IntPtr.Add(intPtr, SetSceneExtensionIsActiveFunction_IsActiveFunction_Offset), 0, SetSceneExtensionIsActiveFunction_IsActiveFunction_PropertyAddress.Address, IsActiveFunction);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSceneExtensionIsActiveFunction_FunctionAddress, intPtr, SetSceneExtensionIsActiveFunction_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSceneExtensionIsActiveFunction_IsActiveFunction_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/OpenColorIO.OpenColorIODisplayExtensionWrapper:SetOpenColorIOConfiguration")]
	public unsafe void SetOpenColorIOConfiguration(FOpenColorIODisplayConfiguration InDisplayConfiguration)
	{
		CheckDestroyed();
		if (!SetOpenColorIOConfiguration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OpenColorIO.OpenColorIODisplayExtensionWrapper:SetOpenColorIOConfiguration");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOpenColorIOConfiguration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOpenColorIOConfiguration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetOpenColorIOConfiguration_InDisplayConfiguration_PropertyAddress.Address, intPtr);
		FOpenColorIODisplayConfiguration.ToNative(IntPtr.Add(intPtr, SetOpenColorIOConfiguration_InDisplayConfiguration_Offset), 0, SetOpenColorIOConfiguration_InDisplayConfiguration_PropertyAddress.Address, InDisplayConfiguration);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOpenColorIOConfiguration_FunctionAddress, intPtr, SetOpenColorIOConfiguration_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetOpenColorIOConfiguration_InDisplayConfiguration_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/OpenColorIO.OpenColorIODisplayExtensionWrapper:RemoveSceneExtension")]
	public unsafe void RemoveSceneExtension()
	{
		CheckDestroyed();
		if (!RemoveSceneExtension_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OpenColorIO.OpenColorIODisplayExtensionWrapper:RemoveSceneExtension");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveSceneExtension_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveSceneExtension_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RemoveSceneExtension_FunctionAddress, argsSize: RemoveSceneExtension_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OpenColorIO.OpenColorIODisplayExtensionWrapper:CreateOpenColorIODisplayExtension")]
	public unsafe static UOpenColorIODisplayExtensionWrapper CreateOpenColorIODisplayExtension(FOpenColorIODisplayConfiguration InDisplayConfiguration, FSceneViewExtensionIsActiveFunctor IsActiveFunction)
	{
		if (!CreateOpenColorIODisplayExtension_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OpenColorIO.OpenColorIODisplayExtensionWrapper:CreateOpenColorIODisplayExtension");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateOpenColorIODisplayExtension_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateOpenColorIODisplayExtension_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CreateOpenColorIODisplayExtension_InDisplayConfiguration_PropertyAddress.Address, intPtr);
		FOpenColorIODisplayConfiguration.ToNative(IntPtr.Add(intPtr, CreateOpenColorIODisplayExtension_InDisplayConfiguration_Offset), 0, CreateOpenColorIODisplayExtension_InDisplayConfiguration_PropertyAddress.Address, InDisplayConfiguration);
		NativeReflection.InitializeValue_InContainer(CreateOpenColorIODisplayExtension_IsActiveFunction_PropertyAddress.Address, intPtr);
		FSceneViewExtensionIsActiveFunctor.ToNative(IntPtr.Add(intPtr, CreateOpenColorIODisplayExtension_IsActiveFunction_Offset), 0, CreateOpenColorIODisplayExtension_IsActiveFunction_PropertyAddress.Address, IsActiveFunction);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateOpenColorIODisplayExtension_FunctionAddress, intPtr, CreateOpenColorIODisplayExtension_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateOpenColorIODisplayExtension_InDisplayConfiguration_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateOpenColorIODisplayExtension_IsActiveFunction_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UOpenColorIODisplayExtensionWrapper>.FromNative(IntPtr.Add(intPtr, CreateOpenColorIODisplayExtension_ReturnValue_Offset), 0, CreateOpenColorIODisplayExtension_ReturnValue_PropertyAddress.Address);
	}

	static UOpenColorIODisplayExtensionWrapper()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UOpenColorIODisplayExtensionWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UOpenColorIODisplayExtensionWrapper));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/OpenColorIO.OpenColorIODisplayExtensionWrapper");
		SetSceneExtensionIsActiveFunctions_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSceneExtensionIsActiveFunctions");
		SetSceneExtensionIsActiveFunctions_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSceneExtensionIsActiveFunctions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSceneExtensionIsActiveFunctions_IsActiveFunctions_PropertyAddress, SetSceneExtensionIsActiveFunctions_FunctionAddress, "IsActiveFunctions");
		SetSceneExtensionIsActiveFunctions_IsActiveFunctions_Offset = NativeReflectionCached.GetPropertyOffset(SetSceneExtensionIsActiveFunctions_FunctionAddress, "IsActiveFunctions");
		SetSceneExtensionIsActiveFunctions_IsActiveFunctions_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSceneExtensionIsActiveFunctions_FunctionAddress, "IsActiveFunctions", Classes.FArrayProperty);
		SetSceneExtensionIsActiveFunctions_IsValid = SetSceneExtensionIsActiveFunctions_FunctionAddress != IntPtr.Zero && SetSceneExtensionIsActiveFunctions_IsActiveFunctions_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OpenColorIO.OpenColorIODisplayExtensionWrapper:SetSceneExtensionIsActiveFunctions", SetSceneExtensionIsActiveFunctions_IsValid);
		SetSceneExtensionIsActiveFunction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSceneExtensionIsActiveFunction");
		SetSceneExtensionIsActiveFunction_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSceneExtensionIsActiveFunction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSceneExtensionIsActiveFunction_IsActiveFunction_PropertyAddress, SetSceneExtensionIsActiveFunction_FunctionAddress, "IsActiveFunction");
		SetSceneExtensionIsActiveFunction_IsActiveFunction_Offset = NativeReflectionCached.GetPropertyOffset(SetSceneExtensionIsActiveFunction_FunctionAddress, "IsActiveFunction");
		SetSceneExtensionIsActiveFunction_IsActiveFunction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSceneExtensionIsActiveFunction_FunctionAddress, "IsActiveFunction", Classes.FStructProperty);
		SetSceneExtensionIsActiveFunction_IsValid = SetSceneExtensionIsActiveFunction_FunctionAddress != IntPtr.Zero && SetSceneExtensionIsActiveFunction_IsActiveFunction_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OpenColorIO.OpenColorIODisplayExtensionWrapper:SetSceneExtensionIsActiveFunction", SetSceneExtensionIsActiveFunction_IsValid);
		SetOpenColorIOConfiguration_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetOpenColorIOConfiguration");
		SetOpenColorIOConfiguration_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOpenColorIOConfiguration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOpenColorIOConfiguration_InDisplayConfiguration_PropertyAddress, SetOpenColorIOConfiguration_FunctionAddress, "InDisplayConfiguration");
		SetOpenColorIOConfiguration_InDisplayConfiguration_Offset = NativeReflectionCached.GetPropertyOffset(SetOpenColorIOConfiguration_FunctionAddress, "InDisplayConfiguration");
		SetOpenColorIOConfiguration_InDisplayConfiguration_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOpenColorIOConfiguration_FunctionAddress, "InDisplayConfiguration", Classes.FStructProperty);
		SetOpenColorIOConfiguration_IsValid = SetOpenColorIOConfiguration_FunctionAddress != IntPtr.Zero && SetOpenColorIOConfiguration_InDisplayConfiguration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OpenColorIO.OpenColorIODisplayExtensionWrapper:SetOpenColorIOConfiguration", SetOpenColorIOConfiguration_IsValid);
		RemoveSceneExtension_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveSceneExtension");
		RemoveSceneExtension_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveSceneExtension_FunctionAddress);
		RemoveSceneExtension_IsValid = RemoveSceneExtension_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/OpenColorIO.OpenColorIODisplayExtensionWrapper:RemoveSceneExtension", RemoveSceneExtension_IsValid);
		CreateOpenColorIODisplayExtension_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateOpenColorIODisplayExtension");
		CreateOpenColorIODisplayExtension_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateOpenColorIODisplayExtension_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateOpenColorIODisplayExtension_InDisplayConfiguration_PropertyAddress, CreateOpenColorIODisplayExtension_FunctionAddress, "InDisplayConfiguration");
		CreateOpenColorIODisplayExtension_InDisplayConfiguration_Offset = NativeReflectionCached.GetPropertyOffset(CreateOpenColorIODisplayExtension_FunctionAddress, "InDisplayConfiguration");
		CreateOpenColorIODisplayExtension_InDisplayConfiguration_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateOpenColorIODisplayExtension_FunctionAddress, "InDisplayConfiguration", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateOpenColorIODisplayExtension_IsActiveFunction_PropertyAddress, CreateOpenColorIODisplayExtension_FunctionAddress, "IsActiveFunction");
		CreateOpenColorIODisplayExtension_IsActiveFunction_Offset = NativeReflectionCached.GetPropertyOffset(CreateOpenColorIODisplayExtension_FunctionAddress, "IsActiveFunction");
		CreateOpenColorIODisplayExtension_IsActiveFunction_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateOpenColorIODisplayExtension_FunctionAddress, "IsActiveFunction", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateOpenColorIODisplayExtension_ReturnValue_PropertyAddress, CreateOpenColorIODisplayExtension_FunctionAddress, "ReturnValue");
		CreateOpenColorIODisplayExtension_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateOpenColorIODisplayExtension_FunctionAddress, "ReturnValue");
		CreateOpenColorIODisplayExtension_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateOpenColorIODisplayExtension_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateOpenColorIODisplayExtension_IsValid = CreateOpenColorIODisplayExtension_FunctionAddress != IntPtr.Zero && CreateOpenColorIODisplayExtension_InDisplayConfiguration_IsValid && CreateOpenColorIODisplayExtension_IsActiveFunction_IsValid && CreateOpenColorIODisplayExtension_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OpenColorIO.OpenColorIODisplayExtensionWrapper:CreateOpenColorIODisplayExtension", CreateOpenColorIODisplayExtension_IsValid);
	}
}
