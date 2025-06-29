using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.AssetRegistry;

[Abstract]
[UInterface(Flags = 810041505u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AssetRegistry.AssetRegistry", "AssetRegistry", UnrealModuleType.Engine, InterfaceImpl = typeof(IAssetRegistryImpl))]
public interface IAssetRegistry : IInterface
{
	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:WaitForPackage")]
	void WaitForPackage(string PackageName);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:WaitForCompletion")]
	void WaitForCompletion();

	[UFunction(Flags = 1153565696u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:UseFilterToExcludeAssets")]
	void UseFilterToExcludeAssets(ref List<FAssetData> AssetDataList, FARFilter Filter);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:SearchAllAssets")]
	void SearchAllAssets(bool bSynchronousSearch);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:ScanPathsSynchronous")]
	void ScanPathsSynchronous(List<string> InPaths, bool bForceRescan = false, bool bIgnoreDenyListScanFilters = false);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:ScanModifiedAssetFiles")]
	void ScanModifiedAssetFiles(List<string> InFilePaths);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:ScanFilesSynchronous")]
	void ScanFilesSynchronous(List<string> InFilePaths, bool bForceRescan = false);

	[UFunction(Flags = 1153565696u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:RunAssetsThroughFilter")]
	void RunAssetsThroughFilter(ref List<FAssetData> AssetDataList, FARFilter Filter);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:PrioritizeSearchPath")]
	void PrioritizeSearchPath(string PathToPrioritize);

	[UFunction(Flags = 1145177088u, OriginalName = "K2_GetReferencers")]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:K2_GetReferencers")]
	bool GetReferencers(FName PackageName, FAssetRegistryDependencyOptions ReferenceOptions, out List<FName> OutReferencers);

	[UFunction(Flags = 1145177088u, OriginalName = "K2_GetDependencies")]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:K2_GetDependencies")]
	bool GetDependencies(FName PackageName, FAssetRegistryDependencyOptions DependencyOptions, out List<FName> OutDependencies);

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:IsSearchAsync")]
	bool IsSearchAsync();

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:IsSearchAllAssets")]
	bool IsSearchAllAssets();

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:IsLoadingAssets")]
	bool IsLoadingAssets();

	[UFunction(Flags = 1140982784u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:HasAssets")]
	bool HasAssets(FName PackagePath, bool bRecursive = false);

	[UFunction(Flags = 1145177088u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:GetSubPaths")]
	void GetSubPaths(string InBasePath, out List<string> OutPathList, bool bInRecurse);

	[UFunction(Flags = 1145177088u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:GetAssetsByPaths")]
	bool GetAssetsByPaths(List<FName> PackagePaths, out List<FAssetData> OutAssetData, bool bRecursive = false, bool bIncludeOnlyOnDiskAssets = false);

	[UFunction(Flags = 1145177088u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:GetAssetsByPath")]
	bool GetAssetsByPath(FName PackagePath, out List<FAssetData> OutAssetData, bool bRecursive = false, bool bIncludeOnlyOnDiskAssets = false);

	[UFunction(Flags = 1145177088u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:GetAssetsByPackageName")]
	bool GetAssetsByPackageName(FName PackageName, out List<FAssetData> OutAssetData, bool bIncludeOnlyOnDiskAssets = false);

	[UFunction(Flags = 1145177088u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:GetAssetsByClass")]
	bool GetAssetsByClass(FName ClassName, out List<FAssetData> OutAssetData, bool bSearchSubClasses = false);

	[UFunction(Flags = 1153565696u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:GetAssets")]
	bool GetAssets(FARFilter Filter, out List<FAssetData> OutAssetData);

	[UFunction(Flags = 1149371392u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:GetAssetByObjectPath")]
	FAssetData GetAssetByObjectPath(FName ObjectPath, bool bIncludeOnlyOnDiskAssets = false);

	[UFunction(Flags = 1145177088u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:GetAllCachedPaths")]
	void GetAllCachedPaths(out List<string> OutPathList);

	[UFunction(Flags = 1145177088u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:GetAllAssets")]
	bool GetAllAssets(out List<FAssetData> OutAssetData, bool bIncludeOnlyOnDiskAssets = false);
}
