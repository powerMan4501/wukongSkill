using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.DonAINavigation;

public sealed class IDonNavigatorImpl : IInterfaceImpl, IDonNavigator, IInterface
{
	private static bool OnNextSegment_IsValid;

	private IntPtr OnNextSegment_InstanceFunctionAddress;

	private static IntPtr OnNextSegment_FunctionAddress;

	private static int OnNextSegment_ParamsSize;

	private static bool OnNextSegment_NextPoint_IsValid;

	private static FFieldAddress OnNextSegment_NextPoint_PropertyAddress;

	private static int OnNextSegment_NextPoint_Offset;

	private static bool OnLocomotionEnd_IsValid;

	private IntPtr OnLocomotionEnd_InstanceFunctionAddress;

	private static IntPtr OnLocomotionEnd_FunctionAddress;

	private static int OnLocomotionEnd_ParamsSize;

	private static bool OnLocomotionEnd_bLocomotionSuccess_IsValid;

	private static FFieldAddress OnLocomotionEnd_bLocomotionSuccess_PropertyAddress;

	private static int OnLocomotionEnd_bLocomotionSuccess_Offset;

	private static bool OnLocomotionBegin_IsValid;

	private IntPtr OnLocomotionBegin_InstanceFunctionAddress;

	private static IntPtr OnLocomotionBegin_FunctionAddress;

	private static int OnLocomotionBegin_ParamsSize;

	private static bool OnLocomotionAbort_IsValid;

	private IntPtr OnLocomotionAbort_InstanceFunctionAddress;

	private static IntPtr OnLocomotionAbort_FunctionAddress;

	private static int OnLocomotionAbort_ParamsSize;

	private static bool AddMovementInputCustom_IsValid;

	private IntPtr AddMovementInputCustom_InstanceFunctionAddress;

	private static IntPtr AddMovementInputCustom_FunctionAddress;

	private static int AddMovementInputCustom_ParamsSize;

	private static bool AddMovementInputCustom_WorldDirection_IsValid;

	private static FFieldAddress AddMovementInputCustom_WorldDirection_PropertyAddress;

	private static int AddMovementInputCustom_WorldDirection_Offset;

	private static bool AddMovementInputCustom_ScaleValue_IsValid;

	private static FFieldAddress AddMovementInputCustom_ScaleValue_PropertyAddress;

	private static int AddMovementInputCustom_ScaleValue_Offset;

