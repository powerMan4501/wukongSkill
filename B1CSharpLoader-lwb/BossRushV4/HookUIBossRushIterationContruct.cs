using System;
using System.Reflection;
using ArchiveB1;
using B1UI;
using HarmonyLib;

namespace BossRushV4;

[HarmonyPatch]
public class HookUIBossRushIterationContruct
{
	private static MethodBase TargetMethod()
	{
		return AccessTools.Method("B1UI.GSUI.UIBossIterationsMain:OnUIPageConstructImpl", (Type[])null, (Type[])null);
	}

	private static void InitPlayerBossIterData(RoleBossRush mData, int id)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		BossRushContinuousFightGroup val = new BossRushContinuousFightGroup
		{
			BossGroupId = id,
			IsPassed = false,
			EncounterBossIndex = -1
		};
		if (mData.ContinuousFight != null)
		{
			if (mData.ContinuousFight.BossGroups == null)
			{
				return;
			}
			bool flag = false;
			foreach (BossRushContinuousFightGroup bossGroup in mData.ContinuousFight.BossGroups)
			{
				if (bossGroup.BossGroupId == id)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				mData.ContinuousFight.BossGroups.Add(val);
			}
		}
		else
		{
			mData.ContinuousFight = new BossRushContinuousFight();
			mData.ContinuousFight.BossGroups.Add(val);
		}
	}

	private static void Prefix()
	{
		RoleBossRush fieldOrPropertyValue = Utils.GetFieldOrPropertyValue<RoleBossRush>("mData", GSG.GamePlayer.BossRushHelper, BindingFlags.Instance | BindingFlags.NonPublic);
		if (fieldOrPropertyValue != null)
		{
			InitPlayerBossIterData(fieldOrPropertyValue, 99);
			InitPlayerBossIterData(fieldOrPropertyValue, 9993);
			InitPlayerBossIterData(fieldOrPropertyValue, 9996);
			InitPlayerBossIterData(fieldOrPropertyValue, 9999);
		}
	}
}
