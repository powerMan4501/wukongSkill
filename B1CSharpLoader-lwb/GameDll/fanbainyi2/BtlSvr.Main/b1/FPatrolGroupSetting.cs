using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.PatrolGroupSetting")]
public struct FPatrolGroupSetting
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PatrolGroupSetting:SplineActor")]
	public FGsActorGuidReference SplineActor;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PatrolGroupSetting:GroupSplinePatrolType")]
	public EGSGroupSplinePatrolType GroupSplinePatrolType;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.PatrolGroupSetting:GroupMembers")]
	public List<FGsActorGuidReference> GroupMembers;

	[UProperty]
	[VisibleAnywhere]
	[BlueprintVisible]
	[USharpPath("/Script/b1-Managed.PatrolGroupSetting:GroupFormation")]
	public List<FVector> GroupFormation;

	private static int PatrolGroupSetting_StructSize;

	private static int PatrolGroupSetting_IsValid;

	private static bool SplineActor_IsValid;

	private static int SplineActor_Offset;

	private static bool GroupSplinePatrolType_IsValid;

	private static int GroupSplinePatrolType_Offset;

	private static FFieldAddress GroupSplinePatrolType_PropertyAddress;

	private static bool GroupMembers_IsValid;

	private static int GroupMembers_Offset;

	private static FFieldAddress GroupMembers_PropertyAddress;

	private static bool GroupFormation_IsValid;

	private static int GroupFormation_Offset;

	private static FFieldAddress GroupFormation_PropertyAddress;

	public FPatrolGroupSetting Copy()
	{
		FPatrolGroupSetting result = this;
		if (GroupMembers != null)
		{
			result.GroupMembers = new List<FGsActorGuidReference>(GroupMembers);
		}
		if (GroupFormation != null)
		{
			result.GroupFormation = new List<FVector>(GroupFormation);
		}
		return result;
	}

	public static FPatrolGroupSetting FromNative(IntPtr nativeBuffer)
	{
		return new FPatrolGroupSetting(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPatrolGroupSetting value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPatrolGroupSetting FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPatrolGroupSetting(IntPtr.Add(nativeBuffer, arrayIndex * PatrolGroupSetting_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPatrolGroupSetting value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * PatrolGroupSetting_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (PatrolGroupSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PatrolGroupSetting");
			return;
		}
		FGsActorGuidReference.ToNative(IntPtr.Add(nativeStruct, SplineActor_Offset), SplineActor);
		EnumMarshaler<EGSGroupSplinePatrolType>.ToNative(IntPtr.Add(nativeStruct, GroupSplinePatrolType_Offset), 0, GroupSplinePatrolType_PropertyAddress.Address, GroupSplinePatrolType);
		new TArrayCopyMarshaler<FGsActorGuidReference>(1, GroupMembers_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).ToNative(IntPtr.Add(nativeStruct, GroupMembers_Offset), GroupMembers);
		new TArrayCopyMarshaler<FVector>(1, GroupFormation_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(nativeStruct, GroupFormation_Offset), GroupFormation);
	}

	public FPatrolGroupSetting(IntPtr nativeStruct)
	{
		if (PatrolGroupSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PatrolGroupSetting");
			SplineActor = default(FGsActorGuidReference);
			GroupSplinePatrolType = EGSGroupSplinePatrolType.Loop;
			GroupMembers = null;
			GroupFormation = null;
		}
		else
		{
			SplineActor = FGsActorGuidReference.FromNative(IntPtr.Add(nativeStruct, SplineActor_Offset));
			GroupSplinePatrolType = EnumMarshaler<EGSGroupSplinePatrolType>.FromNative(IntPtr.Add(nativeStruct, GroupSplinePatrolType_Offset), 0, GroupSplinePatrolType_PropertyAddress.Address);
			GroupMembers = new TArrayCopyMarshaler<FGsActorGuidReference>(1, GroupMembers_PropertyAddress, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.FromNative, CachedMarshalingDelegates<FGsActorGuidReference, FGsActorGuidReference>.ToNative).FromNative(IntPtr.Add(nativeStruct, GroupMembers_Offset));
			GroupFormation = new TArrayCopyMarshaler<FVector>(1, GroupFormation_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(nativeStruct, GroupFormation_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.PatrolGroupSetting");
		PatrolGroupSetting_StructSize = NativeReflection.GetStructSize(intPtr);
		SplineActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "SplineActor");
		SplineActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SplineActor", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref GroupSplinePatrolType_PropertyAddress, intPtr, "GroupSplinePatrolType");
		GroupSplinePatrolType_Offset = NativeReflection.GetPropertyOffset(intPtr, "GroupSplinePatrolType");
		GroupSplinePatrolType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GroupSplinePatrolType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref GroupMembers_PropertyAddress, intPtr, "GroupMembers");
		GroupMembers_Offset = NativeReflection.GetPropertyOffset(intPtr, "GroupMembers");
		GroupMembers_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GroupMembers", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref GroupFormation_PropertyAddress, intPtr, "GroupFormation");
		GroupFormation_Offset = NativeReflection.GetPropertyOffset(intPtr, "GroupFormation");
		GroupFormation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GroupFormation", Classes.FArrayProperty);
		PatrolGroupSetting_IsValid = ((intPtr != IntPtr.Zero && SplineActor_IsValid && GroupSplinePatrolType_IsValid && GroupMembers_IsValid && GroupFormation_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.PatrolGroupSetting", (byte)PatrolGroupSetting_IsValid != 0);
	}

	static FPatrolGroupSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FPatrolGroupSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPatrolGroupSetting));
	}
}
