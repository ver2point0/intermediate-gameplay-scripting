﻿using UnityEngine;
using System.Collections;

public class GenericClass<T> {

	T item;

	public void UpdateItem(T newItem) {
		item = newItem;
	}
}
