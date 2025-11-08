using System;
using System.Collections.Generic;

namespace BlackMythWukong_Game_Helper;

public class GlobalObjectMgr
{
	public const string ModDir = "CSharpLoader\\Mods";

	public const string ModName = "BlackMythWukong_Game_Helper";

	public static string ModTB_KeyHookPath = "CSharpLoader\\Mods\\BlackMythWukong_Game_Helper\\TB_KeyHook.json";

	public static string ModEditionAwardPath = "CSharpLoader\\Mods\\BlackMythWukong_Game_Helper\\EditionAward.json";

	public static string ModTB_GMMethodPath = "CSharpLoader\\Mods\\BlackMythWukong_Game_Helper\\TB_GMMethod.json";

	public static string ModTB_AddItemPath = "CSharpLoader\\Mods\\BlackMythWukong_Game_Helper\\TB_AddItem.json";

	public static string ModTB_BossInfoAPath = "CSharpLoader\\Mods\\BlackMythWukong_Game_Helper\\TB_BossInfoA.json";

	public static string Mod_AbsPath = "CSharpLoader\\Mods\\BlackMythWukong_Game_Helper\\Abs.txt";

	public static int IEditionAward = 3;

	private static Dictionary<Type, object> Dic_;

	public static void Init()
	{
		MyUtils.EnableCNInConsole();
		Dic_ = new Dictionary<Type, object>();
	}

	public static T Get<T>() where T : class, new()
	{
		Type typeFromHandle = typeof(T);
		T val;
		if (Dic_.ContainsKey(typeFromHandle))
		{
			val = Dic_[typeFromHandle] as T;
		}
		else
		{
			val = new T();
			Dic_.Add(typeFromHandle, val);
		}
		return val;
	}

	public static void Add<T>(T GameStateSystem) where T : class
	{
		if (Dic_.ContainsKey(typeof(T)))
		{
			Dic_[typeof(T)] = GameStateSystem;
		}
		else
		{
			Dic_.Add(typeof(T), GameStateSystem);
		}
	}

	public static void Remove<T>()
	{
		Dic_.Remove(typeof(T));
	}

	public static void Remove()
	{
		Dic_?.Clear();
	}
}
