namespace System.Security.Cryptography.X509Certificates;

internal static class SR
{
	internal const string Argument_InvalidValue = "Value was invalid.";

	internal const string Argument_SourceOverlapsDestination = "The destination buffer overlaps the source buffer.";

	internal const string Argument_UniversalValueIsFixed = "Tags with TagClass Universal must have the appropriate TagValue value for the data type being read or written.";

	internal const string BCryptAlgorithmHandle_ProviderNotFound = "A provider could not be found for algorithm '{0}'.";

	internal const string BCryptDeriveKeyPBKDF2_Failed = "A call to BCryptDeriveKeyPBKDF2 failed with code '{0}'.";

	internal const string ContentException_CerRequiresIndefiniteLength = "A constructed tag used a definite length encoding, which is invalid for CER data. The input may be encoded with BER or DER.";

	internal const string ContentException_ConstructedEncodingRequired = "The encoded value uses a primitive encoding, which is invalid for '{0}' values.";

	internal const string ContentException_DefaultMessage = "The ASN.1 value is invalid.";

	internal const string ContentException_InvalidTag = "The provided data does not represent a valid tag.";

	internal const string ContentException_InvalidUnderCerOrDer_TryBer = "The encoded value is not valid under the selected encoding, but it may be valid under the BER encoding.";

	internal const string ContentException_InvalidUnderCer_TryBerOrDer = "The encoded value is not valid under the selected encoding, but it may be valid under the BER or DER encoding.";

	internal const string ContentException_InvalidUnderDer_TryBerOrCer = "The encoded value is not valid under the selected encoding, but it may be valid under the BER or CER encoding.";

	internal const string ContentException_LengthExceedsPayload = "The encoded length exceeds the number of bytes remaining in the input buffer.";

	internal const string ContentException_LengthRuleSetConstraint = "The encoded length is not valid under the requested encoding rules, the value may be valid under the BER encoding.";

	internal const string ContentException_LengthTooBig = "The encoded length exceeds the maximum supported by this library (Int32.MaxValue).";

	internal const string ContentException_PrimitiveEncodingRequired = "The encoded value uses a constructed encoding, which is invalid for '{0}' values.";

	internal const string ContentException_SetOfNotSorted = "The encoded set is not sorted as required by the current encoding rules. The value may be valid under the BER encoding, or you can ignore the sort validation by specifying skipSortValidation=true.";

	internal const string ContentException_TooMuchData = "The last expected value has been read, but the reader still has pending data. This value may be from a newer schema, or is corrupt.";

	internal const string ContentException_WrongTag = "The provided data is tagged with '{0}' class value '{1}', but it should have been '{2}' class value '{3}'.";

	internal const string Cryptography_AlgKdfRequiresChars = "The KDF requires a char-based password input.";

	internal const string Cryptography_Der_Invalid_Encoding = "ASN1 corrupted data.";

	internal const string Cryptography_UnknownAlgorithmIdentifier = "The algorithm is unknown, not valid for the requested usage, or was not handled.";

	internal const string Cryptography_UnknownHashAlgorithm = "'{0}' is not a known hash algorithm.";
}
