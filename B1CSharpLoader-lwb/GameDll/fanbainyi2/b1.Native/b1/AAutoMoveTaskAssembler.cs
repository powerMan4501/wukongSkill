using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.AutoMoveTaskAssembler", "UnrealExtent", UnrealModuleType.Game)]
public class AAutoMoveTaskAssembler : AAutoMovementMonitor
{
	private static bool Tasks_IsValid;

	private static FFieldAddress Tasks_PropertyAddress;

	private static int Tasks_Offset;

	private TArrayReadWriteMarshaler<AAutoMovementMonitor> Tasks_MarshalerCached;

	private static bool TaskID_IsValid;

	private static int TaskID_Offset;

	private static bool PointsTaskIdList_IsValid;

	private static FFieldAddress PointsTaskIdList_PropertyAddress;

	private static int PointsTaskIdList_Offset;

	private TArrayReadWriteMarshaler<int> PointsTaskIdList_MarshalerCached;

	private static bool UpdateProcessingState_IsValid;

	private static IntPtr UpdateProcessingState_FunctionAddress;

	private static int UpdateProcessingState_ParamsSize;

	private static bool TransportSubTaskViewingPosition_IsValid;

	private static IntPtr TransportSubTaskViewingPosition_FunctionAddress;

	private static int TransportSubTaskViewingPosition_ParamsSize;

	private static bool TransportSubTaskViewingPosition_InLocation_IsValid;

	private static FFieldAddress TransportSubTaskViewingPosition_InLocation_PropertyAddress;

	private static int TransportSubTaskViewingPosition_InLocation_Offset;

	private static bool TransportSubTaskViewingPosition_InRotator_IsValid;

	private static FFieldAddress TransportSubTaskViewingPosition_InRotator_PropertyAddress;

	private static int TransportSubTaskViewingPosition_InRotator_Offset;

	private static bool InitAutoMoveAssembler_IsValid;

	private IntPtr InitAutoMoveAssembler_InstanceFunctionAddress;

	private static IntPtr InitAutoMoveAssembler_FunctionAddress;

	private static int InitAutoMoveAssembler_ParamsSize;

	private static bool IncreaseSubTaskViewingRotation_IsValid;

	private static IntPtr IncreaseSubTaskViewingRotation_FunctionAddress;

	private static int IncreaseSubTaskViewingRotation_ParamsSize;

	private static bool IncreaseSubTaskViewingRotation_InRotateType_IsValid;

	private static FFieldAddress IncreaseSubTaskViewingRotation_InRotateType_PropertyAddress;

	private static int IncreaseSubTaskViewingRotation_InRotateType_Offset;

