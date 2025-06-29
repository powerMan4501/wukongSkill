using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.UMGSpline;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/UMGSpline.UMGSplineDebugInfo", "UMGSpline", UnrealModuleType.GamePlugin)]
public struct FUMGSplineDebugInfo
{
	private static bool DrawWidgetBoarder_IsValid;

	private static FFieldAddress DrawWidgetBoarder_PropertyAddress;

	private static int DrawWidgetBoarder_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMGSpline.UMGSplineDebugInfo:bDrawWidgetBoarder")]
	public bool DrawWidgetBoarder;

	private static bool BoarderColor_IsValid;

	private static int BoarderColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UMGSpline.UMGSplineDebugInfo:BoarderColor")]
	public FLinearColor BoarderColor;

	private static bool FUMGSplineDebugInfo_IsValid;

	private static int FUMGSplineDebugInfo_StructSize;

	public FUMGSplineDebugInfo Copy()
	{
		return this;
	}

	public static FUMGSplineDebugInfo FromNative(IntPtr nativeBuffer)
	{
		return new FUMGSplineDebugInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUMGSplineDebugInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUMGSplineDebugInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUMGSplineDebugInfo(nativeBuffer + arrayIndex * FUMGSplineDebugInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUMGSplineDebugInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FUMGSplineDebugInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FUMGSplineDebugInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMGSpline.UMGSplineDebugInfo");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DrawWidgetBoarder_Offset), 0, DrawWidgetBoarder_PropertyAddress.Address, DrawWidgetBoarder);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, BoarderColor_Offset), BoarderColor);
	}

	public FUMGSplineDebugInfo(IntPtr nativeStruct)
	{
		if (!FUMGSplineDebugInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMGSpline.UMGSplineDebugInfo");
			DrawWidgetBoarder = false;
			BoarderColor = default(FLinearColor);
		}
		else
		{
			DrawWidgetBoarder = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DrawWidgetBoarder_Offset), 0, DrawWidgetBoarder_PropertyAddress.Address);
			BoarderColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, BoarderColor_Offset));
		}
	}

	static FUMGSplineDebugInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FUMGSplineDebugInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUMGSplineDebugInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UMGSpline.UMGSplineDebugInfo");
		FUMGSplineDebugInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref DrawWidgetBoarder_PropertyAddress, intPtr, "bDrawWidgetBoarder");
		DrawWidgetBoarder_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDrawWidgetBoarder");
		DrawWidgetBoarder_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDrawWidgetBoarder", Classes.FBoolProperty);
		BoarderColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoarderColor");
		BoarderColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoarderColor", Classes.FStructProperty);
		FUMGSplineDebugInfo_IsValid = intPtr != IntPtr.Zero && DrawWidgetBoarder_IsValid && BoarderColor_IsValid;
		NativeReflection.LogStructIsValid("/Script/UMGSpline.UMGSplineDebugInfo", FUMGSplineDebugInfo_IsValid);
	}
}
