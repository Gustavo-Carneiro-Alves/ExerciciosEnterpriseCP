Int32 a = 0, fib = 1;

while (fib <= 100) {
    Console.Write(a + " " + fib + " ");
    a += fib;
    fib += a;

}

