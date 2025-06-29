using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AIModule.BTDecorator_BlueprintBase", "AIModule", UnrealModuleType.Engine)]
public class UBTDecorator_BlueprintBase : UBTDecorator
{
	private static bool CustomDescription_IsValid;

	private static int CustomDescription_Offset;

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

	private static bool ReceiveObserverDeactivatedAI_IsValid;

	private IntPtr ReceiveObserverDeactivatedAI_InstanceFunctionAddress;

	private static IntPtr ReceiveObserverDeactivatedAI_FunctionAddress;

	private static int ReceiveObserverDeactivatedAI_ParamsSize;

	private static bool ReceiveObserverDeactivatedAI_OwnerController_IsValid;

	private static FFieldAddress ReceiveObserverDeactivatedAI_OwnerController_PropertyAddress;

	private static int ReceiveObserverDeactivatedAI_OwnerController_Offset;

	private static bool ReceiveObserverDeactivatedAI_ControlledPawn_IsValid;

	private static FFieldAddress ReceiveObserverDeactivatedAI_ControlledPawn_PropertyAddress;

	private static int ReceiveObserverDeactivatedAI_ControlledPawn_Offset;

	private static bool ReceiveObserverDeactivated_IsValid;

	private IntPtr ReceiveObserverDeactivated_InstanceFunctionAddress;

	private static IntPtr ReceiveObserverDeactivated_FunctionAddress;

	private static int ReceiveObserverDeactivated_ParamsSize;

	private static bool ReceiveObserverDeactivated_OwnerActor_IsValid;

	private static FFieldAddress ReceiveObserverDeactivated_OwnerActor_PropertyAddress;

	private static int ReceiveObserverDeactivated_OwnerActor_Offset;

	private static bool ReceiveObserverActivatedAI_IsValid;

	private IntPtr ReceiveObserverActivatedAI_InstanceFunctionAddress;

	private static IntPtr ReceiveObserverActivatedAI_FunctionAddress;

	private static int ReceiveObserverActivatedAI_ParamsSize;

	private static bool ReceiveObserverActivatedAI_OwnerController_IsValid;

	private static FFieldAddress ReceiveObserverActivatedAI_OwnerController_PropertyAddress;

	private static int ReceiveObserverActivatedAI_OwnerController_Offset;

	private static bool ReceiveObserverActivatedAI_ControlledPawn_IsValid;

	private static FFieldAddress ReceiveObserverActivatedAI_ControlledPawn_PropertyAddress;

	private static int ReceiveObserverActivatedAI_ControlledPawn_Offset;

	private static bool ReceiveObserverActivated_IsValid;

	private IntPtr ReceiveObserverActivated_InstanceFunctionAddress;

	private static IntPtr ReceiveObserverActivated_FunctionAddress;

	private static int ReceiveObserverActivated_ParamsSize;

	private static bool ReceiveObserverActivated_OwnerActor_IsValid;

	private static FFieldAddress ReceiveObserverActivated_OwnerActor_PropertyAddress;

	private static int ReceiveObserverActivated_OwnerActor_Offset;

	private static bool ReceiveExecutionStartAI_IsValid;

	private IntPtr ReceiveExecutionStartAI_InstanceFunctionAddress;

	private static IntPtr ReceiveExecutionStartAI_FunctionAddress;

	private static int ReceiveExecutionStartAI_ParamsSize;

	private static bool ReceiveExecutionStartAI_OwnerController_IsValid;

	private static FFieldAddress ReceiveExecutionStartAI_OwnerController_PropertyAddress;

	private static int ReceiveExecutionStartAI_OwnerController_Offset;

	private static bool ReceiveExecutionStartAI_ControlledPawn_IsValid;

	private static FFieldAddress ReceiveExecutionStartAI_ControlledPawn_PropertyAddress;

	private static int ReceiveExecutionStartAI_ControlledPawn_Offset;

	private static bool ReceiveExecutionStart_IsValid;

	private IntPtr ReceiveExecutionStart_InstanceFunctionAddress;

	private static IntPtr ReceiveExecutionStart_FunctionAddress;

	private static int ReceiveExecutionStart_ParamsSize;

	private static bool ReceiveExecutionStart_OwnerActor_IsValid;

	private static FFieldAddress ReceiveExecutionStart_OwnerActor_PropertyAddress;

	private static int ReceiveExecutionStart_OwnerActor_Offset;

	private static bool ReceiveExecutionFinishAI_IsValid;

	private IntPtr ReceiveExecutionFinishAI_InstanceFunctionAddress;

	private static IntPtr ReceiveExecutionFinishAI_FunctionAddress;

	private static int ReceiveExecutionFinishAI_ParamsSize;

	private static bool ReceiveExecutionFinishAI_OwnerController_IsValid;

	private static FFieldAddress ReceiveExecutionFinishAI_OwnerController_PropertyAddress;

