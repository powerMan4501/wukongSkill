using System;
using System.IO;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_OnlineDebugInfoComp : UActorCompBaseCS
{
	private string DebugString;

	public override void OnAttach()
	{
		base.BUSEventCollection.Evt_OnlineUnitStateDebugInfo += new Del_OnlineUnitStateDebugInfo(OnlineUnitStateDebugInfo);
	}

	public override void OnBeginPlay()
	{
		DebugString = $"BeginTime : {DateTime.Now.Millisecond}\n";
	}

	private void OnlineUnitStateDebugInfo(int UnitState, float Value, int ChangeType)
	{
		if (DebugConfig.OnlineUnitState && UnitState == 1)
		{
			string text = $"UnitState.ToString():{(EBGUUnitState)UnitState}  Value: {Value}   ChangeType:{ChangeType}   Time:{DateTime.Now.Minute}.{DateTime.Now.Second}.{DateTime.Now.Millisecond}\n";
			DebugString += text;
			GMSaveDataToFile();
		}
	}

	private void OnlineDebugInfoBegin()
	{
		DebugString = $"BeginTime : {DateTime.Now.Minute}.{DateTime.Now.Second}.{DateTime.Now.Millisecond}\n";
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
	}

	private void GMSaveDataToFile()
	{
		string text = FPaths.Combine(FPaths.ProjectPersistentDownloadDir, "OnlineDebug");
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		string text2 = "Client";
		if (GetOwner().World.IsServer())
		{
			text2 = "Server";
		}
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS != null && bGUCharacterCS.IsLocallyControlled())
		{
			text2 += "_islocal";
		}
		File.WriteAllText(Path.Combine(text, GetOwner().GetFName().ToString() + text2), DebugString);
	}
}
