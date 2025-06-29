using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/b1.UStGSHitResult", "b1", UnrealModuleType.Game)]
public struct FUStGSHitResult
{
	private static bool PreCheckLocation_IsValid;

	private static int PreCheckLocation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.UStGSHitResult:PreCheckLocation")]
	public FVector PreCheckLocation;

	private static bool CurCheckLocation_IsValid;

	private static int CurCheckLocation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.UStGSHitResult:CurCheckLocation")]
	public FVector CurCheckLocation;

	private static bool Actor_IsValid;

	private static int Actor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.UStGSHitResult:Actor")]
	public AActor Actor;

	private static bool ImpactPoint_IsValid;

	private static int ImpactPoint_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.UStGSHitResult:ImpactPoint")]
	public FVector ImpactPoint;

	private static bool HitComponent_IsValid;

	private static int HitComponent_Offset;

	[UProperty(Flags = (PropFlags)6755469234799116uL)]
	[UMetaPath("/Script/b1.UStGSHitResult:HitComponent")]
	public UPrimitiveComponent HitComponent;

	private static bool BoneName_IsValid;

	private static int BoneName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.UStGSHitResult:BoneName")]
	public FName BoneName;

	private static bool Normal_IsValid;

	private static int Normal_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.UStGSHitResult:Normal")]
	public FVector Normal;

	private static bool FUStGSHitResult_IsValid;

	private static int FUStGSHitResult_StructSize;

	public FUStGSHitResult Copy()
	{
		return this;
	}

	public static FUStGSHitResult FromNative(IntPtr nativeBuffer)
	{
		return new FUStGSHitResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUStGSHitResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUStGSHitResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUStGSHitResult(nativeBuffer + arrayIndex * FUStGSHitResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUStGSHitResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FUStGSHitResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FUStGSHitResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.UStGSHitResult");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, PreCheckLocation_Offset), PreCheckLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, CurCheckLocation_Offset), CurCheckLocation);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Actor_Offset), Actor);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, ImpactPoint_Offset), ImpactPoint);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(nativeStruct, HitComponent_Offset), HitComponent);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, BoneName_Offset), BoneName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Normal_Offset), Normal);
	}

	public FUStGSHitResult(IntPtr nativeStruct)
	{
		if (!FUStGSHitResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.UStGSHitResult");
			PreCheckLocation = default(FVector);
			CurCheckLocation = default(FVector);
			Actor = null;
			ImpactPoint = default(FVector);
			HitComponent = null;
			BoneName = default(FName);
			Normal = default(FVector);
		}
		else
		{
			PreCheckLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, PreCheckLocation_Offset));
			CurCheckLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, CurCheckLocation_Offset));
			Actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Actor_Offset));
			ImpactPoint = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, ImpactPoint_Offset));
			HitComponent = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(nativeStruct, HitComponent_Offset));
			BoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, BoneName_Offset));
			Normal = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Normal_Offset));
		}
	}

	static FUStGSHitResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FUStGSHitResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUStGSHitResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.UStGSHitResult");
		FUStGSHitResult_StructSize = NativeReflection.GetStructSize(intPtr);
		PreCheckLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreCheckLocation");
		PreCheckLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreCheckLocation", Classes.FStructProperty);
		CurCheckLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurCheckLocation");
		CurCheckLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurCheckLocation", Classes.FStructProperty);
		Actor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Actor");
		Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Actor", Classes.FObjectProperty);
		ImpactPoint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ImpactPoint");
		ImpactPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ImpactPoint", Classes.FStructProperty);
		HitComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HitComponent");
		HitComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HitComponent", Classes.FObjectProperty);
		BoneName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoneName");
		BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoneName", Classes.FNameProperty);
		Normal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Normal");
		Normal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Normal", Classes.FStructProperty);
		FUStGSHitResult_IsValid = intPtr != IntPtr.Zero && PreCheckLocation_IsValid && CurCheckLocation_IsValid && Actor_IsValid && ImpactPoint_IsValid && HitComponent_IsValid && BoneName_IsValid && Normal_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.UStGSHitResult", FUStGSHitResult_IsValid);
	}
}
