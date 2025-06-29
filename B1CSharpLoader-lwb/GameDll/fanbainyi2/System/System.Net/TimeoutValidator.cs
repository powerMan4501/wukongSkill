using System.Configuration;

namespace System.Net;

internal sealed class TimeoutValidator : ConfigurationValidatorBase
{
	private bool _zeroValid;

	internal TimeoutValidator(bool zeroValid)
	{
		_zeroValid = zeroValid;
	}

	public override bool CanValidate(Type type)
	{
		if (!(type == typeof(int)))
		{
			return type == typeof(long);
		}
		return true;
	}

	public override void Validate(object value)
	{
		if (value != null)
		{
			int num = (int)value;
			if ((!_zeroValid || num != 0) && num <= 0 && num != -1)
			{
				throw new ConfigurationErrorsException(SR.GetString("net_io_timeout_use_gt_zero"));
			}
		}
	}
}
