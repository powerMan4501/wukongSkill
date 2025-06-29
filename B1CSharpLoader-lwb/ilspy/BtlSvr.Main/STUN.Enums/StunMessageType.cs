namespace STUN.Enums;

public enum StunMessageType : ushort
{
	BindingRequest = 1,
	BindingResponse = 257,
	BindingErrorResponse = 273,
	SharedSecretRequest = 2,
	SharedSecretResponse = 258,
	SharedSecretErrorResponse = 274
}
