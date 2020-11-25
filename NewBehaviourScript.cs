using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    /*
    Метод получает в качестве аргументов два массива типа GameObject[]:
    1. Массив произвольного размера. ЛЮБОЙ элемент массива может содержать ссылку на Game Object или null.
    2. Массив произвольного размера, заполненный ссылками на GameObject.
    Задание:
    Разместить в СВОБОДНЫХ (содержащих null) элементах первого массива В СЛУЧАЙНОМ ПОРЯДКЕ ссылки на Game Object из второго массива.
    Оговорим условия, относящиеся к случайному порядку:
    Если объектов из второго массива НЕ ХВАТАЕТ для заполнения всех свободных элементов первого массива, часть элементов первого массива
    остается СВОБОДНЫМИ. Не должно быть так, чтобы сначала заполнялись, скажем, первые по порядку свободные элементы, т.е. не должно быть
    известно заранее, какие элементы окажутся заполнены, а какие останутся пустыми.
    Если объектов из второго массива БОЛЬШЕ, чем свободных элементов в первом массиве, часть объектов из второго массива НЕ РАЗМЕЩАЕТСЯ.
    Не должно быть так, чтобы сначала размещались первые по порядку объекты из второго массива, т.е. в этом случае не должно быть известно
    заранее, какие элементы из второго массива окажутся размещены.
    */

    public void Metod(GameObject[] arreyQ, GameObject[] arreyT)
    {
        List<int> listNull = new List<int>();
        List<GameObject> listAdd = new List<GameObject>(arreyT);

        for(int i = 0; i < arreyQ.Length; ++i)
        {
            if (arreyQ[i] != null) continue;

            listNull.Add(i);
        }

        for (int i = 0; i < arreyT.Length; ++i)
        {
            int num = Random.Range(0, listNull.Count);
            int add = Random.Range(0, listAdd.Count);
            arreyQ[listNull[num]] = listAdd[add];
            listNull.RemoveAt(num);
            listAdd.RemoveAt(add);

            if (listNull.Count == 0) break;
        }
    }
}
