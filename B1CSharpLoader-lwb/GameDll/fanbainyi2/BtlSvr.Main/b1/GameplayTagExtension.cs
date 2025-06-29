using System;
using System.Collections.Generic;
using b1.CppExport;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

public static class GameplayTagExtension
{
	public static Dictionary<Guid, FCalliopeGuid> CalliopeGuidMap = new Dictionary<Guid, FCalliopeGuid>();

	public static Dictionary<FCalliopeGuid, Guid> CalliopeGuidReverseMap = new Dictionary<FCalliopeGuid, Guid>();

	public static Dictionary<string, FGameplayTag> GameplayTagCache = new Dictionary<string, FGameplayTag>();

	public static bool IsTag(this FGameplayTag Tag, FGameplayTag OtherTag)
	{
		return GameplayTagFuncLib.EqualEqual_GameplayTag(ref Tag, ref OtherTag);
	}

	public static bool IsTagName(this FName TagName, FGameplayTag OtherTag)
	{
		GameplayTagFuncLib.GetTagName(ref OtherTag, out var OutName);
		return OutName.Equals(TagName);
	}

	public static bool IsValid(this FGameplayTag Tag)
	{
		return GameplayTagFuncLib.IsGameplayTagValid(ref Tag);
	}

	public static FGameplayTag MakeGameplayTag(this FName Name)
	{
		GameplayTagFuncLib.MakeGameplayTagFromName(Name, out var OutTag);
		return OutTag;
	}

	public static FGameplayTag MakeGameplayTag(this string Str)
	{
		if (GameplayTagCache.TryGetValue(Str, out var value))
		{
			return value;
		}
		FScriptArray TagStr = FStringMarshaler.ToArray(Str);
		GameplayTagFuncLib.MakeGameplayTagFromString(ref TagStr, out value);
		GameplayTagCache[Str] = value;
		return value;
	}

	public static FGameplayTag MakeLiteralGameplayTag(this FGameplayTag Tag)
	{
		GameplayTagFuncLib.MakeLiteralGameplayTag(ref Tag, out var _);
		return Tag;
	}

	public static bool EqualTo(this FGameplayTag Tag, FGameplayTag OtherTag)
	{
		return GameplayTagFuncLib.EqualEqual_GameplayTag(ref Tag, ref OtherTag);
	}

	public static bool NotEqualTo(this FGameplayTag Tag, FGameplayTag OtherTag)
	{
		return GameplayTagFuncLib.NotEqual_GameplayTag(ref Tag, ref OtherTag);
	}

	public static bool EqualTo(this FGameplayTag Tag, FName OtherTag)
	{
		return Tag.TagName == OtherTag;
	}

	public static bool NotEqualTo(this FGameplayTag Tag, FName OtherTag)
	{
		return Tag.TagName != OtherTag;
	}

	public static bool EqualTo(this FGameplayTag Tag, string OtherTag)
	{
		return !NotEqualTo(Tag, OtherTag);
	}

	public static bool NotEqualTo(this FGameplayTag Tag, string OtherTag)
	{
		return GameplayTagFuncLib.NotEqual_TagTag(ref Tag, ref FStringPool.New(OtherTag).Array);
	}

	public static string ToDebugString(this FGameplayTag Tag)
	{
		GameplayTagFuncLib.GetDebugStringFromGameplayTag(ref Tag, out var OutStrArray);
		FStringUnsafe fStringUnsafe = FStringPool.New();
		fStringUnsafe.Array = OutStrArray;
		return fStringUnsafe.Value;
	}

	public static bool IsValid(this FGameplayTagContainer Container)
	{
		return Container.GameplayTags.Count > 0;
	}

	public static GameplayTagContainerRef MakeGameplayTagContainer(this FGameplayTag Tag)
	{
		return new GameplayTagContainerRef(GameplayTagFuncLib.GameplayTagContainerRef_MakeGameplayTagContainerFromTag(ref Tag));
	}

	public static FCalliopeGuid ConvertToCalliopeGuid(this Guid Guid)
	{
		if (!CalliopeGuidMap.ContainsKey(Guid))
		{
			FCalliopeGuid fCalliopeGuid = BGW_SerializationUtil.CovertBytesToObject<FCalliopeGuid>(Guid.ToByteArray());
			CalliopeGuidMap.Add(Guid, fCalliopeGuid);
			CalliopeGuidReverseMap.Add(fCalliopeGuid, Guid);
		}
		return CalliopeGuidMap[Guid];
	}

	public static Guid ConvertToGuid(this FCalliopeGuid CalliopeGuid)
	{
		if (!CalliopeGuidReverseMap.ContainsKey(CalliopeGuid))
		{
			Guid guid = UCalliopeInteractor.ConvertCalliopeGuidToGuid(CalliopeGuid);
			CalliopeGuidMap.Add(guid, CalliopeGuid);
			CalliopeGuidReverseMap.Add(CalliopeGuid, guid);
		}
		return CalliopeGuidReverseMap[CalliopeGuid];
	}

	public static FCalliopeGraph LoadGraph(this UCalliopeAsset Asset)
	{
		return BGW_CalliopeDataReader.Get().LoadGraphByAssetPath(Asset.GetPathName(), Asset.GetName());
	}

	public static FCalliopeGraph LoadGraph(this string InAssetPath, bool bUseCache = false)
	{
		string text = InAssetPath;
		string[] array = InAssetPath.Split('\'');
		if (array.Length >= 2)
		{
			text = array[1];
		}
		string baseFilename = FPaths.GetBaseFilename(text);
		return BGW_CalliopeDataReader.Get().LoadGraphByAssetPath(text, baseFilename, bUseCache);
	}

	public static string Convert2CalliopeDataFilePath(this string InAssetPath)
	{
		string text = InAssetPath;
		string[] array = InAssetPath.Split('\'');
		if (array.Length >= 2)
		{
			text = array[1];
		}
		string baseFilename = FPaths.GetBaseFilename(text);
		return BGW_CalliopeDataReader.GetDataFilePathByAssetPath(text, baseFilename);
	}
}
