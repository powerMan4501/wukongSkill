using System.CodeDom;

namespace Microsoft.VisualBasic;

internal class VBMemberAttributeConverter : VBModifierAttributeConverter
{
	private static volatile string[] names;

	private static volatile object[] values;

	private static volatile VBMemberAttributeConverter defaultConverter;

	public static VBMemberAttributeConverter Default
	{
		get
		{
			if (defaultConverter == null)
			{
				defaultConverter = new VBMemberAttributeConverter();
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
				names = new string[5] { "Public", "Protected", "Protected Friend", "Friend", "Private" };
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
				values = new object[5]
				{
					MemberAttributes.Public,
					MemberAttributes.Family,
					MemberAttributes.FamilyOrAssembly,
					MemberAttributes.Assembly,
					MemberAttributes.Private
				};
			}
			return values;
		}
	}

	protected override object DefaultValue => MemberAttributes.Private;

	private VBMemberAttributeConverter()
	{
	}
}
