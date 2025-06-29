using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationModifiers;

[UClass(Flags = (ClassFlags)810549414uL, Config = "Editor")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AnimationModifiers.AnimationModifier", "AnimationModifiers", UnrealModuleType.Engine)]
public class UAnimationModifier : UObject
{
	private static bool OnRevert_IsValid;

	private IntPtr OnRevert_InstanceFunctionAddress;

	private static IntPtr OnRevert_FunctionAddress;

	private static int OnRevert_ParamsSize;

	private static bool OnRevert_AnimationSequence_IsValid;

	private static FFieldAddress OnRevert_AnimationSequence_PropertyAddress;

	private static int OnRevert_AnimationSequence_Offset;

	private static bool OnApply_IsValid;

	private IntPtr OnApply_InstanceFunctionAddress;

	private static IntPtr OnApply_FunctionAddress;

	private static int OnApply_ParamsSize;

	private static bool OnApply_AnimationSequence_IsValid;

	private static FFieldAddress OnApply_AnimationSequence_PropertyAddress;

	private static int OnApply_AnimationSequence_Offset;

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/AnimationModifiers.AnimationModifier:OnRevert")]
	public unsafe void OnRevert(UAnimSequence AnimationSequence)
	{
		CheckDestroyed();
		if (!OnRevert_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationModifiers.AnimationModifier:OnRevert");
			return;
		}
		if (OnRevert_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnRevert_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnRevert");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRevert_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRevert_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, OnRevert_AnimationSequence_Offset), 0, OnRevert_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnRevert_InstanceFunctionAddress, intPtr, OnRevert_ParamsSize);
	}

	protected unsafe virtual void OnRevert_Implementation(UAnimSequence AnimationSequence)
	{
		CheckDestroyed();
		if (!OnRevert_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationModifiers.AnimationModifier:OnRevert");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRevert_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRevert_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, OnRevert_AnimationSequence_Offset), 0, OnRevert_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnRevert_FunctionAddress, intPtr, OnRevert_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/AnimationModifiers.AnimationModifier:OnApply")]
	public unsafe void OnApply(UAnimSequence AnimationSequence)
	{
		CheckDestroyed();
		if (!OnApply_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationModifiers.AnimationModifier:OnApply");
			return;
		}
		if (OnApply_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnApply_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnApply");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApply_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApply_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, OnApply_AnimationSequence_Offset), 0, OnApply_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnApply_InstanceFunctionAddress, intPtr, OnApply_ParamsSize);
	}

	protected unsafe virtual void OnApply_Implementation(UAnimSequence AnimationSequence)
	{
		CheckDestroyed();
		if (!OnApply_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimationModifiers.AnimationModifier:OnApply");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApply_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApply_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, OnApply_AnimationSequence_Offset), 0, OnApply_AnimationSequence_PropertyAddress.Address, AnimationSequence);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnApply_FunctionAddress, intPtr, OnApply_ParamsSize);
	}

	static UAnimationModifier()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimationModifier)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimationModifier));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AnimationModifiers.AnimationModifier");
		OnRevert_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnRevert");
		OnRevert_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRevert_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnRevert_AnimationSequence_PropertyAddress, OnRevert_FunctionAddress, "AnimationSequence");
		OnRevert_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(OnRevert_FunctionAddress, "AnimationSequence");
		OnRevert_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(OnRevert_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		OnRevert_IsValid = OnRevert_FunctionAddress != IntPtr.Zero && OnRevert_AnimationSequence_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationModifiers.AnimationModifier:OnRevert", OnRevert_IsValid);
		OnApply_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnApply");
		OnApply_ParamsSize = NativeReflection.GetFunctionParamsSize(OnApply_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnApply_AnimationSequence_PropertyAddress, OnApply_FunctionAddress, "AnimationSequence");
		OnApply_AnimationSequence_Offset = NativeReflectionCached.GetPropertyOffset(OnApply_FunctionAddress, "AnimationSequence");
		OnApply_AnimationSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(OnApply_FunctionAddress, "AnimationSequence", Classes.FObjectProperty);
		OnApply_IsValid = OnApply_FunctionAddress != IntPtr.Zero && OnApply_AnimationSequence_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimationModifiers.AnimationModifier:OnApply", OnApply_IsValid);
	}
}
