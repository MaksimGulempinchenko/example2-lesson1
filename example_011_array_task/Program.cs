void FillArray(int[] collection) //  создается функиця с аргументом ввиде массива
{

    int lenth = collection.Length; // переменная ленс принемает количество длины массива

    int index = 0;

    while(index < lenth)
    {

        collection[index] = new Random().Next(1,10); // закладываем в массив с индексом (+1) рандомное число, с диапазлном от Next(1 до 10)
        index++;

    }
}

void PrintArray(int[] col)
{
int count = col.Length;
int position = 0;

while(position < count)
{

Console.WriteLine(col[position]);
position++;

}
}

int indexOf(int[]collection,int find) 
{

int count = collection.Length;
int index = 0;
int position = -1;  // возвращает -1 если элемент не найден

while(index < count)
{

    if(collection[index] == find)
    {
     
       position = index;
        break;            // останавливает после первого нахождения позиции    
    }

    index++;

}

return position;

}




int [] array = new int[10]; // создали массив с 10-ю позициями

FillArray(array);
PrintArray(array);
array[2] = 4;
array[5] = 4;
Console.WriteLine();
int pos = indexOf(array,45);
Console.WriteLine(pos);