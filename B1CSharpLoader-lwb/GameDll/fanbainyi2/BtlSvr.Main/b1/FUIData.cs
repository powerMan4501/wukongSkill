using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FUIData")]
public struct FUIData
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FUIData:Con")]
	public List<FWidgetConfig> Con;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FUIData:Img")]
	public List<FImageWidget> Img;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FUIData:Text")]
	public List<FTextWidget> Text;

	[EditAnywhere]
	[Tooltip("仅Editor展示用")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FUIData:AdvancedHitTexture")]
	public UTexture2D AdvancedHitTexture;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("实际数据")]
	[USharpPath("/Script/b1-Managed.FUIData:AdvancedHitDA")]
	public UDataAsset AdvancedHitDA;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FUIData:AdvancedHitAlpha")]
	public float AdvancedHitAlpha;

	private static int FUIData_StructSize;

	private static int FUIData_IsValid;

	private static bool Con_IsValid;

	private static int Con_Offset;

	private static FFieldAddress Con_PropertyAddress;

	private static bool Img_IsValid;

	private static int Img_Offset;

	private static FFieldAddress Img_PropertyAddress;

	private static bool Text_IsValid;

	private static int Text_Offset;

	private static FFieldAddress Text_PropertyAddress;

	private static bool AdvancedHitTexture_IsValid;

	private static int AdvancedHitTexture_Offset;

	private static bool AdvancedHitDA_IsValid;

	private static int AdvancedHitDA_Offset;

	private static bool AdvancedHitAlpha_IsValid;

	private static int AdvancedHitAlpha_Offset;

	public FUIData Copy()
	{
		FUIData result = this;
		if (Con != null)
		{
			result.Con = new List<FWidgetConfig>(Con);
		}
		if (Img != null)
		{
			result.Img = new List<FImageWidget>(Img);
		}
		if (Text != null)
		{
			result.Text = new List<FTextWidget>(Text);
		}
		return result;
	}

	public static FUIData FromNative(IntPtr nativeBuffer)
	{
		return new FUIData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUIData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUIData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUIData(IntPtr.Add(nativeBuffer, arrayIndex * FUIData_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUIData value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FUIData_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FUIData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FUIData");
			return;
		}
		new TArrayCopyMarshaler<FWidgetConfig>(1, Con_PropertyAddress, CachedMarshalingDelegates<FWidgetConfig, FWidgetConfig>.FromNative, CachedMarshalingDelegates<FWidgetConfig, FWidgetConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, Con_Offset), Con);
		new TArrayCopyMarshaler<FImageWidget>(1, Img_PropertyAddress, CachedMarshalingDelegates<FImageWidget, FImageWidget>.FromNative, CachedMarshalingDelegates<FImageWidget, FImageWidget>.ToNative).ToNative(IntPtr.Add(nativeStruct, Img_Offset), Img);
		new TArrayCopyMarshaler<FTextWidget>(1, Text_PropertyAddress, CachedMarshalingDelegates<FTextWidget, FTextWidget>.FromNative, CachedMarshalingDelegates<FTextWidget, FTextWidget>.ToNative).ToNative(IntPtr.Add(nativeStruct, Text_Offset), Text);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(nativeStruct, AdvancedHitTexture_Offset), AdvancedHitTexture);
		UObjectMarshaler<UDataAsset>.ToNative(IntPtr.Add(nativeStruct, AdvancedHitDA_Offset), AdvancedHitDA);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AdvancedHitAlpha_Offset), AdvancedHitAlpha);
	}

	public FUIData(IntPtr nativeStruct)
	{
		if (FUIData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FUIData");
			Con = null;
			Img = null;
			Text = null;
			AdvancedHitTexture = null;
			AdvancedHitDA = null;
			AdvancedHitAlpha = 0f;
		}
		else
		{
			Con = new TArrayCopyMarshaler<FWidgetConfig>(1, Con_PropertyAddress, CachedMarshalingDelegates<FWidgetConfig, FWidgetConfig>.FromNative, CachedMarshalingDelegates<FWidgetConfig, FWidgetConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, Con_Offset));
			Img = new TArrayCopyMarshaler<FImageWidget>(1, Img_PropertyAddress, CachedMarshalingDelegates<FImageWidget, FImageWidget>.FromNative, CachedMarshalingDelegates<FImageWidget, FImageWidget>.ToNative).FromNative(IntPtr.Add(nativeStruct, Img_Offset));
			Text = new TArrayCopyMarshaler<FTextWidget>(1, Text_PropertyAddress, CachedMarshalingDelegates<FTextWidget, FTextWidget>.FromNative, CachedMarshalingDelegates<FTextWidget, FTextWidget>.ToNative).FromNative(IntPtr.Add(nativeStruct, Text_Offset));
			AdvancedHitTexture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(nativeStruct, AdvancedHitTexture_Offset));
			AdvancedHitDA = UObjectMarshaler<UDataAsset>.FromNative(IntPtr.Add(nativeStruct, AdvancedHitDA_Offset));
			AdvancedHitAlpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AdvancedHitAlpha_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FUIData");
		FUIData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Con_PropertyAddress, intPtr, "Con");
		Con_Offset = NativeReflection.GetPropertyOffset(intPtr, "Con");
		Con_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Con", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref Img_PropertyAddress, intPtr, "Img");
		Img_Offset = NativeReflection.GetPropertyOffset(intPtr, "Img");
		Img_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Img", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref Text_PropertyAddress, intPtr, "Text");
		Text_Offset = NativeReflection.GetPropertyOffset(intPtr, "Text");
		Text_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Text", Classes.FArrayProperty);
		AdvancedHitTexture_Offset = NativeReflection.GetPropertyOffset(intPtr, "AdvancedHitTexture");
		AdvancedHitTexture_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AdvancedHitTexture", Classes.FObjectProperty);
		AdvancedHitDA_Offset = NativeReflection.GetPropertyOffset(intPtr, "AdvancedHitDA");
		AdvancedHitDA_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AdvancedHitDA", Classes.FObjectProperty);
		AdvancedHitAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "AdvancedHitAlpha");
		AdvancedHitAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AdvancedHitAlpha", Classes.FFloatProperty);
		FUIData_IsValid = ((intPtr != IntPtr.Zero && Con_IsValid && Img_IsValid && Text_IsValid && AdvancedHitTexture_IsValid && AdvancedHitDA_IsValid && AdvancedHitAlpha_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FUIData", (byte)FUIData_IsValid != 0);
	}

	static FUIData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FUIData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUIData));
	}
}
