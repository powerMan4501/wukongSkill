using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.GsSpiderNavPointInfo")]
public struct FGsSpiderNavPointInfo
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GsSpiderNavPointInfo:Location")]
	public FVector Location;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GsSpiderNavPointInfo:Normal")]
	public FVector Normal;

	[BlueprintReadOnly]
	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.GsSpiderNavPointInfo:LinkRadius")]
	public float LinkRadius;

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.GsSpiderNavPointInfo:LinkAngle")]
	public float LinkAngle;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GsSpiderNavPointInfo:NavLinkPoints")]
	public List<FGsSpiderNavPointLinkInfo> NavLinkPoints;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GsSpiderNavPointInfo:IsGroundPoint")]
	public bool IsGroundPoint;

	private static int GsSpiderNavPointInfo_StructSize;

	private static int GsSpiderNavPointInfo_IsValid;

	private static bool Location_IsValid;

	private static int Location_Offset;

	private static bool Normal_IsValid;

	private static int Normal_Offset;

	private static bool LinkRadius_IsValid;

	private static int LinkRadius_Offset;

	private static bool LinkAngle_IsValid;

	private static int LinkAngle_Offset;

	private static bool NavLinkPoints_IsValid;

	private static int NavLinkPoints_Offset;

	private static FFieldAddress NavLinkPoints_PropertyAddress;

	private static bool IsGroundPoint_IsValid;

	private static int IsGroundPoint_Offset;

	private static FFieldAddress IsGroundPoint_PropertyAddress;

	public FGsSpiderNavPointInfo Copy()
	{
		FGsSpiderNavPointInfo result = this;
		if (NavLinkPoints != null)
		{
			result.NavLinkPoints = new List<FGsSpiderNavPointLinkInfo>(NavLinkPoints);
		}
		return result;
	}

	public static FGsSpiderNavPointInfo FromNative(IntPtr nativeBuffer)
	{
		return new FGsSpiderNavPointInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsSpiderNavPointInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsSpiderNavPointInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsSpiderNavPointInfo(IntPtr.Add(nativeBuffer, arrayIndex * GsSpiderNavPointInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsSpiderNavPointInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * GsSpiderNavPointInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (GsSpiderNavPointInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GsSpiderNavPointInfo");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Normal_Offset), Normal);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LinkRadius_Offset), LinkRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LinkAngle_Offset), LinkAngle);
		new TArrayCopyMarshaler<FGsSpiderNavPointLinkInfo>(1, NavLinkPoints_PropertyAddress, CachedMarshalingDelegates<FGsSpiderNavPointLinkInfo, BlittableTypeMarshaler<FGsSpiderNavPointLinkInfo>>.FromNative, CachedMarshalingDelegates<FGsSpiderNavPointLinkInfo, BlittableTypeMarshaler<FGsSpiderNavPointLinkInfo>>.ToNative).ToNative(IntPtr.Add(nativeStruct, NavLinkPoints_Offset), NavLinkPoints);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsGroundPoint_Offset), 0, IsGroundPoint_PropertyAddress.Address, IsGroundPoint);
	}

	public FGsSpiderNavPointInfo(IntPtr nativeStruct)
	{
		if (GsSpiderNavPointInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GsSpiderNavPointInfo");
			Location = default(FVector);
			Normal = default(FVector);
			LinkRadius = 0f;
			LinkAngle = 0f;
			NavLinkPoints = null;
			IsGroundPoint = false;
		}
		else
		{
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			Normal = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Normal_Offset));
			LinkRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LinkRadius_Offset));
			LinkAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LinkAngle_Offset));
			NavLinkPoints = new TArrayCopyMarshaler<FGsSpiderNavPointLinkInfo>(1, NavLinkPoints_PropertyAddress, CachedMarshalingDelegates<FGsSpiderNavPointLinkInfo, BlittableTypeMarshaler<FGsSpiderNavPointLinkInfo>>.FromNative, CachedMarshalingDelegates<FGsSpiderNavPointLinkInfo, BlittableTypeMarshaler<FGsSpiderNavPointLinkInfo>>.ToNative).FromNative(IntPtr.Add(nativeStruct, NavLinkPoints_Offset));
			IsGroundPoint = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsGroundPoint_Offset), 0, IsGroundPoint_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.GsSpiderNavPointInfo");
		GsSpiderNavPointInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		Location_Offset = NativeReflection.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		Normal_Offset = NativeReflection.GetPropertyOffset(intPtr, "Normal");
		Normal_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Normal", Classes.FStructProperty);
		LinkRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "LinkRadius");
		LinkRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LinkRadius", Classes.FFloatProperty);
		LinkAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "LinkAngle");
		LinkAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LinkAngle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref NavLinkPoints_PropertyAddress, intPtr, "NavLinkPoints");
		NavLinkPoints_Offset = NativeReflection.GetPropertyOffset(intPtr, "NavLinkPoints");
		NavLinkPoints_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NavLinkPoints", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref IsGroundPoint_PropertyAddress, intPtr, "IsGroundPoint");
		IsGroundPoint_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsGroundPoint");
		IsGroundPoint_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsGroundPoint", Classes.FBoolProperty);
		GsSpiderNavPointInfo_IsValid = ((intPtr != IntPtr.Zero && Location_IsValid && Normal_IsValid && LinkRadius_IsValid && LinkAngle_IsValid && NavLinkPoints_IsValid && IsGroundPoint_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.GsSpiderNavPointInfo", (byte)GsSpiderNavPointInfo_IsValid != 0);
	}

	static FGsSpiderNavPointInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGsSpiderNavPointInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsSpiderNavPointInfo));
	}
}
