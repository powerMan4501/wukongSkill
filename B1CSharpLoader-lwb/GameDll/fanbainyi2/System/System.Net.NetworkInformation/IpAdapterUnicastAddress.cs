namespace System.Net.NetworkInformation;

internal struct IpAdapterUnicastAddress
{
	internal uint length;

	internal AdapterAddressFlags flags;

	internal IntPtr next;

	internal IpSocketAddress address;

	internal PrefixOrigin prefixOrigin;

	internal SuffixOrigin suffixOrigin;

	internal DuplicateAddressDetectionState dadState;

	internal uint validLifetime;

	internal uint preferredLifetime;

	internal uint leaseLifetime;

	internal byte prefixLength;
}
