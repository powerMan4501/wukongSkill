using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGWDataAsset_SeqLevelLoadRelationInfo")]
public class BGWDataAsset_SeqLevelLoadRelationInfo : UBGWSaveCheckDataAsset
{
	private static bool LevelRelationInfos_IsValid;

	private static int LevelRelationInfos_Offset;

	private static FFieldAddress LevelRelationInfos_PropertyAddress;

	private TMapReadWriteMarshaler<string, FSeqLevelRelationInfo> LevelRelationInfos_Marshaler;

	private static bool MovieRelationInfos_IsValid;

	private static int MovieRelationInfos_Offset;

	private static FFieldAddress MovieRelationInfos_PropertyAddress;

	private TMapReadWriteMarshaler<int, FMovieRelationInfoCollection> MovieRelationInfos_Marshaler;

	private static bool RelationDescriptions_IsValid;

	private static int RelationDescriptions_Offset;

	private static FFieldAddress RelationDescriptions_PropertyAddress;

	private TMapReadWriteMarshaler<string, FRelationLevelInfo> RelationDescriptions_Marshaler;

	[Category("Performance")]
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SeqLevelLoadRelationInfo:LevelRelationInfos")]
	public TMapReadWrite<string, FSeqLevelRelationInfo> LevelRelationInfos
	{
		get
		{
			CheckDestroyed();
			if (!LevelRelationInfos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SeqLevelLoadRelationInfo:LevelRelationInfos");
				return null;
			}
			if (LevelRelationInfos_Marshaler == null)
			{
				LevelRelationInfos_Marshaler = new TMapReadWriteMarshaler<string, FSeqLevelRelationInfo>(1, LevelRelationInfos_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FSeqLevelRelationInfo, FSeqLevelRelationInfo>.FromNative, CachedMarshalingDelegates<FSeqLevelRelationInfo, FSeqLevelRelationInfo>.ToNative);
			}
			return LevelRelationInfos_Marshaler.FromNative(IntPtr.Add(base.Address, LevelRelationInfos_Offset));
		}
	}

	[UProperty]
	[Category("Performance")]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SeqLevelLoadRelationInfo:MovieRelationInfos")]
	public TMapReadWrite<int, FMovieRelationInfoCollection> MovieRelationInfos
	{
		get
		{
			CheckDestroyed();
			if (!MovieRelationInfos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SeqLevelLoadRelationInfo:MovieRelationInfos");
				return null;
			}
			if (MovieRelationInfos_Marshaler == null)
			{
				MovieRelationInfos_Marshaler = new TMapReadWriteMarshaler<int, FMovieRelationInfoCollection>(1, MovieRelationInfos_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FMovieRelationInfoCollection, FMovieRelationInfoCollection>.FromNative, CachedMarshalingDelegates<FMovieRelationInfoCollection, FMovieRelationInfoCollection>.ToNative);
			}
			return MovieRelationInfos_Marshaler.FromNative(IntPtr.Add(base.Address, MovieRelationInfos_Offset));
		}
	}

	[Category("Performance")]
	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SeqLevelLoadRelationInfo:RelationDescriptions")]
	public TMapReadWrite<string, FRelationLevelInfo> RelationDescriptions
	{
		get
		{
			CheckDestroyed();
			if (!RelationDescriptions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SeqLevelLoadRelationInfo:RelationDescriptions");
				return null;
			}
			if (RelationDescriptions_Marshaler == null)
			{
				RelationDescriptions_Marshaler = new TMapReadWriteMarshaler<string, FRelationLevelInfo>(1, RelationDescriptions_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FRelationLevelInfo, FRelationLevelInfo>.FromNative, CachedMarshalingDelegates<FRelationLevelInfo, FRelationLevelInfo>.ToNative);
			}
			return RelationDescriptions_Marshaler.FromNative(IntPtr.Add(base.Address, RelationDescriptions_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_SeqLevelLoadRelationInfo");
		NativeReflection.GetPropertyRef(ref LevelRelationInfos_PropertyAddress, unrealStruct, "LevelRelationInfos");
		LevelRelationInfos_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LevelRelationInfos");
		LevelRelationInfos_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LevelRelationInfos", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref MovieRelationInfos_PropertyAddress, unrealStruct, "MovieRelationInfos");
		MovieRelationInfos_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MovieRelationInfos");
		MovieRelationInfos_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MovieRelationInfos", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref RelationDescriptions_PropertyAddress, unrealStruct, "RelationDescriptions");
		RelationDescriptions_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RelationDescriptions");
		RelationDescriptions_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RelationDescriptions", Classes.FMapProperty);
	}

	static BGWDataAsset_SeqLevelLoadRelationInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_SeqLevelLoadRelationInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_SeqLevelLoadRelationInfo));
	}
}
