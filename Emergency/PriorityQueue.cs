using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency
{

    class PriorityQueue
    {
        private int _numItems;
        private Heap _items;
        private int _maxItems;

        public PriorityQueue(int max)
        {
            _maxItems = max;
            _items = new Heap(max);
            _numItems = 0;
        }
        public void MakeEmpty()
        {
            _numItems = 0;
        }
        public bool IsEmpty()
        {
            return _numItems == 0;
        }
        public bool IsFull()
        {
            return _numItems == _maxItems;
        }
        public void Enqueue(Patient newPatient)
        {
            _numItems++;
            _items.elements.Add(newPatient);
            _items.ReheapUp(0, _numItems - 1);
            _items.HeapSort(_items.elements, _numItems);

        }
        public void Dequeue(Patient patient)
        {
            patient.Name = _items.elements[0].Name;
            patient.Condition = _items.elements[0].Condition;
            _items.elements[0] = _items.elements[_numItems - 1];
            _items.elements.RemoveAt(_numItems - 1);
            _numItems--;

            _items.ReheapDown(0, _numItems - 1);
            _items.HeapSort(_items.elements, _numItems);
        }
        public List<string> Print()
        {
            return _items.PrintHeap(_numItems);
        }
        public int NumItems { get { return _numItems; } }
    }


    struct Heap
    {
        public List<Patient> elements;
        //int numElements;

        public Heap(int maxItems)
        {
            elements = new List<Patient>(maxItems);
        }

        public void ReheapDown(int root, int bottom)
        {
            int maxChild, rightChild, leftChild;
            leftChild = root * 2 + 1;
            rightChild = root * 2 + 2;

            if (leftChild <= bottom)
            {
                if (leftChild == bottom)
                    maxChild = leftChild;
                else
                {
                    if (elements[leftChild] < elements[rightChild])
                        maxChild = rightChild;
                    else if (elements[rightChild] == elements[leftChild])
                    {
                        if (elements[rightChild].PatientID < elements[leftChild].PatientID)
                            maxChild = rightChild;
                        else
                            maxChild = leftChild;
                    }
                    else
                        maxChild = leftChild;
                }
                if (elements[root] <= elements[maxChild])
                {
                    var tempRoot = elements[root];
                    var tempChild = elements[maxChild];
                    Swap(ref tempRoot, ref tempChild);
                    elements[root] = tempRoot;
                    elements[maxChild] = tempChild;
                    ReheapDown(maxChild, bottom);
                }
                //else if (elements[root] == elements[maxChild])
                //{
                //    if(elements[root].PatientID < elements[max])
                //}
            }
        }

        public void ReheapUp(int root, int bottom)
        {
            int parent;
            if (bottom > root)
            {
                parent = (bottom - 1) / 2;
                if (elements[parent] < elements[bottom])
                {
                    var tempParent = elements[parent];
                    var tempBottom = elements[bottom];
                    Swap(ref tempParent, ref tempBottom);
                    elements[parent] = tempParent;
                    elements[bottom] = tempBottom;
                    ReheapUp(root, parent);
                }
            }
        }
        private void Swap<T>(ref T element1, ref T element2)
        {
            T temp;
            temp = element1;
            element1 = element2;
            element2 = temp;
        }
        public List<string> PrintHeap(int items)
        {
            List<string> patients = new List<string>();
            string str = "";
            for (int i = 0; i < items; i++)
            {
                str = String.Format("{0,10}              {1,-30}", elements[i].Condition, elements[i].Name);
                patients.Add(str);
            }
            return patients;
        }

        public void HeapSort(List<Patient> el, int numElem)
        {
            List<Patient> newList = new List<Patient>(numElem);
            if (numElem > 2)
            {
                for (int index = numElem - 1; index >= 1; index--)
                {
                    var val0 = el[0];
                    var valIndex = el[index];
                    if ((val0 != valIndex) || (val0.PatientID < valIndex.PatientID))
                    {
                        Swap(ref val0, ref valIndex);
                        el[0] = val0;
                        el[index] = valIndex;
                    }
                    newList.Add(valIndex);
                    ReheapDown(0, index - 1);
                }
                newList.Add(el[0]);
                for (int i = 0; i < numElem; i++)
                {
                    elements[i] = newList[i];
                }
            }

        }
    }
}
