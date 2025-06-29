using System.Reflection;

namespace Microsoft.VisualBasic;

internal class VBTypeAttributeConverter : VBModifierAttributeConverter
{
	private static volatile VBTypeAttributeConverter defaultConverter;

	private static volatile string[] names;

	private static volatile object[] values;

	public static VBTypeAttributeConverter Default
	{
		get
		{
			if (defaultConverter == null)
			{
				defaultConverter = new VBTypeAttributeConverter();
			}
			return defaultConverter;
		}
	}

	protected override string[] Names
	{
		get
		{
			if (names == null)
			{
				names = new string[2] { "Public", "Friend" };
			}
			return names;
		}
	}

	protected override object[] Values
	{
		get
		{
			if (values == null)
			{
				values = new object[2]
				{
					TypeAttributes.Public,
					TypeAttributes.NotPublic
				};
			}
			return values;
		}
	}

	protected override object DefaultValue => TypeAttributes.Public;

	private VBTypeAttributeConverter()
	{
	}
}
