using System.Threading;

public class ZeroEvenOdd {
    private int n;
    private int currentNumber = 1;
    private SemaphoreSlim semaphoreZero = new SemaphoreSlim(0,1);
    private SemaphoreSlim semaphoreEven = new SemaphoreSlim(0,1);
    private SemaphoreSlim semaphoreOdd = new SemaphoreSlim(0,1);
    
    public ZeroEvenOdd(int n) {
        this.n = n;
        semaphoreZero.Release();
    }

    // printNumber(x) outputs "x", where x is an integer.
    public void Zero(Action<int> printNumber) {
        
        for (int i = 1; i <= n; i++){
            semaphoreZero.Wait();
            printNumber(0); 
            
            if(i%2 == 0) {
                semaphoreEven.Release();
            }
            else {
                semaphoreOdd.Release();  
            }
        }
            
    }

    public void Even(Action<int> printNumber) {
        while (currentNumber<n) {
            semaphoreEven.Wait();
            printNumber(currentNumber);
            currentNumber++;
            semaphoreZero.Release();
        }
    }

    public void Odd(Action<int> printNumber) {
        while (currentNumber<=n) {
            semaphoreOdd.Wait();
            printNumber(currentNumber);
            currentNumber++;
            semaphoreZero.Release();
        }
    }
}
