using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_SubsystemFunctionLibrary", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_SubsystemFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetWorldSubsystem_IsValid;

	private static IntPtr GetWorldSubsystem_FunctionAddress;

	private static int GetWorldSubsystem_ParamsSize;

	private static bool GetWorldSubsystem_ContextObject_IsValid;

	private static FFieldAddress GetWorldSubsystem_ContextObject_PropertyAddress;

	private static int GetWorldSubsystem_ContextObject_Offset;

	private static bool GetWorldSubsystem_Class_IsValid;

	private static FFieldAddress GetWorldSubsystem_Class_PropertyAddress;

	private static int GetWorldSubsystem_Class_Offset;

	private static bool GetWorldSubsystem_ReturnValue_IsValid;

	private static FFieldAddress GetWorldSubsystem_ReturnValue_PropertyAddress;

	private static int GetWorldSubsystem_ReturnValue_Offset;

	private static bool GetLocalPlayerSubSystemFromPlayerController_IsValid;

	private static IntPtr GetLocalPlayerSubSystemFromPlayerController_FunctionAddress;

	private static int GetLocalPlayerSubSystemFromPlayerController_ParamsSize;

	private static bool GetLocalPlayerSubSystemFromPlayerController_PlayerController_IsValid;

	private static FFieldAddress GetLocalPlayerSubSystemFromPlayerController_PlayerController_PropertyAddress;

	private static int GetLocalPlayerSubSystemFromPlayerController_PlayerController_Offset;

	private static bool GetLocalPlayerSubSystemFromPlayerController_Class_IsValid;

	private static FFieldAddress GetLocalPlayerSubSystemFromPlayerController_Class_PropertyAddress;

	private static int GetLocalPlayerSubSystemFromPlayerController_Class_Offset;

	private static bool GetLocalPlayerSubSystemFromPlayerController_ReturnValue_IsValid;

	private static FFieldAddress GetLocalPlayerSubSystemFromPlayerController_ReturnValue_PropertyAddress;

	private static int GetLocalPlayerSubSystemFromPlayerController_ReturnValue_Offset;

	private static bool GetLocalPlayerSubsystem_IsValid;

	private static IntPtr GetLocalPlayerSubsystem_FunctionAddress;

	private static int GetLocalPlayerSubsystem_ParamsSize;

	private static bool GetLocalPlayerSubsystem_ContextObject_IsValid;

	private static FFieldAddress GetLocalPlayerSubsystem_ContextObject_PropertyAddress;

	private static int GetLocalPlayerSubsystem_ContextObject_Offset;

	private static bool GetLocalPlayerSubsystem_Class_IsValid;

	private static FFieldAddress GetLocalPlayerSubsystem_Class_PropertyAddress;

	private static int GetLocalPlayerSubsystem_Class_Offset;

	private static bool GetLocalPlayerSubsystem_ReturnValue_IsValid;

	private static FFieldAddress GetLocalPlayerSubsystem_ReturnValue_PropertyAddress;

	private static int GetLocalPlayerSubsystem_ReturnValue_Offset;

	private static bool GetGameInstanceSubsystem_IsValid;

	private static IntPtr GetGameInstanceSubsystem_FunctionAddress;

	private static int GetGameInstanceSubsystem_ParamsSize;

	private static bool GetGameInstanceSubsystem_ContextObject_IsValid;

	private static FFieldAddress GetGameInstanceSubsystem_ContextObject_PropertyAddress;

	private static int GetGameInstanceSubsystem_ContextObject_Offset;

	private static bool GetGameInstanceSubsystem_Class_IsValid;

	private static FFieldAddress GetGameInstanceSubsystem_Class_PropertyAddress;

	private static int GetGameInstanceSubsystem_Class_Offset;

	private static bool GetGameInstanceSubsystem_ReturnValue_IsValid;

	private static FFieldAddress GetGameInstanceSubsystem_ReturnValue_PropertyAddress;

	private static int GetGameInstanceSubsystem_ReturnValue_Offset;

	private static bool GetEngineSubsystem_IsValid;

	private static IntPtr GetEngineSubsystem_FunctionAddress;

	private static int GetEngineSubsystem_ParamsSize;

	private static bool GetEngineSubsystem_Class_IsValid;

	private static FFieldAddress GetEngineSubsystem_Class_PropertyAddress;

	private static int GetEngineSubsystem_Class_Offset;

	private static bool GetEngineSubsystem_ReturnValue_IsValid;

	private static FFieldAddress GetEngineSubsystem_ReturnValue_PropertyAddress;

	private static int GetEngineSubsystem_ReturnValue_Offset;

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SubsystemFunctionLibrary:GetWorldSubsystem")]
	public unsafe static UWorldSubsystem GetWorldSubsystem(UObject ContextObject, TSubclassOf<UWorldSubsystem> Class)
	{
		if (!GetWorldSubsystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SubsystemFunctionLibrary:GetWorldSubsystem");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorldSubsystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorldSubsystem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetWorldSubsystem_ContextObject_Offset), 0, GetWorldSubsystem_ContextObject_PropertyAddress.Address, ContextObject);
		TSubclassOfMarshaler<UWorldSubsystem>.ToNative(IntPtr.Add(intPtr, GetWorldSubsystem_Class_Offset), 0, GetWorldSubsystem_Class_PropertyAddress.Address, Class);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWorldSubsystem_FunctionAddress, intPtr, GetWorldSubsystem_ParamsSize);
		return UObjectMarshaler<UWorldSubsystem>.FromNative(IntPtr.Add(intPtr, GetWorldSubsystem_ReturnValue_Offset), 0, GetWorldSubsystem_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SubsystemFunctionLibrary:GetLocalPlayerSubSystemFromPlayerController")]
	public unsafe static ULocalPlayerSubsystem GetLocalPlayerSubSystemFromPlayerController(APlayerController PlayerController, TSubclassOf<ULocalPlayerSubsystem> Class)
	{
		if (!GetLocalPlayerSubSystemFromPlayerController_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SubsystemFunctionLibrary:GetLocalPlayerSubSystemFromPlayerController");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocalPlayerSubSystemFromPlayerController_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocalPlayerSubSystemFromPlayerController_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, GetLocalPlayerSubSystemFromPlayerController_PlayerController_Offset), 0, GetLocalPlayerSubSystemFromPlayerController_PlayerController_PropertyAddress.Address, PlayerController);
		TSubclassOfMarshaler<ULocalPlayerSubsystem>.ToNative(IntPtr.Add(intPtr, GetLocalPlayerSubSystemFromPlayerController_Class_Offset), 0, GetLocalPlayerSubSystemFromPlayerController_Class_PropertyAddress.Address, Class);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLocalPlayerSubSystemFromPlayerController_FunctionAddress, intPtr, GetLocalPlayerSubSystemFromPlayerController_ParamsSize);
		return UObjectMarshaler<ULocalPlayerSubsystem>.FromNative(IntPtr.Add(intPtr, GetLocalPlayerSubSystemFromPlayerController_ReturnValue_Offset), 0, GetLocalPlayerSubSystemFromPlayerController_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SubsystemFunctionLibrary:GetLocalPlayerSubsystem")]
	public unsafe static ULocalPlayerSubsystem GetLocalPlayerSubsystem(UObject ContextObject, TSubclassOf<ULocalPlayerSubsystem> Class)
	{
		if (!GetLocalPlayerSubsystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SubsystemFunctionLibrary:GetLocalPlayerSubsystem");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocalPlayerSubsystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocalPlayerSubsystem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetLocalPlayerSubsystem_ContextObject_Offset), 0, GetLocalPlayerSubsystem_ContextObject_PropertyAddress.Address, ContextObject);
		TSubclassOfMarshaler<ULocalPlayerSubsystem>.ToNative(IntPtr.Add(intPtr, GetLocalPlayerSubsystem_Class_Offset), 0, GetLocalPlayerSubsystem_Class_PropertyAddress.Address, Class);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLocalPlayerSubsystem_FunctionAddress, intPtr, GetLocalPlayerSubsystem_ParamsSize);
		return UObjectMarshaler<ULocalPlayerSubsystem>.FromNative(IntPtr.Add(intPtr, GetLocalPlayerSubsystem_ReturnValue_Offset), 0, GetLocalPlayerSubsystem_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SubsystemFunctionLibrary:GetGameInstanceSubsystem")]
	public unsafe static UGameInstanceSubsystem GetGameInstanceSubsystem(UObject ContextObject, TSubclassOf<UGameInstanceSubsystem> Class)
	{
		if (!GetGameInstanceSubsystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SubsystemFunctionLibrary:GetGameInstanceSubsystem");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGameInstanceSubsystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGameInstanceSubsystem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetGameInstanceSubsystem_ContextObject_Offset), 0, GetGameInstanceSubsystem_ContextObject_PropertyAddress.Address, ContextObject);
		TSubclassOfMarshaler<UGameInstanceSubsystem>.ToNative(IntPtr.Add(intPtr, GetGameInstanceSubsystem_Class_Offset), 0, GetGameInstanceSubsystem_Class_PropertyAddress.Address, Class);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGameInstanceSubsystem_FunctionAddress, intPtr, GetGameInstanceSubsystem_ParamsSize);
		return UObjectMarshaler<UGameInstanceSubsystem>.FromNative(IntPtr.Add(intPtr, GetGameInstanceSubsystem_ReturnValue_Offset), 0, GetGameInstanceSubsystem_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SubsystemFunctionLibrary:GetEngineSubsystem")]
	public unsafe static UEngineSubsystem GetEngineSubsystem(TSubclassOf<UEngineSubsystem> Class)
	{
		if (!GetEngineSubsystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SubsystemFunctionLibrary:GetEngineSubsystem");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEngineSubsystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEngineSubsystem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UEngineSubsystem>.ToNative(IntPtr.Add(intPtr, GetEngineSubsystem_Class_Offset), 0, GetEngineSubsystem_Class_PropertyAddress.Address, Class);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEngineSubsystem_FunctionAddress, intPtr, GetEngineSubsystem_ParamsSize);
		return UObjectMarshaler<UEngineSubsystem>.FromNative(IntPtr.Add(intPtr, GetEngineSubsystem_ReturnValue_Offset), 0, GetEngineSubsystem_ReturnValue_PropertyAddress.Address);
	}

	static UGSE_SubsystemFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_SubsystemFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_SubsystemFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_SubsystemFunctionLibrary");
		GetWorldSubsystem_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWorldSubsystem");
		GetWorldSubsystem_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorldSubsystem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorldSubsystem_ContextObject_PropertyAddress, GetWorldSubsystem_FunctionAddress, "ContextObject");
		GetWorldSubsystem_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldSubsystem_FunctionAddress, "ContextObject");
		GetWorldSubsystem_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldSubsystem_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWorldSubsystem_Class_PropertyAddress, GetWorldSubsystem_FunctionAddress, "Class");
		GetWorldSubsystem_Class_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldSubsystem_FunctionAddress, "Class");
		GetWorldSubsystem_Class_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldSubsystem_FunctionAddress, "Class", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetWorldSubsystem_ReturnValue_PropertyAddress, GetWorldSubsystem_FunctionAddress, "ReturnValue");
		GetWorldSubsystem_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldSubsystem_FunctionAddress, "ReturnValue");
		GetWorldSubsystem_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldSubsystem_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWorldSubsystem_IsValid = GetWorldSubsystem_FunctionAddress != IntPtr.Zero && GetWorldSubsystem_ContextObject_IsValid && GetWorldSubsystem_Class_IsValid && GetWorldSubsystem_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SubsystemFunctionLibrary:GetWorldSubsystem", GetWorldSubsystem_IsValid);
		GetLocalPlayerSubSystemFromPlayerController_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLocalPlayerSubSystemFromPlayerController");
		GetLocalPlayerSubSystemFromPlayerController_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocalPlayerSubSystemFromPlayerController_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocalPlayerSubSystemFromPlayerController_PlayerController_PropertyAddress, GetLocalPlayerSubSystemFromPlayerController_FunctionAddress, "PlayerController");
		GetLocalPlayerSubSystemFromPlayerController_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalPlayerSubSystemFromPlayerController_FunctionAddress, "PlayerController");
		GetLocalPlayerSubSystemFromPlayerController_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalPlayerSubSystemFromPlayerController_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalPlayerSubSystemFromPlayerController_Class_PropertyAddress, GetLocalPlayerSubSystemFromPlayerController_FunctionAddress, "Class");
		GetLocalPlayerSubSystemFromPlayerController_Class_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalPlayerSubSystemFromPlayerController_FunctionAddress, "Class");
		GetLocalPlayerSubSystemFromPlayerController_Class_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalPlayerSubSystemFromPlayerController_FunctionAddress, "Class", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalPlayerSubSystemFromPlayerController_ReturnValue_PropertyAddress, GetLocalPlayerSubSystemFromPlayerController_FunctionAddress, "ReturnValue");
		GetLocalPlayerSubSystemFromPlayerController_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalPlayerSubSystemFromPlayerController_FunctionAddress, "ReturnValue");
		GetLocalPlayerSubSystemFromPlayerController_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalPlayerSubSystemFromPlayerController_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetLocalPlayerSubSystemFromPlayerController_IsValid = GetLocalPlayerSubSystemFromPlayerController_FunctionAddress != IntPtr.Zero && GetLocalPlayerSubSystemFromPlayerController_PlayerController_IsValid && GetLocalPlayerSubSystemFromPlayerController_Class_IsValid && GetLocalPlayerSubSystemFromPlayerController_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SubsystemFunctionLibrary:GetLocalPlayerSubSystemFromPlayerController", GetLocalPlayerSubSystemFromPlayerController_IsValid);
		GetLocalPlayerSubsystem_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLocalPlayerSubsystem");
		GetLocalPlayerSubsystem_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocalPlayerSubsystem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocalPlayerSubsystem_ContextObject_PropertyAddress, GetLocalPlayerSubsystem_FunctionAddress, "ContextObject");
		GetLocalPlayerSubsystem_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalPlayerSubsystem_FunctionAddress, "ContextObject");
		GetLocalPlayerSubsystem_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalPlayerSubsystem_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalPlayerSubsystem_Class_PropertyAddress, GetLocalPlayerSubsystem_FunctionAddress, "Class");
		GetLocalPlayerSubsystem_Class_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalPlayerSubsystem_FunctionAddress, "Class");
		GetLocalPlayerSubsystem_Class_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalPlayerSubsystem_FunctionAddress, "Class", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalPlayerSubsystem_ReturnValue_PropertyAddress, GetLocalPlayerSubsystem_FunctionAddress, "ReturnValue");
		GetLocalPlayerSubsystem_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalPlayerSubsystem_FunctionAddress, "ReturnValue");
		GetLocalPlayerSubsystem_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalPlayerSubsystem_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetLocalPlayerSubsystem_IsValid = GetLocalPlayerSubsystem_FunctionAddress != IntPtr.Zero && GetLocalPlayerSubsystem_ContextObject_IsValid && GetLocalPlayerSubsystem_Class_IsValid && GetLocalPlayerSubsystem_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SubsystemFunctionLibrary:GetLocalPlayerSubsystem", GetLocalPlayerSubsystem_IsValid);
		GetGameInstanceSubsystem_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGameInstanceSubsystem");
		GetGameInstanceSubsystem_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGameInstanceSubsystem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGameInstanceSubsystem_ContextObject_PropertyAddress, GetGameInstanceSubsystem_FunctionAddress, "ContextObject");
		GetGameInstanceSubsystem_ContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetGameInstanceSubsystem_FunctionAddress, "ContextObject");
		GetGameInstanceSubsystem_ContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGameInstanceSubsystem_FunctionAddress, "ContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGameInstanceSubsystem_Class_PropertyAddress, GetGameInstanceSubsystem_FunctionAddress, "Class");
		GetGameInstanceSubsystem_Class_Offset = NativeReflectionCached.GetPropertyOffset(GetGameInstanceSubsystem_FunctionAddress, "Class");
		GetGameInstanceSubsystem_Class_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGameInstanceSubsystem_FunctionAddress, "Class", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGameInstanceSubsystem_ReturnValue_PropertyAddress, GetGameInstanceSubsystem_FunctionAddress, "ReturnValue");
		GetGameInstanceSubsystem_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGameInstanceSubsystem_FunctionAddress, "ReturnValue");
		GetGameInstanceSubsystem_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGameInstanceSubsystem_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetGameInstanceSubsystem_IsValid = GetGameInstanceSubsystem_FunctionAddress != IntPtr.Zero && GetGameInstanceSubsystem_ContextObject_IsValid && GetGameInstanceSubsystem_Class_IsValid && GetGameInstanceSubsystem_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SubsystemFunctionLibrary:GetGameInstanceSubsystem", GetGameInstanceSubsystem_IsValid);
		GetEngineSubsystem_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEngineSubsystem");
		GetEngineSubsystem_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEngineSubsystem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEngineSubsystem_Class_PropertyAddress, GetEngineSubsystem_FunctionAddress, "Class");
		GetEngineSubsystem_Class_Offset = NativeReflectionCached.GetPropertyOffset(GetEngineSubsystem_FunctionAddress, "Class");
		GetEngineSubsystem_Class_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEngineSubsystem_FunctionAddress, "Class", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEngineSubsystem_ReturnValue_PropertyAddress, GetEngineSubsystem_FunctionAddress, "ReturnValue");
		GetEngineSubsystem_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEngineSubsystem_FunctionAddress, "ReturnValue");
		GetEngineSubsystem_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEngineSubsystem_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetEngineSubsystem_IsValid = GetEngineSubsystem_FunctionAddress != IntPtr.Zero && GetEngineSubsystem_Class_IsValid && GetEngineSubsystem_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SubsystemFunctionLibrary:GetEngineSubsystem", GetEngineSubsystem_IsValid);
	}
}
