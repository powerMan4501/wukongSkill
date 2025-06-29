using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCTexture")]
public struct BUC_DispLibUtil_DBCTexture
{
	[BlueprintReadWrite]
	[DisplayName("值")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCTexture:TextureValue")]
	public UTexture TextureValue;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("总时间")]
	[UMeta(MD.ToolTip, "主要阶段的持续时长,\n<=0 程序通知何时还原纹理；\n>0 超过总时间后还原纹理;\n注意，纹理参数事件没有参数收尾阶段的概念，如果父级事件有结束表现阶段，在结束表现阶段期间此参数不会释放参数控制权")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_DBCTexture:Duration")]
	public float Duration;

	private static int BUC_DispLibUtil_DBCTexture_StructSize;

	private static int BUC_DispLibUtil_DBCTexture_IsValid;

	private static bool TextureValue_IsValid;

	private static int TextureValue_Offset;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	public BUC_DispLibUtil_DBCTexture SetCustomData(UTexture _Value, float _Duration)
	{
		TextureValue = _Value;
		Duration = _Duration;
		return this;
	}

	public BUC_DispLibUtil_DBCTexture Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_DBCTexture FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_DBCTexture(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_DBCTexture value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_DBCTexture FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_DBCTexture(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_DBCTexture_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_DBCTexture value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_DBCTexture_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_DBCTexture_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_DBCTexture");
			return;
		}
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(nativeStruct, TextureValue_Offset), TextureValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
	}

	public BUC_DispLibUtil_DBCTexture(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_DBCTexture_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_DBCTexture");
			TextureValue = null;
			Duration = 0f;
		}
		else
		{
			TextureValue = UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(nativeStruct, TextureValue_Offset));
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_DBCTexture");
		BUC_DispLibUtil_DBCTexture_StructSize = NativeReflection.GetStructSize(intPtr);
		TextureValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "TextureValue");
		TextureValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TextureValue", Classes.FObjectProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		BUC_DispLibUtil_DBCTexture_IsValid = ((intPtr != IntPtr.Zero && TextureValue_IsValid && Duration_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_DBCTexture", (byte)BUC_DispLibUtil_DBCTexture_IsValid != 0);
	}

	static BUC_DispLibUtil_DBCTexture()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_DBCTexture)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_DBCTexture));
	}
}
