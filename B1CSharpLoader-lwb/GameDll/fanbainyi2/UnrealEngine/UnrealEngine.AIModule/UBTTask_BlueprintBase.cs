using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AIModule.BTTask_BlueprintBase", "AIModule", UnrealModuleType.Engine)]
public class UBTTask_BlueprintBase : UBTTaskNode
{
	private static bool CustomDescription_IsValid;

	private static int CustomDescription_Offset;

	private static bool SetFinishOnMessageWithId_IsValid;

	private static IntPtr SetFinishOnMessageWithId_FunctionAddress;

	private static int SetFinishOnMessageWithId_ParamsSize;

	private static bool SetFinishOnMessageWithId_MessageName_IsValid;

	private static FFieldAddress SetFinishOnMessageWithId_MessageName_PropertyAddress;

	private static int SetFinishOnMessageWithId_MessageName_Offset;

	private static bool SetFinishOnMessageWithId_RequestID_IsValid;

	private static FFieldAddress SetFinishOnMessageWithId_RequestID_PropertyAddress;

	private static int SetFinishOnMessageWithId_RequestID_Offset;

	private static bool SetFinishOnMessage_IsValid;

	private static IntPtr SetFinishOnMessage_FunctionAddress;

	private static int SetFinishOnMessage_ParamsSize;

	private static bool SetFinishOnMessage_MessageName_IsValid;

	private static FFieldAddress SetFinishOnMessage_MessageName_PropertyAddress;

	private static int SetFinishOnMessage_MessageName_Offset;

	private static bool ReceiveTickAI_IsValid;

	private IntPtr ReceiveTickAI_InstanceFunctionAddress;

	private static IntPtr ReceiveTickAI_FunctionAddress;

	private static int ReceiveTickAI_ParamsSize;

	private static bool ReceiveTickAI_OwnerController_IsValid;

	private static FFieldAddress ReceiveTickAI_OwnerController_PropertyAddress;

	private static int ReceiveTickAI_OwnerController_Offset;

	private static bool ReceiveTickAI_ControlledPawn_IsValid;

	private static FFieldAddress ReceiveTickAI_ControlledPawn_PropertyAddress;

	private static int ReceiveTickAI_ControlledPawn_Offset;

	private static bool ReceiveTickAI_DeltaSeconds_IsValid;

	private static FFieldAddress ReceiveTickAI_DeltaSeconds_PropertyAddress;

	private static int ReceiveTickAI_DeltaSeconds_Offset;

	private static bool ReceiveTick_IsValid;

	private IntPtr ReceiveTick_InstanceFunctionAddress;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_OwnerActor_IsValid;

	private static FFieldAddress ReceiveTick_OwnerActor_PropertyAddress;

	private static int ReceiveTick_OwnerActor_Offset;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static FFieldAddress ReceiveTick_DeltaSeconds_PropertyAddress;

	private static int ReceiveTick_DeltaSeconds_Offset;

	private static bool ReceiveExecuteAI_IsValid;

	private IntPtr ReceiveExecuteAI_InstanceFunctionAddress;

	private static IntPtr ReceiveExecuteAI_FunctionAddress;

	private static int ReceiveExecuteAI_ParamsSize;

	private static bool ReceiveExecuteAI_OwnerController_IsValid;

	private static FFieldAddress ReceiveExecuteAI_OwnerController_PropertyAddress;

	private static int ReceiveExecuteAI_OwnerController_Offset;

	private static bool ReceiveExecuteAI_ControlledPawn_IsValid;

	private static FFieldAddress ReceiveExecuteAI_ControlledPawn_PropertyAddress;

	private static int ReceiveExecuteAI_ControlledPawn_Offset;

	private static bool ReceiveExecute_IsValid;

	private IntPtr ReceiveExecute_InstanceFunctionAddress;

	private static IntPtr ReceiveExecute_FunctionAddress;

	private static int ReceiveExecute_ParamsSize;

