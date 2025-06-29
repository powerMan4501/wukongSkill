using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.TraceQueryTestResultsInner", "FunctionalTesting", UnrealModuleType.Engine)]
public struct FTraceQueryTestResultsInner
{
	private static bool LineResults_IsValid;

	private static int LineResults_Offset;

	[UProperty(Flags = (PropFlags)4504149383184389uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceQueryTestResultsInner:LineResults")]
	public FTraceQueryTestResultsInnerMost LineResults;

	private static bool SphereResults_IsValid;

	private static int SphereResults_Offset;

	[UProperty(Flags = (PropFlags)4504149383184389uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceQueryTestResultsInner:SphereResults")]
	public FTraceQueryTestResultsInnerMost SphereResults;

	private static bool CapsuleResults_IsValid;

	private static int CapsuleResults_Offset;

	[UProperty(Flags = (PropFlags)4504149383184389uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceQueryTestResultsInner:CapsuleResults")]
	public FTraceQueryTestResultsInnerMost CapsuleResults;

	private static bool BoxResults_IsValid;

	private static int BoxResults_Offset;

	[UProperty(Flags = (PropFlags)4504149383184389uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceQueryTestResultsInner:BoxResults")]
	public FTraceQueryTestResultsInnerMost BoxResults;

	private static bool FTraceQueryTestResultsInner_IsValid;

	private static int FTraceQueryTestResultsInner_StructSize;

	public FTraceQueryTestResultsInner Copy()
	{
		return this;
	}

	public static FTraceQueryTestResultsInner FromNative(IntPtr nativeBuffer)
	{
		return new FTraceQueryTestResultsInner(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTraceQueryTestResultsInner value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTraceQueryTestResultsInner FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTraceQueryTestResultsInner(nativeBuffer + arrayIndex * FTraceQueryTestResultsInner_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTraceQueryTestResultsInner value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTraceQueryTestResultsInner_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTraceQueryTestResultsInner_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.TraceQueryTestResultsInner");
			return;
		}
		FTraceQueryTestResultsInnerMost.ToNative(IntPtr.Add(nativeStruct, LineResults_Offset), LineResults);
		FTraceQueryTestResultsInnerMost.ToNative(IntPtr.Add(nativeStruct, SphereResults_Offset), SphereResults);
		FTraceQueryTestResultsInnerMost.ToNative(IntPtr.Add(nativeStruct, CapsuleResults_Offset), CapsuleResults);
		FTraceQueryTestResultsInnerMost.ToNative(IntPtr.Add(nativeStruct, BoxResults_Offset), BoxResults);
	}

	public FTraceQueryTestResultsInner(IntPtr nativeStruct)
	{
		if (!FTraceQueryTestResultsInner_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.TraceQueryTestResultsInner");
			LineResults = default(FTraceQueryTestResultsInnerMost);
			SphereResults = default(FTraceQueryTestResultsInnerMost);
			CapsuleResults = default(FTraceQueryTestResultsInnerMost);
			BoxResults = default(FTraceQueryTestResultsInnerMost);
		}
		else
		{
			LineResults = FTraceQueryTestResultsInnerMost.FromNative(IntPtr.Add(nativeStruct, LineResults_Offset));
			SphereResults = FTraceQueryTestResultsInnerMost.FromNative(IntPtr.Add(nativeStruct, SphereResults_Offset));
			CapsuleResults = FTraceQueryTestResultsInnerMost.FromNative(IntPtr.Add(nativeStruct, CapsuleResults_Offset));
			BoxResults = FTraceQueryTestResultsInnerMost.FromNative(IntPtr.Add(nativeStruct, BoxResults_Offset));
		}
	}

	static FTraceQueryTestResultsInner()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTraceQueryTestResultsInner)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTraceQueryTestResultsInner));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FunctionalTesting.TraceQueryTestResultsInner");
		FTraceQueryTestResultsInner_StructSize = NativeReflection.GetStructSize(intPtr);
		LineResults_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LineResults");
		LineResults_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LineResults", Classes.FStructProperty);
		SphereResults_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SphereResults");
		SphereResults_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SphereResults", Classes.FStructProperty);
		CapsuleResults_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CapsuleResults");
		CapsuleResults_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CapsuleResults", Classes.FStructProperty);
		BoxResults_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoxResults");
		BoxResults_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoxResults", Classes.FStructProperty);
		FTraceQueryTestResultsInner_IsValid = intPtr != IntPtr.Zero && LineResults_IsValid && SphereResults_IsValid && CapsuleResults_IsValid && BoxResults_IsValid;
		NativeReflection.LogStructIsValid("/Script/FunctionalTesting.TraceQueryTestResultsInner", FTraceQueryTestResultsInner_IsValid);
	}
}
