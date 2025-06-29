using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkExternalSourceInfo", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkExternalSourceInfo
{
	private static bool ExternalSrcName_IsValid;

	private static int ExternalSrcName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/AkAudio.AkExternalSourceInfo:ExternalSrcName")]
	public string ExternalSrcName;

	private static bool CodecID_IsValid;

	private static FFieldAddress CodecID_PropertyAddress;

	private static int CodecID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkExternalSourceInfo:CodecID")]
	public EAkCodecId CodecID;

	private static bool FileName_IsValid;

	private static int FileName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/AkAudio.AkExternalSourceInfo:FileName")]
	public string FileName;

	private static bool ExternalSourceAsset_IsValid;

	private static int ExternalSourceAsset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkExternalSourceInfo:ExternalSourceAsset")]
	public UAkExternalMediaAsset ExternalSourceAsset;

	private static bool IsStreamed_IsValid;

	private static FFieldAddress IsStreamed_PropertyAddress;

	private static int IsStreamed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkExternalSourceInfo:IsStreamed")]
	public bool IsStreamed;

	private static bool FAkExternalSourceInfo_IsValid;

	private static int FAkExternalSourceInfo_StructSize;

	public FAkExternalSourceInfo Copy()
	{
		return this;
	}

	public static FAkExternalSourceInfo FromNative(IntPtr nativeBuffer)
	{
		return new FAkExternalSourceInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkExternalSourceInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkExternalSourceInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkExternalSourceInfo(nativeBuffer + arrayIndex * FAkExternalSourceInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkExternalSourceInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkExternalSourceInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkExternalSourceInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkExternalSourceInfo");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ExternalSrcName_Offset), ExternalSrcName);
		EnumMarshaler<EAkCodecId>.ToNative(IntPtr.Add(nativeStruct, CodecID_Offset), 0, CodecID_PropertyAddress.Address, CodecID);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, FileName_Offset), FileName);
		UObjectMarshaler<UAkExternalMediaAsset>.ToNative(IntPtr.Add(nativeStruct, ExternalSourceAsset_Offset), ExternalSourceAsset);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsStreamed_Offset), 0, IsStreamed_PropertyAddress.Address, IsStreamed);
	}

	public FAkExternalSourceInfo(IntPtr nativeStruct)
	{
		if (!FAkExternalSourceInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkExternalSourceInfo");
			ExternalSrcName = FStringMarshaler.DefaultString;
			CodecID = EAkCodecId.None;
			FileName = FStringMarshaler.DefaultString;
			ExternalSourceAsset = null;
			IsStreamed = false;
		}
		else
		{
			ExternalSrcName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ExternalSrcName_Offset));
			CodecID = EnumMarshaler<EAkCodecId>.FromNative(IntPtr.Add(nativeStruct, CodecID_Offset), 0, CodecID_PropertyAddress.Address);
			FileName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, FileName_Offset));
			ExternalSourceAsset = UObjectMarshaler<UAkExternalMediaAsset>.FromNative(IntPtr.Add(nativeStruct, ExternalSourceAsset_Offset));
			IsStreamed = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsStreamed_Offset), 0, IsStreamed_PropertyAddress.Address);
		}
	}

	static FAkExternalSourceInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkExternalSourceInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkExternalSourceInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkExternalSourceInfo");
		FAkExternalSourceInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		ExternalSrcName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExternalSrcName");
		ExternalSrcName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExternalSrcName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CodecID_PropertyAddress, intPtr, "CodecID");
		CodecID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CodecID");
		CodecID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CodecID", Classes.FEnumProperty);
		FileName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FileName");
		FileName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FileName", Classes.FStrProperty);
		ExternalSourceAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExternalSourceAsset");
		ExternalSourceAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExternalSourceAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsStreamed_PropertyAddress, intPtr, "IsStreamed");
		IsStreamed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsStreamed");
		IsStreamed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsStreamed", Classes.FBoolProperty);
		FAkExternalSourceInfo_IsValid = intPtr != IntPtr.Zero && ExternalSrcName_IsValid && CodecID_IsValid && FileName_IsValid && ExternalSourceAsset_IsValid && IsStreamed_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkExternalSourceInfo", FAkExternalSourceInfo_IsValid);
	}
}
