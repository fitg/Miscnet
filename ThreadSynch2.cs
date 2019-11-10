using System.Threading;

public class FooBar {
    private int n;
    static SemaphoreSlim semaphore1 = new SemaphoreSlim(0,1);
    static SemaphoreSlim semaphore2 = new SemaphoreSlim(0,1);

    public FooBar(int n) {
        this.n = n;
        semaphore1.Release();
    }

    public void Foo(Action printFoo) {
                
        for (int i = 0; i < n; i++) {
            semaphore1.Wait();
        	// printFoo() outputs "foo". Do not change or remove this line.
        	printFoo();
            semaphore2.Release();
        }
    }

    public void Bar(Action printBar) {
        
        for (int i = 0; i < n; i++) {
            semaphore2.Wait();
            // printBar() outputs "bar". Do not change or remove this line.
        	printBar();
            semaphore1.Release();
        }
    }
}
