using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.ProjWidgetInfo", "UnrealExtent", UnrealModuleType.Game)]
public struct FProjWidgetInfo
{
	private static bool Widget_IsValid;

	private static int Widget_Offset;

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/UnrealExtent.ProjWidgetInfo:Widget")]
	public UWidget Widget;

	private static bool WorldPos_IsValid;

	private static int WorldPos_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjWidgetInfo:WorldPos")]
	public FVector WorldPos;

	private static bool RoundRect_IsValid;

	private static int RoundRect_Offset;

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/UnrealExtent.ProjWidgetInfo:RoundRect")]
	public UGSRoundRectQuick RoundRect;

	private static bool UseRoundRectCalSize_IsValid;

	private static FFieldAddress UseRoundRectCalSize_PropertyAddress;

	private static int UseRoundRectCalSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjWidgetInfo:UseRoundRectCalSize")]
	public bool UseRoundRectCalSize;

	private static bool RoundRectCalSize_IsValid;

	private static int RoundRectCalSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjWidgetInfo:RoundRectCalSize")]
	public FVector2D RoundRectCalSize;

	private static bool HideRoundRect_IsValid;

	private static int HideRoundRect_Offset;

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/UnrealExtent.ProjWidgetInfo:HideRoundRect")]
	public UGSRoundRectQuick HideRoundRect;

	private static bool NeedCheckProjView_IsValid;

	private static FFieldAddress NeedCheckProjView_PropertyAddress;

	private static int NeedCheckProjView_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjWidgetInfo:NeedCheckProjView")]
	public bool NeedCheckProjView;

	private static bool ShowDistanceMax_IsValid;

	private static int ShowDistanceMax_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjWidgetInfo:ShowDistanceMax")]
	public float ShowDistanceMax;

	private static bool UseDistanceZoom_IsValid;

	private static FFieldAddress UseDistanceZoom_PropertyAddress;

	private static int UseDistanceZoom_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjWidgetInfo:UseDistanceZoom")]
	public bool UseDistanceZoom;

	private static bool MinScale_IsValid;

	private static int MinScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjWidgetInfo:MinScale")]
	public float MinScale;

	private static bool MaxScale_IsValid;

	private static int MaxScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjWidgetInfo:MaxScale")]
	public float MaxScale;

	private static bool ScaleRate_IsValid;

	private static int ScaleRate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjWidgetInfo:ScaleRate")]
	public float ScaleRate;

	private static bool XMinScale_IsValid;

	private static int XMinScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjWidgetInfo:XMinScale")]
	public float XMinScale;

	private static bool XMaxScale_IsValid;

	private static int XMaxScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjWidgetInfo:XMaxScale")]
	public float XMaxScale;

	private static bool YMinScale_IsValid;

	private static int YMinScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjWidgetInfo:YMinScale")]
	public float YMinScale;

	private static bool YMaxScale_IsValid;

	private static int YMaxScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjWidgetInfo:YMaxScale")]
	public float YMaxScale;

	private static bool FProjWidgetInfo_IsValid;

	private static int FProjWidgetInfo_StructSize;

	public FProjWidgetInfo Copy()
	{
		return this;
	}

