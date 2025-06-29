namespace System.Net.Configuration;

internal sealed class SmtpSpecifiedPickupDirectoryElementInternal
{
	private string pickupDirectoryLocation;

	internal string PickupDirectoryLocation => pickupDirectoryLocation;

	internal SmtpSpecifiedPickupDirectoryElementInternal(SmtpSpecifiedPickupDirectoryElement element)
	{
		pickupDirectoryLocation = element.PickupDirectoryLocation;
	}
}
