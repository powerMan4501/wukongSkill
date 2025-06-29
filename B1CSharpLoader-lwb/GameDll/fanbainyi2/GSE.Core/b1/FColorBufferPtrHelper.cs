namespace b1;

public class FColorBufferPtrHelper
{
	public unsafe static FColorBufferPtr ToPtr(void* Val)
	{
		FColorBufferPtr result = default(FColorBufferPtr);
		FColorBufferPtr* ptr = (FColorBufferPtr*)(&Val);
		result = *ptr;
		return result;
	}
}
