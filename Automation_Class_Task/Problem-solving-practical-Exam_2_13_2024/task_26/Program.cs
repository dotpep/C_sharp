// 26.	Напишите функцию, которая преобразует целое число в двоичную систему.

// similiar to task 8


const int bite = 1;         // 2^7, 2^6, 2^5, 2^4, 2^3, 2^2, 2^1, 2^0
const int byte_size = bite * 8;  // 128, 64, 32, 16, 8, 4, 2, 1
byte[] binary_num = new byte[byte_size] { 1, 0, 1, 0, 0, 0, 0, 0 }; // 0...255

byte[] binary_calc = new byte[byte_size] { 128, 64, 32, 16, 8, 4, 2, 1 };


byte converted_num = 0;

//for (int i = 0; i < byte_size; i++)
//{
//	if (binary_num[i] == 1)
//	{
//        converted_num += binary_calc[i];
//    }
//}

//for (int i = 0; i < byte_size; i++)
//{                                       // 2^7 == 128, 2^8 == 256
//                                        // first element i0(1) * 2^8 - i0 - 1        // byte_size - 1 == 7 - i0 == 7 | 7 - i1 == 6
//    converted_num += (byte)(binary_num[i] * Math.Pow(2, byte_size - i - 1));
//    // При каждой итерации умножаем значение элемента на 2 в степени его индекса и добавляем к converted_num
//}

static byte ConvertBinary(byte[] binary_num, int iter)
{               // 2^7 == 128, 2^8 == 256
                        // first element i0(1) * 2^8 - i0 - 1        // byte_size - 1 == 7 - i0 == 7 | 7 - i1 == 6
    return (byte)(binary_num[iter] * Math.Pow(2, byte_size - iter - 1));
    // При каждой итерации умножаем значение элемента на 2 в степени его индекса и добавляем к converted_num
}


for (int i = 0; i < byte_size; i++)
{
    converted_num += ConvertBinary(binary_num, i);
}

Console.WriteLine(converted_num);