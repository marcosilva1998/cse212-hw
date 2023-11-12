﻿/*
 * CSE212 
 * (c) BYU-Idaho
 * 04-Teach - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */

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
        Console.WriteLine("Test 1");
        // Scenario: The user shall specify the maximum size of the Customer Service Queue when it is created. If the size is invalid (less than or equal to 0) then the size shall default to 10.
        var proove = new CustomerService(0);
        // Expected Result: 
        Console.WriteLine($"Size should be 10: {proove}");
        
        // Defect(s) Found: 
        //No one
    
        Console.WriteLine("=================");

        // Test 2
        Console.WriteLine("Test 2");
        // Scenario: The AddNewCustomer method shall enqueue a new customer into the queue.
        proove = new CustomerService(0);
        proove.AddNewCustomer();
        proove.ServeCustomer();
        // Expected Result: The customer that was added and showed

        // Defect(s) Found: 
        //In ServeCustomer neeeds obtanin the customer values before remove it

        Console.WriteLine("=================");



        // Test 2
        Console.WriteLine("Test 2");
        // If the queue is full when trying to add a customer, then an error message will be displayed.
        proove = new CustomerService(5);
       
        proove.AddNewCustomer();
        proove.AddNewCustomer();
        proove.AddNewCustomer();
        proove.AddNewCustomer();
        proove.AddNewCustomer();
        proove.AddNewCustomer();
        // Expected Result: The error message appears

        // Defect(s) Found: 
        //In ServeCustomer neeeds obtanin the customer values before remove it

        Console.WriteLine("=================");

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
        if (_queue.Count >= _maxSize) {
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
        var customer = _queue[0];
        _queue.RemoveAt(0);
        
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
        return $"[size={_queue.Count} max_size={_maxSize} => " + String.Join(", ", _queue) + "]";
    }
}