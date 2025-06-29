using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.TypedElementFramework;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.EngineElementsLibrary", "Engine", UnrealModuleType.Engine)]
public class UEngineElementsLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool AcquireEditorSMInstanceElementHandle_IsValid;

	private static IntPtr AcquireEditorSMInstanceElementHandle_FunctionAddress;

	private static int AcquireEditorSMInstanceElementHandle_ParamsSize;

	private static bool AcquireEditorSMInstanceElementHandle_ISMComponent_IsValid;

	private static FFieldAddress AcquireEditorSMInstanceElementHandle_ISMComponent_PropertyAddress;

	private static int AcquireEditorSMInstanceElementHandle_ISMComponent_Offset;

	private static bool AcquireEditorSMInstanceElementHandle_InstanceIndex_IsValid;

	private static FFieldAddress AcquireEditorSMInstanceElementHandle_InstanceIndex_PropertyAddress;

	private static int AcquireEditorSMInstanceElementHandle_InstanceIndex_Offset;

	private static bool AcquireEditorSMInstanceElementHandle_bAllowCreate_IsValid;

	private static FFieldAddress AcquireEditorSMInstanceElementHandle_bAllowCreate_PropertyAddress;

	private static int AcquireEditorSMInstanceElementHandle_bAllowCreate_Offset;

	private static bool AcquireEditorSMInstanceElementHandle_ReturnValue_IsValid;

	private static FFieldAddress AcquireEditorSMInstanceElementHandle_ReturnValue_PropertyAddress;

	private static int AcquireEditorSMInstanceElementHandle_ReturnValue_Offset;

	private static bool AcquireEditorObjectElementHandle_IsValid;

	private static IntPtr AcquireEditorObjectElementHandle_FunctionAddress;

	private static int AcquireEditorObjectElementHandle_ParamsSize;

	private static bool AcquireEditorObjectElementHandle_Object_IsValid;

	private static FFieldAddress AcquireEditorObjectElementHandle_Object_PropertyAddress;

	private static int AcquireEditorObjectElementHandle_Object_Offset;

	private static bool AcquireEditorObjectElementHandle_bAllowCreate_IsValid;

	private static FFieldAddress AcquireEditorObjectElementHandle_bAllowCreate_PropertyAddress;

	private static int AcquireEditorObjectElementHandle_bAllowCreate_Offset;

	private static bool AcquireEditorObjectElementHandle_ReturnValue_IsValid;

	private static FFieldAddress AcquireEditorObjectElementHandle_ReturnValue_PropertyAddress;

	private static int AcquireEditorObjectElementHandle_ReturnValue_Offset;

	private static bool AcquireEditorComponentElementHandle_IsValid;

	private static IntPtr AcquireEditorComponentElementHandle_FunctionAddress;

	private static int AcquireEditorComponentElementHandle_ParamsSize;

	private static bool AcquireEditorComponentElementHandle_Component_IsValid;

	private static FFieldAddress AcquireEditorComponentElementHandle_Component_PropertyAddress;

	private static int AcquireEditorComponentElementHandle_Component_Offset;

	private static bool AcquireEditorComponentElementHandle_bAllowCreate_IsValid;

	private static FFieldAddress AcquireEditorComponentElementHandle_bAllowCreate_PropertyAddress;

	private static int AcquireEditorComponentElementHandle_bAllowCreate_Offset;

	private static bool AcquireEditorComponentElementHandle_ReturnValue_IsValid;

	private static FFieldAddress AcquireEditorComponentElementHandle_ReturnValue_PropertyAddress;

	private static int AcquireEditorComponentElementHandle_ReturnValue_Offset;

	private static bool AcquireEditorActorElementHandle_IsValid;

	private static IntPtr AcquireEditorActorElementHandle_FunctionAddress;

	private static int AcquireEditorActorElementHandle_ParamsSize;

	private static bool AcquireEditorActorElementHandle_Actor_IsValid;

	private static FFieldAddress AcquireEditorActorElementHandle_Actor_PropertyAddress;

	private static int AcquireEditorActorElementHandle_Actor_Offset;

	private static bool AcquireEditorActorElementHandle_bAllowCreate_IsValid;

	private static FFieldAddress AcquireEditorActorElementHandle_bAllowCreate_PropertyAddress;

	private static int AcquireEditorActorElementHandle_bAllowCreate_Offset;

	private static bool AcquireEditorActorElementHandle_ReturnValue_IsValid;

	private static FFieldAddress AcquireEditorActorElementHandle_ReturnValue_PropertyAddress;

	private static int AcquireEditorActorElementHandle_ReturnValue_Offset;

	[UFunction(Flags = 604120065u, OriginalName = "K2_AcquireEditorSMInstanceElementHandle")]
	[UMetaPath("/Script/Engine.EngineElementsLibrary:K2_AcquireEditorSMInstanceElementHandle")]
	public unsafe static FScriptTypedElementHandle AcquireEditorSMInstanceElementHandle(UInstancedStaticMeshComponent ISMComponent, int InstanceIndex, bool bAllowCreate = true)
	{
		if (!AcquireEditorSMInstanceElementHandle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.EngineElementsLibrary:K2_AcquireEditorSMInstanceElementHandle");
			return default(FScriptTypedElementHandle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AcquireEditorSMInstanceElementHandle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AcquireEditorSMInstanceElementHandle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UInstancedStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, AcquireEditorSMInstanceElementHandle_ISMComponent_Offset), 0, AcquireEditorSMInstanceElementHandle_ISMComponent_PropertyAddress.Address, ISMComponent);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AcquireEditorSMInstanceElementHandle_InstanceIndex_Offset), 0, AcquireEditorSMInstanceElementHandle_InstanceIndex_PropertyAddress.Address, InstanceIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AcquireEditorSMInstanceElementHandle_bAllowCreate_Offset), 0, AcquireEditorSMInstanceElementHandle_bAllowCreate_PropertyAddress.Address, bAllowCreate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AcquireEditorSMInstanceElementHandle_FunctionAddress, intPtr, AcquireEditorSMInstanceElementHandle_ParamsSize);
		FScriptTypedElementHandle result = FScriptTypedElementHandle.FromNative(IntPtr.Add(intPtr, AcquireEditorSMInstanceElementHandle_ReturnValue_Offset), 0, AcquireEditorSMInstanceElementHandle_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AcquireEditorSMInstanceElementHandle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u, OriginalName = "K2_AcquireEditorObjectElementHandle")]
	[UMetaPath("/Script/Engine.EngineElementsLibrary:K2_AcquireEditorObjectElementHandle")]
	public unsafe static FScriptTypedElementHandle AcquireEditorObjectElementHandle(UObject Object, bool bAllowCreate = true)
	{
		if (!AcquireEditorObjectElementHandle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.EngineElementsLibrary:K2_AcquireEditorObjectElementHandle");
			return default(FScriptTypedElementHandle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AcquireEditorObjectElementHandle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AcquireEditorObjectElementHandle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AcquireEditorObjectElementHandle_Object_Offset), 0, AcquireEditorObjectElementHandle_Object_PropertyAddress.Address, Object);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AcquireEditorObjectElementHandle_bAllowCreate_Offset), 0, AcquireEditorObjectElementHandle_bAllowCreate_PropertyAddress.Address, bAllowCreate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AcquireEditorObjectElementHandle_FunctionAddress, intPtr, AcquireEditorObjectElementHandle_ParamsSize);
		FScriptTypedElementHandle result = FScriptTypedElementHandle.FromNative(IntPtr.Add(intPtr, AcquireEditorObjectElementHandle_ReturnValue_Offset), 0, AcquireEditorObjectElementHandle_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AcquireEditorObjectElementHandle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u, OriginalName = "K2_AcquireEditorComponentElementHandle")]
	[UMetaPath("/Script/Engine.EngineElementsLibrary:K2_AcquireEditorComponentElementHandle")]
	public unsafe static FScriptTypedElementHandle AcquireEditorComponentElementHandle(UActorComponent Component, bool bAllowCreate = true)
	{
		if (!AcquireEditorComponentElementHandle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.EngineElementsLibrary:K2_AcquireEditorComponentElementHandle");
			return default(FScriptTypedElementHandle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AcquireEditorComponentElementHandle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AcquireEditorComponentElementHandle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, AcquireEditorComponentElementHandle_Component_Offset), 0, AcquireEditorComponentElementHandle_Component_PropertyAddress.Address, Component);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AcquireEditorComponentElementHandle_bAllowCreate_Offset), 0, AcquireEditorComponentElementHandle_bAllowCreate_PropertyAddress.Address, bAllowCreate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AcquireEditorComponentElementHandle_FunctionAddress, intPtr, AcquireEditorComponentElementHandle_ParamsSize);
		FScriptTypedElementHandle result = FScriptTypedElementHandle.FromNative(IntPtr.Add(intPtr, AcquireEditorComponentElementHandle_ReturnValue_Offset), 0, AcquireEditorComponentElementHandle_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AcquireEditorComponentElementHandle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u, OriginalName = "K2_AcquireEditorActorElementHandle")]
	[UMetaPath("/Script/Engine.EngineElementsLibrary:K2_AcquireEditorActorElementHandle")]
	public unsafe static FScriptTypedElementHandle AcquireEditorActorElementHandle(AActor Actor, bool bAllowCreate = true)
	{
		if (!AcquireEditorActorElementHandle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.EngineElementsLibrary:K2_AcquireEditorActorElementHandle");
			return default(FScriptTypedElementHandle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AcquireEditorActorElementHandle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AcquireEditorActorElementHandle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AcquireEditorActorElementHandle_Actor_Offset), 0, AcquireEditorActorElementHandle_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AcquireEditorActorElementHandle_bAllowCreate_Offset), 0, AcquireEditorActorElementHandle_bAllowCreate_PropertyAddress.Address, bAllowCreate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AcquireEditorActorElementHandle_FunctionAddress, intPtr, AcquireEditorActorElementHandle_ParamsSize);
		FScriptTypedElementHandle result = FScriptTypedElementHandle.FromNative(IntPtr.Add(intPtr, AcquireEditorActorElementHandle_ReturnValue_Offset), 0, AcquireEditorActorElementHandle_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AcquireEditorActorElementHandle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UEngineElementsLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEngineElementsLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEngineElementsLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.EngineElementsLibrary");
		AcquireEditorSMInstanceElementHandle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_AcquireEditorSMInstanceElementHandle");
		AcquireEditorSMInstanceElementHandle_ParamsSize = NativeReflection.GetFunctionParamsSize(AcquireEditorSMInstanceElementHandle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AcquireEditorSMInstanceElementHandle_ISMComponent_PropertyAddress, AcquireEditorSMInstanceElementHandle_FunctionAddress, "ISMComponent");
		AcquireEditorSMInstanceElementHandle_ISMComponent_Offset = NativeReflectionCached.GetPropertyOffset(AcquireEditorSMInstanceElementHandle_FunctionAddress, "ISMComponent");
		AcquireEditorSMInstanceElementHandle_ISMComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(AcquireEditorSMInstanceElementHandle_FunctionAddress, "ISMComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AcquireEditorSMInstanceElementHandle_InstanceIndex_PropertyAddress, AcquireEditorSMInstanceElementHandle_FunctionAddress, "InstanceIndex");
		AcquireEditorSMInstanceElementHandle_InstanceIndex_Offset = NativeReflectionCached.GetPropertyOffset(AcquireEditorSMInstanceElementHandle_FunctionAddress, "InstanceIndex");
		AcquireEditorSMInstanceElementHandle_InstanceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(AcquireEditorSMInstanceElementHandle_FunctionAddress, "InstanceIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AcquireEditorSMInstanceElementHandle_bAllowCreate_PropertyAddress, AcquireEditorSMInstanceElementHandle_FunctionAddress, "bAllowCreate");
		AcquireEditorSMInstanceElementHandle_bAllowCreate_Offset = NativeReflectionCached.GetPropertyOffset(AcquireEditorSMInstanceElementHandle_FunctionAddress, "bAllowCreate");
		AcquireEditorSMInstanceElementHandle_bAllowCreate_IsValid = NativeReflectionCached.ValidatePropertyClass(AcquireEditorSMInstanceElementHandle_FunctionAddress, "bAllowCreate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AcquireEditorSMInstanceElementHandle_ReturnValue_PropertyAddress, AcquireEditorSMInstanceElementHandle_FunctionAddress, "ReturnValue");
		AcquireEditorSMInstanceElementHandle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AcquireEditorSMInstanceElementHandle_FunctionAddress, "ReturnValue");
		AcquireEditorSMInstanceElementHandle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AcquireEditorSMInstanceElementHandle_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AcquireEditorSMInstanceElementHandle_IsValid = AcquireEditorSMInstanceElementHandle_FunctionAddress != IntPtr.Zero && AcquireEditorSMInstanceElementHandle_ISMComponent_IsValid && AcquireEditorSMInstanceElementHandle_InstanceIndex_IsValid && AcquireEditorSMInstanceElementHandle_bAllowCreate_IsValid && AcquireEditorSMInstanceElementHandle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.EngineElementsLibrary:K2_AcquireEditorSMInstanceElementHandle", AcquireEditorSMInstanceElementHandle_IsValid);
		AcquireEditorObjectElementHandle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_AcquireEditorObjectElementHandle");
		AcquireEditorObjectElementHandle_ParamsSize = NativeReflection.GetFunctionParamsSize(AcquireEditorObjectElementHandle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AcquireEditorObjectElementHandle_Object_PropertyAddress, AcquireEditorObjectElementHandle_FunctionAddress, "Object");
		AcquireEditorObjectElementHandle_Object_Offset = NativeReflectionCached.GetPropertyOffset(AcquireEditorObjectElementHandle_FunctionAddress, "Object");
		AcquireEditorObjectElementHandle_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(AcquireEditorObjectElementHandle_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AcquireEditorObjectElementHandle_bAllowCreate_PropertyAddress, AcquireEditorObjectElementHandle_FunctionAddress, "bAllowCreate");
		AcquireEditorObjectElementHandle_bAllowCreate_Offset = NativeReflectionCached.GetPropertyOffset(AcquireEditorObjectElementHandle_FunctionAddress, "bAllowCreate");
		AcquireEditorObjectElementHandle_bAllowCreate_IsValid = NativeReflectionCached.ValidatePropertyClass(AcquireEditorObjectElementHandle_FunctionAddress, "bAllowCreate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AcquireEditorObjectElementHandle_ReturnValue_PropertyAddress, AcquireEditorObjectElementHandle_FunctionAddress, "ReturnValue");
		AcquireEditorObjectElementHandle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AcquireEditorObjectElementHandle_FunctionAddress, "ReturnValue");
		AcquireEditorObjectElementHandle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AcquireEditorObjectElementHandle_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AcquireEditorObjectElementHandle_IsValid = AcquireEditorObjectElementHandle_FunctionAddress != IntPtr.Zero && AcquireEditorObjectElementHandle_Object_IsValid && AcquireEditorObjectElementHandle_bAllowCreate_IsValid && AcquireEditorObjectElementHandle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.EngineElementsLibrary:K2_AcquireEditorObjectElementHandle", AcquireEditorObjectElementHandle_IsValid);
		AcquireEditorComponentElementHandle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_AcquireEditorComponentElementHandle");
		AcquireEditorComponentElementHandle_ParamsSize = NativeReflection.GetFunctionParamsSize(AcquireEditorComponentElementHandle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AcquireEditorComponentElementHandle_Component_PropertyAddress, AcquireEditorComponentElementHandle_FunctionAddress, "Component");
		AcquireEditorComponentElementHandle_Component_Offset = NativeReflectionCached.GetPropertyOffset(AcquireEditorComponentElementHandle_FunctionAddress, "Component");
		AcquireEditorComponentElementHandle_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(AcquireEditorComponentElementHandle_FunctionAddress, "Component", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AcquireEditorComponentElementHandle_bAllowCreate_PropertyAddress, AcquireEditorComponentElementHandle_FunctionAddress, "bAllowCreate");
		AcquireEditorComponentElementHandle_bAllowCreate_Offset = NativeReflectionCached.GetPropertyOffset(AcquireEditorComponentElementHandle_FunctionAddress, "bAllowCreate");
		AcquireEditorComponentElementHandle_bAllowCreate_IsValid = NativeReflectionCached.ValidatePropertyClass(AcquireEditorComponentElementHandle_FunctionAddress, "bAllowCreate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AcquireEditorComponentElementHandle_ReturnValue_PropertyAddress, AcquireEditorComponentElementHandle_FunctionAddress, "ReturnValue");
		AcquireEditorComponentElementHandle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AcquireEditorComponentElementHandle_FunctionAddress, "ReturnValue");
		AcquireEditorComponentElementHandle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AcquireEditorComponentElementHandle_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AcquireEditorComponentElementHandle_IsValid = AcquireEditorComponentElementHandle_FunctionAddress != IntPtr.Zero && AcquireEditorComponentElementHandle_Component_IsValid && AcquireEditorComponentElementHandle_bAllowCreate_IsValid && AcquireEditorComponentElementHandle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.EngineElementsLibrary:K2_AcquireEditorComponentElementHandle", AcquireEditorComponentElementHandle_IsValid);
		AcquireEditorActorElementHandle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "K2_AcquireEditorActorElementHandle");
		AcquireEditorActorElementHandle_ParamsSize = NativeReflection.GetFunctionParamsSize(AcquireEditorActorElementHandle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AcquireEditorActorElementHandle_Actor_PropertyAddress, AcquireEditorActorElementHandle_FunctionAddress, "Actor");
		AcquireEditorActorElementHandle_Actor_Offset = NativeReflectionCached.GetPropertyOffset(AcquireEditorActorElementHandle_FunctionAddress, "Actor");
		AcquireEditorActorElementHandle_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(AcquireEditorActorElementHandle_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AcquireEditorActorElementHandle_bAllowCreate_PropertyAddress, AcquireEditorActorElementHandle_FunctionAddress, "bAllowCreate");
		AcquireEditorActorElementHandle_bAllowCreate_Offset = NativeReflectionCached.GetPropertyOffset(AcquireEditorActorElementHandle_FunctionAddress, "bAllowCreate");
		AcquireEditorActorElementHandle_bAllowCreate_IsValid = NativeReflectionCached.ValidatePropertyClass(AcquireEditorActorElementHandle_FunctionAddress, "bAllowCreate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AcquireEditorActorElementHandle_ReturnValue_PropertyAddress, AcquireEditorActorElementHandle_FunctionAddress, "ReturnValue");
		AcquireEditorActorElementHandle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AcquireEditorActorElementHandle_FunctionAddress, "ReturnValue");
		AcquireEditorActorElementHandle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AcquireEditorActorElementHandle_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AcquireEditorActorElementHandle_IsValid = AcquireEditorActorElementHandle_FunctionAddress != IntPtr.Zero && AcquireEditorActorElementHandle_Actor_IsValid && AcquireEditorActorElementHandle_bAllowCreate_IsValid && AcquireEditorActorElementHandle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.EngineElementsLibrary:K2_AcquireEditorActorElementHandle", AcquireEditorActorElementHandle_IsValid);
	}
}
