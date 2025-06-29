using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)810623137uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.AnimNotify", "Engine", UnrealModuleType.Engine)]
public class UAnimNotify : UObject
{
	private static bool NotifyColor_IsValid;

	private static int NotifyColor_Offset;

	private static bool ShouldFireInEditor_IsValid;

	private static FFieldAddress ShouldFireInEditor_PropertyAddress;

	private static int ShouldFireInEditor_Offset;

	private static bool Received_Notify_IsValid;

	private IntPtr Received_Notify_InstanceFunctionAddress;

	private static IntPtr Received_Notify_FunctionAddress;

	private static int Received_Notify_ParamsSize;

	private static bool Received_Notify_MeshComp_IsValid;

	private static FFieldAddress Received_Notify_MeshComp_PropertyAddress;

	private static int Received_Notify_MeshComp_Offset;

	private static bool Received_Notify_Animation_IsValid;

	private static FFieldAddress Received_Notify_Animation_PropertyAddress;

	private static int Received_Notify_Animation_Offset;

	private static bool Received_Notify_EventReference_IsValid;

	private static FFieldAddress Received_Notify_EventReference_PropertyAddress;

	private static int Received_Notify_EventReference_Offset;

	private static bool Received_Notify_ReturnValue_IsValid;

	private static FFieldAddress Received_Notify_ReturnValue_PropertyAddress;