	[UFunction(Flags = 209849344u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigator:OnNextSegment")]
	public unsafe void OnNextSegment(FVector NextPoint)
	{
		CheckDestroyed();
		if (!OnNextSegment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigator:OnNextSegment");
			return;
		}
		if (OnNextSegment_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnNextSegment_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnNextSegment");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnNextSegment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNextSegment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnNextSegment_NextPoint_Offset), 0, OnNextSegment_NextPoint_PropertyAddress.Address, NextPoint);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnNextSegment_InstanceFunctionAddress, intPtr, OnNextSegment_ParamsSize);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigator:OnLocomotionEnd")]
	public unsafe void OnLocomotionEnd(bool bLocomotionSuccess)
	{
		CheckDestroyed();
		if (!OnLocomotionEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigator:OnLocomotionEnd");
			return;
		}
		if (OnLocomotionEnd_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnLocomotionEnd_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnLocomotionEnd");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnLocomotionEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLocomotionEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnLocomotionEnd_bLocomotionSuccess_Offset), 0, OnLocomotionEnd_bLocomotionSuccess_PropertyAddress.Address, bLocomotionSuccess);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnLocomotionEnd_InstanceFunctionAddress, intPtr, OnLocomotionEnd_ParamsSize);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigator:OnLocomotionBegin")]
	public unsafe void OnLocomotionBegin()
	{
		CheckDestroyed();
		if (!OnLocomotionBegin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigator:OnLocomotionBegin");
			return;
		}
		if (OnLocomotionBegin_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnLocomotionBegin_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnLocomotionBegin");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnLocomotionBegin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLocomotionBegin_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnLocomotionBegin_InstanceFunctionAddress, argsSize: OnLocomotionBegin_ParamsSize);
	}

	[UFunction(Flags = 201460736u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigator:OnLocomotionAbort")]
	public unsafe void OnLocomotionAbort()
	{
		CheckDestroyed();
		if (!OnLocomotionAbort_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigator:OnLocomotionAbort");
			return;
		}
		if (OnLocomotionAbort_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnLocomotionAbort_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnLocomotionAbort");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnLocomotionAbort_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLocomotionAbort_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnLocomotionAbort_InstanceFunctionAddress, argsSize: OnLocomotionAbort_ParamsSize);
	}

	[UFunction(Flags = 209849344u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigator:AddMovementInputCustom")]
	public unsafe void AddMovementInputCustom(FVector WorldDirection, float ScaleValue)
	{
		CheckDestroyed();
		if (!AddMovementInputCustom_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigator:AddMovementInputCustom");
			return;
		}
		if (AddMovementInputCustom_InstanceFunctionAddress == IntPtr.Zero)
		{
			AddMovementInputCustom_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "AddMovementInputCustom");
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMovementInputCustom_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMovementInputCustom_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddMovementInputCustom_WorldDirection_Offset), 0, AddMovementInputCustom_WorldDirection_PropertyAddress.Address, WorldDirection);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddMovementInputCustom_ScaleValue_Offset), 0, AddMovementInputCustom_ScaleValue_PropertyAddress.Address, ScaleValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddMovementInputCustom_InstanceFunctionAddress, intPtr, AddMovementInputCustom_ParamsSize);
	}

	public override void ResetInterface()
	{
		OnNextSegment_InstanceFunctionAddress = IntPtr.Zero;
		OnLocomotionEnd_InstanceFunctionAddress = IntPtr.Zero;
		OnLocomotionBegin_InstanceFunctionAddress = IntPtr.Zero;
		OnLocomotionAbort_InstanceFunctionAddress = IntPtr.Zero;
		AddMovementInputCustom_InstanceFunctionAddress = IntPtr.Zero;
	}

	static IDonNavigatorImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IDonNavigatorImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IDonNavigatorImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/DonAINavigation.DonNavigator");
		OnNextSegment_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnNextSegment");
		OnNextSegment_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNextSegment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnNextSegment_NextPoint_PropertyAddress, OnNextSegment_FunctionAddress, "NextPoint");
		OnNextSegment_NextPoint_Offset = NativeReflectionCached.GetPropertyOffset(OnNextSegment_FunctionAddress, "NextPoint");
		OnNextSegment_NextPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNextSegment_FunctionAddress, "NextPoint", Classes.FStructProperty);
		OnNextSegment_IsValid = OnNextSegment_FunctionAddress != IntPtr.Zero && OnNextSegment_NextPoint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigator:OnNextSegment", OnNextSegment_IsValid);
		OnLocomotionEnd_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnLocomotionEnd");
		OnLocomotionEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLocomotionEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnLocomotionEnd_bLocomotionSuccess_PropertyAddress, OnLocomotionEnd_FunctionAddress, "bLocomotionSuccess");
		OnLocomotionEnd_bLocomotionSuccess_Offset = NativeReflectionCached.GetPropertyOffset(OnLocomotionEnd_FunctionAddress, "bLocomotionSuccess");
		OnLocomotionEnd_bLocomotionSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLocomotionEnd_FunctionAddress, "bLocomotionSuccess", Classes.FBoolProperty);
		OnLocomotionEnd_IsValid = OnLocomotionEnd_FunctionAddress != IntPtr.Zero && OnLocomotionEnd_bLocomotionSuccess_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigator:OnLocomotionEnd", OnLocomotionEnd_IsValid);
		OnLocomotionBegin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnLocomotionBegin");
		OnLocomotionBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLocomotionBegin_FunctionAddress);
		OnLocomotionBegin_IsValid = OnLocomotionBegin_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigator:OnLocomotionBegin", OnLocomotionBegin_IsValid);
		OnLocomotionAbort_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnLocomotionAbort");
		OnLocomotionAbort_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLocomotionAbort_FunctionAddress);
		OnLocomotionAbort_IsValid = OnLocomotionAbort_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigator:OnLocomotionAbort", OnLocomotionAbort_IsValid);
		AddMovementInputCustom_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddMovementInputCustom");
		AddMovementInputCustom_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMovementInputCustom_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMovementInputCustom_WorldDirection_PropertyAddress, AddMovementInputCustom_FunctionAddress, "WorldDirection");
		AddMovementInputCustom_WorldDirection_Offset = NativeReflectionCached.GetPropertyOffset(AddMovementInputCustom_FunctionAddress, "WorldDirection");
		AddMovementInputCustom_WorldDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMovementInputCustom_FunctionAddress, "WorldDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMovementInputCustom_ScaleValue_PropertyAddress, AddMovementInputCustom_FunctionAddress, "ScaleValue");
		AddMovementInputCustom_ScaleValue_Offset = NativeReflectionCached.GetPropertyOffset(AddMovementInputCustom_FunctionAddress, "ScaleValue");
		AddMovementInputCustom_ScaleValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMovementInputCustom_FunctionAddress, "ScaleValue", Classes.FFloatProperty);
		AddMovementInputCustom_IsValid = AddMovementInputCustom_FunctionAddress != IntPtr.Zero && AddMovementInputCustom_WorldDirection_IsValid && AddMovementInputCustom_ScaleValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigator:AddMovementInputCustom", AddMovementInputCustom_IsValid);
	}
}
