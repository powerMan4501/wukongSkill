namespace System.Net;

internal struct CertEnhKeyUse
{
	public uint cUsageIdentifier;

	public unsafe void* rgpszUsageIdentifier;
}
