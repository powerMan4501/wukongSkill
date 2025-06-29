using UnrealEngine.Runtime;

namespace UnrealEngine.AssetRegistry;

public static class UAssetRegistryHelpers_CsExtensions
{
	public static FSoftObjectPath ToSoftObjectPath(this FAssetData InAssetData)
	{
		return UAssetRegistryHelpers.ToSoftObjectPath(InAssetData);
	}

	public static bool IsValid(this FAssetData InAssetData)
	{
		return UAssetRegistryHelpers.IsValid(InAssetData);
	}

	public static bool IsUAsset(this FAssetData InAssetData)
	{
		return UAssetRegistryHelpers.IsUAsset(InAssetData);
	}

	public static bool IsRedirector(this FAssetData InAssetData)
	{
		return UAssetRegistryHelpers.IsRedirector(InAssetData);
	}

	public static bool IsAssetLoaded(this FAssetData InAssetData)
	{
		return UAssetRegistryHelpers.IsAssetLoaded(InAssetData);
	}

	public static bool GetTagValue(this FAssetData InAssetData, FName InTagName, out string OutTagValue)
	{
		return UAssetRegistryHelpers.GetTagValue(InAssetData, InTagName, out OutTagValue);
	}

	public static string GetFullName(this FAssetData InAssetData)
	{
		return UAssetRegistryHelpers.GetFullName(InAssetData);
	}

	public static string GetExportTextName(this FAssetData InAssetData)
	{
		return UAssetRegistryHelpers.GetExportTextName(InAssetData);
	}

	public static TSubclassOf<UObject> GetClass(this FAssetData InAssetData)
	{
		return UAssetRegistryHelpers.GetClass(InAssetData);
	}

	public static UObject GetAsset(this FAssetData InAssetData)
	{
		return UAssetRegistryHelpers.GetAsset(InAssetData);
	}
}
