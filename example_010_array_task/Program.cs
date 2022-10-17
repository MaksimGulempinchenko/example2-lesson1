int [] array = {1,2,3,4,5,6,7,18};
int find = 18;
int index = 0;
int n = array.Length;

while(index < n )
{
    if(array[index] == find)
    {
  
    Console.WriteLine(index);
  
    }
    index++;
}
