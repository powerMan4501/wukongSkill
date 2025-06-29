using System.Collections;
using System.Runtime.InteropServices;

namespace System.ComponentModel.Design;

[ComVisible(true)]
public interface ISelectionService
{
	object PrimarySelection { get; }

	int SelectionCount { get; }

	event EventHandler SelectionChanged;

	event EventHandler SelectionChanging;

	bool GetComponentSelected(object component);

	ICollection GetSelectedComponents();

	void SetSelectedComponents(ICollection components);

	void SetSelectedComponents(ICollection components, SelectionTypes selectionType);
}
