using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.ActorDataContainer", "b1", UnrealModuleType.Game)]
public class UActorDataContainer : UActorComponent
{
	private static bool PreECSBeginPlay_IsValid;

	private IntPtr PreECSBeginPlay_InstanceFunctionAddress;

	private static IntPtr PreECSBeginPlay_FunctionAddress;

	private static int PreECSBeginPlay_ParamsSize;

	private static bool OnDestoryInCS_IsValid;

	private IntPtr OnDestoryInCS_InstanceFunctionAddress;

	private static IntPtr OnDestoryInCS_FunctionAddress;

	private static int OnDestoryInCS_ParamsSize;

	private static bool LateECSBeginPlay_IsValid;

	private IntPtr LateECSBeginPlay_InstanceFunctionAddress;

	private static IntPtr LateECSBeginPlay_FunctionAddress;

	private static int LateECSBeginPlay_ParamsSize;

	private static bool InitOnNewInCS_IsValid;

	private IntPtr InitOnNewInCS_InstanceFunctionAddress;

	private static IntPtr InitOnNewInCS_FunctionAddress;

	private static int InitOnNewInCS_ParamsSize;

	private static bool ClearDataObj_IsValid;

	private static IntPtr ClearDataObj_FunctionAddress;

	private static int ClearDataObj_ParamsSize;

	private static bool AddDataObjInCS_IsValid;

	private static IntPtr AddDataObjInCS_FunctionAddress;

	private static int AddDataObjInCS_ParamsSize;

	private static bool AddDataObjInCS_Obj_IsValid;

	private static FFieldAddress AddDataObjInCS_Obj_PropertyAddress;

