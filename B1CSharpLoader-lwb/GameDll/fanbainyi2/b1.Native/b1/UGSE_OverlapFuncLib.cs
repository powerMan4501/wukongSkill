using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_OverlapFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_OverlapFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool BoxOverlapComponentsByProfile_IsValid;

	private static IntPtr BoxOverlapComponentsByProfile_FunctionAddress;

	private static int BoxOverlapComponentsByProfile_ParamsSize;

	private static bool BoxOverlapComponentsByProfile_WorldContextObject_IsValid;

	private static FFieldAddress BoxOverlapComponentsByProfile_WorldContextObject_PropertyAddress;

	private static int BoxOverlapComponentsByProfile_WorldContextObject_Offset;

	private static bool BoxOverlapComponentsByProfile_BoxPos_IsValid;

	private static FFieldAddress BoxOverlapComponentsByProfile_BoxPos_PropertyAddress;

	private static int BoxOverlapComponentsByProfile_BoxPos_Offset;

	private static bool BoxOverlapComponentsByProfile_BoxExtent_IsValid;

	private static FFieldAddress BoxOverlapComponentsByProfile_BoxExtent_PropertyAddress;

	private static int BoxOverlapComponentsByProfile_BoxExtent_Offset;

	private static bool BoxOverlapComponentsByProfile_ProfileName_IsValid;

	private static FFieldAddress BoxOverlapComponentsByProfile_ProfileName_PropertyAddress;

	private static int BoxOverlapComponentsByProfile_ProfileName_Offset;

	private static bool BoxOverlapComponentsByProfile_ComponentClassFilter_IsValid;

	private static FFieldAddress BoxOverlapComponentsByProfile_ComponentClassFilter_PropertyAddress;

	private static int BoxOverlapComponentsByProfile_ComponentClassFilter_Offset;

	private static bool BoxOverlapComponentsByProfile_ActorsToIgnore_IsValid;

	private static FFieldAddress BoxOverlapComponentsByProfile_ActorsToIgnore_PropertyAddress;

	private static int BoxOverlapComponentsByProfile_ActorsToIgnore_Offset;

	private static bool BoxOverlapComponentsByProfile_OutComponents_IsValid;

	private static FFieldAddress BoxOverlapComponentsByProfile_OutComponents_PropertyAddress;

	private static int BoxOverlapComponentsByProfile_OutComponents_Offset;

	private static bool BoxOverlapComponentsByProfile_ReturnValue_IsValid;

	private static FFieldAddress BoxOverlapComponentsByProfile_ReturnValue_PropertyAddress;

	private static int BoxOverlapComponentsByProfile_ReturnValue_Offset;

	private static bool BoxOverlapActorsByProfile_IsValid;

	private static IntPtr BoxOverlapActorsByProfile_FunctionAddress;

	private static int BoxOverlapActorsByProfile_ParamsSize;

	private static bool BoxOverlapActorsByProfile_WorldContextObject_IsValid;

	private static FFieldAddress BoxOverlapActorsByProfile_WorldContextObject_PropertyAddress;

	private static int BoxOverlapActorsByProfile_WorldContextObject_Offset;

	private static bool BoxOverlapActorsByProfile_BoxPos_IsValid;

	private static FFieldAddress BoxOverlapActorsByProfile_BoxPos_PropertyAddress;

	private static int BoxOverlapActorsByProfile_BoxPos_Offset;

	private static bool BoxOverlapActorsByProfile_BoxExtent_IsValid;

	private static FFieldAddress BoxOverlapActorsByProfile_BoxExtent_PropertyAddress;

	private static int BoxOverlapActorsByProfile_BoxExtent_Offset;

	private static bool BoxOverlapActorsByProfile_ProfileName_IsValid;

	private static FFieldAddress BoxOverlapActorsByProfile_ProfileName_PropertyAddress;

	private static int BoxOverlapActorsByProfile_ProfileName_Offset;

	private static bool BoxOverlapActorsByProfile_ActorClassFilter_IsValid;

	private static FFieldAddress BoxOverlapActorsByProfile_ActorClassFilter_PropertyAddress;

	private static int BoxOverlapActorsByProfile_ActorClassFilter_Offset;

	private static bool BoxOverlapActorsByProfile_ActorsToIgnore_IsValid;

	private static FFieldAddress BoxOverlapActorsByProfile_ActorsToIgnore_PropertyAddress;

	private static int BoxOverlapActorsByProfile_ActorsToIgnore_Offset;

	private static bool BoxOverlapActorsByProfile_OutActors_IsValid;

	private static FFieldAddress BoxOverlapActorsByProfile_OutActors_PropertyAddress;

	private static int BoxOverlapActorsByProfile_OutActors_Offset;

	private static bool BoxOverlapActorsByProfile_ReturnValue_IsValid;

	private static FFieldAddress BoxOverlapActorsByProfile_ReturnValue_PropertyAddress;

	private static int BoxOverlapActorsByProfile_ReturnValue_Offset;

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_OverlapFuncLib:BoxOverlapComponentsByProfile")]
	public unsafe static bool BoxOverlapComponentsByProfile(UObject WorldContextObject, FVector BoxPos, FVector BoxExtent, FName ProfileName, TSubclassOf<UObject> ComponentClassFilter, List<AActor> ActorsToIgnore, out List<UPrimitiveComponent> OutComponents)
	{
		if (!BoxOverlapComponentsByProfile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_OverlapFuncLib:BoxOverlapComponentsByProfile");
			OutComponents = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BoxOverlapComponentsByProfile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BoxOverlapComponentsByProfile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BoxOverlapComponentsByProfile_WorldContextObject_Offset), 0, BoxOverlapComponentsByProfile_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BoxOverlapComponentsByProfile_BoxPos_Offset), 0, BoxOverlapComponentsByProfile_BoxPos_PropertyAddress.Address, BoxPos);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BoxOverlapComponentsByProfile_BoxExtent_Offset), 0, BoxOverlapComponentsByProfile_BoxExtent_PropertyAddress.Address, BoxExtent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BoxOverlapComponentsByProfile_ProfileName_Offset), 0, BoxOverlapComponentsByProfile_ProfileName_PropertyAddress.Address, ProfileName);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BoxOverlapComponentsByProfile_ComponentClassFilter_Offset), 0, BoxOverlapComponentsByProfile_ComponentClassFilter_PropertyAddress.Address, ComponentClassFilter);
		new TArrayCopyMarshaler<AActor>(1, BoxOverlapComponentsByProfile_ActorsToIgnore_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, BoxOverlapComponentsByProfile_ActorsToIgnore_Offset), ActorsToIgnore);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BoxOverlapComponentsByProfile_FunctionAddress, intPtr, BoxOverlapComponentsByProfile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BoxOverlapComponentsByProfile_ActorsToIgnore_PropertyAddress.Address, intPtr);
		OutComponents = new TArrayCopyMarshaler<UPrimitiveComponent>(1, BoxOverlapComponentsByProfile_OutComponents_PropertyAddress, CachedMarshalingDelegates<UPrimitiveComponent, UObjectMarshaler<UPrimitiveComponent>>.FromNative, CachedMarshalingDelegates<UPrimitiveComponent, UObjectMarshaler<UPrimitiveComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, BoxOverlapComponentsByProfile_OutComponents_Offset));
		NativeReflection.DestroyValue_InContainer(BoxOverlapComponentsByProfile_OutComponents_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BoxOverlapComponentsByProfile_ReturnValue_Offset), 0, BoxOverlapComponentsByProfile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_OverlapFuncLib:BoxOverlapActorsByProfile")]
	public unsafe static bool BoxOverlapActorsByProfile(UObject WorldContextObject, FVector BoxPos, FVector BoxExtent, FName ProfileName, TSubclassOf<UObject> ActorClassFilter, List<AActor> ActorsToIgnore, out List<AActor> OutActors)
	{
		if (!BoxOverlapActorsByProfile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_OverlapFuncLib:BoxOverlapActorsByProfile");
			OutActors = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BoxOverlapActorsByProfile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BoxOverlapActorsByProfile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BoxOverlapActorsByProfile_WorldContextObject_Offset), 0, BoxOverlapActorsByProfile_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BoxOverlapActorsByProfile_BoxPos_Offset), 0, BoxOverlapActorsByProfile_BoxPos_PropertyAddress.Address, BoxPos);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BoxOverlapActorsByProfile_BoxExtent_Offset), 0, BoxOverlapActorsByProfile_BoxExtent_PropertyAddress.Address, BoxExtent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BoxOverlapActorsByProfile_ProfileName_Offset), 0, BoxOverlapActorsByProfile_ProfileName_PropertyAddress.Address, ProfileName);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BoxOverlapActorsByProfile_ActorClassFilter_Offset), 0, BoxOverlapActorsByProfile_ActorClassFilter_PropertyAddress.Address, ActorClassFilter);
		new TArrayCopyMarshaler<AActor>(1, BoxOverlapActorsByProfile_ActorsToIgnore_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, BoxOverlapActorsByProfile_ActorsToIgnore_Offset), ActorsToIgnore);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BoxOverlapActorsByProfile_FunctionAddress, intPtr, BoxOverlapActorsByProfile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BoxOverlapActorsByProfile_ActorsToIgnore_PropertyAddress.Address, intPtr);
		OutActors = new TArrayCopyMarshaler<AActor>(1, BoxOverlapActorsByProfile_OutActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, BoxOverlapActorsByProfile_OutActors_Offset));
		NativeReflection.DestroyValue_InContainer(BoxOverlapActorsByProfile_OutActors_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BoxOverlapActorsByProfile_ReturnValue_Offset), 0, BoxOverlapActorsByProfile_ReturnValue_PropertyAddress.Address);
	}

	static UGSE_OverlapFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_OverlapFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_OverlapFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_OverlapFuncLib");
		BoxOverlapComponentsByProfile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BoxOverlapComponentsByProfile");
		BoxOverlapComponentsByProfile_ParamsSize = NativeReflection.GetFunctionParamsSize(BoxOverlapComponentsByProfile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapComponentsByProfile_WorldContextObject_PropertyAddress, BoxOverlapComponentsByProfile_FunctionAddress, "WorldContextObject");
		BoxOverlapComponentsByProfile_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapComponentsByProfile_FunctionAddress, "WorldContextObject");
		BoxOverlapComponentsByProfile_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapComponentsByProfile_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapComponentsByProfile_BoxPos_PropertyAddress, BoxOverlapComponentsByProfile_FunctionAddress, "BoxPos");
		BoxOverlapComponentsByProfile_BoxPos_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapComponentsByProfile_FunctionAddress, "BoxPos");
		BoxOverlapComponentsByProfile_BoxPos_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapComponentsByProfile_FunctionAddress, "BoxPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapComponentsByProfile_BoxExtent_PropertyAddress, BoxOverlapComponentsByProfile_FunctionAddress, "BoxExtent");
		BoxOverlapComponentsByProfile_BoxExtent_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapComponentsByProfile_FunctionAddress, "BoxExtent");
		BoxOverlapComponentsByProfile_BoxExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapComponentsByProfile_FunctionAddress, "BoxExtent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapComponentsByProfile_ProfileName_PropertyAddress, BoxOverlapComponentsByProfile_FunctionAddress, "ProfileName");
		BoxOverlapComponentsByProfile_ProfileName_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapComponentsByProfile_FunctionAddress, "ProfileName");
		BoxOverlapComponentsByProfile_ProfileName_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapComponentsByProfile_FunctionAddress, "ProfileName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapComponentsByProfile_ComponentClassFilter_PropertyAddress, BoxOverlapComponentsByProfile_FunctionAddress, "ComponentClassFilter");
		BoxOverlapComponentsByProfile_ComponentClassFilter_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapComponentsByProfile_FunctionAddress, "ComponentClassFilter");
		BoxOverlapComponentsByProfile_ComponentClassFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapComponentsByProfile_FunctionAddress, "ComponentClassFilter", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapComponentsByProfile_ActorsToIgnore_PropertyAddress, BoxOverlapComponentsByProfile_FunctionAddress, "ActorsToIgnore");
		BoxOverlapComponentsByProfile_ActorsToIgnore_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapComponentsByProfile_FunctionAddress, "ActorsToIgnore");
		BoxOverlapComponentsByProfile_ActorsToIgnore_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapComponentsByProfile_FunctionAddress, "ActorsToIgnore", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapComponentsByProfile_OutComponents_PropertyAddress, BoxOverlapComponentsByProfile_FunctionAddress, "OutComponents");
		BoxOverlapComponentsByProfile_OutComponents_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapComponentsByProfile_FunctionAddress, "OutComponents");
		BoxOverlapComponentsByProfile_OutComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapComponentsByProfile_FunctionAddress, "OutComponents", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapComponentsByProfile_ReturnValue_PropertyAddress, BoxOverlapComponentsByProfile_FunctionAddress, "ReturnValue");
		BoxOverlapComponentsByProfile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapComponentsByProfile_FunctionAddress, "ReturnValue");
		BoxOverlapComponentsByProfile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapComponentsByProfile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BoxOverlapComponentsByProfile_IsValid = BoxOverlapComponentsByProfile_FunctionAddress != IntPtr.Zero && BoxOverlapComponentsByProfile_WorldContextObject_IsValid && BoxOverlapComponentsByProfile_BoxPos_IsValid && BoxOverlapComponentsByProfile_BoxExtent_IsValid && BoxOverlapComponentsByProfile_ProfileName_IsValid && BoxOverlapComponentsByProfile_ComponentClassFilter_IsValid && BoxOverlapComponentsByProfile_ActorsToIgnore_IsValid && BoxOverlapComponentsByProfile_OutComponents_IsValid && BoxOverlapComponentsByProfile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_OverlapFuncLib:BoxOverlapComponentsByProfile", BoxOverlapComponentsByProfile_IsValid);
		BoxOverlapActorsByProfile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BoxOverlapActorsByProfile");
		BoxOverlapActorsByProfile_ParamsSize = NativeReflection.GetFunctionParamsSize(BoxOverlapActorsByProfile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapActorsByProfile_WorldContextObject_PropertyAddress, BoxOverlapActorsByProfile_FunctionAddress, "WorldContextObject");
		BoxOverlapActorsByProfile_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapActorsByProfile_FunctionAddress, "WorldContextObject");
		BoxOverlapActorsByProfile_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapActorsByProfile_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapActorsByProfile_BoxPos_PropertyAddress, BoxOverlapActorsByProfile_FunctionAddress, "BoxPos");
		BoxOverlapActorsByProfile_BoxPos_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapActorsByProfile_FunctionAddress, "BoxPos");
		BoxOverlapActorsByProfile_BoxPos_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapActorsByProfile_FunctionAddress, "BoxPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapActorsByProfile_BoxExtent_PropertyAddress, BoxOverlapActorsByProfile_FunctionAddress, "BoxExtent");
		BoxOverlapActorsByProfile_BoxExtent_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapActorsByProfile_FunctionAddress, "BoxExtent");
		BoxOverlapActorsByProfile_BoxExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapActorsByProfile_FunctionAddress, "BoxExtent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapActorsByProfile_ProfileName_PropertyAddress, BoxOverlapActorsByProfile_FunctionAddress, "ProfileName");
		BoxOverlapActorsByProfile_ProfileName_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapActorsByProfile_FunctionAddress, "ProfileName");
		BoxOverlapActorsByProfile_ProfileName_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapActorsByProfile_FunctionAddress, "ProfileName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapActorsByProfile_ActorClassFilter_PropertyAddress, BoxOverlapActorsByProfile_FunctionAddress, "ActorClassFilter");
		BoxOverlapActorsByProfile_ActorClassFilter_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapActorsByProfile_FunctionAddress, "ActorClassFilter");
		BoxOverlapActorsByProfile_ActorClassFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapActorsByProfile_FunctionAddress, "ActorClassFilter", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapActorsByProfile_ActorsToIgnore_PropertyAddress, BoxOverlapActorsByProfile_FunctionAddress, "ActorsToIgnore");
		BoxOverlapActorsByProfile_ActorsToIgnore_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapActorsByProfile_FunctionAddress, "ActorsToIgnore");
		BoxOverlapActorsByProfile_ActorsToIgnore_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapActorsByProfile_FunctionAddress, "ActorsToIgnore", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapActorsByProfile_OutActors_PropertyAddress, BoxOverlapActorsByProfile_FunctionAddress, "OutActors");
		BoxOverlapActorsByProfile_OutActors_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapActorsByProfile_FunctionAddress, "OutActors");
		BoxOverlapActorsByProfile_OutActors_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapActorsByProfile_FunctionAddress, "OutActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxOverlapActorsByProfile_ReturnValue_PropertyAddress, BoxOverlapActorsByProfile_FunctionAddress, "ReturnValue");
		BoxOverlapActorsByProfile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BoxOverlapActorsByProfile_FunctionAddress, "ReturnValue");
		BoxOverlapActorsByProfile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BoxOverlapActorsByProfile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BoxOverlapActorsByProfile_IsValid = BoxOverlapActorsByProfile_FunctionAddress != IntPtr.Zero && BoxOverlapActorsByProfile_WorldContextObject_IsValid && BoxOverlapActorsByProfile_BoxPos_IsValid && BoxOverlapActorsByProfile_BoxExtent_IsValid && BoxOverlapActorsByProfile_ProfileName_IsValid && BoxOverlapActorsByProfile_ActorClassFilter_IsValid && BoxOverlapActorsByProfile_ActorsToIgnore_IsValid && BoxOverlapActorsByProfile_OutActors_IsValid && BoxOverlapActorsByProfile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_OverlapFuncLib:BoxOverlapActorsByProfile", BoxOverlapActorsByProfile_IsValid);
	}
}
