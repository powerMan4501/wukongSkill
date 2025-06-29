using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_Classes
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_StaticClass();

	public static Del_StaticClass UClass;

	public static Del_StaticClass UScriptStruct;

	public static Del_StaticClass UObject;

	public static Del_StaticClass UPackage;

	public static Del_StaticClass UMetaData;

	public static Del_StaticClass UObjectRedirector;

	public static Del_StaticClass UField;

	public static Del_StaticClass UStruct;

	public static Del_StaticClass UInterface;

	public static Del_StaticClass UEnum;

	public static Del_StaticClass UFunction;

	public static Del_StaticClass UDelegateFunction;

	public static Del_StaticClass FField;

	public static Del_StaticClass FProperty;

	public static Del_StaticClass FNumericProperty;

	public static Del_StaticClass FObjectPropertyBase;

	public static Del_StaticClass FBoolProperty;

	public static Del_StaticClass FInt8Property;

	public static Del_StaticClass FInt16Property;

	public static Del_StaticClass FIntProperty;

	public static Del_StaticClass FInt64Property;

	public static Del_StaticClass FByteProperty;

	public static Del_StaticClass FUInt16Property;

	public static Del_StaticClass FUInt32Property;

	public static Del_StaticClass FUInt64Property;

	public static Del_StaticClass FDoubleProperty;

	public static Del_StaticClass FFloatProperty;

	public static Del_StaticClass FEnumProperty;

	public static Del_StaticClass FInterfaceProperty;

	public static Del_StaticClass FStructProperty;

	public static Del_StaticClass FClassProperty;

	public static Del_StaticClass FObjectProperty;

	public static Del_StaticClass FLazyObjectProperty;

	public static Del_StaticClass FWeakObjectProperty;

	public static Del_StaticClass FSoftClassProperty;

	public static Del_StaticClass FSoftObjectProperty;

	public static Del_StaticClass FDelegateProperty;

	public static Del_StaticClass FMulticastDelegateProperty;

	public static Del_StaticClass FMulticastInlineDelegateProperty;

	public static Del_StaticClass FMulticastSparseDelegateProperty;

	public static Del_StaticClass FArrayProperty;

	public static Del_StaticClass FMapProperty;

	public static Del_StaticClass FSetProperty;

	public static Del_StaticClass FStrProperty;

	public static Del_StaticClass FNameProperty;

	public static Del_StaticClass FTextProperty;

	public static Del_StaticClass UUserDefinedStruct;

	public static Del_StaticClass UUserDefinedEnum;

	public static Del_StaticClass UBlueprint;

	public static Del_StaticClass UBlueprintCore;

	public static Del_StaticClass UBlueprintFunctionLibrary;

	public static Del_StaticClass UBlueprintGeneratedClass;

	public static Del_StaticClass UGameInstance;

	public static Del_StaticClass UGameEngine;

	public static Del_StaticClass UWorld;

	public static Del_StaticClass AActor;

	public static Del_StaticClass APawn;

	public static Del_StaticClass USharpClass;

	public static Del_StaticClass USharpStruct;

	public static Del_StaticClass UActorComponent;

	public static Del_StaticClass APlayerController;

	public static Del_StaticClass UGameInstanceSubsystem;

	public static Del_StaticClass UEngineSubsystem;

	public static Del_StaticClass ULocalPlayerSubsystem;

	public static Del_StaticClass USubsystem;
}
