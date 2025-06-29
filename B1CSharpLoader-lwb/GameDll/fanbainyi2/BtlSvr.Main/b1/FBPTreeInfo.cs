using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FBPTreeInfo")]
public struct FBPTreeInfo
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FBPTreeInfo:LeaveBoxOri")]
	public FVector LeaveBoxOri;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FBPTreeInfo:LeaveBoxExtent")]
	public FVector LeaveBoxExtent;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FBPTreeInfo:TreeName")]
	public string TreeName;

	private static int FBPTreeInfo_StructSize;

	private static int FBPTreeInfo_IsValid;

	private static bool LeaveBoxOri_IsValid;

	private static int LeaveBoxOri_Offset;

	private static bool LeaveBoxExtent_IsValid;

	private static int LeaveBoxExtent_Offset;

	private static bool TreeName_IsValid;

	private static int TreeName_Offset;

	public FBPTreeInfo Copy()
	{
		return this;
	}

	public static FBPTreeInfo FromNative(IntPtr nativeBuffer)
	{
		return new FBPTreeInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBPTreeInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBPTreeInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBPTreeInfo(IntPtr.Add(nativeBuffer, arrayIndex * FBPTreeInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBPTreeInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FBPTreeInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FBPTreeInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FBPTreeInfo");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, LeaveBoxOri_Offset), LeaveBoxOri);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, LeaveBoxExtent_Offset), LeaveBoxExtent);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, TreeName_Offset), TreeName);
	}

	public FBPTreeInfo(IntPtr nativeStruct)
	{
		if (FBPTreeInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FBPTreeInfo");
			LeaveBoxOri = default(FVector);
			LeaveBoxExtent = default(FVector);
			TreeName = null;
		}
		else
		{
			LeaveBoxOri = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, LeaveBoxOri_Offset));
			LeaveBoxExtent = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, LeaveBoxExtent_Offset));
			TreeName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, TreeName_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FBPTreeInfo");
		FBPTreeInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		LeaveBoxOri_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeaveBoxOri");
		LeaveBoxOri_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeaveBoxOri", Classes.FStructProperty);
		LeaveBoxExtent_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeaveBoxExtent");
		LeaveBoxExtent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeaveBoxExtent", Classes.FStructProperty);
		TreeName_Offset = NativeReflection.GetPropertyOffset(intPtr, "TreeName");
		TreeName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TreeName", Classes.FStrProperty);
		FBPTreeInfo_IsValid = ((intPtr != IntPtr.Zero && LeaveBoxOri_IsValid && LeaveBoxExtent_IsValid && TreeName_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FBPTreeInfo", (byte)FBPTreeInfo_IsValid != 0);
	}

	static FBPTreeInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBPTreeInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBPTreeInfo));
	}
}
