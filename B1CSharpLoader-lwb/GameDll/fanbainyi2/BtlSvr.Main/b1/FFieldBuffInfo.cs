using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FieldBuffInfo")]
public struct FFieldBuffInfo
{
	[EditAnywhere]
	[DisplayName("忽略类型筛选")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FieldBuffInfo:bIgnoreTypeFilter")]
	public bool bIgnoreTypeFilter;

	[EditAnywhere]
	[Tooltip("1:自己, 2：队友, 4:敌人")]
	[UProperty]
	[DisplayName("对象阵营筛选")]
	[USharpPath("/Script/b1-Managed.FieldBuffInfo:TargetTeamFilter")]
	public int TargetTeamFilter;

	[UProperty]
	[DisplayName("对象类型筛选")]
	[Tooltip("1:角色, 2：子弹, 4:法术场")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FieldBuffInfo:TargetTypeFilter")]
	public int TargetTypeFilter;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FieldBuffInfo:BuffID")]
	public int BuffID;

	private static int FieldBuffInfo_StructSize;

	private static int FieldBuffInfo_IsValid;

	private static bool bIgnoreTypeFilter_IsValid;

	private static int bIgnoreTypeFilter_Offset;

	private static FFieldAddress bIgnoreTypeFilter_PropertyAddress;

	private static bool TargetTeamFilter_IsValid;

	private static int TargetTeamFilter_Offset;

	private static bool TargetTypeFilter_IsValid;

	private static int TargetTypeFilter_Offset;

	private static bool BuffID_IsValid;

	private static int BuffID_Offset;

	public FFieldBuffInfo Copy()
	{
		return this;
	}

	public static FFieldBuffInfo FromNative(IntPtr nativeBuffer)
	{
		return new FFieldBuffInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFieldBuffInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFieldBuffInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFieldBuffInfo(IntPtr.Add(nativeBuffer, arrayIndex * FieldBuffInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFieldBuffInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FieldBuffInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FieldBuffInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FieldBuffInfo");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bIgnoreTypeFilter_Offset), 0, bIgnoreTypeFilter_PropertyAddress.Address, bIgnoreTypeFilter);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TargetTeamFilter_Offset), TargetTeamFilter);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TargetTypeFilter_Offset), TargetTypeFilter);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BuffID_Offset), BuffID);
	}

	public FFieldBuffInfo(IntPtr nativeStruct)
	{
		if (FieldBuffInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FieldBuffInfo");
			bIgnoreTypeFilter = false;
			TargetTeamFilter = 0;
			TargetTypeFilter = 0;
			BuffID = 0;
		}
		else
		{
			bIgnoreTypeFilter = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bIgnoreTypeFilter_Offset), 0, bIgnoreTypeFilter_PropertyAddress.Address);
			TargetTeamFilter = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TargetTeamFilter_Offset));
			TargetTypeFilter = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TargetTypeFilter_Offset));
			BuffID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BuffID_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FieldBuffInfo");
		FieldBuffInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref bIgnoreTypeFilter_PropertyAddress, intPtr, "bIgnoreTypeFilter");
		bIgnoreTypeFilter_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIgnoreTypeFilter");
		bIgnoreTypeFilter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIgnoreTypeFilter", Classes.FBoolProperty);
		TargetTeamFilter_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetTeamFilter");
		TargetTeamFilter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetTeamFilter", Classes.FIntProperty);
		TargetTypeFilter_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetTypeFilter");
		TargetTypeFilter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetTypeFilter", Classes.FIntProperty);
		BuffID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffID");
		BuffID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffID", Classes.FIntProperty);
		FieldBuffInfo_IsValid = ((intPtr != IntPtr.Zero && bIgnoreTypeFilter_IsValid && TargetTeamFilter_IsValid && TargetTypeFilter_IsValid && BuffID_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FieldBuffInfo", (byte)FieldBuffInfo_IsValid != 0);
	}

	static FFieldBuffInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FFieldBuffInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFieldBuffInfo));
	}
}
