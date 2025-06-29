namespace b1.Util;

public class GSEMiscUtil
{
	public static void ConvIntToBool(int Val, ref bool BoolVal)
	{
		switch (Val)
		{
		case 0:
			BoolVal = false;
			break;
		case 1:
			BoolVal = true;
			break;
		default:
			BoolVal = !BoolVal;
			break;
		}
	}
}
