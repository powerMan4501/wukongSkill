using System;
using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public interface IGSRpcController
{
	APlayerState GetPlayerState();

	string GetUniqueNetIdStr();

	BPC_PlayerRoleData GetReadOnlyDataTodoRemove();

	void RegisterRpcMessageHandler(Action<List<byte>> ReceiveMessageHandler);

	void UnRegisterRpcMessageHandler();

	void GSRpcSendServer(List<byte> SendData);

	void GSRpcSendServer_Implementation(List<byte> RecvData);

	void GSRpcSendClient(List<byte> SendData);

	void GSRpcSendClient_Implementation(List<byte> RecvData);

	bool HasAuthority();
}
