using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/DownloadTookit.DownloadFile", "DownloadTookit", UnrealModuleType.Game)]
public struct FDownloadFile
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/DownloadTookit.DownloadFile:Name")]
	public string Name;

	private static bool URL_IsValid;

	private static int URL_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/DownloadTookit.DownloadFile:URL")]
	public string URL;

	private static bool Size_IsValid;

	private static int Size_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DownloadTookit.DownloadFile:Size")]
	public int Size;

	private static bool HASH_IsValid;

	private static int HASH_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/DownloadTookit.DownloadFile:HASH")]
	public string HASH;

	private static bool SavePath_IsValid;

	private static int SavePath_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/DownloadTookit.DownloadFile:SavePath")]
	public string SavePath;

	private static bool FDownloadFile_IsValid;

	private static int FDownloadFile_StructSize;

	public FDownloadFile Copy()
	{
		return this;
	}

	public static FDownloadFile FromNative(IntPtr nativeBuffer)
	{
		return new FDownloadFile(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDownloadFile value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDownloadFile FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDownloadFile(nativeBuffer + arrayIndex * FDownloadFile_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDownloadFile value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDownloadFile_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDownloadFile_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DownloadTookit.DownloadFile");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, URL_Offset), URL);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Size_Offset), Size);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, HASH_Offset), HASH);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, SavePath_Offset), SavePath);
	}

	public FDownloadFile(IntPtr nativeStruct)
	{
		if (!FDownloadFile_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DownloadTookit.DownloadFile");
			Name = FStringMarshaler.DefaultString;
			URL = FStringMarshaler.DefaultString;
			Size = 0;
			HASH = FStringMarshaler.DefaultString;
			SavePath = FStringMarshaler.DefaultString;
		}
		else
		{
			Name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			URL = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, URL_Offset));
			Size = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Size_Offset));
			HASH = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, HASH_Offset));
			SavePath = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, SavePath_Offset));
		}
	}

	static FDownloadFile()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDownloadFile)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDownloadFile));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DownloadTookit.DownloadFile");
		FDownloadFile_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FStrProperty);
		URL_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "URL");
		URL_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "URL", Classes.FStrProperty);
		Size_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Size");
		Size_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Size", Classes.FIntProperty);
		HASH_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HASH");
		HASH_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HASH", Classes.FStrProperty);
		SavePath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SavePath");
		SavePath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SavePath", Classes.FStrProperty);
		FDownloadFile_IsValid = intPtr != IntPtr.Zero && Name_IsValid && URL_IsValid && Size_IsValid && HASH_IsValid && SavePath_IsValid;
		NativeReflection.LogStructIsValid("/Script/DownloadTookit.DownloadFile", FDownloadFile_IsValid);
	}
}
