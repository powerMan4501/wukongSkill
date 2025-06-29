using System;
using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public static class TeleportTemplateFactory
{
	public delegate TeleportTemplateBase Del_TeleportTemplateCreate(ValueType UserData, APlayerController PlayerController);

	private static Dictionary<ETeleportTypeV2, Del_TeleportTemplateCreate> sTeleportTemplateCreateFuncs;

	static TeleportTemplateFactory()
	{
		sTeleportTemplateCreateFuncs = new Dictionary<ETeleportTypeV2, Del_TeleportTemplateCreate>();
		sTeleportTemplateCreateFuncs.Add(ETeleportTypeV2.SimpleLevelIdAndTransform, delegate(ValueType UserData, APlayerController PlayerController)
		{
			TeleportTemplate_SimpleLevelIdAndTransform teleportTemplate_SimpleLevelIdAndTransform = new TeleportTemplate_SimpleLevelIdAndTransform();
			teleportTemplate_SimpleLevelIdAndTransform.Init(UserData, PlayerController);
			return teleportTemplate_SimpleLevelIdAndTransform;
		});
		sTeleportTemplateCreateFuncs.Add(ETeleportTypeV2.RebirthPoint, delegate(ValueType UserData, APlayerController PlayerController)
		{
			TeleportTemplate_RebirthPoint teleportTemplate_RebirthPoint = new TeleportTemplate_RebirthPoint();
			teleportTemplate_RebirthPoint.Init(UserData, PlayerController);
			return teleportTemplate_RebirthPoint;
		});
		sTeleportTemplateCreateFuncs.Add(ETeleportTypeV2.TeleportNamedPoint, delegate(ValueType UserData, APlayerController PlayerController)
		{
			TeleportTemplate_TeleportPoint teleportTemplate_TeleportPoint = new TeleportTemplate_TeleportPoint();
			teleportTemplate_TeleportPoint.Init(UserData, PlayerController);
			return teleportTemplate_TeleportPoint;
		});
		sTeleportTemplateCreateFuncs.Add(ETeleportTypeV2.Dream, delegate(ValueType UserData, APlayerController PlayerController)
		{
			TeleportTemplate_Dream teleportTemplate_Dream = new TeleportTemplate_Dream();
			teleportTemplate_Dream.Init(UserData, PlayerController);
			return teleportTemplate_Dream;
		});
		sTeleportTemplateCreateFuncs.Add(ETeleportTypeV2.NextChapter, delegate(ValueType UserData, APlayerController PlayerController)
		{
			TeleportTemplate_NextChapter teleportTemplate_NextChapter = new TeleportTemplate_NextChapter();
			teleportTemplate_NextChapter.Init(UserData, PlayerController);
			return teleportTemplate_NextChapter;
		});
		sTeleportTemplateCreateFuncs.Add(ETeleportTypeV2.RebirthPointTeleportOnly, delegate(ValueType UserData, APlayerController PlayerController)
		{
			TeleportTemplate_RebirthPointTeleportOnly teleportTemplate_RebirthPointTeleportOnly = new TeleportTemplate_RebirthPointTeleportOnly();
			teleportTemplate_RebirthPointTeleportOnly.Init(UserData, PlayerController);
			return teleportTemplate_RebirthPointTeleportOnly;
		});
		sTeleportTemplateCreateFuncs.Add(ETeleportTypeV2.PrologueCompleted, delegate(ValueType UserData, APlayerController PlayerController)
		{
			TeleportTemplate_PrologueCompleted teleportTemplate_PrologueCompleted = new TeleportTemplate_PrologueCompleted();
			teleportTemplate_PrologueCompleted.Init(UserData, PlayerController);
			return teleportTemplate_PrologueCompleted;
		});
		sTeleportTemplateCreateFuncs.Add(ETeleportTypeV2.BossRush, delegate(ValueType UserData, APlayerController PlayerController)
		{
			TeleportTemplate_BossRush teleportTemplate_BossRush = new TeleportTemplate_BossRush();
			teleportTemplate_BossRush.Init(UserData, PlayerController);
			return teleportTemplate_BossRush;
		});
	}

	public static TeleportTemplateBase CreateTeleportTemplate(ETeleportTypeV2 Type, ValueType UserData, APlayerController PlayerController)
	{
		return sTeleportTemplateCreateFuncs[Type](UserData, PlayerController);
	}
}
