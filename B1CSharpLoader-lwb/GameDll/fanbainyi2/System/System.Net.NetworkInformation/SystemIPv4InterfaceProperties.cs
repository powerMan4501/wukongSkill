using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation;

internal class SystemIPv4InterfaceProperties : IPv4InterfaceProperties
{
	private bool haveWins;

	private bool dhcpEnabled;

	private bool routingEnabled;

	private bool autoConfigEnabled;

	private bool autoConfigActive;

	private uint index;

	private uint mtu;

	public override bool UsesWins => haveWins;

	public override bool IsDhcpEnabled => dhcpEnabled;

	public override bool IsForwardingEnabled => routingEnabled;

	public override bool IsAutomaticPrivateAddressingEnabled => autoConfigEnabled;

	public override bool IsAutomaticPrivateAddressingActive => autoConfigActive;

	public override int Mtu => (int)mtu;

	public override int Index => (int)index;

	internal SystemIPv4InterfaceProperties(FixedInfo fixedInfo, IpAdapterAddresses ipAdapterAddresses)
	{
		index = ipAdapterAddresses.index;
		routingEnabled = fixedInfo.EnableRouting;
		dhcpEnabled = (ipAdapterAddresses.flags & AdapterFlags.DhcpEnabled) != 0;
		haveWins = ipAdapterAddresses.firstWinsServerAddress != IntPtr.Zero;
		mtu = ipAdapterAddresses.mtu;
		GetPerAdapterInfo(ipAdapterAddresses.index);
	}

	private void GetPerAdapterInfo(uint index)
	{
		if (index == 0)
		{
			return;
		}
		uint pOutBufLen = 0u;
		SafeLocalFree safeLocalFree = null;
		uint perAdapterInfo = UnsafeNetInfoNativeMethods.GetPerAdapterInfo(index, SafeLocalFree.Zero, ref pOutBufLen);
		while (true)
		{
			switch (perAdapterInfo)
			{
			case 111u:
				try
				{
					safeLocalFree = SafeLocalFree.LocalAlloc((int)pOutBufLen);
					perAdapterInfo = UnsafeNetInfoNativeMethods.GetPerAdapterInfo(index, safeLocalFree, ref pOutBufLen);
					if (perAdapterInfo == 0)
					{
						IpPerAdapterInfo ipPerAdapterInfo = (IpPerAdapterInfo)Marshal.PtrToStructure(safeLocalFree.DangerousGetHandle(), typeof(IpPerAdapterInfo));
						autoConfigEnabled = ipPerAdapterInfo.autoconfigEnabled;
						autoConfigActive = ipPerAdapterInfo.autoconfigActive;
					}
				}
				finally
				{
					safeLocalFree?.Close();
				}
				break;
			default:
				throw new NetworkInformationException((int)perAdapterInfo);
			case 0u:
				return;
			}
		}
	}
}
