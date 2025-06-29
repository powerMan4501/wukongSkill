using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_LevelInfo")]
public class BGWDataAsset_LevelInfo : UBGWDataAsset
{
	private static bool MainLevelInfo_IsValid;

	private static int MainLevelInfo_Offset;

	private static bool LiteLevelInfo_IsValid;

	private static int LiteLevelInfo_Offset;

	private static bool LevelTagToLevelIdMap_IsValid;

	private static int LevelTagToLevelIdMap_Offset;

	private static FFieldAddress LevelTagToLevelIdMap_PropertyAddress;

	private TMapReadWriteMarshaler<ELevelTag, FLevelIdListInfo> LevelTagToLevelIdMap_Marshaler;

	[DisplayName("B1地图信息")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LevelInfo:MainLevelInfo")]
	public FDetailLevelInfo MainLevelInfo
	{
		get
		{
			CheckDestroyed();
			if (!MainLevelInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LevelInfo:MainLevelInfo");
				return default(FDetailLevelInfo);
			}
			return BlittableTypeMarshaler<FDetailLevelInfo>.FromNative(IntPtr.Add(base.Address, MainLevelInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MainLevelInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LevelInfo:MainLevelInfo");
			}
			else
			{
				BlittableTypeMarshaler<FDetailLevelInfo>.ToNative(IntPtr.Add(base.Address, MainLevelInfo_Offset), value);
			}
		}
	}

	[DisplayName("小工程地图信息")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LevelInfo:LiteLevelInfo")]
	public FDetailLevelInfo LiteLevelInfo
	{
		get
		{
			CheckDestroyed();
			if (!LiteLevelInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LevelInfo:LiteLevelInfo");
				return default(FDetailLevelInfo);
			}
			return BlittableTypeMarshaler<FDetailLevelInfo>.FromNative(IntPtr.Add(base.Address, LiteLevelInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LiteLevelInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LevelInfo:LiteLevelInfo");
			}
			else
			{
				BlittableTypeMarshaler<FDetailLevelInfo>.ToNative(IntPtr.Add(base.Address, LiteLevelInfo_Offset), value);
			}
		}
	}

	[DisplayName("关卡Tag映射表")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_LevelInfo:LevelTagToLevelIdMap")]
	public TMapReadWrite<ELevelTag, FLevelIdListInfo> LevelTagToLevelIdMap
	{
		get
		{
			CheckDestroyed();
			if (!LevelTagToLevelIdMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_LevelInfo:LevelTagToLevelIdMap");
				return null;
			}
			if (LevelTagToLevelIdMap_Marshaler == null)
			{
				LevelTagToLevelIdMap_Marshaler = new TMapReadWriteMarshaler<ELevelTag, FLevelIdListInfo>(1, LevelTagToLevelIdMap_PropertyAddress, CachedMarshalingDelegates<ELevelTag, EnumMarshaler<ELevelTag>>.FromNative, CachedMarshalingDelegates<ELevelTag, EnumMarshaler<ELevelTag>>.ToNative, CachedMarshalingDelegates<FLevelIdListInfo, FLevelIdListInfo>.FromNative, CachedMarshalingDelegates<FLevelIdListInfo, FLevelIdListInfo>.ToNative);
			}
			return LevelTagToLevelIdMap_Marshaler.FromNative(IntPtr.Add(base.Address, LevelTagToLevelIdMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_LevelInfo");
		MainLevelInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MainLevelInfo");
		MainLevelInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MainLevelInfo", Classes.FStructProperty);
		LiteLevelInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LiteLevelInfo");
		LiteLevelInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LiteLevelInfo", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref LevelTagToLevelIdMap_PropertyAddress, unrealStruct, "LevelTagToLevelIdMap");
		LevelTagToLevelIdMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LevelTagToLevelIdMap");
		LevelTagToLevelIdMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LevelTagToLevelIdMap", Classes.FMapProperty);
	}

	static BGWDataAsset_LevelInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_LevelInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_LevelInfo));
	}
}
