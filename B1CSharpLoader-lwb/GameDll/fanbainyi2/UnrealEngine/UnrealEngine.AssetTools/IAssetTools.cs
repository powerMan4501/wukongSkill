using System.Collections.Generic;
using UnrealEngine.Runtime;
using UnrealEngine.UnrealEd;

namespace UnrealEngine.AssetTools;

[Abstract]
[UInterface(Flags = 810041505u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AssetTools.AssetTools", "AssetTools", UnrealModuleType.Engine, InterfaceImpl = typeof(IAssetToolsImpl))]
public interface IAssetTools : IInterface
{
	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetTools.AssetTools:RenameReferencingSoftObjectPaths")]
	void RenameReferencingSoftObjectPaths(List<UPackage> PackagesToCheck, Dictionary<FSoftObjectPath, FSoftObjectPath> AssetRedirectorMap);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetTools.AssetTools:RenameAssetsWithDialog")]
	EAssetRenameResult RenameAssetsWithDialog(List<FAssetRenameData> AssetsAndNames, bool bAutoCheckout = false);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetTools.AssetTools:RenameAssets")]
	bool RenameAssets(List<FAssetRenameData> AssetsAndNames);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetTools.AssetTools:ImportAssetTasks")]
	void ImportAssetTasks(List<UAssetImportTask> ImportTasks);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetTools.AssetTools:ImportAssetsWithDialog")]
	List<UObject> ImportAssetsWithDialog(string DestinationPath);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetTools.AssetTools:ImportAssetsAutomated")]
	List<UObject> ImportAssetsAutomated(UAutomatedAssetImportData ImportData);

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/AssetTools.AssetTools:FindSoftReferencesToObject")]
	void FindSoftReferencesToObject(FSoftObjectPath TargetObject, out List<UObject> ReferencingObjects);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetTools.AssetTools:ExportAssetsWithDialog")]
	void ExportAssetsWithDialog(List<string> AssetsToExport, bool bPromptForIndividualFilenames);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetTools.AssetTools:ExportAssets")]
	void ExportAssets(List<string> AssetsToExport, string ExportPath);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetTools.AssetTools:DuplicateAssetWithDialogAndTitle")]
	UObject DuplicateAssetWithDialogAndTitle(string AssetName, string PackagePath, UObject OriginalObject, FText DialogTitle);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetTools.AssetTools:DuplicateAssetWithDialog")]
	UObject DuplicateAssetWithDialog(string AssetName, string PackagePath, UObject OriginalObject);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetTools.AssetTools:DuplicateAsset")]
	UObject DuplicateAsset(string AssetName, string PackagePath, UObject OriginalObject);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetTools.AssetTools:CreateUniqueAssetName")]
	void CreateUniqueAssetName(string InBasePackageName, string InSuffix, out string OutPackageName, out string OutAssetName);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetTools.AssetTools:CreateAssetWithDialog")]
	UObject CreateAssetWithDialog(string AssetName, string PackagePath, TSubclassOf<UObject> AssetClass, UFactory Factory, FName CallingContext, bool bCallConfigureProperties);

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetTools.AssetTools:CreateAsset")]
	UObject CreateAsset(string AssetName, string PackagePath, TSubclassOf<UObject> AssetClass, UFactory Factory, FName CallingContext);
}
