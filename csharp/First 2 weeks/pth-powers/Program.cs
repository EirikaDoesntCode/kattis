﻿// find the largest magnitude of Pth power of a integar that is within the amount of like 32bit integars or something


using System;
//int input = int.Parse(Console.ReadLine());
//int value = 2;
float value = float.Parse(Console.ReadLine());
for (double power = 31; power >= 1; power--)

   Console.WriteLine($"{value}^{1/power} = {(float)Math.Pow(value, 1/power):N0} (0x{(float)Math.Pow(value, 1/power):X}) {power}");

// The example displays the following output:
//     2^0 = 1 (0x1)
//     2^1 = 2 (0x2)
//     2^2 = 4 (0x4)
//     2^3 = 8 (0x8)
//     2^4 = 16 (0x10)
//     2^5 = 32 (0x20)
//     2^6 = 64 (0x40)
//     2^7 = 128 (0x80)
//     2^8 = 256 (0x100)
//     2^9 = 512 (0x200)
//     2^10 = 1,024 (0x400)
//     2^11 = 2,048 (0x800)
//     2^12 = 4,096 (0x1000)
//     2^13 = 8,192 (0x2000)
//     2^14 = 16,384 (0x4000)
//     2^15 = 32,768 (0x8000)
//     2^16 = 65,536 (0x10000)
//     2^17 = 131,072 (0x20000)
//     2^18 = 262,144 (0x40000)
//     2^19 = 524,288 (0x80000)
//     2^20 = 1,048,576 (0x100000)
//     2^21 = 2,097,152 (0x200000)
//     2^22 = 4,194,304 (0x400000)
//     2^23 = 8,388,608 (0x800000)
//     2^24 = 16,777,216 (0x1000000)
//     2^25 = 33,554,432 (0x2000000)
//     2^26 = 67,108,864 (0x4000000)
//     2^27 = 134,217,728 (0x8000000)
//     2^28 = 268,435,456 (0x10000000)
//     2^29 = 536,870,912 (0x20000000)
//     2^30 = 1,073,741,824 (0x40000000)
//     2^31 = 2,147,483,648 (0x80000000)
//     2^32 = 4,294,967,296 (0x100000000)
