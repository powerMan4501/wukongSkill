using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.GridRow_ForAbnormalDisp")]
public struct FGridRow_ForAbnormalDisp
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GridRow_ForAbnormalDisp:ActorList")]
	public List<ASkeletalMeshActor> ActorList;

	private static int GridRow_ForAbnormalDisp_StructSize;

	private static int GridRow_ForAbnormalDisp_IsValid;

	private static bool ActorList_IsValid;

	private static int ActorList_Offset;

	private static FFieldAddress ActorList_PropertyAddress;

	public FGridRow_ForAbnormalDisp Copy()
	{
		FGridRow_ForAbnormalDisp result = this;
		if (ActorList != null)
		{
			result.ActorList = new List<ASkeletalMeshActor>(ActorList);
		}
		return result;
	}

	public static FGridRow_ForAbnormalDisp FromNative(IntPtr nativeBuffer)
	{
		return new FGridRow_ForAbnormalDisp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGridRow_ForAbnormalDisp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGridRow_ForAbnormalDisp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGridRow_ForAbnormalDisp(IntPtr.Add(nativeBuffer, arrayIndex * GridRow_ForAbnormalDisp_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGridRow_ForAbnormalDisp value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * GridRow_ForAbnormalDisp_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (GridRow_ForAbnormalDisp_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GridRow_ForAbnormalDisp");
		}
		else
		{
			new TArrayCopyMarshaler<ASkeletalMeshActor>(1, ActorList_PropertyAddress, CachedMarshalingDelegates<ASkeletalMeshActor, UObjectMarshaler<ASkeletalMeshActor>>.FromNative, CachedMarshalingDelegates<ASkeletalMeshActor, UObjectMarshaler<ASkeletalMeshActor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ActorList_Offset), ActorList);
		}
	}

	public FGridRow_ForAbnormalDisp(IntPtr nativeStruct)
	{
		if (GridRow_ForAbnormalDisp_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GridRow_ForAbnormalDisp");
			ActorList = null;
		}
		else
		{
			ActorList = new TArrayCopyMarshaler<ASkeletalMeshActor>(1, ActorList_PropertyAddress, CachedMarshalingDelegates<ASkeletalMeshActor, UObjectMarshaler<ASkeletalMeshActor>>.FromNative, CachedMarshalingDelegates<ASkeletalMeshActor, UObjectMarshaler<ASkeletalMeshActor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ActorList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.GridRow_ForAbnormalDisp");
		GridRow_ForAbnormalDisp_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ActorList_PropertyAddress, intPtr, "ActorList");
		ActorList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorList");
		ActorList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorList", Classes.FArrayProperty);
		GridRow_ForAbnormalDisp_IsValid = ((intPtr != IntPtr.Zero && ActorList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.GridRow_ForAbnormalDisp", (byte)GridRow_ForAbnormalDisp_IsValid != 0);
	}

	static FGridRow_ForAbnormalDisp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGridRow_ForAbnormalDisp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGridRow_ForAbnormalDisp));
	}
}
