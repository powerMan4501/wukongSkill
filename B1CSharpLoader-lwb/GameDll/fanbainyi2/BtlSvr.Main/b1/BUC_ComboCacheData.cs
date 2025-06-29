using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_ComboCacheData : IBUC_ComboCacheData
{
	public bool IsComboSubIdle;

	public float LastAxisMoveForward;

	public Stack<ComboKeyInfo> ComboKeyStack = new Stack<ComboKeyInfo>();

	public int TryConsumeAttackKeyGroupID;

	public int LastMagicSkillID { get; set; }

	public int LastVigorSkillID { get; set; }

	public int LastItemSkillID { get; set; }

	public int LastItemID { get; set; }

	public FVector LastCacheDodgeInputDir { get; set; } = FVector.ZeroVector;

	public ESkillDirection PrepareDodgeDirection { get; set; } = ESkillDirection.Forward;

	public bool PrepareForDodge { get; set; }

	public void AddLastComboKey(ComboKeyInfo ComboKeyInfo)
	{
		ComboKeyStack.Push(ComboKeyInfo);
	}

	public ComboKeyInfo GetLastComboKey()
	{
		return ComboKeyStack.Peek();
	}

	public void PopLastComboKey()
	{
		if (ComboKeyStack.Count == 0)
		{
			BGW_LogUtil.LogError("Trying to pop an empty stack in ComboSkillSystem! This situation should never happen! There must be a bug! Please tell sansan how to reproduce this!");
		}
		else
		{
			ComboKeyStack.Pop();
		}
	}

	public bool IsComboKeyStackEmpty()
	{
		return ComboKeyStack.Count == 0;
	}

	public void ClearComboKeyStack()
	{
		ComboKeyStack.Clear();
	}
}
