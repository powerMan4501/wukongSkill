namespace System.Net.NetworkInformation;

internal struct MibUdpStats
{
	internal uint datagramsReceived;

	internal uint incomingDatagramsDiscarded;

	internal uint incomingDatagramsWithErrors;

	internal uint datagramsSent;

	internal uint udpListeners;
}