	private static int ReceiveExecutionFinishAI_OwnerController_Offset;

	private static bool ReceiveExecutionFinishAI_ControlledPawn_IsValid;

	private static FFieldAddress ReceiveExecutionFinishAI_ControlledPawn_PropertyAddress;

	private static int ReceiveExecutionFinishAI_ControlledPawn_Offset;

	private static bool ReceiveExecutionFinishAI_NodeResult_IsValid;

	private static FFieldAddress ReceiveExecutionFinishAI_NodeResult_PropertyAddress;

	private static int ReceiveExecutionFinishAI_NodeResult_Offset;

	private static bool ReceiveExecutionFinish_IsValid;

	private IntPtr ReceiveExecutionFinish_InstanceFunctionAddress;

	private static IntPtr ReceiveExecutionFinish_FunctionAddress;

	private static int ReceiveExecutionFinish_ParamsSize;

	private static bool ReceiveExecutionFinish_OwnerActor_IsValid;

	private static FFieldAddress ReceiveExecutionFinish_OwnerActor_PropertyAddress;

	private static int ReceiveExecutionFinish_OwnerActor_Offset;

	private static bool ReceiveExecutionFinish_NodeResult_IsValid;

	private static FFieldAddress ReceiveExecutionFinish_NodeResult_PropertyAddress;

	private static int ReceiveExecutionFinish_NodeResult_Offset;

	private static bool PerformConditionCheckAI_IsValid;

	private IntPtr PerformConditionCheckAI_InstanceFunctionAddress;

	private static IntPtr PerformConditionCheckAI_FunctionAddress;

	private static int PerformConditionCheckAI_ParamsSize;

	private static bool PerformConditionCheckAI_OwnerController_IsValid;

	private static FFieldAddress PerformConditionCheckAI_OwnerController_PropertyAddress;

	private static int PerformConditionCheckAI_OwnerController_Offset;

	private static bool PerformConditionCheckAI_ControlledPawn_IsValid;

	private static FFieldAddress PerformConditionCheckAI_ControlledPawn_PropertyAddress;

	private static int PerformConditionCheckAI_ControlledPawn_Offset;

	private static bool PerformConditionCheckAI_ReturnValue_IsValid;

	private static FFieldAddress PerformConditionCheckAI_ReturnValue_PropertyAddress;

	private static int PerformConditionCheckAI_ReturnValue_Offset;

	private static bool PerformConditionCheck_IsValid;

	private IntPtr PerformConditionCheck_InstanceFunctionAddress;

	private static IntPtr PerformConditionCheck_FunctionAddress;

	private static int PerformConditionCheck_ParamsSize;

	private static bool PerformConditionCheck_OwnerActor_IsValid;

	private static FFieldAddress PerformConditionCheck_OwnerActor_PropertyAddress;

	private static int PerformConditionCheck_OwnerActor_Offset;

	private static bool PerformConditionCheck_ReturnValue_IsValid;

	private static FFieldAddress PerformConditionCheck_ReturnValue_PropertyAddress;

	private static int PerformConditionCheck_ReturnValue_Offset;

	private static bool IsDecoratorObserverActive_IsValid;

	private static IntPtr IsDecoratorObserverActive_FunctionAddress;

	private static int IsDecoratorObserverActive_ParamsSize;

	private static bool IsDecoratorObserverActive_ReturnValue_IsValid;

	private static FFieldAddress IsDecoratorObserverActive_ReturnValue_PropertyAddress;

	private static int IsDecoratorObserverActive_ReturnValue_Offset;

	private static bool IsDecoratorExecutionActive_IsValid;

	private static IntPtr IsDecoratorExecutionActive_FunctionAddress;

	private static int IsDecoratorExecutionActive_ParamsSize;

	private static bool IsDecoratorExecutionActive_ReturnValue_IsValid;

	private static FFieldAddress IsDecoratorExecutionActive_ReturnValue_PropertyAddress;

