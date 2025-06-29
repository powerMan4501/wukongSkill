using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.PoseableMeshComponent", "Engine", UnrealModuleType.Engine)]
public class UPoseableMeshComponent : USkinnedMeshComponent
{
	private static bool SetBoneTransformByName_IsValid;

	private static IntPtr SetBoneTransformByName_FunctionAddress;

	private static int SetBoneTransformByName_ParamsSize;

	private static bool SetBoneTransformByName_BoneName_IsValid;

	private static FFieldAddress SetBoneTransformByName_BoneName_PropertyAddress;

	private static int SetBoneTransformByName_BoneName_Offset;

	private static bool SetBoneTransformByName_InTransform_IsValid;

	private static FFieldAddress SetBoneTransformByName_InTransform_PropertyAddress;

	private static int SetBoneTransformByName_InTransform_Offset;

	private static bool SetBoneTransformByName_BoneSpace_IsValid;

	private static FFieldAddress SetBoneTransformByName_BoneSpace_PropertyAddress;

	private static int SetBoneTransformByName_BoneSpace_Offset;

	private static bool SetBoneScaleByName_IsValid;

	private static IntPtr SetBoneScaleByName_FunctionAddress;

	private static int SetBoneScaleByName_ParamsSize;

	private static bool SetBoneScaleByName_BoneName_IsValid;

	private static FFieldAddress SetBoneScaleByName_BoneName_PropertyAddress;

	private static int SetBoneScaleByName_BoneName_Offset;

	private static bool SetBoneScaleByName_InScale3D_IsValid;

	private static FFieldAddress SetBoneScaleByName_InScale3D_PropertyAddress;

	private static int SetBoneScaleByName_InScale3D_Offset;

	private static bool SetBoneScaleByName_BoneSpace_IsValid;

	private static FFieldAddress SetBoneScaleByName_BoneSpace_PropertyAddress;

	private static int SetBoneScaleByName_BoneSpace_Offset;

	private static bool SetBoneRotationByName_IsValid;

	private static IntPtr SetBoneRotationByName_FunctionAddress;

	private static int SetBoneRotationByName_ParamsSize;

	private static bool SetBoneRotationByName_BoneName_IsValid;

	private static FFieldAddress SetBoneRotationByName_BoneName_PropertyAddress;

	private static int SetBoneRotationByName_BoneName_Offset;

	private static bool SetBoneRotationByName_InRotation_IsValid;

	private static FFieldAddress SetBoneRotationByName_InRotation_PropertyAddress;

	private static int SetBoneRotationByName_InRotation_Offset;

	private static bool SetBoneRotationByName_BoneSpace_IsValid;

	private static FFieldAddress SetBoneRotationByName_BoneSpace_PropertyAddress;

	private static int SetBoneRotationByName_BoneSpace_Offset;

	private static bool SetBoneLocationByName_IsValid;

	private static IntPtr SetBoneLocationByName_FunctionAddress;

	private static int SetBoneLocationByName_ParamsSize;

	private static bool SetBoneLocationByName_BoneName_IsValid;

	private static FFieldAddress SetBoneLocationByName_BoneName_PropertyAddress;

	private static int SetBoneLocationByName_BoneName_Offset;

	private static bool SetBoneLocationByName_InLocation_IsValid;

	private static FFieldAddress SetBoneLocationByName_InLocation_PropertyAddress;

	private static int SetBoneLocationByName_InLocation_Offset;

	private static bool SetBoneLocationByName_BoneSpace_IsValid;

	private static FFieldAddress SetBoneLocationByName_BoneSpace_PropertyAddress;

	private static int SetBoneLocationByName_BoneSpace_Offset;

	private static bool ResetBoneTransformByName_IsValid;

	private static IntPtr ResetBoneTransformByName_FunctionAddress;

	private static int ResetBoneTransformByName_ParamsSize;

	private static bool ResetBoneTransformByName_BoneName_IsValid;

	private static FFieldAddress ResetBoneTransformByName_BoneName_PropertyAddress;

	private static int ResetBoneTransformByName_BoneName_Offset;

	private static bool GetBoneTransformByName_IsValid;

	private static IntPtr GetBoneTransformByName_FunctionAddress;

	private static int GetBoneTransformByName_ParamsSize;