	private static int AddDataObjInCS_Obj_Offset;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.ActorDataContainer:PreECSBeginPlay")]
	public unsafe void PreECSBeginPlay()
	{
		CheckDestroyed();
		if (!PreECSBeginPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.ActorDataContainer:PreECSBeginPlay");
			return;
		}
		if (PreECSBeginPlay_InstanceFunctionAddress == IntPtr.Zero)
		{
			PreECSBeginPlay_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PreECSBeginPlay");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreECSBeginPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreECSBeginPlay_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PreECSBeginPlay_InstanceFunctionAddress, argsSize: PreECSBeginPlay_ParamsSize);
	}

	protected unsafe virtual void PreECSBeginPlay_Implementation()
	{
		CheckDestroyed();
		if (!PreECSBeginPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.ActorDataContainer:PreECSBeginPlay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreECSBeginPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreECSBeginPlay_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PreECSBeginPlay_FunctionAddress, argsSize: PreECSBeginPlay_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.ActorDataContainer:OnDestoryInCS")]
	protected unsafe void OnDestoryInCS()
	{
		CheckDestroyed();
		if (!OnDestoryInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.ActorDataContainer:OnDestoryInCS");
			return;
		}
		if (OnDestoryInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnDestoryInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnDestoryInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDestoryInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDestoryInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnDestoryInCS_InstanceFunctionAddress, argsSize: OnDestoryInCS_ParamsSize);
	}

	protected unsafe virtual void OnDestoryInCS_Implementation()
	{
		CheckDestroyed();
		if (!OnDestoryInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.ActorDataContainer:OnDestoryInCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnDestoryInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnDestoryInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnDestoryInCS_FunctionAddress, argsSize: OnDestoryInCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.ActorDataContainer:LateECSBeginPlay")]
	public unsafe void LateECSBeginPlay()
	{
		CheckDestroyed();
		if (!LateECSBeginPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.ActorDataContainer:LateECSBeginPlay");
			return;
		}
		if (LateECSBeginPlay_InstanceFunctionAddress == IntPtr.Zero)
		{
			LateECSBeginPlay_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "LateECSBeginPlay");
		}
		byte* ptr = stackalloc byte[(int)(uint)(LateECSBeginPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LateECSBeginPlay_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: LateECSBeginPlay_InstanceFunctionAddress, argsSize: LateECSBeginPlay_ParamsSize);
	}

	protected unsafe virtual void LateECSBeginPlay_Implementation()
	{
		CheckDestroyed();
		if (!LateECSBeginPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.ActorDataContainer:LateECSBeginPlay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LateECSBeginPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LateECSBeginPlay_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: LateECSBeginPlay_FunctionAddress, argsSize: LateECSBeginPlay_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.ActorDataContainer:InitOnNewInCS")]
	protected unsafe void InitOnNewInCS()
	{
		CheckDestroyed();
		if (!InitOnNewInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.ActorDataContainer:InitOnNewInCS");
			return;
		}
		if (InitOnNewInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			InitOnNewInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "InitOnNewInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitOnNewInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitOnNewInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitOnNewInCS_InstanceFunctionAddress, argsSize: InitOnNewInCS_ParamsSize);
	}

	protected unsafe virtual void InitOnNewInCS_Implementation()
	{
		CheckDestroyed();
		if (!InitOnNewInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.ActorDataContainer:InitOnNewInCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitOnNewInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitOnNewInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitOnNewInCS_FunctionAddress, argsSize: InitOnNewInCS_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.ActorDataContainer:ClearDataObj")]
	protected unsafe void ClearDataObj()
	{
		CheckDestroyed();
		if (!ClearDataObj_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.ActorDataContainer:ClearDataObj");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearDataObj_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearDataObj_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearDataObj_FunctionAddress, argsSize: ClearDataObj_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/b1.ActorDataContainer:AddDataObjInCS")]
	protected unsafe void AddDataObjInCS(UObject Obj)
	{
		CheckDestroyed();
		if (!AddDataObjInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.ActorDataContainer:AddDataObjInCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddDataObjInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddDataObjInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddDataObjInCS_Obj_Offset), 0, AddDataObjInCS_Obj_PropertyAddress.Address, Obj);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddDataObjInCS_FunctionAddress, intPtr, AddDataObjInCS_ParamsSize);
	}

	static UActorDataContainer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UActorDataContainer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UActorDataContainer));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.ActorDataContainer");
		PreECSBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PreECSBeginPlay");
		PreECSBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(PreECSBeginPlay_FunctionAddress);
		PreECSBeginPlay_IsValid = PreECSBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.ActorDataContainer:PreECSBeginPlay", PreECSBeginPlay_IsValid);
		OnDestoryInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnDestoryInCS");
		OnDestoryInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDestoryInCS_FunctionAddress);
		OnDestoryInCS_IsValid = OnDestoryInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.ActorDataContainer:OnDestoryInCS", OnDestoryInCS_IsValid);
		LateECSBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LateECSBeginPlay");
		LateECSBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(LateECSBeginPlay_FunctionAddress);
		LateECSBeginPlay_IsValid = LateECSBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.ActorDataContainer:LateECSBeginPlay", LateECSBeginPlay_IsValid);
		InitOnNewInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitOnNewInCS");
		InitOnNewInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(InitOnNewInCS_FunctionAddress);
		InitOnNewInCS_IsValid = InitOnNewInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.ActorDataContainer:InitOnNewInCS", InitOnNewInCS_IsValid);
		ClearDataObj_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClearDataObj");
		ClearDataObj_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearDataObj_FunctionAddress);
		ClearDataObj_IsValid = ClearDataObj_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.ActorDataContainer:ClearDataObj", ClearDataObj_IsValid);
		AddDataObjInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddDataObjInCS");
		AddDataObjInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(AddDataObjInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddDataObjInCS_Obj_PropertyAddress, AddDataObjInCS_FunctionAddress, "Obj");
		AddDataObjInCS_Obj_Offset = NativeReflectionCached.GetPropertyOffset(AddDataObjInCS_FunctionAddress, "Obj");
		AddDataObjInCS_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(AddDataObjInCS_FunctionAddress, "Obj", Classes.FObjectProperty);
		AddDataObjInCS_IsValid = AddDataObjInCS_FunctionAddress != IntPtr.Zero && AddDataObjInCS_Obj_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.ActorDataContainer:AddDataObjInCS", AddDataObjInCS_IsValid);
	}
}
