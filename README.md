# Data Structures
Some implementations of my data structures.

## Table of content
- [MyArrayList\<T>](#myarraylist)
- [MyLinkedList\<T>](#mylinkedlist)
- [MySet\<T>](#myset)
- [MyStack\<T>](#mystack)

---
### MyArrayList
[Implementation](./DataStructuresLibrary/MyArrayList.cs)

[Unit Tests](./DataStructuresTest/MyArrayListUnitTest.cs)

- **Count**
  - Returns the number of elements in the array list.
- **IsEmpty**
  - Returns a boolean value indicating whether the array list is empty.
- **Add(T? item)**
  - Adds an item to the array list.
- **Remove(T item)**
  - Removes the first occurrence of a specific item from the array list.
- **Clear()**
  - Removes all elements from the array list.
- **IndexOf(T item)**
  - Returns the index of the first occurrence of a specific item in the array list.
- **ToArray()**
  - Copies the elements of the array list to a new array.
- **this[int index]**
  - Gets or sets the element at the specified index.
- **ToString()**
  - Returns a string that represents the current array list.

---
### MyLinkedList
[Implementation](./DataStructuresLibrary/MyLinkedList.cs)

[Unit Tests](./DataStructuresTest/MyLinkedListUnitTest.cs)

- **Count**
  - Returns the number of elements in the linked list.
- **Add(T item)**
  - Adds an item to the beginning of the linked list.
- **InsertAt(int index, T item)**
  - Inserts an item at the specified index in the linked list.
- **Remove(T item)**
  - Removes the first occurrence of a specific item from the linked list.
- **RemoveAt(int index)**
  - Removes the item at the specified index from the linked list.

---
### MyStack
[Implementation](./DataStructuresLibrary/MyStack.cs)

[Unit Tests](./DataStructuresTest/MyStackUnitTest.cs)

- **Size**
  - Gets the maximum size of the stack.
- **Count**
  - Gets the number of elements in the stack.
- **MyStack(int size)**
  - Initializes a new instance of the MyStack class with the specified size.
- **Push(T item)**
  - Inserts an element at the top of the stack.
- **Pop()**
  - Removes and returns the element at the top of the stack.
- **ToArray()**
  - Returns an array containing all the elements in the stack.
- **ToString()**
  - Returns a string that represents the current stack.

---
### MySet
[Implementation](./DataStructuresLibrary/MySet.cs)

[Unit Tests](./DataStructuresTest/MySetUnitTest.cs)

- **Count**
  - Gets the number of elements in the set.
- **Add(T value)**
  - Adds a value to the set if it doesn't already exist.
- **Exists(T value)**
  - Checks whether a value exists in the set.

