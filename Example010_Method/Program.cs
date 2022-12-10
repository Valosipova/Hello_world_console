int[] array = {11, 22, 13, 41, 8, 15, 61, 17, 8};

int n = array.Length;

int find = 61;

int index = 0;

while (index < n)

{
    
    if (array [index] == find)
    {
       Console.WriteLine(index); 
       break;
    }

    //index=index+1;
    index++;
}