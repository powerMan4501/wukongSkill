namespace System.Net.NetworkInformation;

internal struct MibIcmpStats
{
	internal uint messages;

	internal uint errors;

	internal uint destinationUnreachables;

	internal uint timeExceeds;

	internal uint parameterProblems;

	internal uint sourceQuenches;

	internal uint redirects;

	internal uint echoRequests;

	internal uint echoReplies;

	internal uint timestampRequests;

	internal uint timestampReplies;

	internal uint addressMaskRequests;

	internal uint addressMaskReplies;
}
