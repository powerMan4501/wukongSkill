using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGURuntimeMeshActor")]
public class BGURuntimeMeshActor : AActor
{
	private static bool OnSliceRuntimeMesh_IsValid;

	private static IntPtr OnSliceRuntimeMesh_FunctionAddress;

	private static int OnSliceRuntimeMesh_ParamsSize;

	private static bool OnSliceRuntimeMesh_PlanePosition_IsValid;

	private static int OnSliceRuntimeMesh_PlanePosition_Offset;

	private static FFieldAddress OnSliceRuntimeMesh_PlanePosition_PropertyAddress;

	private static bool OnSliceRuntimeMesh_PlaneNormal_IsValid;

	private static int OnSliceRuntimeMesh_PlaneNormal_Offset;

	private static FFieldAddress OnSliceRuntimeMesh_PlaneNormal_PropertyAddress;

	private static bool OnSliceRuntimeMesh_ApplyForce_IsValid;

	private static int OnSliceRuntimeMesh_ApplyForce_Offset;

	private IntPtr OnSliceRuntimeMesh_InstanceFunctionAddressInstance;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	public override void Initialize()
	{
		base.Initialize();
	}

	[USharpPath("/Script/b1-Managed.BGURuntimeMeshActor:ReceiveBeginPlay")]
	protected sealed override void ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
		BGS_EventCollectionCS.Get(this)?.Evt_BGS_RegisterRuntimeMeshActor.Invoke(this);
	}

	[UFunction]
	[BlueprintImplementedEvent]
	[USharpPath("/Script/b1-Managed.BGURuntimeMeshActor:OnSliceRuntimeMesh")]
	public unsafe void OnSliceRuntimeMesh(FVector PlanePosition, FVector PlaneNormal, float ApplyForce)
	{
		CheckDestroyed();
		if (!OnSliceRuntimeMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGURuntimeMeshActor:OnSliceRuntimeMesh");
			return;
		}
		if (OnSliceRuntimeMesh_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			OnSliceRuntimeMesh_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "OnSliceRuntimeMesh");
		}
		byte* value = stackalloc byte[(int)(uint)OnSliceRuntimeMesh_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, OnSliceRuntimeMesh_ParamsSize);
		NativeReflection.InitializeValue_InContainer(OnSliceRuntimeMesh_PlanePosition_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnSliceRuntimeMesh_PlanePosition_Offset), PlanePosition);
		NativeReflection.InitializeValue_InContainer(OnSliceRuntimeMesh_PlaneNormal_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnSliceRuntimeMesh_PlaneNormal_Offset), PlaneNormal);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnSliceRuntimeMesh_ApplyForce_Offset), ApplyForce);
		NativeReflection.InvokeFunction(base.Address, OnSliceRuntimeMesh_InstanceFunctionAddressInstance, intPtr, OnSliceRuntimeMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnSliceRuntimeMesh_PlanePosition_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OnSliceRuntimeMesh_PlaneNormal_PropertyAddress.Address, intPtr);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGURuntimeMeshActor:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGURuntimeMeshActor bGURuntimeMeshActor = GCHelper.Find<BGURuntimeMeshActor>(obj);
		bGURuntimeMeshActor.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGURuntimeMeshActor");
		OnSliceRuntimeMesh_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnSliceRuntimeMesh");
		OnSliceRuntimeMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSliceRuntimeMesh_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnSliceRuntimeMesh_PlanePosition_PropertyAddress, OnSliceRuntimeMesh_FunctionAddress, "PlanePosition");
		OnSliceRuntimeMesh_PlanePosition_Offset = NativeReflection.GetPropertyOffset(OnSliceRuntimeMesh_FunctionAddress, "PlanePosition");
		OnSliceRuntimeMesh_PlanePosition_IsValid = NativeReflection.ValidatePropertyClass(OnSliceRuntimeMesh_FunctionAddress, "PlanePosition", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnSliceRuntimeMesh_PlaneNormal_PropertyAddress, OnSliceRuntimeMesh_FunctionAddress, "PlaneNormal");
		OnSliceRuntimeMesh_PlaneNormal_Offset = NativeReflection.GetPropertyOffset(OnSliceRuntimeMesh_FunctionAddress, "PlaneNormal");
		OnSliceRuntimeMesh_PlaneNormal_IsValid = NativeReflection.ValidatePropertyClass(OnSliceRuntimeMesh_FunctionAddress, "PlaneNormal", Classes.FStructProperty);
		OnSliceRuntimeMesh_ApplyForce_Offset = NativeReflection.GetPropertyOffset(OnSliceRuntimeMesh_FunctionAddress, "ApplyForce");
		OnSliceRuntimeMesh_ApplyForce_IsValid = NativeReflection.ValidatePropertyClass(OnSliceRuntimeMesh_FunctionAddress, "ApplyForce", Classes.FFloatProperty);
		OnSliceRuntimeMesh_IsValid = OnSliceRuntimeMesh_FunctionAddress != IntPtr.Zero && OnSliceRuntimeMesh_PlanePosition_IsValid && OnSliceRuntimeMesh_PlaneNormal_IsValid && OnSliceRuntimeMesh_ApplyForce_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGURuntimeMeshActor:OnSliceRuntimeMesh", OnSliceRuntimeMesh_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGURuntimeMeshActor:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}

	static BGURuntimeMeshActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGURuntimeMeshActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGURuntimeMeshActor));
	}
}
