namespace System.Net;

internal class SpnToken
{
	private readonly string spn;

	private bool isTrusted;

	internal bool IsTrusted
	{
		get
		{
			return isTrusted;
		}
		set
		{
			isTrusted = false;
		}
	}

	internal string Spn => spn;

	internal SpnToken(string spn)
		: this(spn, trusted: true)
	{
	}

	internal SpnToken(string spn, bool trusted)
	{
		this.spn = spn;
		isTrusted = trusted;
	}
}
