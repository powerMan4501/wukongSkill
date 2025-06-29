using System;
using System.IO;
using b1.GSFile;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_DevCheckGameMgr")]
public class BGW_DevCheckGameMgr : GameInstanceSystemBaseUObj
{
	public override bool bTickEnabled => false;

	public static BGW_DevCheckGameMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_DevCheckGameMgr>(WorldContext);
	}

	public override void OnInit()
	{
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
	}

	private void OnCheckMarkFailed(string ErrMsg, int RemainTimes)
	{
		FMessage.OpenDialog(ErrMsg);
		if (RemainTimes == 0)
		{
			UGSE_EngineFuncLib.RequestExit(Force: true);
		}
	}

	private int CheckLocalMark(int RemainTimes)
	{
		if (BGW_GameDB.sCDNRequestResult == BGW_CDNGameDB.CDNRequestResult.Success)
		{
			return 0;
		}
		if (BGW_GameDB.sCDNRequestResult == BGW_CDNGameDB.CDNRequestResult.NotFound)
		{
			if (GSEFileUtil.IsFileExist(Path.Combine(FPaths.ProjectDir, "GSDataTable", "ProtoEncrypt.txt")))
			{
				OnCheckMarkFailed("表格加密已启动，请拉取最新的Git和P4", RemainTimes);
			}
			return -1;
		}
		if (BGW_GameDB.sCDNRequestResult == BGW_CDNGameDB.CDNRequestResult.ConnectFailure)
		{
			OnCheckMarkFailed("访问CDN失败，请检查网络", RemainTimes);
			return -1;
		}
		if (BGW_GameDB.sCDNRequestResult == BGW_CDNGameDB.CDNRequestResult.Unknow)
		{
			OnCheckMarkFailed("出现未知错误，请将log发给aarondu", RemainTimes);
			return -1;
		}
		return -1;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_DevCheckGameMgr");
	}

	static BGW_DevCheckGameMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_DevCheckGameMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_DevCheckGameMgr));
	}
}
