using System.Threading;

public class Foo {
    
    static SemaphoreSlim semaphore1 = new SemaphoreSlim(0,1);
    static SemaphoreSlim semaphore2 = new SemaphoreSlim(0,1);
    static SemaphoreSlim semaphore3 = new SemaphoreSlim(0,1);

    public Foo() {
        semaphore1.Release();
    }

    public void First(Action printFirst) {
        
        semaphore1.Wait();
            
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        semaphore2.Release();
    }

    public void Second(Action printSecond) {
        
        semaphore2.Wait();
        // printSecond() outputs "second". Do not change or remove this line.
        printSecond();
        semaphore3.Release();
    }

    public void Third(Action printThird) {
        
        semaphore3.Wait();
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
    }
}
