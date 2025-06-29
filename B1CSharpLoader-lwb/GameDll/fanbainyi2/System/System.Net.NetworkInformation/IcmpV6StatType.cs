namespace System.Net.NetworkInformation;

internal enum IcmpV6StatType
{
	DestinationUnreachable = 1,
	PacketTooBig = 2,
	TimeExceeded = 3,
	ParameterProblem = 4,
	EchoRequest = 128,
	EchoReply = 129,
	MembershipQuery = 130,
	MembershipReport = 131,
	MembershipReduction = 132,
	RouterSolicit = 133,
	RouterAdvertisement = 134,
	NeighborSolict = 135,
	NeighborAdvertisement = 136,
	Redirect = 137
}
