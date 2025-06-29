using System.ComponentModel;
using System.Security;
using System.Text;

namespace System;

[EditorBrowsable(EditorBrowsableState.Never)]
public static class StringNormalizationExtensions
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static bool IsNormalized(this string value)
	{
		return value.IsNormalized(NormalizationForm.FormC);
	}

	[SecurityCritical]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static bool IsNormalized(this string value, NormalizationForm normalizationForm)
	{
		return value.IsNormalized(normalizationForm);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static string Normalize(this string value)
	{
		return value.Normalize(NormalizationForm.FormC);
	}

	[SecurityCritical]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static string Normalize(this string value, NormalizationForm normalizationForm)
	{
		return value.Normalize(normalizationForm);
	}
}
