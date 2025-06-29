using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.LayerSceneInfo", "UnrealExtent", UnrealModuleType.Game)]
public class ALayerSceneInfo : AActor
{
	private static bool SaveToTextures_IsValid;

	private static IntPtr SaveToTextures_FunctionAddress;

	private static int SaveToTextures_ParamsSize;

	private static bool QueryWeightInfo_IsValid;

	private static IntPtr QueryWeightInfo_FunctionAddress;

	private static int QueryWeightInfo_ParamsSize;

	private static bool QueryWeightInfo_worldPos_IsValid;

	private static FFieldAddress QueryWeightInfo_worldPos_PropertyAddress;

	private static int QueryWeightInfo_worldPos_Offset;

	private static bool QueryWeightInfo_layerIndex_IsValid;

	private static FFieldAddress QueryWeightInfo_layerIndex_PropertyAddress;

	private static int QueryWeightInfo_layerIndex_Offset;

	private static bool QueryWeightInfo_Nearest_IsValid;

	private static FFieldAddress QueryWeightInfo_Nearest_PropertyAddress;

	private static int QueryWeightInfo_Nearest_Offset;

	private static bool QueryWeightInfo_value_IsValid;

	private static FFieldAddress QueryWeightInfo_value_PropertyAddress;

	private static int QueryWeightInfo_value_Offset;

	private static bool QueryWeightInfo_ReturnValue_IsValid;

	private static FFieldAddress QueryWeightInfo_ReturnValue_PropertyAddress;

	private static int QueryWeightInfo_ReturnValue_Offset;

	private static bool GenerateLayeredInfo_IsValid;

	private static IntPtr GenerateLayeredInfo_FunctionAddress;

	private static int GenerateLayeredInfo_ParamsSize;

	private static bool EnableDebugView_IsValid;

	private static IntPtr EnableDebugView_FunctionAddress;

	private static int EnableDebugView_ParamsSize;

	private static bool DebugSampleResult_IsValid;

	private static IntPtr DebugSampleResult_FunctionAddress;

	private static int DebugSampleResult_ParamsSize;

	private static bool BeginPlayCS_IsValid;

