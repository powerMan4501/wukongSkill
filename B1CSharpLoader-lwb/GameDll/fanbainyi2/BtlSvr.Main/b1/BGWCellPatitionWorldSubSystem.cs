using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWCellPatitionWorldSubSystem")]
public class BGWCellPatitionWorldSubSystem : UBGWTickableWorldSubSystem
{
	private static int sCellPartitionInstanceAlloc;

	private Dictionary<string, CellPartitionInstance> ActiveCellPartitionInstance = new Dictionary<string, CellPartitionInstance>();

	private static bool OnTickCS_IsValid;

	private static IntPtr OnTickCS_FunctionAddress;

	private static int OnTickCS_ParamsSize;

	private static bool OnTickCS_DeltaTime_IsValid;

	private static int OnTickCS_DeltaTime_Offset;

	private static bool PostInitializeCS_IsValid;

	private static IntPtr PostInitializeCS_FunctionAddress;

	private static int PostInitializeCS_ParamsSize;

	private static bool OnWorldBeginPlayCS_IsValid;

	private static IntPtr OnWorldBeginPlayCS_FunctionAddress;

	private static int OnWorldBeginPlayCS_ParamsSize;

	private static bool OnWorldBeginPlayCS_InWorld_IsValid;

	private static int OnWorldBeginPlayCS_InWorld_Offset;

	private static bool DoesSupportWorldTypeCS_IsValid;

	private static IntPtr DoesSupportWorldTypeCS_FunctionAddress;

	private static int DoesSupportWorldTypeCS_ParamsSize;

	private static bool DoesSupportWorldTypeCS_WorldType_IsValid;

	private static int DoesSupportWorldTypeCS_WorldType_Offset;

	private static bool DoesSupportWorldTypeCS_ReturnValue_IsValid;

	private static int DoesSupportWorldTypeCS_ReturnValue_Offset;

	private static FFieldAddress DoesSupportWorldTypeCS_ReturnValue_PropertyAddress;

	[USharpPath("/Script/b1-Managed.BGWCellPatitionWorldSubSystem:DoesSupportWorldTypeCS")]
	protected override bool DoesSupportWorldTypeCS_Implementation(int WorldType)
	{
		if (WorldType != 1)
		{
			return WorldType == 3;
		}
		return true;
	}

	public void RegisterLayer(string LayerName, FGSCellPatitionLayerConfig LayerCfg, CellPartitionLayerTag LayerTag, Action<CellPartitionActorInfo> OnActorLeave, Action<CellPartitionActorInfo> OnActorEnter)
	{
		ActiveCellPartitionInstance[LayerCfg.CellPartionInstanceName].RegisterLayer(LayerName, LayerCfg, LayerTag, OnActorLeave, OnActorEnter);
	}

	public void UnRegisterLayer(string InstanceName, string LayerName)
	{
		ActiveCellPartitionInstance[InstanceName].UnRegisterLayer(LayerName);
	}

	[USharpPath("/Script/b1-Managed.BGWCellPatitionWorldSubSystem:OnWorldBeginPlayCS")]
	protected override void OnWorldBeginPlayCS_Implementation(UWorld InWorld)
	{
		base.OnWorldBeginPlayCS_Implementation(InWorld);
	}

	[USharpPath("/Script/b1-Managed.BGWCellPatitionWorldSubSystem:PostInitializeCS")]
	protected override void PostInitializeCS_Implementation()
	{
		UWorld worldRefCS = GetWorldRefCS();
		foreach (KeyValuePair<string, FGSCellPatitionInsatnceConfig> item in (worldRefCS.GetWorldSettings() as BGW_WorldSettings).CellPatitionInsatnceConfig)
		{
			ActiveCellPartitionInstance.Add(item.Key, new CellPartitionInstance(worldRefCS, item.Key, sCellPartitionInstanceAlloc, (AActor Actor) => true, item.Value.WorldCellPatitionSize, item.Value.CellXCount, item.Value.CellYCount, item.Value.WorldCellPatitionBias, 9999, 10));
			sCellPartitionInstanceAlloc++;
		}
	}

	public void AddActor(AActor Actor)
	{
		foreach (KeyValuePair<string, CellPartitionInstance> item in ActiveCellPartitionInstance)
		{
			item.Value.AddActor(Actor);
		}
	}

	public void RemoveActor(AActor Actor)
	{
		foreach (KeyValuePair<string, CellPartitionInstance> item in ActiveCellPartitionInstance)
		{
			item.Value.RemoveActor(Actor);
		}
	}

