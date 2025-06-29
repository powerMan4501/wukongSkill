using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_GeneratePreloadDAConfig")]
public class BGWDataAsset_GeneratePreloadDAConfig : UBGWDataAsset
{
	private static bool bAutoIncludeItemLevels_IsValid;

	private static int bAutoIncludeItemLevels_Offset;

	private static FFieldAddress bAutoIncludeItemLevels_PropertyAddress;

	private static bool RootLevelFolderPaths_IsValid;

	private static int RootLevelFolderPaths_Offset;

	private static FFieldAddress RootLevelFolderPaths_PropertyAddress;

	private TArrayReadWriteMarshaler<string> RootLevelFolderPaths_Marshaler;

	private static bool LevelsForPreload_IsValid;

	private static int LevelsForPreload_Offset;

	private static FFieldAddress LevelsForPreload_PropertyAddress;

	private TArrayReadWriteMarshaler<TSoftObject<UWorld>> LevelsForPreload_Marshaler;

	private static bool TxtOutputName_IsValid;

	private static int TxtOutputName_Offset;

	private static bool PreloadDAOutputName_IsValid;

	private static int PreloadDAOutputName_Offset;

	[Tooltip("是否提供地图根路径自动索引所有item相关关卡")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GeneratePreloadDAConfig:bAutoIncludeItemLevels")]
	public bool bAutoIncludeItemLevels
	{
		get
		{
			CheckDestroyed();
			if (!bAutoIncludeItemLevels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GeneratePreloadDAConfig:bAutoIncludeItemLevels");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAutoIncludeItemLevels_Offset), 0, bAutoIncludeItemLevels_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAutoIncludeItemLevels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GeneratePreloadDAConfig:bAutoIncludeItemLevels");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAutoIncludeItemLevels_Offset), 0, bAutoIncludeItemLevels_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Tooltip("用于自动索引的地图根文件夹列表")]
	[UMeta(MDProp.EditCondition, "bAutoIncludeItemLevels")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GeneratePreloadDAConfig:RootLevelFolderPaths")]
	public TArrayReadWrite<string> RootLevelFolderPaths
	{
		get
		{
			CheckDestroyed();
			if (!RootLevelFolderPaths_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GeneratePreloadDAConfig:RootLevelFolderPaths");
				return null;
			}
			if (RootLevelFolderPaths_Marshaler == null)
			{
				RootLevelFolderPaths_Marshaler = new TArrayReadWriteMarshaler<string>(1, RootLevelFolderPaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return RootLevelFolderPaths_Marshaler.FromNative(IntPtr.Add(base.Address, RootLevelFolderPaths_Offset));
		}
	}

	[UMeta(MDProp.EditCondition, "!bAutoIncludeItemLevels")]
	[Tooltip("用于预加载的item关卡列表")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GeneratePreloadDAConfig:LevelsForPreload")]
	public TArrayReadWrite<TSoftObject<UWorld>> LevelsForPreload
	{
		get
		{
			CheckDestroyed();
			if (!LevelsForPreload_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GeneratePreloadDAConfig:LevelsForPreload");
				return null;
			}
			if (LevelsForPreload_Marshaler == null)
			{
				LevelsForPreload_Marshaler = new TArrayReadWriteMarshaler<TSoftObject<UWorld>>(1, LevelsForPreload_PropertyAddress, CachedMarshalingDelegates<TSoftObject<UWorld>, TSoftObjectMarshaler<UWorld>>.FromNative, CachedMarshalingDelegates<TSoftObject<UWorld>, TSoftObjectMarshaler<UWorld>>.ToNative);
			}
			return LevelsForPreload_Marshaler.FromNative(IntPtr.Add(base.Address, LevelsForPreload_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("txt输出文件名（路径默认为unreal_proj/Saved/PreloadAssetList-TxtOutputName.txt）")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GeneratePreloadDAConfig:TxtOutputName")]
	public string TxtOutputName
	{
		get
		{
			CheckDestroyed();
			if (!TxtOutputName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GeneratePreloadDAConfig:TxtOutputName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, TxtOutputName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TxtOutputName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GeneratePreloadDAConfig:TxtOutputName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, TxtOutputName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("PreloadDA生成文件名（路径默认在/Game/00Main/PreloadDataAsset/下），如果为空，则不会自动生成PreloadDA，只生成txt列表")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GeneratePreloadDAConfig:PreloadDAOutputName")]
	public string PreloadDAOutputName
	{
		get
		{
			CheckDestroyed();
			if (!PreloadDAOutputName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GeneratePreloadDAConfig:PreloadDAOutputName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, PreloadDAOutputName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreloadDAOutputName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GeneratePreloadDAConfig:PreloadDAOutputName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, PreloadDAOutputName_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_GeneratePreloadDAConfig");
		NativeReflection.GetPropertyRef(ref bAutoIncludeItemLevels_PropertyAddress, unrealStruct, "bAutoIncludeItemLevels");
		bAutoIncludeItemLevels_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bAutoIncludeItemLevels");
		bAutoIncludeItemLevels_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bAutoIncludeItemLevels", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref RootLevelFolderPaths_PropertyAddress, unrealStruct, "RootLevelFolderPaths");
		RootLevelFolderPaths_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RootLevelFolderPaths");
		RootLevelFolderPaths_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RootLevelFolderPaths", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LevelsForPreload_PropertyAddress, unrealStruct, "LevelsForPreload");
		LevelsForPreload_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LevelsForPreload");
		LevelsForPreload_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LevelsForPreload", Classes.FArrayProperty);
		TxtOutputName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TxtOutputName");
		TxtOutputName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TxtOutputName", Classes.FStrProperty);
		PreloadDAOutputName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PreloadDAOutputName");
		PreloadDAOutputName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PreloadDAOutputName", Classes.FStrProperty);
	}

	static BGWDataAsset_GeneratePreloadDAConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_GeneratePreloadDAConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_GeneratePreloadDAConfig));
	}
}
