using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)810627233uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.AnimNotifyState", "Engine", UnrealModuleType.Engine)]
public class UAnimNotifyState : UObject
{
	private static bool NotifyColor_IsValid;

	private static int NotifyColor_Offset;

	private static bool ShouldFireInEditor_IsValid;

	private static FFieldAddress ShouldFireInEditor_PropertyAddress;

	private static int ShouldFireInEditor_Offset;

	private static bool Received_NotifyTick_IsValid;

	private IntPtr Received_NotifyTick_InstanceFunctionAddress;

	private static IntPtr Received_NotifyTick_FunctionAddress;

	private static int Received_NotifyTick_ParamsSize;

	private static bool Received_NotifyTick_MeshComp_IsValid;

	private static FFieldAddress Received_NotifyTick_MeshComp_PropertyAddress;

	private static int Received_NotifyTick_MeshComp_Offset;

	private static bool Received_NotifyTick_Animation_IsValid;

	private static FFieldAddress Received_NotifyTick_Animation_PropertyAddress;

	private static int Received_NotifyTick_Animation_Offset;

	private static bool Received_NotifyTick_FrameDeltaTime_IsValid;

	private static FFieldAddress Received_NotifyTick_FrameDeltaTime_PropertyAddress;

	private static int Received_NotifyTick_FrameDeltaTime_Offset;

	private static bool Received_NotifyTick_EventReference_IsValid;

	private static FFieldAddress Received_NotifyTick_EventReference_PropertyAddress;

	private static int Received_NotifyTick_EventReference_Offset;

	private static bool Received_NotifyTick_ReturnValue_IsValid;

	private static FFieldAddress Received_NotifyTick_ReturnValue_PropertyAddress;

	private static int Received_NotifyTick_ReturnValue_Offset;

	private static bool Received_NotifyEnd_IsValid;

	private IntPtr Received_NotifyEnd_InstanceFunctionAddress;

	private static IntPtr Received_NotifyEnd_FunctionAddress;

	private static int Received_NotifyEnd_ParamsSize;

	private static bool Received_NotifyEnd_MeshComp_IsValid;

	private static FFieldAddress Received_NotifyEnd_MeshComp_PropertyAddress;

	private static int Received_NotifyEnd_MeshComp_Offset;

	private static bool Received_NotifyEnd_Animation_IsValid;

	private static FFieldAddress Received_NotifyEnd_Animation_PropertyAddress;

	private static int Received_NotifyEnd_Animation_Offset;

	private static bool Received_NotifyEnd_EventReference_IsValid;

	private static FFieldAddress Received_NotifyEnd_EventReference_PropertyAddress;

	private static int Received_NotifyEnd_EventReference_Offset;

	private static bool Received_NotifyEnd_ReturnValue_IsValid;

	private static FFieldAddress Received_NotifyEnd_ReturnValue_PropertyAddress;

	private static int Received_NotifyEnd_ReturnValue_Offset;

	private static bool Received_NotifyBegin_IsValid;

	private IntPtr Received_NotifyBegin_InstanceFunctionAddress;

	private static IntPtr Received_NotifyBegin_FunctionAddress;

	private static int Received_NotifyBegin_ParamsSize;

	private static bool Received_NotifyBegin_MeshComp_IsValid;

	private static FFieldAddress Received_NotifyBegin_MeshComp_PropertyAddress;

	private static int Received_NotifyBegin_MeshComp_Offset;

	private static bool Received_NotifyBegin_Animation_IsValid;

	private static FFieldAddress Received_NotifyBegin_Animation_PropertyAddress;

	private static int Received_NotifyBegin_Animation_Offset;

	private static bool Received_NotifyBegin_TotalDuration_IsValid;

	private static FFieldAddress Received_NotifyBegin_TotalDuration_PropertyAddress;

	private static int Received_NotifyBegin_TotalDuration_Offset;

	private static bool Received_NotifyBegin_EventReference_IsValid;

	private static FFieldAddress Received_NotifyBegin_EventReference_PropertyAddress;

	private static int Received_NotifyBegin_EventReference_Offset;

	private static bool Received_NotifyBegin_ReturnValue_IsValid;

	private static FFieldAddress Received_NotifyBegin_ReturnValue_PropertyAddress;

