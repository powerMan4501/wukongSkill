using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.IKRig;

public sealed class IKGoalCreatorInterfaceImpl : IInterfaceImpl, IKGoalCreatorInterface, IInterface
{
	private static bool AddIKGoals_IsValid;

	private IntPtr AddIKGoals_InstanceFunctionAddress;

	private static IntPtr AddIKGoals_FunctionAddress;

	private static int AddIKGoals_ParamsSize;

	private static bool AddIKGoals_OutGoals_IsValid;

	private static FFieldAddress AddIKGoals_OutGoals_PropertyAddress;

	private static int AddIKGoals_OutGoals_Offset;

	[UFunction(Flags = 205655040u)]
	[UMetaPath("/Script/IKRig.IKGoalCreatorInterface:AddIKGoals")]
	public unsafe void AddIKGoals(out Dictionary<FName, FIKRigGoal> OutGoals)
	{
		CheckDestroyed();
		if (!AddIKGoals_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IKRig.IKGoalCreatorInterface:AddIKGoals");
			OutGoals = null;
			return;
		}
		if (AddIKGoals_InstanceFunctionAddress == IntPtr.Zero)
		{
			AddIKGoals_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "AddIKGoals");
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddIKGoals_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddIKGoals_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddIKGoals_OutGoals_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddIKGoals_InstanceFunctionAddress, intPtr, AddIKGoals_ParamsSize);
		OutGoals = new TMapCopyMarshaler<FName, FIKRigGoal>(1, AddIKGoals_OutGoals_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FIKRigGoal, FIKRigGoal>.FromNative, CachedMarshalingDelegates<FIKRigGoal, FIKRigGoal>.ToNative).FromNative(IntPtr.Add(intPtr, AddIKGoals_OutGoals_Offset));
		NativeReflection.DestroyValue_InContainer(AddIKGoals_OutGoals_PropertyAddress.Address, intPtr);
	}

	public override void ResetInterface()
	{
		AddIKGoals_InstanceFunctionAddress = IntPtr.Zero;
	}

	static IKGoalCreatorInterfaceImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IKGoalCreatorInterfaceImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IKGoalCreatorInterfaceImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/IKRig.IKGoalCreatorInterface");
		AddIKGoals_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddIKGoals");
		AddIKGoals_ParamsSize = NativeReflection.GetFunctionParamsSize(AddIKGoals_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddIKGoals_OutGoals_PropertyAddress, AddIKGoals_FunctionAddress, "OutGoals");
		AddIKGoals_OutGoals_Offset = NativeReflectionCached.GetPropertyOffset(AddIKGoals_FunctionAddress, "OutGoals");
		AddIKGoals_OutGoals_IsValid = NativeReflectionCached.ValidatePropertyClass(AddIKGoals_FunctionAddress, "OutGoals", Classes.FMapProperty);
		AddIKGoals_IsValid = AddIKGoals_FunctionAddress != IntPtr.Zero && AddIKGoals_OutGoals_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/IKRig.IKGoalCreatorInterface:AddIKGoals", AddIKGoals_IsValid);
	}
}
