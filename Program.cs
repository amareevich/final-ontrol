String [] ArrayStr = ["новый", "массив", "строк", "с", "1им", "или", "до", "3ех", "символов"];
int count = 0;
int retrunLen = 2;

for (int i = 0; i <= ArrayStr.Length - 1; i++) 
{
    if (ArrayStr[i].Length - 1  <= retrunLen) 
    {
        count++;
    }
}

