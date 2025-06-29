using System.Collections.Generic;
using Gssdk;

namespace GSE.GSSdk;

public class GSSdkServerDirState
{
	private DirListRes ServerDirRes = new DirListRes();

	private IList<ServerUnit> ServerList;

	public ServerUnit GetServerInfo(int serverId)
	{
		if (ServerList == null || ServerList.Count == 0)
		{
			return null;
		}
		for (int i = 0; i < ServerList.Count; i++)
		{
			if (ServerList[i].ServerId == serverId)
			{
				return ServerList[i];
			}
		}
		return ServerList[0];
	}

	public IList<ServerUnit> GetServerList()
	{
		return ServerList;
	}

	public void UpdateServerList(DirListRes res)
	{
		ServerDirRes = res;
		ServerList = ServerDirRes.ServerList;
	}
}
