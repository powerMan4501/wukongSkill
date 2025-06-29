using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class Classes
{
	public static IntPtr UClass;

	public static IntPtr UScriptStruct;

	public static IntPtr UObject;

	public static IntPtr UPackage;

	public static IntPtr UMetaData;

	public static IntPtr UObjectRedirector;

	public static IntPtr UField;

	public static IntPtr UStruct;

	public static IntPtr UInterface;

	public static IntPtr UEnum;

	public static IntPtr UFunction;

	public static IntPtr UDelegateFunction;

	public static IntPtr FField;

	public static IntPtr FProperty;

	public static IntPtr FNumericProperty;

	public static IntPtr FObjectPropertyBase;

	public static IntPtr FBoolProperty;

	public static IntPtr FInt8Property;

	public static IntPtr FInt16Property;

	public static IntPtr FIntProperty;

	public static IntPtr FInt64Property;

	public static IntPtr FByteProperty;

	public static IntPtr FUInt16Property;

	public static IntPtr FUInt32Property;

	public static IntPtr FUInt64Property;

	public static IntPtr FDoubleProperty;

	public static IntPtr FFloatProperty;

	public static IntPtr FEnumProperty;

	public static IntPtr FInterfaceProperty;

	public static IntPtr FStructProperty;

	public static IntPtr FClassProperty;

	public static IntPtr FObjectProperty;

	public static IntPtr FLazyObjectProperty;

	public static IntPtr FWeakObjectProperty;

	public static IntPtr FSoftClassProperty;

	public static IntPtr FSoftObjectProperty;

	public static IntPtr FDelegateProperty;

	public static IntPtr FMulticastDelegateProperty;

	public static IntPtr FMulticastInlineDelegateProperty;

	public static IntPtr FMulticastSparseDelegateProperty;

	public static IntPtr FArrayProperty;

	public static IntPtr FMapProperty;

	public static IntPtr FSetProperty;

	public static IntPtr FStrProperty;

	public static IntPtr FNameProperty;

	public static IntPtr FTextProperty;

	public static IntPtr UUserDefinedStruct;

	public static IntPtr UUserDefinedEnum;

	public static IntPtr UBlueprint;

	public static IntPtr UBlueprintCore;

	public static IntPtr UBlueprintFunctionLibrary;

	public static IntPtr UBlueprintGeneratedClass;

	public static IntPtr UGameInstance;

	public static IntPtr UGameEngine;

	public static IntPtr UWorld;

	public static IntPtr AActor;

	public static IntPtr APawn;

	public static IntPtr UActorComponent;

	public static IntPtr APlayerController;

	public static IntPtr UGameInstanceSubsystem;

	public static IntPtr UEngineSubsystem;

	public static IntPtr ULocalPlayerSubsystem;

	public static IntPtr USubsystem;

	public static IntPtr USharpClass;

	public static IntPtr USharpStruct;

	private static IntPtr GetClass(string path, bool canBeNull = false)
	{
		return NativeReflection.FindObject(UClass, IntPtr.Zero, path);
	}

	private static IntPtr GetStruct(string path, bool canBeNull = false)
	{
		return NativeReflection.FindObject(UScriptStruct, IntPtr.Zero, path);
	}

	internal static void OnNativeFunctionsRegistered()
	{
		UClass = Native_Classes.UClass();
		UScriptStruct = Native_Classes.UScriptStruct();
		UObject = Native_Classes.UObject();
		UPackage = Native_Classes.UPackage();
		UMetaData = Native_Classes.UMetaData();
		UObjectRedirector = Native_Classes.UObjectRedirector();
		UField = Native_Classes.UField();
		UStruct = Native_Classes.UStruct();
		UInterface = Native_Classes.UInterface();
		UEnum = Native_Classes.UEnum();
		UFunction = Native_Classes.UFunction();
		UDelegateFunction = Native_Classes.UDelegateFunction();
		FField = Native_Classes.FField();
		FProperty = Native_Classes.FProperty();
		FNumericProperty = Native_Classes.FNumericProperty();
		FObjectPropertyBase = Native_Classes.FObjectPropertyBase();
		FBoolProperty = Native_Classes.FBoolProperty();
		FInt8Property = Native_Classes.FInt8Property();
		FInt16Property = Native_Classes.FInt16Property();
		FIntProperty = Native_Classes.FIntProperty();
		FInt64Property = Native_Classes.FInt64Property();
		FByteProperty = Native_Classes.FByteProperty();
		FUInt16Property = Native_Classes.FUInt16Property();
		FUInt32Property = Native_Classes.FUInt32Property();
		FUInt64Property = Native_Classes.FUInt64Property();
		FDoubleProperty = Native_Classes.FDoubleProperty();
		FFloatProperty = Native_Classes.FFloatProperty();
		FEnumProperty = Native_Classes.FEnumProperty();
		FInterfaceProperty = Native_Classes.FInterfaceProperty();
		FStructProperty = Native_Classes.FStructProperty();
		FClassProperty = Native_Classes.FClassProperty();
		FObjectProperty = Native_Classes.FObjectProperty();
		FLazyObjectProperty = Native_Classes.FLazyObjectProperty();
		FWeakObjectProperty = Native_Classes.FWeakObjectProperty();
		FSoftClassProperty = Native_Classes.FSoftClassProperty();
		FSoftObjectProperty = Native_Classes.FSoftObjectProperty();
		FDelegateProperty = Native_Classes.FDelegateProperty();
		FMulticastDelegateProperty = Native_Classes.FMulticastDelegateProperty();
		FMulticastInlineDelegateProperty = Native_Classes.FMulticastInlineDelegateProperty();
		FMulticastSparseDelegateProperty = Native_Classes.FMulticastSparseDelegateProperty();
		FArrayProperty = Native_Classes.FArrayProperty();
		FMapProperty = Native_Classes.FMapProperty();
		FSetProperty = Native_Classes.FSetProperty();
		FStrProperty = Native_Classes.FStrProperty();
		FNameProperty = Native_Classes.FNameProperty();
		FTextProperty = Native_Classes.FTextProperty();
		UUserDefinedStruct = Native_Classes.UUserDefinedStruct();
		UUserDefinedEnum = Native_Classes.UUserDefinedEnum();
		UBlueprint = Native_Classes.UBlueprint();
		UBlueprintCore = Native_Classes.UBlueprintCore();
		UBlueprintFunctionLibrary = Native_Classes.UBlueprintFunctionLibrary();
		UBlueprintGeneratedClass = Native_Classes.UBlueprintGeneratedClass();
		UGameInstance = Native_Classes.UGameInstance();
		UGameEngine = Native_Classes.UGameEngine();
		UWorld = Native_Classes.UWorld();
		AActor = Native_Classes.AActor();
		APawn = Native_Classes.APawn();
		UActorComponent = Native_Classes.UActorComponent();
		APlayerController = Native_Classes.APlayerController();
		UGameInstanceSubsystem = Native_Classes.UGameInstanceSubsystem();
		UEngineSubsystem = Native_Classes.UEngineSubsystem();
		ULocalPlayerSubsystem = Native_Classes.ULocalPlayerSubsystem();
		USubsystem = Native_Classes.USubsystem();
		USharpClass = Native_Classes.USharpClass();
		USharpStruct = Native_Classes.USharpStruct();
	}
}
