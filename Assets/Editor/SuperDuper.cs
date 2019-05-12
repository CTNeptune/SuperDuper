using UnityEditor;
using UnityEngine;

public class SuperDuper : MonoBehaviour {
	[MenuItem("SuperDuper/Duplicate Under current selection %#U")]
	static void DuplicateUnderCurrent(){
		GameObject dupedObj = GameObject.Instantiate(Selection.activeTransform.gameObject);
		Undo.RegisterCreatedObjectUndo(dupedObj, "Duplicated Object");
		dupedObj.transform.SetParent(Selection.activeTransform.parent);
		dupedObj.transform.SetSiblingIndex(Selection.activeTransform.transform.GetSiblingIndex() + 1);
		dupedObj.transform.localPosition = Selection.activeTransform.transform.localPosition;
	}
	[MenuItem("SuperDuper/Duplicate Over current selection %#O")]
	static void DuplicateOverCurrent(){
		GameObject dupedObj = GameObject.Instantiate(Selection.activeTransform.gameObject);
		Undo.RegisterCreatedObjectUndo(dupedObj, "Duplicated Object");
		dupedObj.transform.SetParent(Selection.activeTransform.parent);
		dupedObj.transform.SetSiblingIndex(Selection.activeTransform.transform.GetSiblingIndex());
		dupedObj.transform.localPosition = Selection.activeTransform.transform.localPosition;
	}
	[MenuItem("SuperDuper/Duplicate current as child of selection %#H")]
	static void DuplicateAsChild(){
		GameObject dupedObj = GameObject.Instantiate(Selection.activeTransform.gameObject);
		Undo.RegisterCreatedObjectUndo(dupedObj, "Duplicated Object");
		dupedObj.transform.SetParent(Selection.activeTransform);
		dupedObj.transform.localPosition = Vector3.zero;
	}
}