	private IntPtr BeginPlayCS_InstanceFunctionAddress;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/UnrealExtent.LayerSceneInfo:SaveToTextures")]
	public unsafe void SaveToTextures()
	{
		CheckDestroyed();
		if (!SaveToTextures_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LayerSceneInfo:SaveToTextures");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveToTextures_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveToTextures_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SaveToTextures_FunctionAddress, argsSize: SaveToTextures_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/UnrealExtent.LayerSceneInfo:QueryWeightInfo")]
	public unsafe bool QueryWeightInfo(FVector worldPos, int layerIndex, bool Nearest, out float value)
	{
		CheckDestroyed();
		if (!QueryWeightInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LayerSceneInfo:QueryWeightInfo");
			value = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QueryWeightInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QueryWeightInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, QueryWeightInfo_worldPos_Offset), 0, QueryWeightInfo_worldPos_PropertyAddress.Address, worldPos);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, QueryWeightInfo_layerIndex_Offset), 0, QueryWeightInfo_layerIndex_PropertyAddress.Address, layerIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, QueryWeightInfo_Nearest_Offset), 0, QueryWeightInfo_Nearest_PropertyAddress.Address, Nearest);
		NativeReflection.InvokeFunctionOptimized(base.Address, QueryWeightInfo_FunctionAddress, intPtr, QueryWeightInfo_ParamsSize);
		value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, QueryWeightInfo_value_Offset), 0, QueryWeightInfo_value_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, QueryWeightInfo_ReturnValue_Offset), 0, QueryWeightInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.LayerSceneInfo:GenerateLayeredInfo")]
	public unsafe void GenerateLayeredInfo()
	{
		CheckDestroyed();
		if (!GenerateLayeredInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LayerSceneInfo:GenerateLayeredInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateLayeredInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateLayeredInfo_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: GenerateLayeredInfo_FunctionAddress, argsSize: GenerateLayeredInfo_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/UnrealExtent.LayerSceneInfo:EnableDebugView")]
	public unsafe void EnableDebugView()
	{
		CheckDestroyed();
		if (!EnableDebugView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LayerSceneInfo:EnableDebugView");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableDebugView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableDebugView_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: EnableDebugView_FunctionAddress, argsSize: EnableDebugView_ParamsSize);
	}

	[UFunction(Flags = 604111873u)]
	[UMetaPath("/Script/UnrealExtent.LayerSceneInfo:DebugSampleResult")]
	public unsafe void DebugSampleResult()
	{
		CheckDestroyed();
		if (!DebugSampleResult_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LayerSceneInfo:DebugSampleResult");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DebugSampleResult_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DebugSampleResult_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: DebugSampleResult_FunctionAddress, argsSize: DebugSampleResult_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/UnrealExtent.LayerSceneInfo:BeginPlayCS")]
	public unsafe void BeginPlayCS()
	{
		CheckDestroyed();
		if (!BeginPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LayerSceneInfo:BeginPlayCS");
			return;
		}
		if (BeginPlayCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			BeginPlayCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BeginPlayCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginPlayCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BeginPlayCS_InstanceFunctionAddress, argsSize: BeginPlayCS_ParamsSize);
	}

	protected unsafe virtual void BeginPlayCS_Implementation()
	{
		CheckDestroyed();
		if (!BeginPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.LayerSceneInfo:BeginPlayCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginPlayCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BeginPlayCS_FunctionAddress, argsSize: BeginPlayCS_ParamsSize);
	}

	static ALayerSceneInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ALayerSceneInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ALayerSceneInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UnrealExtent.LayerSceneInfo");
		SaveToTextures_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SaveToTextures");
		SaveToTextures_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveToTextures_FunctionAddress);
		SaveToTextures_IsValid = SaveToTextures_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LayerSceneInfo:SaveToTextures", SaveToTextures_IsValid);
		QueryWeightInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QueryWeightInfo");
		QueryWeightInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(QueryWeightInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QueryWeightInfo_worldPos_PropertyAddress, QueryWeightInfo_FunctionAddress, "worldPos");
		QueryWeightInfo_worldPos_Offset = NativeReflectionCached.GetPropertyOffset(QueryWeightInfo_FunctionAddress, "worldPos");
		QueryWeightInfo_worldPos_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryWeightInfo_FunctionAddress, "worldPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref QueryWeightInfo_layerIndex_PropertyAddress, QueryWeightInfo_FunctionAddress, "layerIndex");
		QueryWeightInfo_layerIndex_Offset = NativeReflectionCached.GetPropertyOffset(QueryWeightInfo_FunctionAddress, "layerIndex");
		QueryWeightInfo_layerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryWeightInfo_FunctionAddress, "layerIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref QueryWeightInfo_Nearest_PropertyAddress, QueryWeightInfo_FunctionAddress, "Nearest");
		QueryWeightInfo_Nearest_Offset = NativeReflectionCached.GetPropertyOffset(QueryWeightInfo_FunctionAddress, "Nearest");
		QueryWeightInfo_Nearest_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryWeightInfo_FunctionAddress, "Nearest", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref QueryWeightInfo_value_PropertyAddress, QueryWeightInfo_FunctionAddress, "value");
		QueryWeightInfo_value_Offset = NativeReflectionCached.GetPropertyOffset(QueryWeightInfo_FunctionAddress, "value");
		QueryWeightInfo_value_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryWeightInfo_FunctionAddress, "value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref QueryWeightInfo_ReturnValue_PropertyAddress, QueryWeightInfo_FunctionAddress, "ReturnValue");
		QueryWeightInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(QueryWeightInfo_FunctionAddress, "ReturnValue");
		QueryWeightInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryWeightInfo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		QueryWeightInfo_IsValid = QueryWeightInfo_FunctionAddress != IntPtr.Zero && QueryWeightInfo_worldPos_IsValid && QueryWeightInfo_layerIndex_IsValid && QueryWeightInfo_Nearest_IsValid && QueryWeightInfo_value_IsValid && QueryWeightInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LayerSceneInfo:QueryWeightInfo", QueryWeightInfo_IsValid);
		GenerateLayeredInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GenerateLayeredInfo");
		GenerateLayeredInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateLayeredInfo_FunctionAddress);
		GenerateLayeredInfo_IsValid = GenerateLayeredInfo_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LayerSceneInfo:GenerateLayeredInfo", GenerateLayeredInfo_IsValid);
		EnableDebugView_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EnableDebugView");
		EnableDebugView_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableDebugView_FunctionAddress);
		EnableDebugView_IsValid = EnableDebugView_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LayerSceneInfo:EnableDebugView", EnableDebugView_IsValid);
		DebugSampleResult_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DebugSampleResult");
		DebugSampleResult_ParamsSize = NativeReflection.GetFunctionParamsSize(DebugSampleResult_FunctionAddress);
		DebugSampleResult_IsValid = DebugSampleResult_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LayerSceneInfo:DebugSampleResult", DebugSampleResult_IsValid);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.LayerSceneInfo:BeginPlayCS", BeginPlayCS_IsValid);
	}
}
