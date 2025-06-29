using System;
using System.Collections.Generic;
using b1.FUnctionLibUtil;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFuncLibMeshCS")]
public class BGUFuncLibMeshCS : UBlueprintFunctionLibrary
{
	private static bool GetChildBones_IsValid;

	private static IntPtr GetChildBones_FunctionAddress;

	private static int GetChildBones_ParamsSize;

	private static bool GetChildBones_SkeletalMeshComp_IsValid;

	private static int GetChildBones_SkeletalMeshComp_Offset;

	private static bool GetChildBones_BaseBoneName_IsValid;

	private static int GetChildBones_BaseBoneName_Offset;

	private static bool GetChildBones_ChildBoneNames_IsValid;

	private static int GetChildBones_ChildBoneNames_Offset;

	private static FFieldAddress GetChildBones_ChildBoneNames_PropertyAddress;

	private static bool GetChildBones_ReturnValue_IsValid;

	private static int GetChildBones_ReturnValue_Offset;

	[Category("BGU|Mesh")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibMeshCS:GetChildBones")]
	public static int GetChildBones(USkeletalMeshComponent SkeletalMeshComp, FName BaseBoneName, ref List<FName> ChildBoneNames)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(SkeletalMeshComp))
		{
			return -1;
		}
		int numBones = SkeletalMeshComp.GetNumBones();
		int boneIndex = SkeletalMeshComp.GetBoneIndex(BaseBoneName);
		for (int i = boneIndex + 1; i < numBones; i++)
		{
			FName boneName = SkeletalMeshComp.GetBoneName(i);
			FName parentBone = SkeletalMeshComp.GetParentBone(boneName);
			int boneIndex2 = SkeletalMeshComp.GetBoneIndex(parentBone);
			if (boneIndex == boneIndex2)
			{
				ChildBoneNames.Add(boneName);
				GetChildBones(SkeletalMeshComp, boneName, ref ChildBoneNames);
			}
		}
		return ChildBoneNames.Count;
	}

	public static void SetAllPABodiesBelowResponseToAttackChannels(USkeletalMeshComponent SkeletalMeshComp, FName BoneName, ECollisionResponseType NewResponse)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(SkeletalMeshComp))
		{
			List<ECollisionChannel> list = new List<ECollisionChannel>();
			list.Add(ECollisionChannel.ECC_GameTraceChannel1);
			list.Add(ECollisionChannel.ECC_GameTraceChannel2);
			UGSE_CharacterFuncLib.SetAllPABodiesBelowResponseToChannels(SkeletalMeshComp, BoneName, list, NewResponse);
		}
	}

	public static void SetAllPABodiesBelowResponseToAllChannels(USkeletalMeshComponent SkeletalMeshComp, FName BoneName, ECollisionResponseType NewResponse)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(SkeletalMeshComp))
		{
			UGSE_CharacterFuncLib.SetAllPABodiesBelowResponseToAllChannels(SkeletalMeshComp, BoneName, NewResponse);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibMeshCS:GetChildBones")]
	private static void GetChildBones__Invoker(IntPtr buffer, IntPtr obj)
	{
		USkeletalMeshComponent skeletalMeshComp = UObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(buffer, GetChildBones_SkeletalMeshComp_Offset));
		FName baseBoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, GetChildBones_BaseBoneName_Offset));
		TArrayCopyMarshaler<FName> tArrayCopyMarshaler = new TArrayCopyMarshaler<FName>(1, GetChildBones_ChildBoneNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
		List<FName> ChildBoneNames = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetChildBones_ChildBoneNames_Offset));
		int childBones = GetChildBones(skeletalMeshComp, baseBoneName, ref ChildBoneNames);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetChildBones_ReturnValue_Offset), childBones);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetChildBones_ChildBoneNames_Offset), ChildBoneNames);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUFuncLibMeshCS");
		GetChildBones_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetChildBones");
		GetChildBones_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChildBones_FunctionAddress);
		GetChildBones_SkeletalMeshComp_Offset = NativeReflection.GetPropertyOffset(GetChildBones_FunctionAddress, "SkeletalMeshComp");
		GetChildBones_SkeletalMeshComp_IsValid = NativeReflection.ValidatePropertyClass(GetChildBones_FunctionAddress, "SkeletalMeshComp", Classes.FObjectProperty);
		GetChildBones_BaseBoneName_Offset = NativeReflection.GetPropertyOffset(GetChildBones_FunctionAddress, "BaseBoneName");
		GetChildBones_BaseBoneName_IsValid = NativeReflection.ValidatePropertyClass(GetChildBones_FunctionAddress, "BaseBoneName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref GetChildBones_ChildBoneNames_PropertyAddress, GetChildBones_FunctionAddress, "ChildBoneNames");
		GetChildBones_ChildBoneNames_Offset = NativeReflection.GetPropertyOffset(GetChildBones_FunctionAddress, "ChildBoneNames");
		GetChildBones_ChildBoneNames_IsValid = NativeReflection.ValidatePropertyClass(GetChildBones_FunctionAddress, "ChildBoneNames", Classes.FArrayProperty);
		GetChildBones_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetChildBones_FunctionAddress, "ReturnValue");
		GetChildBones_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetChildBones_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetChildBones_IsValid = GetChildBones_FunctionAddress != IntPtr.Zero && GetChildBones_SkeletalMeshComp_IsValid && GetChildBones_BaseBoneName_IsValid && GetChildBones_ChildBoneNames_IsValid && GetChildBones_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibMeshCS:GetChildBones", GetChildBones_IsValid);
	}

	static BGUFuncLibMeshCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFuncLibMeshCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFuncLibMeshCS));
	}
}
