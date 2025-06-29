using System;

namespace b1;

public class FIntPtrHelper
{
	public unsafe static void* FIntPtr2VoidPtr(FIntPtr Val)
	{
		void* result = null;
		FIntPtr* ptr = &Val;
		FIntPtr* ptr2 = (FIntPtr*)(&result);
		*ptr2 = *ptr;
		return result;
	}

	public unsafe static FIntPtr VoidPtr2FIntPtr(void* Val)
	{
		FIntPtr result = default(FIntPtr);
		FIntPtr* ptr = (FIntPtr*)(&Val);
		result = *ptr;
		return result;
	}

	public unsafe static IntPtr FIntPtr2IntPtr(FIntPtr Val)
	{
		return (IntPtr)FIntPtr2VoidPtr(Val);
	}

	public unsafe static FIntPtr IntPtr2FIntPtr(IntPtr Val)
	{
		return VoidPtr2FIntPtr((void*)Val);
	}
}
