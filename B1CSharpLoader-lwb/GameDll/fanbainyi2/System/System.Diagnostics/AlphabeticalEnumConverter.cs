using System.Collections;
using System.ComponentModel;

namespace System.Diagnostics;

internal class AlphabeticalEnumConverter : EnumConverter
{
	public AlphabeticalEnumConverter(Type type)
		: base(type)
	{
	}

	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
	{
		if (base.Values == null)
		{
			Array array = Enum.GetValues(base.EnumType);
			object[] array2 = new object[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = ConvertTo(context, null, array.GetValue(i), typeof(string));
			}
			Array.Sort(array2, array, 0, array.Length, System.Collections.Comparer.Default);
			base.Values = new StandardValuesCollection(array);
		}
		return base.Values;
	}
}
