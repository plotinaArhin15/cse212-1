﻿/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
<<<<<<< HEAD
public class CustomerService
{
    public static void Run()
    {
=======
public class CustomerService {
    public static void Run() {
>>>>>>> b16ee35c239bbe20106348c5095d53a359f3b936
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 1");

        // Defect(s) Found: 

        Console.WriteLine("=================");

        // Test 2
        // Scenario: 
        // Expected Result: 
        Console.WriteLine("Test 2");

        // Defect(s) Found: 

        Console.WriteLine("=================");

        // Add more Test Cases As Needed Below
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

<<<<<<< HEAD
    public CustomerService(int maxSize)
    {
=======
    public CustomerService(int maxSize) {
>>>>>>> b16ee35c239bbe20106348c5095d53a359f3b936
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
<<<<<<< HEAD
    private class Customer
    {
        public Customer(string name, string accountId, string problem)
        {
=======
    private class Customer {
        public Customer(string name, string accountId, string problem) {
>>>>>>> b16ee35c239bbe20106348c5095d53a359f3b936
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

<<<<<<< HEAD
        public override string ToString()
        {
=======
        public override string ToString() {
>>>>>>> b16ee35c239bbe20106348c5095d53a359f3b936
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
<<<<<<< HEAD
    private void AddNewCustomer()
    {
        // Verify there is room in the service queue
        if (_queue.Count >= _maxSize)
        {
=======
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count > _maxSize) {
>>>>>>> b16ee35c239bbe20106348c5095d53a359f3b936
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
<<<<<<< HEAD
    private void ServeCustomer()
    {
        if (_queue.Count == 0)
        {
            Console.WriteLine("No customers in queue.");
            return;
        }
        var customer = _queue[0];
        Console.WriteLine(customer);
        _queue.RemoveAt(0);
=======
    private void ServeCustomer() {
        _queue.RemoveAt(0);
        var customer = _queue[0];
        Console.WriteLine(customer);
>>>>>>> b16ee35c239bbe20106348c5095d53a359f3b936
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
<<<<<<< HEAD
    public override string ToString()
    {
=======
    public override string ToString() {
>>>>>>> b16ee35c239bbe20106348c5095d53a359f3b936
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}