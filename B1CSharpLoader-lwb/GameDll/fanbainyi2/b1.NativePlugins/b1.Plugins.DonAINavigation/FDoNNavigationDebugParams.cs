using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.DonAINavigation;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/DonAINavigation.DoNNavigationDebugParams", "DonAINavigation", UnrealModuleType.GamePlugin)]
public struct FDoNNavigationDebugParams
{
	private static bool DrawDebugVolumes_IsValid;

	private static FFieldAddress DrawDebugVolumes_PropertyAddress;

	private static int DrawDebugVolumes_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationDebugParams:DrawDebugVolumes")]
	public bool DrawDebugVolumes;

	private static bool VisualizeRawPath_IsValid;

	private static FFieldAddress VisualizeRawPath_PropertyAddress;

	private static int VisualizeRawPath_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationDebugParams:VisualizeRawPath")]
	public bool VisualizeRawPath;

	private static bool VisualizeOptimizedPath_IsValid;

	private static FFieldAddress VisualizeOptimizedPath_PropertyAddress;

	private static int VisualizeOptimizedPath_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationDebugParams:VisualizeOptimizedPath")]
	public bool VisualizeOptimizedPath;

	private static bool VisualizeInRealTime_IsValid;

	private static FFieldAddress VisualizeInRealTime_PropertyAddress;

	private static int VisualizeInRealTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationDebugParams:VisualizeInRealTime")]
	public bool VisualizeInRealTime;

	private static bool LineThickness_IsValid;

	private static int LineThickness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationDebugParams:LineThickness")]
	public float LineThickness;

	private static bool LineDuration_IsValid;

	private static int LineDuration_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationDebugParams:LineDuration")]
	public float LineDuration;

	private static bool FDoNNavigationDebugParams_IsValid;

	private static int FDoNNavigationDebugParams_StructSize;

	public FDoNNavigationDebugParams Copy()
	{
		return this;
	}

	public static FDoNNavigationDebugParams FromNative(IntPtr nativeBuffer)
	{
		return new FDoNNavigationDebugParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDoNNavigationDebugParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDoNNavigationDebugParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDoNNavigationDebugParams(nativeBuffer + arrayIndex * FDoNNavigationDebugParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDoNNavigationDebugParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDoNNavigationDebugParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDoNNavigationDebugParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DonAINavigation.DoNNavigationDebugParams");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DrawDebugVolumes_Offset), 0, DrawDebugVolumes_PropertyAddress.Address, DrawDebugVolumes);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, VisualizeRawPath_Offset), 0, VisualizeRawPath_PropertyAddress.Address, VisualizeRawPath);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, VisualizeOptimizedPath_Offset), 0, VisualizeOptimizedPath_PropertyAddress.Address, VisualizeOptimizedPath);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, VisualizeInRealTime_Offset), 0, VisualizeInRealTime_PropertyAddress.Address, VisualizeInRealTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LineThickness_Offset), LineThickness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LineDuration_Offset), LineDuration);
	}

	public FDoNNavigationDebugParams(IntPtr nativeStruct)
	{
		if (!FDoNNavigationDebugParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DonAINavigation.DoNNavigationDebugParams");
			DrawDebugVolumes = false;
			VisualizeRawPath = false;
			VisualizeOptimizedPath = false;
			VisualizeInRealTime = false;
			LineThickness = 0f;
			LineDuration = 0f;
		}
		else
		{
			DrawDebugVolumes = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DrawDebugVolumes_Offset), 0, DrawDebugVolumes_PropertyAddress.Address);
			VisualizeRawPath = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, VisualizeRawPath_Offset), 0, VisualizeRawPath_PropertyAddress.Address);
			VisualizeOptimizedPath = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, VisualizeOptimizedPath_Offset), 0, VisualizeOptimizedPath_PropertyAddress.Address);
			VisualizeInRealTime = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, VisualizeInRealTime_Offset), 0, VisualizeInRealTime_PropertyAddress.Address);
			LineThickness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LineThickness_Offset));
			LineDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LineDuration_Offset));
		}
	}

	static FDoNNavigationDebugParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDoNNavigationDebugParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDoNNavigationDebugParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DonAINavigation.DoNNavigationDebugParams");
		FDoNNavigationDebugParams_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugVolumes_PropertyAddress, intPtr, "DrawDebugVolumes");
		DrawDebugVolumes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DrawDebugVolumes");
		DrawDebugVolumes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DrawDebugVolumes", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref VisualizeRawPath_PropertyAddress, intPtr, "VisualizeRawPath");
		VisualizeRawPath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VisualizeRawPath");
		VisualizeRawPath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VisualizeRawPath", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref VisualizeOptimizedPath_PropertyAddress, intPtr, "VisualizeOptimizedPath");
		VisualizeOptimizedPath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VisualizeOptimizedPath");
		VisualizeOptimizedPath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VisualizeOptimizedPath", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref VisualizeInRealTime_PropertyAddress, intPtr, "VisualizeInRealTime");
		VisualizeInRealTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VisualizeInRealTime");
		VisualizeInRealTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VisualizeInRealTime", Classes.FBoolProperty);
		LineThickness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LineThickness");
		LineThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LineThickness", Classes.FFloatProperty);
		LineDuration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LineDuration");
		LineDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LineDuration", Classes.FFloatProperty);
		FDoNNavigationDebugParams_IsValid = intPtr != IntPtr.Zero && DrawDebugVolumes_IsValid && VisualizeRawPath_IsValid && VisualizeOptimizedPath_IsValid && VisualizeInRealTime_IsValid && LineThickness_IsValid && LineDuration_IsValid;
		NativeReflection.LogStructIsValid("/Script/DonAINavigation.DoNNavigationDebugParams", FDoNNavigationDebugParams_IsValid);
	}
}
