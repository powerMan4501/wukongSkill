using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)817889440uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkMusicSyncCallbackInfo", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkMusicSyncCallbackInfo : UAkCallbackInfo
{
	private static bool PlayingID_IsValid;

	private static int PlayingID_Offset;

	private static bool SegmentInfo_IsValid;

	private static int SegmentInfo_Offset;

	private static bool MusicSyncType_IsValid;

	private static FFieldAddress MusicSyncType_PropertyAddress;

	private static int MusicSyncType_Offset;

	private static bool UserCueName_IsValid;

	private static int UserCueName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkMusicSyncCallbackInfo:PlayingID")]
	public int PlayingID
	{
		get
		{
			CheckDestroyed();
			if (!PlayingID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkMusicSyncCallbackInfo:PlayingID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PlayingID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayingID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkMusicSyncCallbackInfo:PlayingID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PlayingID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/AkAudio.AkMusicSyncCallbackInfo:SegmentInfo")]
	public FAkSegmentInfo SegmentInfo
	{
		get
		{
			CheckDestroyed();
			if (!SegmentInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkMusicSyncCallbackInfo:SegmentInfo");
				return default(FAkSegmentInfo);
			}
			return FAkSegmentInfo.FromNative(IntPtr.Add(base.Address, SegmentInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SegmentInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkMusicSyncCallbackInfo:SegmentInfo");
			}
			else
			{
				FAkSegmentInfo.ToNative(IntPtr.Add(base.Address, SegmentInfo_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkMusicSyncCallbackInfo:MusicSyncType")]
	public EAkCallbackType MusicSyncType
	{
		get
		{
			CheckDestroyed();
			if (!MusicSyncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkMusicSyncCallbackInfo:MusicSyncType");
				return EAkCallbackType.EndOfEvent;
			}
			return EnumMarshaler<EAkCallbackType>.FromNative(IntPtr.Add(base.Address, MusicSyncType_Offset), 0, MusicSyncType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MusicSyncType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkMusicSyncCallbackInfo:MusicSyncType");
			}
			else
			{
				EnumMarshaler<EAkCallbackType>.ToNative(IntPtr.Add(base.Address, MusicSyncType_Offset), 0, MusicSyncType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056277uL)]
	[UMetaPath("/Script/AkAudio.AkMusicSyncCallbackInfo:UserCueName")]
	public string UserCueName
	{
		get
		{
			CheckDestroyed();
			if (!UserCueName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkMusicSyncCallbackInfo:UserCueName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, UserCueName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UserCueName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkMusicSyncCallbackInfo:UserCueName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, UserCueName_Offset), value);
			}
		}
	}

	static UAkMusicSyncCallbackInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkMusicSyncCallbackInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkMusicSyncCallbackInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AkAudio.AkMusicSyncCallbackInfo");
		PlayingID_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PlayingID");
		PlayingID_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PlayingID", Classes.FIntProperty);
		SegmentInfo_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SegmentInfo");
		SegmentInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SegmentInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MusicSyncType_PropertyAddress, unrealStruct, "MusicSyncType");
		MusicSyncType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MusicSyncType");
		MusicSyncType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MusicSyncType", Classes.FEnumProperty);
		UserCueName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "UserCueName");
		UserCueName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "UserCueName", Classes.FStrProperty);
	}
}
