using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGWMeshActor", "b1", UnrealModuleType.Game)]
public class ABGWMeshActor : AActor
{
	private static IntPtr classAddress;

	private static bool SyncComponentAndMobilityFromBP_IsValid;

	private static IntPtr SyncComponentAndMobilityFromBP_FunctionAddress;

	private static int SyncComponentAndMobilityFromBP_ParamsSize;

	private static bool SpawnFromBlueprintActor_IsValid;

	private static IntPtr SpawnFromBlueprintActor_FunctionAddress;

	private static int SpawnFromBlueprintActor_ParamsSize;

	private static bool SpawnFromBlueprintActor_InOriginBlueprint_IsValid;

	private static FFieldAddress SpawnFromBlueprintActor_InOriginBlueprint_PropertyAddress;

	private static int SpawnFromBlueprintActor_InOriginBlueprint_Offset;

	private static bool InitializeFromBlueprintActor_IsValid;

	private static IntPtr InitializeFromBlueprintActor_FunctionAddress;

	private static int InitializeFromBlueprintActor_ParamsSize;

	private static bool InitializeFromBlueprintActor_InOriginBlueprint_IsValid;

	private static FFieldAddress InitializeFromBlueprintActor_InOriginBlueprint_PropertyAddress;

	private static int InitializeFromBlueprintActor_InOriginBlueprint_Offset;

	private static bool ConvertToBlueprintActor_IsValid;

	private static IntPtr ConvertToBlueprintActor_FunctionAddress;

	private static int ConvertToBlueprintActor_ParamsSize;

	private static bool ConvertToBlueprintActor_ReturnValue_IsValid;

	private static FFieldAddress ConvertToBlueprintActor_ReturnValue_PropertyAddress;

	private static int ConvertToBlueprintActor_ReturnValue_Offset;

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/b1.BGWMeshActor:SyncComponentAndMobilityFromBP")]
	public unsafe void SyncComponentAndMobilityFromBP()
	{
		CheckDestroyed();
		if (!SyncComponentAndMobilityFromBP_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWMeshActor:SyncComponentAndMobilityFromBP");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SyncComponentAndMobilityFromBP_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SyncComponentAndMobilityFromBP_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SyncComponentAndMobilityFromBP_FunctionAddress, argsSize: SyncComponentAndMobilityFromBP_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/b1.BGWMeshActor:SpawnFromBlueprintActor")]
	public unsafe static void SpawnFromBlueprintActor(AActor InOriginBlueprint)
	{
		if (!SpawnFromBlueprintActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWMeshActor:SpawnFromBlueprintActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnFromBlueprintActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnFromBlueprintActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SpawnFromBlueprintActor_InOriginBlueprint_Offset), 0, SpawnFromBlueprintActor_InOriginBlueprint_PropertyAddress.Address, InOriginBlueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SpawnFromBlueprintActor_FunctionAddress, intPtr, SpawnFromBlueprintActor_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/b1.BGWMeshActor:InitializeFromBlueprintActor")]
	public unsafe void InitializeFromBlueprintActor(AActor InOriginBlueprint)
	{
		CheckDestroyed();
		if (!InitializeFromBlueprintActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWMeshActor:InitializeFromBlueprintActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitializeFromBlueprintActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitializeFromBlueprintActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, InitializeFromBlueprintActor_InOriginBlueprint_Offset), 0, InitializeFromBlueprintActor_InOriginBlueprint_PropertyAddress.Address, InOriginBlueprint);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitializeFromBlueprintActor_FunctionAddress, intPtr, InitializeFromBlueprintActor_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/b1.BGWMeshActor:ConvertToBlueprintActor")]
	public unsafe AActor ConvertToBlueprintActor()
	{
		CheckDestroyed();
		if (!ConvertToBlueprintActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWMeshActor:ConvertToBlueprintActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertToBlueprintActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertToBlueprintActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConvertToBlueprintActor_FunctionAddress, intPtr, ConvertToBlueprintActor_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, ConvertToBlueprintActor_ReturnValue_Offset), 0, ConvertToBlueprintActor_ReturnValue_PropertyAddress.Address);
	}

	static ABGWMeshActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGWMeshActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGWMeshActor));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGWMeshActor");
		SyncComponentAndMobilityFromBP_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SyncComponentAndMobilityFromBP");
		SyncComponentAndMobilityFromBP_ParamsSize = NativeReflection.GetFunctionParamsSize(SyncComponentAndMobilityFromBP_FunctionAddress);
		SyncComponentAndMobilityFromBP_IsValid = SyncComponentAndMobilityFromBP_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWMeshActor:SyncComponentAndMobilityFromBP", SyncComponentAndMobilityFromBP_IsValid);
		SpawnFromBlueprintActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SpawnFromBlueprintActor");
		SpawnFromBlueprintActor_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnFromBlueprintActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnFromBlueprintActor_InOriginBlueprint_PropertyAddress, SpawnFromBlueprintActor_FunctionAddress, "InOriginBlueprint");
		SpawnFromBlueprintActor_InOriginBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(SpawnFromBlueprintActor_FunctionAddress, "InOriginBlueprint");
		SpawnFromBlueprintActor_InOriginBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnFromBlueprintActor_FunctionAddress, "InOriginBlueprint", Classes.FObjectProperty);
		SpawnFromBlueprintActor_IsValid = SpawnFromBlueprintActor_FunctionAddress != IntPtr.Zero && SpawnFromBlueprintActor_InOriginBlueprint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWMeshActor:SpawnFromBlueprintActor", SpawnFromBlueprintActor_IsValid);
		InitializeFromBlueprintActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InitializeFromBlueprintActor");
		InitializeFromBlueprintActor_ParamsSize = NativeReflection.GetFunctionParamsSize(InitializeFromBlueprintActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitializeFromBlueprintActor_InOriginBlueprint_PropertyAddress, InitializeFromBlueprintActor_FunctionAddress, "InOriginBlueprint");
		InitializeFromBlueprintActor_InOriginBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(InitializeFromBlueprintActor_FunctionAddress, "InOriginBlueprint");
		InitializeFromBlueprintActor_InOriginBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeFromBlueprintActor_FunctionAddress, "InOriginBlueprint", Classes.FObjectProperty);
		InitializeFromBlueprintActor_IsValid = InitializeFromBlueprintActor_FunctionAddress != IntPtr.Zero && InitializeFromBlueprintActor_InOriginBlueprint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWMeshActor:InitializeFromBlueprintActor", InitializeFromBlueprintActor_IsValid);
		ConvertToBlueprintActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertToBlueprintActor");
		ConvertToBlueprintActor_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertToBlueprintActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertToBlueprintActor_ReturnValue_PropertyAddress, ConvertToBlueprintActor_FunctionAddress, "ReturnValue");
		ConvertToBlueprintActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertToBlueprintActor_FunctionAddress, "ReturnValue");
		ConvertToBlueprintActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertToBlueprintActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ConvertToBlueprintActor_IsValid = ConvertToBlueprintActor_FunctionAddress != IntPtr.Zero && ConvertToBlueprintActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWMeshActor:ConvertToBlueprintActor", ConvertToBlueprintActor_IsValid);
	}
}
