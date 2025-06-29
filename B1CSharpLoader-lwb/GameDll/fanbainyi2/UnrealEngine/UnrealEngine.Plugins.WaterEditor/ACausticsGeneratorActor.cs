using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.WaterEditor;

[UClass(Flags = (ClassFlags)817889444uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/WaterEditor.CausticsGeneratorActor", "WaterEditor", UnrealModuleType.EnginePlugin)]
public class ACausticsGeneratorActor : AActor
{
	private static bool DefaultSceneRoot_IsValid;

	private static int DefaultSceneRoot_Offset;

	private static bool SpawnWaterPreviewGrid_IsValid;

	private static IntPtr SpawnWaterPreviewGrid_FunctionAddress;

	private static int SpawnWaterPreviewGrid_ParamsSize;

	private static bool SpawnWaterPreviewGrid_HISMC_IsValid;

	private static FFieldAddress SpawnWaterPreviewGrid_HISMC_PropertyAddress;

	private static int SpawnWaterPreviewGrid_HISMC_Offset;

	private static bool SpawnWaterPreviewGrid_GridSize_IsValid;

	private static FFieldAddress SpawnWaterPreviewGrid_GridSize_PropertyAddress;

	private static int SpawnWaterPreviewGrid_GridSize_Offset;

	private static bool SpawnWaterPreviewGrid_GridTiles_IsValid;

	private static FFieldAddress SpawnWaterPreviewGrid_GridTiles_PropertyAddress;

	private static int SpawnWaterPreviewGrid_GridTiles_Offset;

	private static bool SpawnCausticParticleGrid_IsValid;

	private static IntPtr SpawnCausticParticleGrid_FunctionAddress;

	private static int SpawnCausticParticleGrid_ParamsSize;

	private static bool SpawnCausticParticleGrid_HISMC_IsValid;

	private static FFieldAddress SpawnCausticParticleGrid_HISMC_PropertyAddress;

	private static int SpawnCausticParticleGrid_HISMC_Offset;

	private static bool SpawnCausticParticleGrid_GridSize_IsValid;

	private static FFieldAddress SpawnCausticParticleGrid_GridSize_PropertyAddress;

	private static int SpawnCausticParticleGrid_GridSize_Offset;

	private static bool SpawnCausticParticleGrid_GridTiles_IsValid;

	private static FFieldAddress SpawnCausticParticleGrid_GridTiles_PropertyAddress;

	private static int SpawnCausticParticleGrid_GridTiles_Offset;

	private static bool SetEditorTickEnabled_IsValid;

	private static IntPtr SetEditorTickEnabled_FunctionAddress;

	private static int SetEditorTickEnabled_ParamsSize;

	private static bool SetEditorTickEnabled_bEnabled_IsValid;

	private static FFieldAddress SetEditorTickEnabled_bEnabled_PropertyAddress;

	private static int SetEditorTickEnabled_bEnabled_Offset;

	private static bool EditorTick_IsValid;

	private IntPtr EditorTick_InstanceFunctionAddress;

	private static IntPtr EditorTick_FunctionAddress;

	private static int EditorTick_ParamsSize;

	private static bool EditorTick_DeltaSeconds_IsValid;

	private static FFieldAddress EditorTick_DeltaSeconds_PropertyAddress;

	private static int EditorTick_DeltaSeconds_Offset;

	[UProperty(Flags = (PropFlags)6755486414668300uL)]
	[UMetaPath("/Script/WaterEditor.CausticsGeneratorActor:DefaultSceneRoot")]
	public USceneComponent DefaultSceneRoot
	{
		get
		{
			CheckDestroyed();
			if (!DefaultSceneRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.CausticsGeneratorActor:DefaultSceneRoot");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, DefaultSceneRoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultSceneRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.CausticsGeneratorActor:DefaultSceneRoot");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, DefaultSceneRoot_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/WaterEditor.CausticsGeneratorActor:SpawnWaterPreviewGrid")]
	public unsafe void SpawnWaterPreviewGrid(UHierarchicalInstancedStaticMeshComponent HISMC, float GridSize, int GridTiles)
	{
		CheckDestroyed();
		if (!SpawnWaterPreviewGrid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.CausticsGeneratorActor:SpawnWaterPreviewGrid");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnWaterPreviewGrid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnWaterPreviewGrid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UHierarchicalInstancedStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, SpawnWaterPreviewGrid_HISMC_Offset), 0, SpawnWaterPreviewGrid_HISMC_PropertyAddress.Address, HISMC);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SpawnWaterPreviewGrid_GridSize_Offset), 0, SpawnWaterPreviewGrid_GridSize_PropertyAddress.Address, GridSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SpawnWaterPreviewGrid_GridTiles_Offset), 0, SpawnWaterPreviewGrid_GridTiles_PropertyAddress.Address, GridTiles);
		NativeReflection.InvokeFunctionOptimized(base.Address, SpawnWaterPreviewGrid_FunctionAddress, intPtr, SpawnWaterPreviewGrid_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/WaterEditor.CausticsGeneratorActor:SpawnCausticParticleGrid")]
	public unsafe void SpawnCausticParticleGrid(UHierarchicalInstancedStaticMeshComponent HISMC, float GridSize, int GridTiles)
	{
		CheckDestroyed();
		if (!SpawnCausticParticleGrid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.CausticsGeneratorActor:SpawnCausticParticleGrid");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnCausticParticleGrid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnCausticParticleGrid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UHierarchicalInstancedStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, SpawnCausticParticleGrid_HISMC_Offset), 0, SpawnCausticParticleGrid_HISMC_PropertyAddress.Address, HISMC);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SpawnCausticParticleGrid_GridSize_Offset), 0, SpawnCausticParticleGrid_GridSize_PropertyAddress.Address, GridSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SpawnCausticParticleGrid_GridTiles_Offset), 0, SpawnCausticParticleGrid_GridTiles_PropertyAddress.Address, GridTiles);
		NativeReflection.InvokeFunctionOptimized(base.Address, SpawnCausticParticleGrid_FunctionAddress, intPtr, SpawnCausticParticleGrid_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/WaterEditor.CausticsGeneratorActor:SetEditorTickEnabled")]
	public unsafe void SetEditorTickEnabled(bool bEnabled)
	{
		CheckDestroyed();
		if (!SetEditorTickEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.CausticsGeneratorActor:SetEditorTickEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEditorTickEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEditorTickEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEditorTickEnabled_bEnabled_Offset), 0, SetEditorTickEnabled_bEnabled_PropertyAddress.Address, bEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEditorTickEnabled_FunctionAddress, intPtr, SetEditorTickEnabled_ParamsSize);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/WaterEditor.CausticsGeneratorActor:EditorTick")]
	public unsafe void EditorTick(float DeltaSeconds)
	{
		CheckDestroyed();
		if (!EditorTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.CausticsGeneratorActor:EditorTick");
			return;
		}
		if (EditorTick_InstanceFunctionAddress == IntPtr.Zero)
		{
			EditorTick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "EditorTick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditorTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditorTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, EditorTick_DeltaSeconds_Offset), 0, EditorTick_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, EditorTick_InstanceFunctionAddress, intPtr, EditorTick_ParamsSize);
	}

	protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
	{
		CheckDestroyed();
		if (!EditorTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/WaterEditor.CausticsGeneratorActor:EditorTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditorTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditorTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, EditorTick_DeltaSeconds_Offset), 0, EditorTick_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, EditorTick_FunctionAddress, intPtr, EditorTick_ParamsSize);
	}

	static ACausticsGeneratorActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACausticsGeneratorActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACausticsGeneratorActor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/WaterEditor.CausticsGeneratorActor");
		DefaultSceneRoot_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultSceneRoot");
		DefaultSceneRoot_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultSceneRoot", Classes.FObjectProperty);
		SpawnWaterPreviewGrid_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SpawnWaterPreviewGrid");
		SpawnWaterPreviewGrid_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnWaterPreviewGrid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnWaterPreviewGrid_HISMC_PropertyAddress, SpawnWaterPreviewGrid_FunctionAddress, "HISMC");
		SpawnWaterPreviewGrid_HISMC_Offset = NativeReflectionCached.GetPropertyOffset(SpawnWaterPreviewGrid_FunctionAddress, "HISMC");
		SpawnWaterPreviewGrid_HISMC_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnWaterPreviewGrid_FunctionAddress, "HISMC", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnWaterPreviewGrid_GridSize_PropertyAddress, SpawnWaterPreviewGrid_FunctionAddress, "GridSize");
		SpawnWaterPreviewGrid_GridSize_Offset = NativeReflectionCached.GetPropertyOffset(SpawnWaterPreviewGrid_FunctionAddress, "GridSize");
		SpawnWaterPreviewGrid_GridSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnWaterPreviewGrid_FunctionAddress, "GridSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnWaterPreviewGrid_GridTiles_PropertyAddress, SpawnWaterPreviewGrid_FunctionAddress, "GridTiles");
		SpawnWaterPreviewGrid_GridTiles_Offset = NativeReflectionCached.GetPropertyOffset(SpawnWaterPreviewGrid_FunctionAddress, "GridTiles");
		SpawnWaterPreviewGrid_GridTiles_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnWaterPreviewGrid_FunctionAddress, "GridTiles", Classes.FIntProperty);
		SpawnWaterPreviewGrid_IsValid = SpawnWaterPreviewGrid_FunctionAddress != IntPtr.Zero && SpawnWaterPreviewGrid_HISMC_IsValid && SpawnWaterPreviewGrid_GridSize_IsValid && SpawnWaterPreviewGrid_GridTiles_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.CausticsGeneratorActor:SpawnWaterPreviewGrid", SpawnWaterPreviewGrid_IsValid);
		SpawnCausticParticleGrid_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SpawnCausticParticleGrid");
		SpawnCausticParticleGrid_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnCausticParticleGrid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnCausticParticleGrid_HISMC_PropertyAddress, SpawnCausticParticleGrid_FunctionAddress, "HISMC");
		SpawnCausticParticleGrid_HISMC_Offset = NativeReflectionCached.GetPropertyOffset(SpawnCausticParticleGrid_FunctionAddress, "HISMC");
		SpawnCausticParticleGrid_HISMC_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnCausticParticleGrid_FunctionAddress, "HISMC", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnCausticParticleGrid_GridSize_PropertyAddress, SpawnCausticParticleGrid_FunctionAddress, "GridSize");
		SpawnCausticParticleGrid_GridSize_Offset = NativeReflectionCached.GetPropertyOffset(SpawnCausticParticleGrid_FunctionAddress, "GridSize");
		SpawnCausticParticleGrid_GridSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnCausticParticleGrid_FunctionAddress, "GridSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnCausticParticleGrid_GridTiles_PropertyAddress, SpawnCausticParticleGrid_FunctionAddress, "GridTiles");
		SpawnCausticParticleGrid_GridTiles_Offset = NativeReflectionCached.GetPropertyOffset(SpawnCausticParticleGrid_FunctionAddress, "GridTiles");
		SpawnCausticParticleGrid_GridTiles_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnCausticParticleGrid_FunctionAddress, "GridTiles", Classes.FIntProperty);
		SpawnCausticParticleGrid_IsValid = SpawnCausticParticleGrid_FunctionAddress != IntPtr.Zero && SpawnCausticParticleGrid_HISMC_IsValid && SpawnCausticParticleGrid_GridSize_IsValid && SpawnCausticParticleGrid_GridTiles_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.CausticsGeneratorActor:SpawnCausticParticleGrid", SpawnCausticParticleGrid_IsValid);
		SetEditorTickEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEditorTickEnabled");
		SetEditorTickEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEditorTickEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEditorTickEnabled_bEnabled_PropertyAddress, SetEditorTickEnabled_FunctionAddress, "bEnabled");
		SetEditorTickEnabled_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetEditorTickEnabled_FunctionAddress, "bEnabled");
		SetEditorTickEnabled_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEditorTickEnabled_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		SetEditorTickEnabled_IsValid = SetEditorTickEnabled_FunctionAddress != IntPtr.Zero && SetEditorTickEnabled_bEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.CausticsGeneratorActor:SetEditorTickEnabled", SetEditorTickEnabled_IsValid);
		EditorTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EditorTick");
		EditorTick_ParamsSize = NativeReflection.GetFunctionParamsSize(EditorTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EditorTick_DeltaSeconds_PropertyAddress, EditorTick_FunctionAddress, "DeltaSeconds");
		EditorTick_DeltaSeconds_Offset = NativeReflectionCached.GetPropertyOffset(EditorTick_FunctionAddress, "DeltaSeconds");
		EditorTick_DeltaSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		EditorTick_IsValid = EditorTick_FunctionAddress != IntPtr.Zero && EditorTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/WaterEditor.CausticsGeneratorActor:EditorTick", EditorTick_IsValid);
	}
}