	[USharpPath("/Script/b1-Managed.BGWCellPatitionWorldSubSystem:OnTickCS")]
	protected override void OnTickCS_Implementation(float DeltaTime)
	{
		base.OnTickCS_Implementation(DeltaTime);
		foreach (KeyValuePair<string, CellPartitionInstance> item in ActiveCellPartitionInstance)
		{
			item.Value.OnTick();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWCellPatitionWorldSubSystem:OnTickCS")]
	private static void OnTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWCellPatitionWorldSubSystem bGWCellPatitionWorldSubSystem = GCHelper.Find<BGWCellPatitionWorldSubSystem>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OnTickCS_DeltaTime_Offset));
		bGWCellPatitionWorldSubSystem.OnTickCS_Implementation(deltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWCellPatitionWorldSubSystem:PostInitializeCS")]
	private static void PostInitializeCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWCellPatitionWorldSubSystem bGWCellPatitionWorldSubSystem = GCHelper.Find<BGWCellPatitionWorldSubSystem>(obj);
		bGWCellPatitionWorldSubSystem.PostInitializeCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWCellPatitionWorldSubSystem:OnWorldBeginPlayCS")]
	private static void OnWorldBeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWCellPatitionWorldSubSystem bGWCellPatitionWorldSubSystem = GCHelper.Find<BGWCellPatitionWorldSubSystem>(obj);
		UWorld inWorld = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, OnWorldBeginPlayCS_InWorld_Offset));
		bGWCellPatitionWorldSubSystem.OnWorldBeginPlayCS_Implementation(inWorld);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWCellPatitionWorldSubSystem:DoesSupportWorldTypeCS")]
	private static void DoesSupportWorldTypeCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWCellPatitionWorldSubSystem bGWCellPatitionWorldSubSystem = GCHelper.Find<BGWCellPatitionWorldSubSystem>(obj);
		int worldType = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, DoesSupportWorldTypeCS_WorldType_Offset));
		bool value = bGWCellPatitionWorldSubSystem.DoesSupportWorldTypeCS_Implementation(worldType);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, DoesSupportWorldTypeCS_ReturnValue_Offset), 0, DoesSupportWorldTypeCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGWCellPatitionWorldSubSystem");
		OnTickCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnTickCS");
		OnTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTickCS_FunctionAddress);
		OnTickCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(OnTickCS_FunctionAddress, "DeltaTime");
		OnTickCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(OnTickCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		OnTickCS_IsValid = OnTickCS_FunctionAddress != IntPtr.Zero && OnTickCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWCellPatitionWorldSubSystem:OnTickCS", OnTickCS_IsValid);
		PostInitializeCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PostInitializeCS");
		PostInitializeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostInitializeCS_FunctionAddress);
		PostInitializeCS_IsValid = PostInitializeCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWCellPatitionWorldSubSystem:PostInitializeCS", PostInitializeCS_IsValid);
		OnWorldBeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnWorldBeginPlayCS");
		OnWorldBeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWorldBeginPlayCS_FunctionAddress);
		OnWorldBeginPlayCS_InWorld_Offset = NativeReflection.GetPropertyOffset(OnWorldBeginPlayCS_FunctionAddress, "InWorld");
		OnWorldBeginPlayCS_InWorld_IsValid = NativeReflection.ValidatePropertyClass(OnWorldBeginPlayCS_FunctionAddress, "InWorld", Classes.FObjectProperty);
		OnWorldBeginPlayCS_IsValid = OnWorldBeginPlayCS_FunctionAddress != IntPtr.Zero && OnWorldBeginPlayCS_InWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWCellPatitionWorldSubSystem:OnWorldBeginPlayCS", OnWorldBeginPlayCS_IsValid);
		DoesSupportWorldTypeCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DoesSupportWorldTypeCS");
		DoesSupportWorldTypeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(DoesSupportWorldTypeCS_FunctionAddress);
		DoesSupportWorldTypeCS_WorldType_Offset = NativeReflection.GetPropertyOffset(DoesSupportWorldTypeCS_FunctionAddress, "WorldType");
		DoesSupportWorldTypeCS_WorldType_IsValid = NativeReflection.ValidatePropertyClass(DoesSupportWorldTypeCS_FunctionAddress, "WorldType", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref DoesSupportWorldTypeCS_ReturnValue_PropertyAddress, DoesSupportWorldTypeCS_FunctionAddress, "ReturnValue");
		DoesSupportWorldTypeCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(DoesSupportWorldTypeCS_FunctionAddress, "ReturnValue");
		DoesSupportWorldTypeCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(DoesSupportWorldTypeCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DoesSupportWorldTypeCS_IsValid = DoesSupportWorldTypeCS_FunctionAddress != IntPtr.Zero && DoesSupportWorldTypeCS_WorldType_IsValid && DoesSupportWorldTypeCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWCellPatitionWorldSubSystem:DoesSupportWorldTypeCS", DoesSupportWorldTypeCS_IsValid);
	}

	static BGWCellPatitionWorldSubSystem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWCellPatitionWorldSubSystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWCellPatitionWorldSubSystem));
	}
}