	private static int Received_NotifyBegin_ReturnValue_Offset;

	private static bool GetNotifyName_IsValid;

	private IntPtr GetNotifyName_InstanceFunctionAddress;

	private static IntPtr GetNotifyName_FunctionAddress;

	private static int GetNotifyName_ParamsSize;

	private static bool GetNotifyName_ReturnValue_IsValid;

	private static FFieldAddress GetNotifyName_ReturnValue_PropertyAddress;

	private static int GetNotifyName_ReturnValue_Offset;

	private static bool GetDefaultTriggerWeightThreshold_IsValid;

	private IntPtr GetDefaultTriggerWeightThreshold_InstanceFunctionAddress;

	private static IntPtr GetDefaultTriggerWeightThreshold_FunctionAddress;

	private static int GetDefaultTriggerWeightThreshold_ParamsSize;

	private static bool GetDefaultTriggerWeightThreshold_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultTriggerWeightThreshold_ReturnValue_PropertyAddress;

	private static int GetDefaultTriggerWeightThreshold_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755503594013205uL)]
	[UMetaPath("/Script/Engine.AnimNotifyState:NotifyColor")]
	public FColor NotifyColor
	{
		get
		{
			CheckDestroyed();
			if (!NotifyColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyState:NotifyColor");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, NotifyColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyState:NotifyColor");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, NotifyColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759901640524309uL)]
	[UMetaPath("/Script/Engine.AnimNotifyState:bShouldFireInEditor")]
	public bool ShouldFireInEditor
	{
		get
		{
			CheckDestroyed();
			if (!ShouldFireInEditor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyState:bShouldFireInEditor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShouldFireInEditor_Offset), 0, ShouldFireInEditor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShouldFireInEditor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotifyState:bShouldFireInEditor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShouldFireInEditor_Offset), 0, ShouldFireInEditor_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/Engine.AnimNotifyState:Received_NotifyTick")]
	public unsafe bool Received_NotifyTick(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime, FAnimNotifyEventReference EventReference)
	{
		CheckDestroyed();
		if (!Received_NotifyTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotifyState:Received_NotifyTick");
			return false;
		}
		if (Received_NotifyTick_InstanceFunctionAddress == IntPtr.Zero)
		{
			Received_NotifyTick_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Received_NotifyTick");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Received_NotifyTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Received_NotifyTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, Received_NotifyTick_MeshComp_Offset), 0, Received_NotifyTick_MeshComp_PropertyAddress.Address, MeshComp);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, Received_NotifyTick_Animation_Offset), 0, Received_NotifyTick_Animation_PropertyAddress.Address, Animation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Received_NotifyTick_FrameDeltaTime_Offset), 0, Received_NotifyTick_FrameDeltaTime_PropertyAddress.Address, FrameDeltaTime);
		NativeReflection.InitializeValue_InContainer(Received_NotifyTick_EventReference_PropertyAddress.Address, intPtr);
		FAnimNotifyEventReference.ToNative(IntPtr.Add(intPtr, Received_NotifyTick_EventReference_Offset), 0, Received_NotifyTick_EventReference_PropertyAddress.Address, EventReference);
		NativeReflection.InvokeFunctionOptimized(base.Address, Received_NotifyTick_InstanceFunctionAddress, intPtr, Received_NotifyTick_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Received_NotifyTick_EventReference_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Received_NotifyTick_ReturnValue_Offset), 0, Received_NotifyTick_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool Received_NotifyTick_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime, FAnimNotifyEventReference EventReference)
	{
		CheckDestroyed();
		if (!Received_NotifyTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotifyState:Received_NotifyTick");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Received_NotifyTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Received_NotifyTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, Received_NotifyTick_MeshComp_Offset), 0, Received_NotifyTick_MeshComp_PropertyAddress.Address, MeshComp);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, Received_NotifyTick_Animation_Offset), 0, Received_NotifyTick_Animation_PropertyAddress.Address, Animation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Received_NotifyTick_FrameDeltaTime_Offset), 0, Received_NotifyTick_FrameDeltaTime_PropertyAddress.Address, FrameDeltaTime);
		NativeReflection.InitializeValue_InContainer(Received_NotifyTick_EventReference_PropertyAddress.Address, intPtr);
		FAnimNotifyEventReference.ToNative(IntPtr.Add(intPtr, Received_NotifyTick_EventReference_Offset), 0, Received_NotifyTick_EventReference_PropertyAddress.Address, EventReference);
		NativeReflection.InvokeFunctionOptimized(base.Address, Received_NotifyTick_FunctionAddress, intPtr, Received_NotifyTick_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Received_NotifyTick_EventReference_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Received_NotifyTick_ReturnValue_Offset), 0, Received_NotifyTick_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/Engine.AnimNotifyState:Received_NotifyEnd")]
	public unsafe bool Received_NotifyEnd(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, FAnimNotifyEventReference EventReference)
	{
		CheckDestroyed();
		if (!Received_NotifyEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotifyState:Received_NotifyEnd");
			return false;
		}
		if (Received_NotifyEnd_InstanceFunctionAddress == IntPtr.Zero)
		{
			Received_NotifyEnd_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Received_NotifyEnd");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Received_NotifyEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Received_NotifyEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, Received_NotifyEnd_MeshComp_Offset), 0, Received_NotifyEnd_MeshComp_PropertyAddress.Address, MeshComp);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, Received_NotifyEnd_Animation_Offset), 0, Received_NotifyEnd_Animation_PropertyAddress.Address, Animation);
		NativeReflection.InitializeValue_InContainer(Received_NotifyEnd_EventReference_PropertyAddress.Address, intPtr);
		FAnimNotifyEventReference.ToNative(IntPtr.Add(intPtr, Received_NotifyEnd_EventReference_Offset), 0, Received_NotifyEnd_EventReference_PropertyAddress.Address, EventReference);
		NativeReflection.InvokeFunctionOptimized(base.Address, Received_NotifyEnd_InstanceFunctionAddress, intPtr, Received_NotifyEnd_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Received_NotifyEnd_EventReference_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Received_NotifyEnd_ReturnValue_Offset), 0, Received_NotifyEnd_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool Received_NotifyEnd_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, FAnimNotifyEventReference EventReference)
	{
		CheckDestroyed();
		if (!Received_NotifyEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotifyState:Received_NotifyEnd");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Received_NotifyEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Received_NotifyEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, Received_NotifyEnd_MeshComp_Offset), 0, Received_NotifyEnd_MeshComp_PropertyAddress.Address, MeshComp);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, Received_NotifyEnd_Animation_Offset), 0, Received_NotifyEnd_Animation_PropertyAddress.Address, Animation);
		NativeReflection.InitializeValue_InContainer(Received_NotifyEnd_EventReference_PropertyAddress.Address, intPtr);
		FAnimNotifyEventReference.ToNative(IntPtr.Add(intPtr, Received_NotifyEnd_EventReference_Offset), 0, Received_NotifyEnd_EventReference_PropertyAddress.Address, EventReference);
		NativeReflection.InvokeFunctionOptimized(base.Address, Received_NotifyEnd_FunctionAddress, intPtr, Received_NotifyEnd_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Received_NotifyEnd_EventReference_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Received_NotifyEnd_ReturnValue_Offset), 0, Received_NotifyEnd_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/Engine.AnimNotifyState:Received_NotifyBegin")]
	public unsafe bool Received_NotifyBegin(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration, FAnimNotifyEventReference EventReference)
	{
		CheckDestroyed();
		if (!Received_NotifyBegin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotifyState:Received_NotifyBegin");
			return false;
		}
		if (Received_NotifyBegin_InstanceFunctionAddress == IntPtr.Zero)
		{
			Received_NotifyBegin_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Received_NotifyBegin");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Received_NotifyBegin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Received_NotifyBegin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, Received_NotifyBegin_MeshComp_Offset), 0, Received_NotifyBegin_MeshComp_PropertyAddress.Address, MeshComp);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, Received_NotifyBegin_Animation_Offset), 0, Received_NotifyBegin_Animation_PropertyAddress.Address, Animation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Received_NotifyBegin_TotalDuration_Offset), 0, Received_NotifyBegin_TotalDuration_PropertyAddress.Address, TotalDuration);
		NativeReflection.InitializeValue_InContainer(Received_NotifyBegin_EventReference_PropertyAddress.Address, intPtr);
		FAnimNotifyEventReference.ToNative(IntPtr.Add(intPtr, Received_NotifyBegin_EventReference_Offset), 0, Received_NotifyBegin_EventReference_PropertyAddress.Address, EventReference);
		NativeReflection.InvokeFunctionOptimized(base.Address, Received_NotifyBegin_InstanceFunctionAddress, intPtr, Received_NotifyBegin_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Received_NotifyBegin_EventReference_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Received_NotifyBegin_ReturnValue_Offset), 0, Received_NotifyBegin_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool Received_NotifyBegin_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration, FAnimNotifyEventReference EventReference)
	{
		CheckDestroyed();
		if (!Received_NotifyBegin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotifyState:Received_NotifyBegin");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Received_NotifyBegin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Received_NotifyBegin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, Received_NotifyBegin_MeshComp_Offset), 0, Received_NotifyBegin_MeshComp_PropertyAddress.Address, MeshComp);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, Received_NotifyBegin_Animation_Offset), 0, Received_NotifyBegin_Animation_PropertyAddress.Address, Animation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Received_NotifyBegin_TotalDuration_Offset), 0, Received_NotifyBegin_TotalDuration_PropertyAddress.Address, TotalDuration);
		NativeReflection.InitializeValue_InContainer(Received_NotifyBegin_EventReference_PropertyAddress.Address, intPtr);
		FAnimNotifyEventReference.ToNative(IntPtr.Add(intPtr, Received_NotifyBegin_EventReference_Offset), 0, Received_NotifyBegin_EventReference_PropertyAddress.Address, EventReference);
		NativeReflection.InvokeFunctionOptimized(base.Address, Received_NotifyBegin_FunctionAddress, intPtr, Received_NotifyBegin_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Received_NotifyBegin_EventReference_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Received_NotifyBegin_ReturnValue_Offset), 0, Received_NotifyBegin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/Engine.AnimNotifyState:GetNotifyName")]
	public unsafe string GetNotifyName()
	{
		CheckDestroyed();
		if (!GetNotifyName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotifyState:GetNotifyName");
			return FStringMarshaler.DefaultString;
		}
		if (GetNotifyName_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetNotifyName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetNotifyName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNotifyName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNotifyName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNotifyName_InstanceFunctionAddress, intPtr, GetNotifyName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetNotifyName_ReturnValue_Offset), 0, GetNotifyName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetNotifyName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetNotifyName_Implementation()
	{
		CheckDestroyed();
		if (!GetNotifyName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotifyState:GetNotifyName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNotifyName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNotifyName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNotifyName_FunctionAddress, intPtr, GetNotifyName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetNotifyName_ReturnValue_Offset), 0, GetNotifyName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetNotifyName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/Engine.AnimNotifyState:GetDefaultTriggerWeightThreshold")]
	public unsafe float GetDefaultTriggerWeightThreshold()
	{
		CheckDestroyed();
		if (!GetDefaultTriggerWeightThreshold_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotifyState:GetDefaultTriggerWeightThreshold");
			return 0f;
		}
		if (GetDefaultTriggerWeightThreshold_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetDefaultTriggerWeightThreshold_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetDefaultTriggerWeightThreshold");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultTriggerWeightThreshold_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultTriggerWeightThreshold_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultTriggerWeightThreshold_InstanceFunctionAddress, intPtr, GetDefaultTriggerWeightThreshold_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDefaultTriggerWeightThreshold_ReturnValue_Offset), 0, GetDefaultTriggerWeightThreshold_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual float GetDefaultTriggerWeightThreshold_Implementation()
	{
		CheckDestroyed();
		if (!GetDefaultTriggerWeightThreshold_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotifyState:GetDefaultTriggerWeightThreshold");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultTriggerWeightThreshold_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultTriggerWeightThreshold_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultTriggerWeightThreshold_FunctionAddress, intPtr, GetDefaultTriggerWeightThreshold_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDefaultTriggerWeightThreshold_ReturnValue_Offset), 0, GetDefaultTriggerWeightThreshold_ReturnValue_PropertyAddress.Address);
	}

	static UAnimNotifyState()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotifyState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotifyState));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.AnimNotifyState");
		NotifyColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotifyColor");
		NotifyColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotifyColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldFireInEditor_PropertyAddress, intPtr, "bShouldFireInEditor");
		ShouldFireInEditor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShouldFireInEditor");
		ShouldFireInEditor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShouldFireInEditor", Classes.FBoolProperty);
		Received_NotifyTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Received_NotifyTick");
		Received_NotifyTick_ParamsSize = NativeReflection.GetFunctionParamsSize(Received_NotifyTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Received_NotifyTick_MeshComp_PropertyAddress, Received_NotifyTick_FunctionAddress, "MeshComp");
		Received_NotifyTick_MeshComp_Offset = NativeReflectionCached.GetPropertyOffset(Received_NotifyTick_FunctionAddress, "MeshComp");
		Received_NotifyTick_MeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(Received_NotifyTick_FunctionAddress, "MeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Received_NotifyTick_Animation_PropertyAddress, Received_NotifyTick_FunctionAddress, "Animation");
		Received_NotifyTick_Animation_Offset = NativeReflectionCached.GetPropertyOffset(Received_NotifyTick_FunctionAddress, "Animation");
		Received_NotifyTick_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(Received_NotifyTick_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Received_NotifyTick_FrameDeltaTime_PropertyAddress, Received_NotifyTick_FunctionAddress, "FrameDeltaTime");
		Received_NotifyTick_FrameDeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(Received_NotifyTick_FunctionAddress, "FrameDeltaTime");
		Received_NotifyTick_FrameDeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(Received_NotifyTick_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Received_NotifyTick_EventReference_PropertyAddress, Received_NotifyTick_FunctionAddress, "EventReference");
		Received_NotifyTick_EventReference_Offset = NativeReflectionCached.GetPropertyOffset(Received_NotifyTick_FunctionAddress, "EventReference");
		Received_NotifyTick_EventReference_IsValid = NativeReflectionCached.ValidatePropertyClass(Received_NotifyTick_FunctionAddress, "EventReference", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Received_NotifyTick_ReturnValue_PropertyAddress, Received_NotifyTick_FunctionAddress, "ReturnValue");
		Received_NotifyTick_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Received_NotifyTick_FunctionAddress, "ReturnValue");
		Received_NotifyTick_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Received_NotifyTick_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Received_NotifyTick_IsValid = Received_NotifyTick_FunctionAddress != IntPtr.Zero && Received_NotifyTick_MeshComp_IsValid && Received_NotifyTick_Animation_IsValid && Received_NotifyTick_FrameDeltaTime_IsValid && Received_NotifyTick_EventReference_IsValid && Received_NotifyTick_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimNotifyState:Received_NotifyTick", Received_NotifyTick_IsValid);
		Received_NotifyEnd_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Received_NotifyEnd");
		Received_NotifyEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(Received_NotifyEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Received_NotifyEnd_MeshComp_PropertyAddress, Received_NotifyEnd_FunctionAddress, "MeshComp");
		Received_NotifyEnd_MeshComp_Offset = NativeReflectionCached.GetPropertyOffset(Received_NotifyEnd_FunctionAddress, "MeshComp");
		Received_NotifyEnd_MeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(Received_NotifyEnd_FunctionAddress, "MeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Received_NotifyEnd_Animation_PropertyAddress, Received_NotifyEnd_FunctionAddress, "Animation");
		Received_NotifyEnd_Animation_Offset = NativeReflectionCached.GetPropertyOffset(Received_NotifyEnd_FunctionAddress, "Animation");
		Received_NotifyEnd_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(Received_NotifyEnd_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Received_NotifyEnd_EventReference_PropertyAddress, Received_NotifyEnd_FunctionAddress, "EventReference");
		Received_NotifyEnd_EventReference_Offset = NativeReflectionCached.GetPropertyOffset(Received_NotifyEnd_FunctionAddress, "EventReference");
		Received_NotifyEnd_EventReference_IsValid = NativeReflectionCached.ValidatePropertyClass(Received_NotifyEnd_FunctionAddress, "EventReference", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Received_NotifyEnd_ReturnValue_PropertyAddress, Received_NotifyEnd_FunctionAddress, "ReturnValue");
		Received_NotifyEnd_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Received_NotifyEnd_FunctionAddress, "ReturnValue");
		Received_NotifyEnd_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Received_NotifyEnd_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Received_NotifyEnd_IsValid = Received_NotifyEnd_FunctionAddress != IntPtr.Zero && Received_NotifyEnd_MeshComp_IsValid && Received_NotifyEnd_Animation_IsValid && Received_NotifyEnd_EventReference_IsValid && Received_NotifyEnd_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimNotifyState:Received_NotifyEnd", Received_NotifyEnd_IsValid);
		Received_NotifyBegin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Received_NotifyBegin");
		Received_NotifyBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(Received_NotifyBegin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Received_NotifyBegin_MeshComp_PropertyAddress, Received_NotifyBegin_FunctionAddress, "MeshComp");
		Received_NotifyBegin_MeshComp_Offset = NativeReflectionCached.GetPropertyOffset(Received_NotifyBegin_FunctionAddress, "MeshComp");
		Received_NotifyBegin_MeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(Received_NotifyBegin_FunctionAddress, "MeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Received_NotifyBegin_Animation_PropertyAddress, Received_NotifyBegin_FunctionAddress, "Animation");
		Received_NotifyBegin_Animation_Offset = NativeReflectionCached.GetPropertyOffset(Received_NotifyBegin_FunctionAddress, "Animation");
		Received_NotifyBegin_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(Received_NotifyBegin_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Received_NotifyBegin_TotalDuration_PropertyAddress, Received_NotifyBegin_FunctionAddress, "TotalDuration");
		Received_NotifyBegin_TotalDuration_Offset = NativeReflectionCached.GetPropertyOffset(Received_NotifyBegin_FunctionAddress, "TotalDuration");
		Received_NotifyBegin_TotalDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(Received_NotifyBegin_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Received_NotifyBegin_EventReference_PropertyAddress, Received_NotifyBegin_FunctionAddress, "EventReference");
		Received_NotifyBegin_EventReference_Offset = NativeReflectionCached.GetPropertyOffset(Received_NotifyBegin_FunctionAddress, "EventReference");
		Received_NotifyBegin_EventReference_IsValid = NativeReflectionCached.ValidatePropertyClass(Received_NotifyBegin_FunctionAddress, "EventReference", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Received_NotifyBegin_ReturnValue_PropertyAddress, Received_NotifyBegin_FunctionAddress, "ReturnValue");
		Received_NotifyBegin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Received_NotifyBegin_FunctionAddress, "ReturnValue");
		Received_NotifyBegin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Received_NotifyBegin_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Received_NotifyBegin_IsValid = Received_NotifyBegin_FunctionAddress != IntPtr.Zero && Received_NotifyBegin_MeshComp_IsValid && Received_NotifyBegin_Animation_IsValid && Received_NotifyBegin_TotalDuration_IsValid && Received_NotifyBegin_EventReference_IsValid && Received_NotifyBegin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimNotifyState:Received_NotifyBegin", Received_NotifyBegin_IsValid);
		GetNotifyName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNotifyName");
		GetNotifyName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNotifyName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNotifyName_ReturnValue_PropertyAddress, GetNotifyName_FunctionAddress, "ReturnValue");
		GetNotifyName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNotifyName_FunctionAddress, "ReturnValue");
		GetNotifyName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNotifyName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNotifyName_IsValid = GetNotifyName_FunctionAddress != IntPtr.Zero && GetNotifyName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimNotifyState:GetNotifyName", GetNotifyName_IsValid);
		GetDefaultTriggerWeightThreshold_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDefaultTriggerWeightThreshold");
		GetDefaultTriggerWeightThreshold_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultTriggerWeightThreshold_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultTriggerWeightThreshold_ReturnValue_PropertyAddress, GetDefaultTriggerWeightThreshold_FunctionAddress, "ReturnValue");
		GetDefaultTriggerWeightThreshold_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultTriggerWeightThreshold_FunctionAddress, "ReturnValue");
		GetDefaultTriggerWeightThreshold_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultTriggerWeightThreshold_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDefaultTriggerWeightThreshold_IsValid = GetDefaultTriggerWeightThreshold_FunctionAddress != IntPtr.Zero && GetDefaultTriggerWeightThreshold_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimNotifyState:GetDefaultTriggerWeightThreshold", GetDefaultTriggerWeightThreshold_IsValid);
	}
}