	private static bool ReceiveExecute_OwnerActor_IsValid;

	private static FFieldAddress ReceiveExecute_OwnerActor_PropertyAddress;

	private static int ReceiveExecute_OwnerActor_Offset;

	private static bool ReceiveAbortAI_IsValid;

	private IntPtr ReceiveAbortAI_InstanceFunctionAddress;

	private static IntPtr ReceiveAbortAI_FunctionAddress;

	private static int ReceiveAbortAI_ParamsSize;

	private static bool ReceiveAbortAI_OwnerController_IsValid;

	private static FFieldAddress ReceiveAbortAI_OwnerController_PropertyAddress;

	private static int ReceiveAbortAI_OwnerController_Offset;

	private static bool ReceiveAbortAI_ControlledPawn_IsValid;

	private static FFieldAddress ReceiveAbortAI_ControlledPawn_PropertyAddress;

	private static int ReceiveAbortAI_ControlledPawn_Offset;

	private static bool ReceiveAbort_IsValid;

	private IntPtr ReceiveAbort_InstanceFunctionAddress;

	private static IntPtr ReceiveAbort_FunctionAddress;

	private static int ReceiveAbort_ParamsSize;

	private static bool ReceiveAbort_OwnerActor_IsValid;

	private static FFieldAddress ReceiveAbort_OwnerActor_PropertyAddress;

	private static int ReceiveAbort_OwnerActor_Offset;

	private static bool IsTaskExecuting_IsValid;

	private static IntPtr IsTaskExecuting_FunctionAddress;

	private static int IsTaskExecuting_ParamsSize;

	private static bool IsTaskExecuting_ReturnValue_IsValid;

	private static FFieldAddress IsTaskExecuting_ReturnValue_PropertyAddress;

	private static int IsTaskExecuting_ReturnValue_Offset;

	private static bool IsTaskAborting_IsValid;

	private static IntPtr IsTaskAborting_FunctionAddress;

	private static int IsTaskAborting_ParamsSize;

	private static bool IsTaskAborting_ReturnValue_IsValid;

	private static FFieldAddress IsTaskAborting_ReturnValue_PropertyAddress;

	private static int IsTaskAborting_ReturnValue_Offset;

	private static bool FinishExecute_IsValid;

	private static IntPtr FinishExecute_FunctionAddress;

	private static int FinishExecute_ParamsSize;

	private static bool FinishExecute_bSuccess_IsValid;

	private static FFieldAddress FinishExecute_bSuccess_PropertyAddress;

	private static int FinishExecute_bSuccess_Offset;

	private static bool FinishAbort_IsValid;

	private static IntPtr FinishAbort_FunctionAddress;

	private static int FinishAbort_ParamsSize;

