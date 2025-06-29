using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.GenerateLandscapeVolume", "UnrealExtent", UnrealModuleType.Game)]
public class AGenerateLandscapeVolume : AVolume
{
	private static bool RefreshCollision_IsValid;

	private static IntPtr RefreshCollision_FunctionAddress;

	private static int RefreshCollision_ParamsSize;

	private static bool RecreateLayerInfo_IsValid;

	private static IntPtr RecreateLayerInfo_FunctionAddress;

	private static int RecreateLayerInfo_ParamsSize;

	private static bool RecomputePhysicalMaterial_IsValid;

	private static IntPtr RecomputePhysicalMaterial_FunctionAddress;

	private static int RecomputePhysicalMaterial_ParamsSize;

	private static bool RecomputeIKDiffViewOOT_IsValid;

	private static IntPtr RecomputeIKDiffViewOOT_FunctionAddress;

	private static int RecomputeIKDiffViewOOT_ParamsSize;

	private static bool RecomputeIKDiffView_IsValid;

	private static IntPtr RecomputeIKDiffView_FunctionAddress;

	private static int RecomputeIKDiffView_ParamsSize;

	private static bool RecomputeHeightMap_IsValid;

	private static IntPtr RecomputeHeightMap_FunctionAddress;

	private static int RecomputeHeightMap_ParamsSize;

	private static bool RecomputeCantLeapOrCrossArea_IsValid;

	private static IntPtr RecomputeCantLeapOrCrossArea_FunctionAddress;

	private static int RecomputeCantLeapOrCrossArea_ParamsSize;

	private static bool ModifyHeightLiftUp_IsValid;

	private static IntPtr ModifyHeightLiftUp_FunctionAddress;

	private static int ModifyHeightLiftUp_ParamsSize;

	private static bool ModifyHeightLiftUp_LiftUpDelta_IsValid;

	private static FFieldAddress ModifyHeightLiftUp_LiftUpDelta_PropertyAddress;

	private static int ModifyHeightLiftUp_LiftUpDelta_Offset;

	private static bool FixMeshCollision_IsValid;

	private static IntPtr FixMeshCollision_FunctionAddress;

	private static int FixMeshCollision_ParamsSize;

	private static bool FixAffectNavMeshSetting_IsValid;

	private static IntPtr FixAffectNavMeshSetting_FunctionAddress;

	private static int FixAffectNavMeshSetting_ParamsSize;

	private static bool CreateLandscapeWithWorld_IsValid;

	private static IntPtr CreateLandscapeWithWorld_FunctionAddress;

	private static int CreateLandscapeWithWorld_ParamsSize;

	private static bool CreateLandscapeWithWorld_World_IsValid;

	private static FFieldAddress CreateLandscapeWithWorld_World_PropertyAddress;

	private static int CreateLandscapeWithWorld_World_Offset;

	private static bool CreateLandscape_IsValid;

	private static IntPtr CreateLandscape_FunctionAddress;

