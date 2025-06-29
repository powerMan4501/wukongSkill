using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.IKRig;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/IKRig.IKRigComponent", "IKRig", UnrealModuleType.EnginePlugin)]
public class UIKRigComponent : UActorComponent, IKGoalCreatorInterface, IInterface
{
	private static bool SetIKRigGoalTransform_IsValid;

	private static IntPtr SetIKRigGoalTransform_FunctionAddress;

	private static int SetIKRigGoalTransform_ParamsSize;

	private static bool SetIKRigGoalTransform_GoalName_IsValid;

	private static FFieldAddress SetIKRigGoalTransform_GoalName_PropertyAddress;

	private static int SetIKRigGoalTransform_GoalName_Offset;

	private static bool SetIKRigGoalTransform_Transform_IsValid;

	private static FFieldAddress SetIKRigGoalTransform_Transform_PropertyAddress;

	private static int SetIKRigGoalTransform_Transform_Offset;

	private static bool SetIKRigGoalTransform_PositionAlpha_IsValid;

	private static FFieldAddress SetIKRigGoalTransform_PositionAlpha_PropertyAddress;

	private static int SetIKRigGoalTransform_PositionAlpha_Offset;

	private static bool SetIKRigGoalTransform_RotationAlpha_IsValid;

	private static FFieldAddress SetIKRigGoalTransform_RotationAlpha_PropertyAddress;

	private static int SetIKRigGoalTransform_RotationAlpha_Offset;

	private static bool SetIKRigGoalPositionAndRotation_IsValid;

	private static IntPtr SetIKRigGoalPositionAndRotation_FunctionAddress;

	private static int SetIKRigGoalPositionAndRotation_ParamsSize;

	private static bool SetIKRigGoalPositionAndRotation_GoalName_IsValid;

	private static FFieldAddress SetIKRigGoalPositionAndRotation_GoalName_PropertyAddress;

	private static int SetIKRigGoalPositionAndRotation_GoalName_Offset;

	private static bool SetIKRigGoalPositionAndRotation_Position_IsValid;

	private static FFieldAddress SetIKRigGoalPositionAndRotation_Position_PropertyAddress;

	private static int SetIKRigGoalPositionAndRotation_Position_Offset;

	private static bool SetIKRigGoalPositionAndRotation_Rotation_IsValid;

	private static FFieldAddress SetIKRigGoalPositionAndRotation_Rotation_PropertyAddress;

	private static int SetIKRigGoalPositionAndRotation_Rotation_Offset;

	private static bool SetIKRigGoalPositionAndRotation_PositionAlpha_IsValid;

	private static FFieldAddress SetIKRigGoalPositionAndRotation_PositionAlpha_PropertyAddress;

	private static int SetIKRigGoalPositionAndRotation_PositionAlpha_Offset;

	private static bool SetIKRigGoalPositionAndRotation_RotationAlpha_IsValid;

	private static FFieldAddress SetIKRigGoalPositionAndRotation_RotationAlpha_PropertyAddress;

	private static int SetIKRigGoalPositionAndRotation_RotationAlpha_Offset;

	private static bool SetIKRigGoal_IsValid;

	private static IntPtr SetIKRigGoal_FunctionAddress;

	private static int SetIKRigGoal_ParamsSize;

	private static bool SetIKRigGoal_Goal_IsValid;

	private static FFieldAddress SetIKRigGoal_Goal_PropertyAddress;

	private static int SetIKRigGoal_Goal_Offset;

	private static bool ClearAllGoals_IsValid;

	private static IntPtr ClearAllGoals_FunctionAddress;

	private static int ClearAllGoals_ParamsSize;

	private static bool AddIKGoals_IsValid;

	private IntPtr AddIKGoals_InstanceFunctionAddress;

	private static IntPtr AddIKGoals_FunctionAddress;

	private static int AddIKGoals_ParamsSize;

	private static bool AddIKGoals_OutGoals_IsValid;

	private static FFieldAddress AddIKGoals_OutGoals_PropertyAddress;

