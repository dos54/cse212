/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: Trying to create a queue with a size less than 10
        // Expected Result: 
        Console.WriteLine("Test 1");
        var cs = new CustomerService(0);
        Console.WriteLine(cs._maxSize); //Should default to a max queue size of 10 
        // Defect(s) Found: 

        Console.WriteLine("=================");

        // Test 2
        // Scenario: Add a new customer
        // Expected Result: Display 1 customer in queue
        Console.WriteLine("Test 2");
        cs.AddNewCustomer();
        Console.WriteLine(cs.ToString());
        // Defect(s) Found: 

        Console.WriteLine("=================");

        // Test 3
        // Scenario: Customer service queue is full
        // Expected Result: Error should be displayed
        Console.WriteLine("Test 3");
        var cs3 = new CustomerService(10);
        var customer1 = new Customer("customer1", "1", "problem1");
        cs3._queue.Add(customer1);

        var customer2 = new Customer("customer2", "2", "problem2");
        cs3._queue.Add(customer2);

        var customer3 = new Customer("customer3", "3", "problem3");
        cs3._queue.Add(customer3);

        var customer4 = new Customer("customer4", "4", "problem4");
        cs3._queue.Add(customer4);

        var customer5 = new Customer("customer5", "5", "problem5");
        cs3._queue.Add(customer5);

        var customer6 = new Customer("customer6", "6", "problem6");
        cs3._queue.Add(customer6);

        var customer7 = new Customer("customer7", "7", "problem7");
        cs3._queue.Add(customer7);

        var customer8 = new Customer("customer8", "8", "problem8");
        cs3._queue.Add(customer8);

        var customer9 = new Customer("customer9", "9", "problem9");
        cs3._queue.Add(customer9);

        var customer10 = new Customer("customer10", "10", "problem10");
        cs3._queue.Add(customer10);

        Console.WriteLine(cs3.ToString());
        cs3.AddNewCustomer();
        Console.WriteLine(cs3.ToString());
        
        //Test 4
        //Scenario: ServeCustomer should dequeue the next customer and display details
        //Expected result: 
        
        // Add more Test Cases As Needed Below
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count > _maxSize) {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer() {
        _queue.RemoveAt(0);
        var customer = _queue[0];
        Console.WriteLine(customer);
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}