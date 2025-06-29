namespace System.Net.Mail;

internal enum ServerState
{
	Starting = 1,
	Started,
	Stopping,
	Stopped,
	Pausing,
	Paused,
	Continuing
}