	private static int AddIKGoals_OutGoals_Offset;

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/IKRig.IKRigComponent:SetIKRigGoalTransform")]
	public unsafe void SetIKRigGoalTransform(FName GoalName, FTransform Transform, float PositionAlpha, float RotationAlpha)
	{
		CheckDestroyed();
		if (!SetIKRigGoalTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IKRig.IKRigComponent:SetIKRigGoalTransform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIKRigGoalTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIKRigGoalTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetIKRigGoalTransform_GoalName_Offset), 0, SetIKRigGoalTransform_GoalName_PropertyAddress.Address, GoalName);
		NativeReflection.InitializeValue_InContainer(SetIKRigGoalTransform_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetIKRigGoalTransform_Transform_Offset), 0, SetIKRigGoalTransform_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetIKRigGoalTransform_PositionAlpha_Offset), 0, SetIKRigGoalTransform_PositionAlpha_PropertyAddress.Address, PositionAlpha);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetIKRigGoalTransform_RotationAlpha_Offset), 0, SetIKRigGoalTransform_RotationAlpha_PropertyAddress.Address, RotationAlpha);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIKRigGoalTransform_FunctionAddress, intPtr, SetIKRigGoalTransform_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/IKRig.IKRigComponent:SetIKRigGoalPositionAndRotation")]
	public unsafe void SetIKRigGoalPositionAndRotation(FName GoalName, FVector Position, FQuat Rotation, float PositionAlpha, float RotationAlpha)
	{
		CheckDestroyed();
		if (!SetIKRigGoalPositionAndRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IKRig.IKRigComponent:SetIKRigGoalPositionAndRotation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIKRigGoalPositionAndRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIKRigGoalPositionAndRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetIKRigGoalPositionAndRotation_GoalName_Offset), 0, SetIKRigGoalPositionAndRotation_GoalName_PropertyAddress.Address, GoalName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetIKRigGoalPositionAndRotation_Position_Offset), 0, SetIKRigGoalPositionAndRotation_Position_PropertyAddress.Address, Position);
		NativeReflection.InitializeValue_InContainer(SetIKRigGoalPositionAndRotation_Rotation_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(intPtr, SetIKRigGoalPositionAndRotation_Rotation_Offset), 0, SetIKRigGoalPositionAndRotation_Rotation_PropertyAddress.Address, Rotation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetIKRigGoalPositionAndRotation_PositionAlpha_Offset), 0, SetIKRigGoalPositionAndRotation_PositionAlpha_PropertyAddress.Address, PositionAlpha);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetIKRigGoalPositionAndRotation_RotationAlpha_Offset), 0, SetIKRigGoalPositionAndRotation_RotationAlpha_PropertyAddress.Address, RotationAlpha);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIKRigGoalPositionAndRotation_FunctionAddress, intPtr, SetIKRigGoalPositionAndRotation_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/IKRig.IKRigComponent:SetIKRigGoal")]
	public unsafe void SetIKRigGoal(FIKRigGoal Goal)
	{
		CheckDestroyed();
		if (!SetIKRigGoal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IKRig.IKRigComponent:SetIKRigGoal");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIKRigGoal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIKRigGoal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetIKRigGoal_Goal_PropertyAddress.Address, intPtr);
		FIKRigGoal.ToNative(IntPtr.Add(intPtr, SetIKRigGoal_Goal_Offset), 0, SetIKRigGoal_Goal_PropertyAddress.Address, Goal);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIKRigGoal_FunctionAddress, intPtr, SetIKRigGoal_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/IKRig.IKRigComponent:ClearAllGoals")]
	public unsafe void ClearAllGoals()
	{
		CheckDestroyed();
		if (!ClearAllGoals_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IKRig.IKRigComponent:ClearAllGoals");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearAllGoals_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearAllGoals_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearAllGoals_FunctionAddress, argsSize: ClearAllGoals_ParamsSize);
	}

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

	protected unsafe void AddIKGoals_Implementation(out Dictionary<FName, FIKRigGoal> OutGoals)
	{
		CheckDestroyed();
		if (!AddIKGoals_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/IKRig.IKGoalCreatorInterface:AddIKGoals");
			OutGoals = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddIKGoals_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddIKGoals_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddIKGoals_OutGoals_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddIKGoals_FunctionAddress, intPtr, AddIKGoals_ParamsSize);
		OutGoals = new TMapCopyMarshaler<FName, FIKRigGoal>(1, AddIKGoals_OutGoals_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FIKRigGoal, FIKRigGoal>.FromNative, CachedMarshalingDelegates<FIKRigGoal, FIKRigGoal>.ToNative).FromNative(IntPtr.Add(intPtr, AddIKGoals_OutGoals_Offset));
		NativeReflection.DestroyValue_InContainer(AddIKGoals_OutGoals_PropertyAddress.Address, intPtr);
	}

	static UIKRigComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UIKRigComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UIKRigComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/IKRig.IKRigComponent");
		SetIKRigGoalTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetIKRigGoalTransform");
		SetIKRigGoalTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIKRigGoalTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIKRigGoalTransform_GoalName_PropertyAddress, SetIKRigGoalTransform_FunctionAddress, "GoalName");
		SetIKRigGoalTransform_GoalName_Offset = NativeReflectionCached.GetPropertyOffset(SetIKRigGoalTransform_FunctionAddress, "GoalName");
		SetIKRigGoalTransform_GoalName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIKRigGoalTransform_FunctionAddress, "GoalName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetIKRigGoalTransform_Transform_PropertyAddress, SetIKRigGoalTransform_FunctionAddress, "Transform");
		SetIKRigGoalTransform_Transform_Offset = NativeReflectionCached.GetPropertyOffset(SetIKRigGoalTransform_FunctionAddress, "Transform");
		SetIKRigGoalTransform_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIKRigGoalTransform_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetIKRigGoalTransform_PositionAlpha_PropertyAddress, SetIKRigGoalTransform_FunctionAddress, "PositionAlpha");
		SetIKRigGoalTransform_PositionAlpha_Offset = NativeReflectionCached.GetPropertyOffset(SetIKRigGoalTransform_FunctionAddress, "PositionAlpha");
		SetIKRigGoalTransform_PositionAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIKRigGoalTransform_FunctionAddress, "PositionAlpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetIKRigGoalTransform_RotationAlpha_PropertyAddress, SetIKRigGoalTransform_FunctionAddress, "RotationAlpha");
		SetIKRigGoalTransform_RotationAlpha_Offset = NativeReflectionCached.GetPropertyOffset(SetIKRigGoalTransform_FunctionAddress, "RotationAlpha");
		SetIKRigGoalTransform_RotationAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIKRigGoalTransform_FunctionAddress, "RotationAlpha", Classes.FFloatProperty);
		SetIKRigGoalTransform_IsValid = SetIKRigGoalTransform_FunctionAddress != IntPtr.Zero && SetIKRigGoalTransform_GoalName_IsValid && SetIKRigGoalTransform_Transform_IsValid && SetIKRigGoalTransform_PositionAlpha_IsValid && SetIKRigGoalTransform_RotationAlpha_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/IKRig.IKRigComponent:SetIKRigGoalTransform", SetIKRigGoalTransform_IsValid);
		SetIKRigGoalPositionAndRotation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetIKRigGoalPositionAndRotation");
		SetIKRigGoalPositionAndRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIKRigGoalPositionAndRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIKRigGoalPositionAndRotation_GoalName_PropertyAddress, SetIKRigGoalPositionAndRotation_FunctionAddress, "GoalName");
		SetIKRigGoalPositionAndRotation_GoalName_Offset = NativeReflectionCached.GetPropertyOffset(SetIKRigGoalPositionAndRotation_FunctionAddress, "GoalName");
		SetIKRigGoalPositionAndRotation_GoalName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIKRigGoalPositionAndRotation_FunctionAddress, "GoalName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetIKRigGoalPositionAndRotation_Position_PropertyAddress, SetIKRigGoalPositionAndRotation_FunctionAddress, "Position");
		SetIKRigGoalPositionAndRotation_Position_Offset = NativeReflectionCached.GetPropertyOffset(SetIKRigGoalPositionAndRotation_FunctionAddress, "Position");
		SetIKRigGoalPositionAndRotation_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIKRigGoalPositionAndRotation_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetIKRigGoalPositionAndRotation_Rotation_PropertyAddress, SetIKRigGoalPositionAndRotation_FunctionAddress, "Rotation");
		SetIKRigGoalPositionAndRotation_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(SetIKRigGoalPositionAndRotation_FunctionAddress, "Rotation");
		SetIKRigGoalPositionAndRotation_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIKRigGoalPositionAndRotation_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetIKRigGoalPositionAndRotation_PositionAlpha_PropertyAddress, SetIKRigGoalPositionAndRotation_FunctionAddress, "PositionAlpha");
		SetIKRigGoalPositionAndRotation_PositionAlpha_Offset = NativeReflectionCached.GetPropertyOffset(SetIKRigGoalPositionAndRotation_FunctionAddress, "PositionAlpha");
		SetIKRigGoalPositionAndRotation_PositionAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIKRigGoalPositionAndRotation_FunctionAddress, "PositionAlpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetIKRigGoalPositionAndRotation_RotationAlpha_PropertyAddress, SetIKRigGoalPositionAndRotation_FunctionAddress, "RotationAlpha");
		SetIKRigGoalPositionAndRotation_RotationAlpha_Offset = NativeReflectionCached.GetPropertyOffset(SetIKRigGoalPositionAndRotation_FunctionAddress, "RotationAlpha");
		SetIKRigGoalPositionAndRotation_RotationAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIKRigGoalPositionAndRotation_FunctionAddress, "RotationAlpha", Classes.FFloatProperty);
		SetIKRigGoalPositionAndRotation_IsValid = SetIKRigGoalPositionAndRotation_FunctionAddress != IntPtr.Zero && SetIKRigGoalPositionAndRotation_GoalName_IsValid && SetIKRigGoalPositionAndRotation_Position_IsValid && SetIKRigGoalPositionAndRotation_Rotation_IsValid && SetIKRigGoalPositionAndRotation_PositionAlpha_IsValid && SetIKRigGoalPositionAndRotation_RotationAlpha_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/IKRig.IKRigComponent:SetIKRigGoalPositionAndRotation", SetIKRigGoalPositionAndRotation_IsValid);
		SetIKRigGoal_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetIKRigGoal");
		SetIKRigGoal_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIKRigGoal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIKRigGoal_Goal_PropertyAddress, SetIKRigGoal_FunctionAddress, "Goal");
		SetIKRigGoal_Goal_Offset = NativeReflectionCached.GetPropertyOffset(SetIKRigGoal_FunctionAddress, "Goal");
		SetIKRigGoal_Goal_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIKRigGoal_FunctionAddress, "Goal", Classes.FStructProperty);
		SetIKRigGoal_IsValid = SetIKRigGoal_FunctionAddress != IntPtr.Zero && SetIKRigGoal_Goal_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/IKRig.IKRigComponent:SetIKRigGoal", SetIKRigGoal_IsValid);
		ClearAllGoals_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClearAllGoals");
		ClearAllGoals_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearAllGoals_FunctionAddress);
		ClearAllGoals_IsValid = ClearAllGoals_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/IKRig.IKRigComponent:ClearAllGoals", ClearAllGoals_IsValid);
		AddIKGoals_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddIKGoals");
		AddIKGoals_ParamsSize = NativeReflection.GetFunctionParamsSize(AddIKGoals_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddIKGoals_OutGoals_PropertyAddress, AddIKGoals_FunctionAddress, "OutGoals");
		AddIKGoals_OutGoals_Offset = NativeReflectionCached.GetPropertyOffset(AddIKGoals_FunctionAddress, "OutGoals");
		AddIKGoals_OutGoals_IsValid = NativeReflectionCached.ValidatePropertyClass(AddIKGoals_FunctionAddress, "OutGoals", Classes.FMapProperty);
		AddIKGoals_IsValid = AddIKGoals_FunctionAddress != IntPtr.Zero && AddIKGoals_OutGoals_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/IKRig.IKGoalCreatorInterface:AddIKGoals", AddIKGoals_IsValid);
	}
}
