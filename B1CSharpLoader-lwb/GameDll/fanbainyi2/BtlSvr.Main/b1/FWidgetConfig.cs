using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.WidgetConfig")]
public struct FWidgetConfig
{
	[DisplayName("Widget名字")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.WidgetConfig:WidgetName")]
	public string WidgetName;

	[DisplayName("UI状态")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.WidgetConfig:Visibility")]
	public ESlateVisibility Visibility;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("启用UI尺寸配置")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.WidgetConfig:UseSize")]
	public bool UseSize;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "UseSize")]
	[DisplayName("UI尺寸")]
	[USharpPath("/Script/b1-Managed.WidgetConfig:Size")]
	public FVector2D Size;

	[DisplayName("启用UI位置配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.WidgetConfig:UsePos")]
	public bool UsePos;

	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "UsePos")]
	[DisplayName("UI位置")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.WidgetConfig:Pos")]
	public FVector2D Pos;

	private static int WidgetConfig_StructSize;

	private static int WidgetConfig_IsValid;

	private static bool WidgetName_IsValid;

	private static int WidgetName_Offset;

	private static bool Visibility_IsValid;

	private static int Visibility_Offset;

	private static FFieldAddress Visibility_PropertyAddress;

	private static bool UseSize_IsValid;

	private static int UseSize_Offset;

	private static FFieldAddress UseSize_PropertyAddress;

	private static bool Size_IsValid;

	private static int Size_Offset;

	private static bool UsePos_IsValid;

	private static int UsePos_Offset;

	private static FFieldAddress UsePos_PropertyAddress;

	private static bool Pos_IsValid;

	private static int Pos_Offset;

	public FWidgetConfig Copy()
	{
		return this;
	}

	public static FWidgetConfig FromNative(IntPtr nativeBuffer)
	{
		return new FWidgetConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWidgetConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWidgetConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWidgetConfig(IntPtr.Add(nativeBuffer, arrayIndex * WidgetConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWidgetConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * WidgetConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (WidgetConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.WidgetConfig");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, WidgetName_Offset), WidgetName);
		EnumMarshaler<ESlateVisibility>.ToNative(IntPtr.Add(nativeStruct, Visibility_Offset), 0, Visibility_PropertyAddress.Address, Visibility);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseSize_Offset), 0, UseSize_PropertyAddress.Address, UseSize);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, Size_Offset), Size);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UsePos_Offset), 0, UsePos_PropertyAddress.Address, UsePos);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, Pos_Offset), Pos);
	}

	public FWidgetConfig(IntPtr nativeStruct)
	{
		if (WidgetConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.WidgetConfig");
			WidgetName = null;
			Visibility = ESlateVisibility.Visible;
			UseSize = false;
			Size = default(FVector2D);
			UsePos = false;
			Pos = default(FVector2D);
		}
		else
		{
			WidgetName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, WidgetName_Offset));
			Visibility = EnumMarshaler<ESlateVisibility>.FromNative(IntPtr.Add(nativeStruct, Visibility_Offset), 0, Visibility_PropertyAddress.Address);
			UseSize = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseSize_Offset), 0, UseSize_PropertyAddress.Address);
			Size = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, Size_Offset));
			UsePos = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UsePos_Offset), 0, UsePos_PropertyAddress.Address);
			Pos = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, Pos_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.WidgetConfig");
		WidgetConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		WidgetName_Offset = NativeReflection.GetPropertyOffset(intPtr, "WidgetName");
		WidgetName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WidgetName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref Visibility_PropertyAddress, intPtr, "Visibility");
		Visibility_Offset = NativeReflection.GetPropertyOffset(intPtr, "Visibility");
		Visibility_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Visibility", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref UseSize_PropertyAddress, intPtr, "UseSize");
		UseSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseSize");
		UseSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseSize", Classes.FBoolProperty);
		Size_Offset = NativeReflection.GetPropertyOffset(intPtr, "Size");
		Size_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Size", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref UsePos_PropertyAddress, intPtr, "UsePos");
		UsePos_Offset = NativeReflection.GetPropertyOffset(intPtr, "UsePos");
		UsePos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UsePos", Classes.FBoolProperty);
		Pos_Offset = NativeReflection.GetPropertyOffset(intPtr, "Pos");
		Pos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Pos", Classes.FStructProperty);
		WidgetConfig_IsValid = ((intPtr != IntPtr.Zero && WidgetName_IsValid && Visibility_IsValid && UseSize_IsValid && Size_IsValid && UsePos_IsValid && Pos_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.WidgetConfig", (byte)WidgetConfig_IsValid != 0);
	}

	static FWidgetConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FWidgetConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWidgetConfig));
	}
}
