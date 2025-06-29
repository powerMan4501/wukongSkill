using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AIModule.BTService_BlueprintBase", "AIModule", UnrealModuleType.Engine)]
public class UBTService_BlueprintBase : UBTService
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

	private static bool ReceiveSearchStartAI_IsValid;

	private IntPtr ReceiveSearchStartAI_InstanceFunctionAddress;

	private static IntPtr ReceiveSearchStartAI_FunctionAddress;

	private static int ReceiveSearchStartAI_ParamsSize;

	private static bool ReceiveSearchStartAI_OwnerController_IsValid;

	private static FFieldAddress ReceiveSearchStartAI_OwnerController_PropertyAddress;

	private static int ReceiveSearchStartAI_OwnerController_Offset;

	private static bool ReceiveSearchStartAI_ControlledPawn_IsValid;

	private static FFieldAddress ReceiveSearchStartAI_ControlledPawn_PropertyAddress;

	private static int ReceiveSearchStartAI_ControlledPawn_Offset;

	private static bool ReceiveSearchStart_IsValid;

	private IntPtr ReceiveSearchStart_InstanceFunctionAddress;

	private static IntPtr ReceiveSearchStart_FunctionAddress;

	private static int ReceiveSearchStart_ParamsSize;

	private static bool ReceiveSearchStart_OwnerActor_IsValid;

	private static FFieldAddress ReceiveSearchStart_OwnerActor_PropertyAddress;

	private static int ReceiveSearchStart_OwnerActor_Offset;

	private static bool ReceiveDeactivationAI_IsValid;

	private IntPtr ReceiveDeactivationAI_InstanceFunctionAddress;

	private static IntPtr ReceiveDeactivationAI_FunctionAddress;

	private static int ReceiveDeactivationAI_ParamsSize;

	private static bool ReceiveDeactivationAI_OwnerController_IsValid;

	private static FFieldAddress ReceiveDeactivationAI_OwnerController_PropertyAddress;

	private static int ReceiveDeactivationAI_OwnerController_Offset;

	private static bool ReceiveDeactivationAI_ControlledPawn_IsValid;

	private static FFieldAddress ReceiveDeactivationAI_ControlledPawn_PropertyAddress;

	private static int ReceiveDeactivationAI_ControlledPawn_Offset;

	private static bool ReceiveDeactivation_IsValid;

	private IntPtr ReceiveDeactivation_InstanceFunctionAddress;

	private static IntPtr ReceiveDeactivation_FunctionAddress;

	private static int ReceiveDeactivation_ParamsSize;

	private static bool ReceiveDeactivation_OwnerActor_IsValid;

	private static FFieldAddress ReceiveDeactivation_OwnerActor_PropertyAddress;

	private static int ReceiveDeactivation_OwnerActor_Offset;

	private static bool ReceiveActivationAI_IsValid;

	private IntPtr ReceiveActivationAI_InstanceFunctionAddress;

	private static IntPtr ReceiveActivationAI_FunctionAddress;

	private static int ReceiveActivationAI_ParamsSize;

	private static bool ReceiveActivationAI_OwnerController_IsValid;

	private static FFieldAddress ReceiveActivationAI_OwnerController_PropertyAddress;

	private static int ReceiveActivationAI_OwnerController_Offset;

	private static bool ReceiveActivationAI_ControlledPawn_IsValid;

	private static FFieldAddress ReceiveActivationAI_ControlledPawn_PropertyAddress;

	private static int ReceiveActivationAI_ControlledPawn_Offset;

	private static bool ReceiveActivation_IsValid;

	private IntPtr ReceiveActivation_InstanceFunctionAddress;

	private static IntPtr ReceiveActivation_FunctionAddress;

	private static int ReceiveActivation_ParamsSize;

	private static bool ReceiveActivation_OwnerActor_IsValid;

	private static FFieldAddress ReceiveActivation_OwnerActor_PropertyAddress;

	private static int ReceiveActivation_OwnerActor_Offset;

	private static bool IsServiceActive_IsValid;

	private static IntPtr IsServiceActive_FunctionAddress;

	private static int IsServiceActive_ParamsSize;

	private static bool IsServiceActive_ReturnValue_IsValid;

	private static FFieldAddress IsServiceActive_ReturnValue_PropertyAddress;

	private static int IsServiceActive_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)11267829521252869uL)]
	[UMetaPath("/Script/AIModule.BTService_BlueprintBase:CustomDescription")]
	protected string CustomDescription
	{
		get
		{
			CheckDestroyed();
			if (!CustomDescription_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.BTService_BlueprintBase:CustomDescription");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, CustomDescription_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomDescription_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.BTService_BlueprintBase:CustomDescription");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, CustomDescription_Offset), value);
			}
		}
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTService_BlueprintBase:ReceiveTickAI")]
	protected unsafe void ReceiveTickAI(AIController OwnerController, APawn ControlledPawn, float DeltaSeconds)
	{
		CheckDestroyed();
		if (!ReceiveTickAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTService_BlueprintBase:ReceiveTickAI");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTService_BlueprintBase:ReceiveTickAI");
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
	[UMetaPath("/Script/AIModule.BTService_BlueprintBase:ReceiveTick")]
	protected unsafe void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
		CheckDestroyed();
		if (!ReceiveTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTService_BlueprintBase:ReceiveTick");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTService_BlueprintBase:ReceiveTick");
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
	[UMetaPath("/Script/AIModule.BTService_BlueprintBase:ReceiveSearchStartAI")]
	protected unsafe void ReceiveSearchStartAI(AIController OwnerController, APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ReceiveSearchStartAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTService_BlueprintBase:ReceiveSearchStartAI");
			return;
		}
		if (ReceiveSearchStartAI_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveSearchStartAI_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveSearchStartAI");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveSearchStartAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveSearchStartAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveSearchStartAI_OwnerController_Offset), 0, ReceiveSearchStartAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveSearchStartAI_ControlledPawn_Offset), 0, ReceiveSearchStartAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveSearchStartAI_InstanceFunctionAddress, intPtr, ReceiveSearchStartAI_ParamsSize);
	}

	protected unsafe virtual void ReceiveSearchStartAI_Implementation(AIController OwnerController, APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ReceiveSearchStartAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTService_BlueprintBase:ReceiveSearchStartAI");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveSearchStartAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveSearchStartAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveSearchStartAI_OwnerController_Offset), 0, ReceiveSearchStartAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveSearchStartAI_ControlledPawn_Offset), 0, ReceiveSearchStartAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveSearchStartAI_FunctionAddress, intPtr, ReceiveSearchStartAI_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTService_BlueprintBase:ReceiveSearchStart")]
	protected unsafe void ReceiveSearchStart(AActor OwnerActor)
	{
		CheckDestroyed();
		if (!ReceiveSearchStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTService_BlueprintBase:ReceiveSearchStart");
			return;
		}
		if (ReceiveSearchStart_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveSearchStart_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveSearchStart");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveSearchStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveSearchStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveSearchStart_OwnerActor_Offset), 0, ReceiveSearchStart_OwnerActor_PropertyAddress.Address, OwnerActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveSearchStart_InstanceFunctionAddress, intPtr, ReceiveSearchStart_ParamsSize);
	}

	protected unsafe virtual void ReceiveSearchStart_Implementation(AActor OwnerActor)
	{
		CheckDestroyed();
		if (!ReceiveSearchStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTService_BlueprintBase:ReceiveSearchStart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveSearchStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveSearchStart_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveSearchStart_OwnerActor_Offset), 0, ReceiveSearchStart_OwnerActor_PropertyAddress.Address, OwnerActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveSearchStart_FunctionAddress, intPtr, ReceiveSearchStart_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTService_BlueprintBase:ReceiveDeactivationAI")]
	protected unsafe void ReceiveDeactivationAI(AIController OwnerController, APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ReceiveDeactivationAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTService_BlueprintBase:ReceiveDeactivationAI");
			return;
		}
		if (ReceiveDeactivationAI_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveDeactivationAI_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveDeactivationAI");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveDeactivationAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveDeactivationAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveDeactivationAI_OwnerController_Offset), 0, ReceiveDeactivationAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveDeactivationAI_ControlledPawn_Offset), 0, ReceiveDeactivationAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveDeactivationAI_InstanceFunctionAddress, intPtr, ReceiveDeactivationAI_ParamsSize);
	}

	protected unsafe virtual void ReceiveDeactivationAI_Implementation(AIController OwnerController, APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ReceiveDeactivationAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTService_BlueprintBase:ReceiveDeactivationAI");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveDeactivationAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveDeactivationAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveDeactivationAI_OwnerController_Offset), 0, ReceiveDeactivationAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveDeactivationAI_ControlledPawn_Offset), 0, ReceiveDeactivationAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveDeactivationAI_FunctionAddress, intPtr, ReceiveDeactivationAI_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTService_BlueprintBase:ReceiveDeactivation")]
	protected unsafe void ReceiveDeactivation(AActor OwnerActor)
	{
		CheckDestroyed();
		if (!ReceiveDeactivation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTService_BlueprintBase:ReceiveDeactivation");
			return;
		}
		if (ReceiveDeactivation_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveDeactivation_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveDeactivation");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveDeactivation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveDeactivation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveDeactivation_OwnerActor_Offset), 0, ReceiveDeactivation_OwnerActor_PropertyAddress.Address, OwnerActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveDeactivation_InstanceFunctionAddress, intPtr, ReceiveDeactivation_ParamsSize);
	}

	protected unsafe virtual void ReceiveDeactivation_Implementation(AActor OwnerActor)
	{
		CheckDestroyed();
		if (!ReceiveDeactivation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTService_BlueprintBase:ReceiveDeactivation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveDeactivation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveDeactivation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveDeactivation_OwnerActor_Offset), 0, ReceiveDeactivation_OwnerActor_PropertyAddress.Address, OwnerActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveDeactivation_FunctionAddress, intPtr, ReceiveDeactivation_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTService_BlueprintBase:ReceiveActivationAI")]
	protected unsafe void ReceiveActivationAI(AIController OwnerController, APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ReceiveActivationAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTService_BlueprintBase:ReceiveActivationAI");
			return;
		}
		if (ReceiveActivationAI_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveActivationAI_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveActivationAI");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActivationAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActivationAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveActivationAI_OwnerController_Offset), 0, ReceiveActivationAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveActivationAI_ControlledPawn_Offset), 0, ReceiveActivationAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActivationAI_InstanceFunctionAddress, intPtr, ReceiveActivationAI_ParamsSize);
	}

	protected unsafe virtual void ReceiveActivationAI_Implementation(AIController OwnerController, APawn ControlledPawn)
	{
		CheckDestroyed();
		if (!ReceiveActivationAI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTService_BlueprintBase:ReceiveActivationAI");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActivationAI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActivationAI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AIController>.ToNative(IntPtr.Add(intPtr, ReceiveActivationAI_OwnerController_Offset), 0, ReceiveActivationAI_OwnerController_PropertyAddress.Address, OwnerController);
		UObjectMarshaler<APawn>.ToNative(IntPtr.Add(intPtr, ReceiveActivationAI_ControlledPawn_Offset), 0, ReceiveActivationAI_ControlledPawn_PropertyAddress.Address, ControlledPawn);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActivationAI_FunctionAddress, intPtr, ReceiveActivationAI_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/AIModule.BTService_BlueprintBase:ReceiveActivation")]
	protected unsafe void ReceiveActivation(AActor OwnerActor)
	{
		CheckDestroyed();
		if (!ReceiveActivation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTService_BlueprintBase:ReceiveActivation");
			return;
		}
		if (ReceiveActivation_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveActivation_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveActivation");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActivation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActivation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveActivation_OwnerActor_Offset), 0, ReceiveActivation_OwnerActor_PropertyAddress.Address, OwnerActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActivation_InstanceFunctionAddress, intPtr, ReceiveActivation_ParamsSize);
	}

	protected unsafe virtual void ReceiveActivation_Implementation(AActor OwnerActor)
	{
		CheckDestroyed();
		if (!ReceiveActivation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTService_BlueprintBase:ReceiveActivation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveActivation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveActivation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ReceiveActivation_OwnerActor_Offset), 0, ReceiveActivation_OwnerActor_PropertyAddress.Address, OwnerActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReceiveActivation_FunctionAddress, intPtr, ReceiveActivation_ParamsSize);
	}

	[UFunction(Flags = 1409811457u)]
	[UMetaPath("/Script/AIModule.BTService_BlueprintBase:IsServiceActive")]
	protected unsafe bool IsServiceActive()
	{
		CheckDestroyed();
		if (!IsServiceActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AIModule.BTService_BlueprintBase:IsServiceActive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsServiceActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsServiceActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsServiceActive_FunctionAddress, intPtr, IsServiceActive_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsServiceActive_ReturnValue_Offset), 0, IsServiceActive_ReturnValue_PropertyAddress.Address);
	}

	static UBTService_BlueprintBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBTService_BlueprintBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBTService_BlueprintBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AIModule.BTService_BlueprintBase");
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
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTService_BlueprintBase:ReceiveTickAI", ReceiveTickAI_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveTick_OwnerActor_PropertyAddress, ReceiveTick_FunctionAddress, "OwnerActor");
		ReceiveTick_OwnerActor_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveTick_FunctionAddress, "OwnerActor");
		ReceiveTick_OwnerActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveTick_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveTick_DeltaSeconds_PropertyAddress, ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_OwnerActor_IsValid && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTService_BlueprintBase:ReceiveTick", ReceiveTick_IsValid);
		ReceiveSearchStartAI_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveSearchStartAI");
		ReceiveSearchStartAI_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveSearchStartAI_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveSearchStartAI_OwnerController_PropertyAddress, ReceiveSearchStartAI_FunctionAddress, "OwnerController");
		ReceiveSearchStartAI_OwnerController_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveSearchStartAI_FunctionAddress, "OwnerController");
		ReceiveSearchStartAI_OwnerController_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveSearchStartAI_FunctionAddress, "OwnerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveSearchStartAI_ControlledPawn_PropertyAddress, ReceiveSearchStartAI_FunctionAddress, "ControlledPawn");
		ReceiveSearchStartAI_ControlledPawn_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveSearchStartAI_FunctionAddress, "ControlledPawn");
		ReceiveSearchStartAI_ControlledPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveSearchStartAI_FunctionAddress, "ControlledPawn", Classes.FObjectProperty);
		ReceiveSearchStartAI_IsValid = ReceiveSearchStartAI_FunctionAddress != IntPtr.Zero && ReceiveSearchStartAI_OwnerController_IsValid && ReceiveSearchStartAI_ControlledPawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTService_BlueprintBase:ReceiveSearchStartAI", ReceiveSearchStartAI_IsValid);
		ReceiveSearchStart_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveSearchStart");
		ReceiveSearchStart_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveSearchStart_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveSearchStart_OwnerActor_PropertyAddress, ReceiveSearchStart_FunctionAddress, "OwnerActor");
		ReceiveSearchStart_OwnerActor_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveSearchStart_FunctionAddress, "OwnerActor");
		ReceiveSearchStart_OwnerActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveSearchStart_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		ReceiveSearchStart_IsValid = ReceiveSearchStart_FunctionAddress != IntPtr.Zero && ReceiveSearchStart_OwnerActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTService_BlueprintBase:ReceiveSearchStart", ReceiveSearchStart_IsValid);
		ReceiveDeactivationAI_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveDeactivationAI");
		ReceiveDeactivationAI_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveDeactivationAI_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveDeactivationAI_OwnerController_PropertyAddress, ReceiveDeactivationAI_FunctionAddress, "OwnerController");
		ReceiveDeactivationAI_OwnerController_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveDeactivationAI_FunctionAddress, "OwnerController");
		ReceiveDeactivationAI_OwnerController_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveDeactivationAI_FunctionAddress, "OwnerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveDeactivationAI_ControlledPawn_PropertyAddress, ReceiveDeactivationAI_FunctionAddress, "ControlledPawn");
		ReceiveDeactivationAI_ControlledPawn_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveDeactivationAI_FunctionAddress, "ControlledPawn");
		ReceiveDeactivationAI_ControlledPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveDeactivationAI_FunctionAddress, "ControlledPawn", Classes.FObjectProperty);
		ReceiveDeactivationAI_IsValid = ReceiveDeactivationAI_FunctionAddress != IntPtr.Zero && ReceiveDeactivationAI_OwnerController_IsValid && ReceiveDeactivationAI_ControlledPawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTService_BlueprintBase:ReceiveDeactivationAI", ReceiveDeactivationAI_IsValid);
		ReceiveDeactivation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveDeactivation");
		ReceiveDeactivation_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveDeactivation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveDeactivation_OwnerActor_PropertyAddress, ReceiveDeactivation_FunctionAddress, "OwnerActor");
		ReceiveDeactivation_OwnerActor_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveDeactivation_FunctionAddress, "OwnerActor");
		ReceiveDeactivation_OwnerActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveDeactivation_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		ReceiveDeactivation_IsValid = ReceiveDeactivation_FunctionAddress != IntPtr.Zero && ReceiveDeactivation_OwnerActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTService_BlueprintBase:ReceiveDeactivation", ReceiveDeactivation_IsValid);
		ReceiveActivationAI_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveActivationAI");
		ReceiveActivationAI_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveActivationAI_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveActivationAI_OwnerController_PropertyAddress, ReceiveActivationAI_FunctionAddress, "OwnerController");
		ReceiveActivationAI_OwnerController_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveActivationAI_FunctionAddress, "OwnerController");
		ReceiveActivationAI_OwnerController_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveActivationAI_FunctionAddress, "OwnerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReceiveActivationAI_ControlledPawn_PropertyAddress, ReceiveActivationAI_FunctionAddress, "ControlledPawn");
		ReceiveActivationAI_ControlledPawn_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveActivationAI_FunctionAddress, "ControlledPawn");
		ReceiveActivationAI_ControlledPawn_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveActivationAI_FunctionAddress, "ControlledPawn", Classes.FObjectProperty);
		ReceiveActivationAI_IsValid = ReceiveActivationAI_FunctionAddress != IntPtr.Zero && ReceiveActivationAI_OwnerController_IsValid && ReceiveActivationAI_ControlledPawn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTService_BlueprintBase:ReceiveActivationAI", ReceiveActivationAI_IsValid);
		ReceiveActivation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveActivation");
		ReceiveActivation_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveActivation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReceiveActivation_OwnerActor_PropertyAddress, ReceiveActivation_FunctionAddress, "OwnerActor");
		ReceiveActivation_OwnerActor_Offset = NativeReflectionCached.GetPropertyOffset(ReceiveActivation_FunctionAddress, "OwnerActor");
		ReceiveActivation_OwnerActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ReceiveActivation_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		ReceiveActivation_IsValid = ReceiveActivation_FunctionAddress != IntPtr.Zero && ReceiveActivation_OwnerActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTService_BlueprintBase:ReceiveActivation", ReceiveActivation_IsValid);
		IsServiceActive_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsServiceActive");
		IsServiceActive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsServiceActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsServiceActive_ReturnValue_PropertyAddress, IsServiceActive_FunctionAddress, "ReturnValue");
		IsServiceActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsServiceActive_FunctionAddress, "ReturnValue");
		IsServiceActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsServiceActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsServiceActive_IsValid = IsServiceActive_FunctionAddress != IntPtr.Zero && IsServiceActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AIModule.BTService_BlueprintBase:IsServiceActive", IsServiceActive_IsValid);
	}
}
