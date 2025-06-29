using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[UStruct(Flags = 57857)]
[BlueprintType]
[UMetaPath("/Script/V8.JavascriptHeapStatistics", "V8", UnrealModuleType.GamePlugin)]
public struct FJavascriptHeapStatistics
{
	private static bool TotalHeapSize_IsValid;

	private static int TotalHeapSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/V8.JavascriptHeapStatistics:TotalHeapSize")]
	public int TotalHeapSize;

	private static bool TotalHeapSizeExecutable_IsValid;

	private static int TotalHeapSizeExecutable_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/V8.JavascriptHeapStatistics:TotalHeapSizeExecutable")]
	public int TotalHeapSizeExecutable;

	private static bool TotalPhysicalSize_IsValid;

	private static int TotalPhysicalSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/V8.JavascriptHeapStatistics:TotalPhysicalSize")]
	public int TotalPhysicalSize;

	private static bool TotalAvailableSize_IsValid;

	private static int TotalAvailableSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/V8.JavascriptHeapStatistics:TotalAvailableSize")]
	public int TotalAvailableSize;

	private static bool UsedHeapSize_IsValid;

	private static int UsedHeapSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/V8.JavascriptHeapStatistics:UsedHeapSize")]
	public int UsedHeapSize;

	private static bool HeapSizeLimit_IsValid;

	private static int HeapSizeLimit_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/V8.JavascriptHeapStatistics:HeapSizeLimit")]
	public int HeapSizeLimit;

	private static bool MallocedMemory_IsValid;

	private static int MallocedMemory_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/V8.JavascriptHeapStatistics:MallocedMemory")]
	public int MallocedMemory;

	private static bool DoesZapGarbage_IsValid;

	private static FFieldAddress DoesZapGarbage_PropertyAddress;

	private static int DoesZapGarbage_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/V8.JavascriptHeapStatistics:bDoesZapGarbage")]
	public bool DoesZapGarbage;

	private static bool FJavascriptHeapStatistics_IsValid;

	private static int FJavascriptHeapStatistics_StructSize;

	public FJavascriptHeapStatistics Copy()
	{
		return this;
	}

	public static FJavascriptHeapStatistics FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptHeapStatistics(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptHeapStatistics value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptHeapStatistics FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptHeapStatistics(nativeBuffer + arrayIndex * FJavascriptHeapStatistics_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptHeapStatistics value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptHeapStatistics_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptHeapStatistics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptHeapStatistics");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TotalHeapSize_Offset), TotalHeapSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TotalHeapSizeExecutable_Offset), TotalHeapSizeExecutable);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TotalPhysicalSize_Offset), TotalPhysicalSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TotalAvailableSize_Offset), TotalAvailableSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, UsedHeapSize_Offset), UsedHeapSize);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, HeapSizeLimit_Offset), HeapSizeLimit);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MallocedMemory_Offset), MallocedMemory);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DoesZapGarbage_Offset), 0, DoesZapGarbage_PropertyAddress.Address, DoesZapGarbage);
	}

	public FJavascriptHeapStatistics(IntPtr nativeStruct)
	{
		if (!FJavascriptHeapStatistics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/V8.JavascriptHeapStatistics");
			TotalHeapSize = 0;
			TotalHeapSizeExecutable = 0;
			TotalPhysicalSize = 0;
			TotalAvailableSize = 0;
			UsedHeapSize = 0;
			HeapSizeLimit = 0;
			MallocedMemory = 0;
			DoesZapGarbage = false;
		}
		else
		{
			TotalHeapSize = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TotalHeapSize_Offset));
			TotalHeapSizeExecutable = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TotalHeapSizeExecutable_Offset));
			TotalPhysicalSize = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TotalPhysicalSize_Offset));
			TotalAvailableSize = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TotalAvailableSize_Offset));
			UsedHeapSize = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, UsedHeapSize_Offset));
			HeapSizeLimit = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, HeapSizeLimit_Offset));
			MallocedMemory = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MallocedMemory_Offset));
			DoesZapGarbage = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DoesZapGarbage_Offset), 0, DoesZapGarbage_PropertyAddress.Address);
		}
	}

	static FJavascriptHeapStatistics()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptHeapStatistics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptHeapStatistics));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/V8.JavascriptHeapStatistics");
		FJavascriptHeapStatistics_StructSize = NativeReflection.GetStructSize(intPtr);
		TotalHeapSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TotalHeapSize");
		TotalHeapSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TotalHeapSize", Classes.FIntProperty);
		TotalHeapSizeExecutable_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TotalHeapSizeExecutable");
		TotalHeapSizeExecutable_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TotalHeapSizeExecutable", Classes.FIntProperty);
		TotalPhysicalSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TotalPhysicalSize");
		TotalPhysicalSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TotalPhysicalSize", Classes.FIntProperty);
		TotalAvailableSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TotalAvailableSize");
		TotalAvailableSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TotalAvailableSize", Classes.FIntProperty);
		UsedHeapSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UsedHeapSize");
		UsedHeapSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UsedHeapSize", Classes.FIntProperty);
		HeapSizeLimit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HeapSizeLimit");
		HeapSizeLimit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HeapSizeLimit", Classes.FIntProperty);
		MallocedMemory_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MallocedMemory");
		MallocedMemory_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MallocedMemory", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesZapGarbage_PropertyAddress, intPtr, "bDoesZapGarbage");
		DoesZapGarbage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDoesZapGarbage");
		DoesZapGarbage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDoesZapGarbage", Classes.FBoolProperty);
		FJavascriptHeapStatistics_IsValid = intPtr != IntPtr.Zero && TotalHeapSize_IsValid && TotalHeapSizeExecutable_IsValid && TotalPhysicalSize_IsValid && TotalAvailableSize_IsValid && UsedHeapSize_IsValid && HeapSizeLimit_IsValid && MallocedMemory_IsValid && DoesZapGarbage_IsValid;
		NativeReflection.LogStructIsValid("/Script/V8.JavascriptHeapStatistics", FJavascriptHeapStatistics_IsValid);
	}
}
