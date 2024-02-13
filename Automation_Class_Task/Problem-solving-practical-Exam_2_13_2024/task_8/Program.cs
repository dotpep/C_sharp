// 8.	Двоичная система счета имеет последовательность из 0 и 1 цифр.
// Напишите программу для преобразования этого числа в десятичную систему.

// similiar to task 26

// степень это умножение на самого себя то есть если 2^2 == 4 тогда 2^3 = 4 * 2 = 8
// если 2^5 == 32 тогда 2^6 = 32 * 2 = 64

const int bite = 1;         // 2^7, 2^6, 2^5, 2^4, 2^3, 2^2, 2^1, 2^0
const int byte_size = bite * 8;  // 128, 64, 32, 16, 8, 4, 2, 1
byte[] binary_num = new byte[byte_size] { 1, 0, 1, 0, 0, 0, 0, 0}; // 0...255

byte[] binary_calc = new byte[byte_size] { 128, 64, 32, 16, 8, 4, 2, 1 };


byte converted_num = 0;

//for (int i = 0; i < byte_size; i++)
//{
//	if (binary_num[i] == 1)
//	{
//        converted_num += binary_calc[i];
//    }
//}

for (int i = 0; i < byte_size; i++)
{                                       // 2^7 == 128, 2^8 == 256
            // first element i0(1) * 2^8 - i0 - 1        // byte_size - 1 == 7 - i0 == 7 | 7 - i1 == 6
    converted_num += (byte)(binary_num[i] * Math.Pow(2, byte_size - i - 1));
    // При каждой итерации умножаем значение элемента на 2 в степени его индекса и добавляем к converted_num
}

Console.WriteLine(converted_num);