	private static int CreateLandscape_ParamsSize;

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/UnrealExtent.GenerateLandscapeVolume:RefreshCollision")]
	public unsafe void RefreshCollision()
	{
		CheckDestroyed();
		if (!RefreshCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GenerateLandscapeVolume:RefreshCollision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshCollision_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RefreshCollision_FunctionAddress, argsSize: RefreshCollision_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/UnrealExtent.GenerateLandscapeVolume:RecreateLayerInfo")]
	public unsafe void RecreateLayerInfo()
	{
		CheckDestroyed();
		if (!RecreateLayerInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GenerateLandscapeVolume:RecreateLayerInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecreateLayerInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecreateLayerInfo_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RecreateLayerInfo_FunctionAddress, argsSize: RecreateLayerInfo_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/UnrealExtent.GenerateLandscapeVolume:RecomputePhysicalMaterial")]
	public unsafe void RecomputePhysicalMaterial()
	{
		CheckDestroyed();
		if (!RecomputePhysicalMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GenerateLandscapeVolume:RecomputePhysicalMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecomputePhysicalMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecomputePhysicalMaterial_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RecomputePhysicalMaterial_FunctionAddress, argsSize: RecomputePhysicalMaterial_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/UnrealExtent.GenerateLandscapeVolume:RecomputeIKDiffViewOOT")]
	public unsafe void RecomputeIKDiffViewOOT()
	{
		CheckDestroyed();
		if (!RecomputeIKDiffViewOOT_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GenerateLandscapeVolume:RecomputeIKDiffViewOOT");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecomputeIKDiffViewOOT_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecomputeIKDiffViewOOT_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RecomputeIKDiffViewOOT_FunctionAddress, argsSize: RecomputeIKDiffViewOOT_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/UnrealExtent.GenerateLandscapeVolume:RecomputeIKDiffView")]
	public unsafe void RecomputeIKDiffView()
	{
		CheckDestroyed();
		if (!RecomputeIKDiffView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GenerateLandscapeVolume:RecomputeIKDiffView");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecomputeIKDiffView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecomputeIKDiffView_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RecomputeIKDiffView_FunctionAddress, argsSize: RecomputeIKDiffView_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/UnrealExtent.GenerateLandscapeVolume:RecomputeHeightMap")]
	public unsafe void RecomputeHeightMap()
	{
		CheckDestroyed();
		if (!RecomputeHeightMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GenerateLandscapeVolume:RecomputeHeightMap");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecomputeHeightMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecomputeHeightMap_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RecomputeHeightMap_FunctionAddress, argsSize: RecomputeHeightMap_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/UnrealExtent.GenerateLandscapeVolume:RecomputeCantLeapOrCrossArea")]
	public unsafe void RecomputeCantLeapOrCrossArea()
	{
		CheckDestroyed();
		if (!RecomputeCantLeapOrCrossArea_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GenerateLandscapeVolume:RecomputeCantLeapOrCrossArea");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecomputeCantLeapOrCrossArea_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecomputeCantLeapOrCrossArea_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RecomputeCantLeapOrCrossArea_FunctionAddress, argsSize: RecomputeCantLeapOrCrossArea_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/UnrealExtent.GenerateLandscapeVolume:ModifyHeightLiftUp")]
	public unsafe void ModifyHeightLiftUp(float LiftUpDelta)
	{
		CheckDestroyed();
		if (!ModifyHeightLiftUp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GenerateLandscapeVolume:ModifyHeightLiftUp");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ModifyHeightLiftUp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ModifyHeightLiftUp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ModifyHeightLiftUp_LiftUpDelta_Offset), 0, ModifyHeightLiftUp_LiftUpDelta_PropertyAddress.Address, LiftUpDelta);
		NativeReflection.InvokeFunctionOptimized(base.Address, ModifyHeightLiftUp_FunctionAddress, intPtr, ModifyHeightLiftUp_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/UnrealExtent.GenerateLandscapeVolume:FixMeshCollision")]
	public unsafe void FixMeshCollision()
	{
		CheckDestroyed();
		if (!FixMeshCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GenerateLandscapeVolume:FixMeshCollision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FixMeshCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FixMeshCollision_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: FixMeshCollision_FunctionAddress, argsSize: FixMeshCollision_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/UnrealExtent.GenerateLandscapeVolume:FixAffectNavMeshSetting")]
	public unsafe void FixAffectNavMeshSetting()
	{
		CheckDestroyed();
		if (!FixAffectNavMeshSetting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GenerateLandscapeVolume:FixAffectNavMeshSetting");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FixAffectNavMeshSetting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FixAffectNavMeshSetting_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: FixAffectNavMeshSetting_FunctionAddress, argsSize: FixAffectNavMeshSetting_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/UnrealExtent.GenerateLandscapeVolume:CreateLandscapeWithWorld")]
	public unsafe void CreateLandscapeWithWorld(UWorld World)
	{
		CheckDestroyed();
		if (!CreateLandscapeWithWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GenerateLandscapeVolume:CreateLandscapeWithWorld");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateLandscapeWithWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateLandscapeWithWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, CreateLandscapeWithWorld_World_Offset), 0, CreateLandscapeWithWorld_World_PropertyAddress.Address, World);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateLandscapeWithWorld_FunctionAddress, intPtr, CreateLandscapeWithWorld_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/UnrealExtent.GenerateLandscapeVolume:CreateLandscape")]
	public unsafe void CreateLandscape()
	{
		CheckDestroyed();
		if (!CreateLandscape_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GenerateLandscapeVolume:CreateLandscape");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateLandscape_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateLandscape_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CreateLandscape_FunctionAddress, argsSize: CreateLandscape_ParamsSize);
	}

	static AGenerateLandscapeVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGenerateLandscapeVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGenerateLandscapeVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UnrealExtent.GenerateLandscapeVolume");
		RefreshCollision_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RefreshCollision");
		RefreshCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshCollision_FunctionAddress);
		RefreshCollision_IsValid = RefreshCollision_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GenerateLandscapeVolume:RefreshCollision", RefreshCollision_IsValid);
		RecreateLayerInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RecreateLayerInfo");
		RecreateLayerInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(RecreateLayerInfo_FunctionAddress);
		RecreateLayerInfo_IsValid = RecreateLayerInfo_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GenerateLandscapeVolume:RecreateLayerInfo", RecreateLayerInfo_IsValid);
		RecomputePhysicalMaterial_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RecomputePhysicalMaterial");
		RecomputePhysicalMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(RecomputePhysicalMaterial_FunctionAddress);
		RecomputePhysicalMaterial_IsValid = RecomputePhysicalMaterial_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GenerateLandscapeVolume:RecomputePhysicalMaterial", RecomputePhysicalMaterial_IsValid);
		RecomputeIKDiffViewOOT_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RecomputeIKDiffViewOOT");
		RecomputeIKDiffViewOOT_ParamsSize = NativeReflection.GetFunctionParamsSize(RecomputeIKDiffViewOOT_FunctionAddress);
		RecomputeIKDiffViewOOT_IsValid = RecomputeIKDiffViewOOT_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GenerateLandscapeVolume:RecomputeIKDiffViewOOT", RecomputeIKDiffViewOOT_IsValid);
		RecomputeIKDiffView_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RecomputeIKDiffView");
		RecomputeIKDiffView_ParamsSize = NativeReflection.GetFunctionParamsSize(RecomputeIKDiffView_FunctionAddress);
		RecomputeIKDiffView_IsValid = RecomputeIKDiffView_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GenerateLandscapeVolume:RecomputeIKDiffView", RecomputeIKDiffView_IsValid);
		RecomputeHeightMap_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RecomputeHeightMap");
		RecomputeHeightMap_ParamsSize = NativeReflection.GetFunctionParamsSize(RecomputeHeightMap_FunctionAddress);
		RecomputeHeightMap_IsValid = RecomputeHeightMap_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GenerateLandscapeVolume:RecomputeHeightMap", RecomputeHeightMap_IsValid);
		RecomputeCantLeapOrCrossArea_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RecomputeCantLeapOrCrossArea");
		RecomputeCantLeapOrCrossArea_ParamsSize = NativeReflection.GetFunctionParamsSize(RecomputeCantLeapOrCrossArea_FunctionAddress);
		RecomputeCantLeapOrCrossArea_IsValid = RecomputeCantLeapOrCrossArea_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GenerateLandscapeVolume:RecomputeCantLeapOrCrossArea", RecomputeCantLeapOrCrossArea_IsValid);
		ModifyHeightLiftUp_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ModifyHeightLiftUp");
		ModifyHeightLiftUp_ParamsSize = NativeReflection.GetFunctionParamsSize(ModifyHeightLiftUp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ModifyHeightLiftUp_LiftUpDelta_PropertyAddress, ModifyHeightLiftUp_FunctionAddress, "LiftUpDelta");
		ModifyHeightLiftUp_LiftUpDelta_Offset = NativeReflectionCached.GetPropertyOffset(ModifyHeightLiftUp_FunctionAddress, "LiftUpDelta");
		ModifyHeightLiftUp_LiftUpDelta_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyHeightLiftUp_FunctionAddress, "LiftUpDelta", Classes.FFloatProperty);
		ModifyHeightLiftUp_IsValid = ModifyHeightLiftUp_FunctionAddress != IntPtr.Zero && ModifyHeightLiftUp_LiftUpDelta_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GenerateLandscapeVolume:ModifyHeightLiftUp", ModifyHeightLiftUp_IsValid);
		FixMeshCollision_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FixMeshCollision");
		FixMeshCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(FixMeshCollision_FunctionAddress);
		FixMeshCollision_IsValid = FixMeshCollision_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GenerateLandscapeVolume:FixMeshCollision", FixMeshCollision_IsValid);
		FixAffectNavMeshSetting_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FixAffectNavMeshSetting");
		FixAffectNavMeshSetting_ParamsSize = NativeReflection.GetFunctionParamsSize(FixAffectNavMeshSetting_FunctionAddress);
		FixAffectNavMeshSetting_IsValid = FixAffectNavMeshSetting_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GenerateLandscapeVolume:FixAffectNavMeshSetting", FixAffectNavMeshSetting_IsValid);
		CreateLandscapeWithWorld_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateLandscapeWithWorld");
		CreateLandscapeWithWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateLandscapeWithWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateLandscapeWithWorld_World_PropertyAddress, CreateLandscapeWithWorld_FunctionAddress, "World");
		CreateLandscapeWithWorld_World_Offset = NativeReflectionCached.GetPropertyOffset(CreateLandscapeWithWorld_FunctionAddress, "World");
		CreateLandscapeWithWorld_World_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateLandscapeWithWorld_FunctionAddress, "World", Classes.FObjectProperty);
		CreateLandscapeWithWorld_IsValid = CreateLandscapeWithWorld_FunctionAddress != IntPtr.Zero && CreateLandscapeWithWorld_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GenerateLandscapeVolume:CreateLandscapeWithWorld", CreateLandscapeWithWorld_IsValid);
		CreateLandscape_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateLandscape");
		CreateLandscape_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateLandscape_FunctionAddress);
		CreateLandscape_IsValid = CreateLandscape_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GenerateLandscapeVolume:CreateLandscape", CreateLandscape_IsValid);
	}
}
