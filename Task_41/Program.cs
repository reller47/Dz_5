Console.Write("Сколько чисел вы хотите ввести = ");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;
double[] array = new double[m];
for(int i = 0; i < m; i++){
    Console.WriteLine("Введите число " + (i + 1));
    array[i] = Convert.ToDouble(Console.ReadLine());
    if(array[i] > 0){
        count++;
    }
}
Console.WriteLine("Чисел больше нуля = " + count);