using System;
using System.Collections;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.CppExport;

public class GameplayTagContainerRef : IDisposable, IEnumerable
{
	private IntPtr Ptr;

	public FGameplayTag this[int Index] => GetTag(Index);

	public GameplayTagContainerRef()
	{
		Ptr = GameplayTagFuncLib.GameplayTagContainerRef_Allocate();
	}

	public GameplayTagContainerRef(IntPtr InPtr)
	{
		Ptr = InPtr;
	}

	public GameplayTagContainerRef(in FGameplayTagContainer Container)
	{
		Ptr = GameplayTagFuncLib.GameplayTagContainerRef_Allocate();
		foreach (FGameplayTag gameplayTag in Container.GameplayTags)
		{
			AddTag(gameplayTag);
		}
	}

	~GameplayTagContainerRef()
	{
		Dispose();
	}

	public IEnumerator GetEnumerator()
	{
		int TagNum = GetTagNum();
		for (int Index = 0; Index < TagNum; Index++)
		{
			yield return GetTag(Index);
		}
	}

	public void Dispose()
	{
		if (Ptr != IntPtr.Zero)
		{
			GameplayTagFuncLib.GameplayTagContainerRef_Destroy(Ptr);
			Ptr = IntPtr.Zero;
		}
	}

	public bool IsValid()
	{
		return GameplayTagFuncLib.GameplayTagContainerRef_IsValid(Ptr);
	}

	public bool IsEmpty()
	{
		return GameplayTagFuncLib.GameplayTagContainerRef_IsEmpty(Ptr);
	}

	public int GetTagNum()
	{
		return GameplayTagFuncLib.GameplayTagContainerRef_GetNum(Ptr);
	}

	public FGameplayTag GetTag(int Index)
	{
		GameplayTagFuncLib.GameplayTagContainerRef_GetTag(Ptr, Index, out var OutTag);
		return OutTag;
	}

	public void GetAllTagStrList(out List<string> TagStrList)
	{
		TagStrList = new List<string>();
		IEnumerator enumerator = GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				FGameplayTag fGameplayTag = (FGameplayTag)enumerator.Current;
				List<string> obj = TagStrList;
				FName tagName = fGameplayTag.TagName;
				obj.Add(tagName.PlainName);
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
	}

	public override string ToString()
	{
		GameplayTagFuncLib.GameplayTagContainerRef_GetDebugStringFromGameplayTagContainer(Ptr, out var OutStrArray);
		FStringUnsafe fStringUnsafe = FStringPool.New();
		fStringUnsafe.Array = OutStrArray;
		return fStringUnsafe.Value;
	}

	public bool HasTagName(FName TagName, bool bExactMatch = true)
	{
		return GameplayTagFuncLib.GameplayTagContainerRef_HasTagName(Ptr, ref TagName, bExactMatch);
	}

	public bool MatchesAnyTags(FGameplayTag TagOne, bool bExactMatch = true)
	{
		return GameplayTagFuncLib.GameplayTagContainerRef_MatchesAnyTags(Ptr, ref TagOne, bExactMatch);
	}

	public bool HasTag(FGameplayTag Tag, bool bExactMatch = true)
	{
		return GameplayTagFuncLib.GameplayTagContainerRef_HasTag(Ptr, ref Tag, bExactMatch);
	}

	public void AddTag(FGameplayTag Tag)
	{
		GameplayTagFuncLib.GameplayTagContainerRef_AddTag(Ptr, ref Tag);
	}

	public GameplayTagContainerRef FilterTag(FGameplayTag Tag, bool bExactMatch = true)
	{
		return new GameplayTagContainerRef(GameplayTagFuncLib.GameplayTagContainerRef_FilterTag(Ptr, ref Tag, bExactMatch));
	}

	public GameplayTagContainerRef FilterTags(GameplayTagContainerRef OtherContainer, bool bExactMatch = true)
	{
		return new GameplayTagContainerRef(GameplayTagFuncLib.GameplayTagContainerRef_FilterTags(Ptr, OtherContainer.Ptr, bExactMatch));
	}

	public bool HasAnyTags(GameplayTagContainerRef OtherContainer, bool bExactMatch = true)
	{
		if (OtherContainer.Ptr == IntPtr.Zero || Ptr == IntPtr.Zero)
		{
			return false;
		}
		return GameplayTagFuncLib.GameplayTagContainerRef_HasAnyTags(Ptr, OtherContainer.Ptr, bExactMatch);
	}

	public bool HasAllTags(GameplayTagContainerRef OtherContainer, bool bExactMatch = true)
	{
		return GameplayTagFuncLib.GameplayTagContainerRef_HasAllTags(Ptr, OtherContainer.Ptr, bExactMatch);
	}

	public void AddGameplayTag(FGameplayTag Tag)
	{
		GameplayTagFuncLib.GameplayTagContainerRef_AddTag(Ptr, ref Tag);
	}

	public void RemoveGameplayTag(FGameplayTag Tag)
	{
		GameplayTagFuncLib.GameplayTagContainerRef_RemoveTag(Ptr, ref Tag);
	}

	public void Append(GameplayTagContainerRef OtherTagContainer)
	{
		GameplayTagFuncLib.GameplayTagContainerRef_Append(Ptr, OtherTagContainer.Ptr);
	}

	public bool EqualTo(GameplayTagContainerRef OtherTagContainer)
	{
		return GameplayTagFuncLib.GameplayTagContainerRef_EqualEqual(Ptr, OtherTagContainer.Ptr);
	}

	public bool NotEqualTo(GameplayTagContainerRef OtherTagContainer)
	{
		return GameplayTagFuncLib.GameplayTagContainerRef_NotEqual(Ptr, OtherTagContainer.Ptr);
	}

	public bool EqualTo(string OtherTag)
	{
		return !NotEqualTo(OtherTag);
	}

	public bool NotEqualTo(string OtherTag)
	{
		return GameplayTagFuncLib.GameplayTagContainerRef_NotEqual_TagContainerTagContainer(Ptr, ref FStringPool.New(OtherTag).Array);
	}

	public GameplayTagContainerRef MakeLiteralGameplayTagContainer()
	{
		return new GameplayTagContainerRef(GameplayTagFuncLib.GameplayTagContainerRef_MakeLiteralGameplayTagContainer(Ptr));
	}

	public GameplayTagContainerRef MakeGameplayTagContainerFromTag(FGameplayTag SingleTag)
	{
		return new GameplayTagContainerRef(GameplayTagFuncLib.GameplayTagContainerRef_MakeGameplayTagContainerFromTag(ref SingleTag));
	}

	public void RemoveTags(GameplayTagContainerRef OtherContainer)
	{
		int tagNum = OtherContainer.GetTagNum();
		for (int i = 0; i < tagNum; i++)
		{
			RemoveTag(OtherContainer.GetTag(i));
		}
	}

	public void RemoveTag(FGameplayTag TagToRemove)
	{
		GameplayTagFuncLib.GameplayTagContainerRef_RemoveTag(Ptr, ref TagToRemove);
	}

	public void RemoveMatchTag(FGameplayTag TagToRemove)
	{
		GameplayTagContainerRef gameplayTagContainerRef = FilterTag(TagToRemove, bExactMatch: false);
		int tagNum = gameplayTagContainerRef.GetTagNum();
		for (int i = 0; i < tagNum; i++)
		{
			RemoveTag(gameplayTagContainerRef.GetTag(i));
		}
	}

	public void RemoveAllTags()
	{
		int tagNum = GetTagNum();
		for (int i = 0; i < tagNum; i++)
		{
			RemoveTag(GetTag(0));
		}
	}
}
