using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.TraceChannelTestBatchOptions", "FunctionalTesting", UnrealModuleType.Engine)]
public struct FTraceChannelTestBatchOptions
{
	private static bool LineTrace_IsValid;

	private static FFieldAddress LineTrace_PropertyAddress;

	private static int LineTrace_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceChannelTestBatchOptions:bLineTrace")]
	public bool LineTrace;

	private static bool SphereTrace_IsValid;

	private static FFieldAddress SphereTrace_PropertyAddress;

	private static int SphereTrace_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceChannelTestBatchOptions:bSphereTrace")]
	public bool SphereTrace;

	private static bool CapsuleTrace_IsValid;

	private static FFieldAddress CapsuleTrace_PropertyAddress;

	private static int CapsuleTrace_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceChannelTestBatchOptions:bCapsuleTrace")]
	public bool CapsuleTrace;

	private static bool BoxTrace_IsValid;

	private static FFieldAddress BoxTrace_PropertyAddress;

	private static int BoxTrace_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceChannelTestBatchOptions:bBoxTrace")]
	public bool BoxTrace;

	private static bool ChannelTrace_IsValid;

	private static FFieldAddress ChannelTrace_PropertyAddress;

	private static int ChannelTrace_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceChannelTestBatchOptions:bChannelTrace")]
	public bool ChannelTrace;

	private static bool ObjectsTrace_IsValid;

	private static FFieldAddress ObjectsTrace_PropertyAddress;

	private static int ObjectsTrace_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceChannelTestBatchOptions:bObjectsTrace")]
	public bool ObjectsTrace;

	private static bool ProfileTrace_IsValid;

	private static FFieldAddress ProfileTrace_PropertyAddress;

	private static int ProfileTrace_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.TraceChannelTestBatchOptions:bProfileTrace")]
	public bool ProfileTrace;

	private static bool FTraceChannelTestBatchOptions_IsValid;

	private static int FTraceChannelTestBatchOptions_StructSize;

	public FTraceChannelTestBatchOptions Copy()
	{
		return this;
	}

	public static FTraceChannelTestBatchOptions FromNative(IntPtr nativeBuffer)
	{
		return new FTraceChannelTestBatchOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTraceChannelTestBatchOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTraceChannelTestBatchOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTraceChannelTestBatchOptions(nativeBuffer + arrayIndex * FTraceChannelTestBatchOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTraceChannelTestBatchOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTraceChannelTestBatchOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTraceChannelTestBatchOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.TraceChannelTestBatchOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, LineTrace_Offset), 0, LineTrace_PropertyAddress.Address, LineTrace);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SphereTrace_Offset), 0, SphereTrace_PropertyAddress.Address, SphereTrace);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CapsuleTrace_Offset), 0, CapsuleTrace_PropertyAddress.Address, CapsuleTrace);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, BoxTrace_Offset), 0, BoxTrace_PropertyAddress.Address, BoxTrace);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ChannelTrace_Offset), 0, ChannelTrace_PropertyAddress.Address, ChannelTrace);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ObjectsTrace_Offset), 0, ObjectsTrace_PropertyAddress.Address, ObjectsTrace);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ProfileTrace_Offset), 0, ProfileTrace_PropertyAddress.Address, ProfileTrace);
	}

	public FTraceChannelTestBatchOptions(IntPtr nativeStruct)
	{
		if (!FTraceChannelTestBatchOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.TraceChannelTestBatchOptions");
			LineTrace = false;
			SphereTrace = false;
			CapsuleTrace = false;
			BoxTrace = false;
			ChannelTrace = false;
			ObjectsTrace = false;
			ProfileTrace = false;
		}
		else
		{
			LineTrace = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, LineTrace_Offset), 0, LineTrace_PropertyAddress.Address);
			SphereTrace = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SphereTrace_Offset), 0, SphereTrace_PropertyAddress.Address);
			CapsuleTrace = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CapsuleTrace_Offset), 0, CapsuleTrace_PropertyAddress.Address);
			BoxTrace = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, BoxTrace_Offset), 0, BoxTrace_PropertyAddress.Address);
			ChannelTrace = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ChannelTrace_Offset), 0, ChannelTrace_PropertyAddress.Address);
			ObjectsTrace = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ObjectsTrace_Offset), 0, ObjectsTrace_PropertyAddress.Address);
			ProfileTrace = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ProfileTrace_Offset), 0, ProfileTrace_PropertyAddress.Address);
		}
	}

	static FTraceChannelTestBatchOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTraceChannelTestBatchOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTraceChannelTestBatchOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FunctionalTesting.TraceChannelTestBatchOptions");
		FTraceChannelTestBatchOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref LineTrace_PropertyAddress, intPtr, "bLineTrace");
		LineTrace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLineTrace");
		LineTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLineTrace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereTrace_PropertyAddress, intPtr, "bSphereTrace");
		SphereTrace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSphereTrace");
		SphereTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSphereTrace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CapsuleTrace_PropertyAddress, intPtr, "bCapsuleTrace");
		CapsuleTrace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCapsuleTrace");
		CapsuleTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCapsuleTrace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BoxTrace_PropertyAddress, intPtr, "bBoxTrace");
		BoxTrace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBoxTrace");
		BoxTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBoxTrace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ChannelTrace_PropertyAddress, intPtr, "bChannelTrace");
		ChannelTrace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bChannelTrace");
		ChannelTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bChannelTrace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ObjectsTrace_PropertyAddress, intPtr, "bObjectsTrace");
		ObjectsTrace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bObjectsTrace");
		ObjectsTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bObjectsTrace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ProfileTrace_PropertyAddress, intPtr, "bProfileTrace");
		ProfileTrace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bProfileTrace");
		ProfileTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bProfileTrace", Classes.FBoolProperty);
		FTraceChannelTestBatchOptions_IsValid = intPtr != IntPtr.Zero && LineTrace_IsValid && SphereTrace_IsValid && CapsuleTrace_IsValid && BoxTrace_IsValid && ChannelTrace_IsValid && ObjectsTrace_IsValid && ProfileTrace_IsValid;
		NativeReflection.LogStructIsValid("/Script/FunctionalTesting.TraceChannelTestBatchOptions", FTraceChannelTestBatchOptions_IsValid);
	}
}
