using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.ProjResult", "UnrealExtent", UnrealModuleType.Game)]
public struct FProjResult
{
	private static bool IsInSight_IsValid;

	private static FFieldAddress IsInSight_PropertyAddress;

	private static int IsInSight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjResult:IsInSight")]
	public bool IsInSight;

	private static bool IsInRound_IsValid;

	private static FFieldAddress IsInRound_PropertyAddress;

	private static int IsInRound_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjResult:IsInRound")]
	public bool IsInRound;

	private static bool ScrPos_IsValid;

	private static int ScrPos_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjResult:ScrPos")]
	public FVector2D ScrPos;

	private static bool RectAngle_IsValid;

	private static int RectAngle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjResult:RectAngle")]
	public float RectAngle;

	private static bool IndicatorType_IsValid;

	private static int IndicatorType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjResult:IndicatorType")]
	public int IndicatorType;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjResult:Scale")]
	public float Scale;

	private static bool SizeScale_IsValid;

	private static int SizeScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.ProjResult:SizeScale")]
	public FVector2D SizeScale;

	private static bool FProjResult_IsValid;

	private static int FProjResult_StructSize;

	public FProjResult Copy()
	{
		return this;
	}

	public static FProjResult FromNative(IntPtr nativeBuffer)
	{
		return new FProjResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FProjResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FProjResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FProjResult(nativeBuffer + arrayIndex * FProjResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FProjResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FProjResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FProjResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.ProjResult");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsInSight_Offset), 0, IsInSight_PropertyAddress.Address, IsInSight);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsInRound_Offset), 0, IsInRound_PropertyAddress.Address, IsInRound);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, ScrPos_Offset), ScrPos);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RectAngle_Offset), RectAngle);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IndicatorType_Offset), IndicatorType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, SizeScale_Offset), SizeScale);
	}

	public FProjResult(IntPtr nativeStruct)
	{
		if (!FProjResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.ProjResult");
			IsInSight = false;
			IsInRound = false;
			ScrPos = default(FVector2D);
			RectAngle = 0f;
			IndicatorType = 0;
			Scale = 0f;
			SizeScale = default(FVector2D);
		}
		else
		{
			IsInSight = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsInSight_Offset), 0, IsInSight_PropertyAddress.Address);
			IsInRound = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsInRound_Offset), 0, IsInRound_PropertyAddress.Address);
			ScrPos = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, ScrPos_Offset));
			RectAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RectAngle_Offset));
			IndicatorType = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IndicatorType_Offset));
			Scale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
			SizeScale = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, SizeScale_Offset));
		}
	}

	static FProjResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FProjResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FProjResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.ProjResult");
		FProjResult_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref IsInSight_PropertyAddress, intPtr, "IsInSight");
		IsInSight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsInSight");
		IsInSight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsInSight", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsInRound_PropertyAddress, intPtr, "IsInRound");
		IsInRound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsInRound");
		IsInRound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsInRound", Classes.FBoolProperty);
		ScrPos_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScrPos");
		ScrPos_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScrPos", Classes.FStructProperty);
		RectAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RectAngle");
		RectAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RectAngle", Classes.FFloatProperty);
		IndicatorType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IndicatorType");
		IndicatorType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IndicatorType", Classes.FIntProperty);
		Scale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Scale", Classes.FFloatProperty);
		SizeScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SizeScale");
		SizeScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SizeScale", Classes.FStructProperty);
		FProjResult_IsValid = intPtr != IntPtr.Zero && IsInSight_IsValid && IsInRound_IsValid && ScrPos_IsValid && RectAngle_IsValid && IndicatorType_IsValid && Scale_IsValid && SizeScale_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.ProjResult", FProjResult_IsValid);
	}
}
