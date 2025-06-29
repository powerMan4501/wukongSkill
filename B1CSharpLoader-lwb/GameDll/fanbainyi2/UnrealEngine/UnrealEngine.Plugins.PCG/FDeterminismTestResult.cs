using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/PCG.DeterminismTestResult", "PCG", UnrealModuleType.EnginePlugin)]
public struct FDeterminismTestResult
{
	private static bool TestResultTitle_IsValid;

	private static int TestResultTitle_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/PCG.DeterminismTestResult:TestResultTitle")]
	public FName TestResultTitle;

	private static bool TestResultName_IsValid;

	private static int TestResultName_Offset;

	[UProperty(Flags = (PropFlags)6755399441187349uL)]
	[UMetaPath("/Script/PCG.DeterminismTestResult:TestResultName")]
	public string TestResultName;

	private static bool Seed_IsValid;

	private static int Seed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.DeterminismTestResult:Seed")]
	public int Seed;

	private static bool DataTypesTested_IsValid;

	private static FFieldAddress DataTypesTested_PropertyAddress;

	private static int DataTypesTested_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.DeterminismTestResult:DataTypesTested")]
	public EPCGDataType DataTypesTested;

	private static bool TestResults_IsValid;

	private static FFieldAddress TestResults_PropertyAddress;

	private static int TestResults_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.DeterminismTestResult:TestResults")]
	public Dictionary<FName, EDeterminismLevel> TestResults;

	private static bool AdditionalDetails_IsValid;

	private static FFieldAddress AdditionalDetails_PropertyAddress;

	private static int AdditionalDetails_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.DeterminismTestResult:AdditionalDetails")]
	public List<string> AdditionalDetails;

	private static bool FlagRaised_IsValid;

	private static FFieldAddress FlagRaised_PropertyAddress;

	private static int FlagRaised_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.DeterminismTestResult:bFlagRaised")]
	public bool FlagRaised;

	private static bool FDeterminismTestResult_IsValid;

	private static int FDeterminismTestResult_StructSize;

	public FDeterminismTestResult Copy()
	{
		FDeterminismTestResult result = this;
		if (TestResults != null)
		{
			result.TestResults = new Dictionary<FName, EDeterminismLevel>(TestResults);
		}
		if (AdditionalDetails != null)
		{
			result.AdditionalDetails = new List<string>(AdditionalDetails);
		}
		return result;
	}

	public static FDeterminismTestResult FromNative(IntPtr nativeBuffer)
	{
		return new FDeterminismTestResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDeterminismTestResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDeterminismTestResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDeterminismTestResult(nativeBuffer + arrayIndex * FDeterminismTestResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDeterminismTestResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDeterminismTestResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDeterminismTestResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.DeterminismTestResult");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, TestResultTitle_Offset), TestResultTitle);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, TestResultName_Offset), TestResultName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Seed_Offset), Seed);
		EnumMarshaler<EPCGDataType>.ToNative(IntPtr.Add(nativeStruct, DataTypesTested_Offset), 0, DataTypesTested_PropertyAddress.Address, DataTypesTested);
		new TMapCopyMarshaler<FName, EDeterminismLevel>(1, TestResults_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<EDeterminismLevel, EnumMarshaler<EDeterminismLevel>>.FromNative, CachedMarshalingDelegates<EDeterminismLevel, EnumMarshaler<EDeterminismLevel>>.ToNative).ToNative(IntPtr.Add(nativeStruct, TestResults_Offset), TestResults);
		new TArrayCopyMarshaler<string>(1, AdditionalDetails_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, AdditionalDetails_Offset), AdditionalDetails);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FlagRaised_Offset), 0, FlagRaised_PropertyAddress.Address, FlagRaised);
	}

	public FDeterminismTestResult(IntPtr nativeStruct)
	{
		if (!FDeterminismTestResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.DeterminismTestResult");
			TestResultTitle = default(FName);
			TestResultName = FStringMarshaler.DefaultString;
			Seed = 0;
			DataTypesTested = EPCGDataType.None;
			TestResults = null;
			AdditionalDetails = null;
			FlagRaised = false;
		}
		else
		{
			TestResultTitle = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, TestResultTitle_Offset));
			TestResultName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, TestResultName_Offset));
			Seed = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Seed_Offset));
			DataTypesTested = EnumMarshaler<EPCGDataType>.FromNative(IntPtr.Add(nativeStruct, DataTypesTested_Offset), 0, DataTypesTested_PropertyAddress.Address);
			TestResults = new TMapCopyMarshaler<FName, EDeterminismLevel>(1, TestResults_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<EDeterminismLevel, EnumMarshaler<EDeterminismLevel>>.FromNative, CachedMarshalingDelegates<EDeterminismLevel, EnumMarshaler<EDeterminismLevel>>.ToNative).FromNative(IntPtr.Add(nativeStruct, TestResults_Offset));
			AdditionalDetails = new TArrayCopyMarshaler<string>(1, AdditionalDetails_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, AdditionalDetails_Offset));
			FlagRaised = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FlagRaised_Offset), 0, FlagRaised_PropertyAddress.Address);
		}
	}

	static FDeterminismTestResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDeterminismTestResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDeterminismTestResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.DeterminismTestResult");
		FDeterminismTestResult_StructSize = NativeReflection.GetStructSize(intPtr);
		TestResultTitle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TestResultTitle");
		TestResultTitle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TestResultTitle", Classes.FNameProperty);
		TestResultName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TestResultName");
		TestResultName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TestResultName", Classes.FStrProperty);
		Seed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Seed");
		Seed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Seed", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DataTypesTested_PropertyAddress, intPtr, "DataTypesTested");
		DataTypesTested_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DataTypesTested");
		DataTypesTested_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DataTypesTested", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref TestResults_PropertyAddress, intPtr, "TestResults");
		TestResults_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TestResults");
		TestResults_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TestResults", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref AdditionalDetails_PropertyAddress, intPtr, "AdditionalDetails");
		AdditionalDetails_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AdditionalDetails");
		AdditionalDetails_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AdditionalDetails", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref FlagRaised_PropertyAddress, intPtr, "bFlagRaised");
		FlagRaised_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFlagRaised");
		FlagRaised_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFlagRaised", Classes.FBoolProperty);
		FDeterminismTestResult_IsValid = intPtr != IntPtr.Zero && TestResultTitle_IsValid && TestResultName_IsValid && Seed_IsValid && DataTypesTested_IsValid && TestResults_IsValid && AdditionalDetails_IsValid && FlagRaised_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.DeterminismTestResult", FDeterminismTestResult_IsValid);
	}
}
