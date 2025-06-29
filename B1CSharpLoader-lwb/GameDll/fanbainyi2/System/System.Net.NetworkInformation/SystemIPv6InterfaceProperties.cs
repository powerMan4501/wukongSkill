namespace System.Net.NetworkInformation;

internal class SystemIPv6InterfaceProperties : IPv6InterfaceProperties
{
	private uint index;

	private uint mtu;

	private uint[] zoneIndices;

	public override int Index => (int)index;

	public override int Mtu => (int)mtu;

	internal SystemIPv6InterfaceProperties(uint index, uint mtu, uint[] zoneIndices)
	{
		this.index = index;
		this.mtu = mtu;
		this.zoneIndices = zoneIndices;
	}

	public override long GetScopeId(ScopeLevel scopeLevel)
	{
		if (scopeLevel < ScopeLevel.None || (int)scopeLevel >= zoneIndices.Length)
		{
			throw new ArgumentOutOfRangeException("scopeLevel");
		}
		return zoneIndices[(int)scopeLevel];
	}
}
