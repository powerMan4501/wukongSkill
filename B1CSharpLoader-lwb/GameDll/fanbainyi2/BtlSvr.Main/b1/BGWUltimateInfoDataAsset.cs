using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWUltimateInfoDataAsset")]
public class BGWUltimateInfoDataAsset : UBGWDataAsset
{
	private static bool UltimateSkillConfigInfo_IsValid;

	private static int UltimateSkillConfigInfo_Offset;

	private static FFieldAddress UltimateSkillConfigInfo_PropertyAddress;

	private TArrayReadWriteMarshaler<FUltimateSkillConfigInfo> UltimateSkillConfigInfo_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWUltimateInfoDataAsset:UltimateSkillConfigInfo")]
	public TArrayReadWrite<FUltimateSkillConfigInfo> UltimateSkillConfigInfo
	{
		get
		{
			CheckDestroyed();
			if (!UltimateSkillConfigInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWUltimateInfoDataAsset:UltimateSkillConfigInfo");
				return null;
			}
			if (UltimateSkillConfigInfo_Marshaler == null)
			{
				UltimateSkillConfigInfo_Marshaler = new TArrayReadWriteMarshaler<FUltimateSkillConfigInfo>(1, UltimateSkillConfigInfo_PropertyAddress, CachedMarshalingDelegates<FUltimateSkillConfigInfo, BlittableTypeMarshaler<FUltimateSkillConfigInfo>>.FromNative, CachedMarshalingDelegates<FUltimateSkillConfigInfo, BlittableTypeMarshaler<FUltimateSkillConfigInfo>>.ToNative);
			}
			return UltimateSkillConfigInfo_Marshaler.FromNative(IntPtr.Add(base.Address, UltimateSkillConfigInfo_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWUltimateInfoDataAsset");
		NativeReflection.GetPropertyRef(ref UltimateSkillConfigInfo_PropertyAddress, unrealStruct, "UltimateSkillConfigInfo");
		UltimateSkillConfigInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UltimateSkillConfigInfo");
		UltimateSkillConfigInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UltimateSkillConfigInfo", Classes.FArrayProperty);
	}

	static BGWUltimateInfoDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWUltimateInfoDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWUltimateInfoDataAsset));
	}
}
