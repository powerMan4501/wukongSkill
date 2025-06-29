using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1.Plugins.UMGSpline;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/UMGSpline.UMGSplineInfo", "UMGSpline", UnrealModuleType.GamePlugin)]
public struct FUMGSplineInfo
{
	private static bool SplineType_IsValid;

	private static FFieldAddress SplineType_PropertyAddress;

	private static int SplineType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMGSpline.UMGSplineInfo:SplineType")]
	public EUMGSplineType SplineType;

	private static bool Thickness_IsValid;

	private static int Thickness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMGSpline.UMGSplineInfo:Thickness")]
	public float Thickness;

	private static bool Points_IsValid;

	private static FFieldAddress Points_PropertyAddress;

	private static int Points_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/UMGSpline.UMGSplineInfo:Points")]
	public List<FUMGSplinePoint> Points;

	private static bool ClosedLoop_IsValid;

	private static FFieldAddress ClosedLoop_PropertyAddress;

	private static int ClosedLoop_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMGSpline.UMGSplineInfo:bClosedLoop")]
	public bool ClosedLoop;

	private static bool TintColor_IsValid;

	private static int TintColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMGSpline.UMGSplineInfo:TintColor")]
	public FLinearColor TintColor;

	private static bool BuildCustomVerts_IsValid;

	private static FFieldAddress BuildCustomVerts_PropertyAddress;

	private static int BuildCustomVerts_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMGSpline.UMGSplineInfo:BuildCustomVerts")]
	public bool BuildCustomVerts;

	private static bool CustomVertsBrush_IsValid;

	private static int CustomVertsBrush_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UMGSpline.UMGSplineInfo:CustomVertsBrush")]
	public FSlateBrush CustomVertsBrush;

	private static bool CustomVertsVCoordScale_IsValid;

	private static int CustomVertsVCoordScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMGSpline.UMGSplineInfo:CustomVertsVCoordScale")]
	public float CustomVertsVCoordScale;

	private static bool FUMGSplineInfo_IsValid;

	private static int FUMGSplineInfo_StructSize;

	public FUMGSplineInfo Copy()
	{
		FUMGSplineInfo result = this;
		if (Points != null)
		{
			result.Points = new List<FUMGSplinePoint>(Points);
		}
		return result;
	}

	public static FUMGSplineInfo FromNative(IntPtr nativeBuffer)
	{
		return new FUMGSplineInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUMGSplineInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUMGSplineInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUMGSplineInfo(nativeBuffer + arrayIndex * FUMGSplineInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUMGSplineInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FUMGSplineInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FUMGSplineInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMGSpline.UMGSplineInfo");
			return;
		}
		EnumMarshaler<EUMGSplineType>.ToNative(IntPtr.Add(nativeStruct, SplineType_Offset), 0, SplineType_PropertyAddress.Address, SplineType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Thickness_Offset), Thickness);
		new TArrayCopyMarshaler<FUMGSplinePoint>(1, Points_PropertyAddress, CachedMarshalingDelegates<FUMGSplinePoint, FUMGSplinePoint>.FromNative, CachedMarshalingDelegates<FUMGSplinePoint, FUMGSplinePoint>.ToNative).ToNative(IntPtr.Add(nativeStruct, Points_Offset), Points);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ClosedLoop_Offset), 0, ClosedLoop_PropertyAddress.Address, ClosedLoop);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, TintColor_Offset), TintColor);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, BuildCustomVerts_Offset), 0, BuildCustomVerts_PropertyAddress.Address, BuildCustomVerts);
		FSlateBrush.ToNative(IntPtr.Add(nativeStruct, CustomVertsBrush_Offset), CustomVertsBrush);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CustomVertsVCoordScale_Offset), CustomVertsVCoordScale);
	}

	public FUMGSplineInfo(IntPtr nativeStruct)
	{
		if (!FUMGSplineInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMGSpline.UMGSplineInfo");
			SplineType = EUMGSplineType.Linear;
			Thickness = 0f;
			Points = null;
			ClosedLoop = false;
			TintColor = default(FLinearColor);
			BuildCustomVerts = false;
			CustomVertsBrush = default(FSlateBrush);
			CustomVertsVCoordScale = 0f;
		}
		else
		{
			SplineType = EnumMarshaler<EUMGSplineType>.FromNative(IntPtr.Add(nativeStruct, SplineType_Offset), 0, SplineType_PropertyAddress.Address);
			Thickness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Thickness_Offset));
			Points = new TArrayCopyMarshaler<FUMGSplinePoint>(1, Points_PropertyAddress, CachedMarshalingDelegates<FUMGSplinePoint, FUMGSplinePoint>.FromNative, CachedMarshalingDelegates<FUMGSplinePoint, FUMGSplinePoint>.ToNative).FromNative(IntPtr.Add(nativeStruct, Points_Offset));
			ClosedLoop = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ClosedLoop_Offset), 0, ClosedLoop_PropertyAddress.Address);
			TintColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, TintColor_Offset));
			BuildCustomVerts = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, BuildCustomVerts_Offset), 0, BuildCustomVerts_PropertyAddress.Address);
			CustomVertsBrush = FSlateBrush.FromNative(IntPtr.Add(nativeStruct, CustomVertsBrush_Offset));
			CustomVertsVCoordScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CustomVertsVCoordScale_Offset));
		}
	}

	static FUMGSplineInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FUMGSplineInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUMGSplineInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UMGSpline.UMGSplineInfo");
		FUMGSplineInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SplineType_PropertyAddress, intPtr, "SplineType");
		SplineType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SplineType");
		SplineType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SplineType", Classes.FEnumProperty);
		Thickness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Thickness");
		Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Points_PropertyAddress, intPtr, "Points");
		Points_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Points");
		Points_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Points", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ClosedLoop_PropertyAddress, intPtr, "bClosedLoop");
		ClosedLoop_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bClosedLoop");
		ClosedLoop_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bClosedLoop", Classes.FBoolProperty);
		TintColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TintColor");
		TintColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TintColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildCustomVerts_PropertyAddress, intPtr, "BuildCustomVerts");
		BuildCustomVerts_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BuildCustomVerts");
		BuildCustomVerts_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BuildCustomVerts", Classes.FBoolProperty);
		CustomVertsBrush_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomVertsBrush");
		CustomVertsBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomVertsBrush", Classes.FStructProperty);
		CustomVertsVCoordScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomVertsVCoordScale");
		CustomVertsVCoordScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomVertsVCoordScale", Classes.FFloatProperty);
		FUMGSplineInfo_IsValid = intPtr != IntPtr.Zero && SplineType_IsValid && Thickness_IsValid && Points_IsValid && ClosedLoop_IsValid && TintColor_IsValid && BuildCustomVerts_IsValid && CustomVertsBrush_IsValid && CustomVertsVCoordScale_IsValid;
		NativeReflection.LogStructIsValid("/Script/UMGSpline.UMGSplineInfo", FUMGSplineInfo_IsValid);
	}
}
