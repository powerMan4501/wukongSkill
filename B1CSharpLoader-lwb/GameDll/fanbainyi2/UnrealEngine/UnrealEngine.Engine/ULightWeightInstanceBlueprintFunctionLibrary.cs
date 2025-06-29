using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.LightWeightInstanceBlueprintFunctionLibrary", "Engine", UnrealModuleType.Engine)]
public class ULightWeightInstanceBlueprintFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool CreateNewLightWeightInstance_IsValid;

	private static IntPtr CreateNewLightWeightInstance_FunctionAddress;

	private static int CreateNewLightWeightInstance_ParamsSize;

	private static bool CreateNewLightWeightInstance_ActorClass_IsValid;

	private static FFieldAddress CreateNewLightWeightInstance_ActorClass_PropertyAddress;

	private static int CreateNewLightWeightInstance_ActorClass_Offset;

	private static bool CreateNewLightWeightInstance_Transform_IsValid;

	private static FFieldAddress CreateNewLightWeightInstance_Transform_PropertyAddress;

	private static int CreateNewLightWeightInstance_Transform_Offset;

	private static bool CreateNewLightWeightInstance_Layer_IsValid;

	private static FFieldAddress CreateNewLightWeightInstance_Layer_PropertyAddress;

	private static int CreateNewLightWeightInstance_Layer_Offset;

	private static bool CreateNewLightWeightInstance_World_IsValid;

	private static FFieldAddress CreateNewLightWeightInstance_World_PropertyAddress;

	private static int CreateNewLightWeightInstance_World_Offset;

	private static bool CreateNewLightWeightInstance_ReturnValue_IsValid;

	private static FFieldAddress CreateNewLightWeightInstance_ReturnValue_PropertyAddress;

	private static int CreateNewLightWeightInstance_ReturnValue_Offset;

	private static bool ConvertActorToLightWeightInstance_IsValid;

	private static IntPtr ConvertActorToLightWeightInstance_FunctionAddress;

	private static int ConvertActorToLightWeightInstance_ParamsSize;

	private static bool ConvertActorToLightWeightInstance_Actor_IsValid;

	private static FFieldAddress ConvertActorToLightWeightInstance_Actor_PropertyAddress;

	private static int ConvertActorToLightWeightInstance_Actor_Offset;

	private static bool ConvertActorToLightWeightInstance_ReturnValue_IsValid;

	private static FFieldAddress ConvertActorToLightWeightInstance_ReturnValue_PropertyAddress;

	private static int ConvertActorToLightWeightInstance_ReturnValue_Offset;

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/Engine.LightWeightInstanceBlueprintFunctionLibrary:CreateNewLightWeightInstance")]
	public unsafe static FActorInstanceHandle CreateNewLightWeightInstance(TSubclassOf<UObject> ActorClass, FTransform Transform, UDataLayer Layer, UWorld World)
	{
		if (!CreateNewLightWeightInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightWeightInstanceBlueprintFunctionLibrary:CreateNewLightWeightInstance");
			return default(FActorInstanceHandle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateNewLightWeightInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateNewLightWeightInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateNewLightWeightInstance_ActorClass_Offset), 0, CreateNewLightWeightInstance_ActorClass_PropertyAddress.Address, ActorClass);
		NativeReflection.InitializeValue_InContainer(CreateNewLightWeightInstance_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, CreateNewLightWeightInstance_Transform_Offset), 0, CreateNewLightWeightInstance_Transform_PropertyAddress.Address, Transform);
		UObjectMarshaler<UDataLayer>.ToNative(IntPtr.Add(intPtr, CreateNewLightWeightInstance_Layer_Offset), 0, CreateNewLightWeightInstance_Layer_PropertyAddress.Address, Layer);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, CreateNewLightWeightInstance_World_Offset), 0, CreateNewLightWeightInstance_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateNewLightWeightInstance_FunctionAddress, intPtr, CreateNewLightWeightInstance_ParamsSize);
		return FActorInstanceHandle.FromNative(IntPtr.Add(intPtr, CreateNewLightWeightInstance_ReturnValue_Offset), 0, CreateNewLightWeightInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.LightWeightInstanceBlueprintFunctionLibrary:ConvertActorToLightWeightInstance")]
	public unsafe static FActorInstanceHandle ConvertActorToLightWeightInstance(AActor Actor)
	{
		if (!ConvertActorToLightWeightInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightWeightInstanceBlueprintFunctionLibrary:ConvertActorToLightWeightInstance");
			return default(FActorInstanceHandle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertActorToLightWeightInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertActorToLightWeightInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ConvertActorToLightWeightInstance_Actor_Offset), 0, ConvertActorToLightWeightInstance_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertActorToLightWeightInstance_FunctionAddress, intPtr, ConvertActorToLightWeightInstance_ParamsSize);
		return FActorInstanceHandle.FromNative(IntPtr.Add(intPtr, ConvertActorToLightWeightInstance_ReturnValue_Offset), 0, ConvertActorToLightWeightInstance_ReturnValue_PropertyAddress.Address);
	}

	static ULightWeightInstanceBlueprintFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULightWeightInstanceBlueprintFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULightWeightInstanceBlueprintFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.LightWeightInstanceBlueprintFunctionLibrary");
		CreateNewLightWeightInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateNewLightWeightInstance");
		CreateNewLightWeightInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateNewLightWeightInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateNewLightWeightInstance_ActorClass_PropertyAddress, CreateNewLightWeightInstance_FunctionAddress, "ActorClass");
		CreateNewLightWeightInstance_ActorClass_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewLightWeightInstance_FunctionAddress, "ActorClass");
		CreateNewLightWeightInstance_ActorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewLightWeightInstance_FunctionAddress, "ActorClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewLightWeightInstance_Transform_PropertyAddress, CreateNewLightWeightInstance_FunctionAddress, "Transform");
		CreateNewLightWeightInstance_Transform_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewLightWeightInstance_FunctionAddress, "Transform");
		CreateNewLightWeightInstance_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewLightWeightInstance_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewLightWeightInstance_Layer_PropertyAddress, CreateNewLightWeightInstance_FunctionAddress, "Layer");
		CreateNewLightWeightInstance_Layer_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewLightWeightInstance_FunctionAddress, "Layer");
		CreateNewLightWeightInstance_Layer_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewLightWeightInstance_FunctionAddress, "Layer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewLightWeightInstance_World_PropertyAddress, CreateNewLightWeightInstance_FunctionAddress, "World");
		CreateNewLightWeightInstance_World_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewLightWeightInstance_FunctionAddress, "World");
		CreateNewLightWeightInstance_World_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewLightWeightInstance_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewLightWeightInstance_ReturnValue_PropertyAddress, CreateNewLightWeightInstance_FunctionAddress, "ReturnValue");
		CreateNewLightWeightInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewLightWeightInstance_FunctionAddress, "ReturnValue");
		CreateNewLightWeightInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewLightWeightInstance_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CreateNewLightWeightInstance_IsValid = CreateNewLightWeightInstance_FunctionAddress != IntPtr.Zero && CreateNewLightWeightInstance_ActorClass_IsValid && CreateNewLightWeightInstance_Transform_IsValid && CreateNewLightWeightInstance_Layer_IsValid && CreateNewLightWeightInstance_World_IsValid && CreateNewLightWeightInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightWeightInstanceBlueprintFunctionLibrary:CreateNewLightWeightInstance", CreateNewLightWeightInstance_IsValid);
		ConvertActorToLightWeightInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertActorToLightWeightInstance");
		ConvertActorToLightWeightInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertActorToLightWeightInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertActorToLightWeightInstance_Actor_PropertyAddress, ConvertActorToLightWeightInstance_FunctionAddress, "Actor");
		ConvertActorToLightWeightInstance_Actor_Offset = NativeReflectionCached.GetPropertyOffset(ConvertActorToLightWeightInstance_FunctionAddress, "Actor");
		ConvertActorToLightWeightInstance_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertActorToLightWeightInstance_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertActorToLightWeightInstance_ReturnValue_PropertyAddress, ConvertActorToLightWeightInstance_FunctionAddress, "ReturnValue");
		ConvertActorToLightWeightInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertActorToLightWeightInstance_FunctionAddress, "ReturnValue");
		ConvertActorToLightWeightInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertActorToLightWeightInstance_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ConvertActorToLightWeightInstance_IsValid = ConvertActorToLightWeightInstance_FunctionAddress != IntPtr.Zero && ConvertActorToLightWeightInstance_Actor_IsValid && ConvertActorToLightWeightInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightWeightInstanceBlueprintFunctionLibrary:ConvertActorToLightWeightInstance", ConvertActorToLightWeightInstance_IsValid);
	}
}
