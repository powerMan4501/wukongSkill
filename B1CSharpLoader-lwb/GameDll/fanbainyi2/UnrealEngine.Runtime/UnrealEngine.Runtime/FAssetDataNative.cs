namespace UnrealEngine.Runtime;

internal struct FAssetDataNative
{
	public FName ObjectPath;

	public FName PackageName;

	public FName PackagePath;

	public FName AssetName;

	public FName AssetClass;

	public ulong TagsAndValues;

	public ulong TagsAndValuesPadding;

	public FSharedPtr TaggedAssetBundles;

	public FScriptArray ChunkIDs;

	public uint PackageFlags;
}
