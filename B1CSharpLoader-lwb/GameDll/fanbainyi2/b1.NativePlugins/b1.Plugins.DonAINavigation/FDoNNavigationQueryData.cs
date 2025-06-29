using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.DonAINavigation;

[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/DonAINavigation.DoNNavigationQueryData", "DonAINavigation", UnrealModuleType.GamePlugin)]
public struct FDoNNavigationQueryData
{
	private static bool Actor_IsValid;

	private static int Actor_Offset;

	[UProperty(Flags = (PropFlags)7881369141117460uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationQueryData:Actor")]
	public TWeakObject<AActor> Actor;

	private static bool Origin_IsValid;

	private static int Origin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationQueryData:Origin")]
	public FVector Origin;

	private static bool Destination_IsValid;

	private static int Destination_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationQueryData:Destination")]
	public FVector Destination;

	private static bool QueryParams_IsValid;

	private static int QueryParams_Offset;

	[UProperty(Flags = (PropFlags)4503668346847252uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationQueryData:QueryParams")]
	public FDoNNavigationQueryParams QueryParams;

	private static bool PathSolutionOptimized_IsValid;

	private static FFieldAddress PathSolutionOptimized_PropertyAddress;

	private static int PathSolutionOptimized_Offset;

	[UProperty(Flags = (PropFlags)4503599627371028uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationQueryData:PathSolutionOptimized")]
	public List<FVector> PathSolutionOptimized;

	private static bool QueryStatus_IsValid;

	private static FFieldAddress QueryStatus_PropertyAddress;

	private static int QueryStatus_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/DonAINavigation.DoNNavigationQueryData:QueryStatus")]
	public EDonNavigationQueryStatus QueryStatus;

	private static bool FDoNNavigationQueryData_IsValid;

	private static int FDoNNavigationQueryData_StructSize;

	public FDoNNavigationQueryData Copy()
	{
		FDoNNavigationQueryData result = this;
		if (PathSolutionOptimized != null)
		{
			result.PathSolutionOptimized = new List<FVector>(PathSolutionOptimized);
		}
		return result;
	}

	public static FDoNNavigationQueryData FromNative(IntPtr nativeBuffer)
	{
		return new FDoNNavigationQueryData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDoNNavigationQueryData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDoNNavigationQueryData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDoNNavigationQueryData(nativeBuffer + arrayIndex * FDoNNavigationQueryData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDoNNavigationQueryData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDoNNavigationQueryData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDoNNavigationQueryData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DonAINavigation.DoNNavigationQueryData");
			return;
		}
		TWeakObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Actor_Offset), Actor);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Origin_Offset), Origin);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Destination_Offset), Destination);
		FDoNNavigationQueryParams.ToNative(IntPtr.Add(nativeStruct, QueryParams_Offset), QueryParams);
		new TArrayCopyMarshaler<FVector>(1, PathSolutionOptimized_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PathSolutionOptimized_Offset), PathSolutionOptimized);
		EnumMarshaler<EDonNavigationQueryStatus>.ToNative(IntPtr.Add(nativeStruct, QueryStatus_Offset), 0, QueryStatus_PropertyAddress.Address, QueryStatus);
	}

	public FDoNNavigationQueryData(IntPtr nativeStruct)
	{
		if (!FDoNNavigationQueryData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DonAINavigation.DoNNavigationQueryData");
			Actor = default(TWeakObject<AActor>);
			Origin = default(FVector);
			Destination = default(FVector);
			QueryParams = default(FDoNNavigationQueryParams);
			PathSolutionOptimized = null;
			QueryStatus = EDonNavigationQueryStatus.Unscheduled;
		}
		else
		{
			Actor = TWeakObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Actor_Offset));
			Origin = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Origin_Offset));
			Destination = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Destination_Offset));
			QueryParams = FDoNNavigationQueryParams.FromNative(IntPtr.Add(nativeStruct, QueryParams_Offset));
			PathSolutionOptimized = new TArrayCopyMarshaler<FVector>(1, PathSolutionOptimized_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PathSolutionOptimized_Offset));
			QueryStatus = EnumMarshaler<EDonNavigationQueryStatus>.FromNative(IntPtr.Add(nativeStruct, QueryStatus_Offset), 0, QueryStatus_PropertyAddress.Address);
		}
	}

	static FDoNNavigationQueryData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDoNNavigationQueryData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDoNNavigationQueryData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DonAINavigation.DoNNavigationQueryData");
		FDoNNavigationQueryData_StructSize = NativeReflection.GetStructSize(intPtr);
		Actor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Actor");
		Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Actor", Classes.FWeakObjectProperty);
		Origin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Origin");
		Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Origin", Classes.FStructProperty);
		Destination_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Destination");
		Destination_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Destination", Classes.FStructProperty);
		QueryParams_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "QueryParams");
		QueryParams_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "QueryParams", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PathSolutionOptimized_PropertyAddress, intPtr, "PathSolutionOptimized");
		PathSolutionOptimized_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PathSolutionOptimized");
		PathSolutionOptimized_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PathSolutionOptimized", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref QueryStatus_PropertyAddress, intPtr, "QueryStatus");
		QueryStatus_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "QueryStatus");
		QueryStatus_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "QueryStatus", Classes.FEnumProperty);
		FDoNNavigationQueryData_IsValid = intPtr != IntPtr.Zero && Actor_IsValid && Origin_IsValid && Destination_IsValid && QueryParams_IsValid && PathSolutionOptimized_IsValid && QueryStatus_IsValid;
		NativeReflection.LogStructIsValid("/Script/DonAINavigation.DoNNavigationQueryData", FDoNNavigationQueryData_IsValid);
	}
}
