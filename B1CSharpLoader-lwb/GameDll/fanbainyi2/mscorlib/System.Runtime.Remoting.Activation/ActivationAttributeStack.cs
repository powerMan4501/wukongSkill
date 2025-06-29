namespace System.Runtime.Remoting.Activation;

internal class ActivationAttributeStack
{
	private object[] activationTypes;

	private object[] activationAttributes;

	private int freeIndex;

	internal ActivationAttributeStack()
	{
		activationTypes = new object[4];
		activationAttributes = new object[4];
		freeIndex = 0;
	}

	internal void Push(Type typ, object[] attr)
	{
		if (freeIndex == activationTypes.Length)
		{
			object[] destinationArray = new object[activationTypes.Length * 2];
			object[] destinationArray2 = new object[activationAttributes.Length * 2];
			Array.Copy(activationTypes, destinationArray, activationTypes.Length);
			Array.Copy(activationAttributes, destinationArray2, activationAttributes.Length);
			activationTypes = destinationArray;
			activationAttributes = destinationArray2;
		}
		activationTypes[freeIndex] = typ;
		activationAttributes[freeIndex] = attr;
		freeIndex++;
	}

	internal object[] Peek(Type typ)
	{
		if (freeIndex == 0 || activationTypes[freeIndex - 1] != typ)
		{
			return null;
		}
		return (object[])activationAttributes[freeIndex - 1];
	}

	internal void Pop(Type typ)
	{
		if (freeIndex != 0 && activationTypes[freeIndex - 1] == typ)
		{
			freeIndex--;
			activationTypes[freeIndex] = null;
			activationAttributes[freeIndex] = null;
		}
	}
}
