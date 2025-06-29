using System;

namespace b1.ECS.Test;

internal class TestDataSafe : IEntitySafeData
{
	private unsafe TestData* Target;

	public unsafe int Data
	{
		get
		{
			return Target->Data;
		}
		set
		{
			Target->Data = value;
		}
	}

	public unsafe void SetPtr(IntPtr Ptr)
	{
		Target = (TestData*)(void*)Ptr;
	}
}