	private static int IsDecoratorExecutionActive_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267829521252869uL)]
	[UMetaPath("/Script/AIModule.BTDecorator_BlueprintBase:CustomDescription")]
	protected string CustomDescription
	{
		get
		{
			CheckDestroyed();
			if (!CustomDescription_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.BTDecorator_BlueprintBase:CustomDescription");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, CustomDescription_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomDescription_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.BTDecorator_BlueprintBase:CustomDescription");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, CustomDescription_Offset), value);
			}
		}
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveTickAI")]
	protected unsafe void ReceiveTickAI(AIController OwnerController, APawn ControlledPawn, float DeltaSeconds)
	{
		CheckDestroyed();
		if (!ReceiveTickAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveTickAI");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveTickAI");
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
	[UMetaPath("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveTick")]
	protected unsafe void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
		CheckDestroyed();
		if (!ReceiveTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveTick");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveTick");
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
	[UMetaPath("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveObserverDeactivatedAI")]
	protected unsafe void ReceiveObserverDeactivatedAI(AIController OwnerController, APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ReceiveObserverDeactivatedAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveObserverDeactivatedAI");
			return;
		}
		if (ReceiveObserverDeactivatedAI_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveObserverDeactivatedAI_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveObserverDeactivatedAI");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveObserverDeactivatedAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveObserverDeactivatedAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveObserverDeactivatedAI_OwnerController_Offset), 0, ReceiveObserverDeactivatedAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveObserverDeactivatedAI_ControlledPawn_Offset), 0, ReceiveObserverDeactivatedAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveObserverDeactivatedAI_InstanceFunctionAddress, intPtr, ReceiveObserverDeactivatedAI_ParamsSize);
	}

	protected unsafe virtual void ReceiveObserverDeactivatedAI_Implementation(AIController OwnerController, APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ReceiveObserverDeactivatedAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveObserverDeactivatedAI");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveObserverDeactivatedAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveObserverDeactivatedAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveObserverDeactivatedAI_OwnerController_Offset), 0, ReceiveObserverDeactivatedAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveObserverDeactivatedAI_ControlledPawn_Offset), 0, ReceiveObserverDeactivatedAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveObserverDeactivatedAI_FunctionAddress, intPtr, ReceiveObserverDeactivatedAI_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveObserverDeactivated")]
	protected unsafe void ReceiveObserverDeactivated(AActor OwnerActor)
	{
		CheckDestroyed();
		if (!ReceiveObserverDeactivated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveObserverDeactivated");
			return;
		}
		if (ReceiveObserverDeactivated_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveObserverDeactivated_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveObserverDeactivated");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveObserverDeactivated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveObserverDeactivated_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveObserverDeactivated_OwnerActor_Offset), 0, ReceiveObserverDeactivated_OwnerActor_PropertyAddress.Address, OwnerActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveObserverDeactivated_InstanceFunctionAddress, intPtr, ReceiveObserverDeactivated_ParamsSize);
	}

	protected unsafe virtual void ReceiveObserverDeactivated_Implementation(AActor OwnerActor)
	{
		CheckDestroyed();
		if (!ReceiveObserverDeactivated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveObserverDeactivated");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveObserverDeactivated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveObserverDeactivated_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveObserverDeactivated_OwnerActor_Offset), 0, ReceiveObserverDeactivated_OwnerActor_PropertyAddress.Address, OwnerActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveObserverDeactivated_FunctionAddress, intPtr, ReceiveObserverDeactivated_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveObserverActivatedAI")]
	protected unsafe void ReceiveObserverActivatedAI(AIController OwnerController, APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ReceiveObserverActivatedAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveObserverActivatedAI");
			return;
		}
		if (ReceiveObserverActivatedAI_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveObserverActivatedAI_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveObserverActivatedAI");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveObserverActivatedAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveObserverActivatedAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveObserverActivatedAI_OwnerController_Offset), 0, ReceiveObserverActivatedAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveObserverActivatedAI_ControlledPawn_Offset), 0, ReceiveObserverActivatedAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveObserverActivatedAI_InstanceFunctionAddress, intPtr, ReceiveObserverActivatedAI_ParamsSize);
	}

	protected unsafe virtual void ReceiveObserverActivatedAI_Implementation(AIController OwnerController, APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ReceiveObserverActivatedAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveObserverActivatedAI");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveObserverActivatedAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveObserverActivatedAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveObserverActivatedAI_OwnerController_Offset), 0, ReceiveObserverActivatedAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveObserverActivatedAI_ControlledPawn_Offset), 0, ReceiveObserverActivatedAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveObserverActivatedAI_FunctionAddress, intPtr, ReceiveObserverActivatedAI_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveObserverActivated")]
	protected unsafe void ReceiveObserverActivated(AActor OwnerActor)
	{
		CheckDestroyed();
		if (!ReceiveObserverActivated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveObserverActivated");
			return;
		}
		if (ReceiveObserverActivated_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveObserverActivated_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveObserverActivated");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveObserverActivated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveObserverActivated_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveObserverActivated_OwnerActor_Offset), 0, ReceiveObserverActivated_OwnerActor_PropertyAddress.Address, OwnerActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveObserverActivated_InstanceFunctionAddress, intPtr, ReceiveObserverActivated_ParamsSize);
	}

	protected unsafe virtual void ReceiveObserverActivated_Implementation(AActor OwnerActor)
	{
		CheckDestroyed();
		if (!ReceiveObserverActivated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveObserverActivated");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveObserverActivated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveObserverActivated_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveObserverActivated_OwnerActor_Offset), 0, ReceiveObserverActivated_OwnerActor_PropertyAddress.Address, OwnerActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveObserverActivated_FunctionAddress, intPtr, ReceiveObserverActivated_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveExecutionStartAI")]
	protected unsafe void ReceiveExecutionStartAI(AIController OwnerController, APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ReceiveExecutionStartAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveExecutionStartAI");
			return;
		}
		if (ReceiveExecutionStartAI_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveExecutionStartAI_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveExecutionStartAI");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveExecutionStartAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveExecutionStartAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveExecutionStartAI_OwnerController_Offset), 0, ReceiveExecutionStartAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveExecutionStartAI_ControlledPawn_Offset), 0, ReceiveExecutionStartAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveExecutionStartAI_InstanceFunctionAddress, intPtr, ReceiveExecutionStartAI_ParamsSize);
	}

	protected unsafe virtual void ReceiveExecutionStartAI_Implementation(AIController OwnerController, APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ReceiveExecutionStartAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveExecutionStartAI");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveExecutionStartAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveExecutionStartAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveExecutionStartAI_OwnerController_Offset), 0, ReceiveExecutionStartAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveExecutionStartAI_ControlledPawn_Offset), 0, ReceiveExecutionStartAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveExecutionStartAI_FunctionAddress, intPtr, ReceiveExecutionStartAI_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveExecutionStart")]
	protected unsafe void ReceiveExecutionStart(AActor OwnerActor)
	{
		CheckDestroyed();
		if (!ReceiveExecutionStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveExecutionStart");
			return;
		}
		if (ReceiveExecutionStart_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveExecutionStart_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveExecutionStart");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveExecutionStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveExecutionStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveExecutionStart_OwnerActor_Offset), 0, ReceiveExecutionStart_OwnerActor_PropertyAddress.Address, OwnerActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveExecutionStart_InstanceFunctionAddress, intPtr, ReceiveExecutionStart_ParamsSize);
	}

	protected unsafe virtual void ReceiveExecutionStart_Implementation(AActor OwnerActor)
	{
		CheckDestroyed();
		if (!ReceiveExecutionStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveExecutionStart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveExecutionStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveExecutionStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveExecutionStart_OwnerActor_Offset), 0, ReceiveExecutionStart_OwnerActor_PropertyAddress.Address, OwnerActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveExecutionStart_FunctionAddress, intPtr, ReceiveExecutionStart_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveExecutionFinishAI")]
	protected unsafe void ReceiveExecutionFinishAI(AIController OwnerController, APawn ControlledPawn, EBTNodeResult NodeResult)
	{
		CheckDestroyed();
		if (!ReceiveExecutionFinishAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveExecutionFinishAI");
			return;
		}
		if (ReceiveExecutionFinishAI_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveExecutionFinishAI_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveExecutionFinishAI");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveExecutionFinishAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveExecutionFinishAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveExecutionFinishAI_OwnerController_Offset), 0, ReceiveExecutionFinishAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveExecutionFinishAI_ControlledPawn_Offset), 0, ReceiveExecutionFinishAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		EnumMarshaler<EBTNodeResult>.ToNative(IntPtr.Add(intPtr, ReceiveExecutionFinishAI_NodeResult_Offset), 0, ReceiveExecutionFinishAI_NodeResult_PropertyAddress.Address, NodeResult);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveExecutionFinishAI_InstanceFunctionAddress, intPtr, ReceiveExecutionFinishAI_ParamsSize);
	}

	protected unsafe virtual void ReceiveExecutionFinishAI_Implementation(AIController OwnerController, APawn ControlledPawn, EBTNodeResult NodeResult)
	{
		CheckDestroyed();
		if (!ReceiveExecutionFinishAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveExecutionFinishAI");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveExecutionFinishAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveExecutionFinishAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveExecutionFinishAI_OwnerController_Offset), 0, ReceiveExecutionFinishAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveExecutionFinishAI_ControlledPawn_Offset), 0, ReceiveExecutionFinishAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		EnumMarshaler<EBTNodeResult>.ToNative(IntPtr.Add(intPtr, ReceiveExecutionFinishAI_NodeResult_Offset), 0, ReceiveExecutionFinishAI_NodeResult_PropertyAddress.Address, NodeResult);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveExecutionFinishAI_FunctionAddress, intPtr, ReceiveExecutionFinishAI_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveExecutionFinish")]
	protected unsafe void ReceiveExecutionFinish(AActor OwnerActor, EBTNodeResult NodeResult)
	{
		CheckDestroyed();
		if (!ReceiveExecutionFinish_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveExecutionFinish");
			return;
		}
		if (ReceiveExecutionFinish_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveExecutionFinish_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveExecutionFinish");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveExecutionFinish_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveExecutionFinish_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveExecutionFinish_OwnerActor_Offset), 0, ReceiveExecutionFinish_OwnerActor_PropertyAddress.Address, OwnerActor);
		EnumMarshaler<EBTNodeResult>.ToNative(IntPtr.Add(intPtr, ReceiveExecutionFinish_NodeResult_Offset), 0, ReceiveExecutionFinish_NodeResult_PropertyAddress.Address, NodeResult);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveExecutionFinish_InstanceFunctionAddress, intPtr, ReceiveExecutionFinish_ParamsSize);
	}

	protected unsafe virtual void ReceiveExecutionFinish_Implementation(AActor OwnerActor, EBTNodeResult NodeResult)
	{
		CheckDestroyed();
		if (!ReceiveExecutionFinish_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveExecutionFinish");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveExecutionFinish_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveExecutionFinish_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveExecutionFinish_OwnerActor_Offset), 0, ReceiveExecutionFinish_OwnerActor_PropertyAddress.Address, OwnerActor);
		EnumMarshaler<EBTNodeResult>.ToNative(IntPtr.Add(intPtr, ReceiveExecutionFinish_NodeResult_Offset), 0, ReceiveExecutionFinish_NodeResult_PropertyAddress.Address, NodeResult);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveExecutionFinish_FunctionAddress, intPtr, ReceiveExecutionFinish_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTDecorator_BlueprintBase:PerformConditionCheckAI")]
	protected unsafe bool PerformConditionCheckAI(AIController OwnerController, APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!PerformConditionCheckAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:PerformConditionCheckAI");
			return false;
		}
		if (PerformConditionCheckAI_InstanceFunctionAddress == IntPtr.Zero)
		{
			PerformConditionCheckAI_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PerformConditionCheckAI");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PerformConditionCheckAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PerformConditionCheckAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, PerformConditionCheckAI_OwnerController_Offset), 0, PerformConditionCheckAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, PerformConditionCheckAI_ControlledPawn_Offset), 0, PerformConditionCheckAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, PerformConditionCheckAI_InstanceFunctionAddress, intPtr, PerformConditionCheckAI_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PerformConditionCheckAI_ReturnValue_Offset), 0, PerformConditionCheckAI_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool PerformConditionCheckAI_Implementation(AIController OwnerController, APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!PerformConditionCheckAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:PerformConditionCheckAI");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PerformConditionCheckAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PerformConditionCheckAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, PerformConditionCheckAI_OwnerController_Offset), 0, PerformConditionCheckAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, PerformConditionCheckAI_ControlledPawn_Offset), 0, PerformConditionCheckAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, PerformConditionCheckAI_FunctionAddress, intPtr, PerformConditionCheckAI_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PerformConditionCheckAI_ReturnValue_Offset), 0, PerformConditionCheckAI_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTDecorator_BlueprintBase:PerformConditionCheck")]
	protected unsafe bool PerformConditionCheck(AActor OwnerActor)
	{
		CheckDestroyed();
		if (!PerformConditionCheck_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:PerformConditionCheck");
			return false;
		}
		if (PerformConditionCheck_InstanceFunctionAddress == IntPtr.Zero)
		{
			PerformConditionCheck_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PerformConditionCheck");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PerformConditionCheck_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PerformConditionCheck_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, PerformConditionCheck_OwnerActor_Offset), 0, PerformConditionCheck_OwnerActor_PropertyAddress.Address, OwnerActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, PerformConditionCheck_InstanceFunctionAddress, intPtr, PerformConditionCheck_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PerformConditionCheck_ReturnValue_Offset), 0, PerformConditionCheck_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool PerformConditionCheck_Implementation(AActor OwnerActor)
	{
		CheckDestroyed();
		if (!PerformConditionCheck_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:PerformConditionCheck");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PerformConditionCheck_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PerformConditionCheck_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, PerformConditionCheck_OwnerActor_Offset), 0, PerformConditionCheck_OwnerActor_PropertyAddress.Address, OwnerActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, PerformConditionCheck_FunctionAddress, intPtr, PerformConditionCheck_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PerformConditionCheck_ReturnValue_Offset), 0, PerformConditionCheck_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409811457u)]
	[UMetaPath("/Script/AIModule.BTDecorator_BlueprintBase:IsDecoratorObserverActive")]
	protected unsafe bool IsDecoratorObserverActive()
	{
		CheckDestroyed();
		if (!IsDecoratorObserverActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:IsDecoratorObserverActive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDecoratorObserverActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDecoratorObserverActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsDecoratorObserverActive_FunctionAddress, intPtr, IsDecoratorObserverActive_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDecoratorObserverActive_ReturnValue_Offset), 0, IsDecoratorObserverActive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409811457u)]
	[UMetaPath("/Script/AIModule.BTDecorator_BlueprintBase:IsDecoratorExecutionActive")]
	protected unsafe bool IsDecoratorExecutionActive()
	{
		CheckDestroyed();
		if (!IsDecoratorExecutionActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTDecorator_BlueprintBase:IsDecoratorExecutionActive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDecoratorExecutionActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDecoratorExecutionActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsDecoratorExecutionActive_FunctionAddress, intPtr, IsDecoratorExecutionActive_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDecoratorExecutionActive_ReturnValue_Offset), 0, IsDecoratorExecutionActive_ReturnValue_PropertyAddress.Address);
	}

	static UBTDecorator_BlueprintBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBTDecorator_BlueprintBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBTDecorator_BlueprintBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AIModule.BTDecorator_BlueprintBase");
		CustomDescription_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomDescription");
		CustomDescription_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomDescription", Classes.FStrProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveTickAI", ReceiveTickAI_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveTick_OwnerActor_PropertyAddress, ReceiveTick_FunctionAddress, "OwnerActor");
		ReceiveTick_OwnerActor_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveTick_FunctionAddress, "OwnerActor");
		ReceiveTick_OwnerActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveTick_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveTick_DeltaSeconds_PropertyAddress, ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_OwnerActor_IsValid && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveTick", ReceiveTick_IsValid);
		ReceiveObserverDeactivatedAI_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveObserverDeactivatedAI");
		ReceiveObserverDeactivatedAI_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveObserverDeactivatedAI_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveObserverDeactivatedAI_OwnerController_PropertyAddress, ReceiveObserverDeactivatedAI_FunctionAddress, "OwnerController");
		ReceiveObserverDeactivatedAI_OwnerController_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveObserverDeactivatedAI_FunctionAddress, "OwnerController");
		ReceiveObserverDeactivatedAI_OwnerController_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveObserverDeactivatedAI_FunctionAddress, "OwnerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveObserverDeactivatedAI_ControlledPawn_PropertyAddress, ReceiveObserverDeactivatedAI_FunctionAddress, "ControlledPawn");
		ReceiveObserverDeactivatedAI_ControlledPawn_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveObserverDeactivatedAI_FunctionAddress, "ControlledPawn");
		ReceiveObserverDeactivatedAI_ControlledPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveObserverDeactivatedAI_FunctionAddress, "ControlledPawn", Classes.FObjectProperty);
		ReceiveObserverDeactivatedAI_IsValid = ReceiveObserverDeactivatedAI_FunctionAddress != IntPtr.Zero && ReceiveObserverDeactivatedAI_OwnerController_IsValid && ReceiveObserverDeactivatedAI_ControlledPawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveObserverDeactivatedAI", ReceiveObserverDeactivatedAI_IsValid);
		ReceiveObserverDeactivated_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveObserverDeactivated");
		ReceiveObserverDeactivated_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveObserverDeactivated_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveObserverDeactivated_OwnerActor_PropertyAddress, ReceiveObserverDeactivated_FunctionAddress, "OwnerActor");
		ReceiveObserverDeactivated_OwnerActor_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveObserverDeactivated_FunctionAddress, "OwnerActor");
		ReceiveObserverDeactivated_OwnerActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveObserverDeactivated_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		ReceiveObserverDeactivated_IsValid = ReceiveObserverDeactivated_FunctionAddress != IntPtr.Zero && ReceiveObserverDeactivated_OwnerActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveObserverDeactivated", ReceiveObserverDeactivated_IsValid);
		ReceiveObserverActivatedAI_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveObserverActivatedAI");
		ReceiveObserverActivatedAI_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveObserverActivatedAI_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveObserverActivatedAI_OwnerController_PropertyAddress, ReceiveObserverActivatedAI_FunctionAddress, "OwnerController");
		ReceiveObserverActivatedAI_OwnerController_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveObserverActivatedAI_FunctionAddress, "OwnerController");
		ReceiveObserverActivatedAI_OwnerController_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveObserverActivatedAI_FunctionAddress, "OwnerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveObserverActivatedAI_ControlledPawn_PropertyAddress, ReceiveObserverActivatedAI_FunctionAddress, "ControlledPawn");
		ReceiveObserverActivatedAI_ControlledPawn_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveObserverActivatedAI_FunctionAddress, "ControlledPawn");
		ReceiveObserverActivatedAI_ControlledPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveObserverActivatedAI_FunctionAddress, "ControlledPawn", Classes.FObjectProperty);
		ReceiveObserverActivatedAI_IsValid = ReceiveObserverActivatedAI_FunctionAddress != IntPtr.Zero && ReceiveObserverActivatedAI_OwnerController_IsValid && ReceiveObserverActivatedAI_ControlledPawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveObserverActivatedAI", ReceiveObserverActivatedAI_IsValid);
		ReceiveObserverActivated_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveObserverActivated");
		ReceiveObserverActivated_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveObserverActivated_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveObserverActivated_OwnerActor_PropertyAddress, ReceiveObserverActivated_FunctionAddress, "OwnerActor");
		ReceiveObserverActivated_OwnerActor_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveObserverActivated_FunctionAddress, "OwnerActor");
		ReceiveObserverActivated_OwnerActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveObserverActivated_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		ReceiveObserverActivated_IsValid = ReceiveObserverActivated_FunctionAddress != IntPtr.Zero && ReceiveObserverActivated_OwnerActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveObserverActivated", ReceiveObserverActivated_IsValid);
		ReceiveExecutionStartAI_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveExecutionStartAI");
		ReceiveExecutionStartAI_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveExecutionStartAI_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveExecutionStartAI_OwnerController_PropertyAddress, ReceiveExecutionStartAI_FunctionAddress, "OwnerController");
		ReceiveExecutionStartAI_OwnerController_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveExecutionStartAI_FunctionAddress, "OwnerController");
		ReceiveExecutionStartAI_OwnerController_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveExecutionStartAI_FunctionAddress, "OwnerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveExecutionStartAI_ControlledPawn_PropertyAddress, ReceiveExecutionStartAI_FunctionAddress, "ControlledPawn");
		ReceiveExecutionStartAI_ControlledPawn_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveExecutionStartAI_FunctionAddress, "ControlledPawn");
		ReceiveExecutionStartAI_ControlledPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveExecutionStartAI_FunctionAddress, "ControlledPawn", Classes.FObjectProperty);
		ReceiveExecutionStartAI_IsValid = ReceiveExecutionStartAI_FunctionAddress != IntPtr.Zero && ReceiveExecutionStartAI_OwnerController_IsValid && ReceiveExecutionStartAI_ControlledPawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveExecutionStartAI", ReceiveExecutionStartAI_IsValid);
		ReceiveExecutionStart_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveExecutionStart");
		ReceiveExecutionStart_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveExecutionStart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveExecutionStart_OwnerActor_PropertyAddress, ReceiveExecutionStart_FunctionAddress, "OwnerActor");
		ReceiveExecutionStart_OwnerActor_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveExecutionStart_FunctionAddress, "OwnerActor");
		ReceiveExecutionStart_OwnerActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveExecutionStart_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		ReceiveExecutionStart_IsValid = ReceiveExecutionStart_FunctionAddress != IntPtr.Zero && ReceiveExecutionStart_OwnerActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveExecutionStart", ReceiveExecutionStart_IsValid);
		ReceiveExecutionFinishAI_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveExecutionFinishAI");
		ReceiveExecutionFinishAI_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveExecutionFinishAI_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveExecutionFinishAI_OwnerController_PropertyAddress, ReceiveExecutionFinishAI_FunctionAddress, "OwnerController");
		ReceiveExecutionFinishAI_OwnerController_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveExecutionFinishAI_FunctionAddress, "OwnerController");
		ReceiveExecutionFinishAI_OwnerController_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveExecutionFinishAI_FunctionAddress, "OwnerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveExecutionFinishAI_ControlledPawn_PropertyAddress, ReceiveExecutionFinishAI_FunctionAddress, "ControlledPawn");
		ReceiveExecutionFinishAI_ControlledPawn_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveExecutionFinishAI_FunctionAddress, "ControlledPawn");
		ReceiveExecutionFinishAI_ControlledPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveExecutionFinishAI_FunctionAddress, "ControlledPawn", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveExecutionFinishAI_NodeResult_PropertyAddress, ReceiveExecutionFinishAI_FunctionAddress, "NodeResult");
		ReceiveExecutionFinishAI_NodeResult_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveExecutionFinishAI_FunctionAddress, "NodeResult");
		ReceiveExecutionFinishAI_NodeResult_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveExecutionFinishAI_FunctionAddress, "NodeResult", Classes.FByteProperty);
		ReceiveExecutionFinishAI_IsValid = ReceiveExecutionFinishAI_FunctionAddress != IntPtr.Zero && ReceiveExecutionFinishAI_OwnerController_IsValid && ReceiveExecutionFinishAI_ControlledPawn_IsValid && ReceiveExecutionFinishAI_NodeResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveExecutionFinishAI", ReceiveExecutionFinishAI_IsValid);
		ReceiveExecutionFinish_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveExecutionFinish");
		ReceiveExecutionFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveExecutionFinish_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveExecutionFinish_OwnerActor_PropertyAddress, ReceiveExecutionFinish_FunctionAddress, "OwnerActor");
		ReceiveExecutionFinish_OwnerActor_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveExecutionFinish_FunctionAddress, "OwnerActor");
		ReceiveExecutionFinish_OwnerActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveExecutionFinish_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveExecutionFinish_NodeResult_PropertyAddress, ReceiveExecutionFinish_FunctionAddress, "NodeResult");
		ReceiveExecutionFinish_NodeResult_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveExecutionFinish_FunctionAddress, "NodeResult");
		ReceiveExecutionFinish_NodeResult_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveExecutionFinish_FunctionAddress, "NodeResult", Classes.FByteProperty);
		ReceiveExecutionFinish_IsValid = ReceiveExecutionFinish_FunctionAddress != IntPtr.Zero && ReceiveExecutionFinish_OwnerActor_IsValid && ReceiveExecutionFinish_NodeResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTDecorator_BlueprintBase:ReceiveExecutionFinish", ReceiveExecutionFinish_IsValid);
		PerformConditionCheckAI_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PerformConditionCheckAI");
		PerformConditionCheckAI_ParamsSize = NativeReflection.GetFunctionParamsSize(PerformConditionCheckAI_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PerformConditionCheckAI_OwnerController_PropertyAddress, PerformConditionCheckAI_FunctionAddress, "OwnerController");
		PerformConditionCheckAI_OwnerController_Offset = NativeReflectionCached.GetPropertyOffset(PerformConditionCheckAI_FunctionAddress, "OwnerController");
		PerformConditionCheckAI_OwnerController_IsValid = NativeReflectionCached.ValidatePropertyClass(PerformConditionCheckAI_FunctionAddress, "OwnerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PerformConditionCheckAI_ControlledPawn_PropertyAddress, PerformConditionCheckAI_FunctionAddress, "ControlledPawn");
		PerformConditionCheckAI_ControlledPawn_Offset = NativeReflectionCached.GetPropertyOffset(PerformConditionCheckAI_FunctionAddress, "ControlledPawn");
		PerformConditionCheckAI_ControlledPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(PerformConditionCheckAI_FunctionAddress, "ControlledPawn", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PerformConditionCheckAI_ReturnValue_PropertyAddress, PerformConditionCheckAI_FunctionAddress, "ReturnValue");
		PerformConditionCheckAI_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PerformConditionCheckAI_FunctionAddress, "ReturnValue");
		PerformConditionCheckAI_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PerformConditionCheckAI_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PerformConditionCheckAI_IsValid = PerformConditionCheckAI_FunctionAddress != IntPtr.Zero && PerformConditionCheckAI_OwnerController_IsValid && PerformConditionCheckAI_ControlledPawn_IsValid && PerformConditionCheckAI_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTDecorator_BlueprintBase:PerformConditionCheckAI", PerformConditionCheckAI_IsValid);
		PerformConditionCheck_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PerformConditionCheck");
		PerformConditionCheck_ParamsSize = NativeReflection.GetFunctionParamsSize(PerformConditionCheck_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PerformConditionCheck_OwnerActor_PropertyAddress, PerformConditionCheck_FunctionAddress, "OwnerActor");
		PerformConditionCheck_OwnerActor_Offset = NativeReflectionCached.GetPropertyOffset(PerformConditionCheck_FunctionAddress, "OwnerActor");
		PerformConditionCheck_OwnerActor_IsValid = NativeReflectionCached.ValidatePropertyClass(PerformConditionCheck_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PerformConditionCheck_ReturnValue_PropertyAddress, PerformConditionCheck_FunctionAddress, "ReturnValue");
		PerformConditionCheck_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PerformConditionCheck_FunctionAddress, "ReturnValue");
		PerformConditionCheck_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PerformConditionCheck_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PerformConditionCheck_IsValid = PerformConditionCheck_FunctionAddress != IntPtr.Zero && PerformConditionCheck_OwnerActor_IsValid && PerformConditionCheck_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTDecorator_BlueprintBase:PerformConditionCheck", PerformConditionCheck_IsValid);
		IsDecoratorObserverActive_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsDecoratorObserverActive");
		IsDecoratorObserverActive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDecoratorObserverActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDecoratorObserverActive_ReturnValue_PropertyAddress, IsDecoratorObserverActive_FunctionAddress, "ReturnValue");
		IsDecoratorObserverActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDecoratorObserverActive_FunctionAddress, "ReturnValue");
		IsDecoratorObserverActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDecoratorObserverActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDecoratorObserverActive_IsValid = IsDecoratorObserverActive_FunctionAddress != IntPtr.Zero && IsDecoratorObserverActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTDecorator_BlueprintBase:IsDecoratorObserverActive", IsDecoratorObserverActive_IsValid);
		IsDecoratorExecutionActive_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsDecoratorExecutionActive");
		IsDecoratorExecutionActive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDecoratorExecutionActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDecoratorExecutionActive_ReturnValue_PropertyAddress, IsDecoratorExecutionActive_FunctionAddress, "ReturnValue");
		IsDecoratorExecutionActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDecoratorExecutionActive_FunctionAddress, "ReturnValue");
		IsDecoratorExecutionActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDecoratorExecutionActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDecoratorExecutionActive_IsValid = IsDecoratorExecutionActive_FunctionAddress != IntPtr.Zero && IsDecoratorExecutionActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTDecorator_BlueprintBase:IsDecoratorExecutionActive", IsDecoratorExecutionActive_IsValid);
	}
}
