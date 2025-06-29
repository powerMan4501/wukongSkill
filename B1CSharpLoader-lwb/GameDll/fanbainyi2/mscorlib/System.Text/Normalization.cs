using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Text;

internal class Normalization
{
	private static volatile bool NFC;

	private static volatile bool NFD;

	private static volatile bool NFKC;

	private static volatile bool NFKD;

	private static volatile bool IDNA;

	private static volatile bool NFCDisallowUnassigned;

	private static volatile bool NFDDisallowUnassigned;

	private static volatile bool NFKCDisallowUnassigned;

	private static volatile bool NFKDDisallowUnassigned;

	private static volatile bool IDNADisallowUnassigned;

	private static volatile bool Other;

	private const int ERROR_SUCCESS = 0;

	private const int ERROR_NOT_ENOUGH_MEMORY = 8;

	private const int ERROR_INVALID_PARAMETER = 87;

	private const int ERROR_INSUFFICIENT_BUFFER = 122;

	private const int ERROR_NO_UNICODE_TRANSLATION = 1113;

	[SecurityCritical]
	private unsafe static void InitializeForm(NormalizationForm form, string strDataFile)
	{
		byte* ptr = null;
		if (!Environment.IsWindows8OrAbove)
		{
			if (strDataFile == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidNormalizationForm"));
			}
			ptr = GlobalizationAssembly.GetGlobalizationResourceBytePtr(typeof(Normalization).Assembly, strDataFile);
			if (ptr == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidNormalizationForm"));
			}
		}
		nativeNormalizationInitNormalization(form, ptr);
	}

	[SecurityCritical]
	private static void EnsureInitialized(NormalizationForm form)
	{
		switch ((ExtendedNormalizationForms)form)
		{
		case ExtendedNormalizationForms.FormC:
			if (!NFC)
			{
				InitializeForm(form, "normnfc.nlp");
				NFC = true;
			}
			break;
		case ExtendedNormalizationForms.FormD:
			if (!NFD)
			{
				InitializeForm(form, "normnfd.nlp");
				NFD = true;
			}
			break;
		case ExtendedNormalizationForms.FormKC:
			if (!NFKC)
			{
				InitializeForm(form, "normnfkc.nlp");
				NFKC = true;
			}
			break;
		case ExtendedNormalizationForms.FormKD:
			if (!NFKD)
			{
				InitializeForm(form, "normnfkd.nlp");
				NFKD = true;
			}
			break;
		case ExtendedNormalizationForms.FormIdna:
			if (!IDNA)
			{
				InitializeForm(form, "normidna.nlp");
				IDNA = true;
			}
			break;
		case ExtendedNormalizationForms.FormCDisallowUnassigned:
			if (!NFCDisallowUnassigned)
			{
				InitializeForm(form, "normnfc.nlp");
				NFCDisallowUnassigned = true;
			}
			break;
		case ExtendedNormalizationForms.FormDDisallowUnassigned:
			if (!NFDDisallowUnassigned)
			{
				InitializeForm(form, "normnfd.nlp");
				NFDDisallowUnassigned = true;
			}
			break;
		case ExtendedNormalizationForms.FormKCDisallowUnassigned:
			if (!NFKCDisallowUnassigned)
			{
				InitializeForm(form, "normnfkc.nlp");
				NFKCDisallowUnassigned = true;
			}
			break;
		case ExtendedNormalizationForms.FormKDDisallowUnassigned:
			if (!NFKDDisallowUnassigned)
			{
				InitializeForm(form, "normnfkd.nlp");
				NFKDDisallowUnassigned = true;
			}
			break;
		case ExtendedNormalizationForms.FormIdnaDisallowUnassigned:
			if (!IDNADisallowUnassigned)
			{
				InitializeForm(form, "normidna.nlp");
				IDNADisallowUnassigned = true;
			}
			break;
		default:
			if (!Other)
			{
				InitializeForm(form, null);
				Other = true;
			}
			break;
		}
	}

	[SecurityCritical]
	internal static bool IsNormalized(string strInput, NormalizationForm normForm)
	{
		EnsureInitialized(normForm);
		int iError = 0;
		bool result = nativeNormalizationIsNormalizedString(normForm, ref iError, strInput, strInput.Length);
		switch (iError)
		{
		case 87:
		case 1113:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidCharSequenceNoIndex"), "strInput");
		case 8:
			throw new OutOfMemoryException(Environment.GetResourceString("Arg_OutOfMemoryException"));
		default:
			throw new InvalidOperationException(Environment.GetResourceString("UnknownError_Num", iError));
		case 0:
			return result;
		}
	}

	[SecurityCritical]
	internal static string Normalize(string strInput, NormalizationForm normForm)
	{
		EnsureInitialized(normForm);
		int iError = 0;
		int num = nativeNormalizationNormalizeString(normForm, ref iError, strInput, strInput.Length, null, 0);
		switch (iError)
		{
		case 87:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidCharSequenceNoIndex"), "strInput");
		case 8:
			throw new OutOfMemoryException(Environment.GetResourceString("Arg_OutOfMemoryException"));
		default:
			throw new InvalidOperationException(Environment.GetResourceString("UnknownError_Num", iError));
		case 0:
		{
			if (num == 0)
			{
				return string.Empty;
			}
			char[] array = null;
			while (true)
			{
				array = new char[num];
				num = nativeNormalizationNormalizeString(normForm, ref iError, strInput, strInput.Length, array, array.Length);
				switch (iError)
				{
				case 122:
					break;
				case 87:
				case 1113:
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidCharSequence", num), "strInput");
				case 8:
					throw new OutOfMemoryException(Environment.GetResourceString("Arg_OutOfMemoryException"));
				default:
					throw new InvalidOperationException(Environment.GetResourceString("UnknownError_Num", iError));
				case 0:
					return new string(array, 0, num);
				}
			}
		}
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern int nativeNormalizationNormalizeString(NormalizationForm normForm, ref int iError, string lpSrcString, int cwSrcLength, char[] lpDstString, int cwDstLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool nativeNormalizationIsNormalizedString(NormalizationForm normForm, ref int iError, string lpString, int cwLength);

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern void nativeNormalizationInitNormalization(NormalizationForm normForm, byte* pTableData);
}
