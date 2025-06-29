namespace b1;

public class ActorCompNetRole
{
	public const int NotDedicateServer = 1;

	public const int Server = 2;

	public const int NetServer = 4;

	public const int NetClient = 8;

	public const int LocalCtrl = 16;

	public const int AutonomousProxy = 32;

	public const int SimulatedProxy = 64;

	public const int Authority = 128;

	public const int DedicateServer = 256;

	public const int ListenServer = 512;

	public const int RemoteControl = 1024;

	public const int BattleReplay = 2048;

	public const int StandAlone = 4096;

	public const int AllFilter = int.MaxValue;
}