	[UProperty(Flags = (PropFlags)4503599627502085uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMoveTaskAssembler:Tasks")]
	public TArrayReadWrite<AAutoMovementMonitor> Tasks
	{
		get
		{
			CheckDestroyed();
			if (!Tasks_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMoveTaskAssembler:Tasks");
				return null;
			}
			if (Tasks_MarshalerCached == null)
			{
				Tasks_MarshalerCached = new TArrayReadWriteMarshaler<AAutoMovementMonitor>(1, Tasks_PropertyAddress, CachedMarshalingDelegates<AAutoMovementMonitor, UObjectMarshaler<AAutoMovementMonitor>>.FromNative, CachedMarshalingDelegates<AAutoMovementMonitor, UObjectMarshaler<AAutoMovementMonitor>>.ToNative);
			}
			return Tasks_MarshalerCached.FromNative(IntPtr.Add(base.Address, Tasks_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMoveTaskAssembler:TaskID")]
	public int TaskID
	{
		get
		{
			CheckDestroyed();
			if (!TaskID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMoveTaskAssembler:TaskID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TaskID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TaskID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMoveTaskAssembler:TaskID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TaskID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627502085uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMoveTaskAssembler:PointsTaskIdList")]
	public TArrayReadWrite<int> PointsTaskIdList
	{
		get
		{
			CheckDestroyed();
			if (!PointsTaskIdList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMoveTaskAssembler:PointsTaskIdList");
				return null;
			}
			if (PointsTaskIdList_MarshalerCached == null)
			{
				PointsTaskIdList_MarshalerCached = new TArrayReadWriteMarshaler<int>(1, PointsTaskIdList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return PointsTaskIdList_MarshalerCached.FromNative(IntPtr.Add(base.Address, PointsTaskIdList_Offset));
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.AutoMoveTaskAssembler:UpdateProcessingState")]
	public unsafe void UpdateProcessingState()
	{
		CheckDestroyed();
		if (!UpdateProcessingState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMoveTaskAssembler:UpdateProcessingState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateProcessingState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateProcessingState_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateProcessingState_FunctionAddress, argsSize: UpdateProcessingState_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UnrealExtent.AutoMoveTaskAssembler:TransportSubTaskViewingPosition")]
	public unsafe void TransportSubTaskViewingPosition(FVector InLocation, FRotator InRotator)
	{
		CheckDestroyed();
		if (!TransportSubTaskViewingPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMoveTaskAssembler:TransportSubTaskViewingPosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TransportSubTaskViewingPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TransportSubTaskViewingPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, TransportSubTaskViewingPosition_InLocation_Offset), 0, TransportSubTaskViewingPosition_InLocation_PropertyAddress.Address, InLocation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, TransportSubTaskViewingPosition_InRotator_Offset), 0, TransportSubTaskViewingPosition_InRotator_PropertyAddress.Address, InRotator);
		NativeReflection.InvokeFunctionOptimized(base.Address, TransportSubTaskViewingPosition_FunctionAddress, intPtr, TransportSubTaskViewingPosition_ParamsSize);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/UnrealExtent.AutoMoveTaskAssembler:InitAutoMoveAssembler")]
	public unsafe void InitAutoMoveAssembler()
	{
		CheckDestroyed();
		if (!InitAutoMoveAssembler_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMoveTaskAssembler:InitAutoMoveAssembler");
			return;
		}
		if (InitAutoMoveAssembler_InstanceFunctionAddress == IntPtr.Zero)
		{
			InitAutoMoveAssembler_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "InitAutoMoveAssembler");
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitAutoMoveAssembler_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitAutoMoveAssembler_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitAutoMoveAssembler_InstanceFunctionAddress, argsSize: InitAutoMoveAssembler_ParamsSize);
	}

	protected unsafe virtual void InitAutoMoveAssembler_Implementation()
	{
		CheckDestroyed();
		if (!InitAutoMoveAssembler_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMoveTaskAssembler:InitAutoMoveAssembler");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitAutoMoveAssembler_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitAutoMoveAssembler_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitAutoMoveAssembler_FunctionAddress, argsSize: InitAutoMoveAssembler_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.AutoMoveTaskAssembler:IncreaseSubTaskViewingRotation")]
	public unsafe void IncreaseSubTaskViewingRotation(ERotateType InRotateType)
	{
		CheckDestroyed();
		if (!IncreaseSubTaskViewingRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.AutoMoveTaskAssembler:IncreaseSubTaskViewingRotation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IncreaseSubTaskViewingRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IncreaseSubTaskViewingRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ERotateType>.ToNative(IntPtr.Add(intPtr, IncreaseSubTaskViewingRotation_InRotateType_Offset), 0, IncreaseSubTaskViewingRotation_InRotateType_PropertyAddress.Address, InRotateType);
		NativeReflection.InvokeFunctionOptimized(base.Address, IncreaseSubTaskViewingRotation_FunctionAddress, intPtr, IncreaseSubTaskViewingRotation_ParamsSize);
	}

	static AAutoMoveTaskAssembler()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AAutoMoveTaskAssembler)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AAutoMoveTaskAssembler));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UnrealExtent.AutoMoveTaskAssembler");
		NativeReflectionCached.GetPropertyRef(ref Tasks_PropertyAddress, intPtr, "Tasks");
		Tasks_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tasks");
		Tasks_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tasks", Classes.FArrayProperty);
		TaskID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TaskID");
		TaskID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TaskID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PointsTaskIdList_PropertyAddress, intPtr, "PointsTaskIdList");
		PointsTaskIdList_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PointsTaskIdList");
		PointsTaskIdList_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PointsTaskIdList", Classes.FArrayProperty);
		UpdateProcessingState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateProcessingState");
		UpdateProcessingState_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateProcessingState_FunctionAddress);
		UpdateProcessingState_IsValid = UpdateProcessingState_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMoveTaskAssembler:UpdateProcessingState", UpdateProcessingState_IsValid);
		TransportSubTaskViewingPosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TransportSubTaskViewingPosition");
		TransportSubTaskViewingPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(TransportSubTaskViewingPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TransportSubTaskViewingPosition_InLocation_PropertyAddress, TransportSubTaskViewingPosition_FunctionAddress, "InLocation");
		TransportSubTaskViewingPosition_InLocation_Offset = NativeReflectionCached.GetPropertyOffset(TransportSubTaskViewingPosition_FunctionAddress, "InLocation");
		TransportSubTaskViewingPosition_InLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(TransportSubTaskViewingPosition_FunctionAddress, "InLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TransportSubTaskViewingPosition_InRotator_PropertyAddress, TransportSubTaskViewingPosition_FunctionAddress, "InRotator");
		TransportSubTaskViewingPosition_InRotator_Offset = NativeReflectionCached.GetPropertyOffset(TransportSubTaskViewingPosition_FunctionAddress, "InRotator");
		TransportSubTaskViewingPosition_InRotator_IsValid = NativeReflectionCached.ValidatePropertyClass(TransportSubTaskViewingPosition_FunctionAddress, "InRotator", Classes.FStructProperty);
		TransportSubTaskViewingPosition_IsValid = TransportSubTaskViewingPosition_FunctionAddress != IntPtr.Zero && TransportSubTaskViewingPosition_InLocation_IsValid && TransportSubTaskViewingPosition_InRotator_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMoveTaskAssembler:TransportSubTaskViewingPosition", TransportSubTaskViewingPosition_IsValid);
		InitAutoMoveAssembler_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitAutoMoveAssembler");
		InitAutoMoveAssembler_ParamsSize = NativeReflection.GetFunctionParamsSize(InitAutoMoveAssembler_FunctionAddress);
		InitAutoMoveAssembler_IsValid = InitAutoMoveAssembler_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMoveTaskAssembler:InitAutoMoveAssembler", InitAutoMoveAssembler_IsValid);
		IncreaseSubTaskViewingRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IncreaseSubTaskViewingRotation");
		IncreaseSubTaskViewingRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(IncreaseSubTaskViewingRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IncreaseSubTaskViewingRotation_InRotateType_PropertyAddress, IncreaseSubTaskViewingRotation_FunctionAddress, "InRotateType");
		IncreaseSubTaskViewingRotation_InRotateType_Offset = NativeReflectionCached.GetPropertyOffset(IncreaseSubTaskViewingRotation_FunctionAddress, "InRotateType");
		IncreaseSubTaskViewingRotation_InRotateType_IsValid = NativeReflectionCached.ValidatePropertyClass(IncreaseSubTaskViewingRotation_FunctionAddress, "InRotateType", Classes.FEnumProperty);
		IncreaseSubTaskViewingRotation_IsValid = IncreaseSubTaskViewingRotation_FunctionAddress != IntPtr.Zero && IncreaseSubTaskViewingRotation_InRotateType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.AutoMoveTaskAssembler:IncreaseSubTaskViewingRotation", IncreaseSubTaskViewingRotation_IsValid);
	}
}