	private static bool GetBoneTransformByName_BoneName_IsValid;

	private static FFieldAddress GetBoneTransformByName_BoneName_PropertyAddress;

	private static int GetBoneTransformByName_BoneName_Offset;

	private static bool GetBoneTransformByName_BoneSpace_IsValid;

	private static FFieldAddress GetBoneTransformByName_BoneSpace_PropertyAddress;

	private static int GetBoneTransformByName_BoneSpace_Offset;

	private static bool GetBoneTransformByName_ReturnValue_IsValid;

	private static FFieldAddress GetBoneTransformByName_ReturnValue_PropertyAddress;

	private static int GetBoneTransformByName_ReturnValue_Offset;

	private static bool GetBoneScaleByName_IsValid;

	private static IntPtr GetBoneScaleByName_FunctionAddress;

	private static int GetBoneScaleByName_ParamsSize;

	private static bool GetBoneScaleByName_BoneName_IsValid;

	private static FFieldAddress GetBoneScaleByName_BoneName_PropertyAddress;

	private static int GetBoneScaleByName_BoneName_Offset;

	private static bool GetBoneScaleByName_BoneSpace_IsValid;

	private static FFieldAddress GetBoneScaleByName_BoneSpace_PropertyAddress;

	private static int GetBoneScaleByName_BoneSpace_Offset;

	private static bool GetBoneScaleByName_ReturnValue_IsValid;

	private static FFieldAddress GetBoneScaleByName_ReturnValue_PropertyAddress;

	private static int GetBoneScaleByName_ReturnValue_Offset;

	private static bool GetBoneRotationByName_IsValid;

	private static IntPtr GetBoneRotationByName_FunctionAddress;

	private static int GetBoneRotationByName_ParamsSize;

	private static bool GetBoneRotationByName_BoneName_IsValid;

	private static FFieldAddress GetBoneRotationByName_BoneName_PropertyAddress;

	private static int GetBoneRotationByName_BoneName_Offset;

	private static bool GetBoneRotationByName_BoneSpace_IsValid;

	private static FFieldAddress GetBoneRotationByName_BoneSpace_PropertyAddress;

	private static int GetBoneRotationByName_BoneSpace_Offset;

	private static bool GetBoneRotationByName_ReturnValue_IsValid;

	private static FFieldAddress GetBoneRotationByName_ReturnValue_PropertyAddress;

	private static int GetBoneRotationByName_ReturnValue_Offset;

	private static bool GetBoneLocationByName_IsValid;

	private static IntPtr GetBoneLocationByName_FunctionAddress;

	private static int GetBoneLocationByName_ParamsSize;

	private static bool GetBoneLocationByName_BoneName_IsValid;

	private static FFieldAddress GetBoneLocationByName_BoneName_PropertyAddress;

	private static int GetBoneLocationByName_BoneName_Offset;

	private static bool GetBoneLocationByName_BoneSpace_IsValid;

	private static FFieldAddress GetBoneLocationByName_BoneSpace_PropertyAddress;

	private static int GetBoneLocationByName_BoneSpace_Offset;

	private static bool GetBoneLocationByName_ReturnValue_IsValid;

	private static FFieldAddress GetBoneLocationByName_ReturnValue_PropertyAddress;

	private static int GetBoneLocationByName_ReturnValue_Offset;

	private static bool CopyPoseFromSkeletalComponent_IsValid;

	private static IntPtr CopyPoseFromSkeletalComponent_FunctionAddress;

	private static int CopyPoseFromSkeletalComponent_ParamsSize;

	private static bool CopyPoseFromSkeletalComponent_InComponentToCopy_IsValid;

	private static FFieldAddress CopyPoseFromSkeletalComponent_InComponentToCopy_PropertyAddress;