	private static int Received_Notify_ReturnValue_Offset;

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
	[UMetaPath("/Script/Engine.AnimNotify:NotifyColor")]
	public FColor NotifyColor
	{
		get
		{
			CheckDestroyed();
			if (!NotifyColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify:NotifyColor");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, NotifyColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify:NotifyColor");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, NotifyColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759901640524309uL)]
	[UMetaPath("/Script/Engine.AnimNotify:bShouldFireInEditor")]
	public bool ShouldFireInEditor
	{
		get
		{
			CheckDestroyed();
			if (!ShouldFireInEditor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify:bShouldFireInEditor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShouldFireInEditor_Offset), 0, ShouldFireInEditor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShouldFireInEditor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify:bShouldFireInEditor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShouldFireInEditor_Offset), 0, ShouldFireInEditor_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/Engine.AnimNotify:Received_Notify")]
	public unsafe bool Received_Notify(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, FAnimNotifyEventReference EventReference)
	{
		CheckDestroyed();
		if (!Received_Notify_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotify:Received_Notify");
			return false;
		}
		if (Received_Notify_InstanceFunctionAddress == IntPtr.Zero)
		{
			Received_Notify_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Received_Notify");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Received_Notify_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Received_Notify_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, Received_Notify_MeshComp_Offset), 0, Received_Notify_MeshComp_PropertyAddress.Address, MeshComp);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, Received_Notify_Animation_Offset), 0, Received_Notify_Animation_PropertyAddress.Address, Animation);
		NativeReflection.InitializeValue_InContainer(Received_Notify_EventReference_PropertyAddress.Address, intPtr);
		FAnimNotifyEventReference.ToNative(IntPtr.Add(intPtr, Received_Notify_EventReference_Offset), 0, Received_Notify_EventReference_PropertyAddress.Address, EventReference);
		NativeReflection.InvokeFunctionOptimized(base.Address, Received_Notify_InstanceFunctionAddress, intPtr, Received_Notify_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Received_Notify_EventReference_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Received_Notify_ReturnValue_Offset), 0, Received_Notify_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool Received_Notify_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, FAnimNotifyEventReference EventReference)
	{
		CheckDestroyed();
		if (!Received_Notify_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotify:Received_Notify");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Received_Notify_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Received_Notify_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, Received_Notify_MeshComp_Offset), 0, Received_Notify_MeshComp_PropertyAddress.Address, MeshComp);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, Received_Notify_Animation_Offset), 0, Received_Notify_Animation_PropertyAddress.Address, Animation);
		NativeReflection.InitializeValue_InContainer(Received_Notify_EventReference_PropertyAddress.Address, intPtr);
		FAnimNotifyEventReference.ToNative(IntPtr.Add(intPtr, Received_Notify_EventReference_Offset), 0, Received_Notify_EventReference_PropertyAddress.Address, EventReference);
		NativeReflection.InvokeFunctionOptimized(base.Address, Received_Notify_FunctionAddress, intPtr, Received_Notify_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Received_Notify_EventReference_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Received_Notify_ReturnValue_Offset), 0, Received_Notify_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/Engine.AnimNotify:GetNotifyName")]
	public unsafe string GetNotifyName()
	{
		CheckDestroyed();
		if (!GetNotifyName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotify:GetNotifyName");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotify:GetNotifyName");
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
	[UMetaPath("/Script/Engine.AnimNotify:GetDefaultTriggerWeightThreshold")]
	public unsafe float GetDefaultTriggerWeightThreshold()
	{
		CheckDestroyed();
		if (!GetDefaultTriggerWeightThreshold_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotify:GetDefaultTriggerWeightThreshold");
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
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AnimNotify:GetDefaultTriggerWeightThreshold");
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

	static UAnimNotify()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotify)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotify));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.AnimNotify");
		NotifyColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotifyColor");
		NotifyColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotifyColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldFireInEditor_PropertyAddress, intPtr, "bShouldFireInEditor");
		ShouldFireInEditor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShouldFireInEditor");
		ShouldFireInEditor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShouldFireInEditor", Classes.FBoolProperty);
		Received_Notify_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Received_Notify");
		Received_Notify_ParamsSize = NativeReflection.GetFunctionParamsSize(Received_Notify_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Received_Notify_MeshComp_PropertyAddress, Received_Notify_FunctionAddress, "MeshComp");
		Received_Notify_MeshComp_Offset = NativeReflectionCached.GetPropertyOffset(Received_Notify_FunctionAddress, "MeshComp");
		Received_Notify_MeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(Received_Notify_FunctionAddress, "MeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Received_Notify_Animation_PropertyAddress, Received_Notify_FunctionAddress, "Animation");
		Received_Notify_Animation_Offset = NativeReflectionCached.GetPropertyOffset(Received_Notify_FunctionAddress, "Animation");
		Received_Notify_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(Received_Notify_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Received_Notify_EventReference_PropertyAddress, Received_Notify_FunctionAddress, "EventReference");
		Received_Notify_EventReference_Offset = NativeReflectionCached.GetPropertyOffset(Received_Notify_FunctionAddress, "EventReference");
		Received_Notify_EventReference_IsValid = NativeReflectionCached.ValidatePropertyClass(Received_Notify_FunctionAddress, "EventReference", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Received_Notify_ReturnValue_PropertyAddress, Received_Notify_FunctionAddress, "ReturnValue");
		Received_Notify_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Received_Notify_FunctionAddress, "ReturnValue");
		Received_Notify_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Received_Notify_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Received_Notify_IsValid = Received_Notify_FunctionAddress != IntPtr.Zero && Received_Notify_MeshComp_IsValid && Received_Notify_Animation_IsValid && Received_Notify_EventReference_IsValid && Received_Notify_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimNotify:Received_Notify", Received_Notify_IsValid);
		GetNotifyName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNotifyName");
		GetNotifyName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNotifyName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNotifyName_ReturnValue_PropertyAddress, GetNotifyName_FunctionAddress, "ReturnValue");
		GetNotifyName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNotifyName_FunctionAddress, "ReturnValue");
		GetNotifyName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNotifyName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNotifyName_IsValid = GetNotifyName_FunctionAddress != IntPtr.Zero && GetNotifyName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimNotify:GetNotifyName", GetNotifyName_IsValid);
		GetDefaultTriggerWeightThreshold_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDefaultTriggerWeightThreshold");
		GetDefaultTriggerWeightThreshold_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultTriggerWeightThreshold_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultTriggerWeightThreshold_ReturnValue_PropertyAddress, GetDefaultTriggerWeightThreshold_FunctionAddress, "ReturnValue");
		GetDefaultTriggerWeightThreshold_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultTriggerWeightThreshold_FunctionAddress, "ReturnValue");
		GetDefaultTriggerWeightThreshold_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultTriggerWeightThreshold_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDefaultTriggerWeightThreshold_IsValid = GetDefaultTriggerWeightThreshold_FunctionAddress != IntPtr.Zero && GetDefaultTriggerWeightThreshold_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AnimNotify:GetDefaultTriggerWeightThreshold", GetDefaultTriggerWeightThreshold_IsValid);
	}
}
