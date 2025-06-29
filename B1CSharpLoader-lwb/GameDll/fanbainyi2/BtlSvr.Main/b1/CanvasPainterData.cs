using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.CanvasPainterData")]
public struct CanvasPainterData
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.CanvasPainterData:RTTextureParamName")]
	public FName RTTextureParamName;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.CanvasPainterData:RTPing")]
	public TSoftObject<UTextureRenderTarget2D> RTPing;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.CanvasPainterData:RTPong")]
	public TSoftObject<UTextureRenderTarget2D> RTPong;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.CanvasPainterData:RTResult")]
	public TSoftObject<UTextureRenderTarget2D> RTResult;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.CanvasPainterData:PainterMaterial")]
	public UMaterial PainterMaterial;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CanvasPainterData:CanvasMaterial")]
	public UMaterial CanvasMaterial;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.CanvasPainterData:FadeOutTime")]
	public float FadeOutTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.CanvasPainterData:EndTime")]
	public float EndTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.CanvasPainterData:RTSize")]
	public int RTSize;

	private static int CanvasPainterData_StructSize;

	private static int CanvasPainterData_IsValid;

	private static bool RTTextureParamName_IsValid;

	private static int RTTextureParamName_Offset;

	private static bool RTPing_IsValid;

	private static int RTPing_Offset;

	private static bool RTPong_IsValid;

	private static int RTPong_Offset;

	private static bool RTResult_IsValid;

	private static int RTResult_Offset;

	private static bool PainterMaterial_IsValid;

	private static int PainterMaterial_Offset;

	private static bool CanvasMaterial_IsValid;

	private static int CanvasMaterial_Offset;

	private static bool FadeOutTime_IsValid;

	private static int FadeOutTime_Offset;

	private static bool EndTime_IsValid;

	private static int EndTime_Offset;

	private static bool RTSize_IsValid;

	private static int RTSize_Offset;

	public CanvasPainterData Copy()
	{
		return this;
	}

	public static CanvasPainterData FromNative(IntPtr nativeBuffer)
	{
		return new CanvasPainterData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, CanvasPainterData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static CanvasPainterData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new CanvasPainterData(IntPtr.Add(nativeBuffer, arrayIndex * CanvasPainterData_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, CanvasPainterData value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CanvasPainterData_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CanvasPainterData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CanvasPainterData");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, RTTextureParamName_Offset), RTTextureParamName);
		TSoftObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(nativeStruct, RTPing_Offset), RTPing);
		TSoftObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(nativeStruct, RTPong_Offset), RTPong);
		TSoftObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(nativeStruct, RTResult_Offset), RTResult);
		UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(nativeStruct, PainterMaterial_Offset), PainterMaterial);
		UObjectMarshaler<UMaterial>.ToNative(IntPtr.Add(nativeStruct, CanvasMaterial_Offset), CanvasMaterial);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FadeOutTime_Offset), FadeOutTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, EndTime_Offset), EndTime);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RTSize_Offset), RTSize);
	}

	public CanvasPainterData(IntPtr nativeStruct)
	{
		if (CanvasPainterData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CanvasPainterData");
			RTTextureParamName = default(FName);
			RTPing = default(TSoftObject<UTextureRenderTarget2D>);
			RTPong = default(TSoftObject<UTextureRenderTarget2D>);
			RTResult = default(TSoftObject<UTextureRenderTarget2D>);
			PainterMaterial = null;
			CanvasMaterial = null;
			FadeOutTime = 0f;
			EndTime = 0f;
			RTSize = 0;
		}
		else
		{
			RTTextureParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, RTTextureParamName_Offset));
			RTPing = TSoftObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(nativeStruct, RTPing_Offset));
			RTPong = TSoftObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(nativeStruct, RTPong_Offset));
			RTResult = TSoftObjectMarshaler<UTextureRenderTarget2D>.FromNative(IntPtr.Add(nativeStruct, RTResult_Offset));
			PainterMaterial = UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(nativeStruct, PainterMaterial_Offset));
			CanvasMaterial = UObjectMarshaler<UMaterial>.FromNative(IntPtr.Add(nativeStruct, CanvasMaterial_Offset));
			FadeOutTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FadeOutTime_Offset));
			EndTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, EndTime_Offset));
			RTSize = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RTSize_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CanvasPainterData");
		CanvasPainterData_StructSize = NativeReflection.GetStructSize(intPtr);
		RTTextureParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "RTTextureParamName");
		RTTextureParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RTTextureParamName", Classes.FNameProperty);
		RTPing_Offset = NativeReflection.GetPropertyOffset(intPtr, "RTPing");
		RTPing_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RTPing", Classes.FSoftObjectProperty);
		RTPong_Offset = NativeReflection.GetPropertyOffset(intPtr, "RTPong");
		RTPong_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RTPong", Classes.FSoftObjectProperty);
		RTResult_Offset = NativeReflection.GetPropertyOffset(intPtr, "RTResult");
		RTResult_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RTResult", Classes.FSoftObjectProperty);
		PainterMaterial_Offset = NativeReflection.GetPropertyOffset(intPtr, "PainterMaterial");
		PainterMaterial_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PainterMaterial", Classes.FObjectProperty);
		CanvasMaterial_Offset = NativeReflection.GetPropertyOffset(intPtr, "CanvasMaterial");
		CanvasMaterial_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CanvasMaterial", Classes.FObjectProperty);
		FadeOutTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "FadeOutTime");
		FadeOutTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FadeOutTime", Classes.FFloatProperty);
		EndTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndTime");
		EndTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndTime", Classes.FFloatProperty);
		RTSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "RTSize");
		RTSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RTSize", Classes.FIntProperty);
		CanvasPainterData_IsValid = ((intPtr != IntPtr.Zero && RTTextureParamName_IsValid && RTPing_IsValid && RTPong_IsValid && RTResult_IsValid && PainterMaterial_IsValid && CanvasMaterial_IsValid && FadeOutTime_IsValid && EndTime_IsValid && RTSize_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CanvasPainterData", (byte)CanvasPainterData_IsValid != 0);
	}

	static CanvasPainterData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(CanvasPainterData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(CanvasPainterData));
	}
}