	public static FProjWidgetInfo FromNative(IntPtr nativeBuffer)
	{
		return new FProjWidgetInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FProjWidgetInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FProjWidgetInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FProjWidgetInfo(nativeBuffer + arrayIndex * FProjWidgetInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FProjWidgetInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FProjWidgetInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FProjWidgetInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.ProjWidgetInfo");
			return;
		}
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(nativeStruct, Widget_Offset), Widget);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, WorldPos_Offset), WorldPos);
		UObjectMarshaler<UGSRoundRectQuick>.ToNative(IntPtr.Add(nativeStruct, RoundRect_Offset), RoundRect);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseRoundRectCalSize_Offset), 0, UseRoundRectCalSize_PropertyAddress.Address, UseRoundRectCalSize);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, RoundRectCalSize_Offset), RoundRectCalSize);
		UObjectMarshaler<UGSRoundRectQuick>.ToNative(IntPtr.Add(nativeStruct, HideRoundRect_Offset), HideRoundRect);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NeedCheckProjView_Offset), 0, NeedCheckProjView_PropertyAddress.Address, NeedCheckProjView);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ShowDistanceMax_Offset), ShowDistanceMax);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseDistanceZoom_Offset), 0, UseDistanceZoom_PropertyAddress.Address, UseDistanceZoom);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinScale_Offset), MinScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxScale_Offset), MaxScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ScaleRate_Offset), ScaleRate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, XMinScale_Offset), XMinScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, XMaxScale_Offset), XMaxScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, YMinScale_Offset), YMinScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, YMaxScale_Offset), YMaxScale);
	}

	public FProjWidgetInfo(IntPtr nativeStruct)
	{
		if (!FProjWidgetInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.ProjWidgetInfo");
			Widget = null;
			WorldPos = default(FVector);
			RoundRect = null;
			UseRoundRectCalSize = false;
			RoundRectCalSize = default(FVector2D);
			HideRoundRect = null;
			NeedCheckProjView = false;
			ShowDistanceMax = 0f;
			UseDistanceZoom = false;
			MinScale = 0f;
			MaxScale = 0f;
			ScaleRate = 0f;
			XMinScale = 0f;
			XMaxScale = 0f;
			YMinScale = 0f;
			YMaxScale = 0f;
		}
		else
		{
			Widget = UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(nativeStruct, Widget_Offset));
			WorldPos = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, WorldPos_Offset));
			RoundRect = UObjectMarshaler<UGSRoundRectQuick>.FromNative(IntPtr.Add(nativeStruct, RoundRect_Offset));
			UseRoundRectCalSize = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseRoundRectCalSize_Offset), 0, UseRoundRectCalSize_PropertyAddress.Address);
			RoundRectCalSize = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, RoundRectCalSize_Offset));
			HideRoundRect = UObjectMarshaler<UGSRoundRectQuick>.FromNative(IntPtr.Add(nativeStruct, HideRoundRect_Offset));
			NeedCheckProjView = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, NeedCheckProjView_Offset), 0, NeedCheckProjView_PropertyAddress.Address);
			ShowDistanceMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ShowDistanceMax_Offset));
			UseDistanceZoom = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseDistanceZoom_Offset), 0, UseDistanceZoom_PropertyAddress.Address);
			MinScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinScale_Offset));
			MaxScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxScale_Offset));
			ScaleRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ScaleRate_Offset));
			XMinScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, XMinScale_Offset));
			XMaxScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, XMaxScale_Offset));
			YMinScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, YMinScale_Offset));
			YMaxScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, YMaxScale_Offset));
		}
	}

	static FProjWidgetInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FProjWidgetInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FProjWidgetInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.ProjWidgetInfo");
		FProjWidgetInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		Widget_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Widget");
		Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Widget", Classes.FObjectProperty);
		WorldPos_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WorldPos");
		WorldPos_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WorldPos", Classes.FStructProperty);
		RoundRect_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RoundRect");
		RoundRect_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RoundRect", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UseRoundRectCalSize_PropertyAddress, intPtr, "UseRoundRectCalSize");
		UseRoundRectCalSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UseRoundRectCalSize");
		UseRoundRectCalSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UseRoundRectCalSize", Classes.FBoolProperty);
		RoundRectCalSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RoundRectCalSize");
		RoundRectCalSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RoundRectCalSize", Classes.FStructProperty);
		HideRoundRect_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HideRoundRect");
		HideRoundRect_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HideRoundRect", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NeedCheckProjView_PropertyAddress, intPtr, "NeedCheckProjView");
		NeedCheckProjView_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NeedCheckProjView");
		NeedCheckProjView_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NeedCheckProjView", Classes.FBoolProperty);
		ShowDistanceMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShowDistanceMax");
		ShowDistanceMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShowDistanceMax", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UseDistanceZoom_PropertyAddress, intPtr, "UseDistanceZoom");
		UseDistanceZoom_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UseDistanceZoom");
		UseDistanceZoom_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UseDistanceZoom", Classes.FBoolProperty);
		MinScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinScale");
		MinScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinScale", Classes.FFloatProperty);
		MaxScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxScale");
		MaxScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxScale", Classes.FFloatProperty);
		ScaleRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScaleRate");
		ScaleRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScaleRate", Classes.FFloatProperty);
		XMinScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "XMinScale");
		XMinScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "XMinScale", Classes.FFloatProperty);
		XMaxScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "XMaxScale");
		XMaxScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "XMaxScale", Classes.FFloatProperty);
		YMinScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "YMinScale");
		YMinScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "YMinScale", Classes.FFloatProperty);
		YMaxScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "YMaxScale");
		YMaxScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "YMaxScale", Classes.FFloatProperty);
		FProjWidgetInfo_IsValid = intPtr != IntPtr.Zero && Widget_IsValid && WorldPos_IsValid && RoundRect_IsValid && UseRoundRectCalSize_IsValid && RoundRectCalSize_IsValid && HideRoundRect_IsValid && NeedCheckProjView_IsValid && ShowDistanceMax_IsValid && UseDistanceZoom_IsValid && MinScale_IsValid && MaxScale_IsValid && ScaleRate_IsValid && XMinScale_IsValid && XMaxScale_IsValid && YMinScale_IsValid && YMaxScale_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.ProjWidgetInfo", FProjWidgetInfo_IsValid);
	}
}