	private static int CopyPoseFromSkeletalComponent_InComponentToCopy_Offset;

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.PoseableMeshComponent:SetBoneTransformByName")]
	public unsafe void SetBoneTransformByName(FName BoneName, FTransform InTransform, EBoneSpaces BoneSpace)
	{
		CheckDestroyed();
		if (!SetBoneTransformByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PoseableMeshComponent:SetBoneTransformByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoneTransformByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoneTransformByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBoneTransformByName_BoneName_Offset), 0, SetBoneTransformByName_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InitializeValue_InContainer(SetBoneTransformByName_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetBoneTransformByName_InTransform_Offset), 0, SetBoneTransformByName_InTransform_PropertyAddress.Address, InTransform);
		EnumMarshaler<EBoneSpaces>.ToNative(IntPtr.Add(intPtr, SetBoneTransformByName_BoneSpace_Offset), 0, SetBoneTransformByName_BoneSpace_PropertyAddress.Address, BoneSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBoneTransformByName_FunctionAddress, intPtr, SetBoneTransformByName_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PoseableMeshComponent:SetBoneScaleByName")]
	public unsafe void SetBoneScaleByName(FName BoneName, FVector InScale3D, EBoneSpaces BoneSpace)
	{
		CheckDestroyed();
		if (!SetBoneScaleByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PoseableMeshComponent:SetBoneScaleByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoneScaleByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoneScaleByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBoneScaleByName_BoneName_Offset), 0, SetBoneScaleByName_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetBoneScaleByName_InScale3D_Offset), 0, SetBoneScaleByName_InScale3D_PropertyAddress.Address, InScale3D);
		EnumMarshaler<EBoneSpaces>.ToNative(IntPtr.Add(intPtr, SetBoneScaleByName_BoneSpace_Offset), 0, SetBoneScaleByName_BoneSpace_PropertyAddress.Address, BoneSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBoneScaleByName_FunctionAddress, intPtr, SetBoneScaleByName_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PoseableMeshComponent:SetBoneRotationByName")]
	public unsafe void SetBoneRotationByName(FName BoneName, FRotator InRotation, EBoneSpaces BoneSpace)
	{
		CheckDestroyed();
		if (!SetBoneRotationByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PoseableMeshComponent:SetBoneRotationByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoneRotationByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoneRotationByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBoneRotationByName_BoneName_Offset), 0, SetBoneRotationByName_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetBoneRotationByName_InRotation_Offset), 0, SetBoneRotationByName_InRotation_PropertyAddress.Address, InRotation);
		EnumMarshaler<EBoneSpaces>.ToNative(IntPtr.Add(intPtr, SetBoneRotationByName_BoneSpace_Offset), 0, SetBoneRotationByName_BoneSpace_PropertyAddress.Address, BoneSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBoneRotationByName_FunctionAddress, intPtr, SetBoneRotationByName_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PoseableMeshComponent:SetBoneLocationByName")]
	public unsafe void SetBoneLocationByName(FName BoneName, FVector InLocation, EBoneSpaces BoneSpace)
	{
		CheckDestroyed();
		if (!SetBoneLocationByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PoseableMeshComponent:SetBoneLocationByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoneLocationByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoneLocationByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBoneLocationByName_BoneName_Offset), 0, SetBoneLocationByName_BoneName_PropertyAddress.Address, BoneName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetBoneLocationByName_InLocation_Offset), 0, SetBoneLocationByName_InLocation_PropertyAddress.Address, InLocation);
		EnumMarshaler<EBoneSpaces>.ToNative(IntPtr.Add(intPtr, SetBoneLocationByName_BoneSpace_Offset), 0, SetBoneLocationByName_BoneSpace_PropertyAddress.Address, BoneSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBoneLocationByName_FunctionAddress, intPtr, SetBoneLocationByName_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PoseableMeshComponent:ResetBoneTransformByName")]
	public unsafe void ResetBoneTransformByName(FName BoneName)
	{
		CheckDestroyed();
		if (!ResetBoneTransformByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PoseableMeshComponent:ResetBoneTransformByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetBoneTransformByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetBoneTransformByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ResetBoneTransformByName_BoneName_Offset), 0, ResetBoneTransformByName_BoneName_PropertyAddress.Address, BoneName);
		NativeReflection.InvokeFunctionOptimized(base.Address, ResetBoneTransformByName_FunctionAddress, intPtr, ResetBoneTransformByName_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PoseableMeshComponent:GetBoneTransformByName")]
	public unsafe FTransform GetBoneTransformByName(FName BoneName, EBoneSpaces BoneSpace)
	{
		CheckDestroyed();
		if (!GetBoneTransformByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PoseableMeshComponent:GetBoneTransformByName");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneTransformByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneTransformByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBoneTransformByName_BoneName_Offset), 0, GetBoneTransformByName_BoneName_PropertyAddress.Address, BoneName);
		EnumMarshaler<EBoneSpaces>.ToNative(IntPtr.Add(intPtr, GetBoneTransformByName_BoneSpace_Offset), 0, GetBoneTransformByName_BoneSpace_PropertyAddress.Address, BoneSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoneTransformByName_FunctionAddress, intPtr, GetBoneTransformByName_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetBoneTransformByName_ReturnValue_Offset), 0, GetBoneTransformByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PoseableMeshComponent:GetBoneScaleByName")]
	public unsafe FVector GetBoneScaleByName(FName BoneName, EBoneSpaces BoneSpace)
	{
		CheckDestroyed();
		if (!GetBoneScaleByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PoseableMeshComponent:GetBoneScaleByName");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneScaleByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneScaleByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBoneScaleByName_BoneName_Offset), 0, GetBoneScaleByName_BoneName_PropertyAddress.Address, BoneName);
		EnumMarshaler<EBoneSpaces>.ToNative(IntPtr.Add(intPtr, GetBoneScaleByName_BoneSpace_Offset), 0, GetBoneScaleByName_BoneSpace_PropertyAddress.Address, BoneSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoneScaleByName_FunctionAddress, intPtr, GetBoneScaleByName_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetBoneScaleByName_ReturnValue_Offset), 0, GetBoneScaleByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PoseableMeshComponent:GetBoneRotationByName")]
	public unsafe FRotator GetBoneRotationByName(FName BoneName, EBoneSpaces BoneSpace)
	{
		CheckDestroyed();
		if (!GetBoneRotationByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PoseableMeshComponent:GetBoneRotationByName");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneRotationByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneRotationByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBoneRotationByName_BoneName_Offset), 0, GetBoneRotationByName_BoneName_PropertyAddress.Address, BoneName);
		EnumMarshaler<EBoneSpaces>.ToNative(IntPtr.Add(intPtr, GetBoneRotationByName_BoneSpace_Offset), 0, GetBoneRotationByName_BoneSpace_PropertyAddress.Address, BoneSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoneRotationByName_FunctionAddress, intPtr, GetBoneRotationByName_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetBoneRotationByName_ReturnValue_Offset), 0, GetBoneRotationByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PoseableMeshComponent:GetBoneLocationByName")]
	public unsafe FVector GetBoneLocationByName(FName BoneName, EBoneSpaces BoneSpace)
	{
		CheckDestroyed();
		if (!GetBoneLocationByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PoseableMeshComponent:GetBoneLocationByName");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoneLocationByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoneLocationByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBoneLocationByName_BoneName_Offset), 0, GetBoneLocationByName_BoneName_PropertyAddress.Address, BoneName);
		EnumMarshaler<EBoneSpaces>.ToNative(IntPtr.Add(intPtr, GetBoneLocationByName_BoneSpace_Offset), 0, GetBoneLocationByName_BoneSpace_PropertyAddress.Address, BoneSpace);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoneLocationByName_FunctionAddress, intPtr, GetBoneLocationByName_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetBoneLocationByName_ReturnValue_Offset), 0, GetBoneLocationByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PoseableMeshComponent:CopyPoseFromSkeletalComponent")]
	public unsafe void CopyPoseFromSkeletalComponent(USkeletalMeshComponent InComponentToCopy)
	{
		CheckDestroyed();
		if (!CopyPoseFromSkeletalComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PoseableMeshComponent:CopyPoseFromSkeletalComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyPoseFromSkeletalComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyPoseFromSkeletalComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, CopyPoseFromSkeletalComponent_InComponentToCopy_Offset), 0, CopyPoseFromSkeletalComponent_InComponentToCopy_PropertyAddress.Address, InComponentToCopy);
		NativeReflection.InvokeFunctionOptimized(base.Address, CopyPoseFromSkeletalComponent_FunctionAddress, intPtr, CopyPoseFromSkeletalComponent_ParamsSize);
	}

	static UPoseableMeshComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPoseableMeshComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPoseableMeshComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.PoseableMeshComponent");
		SetBoneTransformByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBoneTransformByName");
		SetBoneTransformByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoneTransformByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoneTransformByName_BoneName_PropertyAddress, SetBoneTransformByName_FunctionAddress, "BoneName");
		SetBoneTransformByName_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneTransformByName_FunctionAddress, "BoneName");
		SetBoneTransformByName_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneTransformByName_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoneTransformByName_InTransform_PropertyAddress, SetBoneTransformByName_FunctionAddress, "InTransform");
		SetBoneTransformByName_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneTransformByName_FunctionAddress, "InTransform");
		SetBoneTransformByName_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneTransformByName_FunctionAddress, "InTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoneTransformByName_BoneSpace_PropertyAddress, SetBoneTransformByName_FunctionAddress, "BoneSpace");
		SetBoneTransformByName_BoneSpace_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneTransformByName_FunctionAddress, "BoneSpace");
		SetBoneTransformByName_BoneSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneTransformByName_FunctionAddress, "BoneSpace", Classes.FByteProperty);
		SetBoneTransformByName_IsValid = SetBoneTransformByName_FunctionAddress != IntPtr.Zero && SetBoneTransformByName_BoneName_IsValid && SetBoneTransformByName_InTransform_IsValid && SetBoneTransformByName_BoneSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PoseableMeshComponent:SetBoneTransformByName", SetBoneTransformByName_IsValid);
		SetBoneScaleByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBoneScaleByName");
		SetBoneScaleByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoneScaleByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoneScaleByName_BoneName_PropertyAddress, SetBoneScaleByName_FunctionAddress, "BoneName");
		SetBoneScaleByName_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneScaleByName_FunctionAddress, "BoneName");
		SetBoneScaleByName_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneScaleByName_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoneScaleByName_InScale3D_PropertyAddress, SetBoneScaleByName_FunctionAddress, "InScale3D");
		SetBoneScaleByName_InScale3D_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneScaleByName_FunctionAddress, "InScale3D");
		SetBoneScaleByName_InScale3D_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneScaleByName_FunctionAddress, "InScale3D", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoneScaleByName_BoneSpace_PropertyAddress, SetBoneScaleByName_FunctionAddress, "BoneSpace");
		SetBoneScaleByName_BoneSpace_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneScaleByName_FunctionAddress, "BoneSpace");
		SetBoneScaleByName_BoneSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneScaleByName_FunctionAddress, "BoneSpace", Classes.FByteProperty);
		SetBoneScaleByName_IsValid = SetBoneScaleByName_FunctionAddress != IntPtr.Zero && SetBoneScaleByName_BoneName_IsValid && SetBoneScaleByName_InScale3D_IsValid && SetBoneScaleByName_BoneSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PoseableMeshComponent:SetBoneScaleByName", SetBoneScaleByName_IsValid);
		SetBoneRotationByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBoneRotationByName");
		SetBoneRotationByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoneRotationByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoneRotationByName_BoneName_PropertyAddress, SetBoneRotationByName_FunctionAddress, "BoneName");
		SetBoneRotationByName_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneRotationByName_FunctionAddress, "BoneName");
		SetBoneRotationByName_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneRotationByName_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoneRotationByName_InRotation_PropertyAddress, SetBoneRotationByName_FunctionAddress, "InRotation");
		SetBoneRotationByName_InRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneRotationByName_FunctionAddress, "InRotation");
		SetBoneRotationByName_InRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneRotationByName_FunctionAddress, "InRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoneRotationByName_BoneSpace_PropertyAddress, SetBoneRotationByName_FunctionAddress, "BoneSpace");
		SetBoneRotationByName_BoneSpace_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneRotationByName_FunctionAddress, "BoneSpace");
		SetBoneRotationByName_BoneSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneRotationByName_FunctionAddress, "BoneSpace", Classes.FByteProperty);
		SetBoneRotationByName_IsValid = SetBoneRotationByName_FunctionAddress != IntPtr.Zero && SetBoneRotationByName_BoneName_IsValid && SetBoneRotationByName_InRotation_IsValid && SetBoneRotationByName_BoneSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PoseableMeshComponent:SetBoneRotationByName", SetBoneRotationByName_IsValid);
		SetBoneLocationByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBoneLocationByName");
		SetBoneLocationByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoneLocationByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoneLocationByName_BoneName_PropertyAddress, SetBoneLocationByName_FunctionAddress, "BoneName");
		SetBoneLocationByName_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneLocationByName_FunctionAddress, "BoneName");
		SetBoneLocationByName_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneLocationByName_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoneLocationByName_InLocation_PropertyAddress, SetBoneLocationByName_FunctionAddress, "InLocation");
		SetBoneLocationByName_InLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneLocationByName_FunctionAddress, "InLocation");
		SetBoneLocationByName_InLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneLocationByName_FunctionAddress, "InLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoneLocationByName_BoneSpace_PropertyAddress, SetBoneLocationByName_FunctionAddress, "BoneSpace");
		SetBoneLocationByName_BoneSpace_Offset = NativeReflectionCached.GetPropertyOffset(SetBoneLocationByName_FunctionAddress, "BoneSpace");
		SetBoneLocationByName_BoneSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoneLocationByName_FunctionAddress, "BoneSpace", Classes.FByteProperty);
		SetBoneLocationByName_IsValid = SetBoneLocationByName_FunctionAddress != IntPtr.Zero && SetBoneLocationByName_BoneName_IsValid && SetBoneLocationByName_InLocation_IsValid && SetBoneLocationByName_BoneSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PoseableMeshComponent:SetBoneLocationByName", SetBoneLocationByName_IsValid);
		ResetBoneTransformByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ResetBoneTransformByName");
		ResetBoneTransformByName_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetBoneTransformByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetBoneTransformByName_BoneName_PropertyAddress, ResetBoneTransformByName_FunctionAddress, "BoneName");
		ResetBoneTransformByName_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(ResetBoneTransformByName_FunctionAddress, "BoneName");
		ResetBoneTransformByName_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetBoneTransformByName_FunctionAddress, "BoneName", Classes.FNameProperty);
		ResetBoneTransformByName_IsValid = ResetBoneTransformByName_FunctionAddress != IntPtr.Zero && ResetBoneTransformByName_BoneName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PoseableMeshComponent:ResetBoneTransformByName", ResetBoneTransformByName_IsValid);
		GetBoneTransformByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetBoneTransformByName");
		GetBoneTransformByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneTransformByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransformByName_BoneName_PropertyAddress, GetBoneTransformByName_FunctionAddress, "BoneName");
		GetBoneTransformByName_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransformByName_FunctionAddress, "BoneName");
		GetBoneTransformByName_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransformByName_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransformByName_BoneSpace_PropertyAddress, GetBoneTransformByName_FunctionAddress, "BoneSpace");
		GetBoneTransformByName_BoneSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransformByName_FunctionAddress, "BoneSpace");
		GetBoneTransformByName_BoneSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransformByName_FunctionAddress, "BoneSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneTransformByName_ReturnValue_PropertyAddress, GetBoneTransformByName_FunctionAddress, "ReturnValue");
		GetBoneTransformByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneTransformByName_FunctionAddress, "ReturnValue");
		GetBoneTransformByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneTransformByName_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBoneTransformByName_IsValid = GetBoneTransformByName_FunctionAddress != IntPtr.Zero && GetBoneTransformByName_BoneName_IsValid && GetBoneTransformByName_BoneSpace_IsValid && GetBoneTransformByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PoseableMeshComponent:GetBoneTransformByName", GetBoneTransformByName_IsValid);
		GetBoneScaleByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetBoneScaleByName");
		GetBoneScaleByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneScaleByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneScaleByName_BoneName_PropertyAddress, GetBoneScaleByName_FunctionAddress, "BoneName");
		GetBoneScaleByName_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneScaleByName_FunctionAddress, "BoneName");
		GetBoneScaleByName_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneScaleByName_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneScaleByName_BoneSpace_PropertyAddress, GetBoneScaleByName_FunctionAddress, "BoneSpace");
		GetBoneScaleByName_BoneSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneScaleByName_FunctionAddress, "BoneSpace");
		GetBoneScaleByName_BoneSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneScaleByName_FunctionAddress, "BoneSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneScaleByName_ReturnValue_PropertyAddress, GetBoneScaleByName_FunctionAddress, "ReturnValue");
		GetBoneScaleByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneScaleByName_FunctionAddress, "ReturnValue");
		GetBoneScaleByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneScaleByName_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBoneScaleByName_IsValid = GetBoneScaleByName_FunctionAddress != IntPtr.Zero && GetBoneScaleByName_BoneName_IsValid && GetBoneScaleByName_BoneSpace_IsValid && GetBoneScaleByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PoseableMeshComponent:GetBoneScaleByName", GetBoneScaleByName_IsValid);
		GetBoneRotationByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetBoneRotationByName");
		GetBoneRotationByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneRotationByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneRotationByName_BoneName_PropertyAddress, GetBoneRotationByName_FunctionAddress, "BoneName");
		GetBoneRotationByName_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneRotationByName_FunctionAddress, "BoneName");
		GetBoneRotationByName_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneRotationByName_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneRotationByName_BoneSpace_PropertyAddress, GetBoneRotationByName_FunctionAddress, "BoneSpace");
		GetBoneRotationByName_BoneSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneRotationByName_FunctionAddress, "BoneSpace");
		GetBoneRotationByName_BoneSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneRotationByName_FunctionAddress, "BoneSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneRotationByName_ReturnValue_PropertyAddress, GetBoneRotationByName_FunctionAddress, "ReturnValue");
		GetBoneRotationByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneRotationByName_FunctionAddress, "ReturnValue");
		GetBoneRotationByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneRotationByName_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBoneRotationByName_IsValid = GetBoneRotationByName_FunctionAddress != IntPtr.Zero && GetBoneRotationByName_BoneName_IsValid && GetBoneRotationByName_BoneSpace_IsValid && GetBoneRotationByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PoseableMeshComponent:GetBoneRotationByName", GetBoneRotationByName_IsValid);
		GetBoneLocationByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetBoneLocationByName");
		GetBoneLocationByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoneLocationByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoneLocationByName_BoneName_PropertyAddress, GetBoneLocationByName_FunctionAddress, "BoneName");
		GetBoneLocationByName_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneLocationByName_FunctionAddress, "BoneName");
		GetBoneLocationByName_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneLocationByName_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneLocationByName_BoneSpace_PropertyAddress, GetBoneLocationByName_FunctionAddress, "BoneSpace");
		GetBoneLocationByName_BoneSpace_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneLocationByName_FunctionAddress, "BoneSpace");
		GetBoneLocationByName_BoneSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneLocationByName_FunctionAddress, "BoneSpace", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoneLocationByName_ReturnValue_PropertyAddress, GetBoneLocationByName_FunctionAddress, "ReturnValue");
		GetBoneLocationByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoneLocationByName_FunctionAddress, "ReturnValue");
		GetBoneLocationByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoneLocationByName_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBoneLocationByName_IsValid = GetBoneLocationByName_FunctionAddress != IntPtr.Zero && GetBoneLocationByName_BoneName_IsValid && GetBoneLocationByName_BoneSpace_IsValid && GetBoneLocationByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PoseableMeshComponent:GetBoneLocationByName", GetBoneLocationByName_IsValid);
		CopyPoseFromSkeletalComponent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CopyPoseFromSkeletalComponent");
		CopyPoseFromSkeletalComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyPoseFromSkeletalComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyPoseFromSkeletalComponent_InComponentToCopy_PropertyAddress, CopyPoseFromSkeletalComponent_FunctionAddress, "InComponentToCopy");
		CopyPoseFromSkeletalComponent_InComponentToCopy_Offset = NativeReflectionCached.GetPropertyOffset(CopyPoseFromSkeletalComponent_FunctionAddress, "InComponentToCopy");
		CopyPoseFromSkeletalComponent_InComponentToCopy_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyPoseFromSkeletalComponent_FunctionAddress, "InComponentToCopy", Classes.FObjectProperty);
		CopyPoseFromSkeletalComponent_IsValid = CopyPoseFromSkeletalComponent_FunctionAddress != IntPtr.Zero && CopyPoseFromSkeletalComponent_InComponentToCopy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PoseableMeshComponent:CopyPoseFromSkeletalComponent", CopyPoseFromSkeletalComponent_IsValid);
	}
}
