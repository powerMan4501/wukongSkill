using System;
using System.Collections.Generic;
using CSharpModBase;

namespace BlackMythWukong_Game_Helper;

public class KeyHookMgr
{
	private TB_KeyHook Keys_;

	private MethodByKey Method_;

	private static KeyHookMgr _Instance;

	private KeyHookMgr()
	{
		Keys_ = GlobalObjectMgr.Get<TB_KeyHook>();
		Method_ = MethodByKey.Get();
		Method_.Init();
	}

	public static KeyHookMgr Get()
	{
		if (_Instance == null)
		{
			_Instance = new KeyHookMgr();
		}
		return _Instance;
	}

	public void Add(KeyHook key)
	{
		Keys_.List_.Add(key);
	}

	public void AddRange(List<KeyHook> keys)
	{
		Keys_.List_.AddRange(keys);
	}

	private void RegistAllKey(MethodByKey methodByKey)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		foreach (KeyHook item in Keys_.List_)
		{
			if ((int)item.HookKey > 0)
			{
				Action action = (Action)Delegate.CreateDelegate(typeof(Action), methodByKey, item.Method);
				Utils.RegisterKeyBind(item.HookKey, action);
				Console.WriteLine(item.Name + ":" + item.Method + ":" + ((object)item.HookKey/*cast due to .constrained prefix*/).ToString());
			}
		}
	}

	public void RegistAllKey()
	{
		RegistAllKey(Method_);
	}
}
