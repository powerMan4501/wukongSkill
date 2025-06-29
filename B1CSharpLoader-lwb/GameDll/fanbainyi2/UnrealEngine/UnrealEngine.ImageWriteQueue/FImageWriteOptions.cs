using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.ImageWriteQueue;

[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/ImageWriteQueue.ImageWriteOptions", "ImageWriteQueue", UnrealModuleType.Engine)]
public struct FImageWriteOptions
{
	private static bool Format_IsValid;

	private static FFieldAddress Format_PropertyAddress;

	private static int Format_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ImageWriteQueue.ImageWriteOptions:Format")]
	public EDesiredImageFormat Format;

	private static bool OnComplete_IsValid;

	private static int OnComplete_Offset;

	[UProperty(Flags = (PropFlags)4503668347372036uL)]
	[UMetaPath("/Script/ImageWriteQueue.ImageWriteOptions:OnComplete")]
	public FOnImageWriteComplete OnComplete;

	private static bool CompressionQuality_IsValid;

	private static int CompressionQuality_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ImageWriteQueue.ImageWriteOptions:CompressionQuality")]
	public int CompressionQuality;

	private static bool OverwriteFile_IsValid;

	private static FFieldAddress OverwriteFile_PropertyAddress;

	private static int OverwriteFile_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ImageWriteQueue.ImageWriteOptions:bOverwriteFile")]
	public bool OverwriteFile;

	private static bool Async_IsValid;

	private static FFieldAddress Async_PropertyAddress;

	private static int Async_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ImageWriteQueue.ImageWriteOptions:bAsync")]
	public bool Async;

	private static bool FImageWriteOptions_IsValid;

	private static int FImageWriteOptions_StructSize;

	public FImageWriteOptions Copy()
	{
		return this;
	}

	public static FImageWriteOptions FromNative(IntPtr nativeBuffer)
	{
		return new FImageWriteOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FImageWriteOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FImageWriteOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FImageWriteOptions(nativeBuffer + arrayIndex * FImageWriteOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FImageWriteOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FImageWriteOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FImageWriteOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ImageWriteQueue.ImageWriteOptions");
			return;
		}
		EnumMarshaler<EDesiredImageFormat>.ToNative(IntPtr.Add(nativeStruct, Format_Offset), 0, Format_PropertyAddress.Address, Format);
		FDelegateMarshaler<FOnImageWriteComplete>.ToNative(IntPtr.Add(nativeStruct, OnComplete_Offset), OnComplete);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CompressionQuality_Offset), CompressionQuality);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OverwriteFile_Offset), 0, OverwriteFile_PropertyAddress.Address, OverwriteFile);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Async_Offset), 0, Async_PropertyAddress.Address, Async);
	}

	public FImageWriteOptions(IntPtr nativeStruct)
	{
		if (!FImageWriteOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ImageWriteQueue.ImageWriteOptions");
			Format = EDesiredImageFormat.PNG;
			OnComplete = new FOnImageWriteComplete();
			CompressionQuality = 0;
			OverwriteFile = false;
			Async = false;
		}
		else
		{
			Format = EnumMarshaler<EDesiredImageFormat>.FromNative(IntPtr.Add(nativeStruct, Format_Offset), 0, Format_PropertyAddress.Address);
			OnComplete = FDelegateMarshaler<FOnImageWriteComplete>.FromNative(IntPtr.Add(nativeStruct, OnComplete_Offset));
			CompressionQuality = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CompressionQuality_Offset));
			OverwriteFile = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OverwriteFile_Offset), 0, OverwriteFile_PropertyAddress.Address);
			Async = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Async_Offset), 0, Async_PropertyAddress.Address);
		}
	}

	static FImageWriteOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FImageWriteOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FImageWriteOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ImageWriteQueue.ImageWriteOptions");
		FImageWriteOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Format_PropertyAddress, intPtr, "Format");
		Format_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Format");
		Format_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Format", Classes.FEnumProperty);
		OnComplete_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnComplete");
		OnComplete_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnComplete", Classes.FDelegateProperty);
		CompressionQuality_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CompressionQuality");
		CompressionQuality_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CompressionQuality", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OverwriteFile_PropertyAddress, intPtr, "bOverwriteFile");
		OverwriteFile_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverwriteFile");
		OverwriteFile_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverwriteFile", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Async_PropertyAddress, intPtr, "bAsync");
		Async_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAsync");
		Async_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAsync", Classes.FBoolProperty);
		FImageWriteOptions_IsValid = intPtr != IntPtr.Zero && Format_IsValid && OnComplete_IsValid && CompressionQuality_IsValid && OverwriteFile_IsValid && Async_IsValid;
		NativeReflection.LogStructIsValid("/Script/ImageWriteQueue.ImageWriteOptions", FImageWriteOptions_IsValid);
	}
}