	[UProperty(Flags = (PropFlags)11267829521252869uL)]
	[UMetaPath("/Script/AIModule.BTTask_BlueprintBase:CustomDescription")]
	protected string CustomDescription
	{
		get
		{
			CheckDestroyed();
			if (!CustomDescription_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.BTTask_BlueprintBase:CustomDescription");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, CustomDescription_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomDescription_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.BTTask_BlueprintBase:CustomDescription");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, CustomDescription_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/AIModule.BTTask_BlueprintBase:SetFinishOnMessageWithId")]
	protected unsafe void SetFinishOnMessageWithId(FName MessageName, int RequestID = -1)
	{
		CheckDestroyed();
		if (!SetFinishOnMessageWithId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTTask_BlueprintBase:SetFinishOnMessageWithId");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFinishOnMessageWithId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFinishOnMessageWithId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetFinishOnMessageWithId_MessageName_Offset), 0, SetFinishOnMessageWithId_MessageName_PropertyAddress.Address, MessageName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetFinishOnMessageWithId_RequestID_Offset), 0, SetFinishOnMessageWithId_RequestID_PropertyAddress.Address, RequestID);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFinishOnMessageWithId_FunctionAddress, intPtr, SetFinishOnMessageWithId_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/AIModule.BTTask_BlueprintBase:SetFinishOnMessage")]
	protected unsafe void SetFinishOnMessage(FName MessageName)
	{
		CheckDestroyed();
		if (!SetFinishOnMessage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTTask_BlueprintBase:SetFinishOnMessage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFinishOnMessage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFinishOnMessage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetFinishOnMessage_MessageName_Offset), 0, SetFinishOnMessage_MessageName_PropertyAddress.Address, MessageName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFinishOnMessage_FunctionAddress, intPtr, SetFinishOnMessage_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTTask_BlueprintBase:ReceiveTickAI")]
	protected unsafe void ReceiveTickAI(AIController OwnerController, APawn ControlledPawn, float DeltaSeconds)
	{
		CheckDestroyed();
		if (!ReceiveTickAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTTask_BlueprintBase:ReceiveTickAI");
			return;
		}
		if (ReceiveTickAI_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveTickAI_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveTickAI");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveTickAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveTickAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveTickAI_OwnerController_Offset), 0, ReceiveTickAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveTickAI_ControlledPawn_Offset), 0, ReceiveTickAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceiveTickAI_DeltaSeconds_Offset), 0, ReceiveTickAI_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveTickAI_InstanceFunctionAddress, intPtr, ReceiveTickAI_ParamsSize);
	}

	protected unsafe virtual void ReceiveTickAI_Implementation(AIController OwnerController, APawn ControlledPawn, float DeltaSeconds)
	{
		CheckDestroyed();
		if (!ReceiveTickAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTTask_BlueprintBase:ReceiveTickAI");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveTickAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveTickAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveTickAI_OwnerController_Offset), 0, ReceiveTickAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveTickAI_ControlledPawn_Offset), 0, ReceiveTickAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceiveTickAI_DeltaSeconds_Offset), 0, ReceiveTickAI_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveTickAI_FunctionAddress, intPtr, ReceiveTickAI_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTTask_BlueprintBase:ReceiveTick")]
	protected unsafe void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
		CheckDestroyed();
		if (!ReceiveTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTTask_BlueprintBase:ReceiveTick");
			return;
		}
		if (ReceiveTick_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveTick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveTick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveTick_OwnerActor_Offset), 0, ReceiveTick_OwnerActor_PropertyAddress.Address, OwnerActor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceiveTick_DeltaSeconds_Offset), 0, ReceiveTick_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveTick_InstanceFunctionAddress, intPtr, ReceiveTick_ParamsSize);
	}

	protected unsafe virtual void ReceiveTick_Implementation(AActor OwnerActor, float DeltaSeconds)
	{
		CheckDestroyed();
		if (!ReceiveTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTTask_BlueprintBase:ReceiveTick");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveTick_OwnerActor_Offset), 0, ReceiveTick_OwnerActor_PropertyAddress.Address, OwnerActor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ReceiveTick_DeltaSeconds_Offset), 0, ReceiveTick_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveTick_FunctionAddress, intPtr, ReceiveTick_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTTask_BlueprintBase:ReceiveExecuteAI")]
	protected unsafe void ReceiveExecuteAI(AIController OwnerController, APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ReceiveExecuteAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTTask_BlueprintBase:ReceiveExecuteAI");
			return;
		}
		if (ReceiveExecuteAI_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveExecuteAI_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveExecuteAI");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveExecuteAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveExecuteAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveExecuteAI_OwnerController_Offset), 0, ReceiveExecuteAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveExecuteAI_ControlledPawn_Offset), 0, ReceiveExecuteAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveExecuteAI_InstanceFunctionAddress, intPtr, ReceiveExecuteAI_ParamsSize);
	}

	protected unsafe virtual void ReceiveExecuteAI_Implementation(AIController OwnerController, APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ReceiveExecuteAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTTask_BlueprintBase:ReceiveExecuteAI");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveExecuteAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveExecuteAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveExecuteAI_OwnerController_Offset), 0, ReceiveExecuteAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveExecuteAI_ControlledPawn_Offset), 0, ReceiveExecuteAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveExecuteAI_FunctionAddress, intPtr, ReceiveExecuteAI_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTTask_BlueprintBase:ReceiveExecute")]
	protected unsafe void ReceiveExecute(AActor OwnerActor)
	{
		CheckDestroyed();
		if (!ReceiveExecute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTTask_BlueprintBase:ReceiveExecute");
			return;
		}
		if (ReceiveExecute_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveExecute_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveExecute");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveExecute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveExecute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveExecute_OwnerActor_Offset), 0, ReceiveExecute_OwnerActor_PropertyAddress.Address, OwnerActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveExecute_InstanceFunctionAddress, intPtr, ReceiveExecute_ParamsSize);
	}

	protected unsafe virtual void ReceiveExecute_Implementation(AActor OwnerActor)
	{
		CheckDestroyed();
		if (!ReceiveExecute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTTask_BlueprintBase:ReceiveExecute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveExecute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveExecute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveExecute_OwnerActor_Offset), 0, ReceiveExecute_OwnerActor_PropertyAddress.Address, OwnerActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveExecute_FunctionAddress, intPtr, ReceiveExecute_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTTask_BlueprintBase:ReceiveAbortAI")]
	protected unsafe void ReceiveAbortAI(AIController OwnerController, APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ReceiveAbortAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTTask_BlueprintBase:ReceiveAbortAI");
			return;
		}
		if (ReceiveAbortAI_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveAbortAI_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveAbortAI");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveAbortAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveAbortAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveAbortAI_OwnerController_Offset), 0, ReceiveAbortAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveAbortAI_ControlledPawn_Offset), 0, ReceiveAbortAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveAbortAI_InstanceFunctionAddress, intPtr, ReceiveAbortAI_ParamsSize);
	}

	protected unsafe virtual void ReceiveAbortAI_Implementation(AIController OwnerController, APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ReceiveAbortAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTTask_BlueprintBase:ReceiveAbortAI");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveAbortAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveAbortAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveAbortAI_OwnerController_Offset), 0, ReceiveAbortAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveAbortAI_ControlledPawn_Offset), 0, ReceiveAbortAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveAbortAI_FunctionAddress, intPtr, ReceiveAbortAI_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTTask_BlueprintBase:ReceiveAbort")]
	protected unsafe void ReceiveAbort(AActor OwnerActor)
	{
		CheckDestroyed();
		if (!ReceiveAbort_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTTask_BlueprintBase:ReceiveAbort");
			return;
		}
		if (ReceiveAbort_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveAbort_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveAbort");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveAbort_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveAbort_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveAbort_OwnerActor_Offset), 0, ReceiveAbort_OwnerActor_PropertyAddress.Address, OwnerActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveAbort_InstanceFunctionAddress, intPtr, ReceiveAbort_ParamsSize);
	}

	protected unsafe virtual void ReceiveAbort_Implementation(AActor OwnerActor)
	{
		CheckDestroyed();
		if (!ReceiveAbort_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTTask_BlueprintBase:ReceiveAbort");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveAbort_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveAbort_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveAbort_OwnerActor_Offset), 0, ReceiveAbort_OwnerActor_PropertyAddress.Address, OwnerActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveAbort_FunctionAddress, intPtr, ReceiveAbort_ParamsSize);
	}

	[UFunction(Flags = 1409811457u)]
	[UMetaPath("/Script/AIModule.BTTask_BlueprintBase:IsTaskExecuting")]
	protected unsafe bool IsTaskExecuting()
	{
		CheckDestroyed();
		if (!IsTaskExecuting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTTask_BlueprintBase:IsTaskExecuting");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsTaskExecuting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsTaskExecuting_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsTaskExecuting_FunctionAddress, intPtr, IsTaskExecuting_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsTaskExecuting_ReturnValue_Offset), 0, IsTaskExecuting_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409811457u)]
	[UMetaPath("/Script/AIModule.BTTask_BlueprintBase:IsTaskAborting")]
	protected unsafe bool IsTaskAborting()
	{
		CheckDestroyed();
		if (!IsTaskAborting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTTask_BlueprintBase:IsTaskAborting");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsTaskAborting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsTaskAborting_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsTaskAborting_FunctionAddress, intPtr, IsTaskAborting_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsTaskAborting_ReturnValue_Offset), 0, IsTaskAborting_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/AIModule.BTTask_BlueprintBase:FinishExecute")]
	protected unsafe void FinishExecute(bool bSuccess)
	{
		CheckDestroyed();
		if (!FinishExecute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTTask_BlueprintBase:FinishExecute");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FinishExecute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FinishExecute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FinishExecute_bSuccess_Offset), 0, FinishExecute_bSuccess_PropertyAddress.Address, bSuccess);
		NativeReflection.InvokeFunctionOptimized(base.Address, FinishExecute_FunctionAddress, intPtr, FinishExecute_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/AIModule.BTTask_BlueprintBase:FinishAbort")]
	protected unsafe void FinishAbort()
	{
		CheckDestroyed();
		if (!FinishAbort_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTTask_BlueprintBase:FinishAbort");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FinishAbort_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FinishAbort_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: FinishAbort_FunctionAddress, argsSize: FinishAbort_ParamsSize);
	}

	static UBTTask_BlueprintBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBTTask_BlueprintBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBTTask_BlueprintBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AIModule.BTTask_BlueprintBase");
		CustomDescription_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomDescription");
		CustomDescription_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomDescription", Classes.FStrProperty);
		SetFinishOnMessageWithId_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFinishOnMessageWithId");
		SetFinishOnMessageWithId_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFinishOnMessageWithId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFinishOnMessageWithId_MessageName_PropertyAddress, SetFinishOnMessageWithId_FunctionAddress, "MessageName");
		SetFinishOnMessageWithId_MessageName_Offset = NativeReflectionCached.GetPropertyOffset(SetFinishOnMessageWithId_FunctionAddress, "MessageName");
		SetFinishOnMessageWithId_MessageName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFinishOnMessageWithId_FunctionAddress, "MessageName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFinishOnMessageWithId_RequestID_PropertyAddress, SetFinishOnMessageWithId_FunctionAddress, "RequestID");
		SetFinishOnMessageWithId_RequestID_Offset = NativeReflectionCached.GetPropertyOffset(SetFinishOnMessageWithId_FunctionAddress, "RequestID");
		SetFinishOnMessageWithId_RequestID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFinishOnMessageWithId_FunctionAddress, "RequestID", Classes.FIntProperty);
		SetFinishOnMessageWithId_IsValid = SetFinishOnMessageWithId_FunctionAddress != IntPtr.Zero && SetFinishOnMessageWithId_MessageName_IsValid && SetFinishOnMessageWithId_RequestID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTTask_BlueprintBase:SetFinishOnMessageWithId", SetFinishOnMessageWithId_IsValid);
		SetFinishOnMessage_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFinishOnMessage");
		SetFinishOnMessage_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFinishOnMessage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFinishOnMessage_MessageName_PropertyAddress, SetFinishOnMessage_FunctionAddress, "MessageName");
		SetFinishOnMessage_MessageName_Offset = NativeReflectionCached.GetPropertyOffset(SetFinishOnMessage_FunctionAddress, "MessageName");
		SetFinishOnMessage_MessageName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFinishOnMessage_FunctionAddress, "MessageName", Classes.FNameProperty);
		SetFinishOnMessage_IsValid = SetFinishOnMessage_FunctionAddress != IntPtr.Zero && SetFinishOnMessage_MessageName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTTask_BlueprintBase:SetFinishOnMessage", SetFinishOnMessage_IsValid);
		ReceiveTickAI_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTickAI");
		ReceiveTickAI_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTickAI_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveTickAI_OwnerController_PropertyAddress, ReceiveTickAI_FunctionAddress, "OwnerController");
		ReceiveTickAI_OwnerController_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveTickAI_FunctionAddress, "OwnerController");
		ReceiveTickAI_OwnerController_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveTickAI_FunctionAddress, "OwnerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveTickAI_ControlledPawn_PropertyAddress, ReceiveTickAI_FunctionAddress, "ControlledPawn");
		ReceiveTickAI_ControlledPawn_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveTickAI_FunctionAddress, "ControlledPawn");
		ReceiveTickAI_ControlledPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveTickAI_FunctionAddress, "ControlledPawn", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveTickAI_DeltaSeconds_PropertyAddress, ReceiveTickAI_FunctionAddress, "DeltaSeconds");
		ReceiveTickAI_DeltaSeconds_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveTickAI_FunctionAddress, "DeltaSeconds");
		ReceiveTickAI_DeltaSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveTickAI_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTickAI_IsValid = ReceiveTickAI_FunctionAddress != IntPtr.Zero && ReceiveTickAI_OwnerController_IsValid && ReceiveTickAI_ControlledPawn_IsValid && ReceiveTickAI_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTTask_BlueprintBase:ReceiveTickAI", ReceiveTickAI_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveTick_OwnerActor_PropertyAddress, ReceiveTick_FunctionAddress, "OwnerActor");
		ReceiveTick_OwnerActor_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveTick_FunctionAddress, "OwnerActor");
		ReceiveTick_OwnerActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveTick_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveTick_DeltaSeconds_PropertyAddress, ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_OwnerActor_IsValid && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTTask_BlueprintBase:ReceiveTick", ReceiveTick_IsValid);
		ReceiveExecuteAI_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveExecuteAI");
		ReceiveExecuteAI_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveExecuteAI_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveExecuteAI_OwnerController_PropertyAddress, ReceiveExecuteAI_FunctionAddress, "OwnerController");
		ReceiveExecuteAI_OwnerController_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveExecuteAI_FunctionAddress, "OwnerController");
		ReceiveExecuteAI_OwnerController_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveExecuteAI_FunctionAddress, "OwnerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveExecuteAI_ControlledPawn_PropertyAddress, ReceiveExecuteAI_FunctionAddress, "ControlledPawn");
		ReceiveExecuteAI_ControlledPawn_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveExecuteAI_FunctionAddress, "ControlledPawn");
		ReceiveExecuteAI_ControlledPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveExecuteAI_FunctionAddress, "ControlledPawn", Classes.FObjectProperty);
		ReceiveExecuteAI_IsValid = ReceiveExecuteAI_FunctionAddress != IntPtr.Zero && ReceiveExecuteAI_OwnerController_IsValid && ReceiveExecuteAI_ControlledPawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTTask_BlueprintBase:ReceiveExecuteAI", ReceiveExecuteAI_IsValid);
		ReceiveExecute_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveExecute");
		ReceiveExecute_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveExecute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveExecute_OwnerActor_PropertyAddress, ReceiveExecute_FunctionAddress, "OwnerActor");
		ReceiveExecute_OwnerActor_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveExecute_FunctionAddress, "OwnerActor");
		ReceiveExecute_OwnerActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveExecute_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		ReceiveExecute_IsValid = ReceiveExecute_FunctionAddress != IntPtr.Zero && ReceiveExecute_OwnerActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTTask_BlueprintBase:ReceiveExecute", ReceiveExecute_IsValid);
		ReceiveAbortAI_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveAbortAI");
		ReceiveAbortAI_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveAbortAI_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveAbortAI_OwnerController_PropertyAddress, ReceiveAbortAI_FunctionAddress, "OwnerController");
		ReceiveAbortAI_OwnerController_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveAbortAI_FunctionAddress, "OwnerController");
		ReceiveAbortAI_OwnerController_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveAbortAI_FunctionAddress, "OwnerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveAbortAI_ControlledPawn_PropertyAddress, ReceiveAbortAI_FunctionAddress, "ControlledPawn");
		ReceiveAbortAI_ControlledPawn_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveAbortAI_FunctionAddress, "ControlledPawn");
		ReceiveAbortAI_ControlledPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveAbortAI_FunctionAddress, "ControlledPawn", Classes.FObjectProperty);
		ReceiveAbortAI_IsValid = ReceiveAbortAI_FunctionAddress != IntPtr.Zero && ReceiveAbortAI_OwnerController_IsValid && ReceiveAbortAI_ControlledPawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTTask_BlueprintBase:ReceiveAbortAI", ReceiveAbortAI_IsValid);
		ReceiveAbort_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveAbort");
		ReceiveAbort_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveAbort_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveAbort_OwnerActor_PropertyAddress, ReceiveAbort_FunctionAddress, "OwnerActor");
		ReceiveAbort_OwnerActor_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveAbort_FunctionAddress, "OwnerActor");
		ReceiveAbort_OwnerActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveAbort_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		ReceiveAbort_IsValid = ReceiveAbort_FunctionAddress != IntPtr.Zero && ReceiveAbort_OwnerActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTTask_BlueprintBase:ReceiveAbort", ReceiveAbort_IsValid);
		IsTaskExecuting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsTaskExecuting");
		IsTaskExecuting_ParamsSize = NativeReflection.GetFunctionParamsSize(IsTaskExecuting_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsTaskExecuting_ReturnValue_PropertyAddress, IsTaskExecuting_FunctionAddress, "ReturnValue");
		IsTaskExecuting_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsTaskExecuting_FunctionAddress, "ReturnValue");
		IsTaskExecuting_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTaskExecuting_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsTaskExecuting_IsValid = IsTaskExecuting_FunctionAddress != IntPtr.Zero && IsTaskExecuting_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTTask_BlueprintBase:IsTaskExecuting", IsTaskExecuting_IsValid);
		IsTaskAborting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsTaskAborting");
		IsTaskAborting_ParamsSize = NativeReflection.GetFunctionParamsSize(IsTaskAborting_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsTaskAborting_ReturnValue_PropertyAddress, IsTaskAborting_FunctionAddress, "ReturnValue");
		IsTaskAborting_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsTaskAborting_FunctionAddress, "ReturnValue");
		IsTaskAborting_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTaskAborting_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsTaskAborting_IsValid = IsTaskAborting_FunctionAddress != IntPtr.Zero && IsTaskAborting_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTTask_BlueprintBase:IsTaskAborting", IsTaskAborting_IsValid);
		FinishExecute_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FinishExecute");
		FinishExecute_ParamsSize = NativeReflection.GetFunctionParamsSize(FinishExecute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FinishExecute_bSuccess_PropertyAddress, FinishExecute_FunctionAddress, "bSuccess");
		FinishExecute_bSuccess_Offset = NativeReflectionCached.GetPropertyOffset(FinishExecute_FunctionAddress, "bSuccess");
		FinishExecute_bSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(FinishExecute_FunctionAddress, "bSuccess", Classes.FBoolProperty);
		FinishExecute_IsValid = FinishExecute_FunctionAddress != IntPtr.Zero && FinishExecute_bSuccess_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTTask_BlueprintBase:FinishExecute", FinishExecute_IsValid);
		FinishAbort_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FinishAbort");
		FinishAbort_ParamsSize = NativeReflection.GetFunctionParamsSize(FinishAbort_FunctionAddress);
		FinishAbort_IsValid = FinishAbort_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTTask_BlueprintBase:FinishAbort", FinishAbort_IsValid);
	}
}
