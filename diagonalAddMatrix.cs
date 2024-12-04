using System;

class HelloWorld {
    static void Main() {
        int[,] arr = {
            {1, 2, 3},
            {3, 4, 5},
            {2, 3, 5}
        };

        int len = arr.GetLength(0); 
        int total = 0;

        for (int i = 0; i < len; i++) {
            for (int j = 0; j < len; j++) {
                if (i == j) {
                    total += arr[i, j]; 
                }
            }
        }

        Console.Write(total);
    }
}

