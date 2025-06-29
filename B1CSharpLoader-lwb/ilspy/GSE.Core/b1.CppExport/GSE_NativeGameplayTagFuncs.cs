using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using UnrealEngine.Runtime;

namespace b1.CppExport;

public class GSE_NativeGameplayTagFuncs
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GameplayTagContainerRef_Allocate();

	[MonoNativeFunctionWrapper]
	public delegate void Del_GameplayTagContainerRef_Destroy(IntPtr GT);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GameplayTagContainerRef_AddTag(IntPtr GameplayTagContainer, ref FGameplayTag Tag);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GameplayTagContainerRef_RemoveTag(IntPtr GameplayTagContainer, ref FGameplayTag Tag);

	[MonoNativeFunctionWrapper]
	public delegate bool Del_GameplayTagContainerRef_HasTag(IntPtr TagContainer, ref FGameplayTag Tag, bool bExactMatch);

	[MonoNativeFunctionWrapper]
	public delegate bool Del_GameplayTagContainerRef_HasTagName(IntPtr TagContainer, ref FName TagName, bool bExactMatch);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GameplayTagContainerRef_GetTag(IntPtr GameplayTagContainer, int Index, out FGameplayTag OutTag);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GameplayTagContainerRef_FilterTags(IntPtr Container, IntPtr OtherContainer, bool bExactMatch);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GameplayTagContainerRef_FilterTag(IntPtr GameplayTagContainer, ref FGameplayTag Tag, bool bExactMatch);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GameplayTagContainerRef_GetNum(IntPtr GameplayTagContainer);

	[MonoNativeFunctionWrapper]
	public delegate bool Del_GameplayTagContainerRef_IsValid(IntPtr GameplayTagContainer);

	[MonoNativeFunctionWrapper]
	public delegate bool Del_GameplayTagContainerRef_IsEmpty(IntPtr GameplayTagContainer);

	[MonoNativeFunctionWrapper]
	public delegate bool Del_GameplayTagContainerRef_MatchesAnyTags(IntPtr GameplayTagContainer, ref FGameplayTag TagOne, bool bExactMatch);

	[MonoNativeFunctionWrapper]
	public delegate bool Del_GameplayTagContainerRef_HasAnyTags(IntPtr TagContainer, IntPtr OtherContainer, bool bExactMatch);

	[MonoNativeFunctionWrapper]
	public delegate bool Del_GameplayTagContainerRef_HasAllTags(IntPtr TagContainer, IntPtr OtherContainer, bool bExactMatch);

	[MonoNativeFunctionWrapper]
	public delegate bool Del_GameplayTagContainerRef_EqualEqual(IntPtr A, IntPtr B);

	[MonoNativeFunctionWrapper]
	public delegate bool Del_GameplayTagContainerRef_NotEqual(IntPtr A, IntPtr B);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GameplayTagContainerRef_MakeLiteralGameplayTagContainer(IntPtr TagContainer);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GameplayTagContainerRef_MakeGameplayTagContainerFromTag(ref FGameplayTag SingleTag);

	[MonoNativeFunctionWrapper]
	public delegate bool Del_GameplayTagContainerRef_NotEqual_TagContainerTagContainer(IntPtr A, ref FScriptArray B);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GameplayTagContainerRef_GetDebugStringFromGameplayTagContainer(IntPtr TagContainer, out FScriptArray OutStrArray);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GameplayTagContainerRef_Append(IntPtr TagContainer, IntPtr OtherContainer);

	[MonoNativeFunctionWrapper]
	public delegate void Del_MakeGameplayTagFromName(FName TagName, out FGameplayTag OutTag);

	[MonoNativeFunctionWrapper]
	public delegate void Del_MakeGameplayTagFromString(ref FScriptArray TagStr, out FGameplayTag OutTag);

	[MonoNativeFunctionWrapper]
	public delegate bool Del_AddGamePlayTagToINI(ref FScriptArray NewTag);

	[MonoNativeFunctionWrapper]
	public delegate bool Del_EqualEqual_GameplayTag(ref FGameplayTag A, ref FGameplayTag B);

	[MonoNativeFunctionWrapper]
	public delegate bool Del_NotEqual_GameplayTag(ref FGameplayTag A, ref FGameplayTag B);

	[MonoNativeFunctionWrapper]
	public delegate bool Del_IsGameplayTagValid(ref FGameplayTag GameplayTag);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetTagName(ref FGameplayTag GameplayTag, out FName OutName);

	[MonoNativeFunctionWrapper]
	public delegate void Del_MakeLiteralGameplayTag(ref FGameplayTag Value, out FGameplayTag OutTag);

	[MonoNativeFunctionWrapper]
	public delegate bool Del_NotEqual_TagTag(ref FGameplayTag A, ref FScriptArray B);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetDebugStringFromGameplayTag(ref FGameplayTag GameplayTag, out FScriptArray OutStrArray);

	static GSE_NativeGameplayTagFuncs()
	{
		Type typeFromHandle = typeof(GameplayTagFuncLib);
		Dictionary<string, FIntPtr> gameplayTagFuncAsMap = UGSE_CppExport.GetGameplayTagFuncAsMap();
		FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (gameplayTagFuncAsMap.TryGetValue(fieldInfo.Name, out var value))
			{
				fieldInfo.SetValue(null, Marshal.GetDelegateForFunctionPointer(FIntPtrHelper.FIntPtr2IntPtr(value), fieldInfo.FieldType));
			}
		}
	}
}
