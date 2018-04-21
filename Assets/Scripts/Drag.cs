using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Drag : MonoBehaviour,IDragHandler,IBeginDragHandler,IEndDragHandler {
	private Image image;
	float distance=10f;
	private void Awake(){
		image = GetComponent<Image> ();
	}
	public void OnBeginDrag(PointerEventData eventdata){
		image.color = Color.grey;
	}
	public void OnDrag(PointerEventData eventData){
		transform.position = eventData.position;
	}
	public void OnEndDrag(PointerEventData eventdata){
		image.color = Color.white;
	}

}
